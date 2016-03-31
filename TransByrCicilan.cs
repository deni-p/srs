using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRS.DeskApp.Context;
using Equin.ApplicationFramework;
using System.Data.Entity.SqlServer;
using SAPbobsCOM;

namespace SRS.DeskApp
{
    public partial class TransGr : MetroForm
    {
        
        SRSEntities ptn = new SRSEntities();
        Sap saExport = new Sap();
        

        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        CheckBox HeaderCheckBox = null;
        
        bool IsHeaderCheckBoxClicked = false;

        public TransGr()
        {
            InitializeComponent();
        }

        private void TransByrCicilan_Load(object sender, EventArgs e)
        {
            saExport.ConnectServer();
            BindGrid();
            AddHeaderCheckBox();

            HeaderCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            GridList.CellValueChanged+= new DataGridViewCellEventHandler(dgvSelectAll_CellValueChanged);
            GridList.CurrentCellDirtyStateChanged += new EventHandler(dgvSelectAll_CurrentCellDirtyStateChanged);
            GridList.CellPainting+= new DataGridViewCellPaintingEventHandler(dgvSelectAll_CellPainting);
                      
        }

        private void dgvSelectAll_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }
        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            //Get the column header cell bounds
            Rectangle oRectangle = this.GridList.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPoint = new Point();

            oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2 + 1;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2 + 1;

            //Change the location of the CheckBox to make it stay on the header
            HeaderCheckBox.Location = oPoint;
        }
        private void dgvSelectAll_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if ( GridList.CurrentCell  is DataGridViewCheckBoxCell)
               GridList.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvSelectAll_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsHeaderCheckBoxClicked)
                RowCheckBoxClick((DataGridViewCheckBoxCell) GridList[e.ColumnIndex, e.RowIndex]);
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

            
            this.GridList.Controls.Add(HeaderCheckBox);
        }
        private void BindGrid()
        {
            try
            {
                var showptn = (from lc in ptn.spLoadBayarAll()
                               select new
                               {
                                   BASE = lc.base_entry,
                                   KODE = lc.card_code,
                                   NAMA = lc.card_name,
                                   BERAT = lc.net_weight,
                                   PEMBAYARAN = lc.pembayaran,
                                   TANGGAL = lc.create_date,
                                   INVOICE = lc.invoicekey,
                                   JENIS = lc.jenis_mitra
                               }).ToList();

                //var showBayar = ( from tcs in ptn.tbl_transit_core_sampling
                //                   join ttt in ptn.tbl_transit_timbangan on tcs.base_entry equals ttt.base_entry  
                //                   join tpm in ptn.tbl_pendaftaran_mobil on tcs.base_entry equals tpm.doc_entry
                //                   join ml2 in ptn.Masterlist2 on  
                //                    select new {}  ).ToList;


                GridList.DataSource = showptn;
                TotalCheckBoxes = GridList.RowCount;
            }
            catch (Exception x)
            {

                Console.WriteLine(x.Message);
            }
            
            TotalCheckedCheckBoxes = 0;
           
        }
        private String cash_acc;
        private String arAcc;
        private String exAcc;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            var qry = from t in ptn.trans_data_type
                      select t;
            var jml = qry.Count();

            //var rsInvent = ( from i in ptn.m_conf_acc
            //               select new { 
            //                 cashAcc = i.cash_acc_no,
            //                 arAcc = i.ar_acc_no,
            //                 exAcc = i.ex_acc_no
            //               }).ToList();
            //for (int i = 0; i < rsInvent.Count; i++)
            //{
            //    cash_acc = rsInvent[0].ToString();
            //    arAcc = rsInvent[0].ToString();
            //    exAcc = rsInvent[0].ToString();
            //}
            var rsAcc = (from a in ptn.m_conf_acc
                         select a.cash_acc_no).ToList();
            var rsArAcc = (from b in ptn.m_conf_acc
                         select b.ar_acc_no ).ToList();
            var rsExAcc = (from c in ptn.m_conf_acc
                         select c.ex_acc_no ).ToList();

            for (int i = 0; i < rsAcc.Count; i++)
            {
                this.cash_acc = rsAcc[0].ToString();
            }

            for (int i = 0; i < rsArAcc.Count; i++)
            {
                this.arAcc = rsArAcc[0].ToString();
            }

            for (int i = 0; i < rsExAcc.Count; i++)
            {
                this.exAcc = rsExAcc[0].ToString();
            }

            if (jml > 0)

                if (jml > 0)
                {
                    foreach (DataGridViewRow Row in GridList.Rows)
                    {
                        String base_entry;
                        String kode;
                        String nama;
                        String berat;
                        String pembayaran;
                        DateTime tanggal;
                        int invKey;
                        String jnsMitra;

                        if (Convert.ToBoolean(Row.Cells["chkBxSelect"].Value))
                        {
                            base_entry = Row.Cells[1].Value.ToString() ?? string.Empty;
                            kode = Row.Cells[2].Value.ToString() ?? string.Empty;
                            nama = Row.Cells[3].Value.ToString() ?? string.Empty;
                            berat = Row.Cells[4].Value.ToString() ?? string.Empty;

                            pembayaran = Row.Cells[5].Value.ToString() ?? string.Empty;
                            tanggal = Convert.ToDateTime(Row.Cells[6].Value);
                            invKey = Convert.ToInt32( Row.Cells[7].Value) ;
                            jnsMitra = Row.Cells[8].Value.ToString() ?? string.Empty;
                            saExport.insertTrans("cicil", kode, tanggal,
                                    "", 1, "", Convert.ToDecimal(pembayaran), base_entry, jnsMitra );

                            saExport.saveOutGoingPayment(invKey, kode, DateTime.Now,
                                Convert.ToDouble(pembayaran), jnsMitra, cash_acc, arAcc, exAcc);
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

            foreach (DataGridViewRow Row in GridList.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["chkBxSelect"]).Value = HCheckBox.Checked;
            GridList.RefreshEdit();

            TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

            IsHeaderCheckBoxClicked = false;
        }

        private void GridList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
