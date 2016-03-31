using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using SRS.DeskApp.Context;
using Equin.ApplicationFramework;
using System.Data.Entity.SqlServer;
using SAPbobsCOM;
using MetroFramework;


namespace SRS.DeskApp
{
    public partial class FrmTransGrPo : MetroForm
    {
        SRSEntities ptn = new SRSEntities();
        Sap saExport = new Sap();

        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        CheckBox HeaderCheckBox = null;

        bool IsHeaderCheckBoxClicked = false;

        public FrmTransGrPo()
        {
            InitializeComponent();
        }

        private void FrmTransGrPo_Load(object sender, EventArgs e)
        {
            BindGrid();
            AddHeaderCheckBox();

            HeaderCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            GrdList.CellValueChanged += new DataGridViewCellEventHandler(dgvSelectAll_CellValueChanged);
            GrdList.CurrentCellDirtyStateChanged += new EventHandler(dgvSelectAll_CurrentCellDirtyStateChanged);
            GrdList.CellPainting += new DataGridViewCellPaintingEventHandler(dgvSelectAll_CellPainting);
            
            saExport.ConnectServer();
        }
        private void dgvSelectAll_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }
        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            //Get the column header cell bounds
            Rectangle oRectangle = this.GrdList.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPoint = new Point();

            oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2 + 1;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2 + 1;

            //Change the location of the CheckBox to make it stay on the header
            HeaderCheckBox.Location = oPoint;
        }
        private void dgvSelectAll_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (GrdList.CurrentCell is DataGridViewCheckBoxCell)
                GrdList.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvSelectAll_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsHeaderCheckBoxClicked)
                RowCheckBoxClick((DataGridViewCheckBoxCell)GrdList[e.ColumnIndex, e.RowIndex]);
        }
        private void RowCheckBoxClick(DataGridViewCheckBoxCell RCheckBox)
        {
            if (RCheckBox != null)
            {
                //Modifiy Counter;            
                if ((bool)RCheckBox.Value && TotalCheckedCheckBoxes < TotalCheckBoxes)
                    TotalCheckedCheckBoxes++;
                else if (TotalCheckedCheckBoxes > 0)
                    TotalCheckedCheckBoxes--;

                //Change state of the header CheckBox.
                if (TotalCheckedCheckBoxes < TotalCheckBoxes)
                    HeaderCheckBox.Checked = false;
                else if (TotalCheckedCheckBoxes == TotalCheckBoxes)
                    HeaderCheckBox.Checked = true;
            }
        }
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void HeaderCheckBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                HeaderCheckBoxClick((CheckBox)sender);
        }


        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();

            HeaderCheckBox.Size = new Size(15, 15);


            this.GrdList.Controls.Add(HeaderCheckBox);
        }
        private void BindGrid(  )
        {

            //var showPtn = (from lc in ptn.spLoadCicilan() 
            //               where lc.jenis_mitra == jenisMitra
            //               select new
            //               {
            //                   BASE = lc.base_entry,
            //                   KODE = lc.kode_mitra,
            //                   NAMA = lc.nama_mitra,
            //                   QUANTITY = lc.net_weight ?? 0,
            //                   NO_REK = lc.no_rek,
            //                   HARGA = lc.harga,                              
            //                   TANGGAL = lc.date_out
            //               }).ToList();

            
            var showTransitTimbangan = (from tt in ptn.tbl_transit_timbangan
                                        join tpm in ptn.tbl_pendaftaran_mobil on tt.base_entry equals tpm.doc_entry
                                        join ml2 in ptn.Masterlist2 on tpm.card_code equals ml2.kode_mitra
                                        join tcs in ptn.tbl_transit_core_sampling on tpm.doc_entry equals tcs.base_entry
                                        where ((tcs.grkey == null || tcs.invoicekey == null)
                                            || (tcs.grkey == "" || tcs.invoicekey == ""))
                                            && ((tt.date_out.Value.Year == DateTime.Now.Year) && (tt.date_out.Value.Month == DateTime.Now.Month) && (tt.date_out.Value.Day >= DateTime.Now.Day))
                                        select new 
                                          {
                                            BASE =  tt.base_entry,
                                            KODE = tpm.card_code,
                                            NAMA = tpm.card_name,
                                            NO_REK = ml2.no_rek,
                                            BERAT_BERSIH = tt.net_weight,
                                            RENDEMEN = tcs.rendemen_nir,
                                            HARGA = tcs.harga,
                                            TANGGAL = tt.date_out,
                                            DOC_ENTRY = tcs.doc_entry
                                          }
                                         ).Distinct().ToList();

            GrdList.DataSource = showTransitTimbangan;
            
            //GrdList.Columns["BASE"].Visible = false;
            //GrdList.Columns["TANGGAL"].Visible = false;
            //GrdList.Columns["DOC_ENTRY"].Visible = false;

            TotalCheckBoxes = GrdList.RowCount;
            TotalCheckedCheckBoxes = 0;

        }
        
        private String invCode;
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            
            var qry = from t in ptn.trans_data_type
                      select t;
            var jml = qry.Count();

            var rsInvent = from i in ptn.m_conf_acc
                           select i.inv_code;
            foreach (String  item in rsInvent)
            {
                invCode = item;
            }
            
            if (jml > 0)

                if (jml > 0)
                {
                    foreach (DataGridViewRow Row in GrdList.Rows)
                    {
                        int base_entry;
                        String kode;
                        String nama;
                        Decimal quantity;
                        Decimal harga;
                        DateTime tanggal;
                        Int32 doc_entry;

                        if (Convert.ToBoolean(Row.Cells["chkBxSelect"].Value))
                        {
                            base_entry = Convert.ToInt32 ( Row.Cells[1].Value ) ;
                            kode = Row.Cells[2].Value.ToString() ?? string.Empty;
                            nama = Row.Cells[3].Value.ToString() ?? string.Empty;
                            
                            quantity = Convert.ToDecimal ( Row.Cells[4].Value ) ;
                            harga = Convert.ToDecimal(Row.Cells[6].Value);   //Row.Cells[5].Value.ToString() ?? string.Empty;
                            tanggal = Convert.ToDateTime(Row.Cells[7].Value);
                            doc_entry = Convert.ToInt32( Row.Cells[8].Value) ;    
                      
                            int tgl = tanggal.Date.Day;
                            int bln = tanggal.Date.Month;
                            int thn = tanggal.Date.Year;

                            String jatuhTempo;

                            if (tgl >0 && tgl <=7)
                            {
                                jatuhTempo = bln + "/10/" + thn; //tanggal.AddDays(3) ;
                                Console.WriteLine(jatuhTempo);
                            }
                            else if (tgl >= 8 && tgl <= 14)
                            {
                                jatuhTempo = bln + "/17/" + thn;
                            }
                            else if (tgl >= 15 && tgl <= 21)
                            {
                                jatuhTempo = bln + "/24/" + thn;
                            }
                            else
                            {                              
                                jatuhTempo = bln + "/" + Convert.ToString(DateTime.DaysInMonth(thn, bln)) + "/" + thn; 
                                tanggal = Convert.ToDateTime( jatuhTempo) ;
                                tanggal = tanggal.AddDays(3);
                                jatuhTempo = tanggal.ToString();
                            }

                            if (quantity < 1)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Quantity tidak boleh kosong", "Error", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            { 
                                saExport.saveAPInvoice(doc_entry,  base_entry, kode, DateTime.Now,
                                    Convert.ToDateTime ( jatuhTempo ) , this.invCode  , quantity, harga);
                            }

                            //===========================================================================INI BUAT SIMPAN HEADER & LINE
                            //if ( quantity > 0 )
                            //{
                            //    using (var context = new SRSEntities())
                            //    {
                            //        context.spInsertTrans("cicil", kode, tanggal,
                            //        "", 1, "", harga, Convert.ToString( base_entry) );

                            //        context.SaveChanges();

                            //    }
                            //    saExport.saveAPInvoice(base_entry, kode, DateTime.Now,
                            //        Convert.ToDateTime ( jatuhTempo ) , this.invCode  , quantity, harga);
                            //}
                            //else
                            //{
                            //    MetroFramework.MetroMessageBox.Show(this,
                            //        "Tidak dapat diproses karena berat/quantity < 1", "Informasi", MessageBoxButtons.OK);
                            //}
                            //==================================================================================================== AKHIR HEADER & LINE

                        }
                        
                    }
                    MetroFramework.MetroMessageBox.Show(this, "Data berhasil disimpan", "Informasi", MessageBoxButtons.OK);
                    BindGrid();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Tabel Type transaksi masih kosong", "Informasi", MessageBoxButtons.OK);
                }
        }
        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            IsHeaderCheckBoxClicked = true;

            foreach (DataGridViewRow Row in GrdList.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["chkBxSelect"]).Value = HCheckBox.Checked;
            GrdList.RefreshEdit();

            TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

            IsHeaderCheckBoxClicked = false;
        }

        private void rdMandiri_Click(object sender, EventArgs e)
        {
            if (rdMandiri.Checked)
            {
                BindGrid();
            }
        }

        private void rdKKPE_Click(object sender, EventArgs e)
        {
            if (rdKKPE.Checked)
            {
                BindGrid();    
            }
            
        }

        private void rdOwn_Click(object sender, EventArgs e)
        {
            if (rdOwn.Checked)
            {
                BindGrid();    
            }
            
        }
    }
}
