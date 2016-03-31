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
        //SAPbobsCOM.Company oCom = new SAPbobsCOM.Company();
        

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
            BindGrid();
            AddHeaderCheckBox();

            HeaderCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            GridList.CellValueChanged+= new DataGridViewCellEventHandler(dgvSelectAll_CellValueChanged);
            GridList.CurrentCellDirtyStateChanged += new EventHandler(dgvSelectAll_CurrentCellDirtyStateChanged);
            GridList.CellPainting+= new DataGridViewCellPaintingEventHandler(dgvSelectAll_CellPainting);
            
            

                      
        }

        
        //public void sapConnect()
        //{
        //    oCom.DbServerType = BoDataServerTypes.dst_MSSQL2012;
        //    oCom.Server = @"DERIT-PC\SQL2012";
        //    oCom.language = BoSuppLangs.ln_English;
        //    oCom.DbUserName = "sa";
        //    oCom.DbPassword = "sasa";

        //    if (oCom.Connected == false)
        //    {
        //        try
        //        {
        //            oCom.Connect();
                    
        //        }
        //        catch (Exception x)
        //        {

        //            throw new Exception(x.Message);
        //        }
                
        //    }
            

        //}
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
           //var sq1 = ptn.trans_data_line.Where(x => x.type_trans == "F-ISSUED"); 

            //var sq1 = from tdl in ptn.trans_data_line
            //          where tdl.type_trans == "F-ISSUED"
            //          && tdl.base_entry != null
            //          select tdl;
            
            //var showPtn = (from tcs in ptn.tbl_transit_core_sampling
            //               join tpm in ptn.tbl_pendaftaran_mobil on tcs.base_entry equals tpm.doc_entry
            //               join ml2 in ptn.Masterlist2 on tpm.card_code_reg equals ml2.kode_mitra
            //               join ttt in ptn.tbl_transit_timbangan on tpm.doc_entry equals ttt.base_entry
            //               where  SqlFunctions.DateDiff("day", tcs.create_date , DateTime.Now ) > 0
                           
            //               select new
            //               {
            //                   BASE = tcs.base_entry,
            //                   KODE = ml2.kode_mitra,
            //                   NAMA = ml2.nama_mitra,
            //                   BERAT = ttt.net_weight,
            //                   PEMBAYARAN = tcs.pembayaran
            //               }).ToList();

            var showptn = (from lc in ptn.spLoadCicilan()
                                select new
                           {
                               BASE= lc.base_entry,
                               KODE= lc.kode_mitra,
                               NAMA = lc.nama_mitra,
                               BERAT = lc.net_weight,
                               PEMBAYARAN = lc.pembayaran,
                               TANGGAL = lc.create_date
                           }).ToList();

            GridList.DataSource = showptn;
            TotalCheckBoxes = GridList.RowCount;
            TotalCheckedCheckBoxes = 0;
           
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            var qry = from t in ptn.trans_data_type
                      select t;
            var jml = qry.Count();
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

                        if (Convert.ToBoolean(Row.Cells["chkBxSelect"].Value))
                        {
                            base_entry = Row.Cells[1].Value.ToString() ?? string.Empty;
                            kode = Row.Cells[2].Value.ToString() ?? string.Empty;
                            nama = Row.Cells[3].Value.ToString() ?? string.Empty;
                            berat = Row.Cells[4].Value.ToString() ?? string.Empty;

                            pembayaran = Row.Cells[5].Value.ToString() ?? string.Empty;
                            tanggal = Convert.ToDateTime(Row.Cells[6].Value);

                            using (var context = new SRSEntities())
                            {
                                context.spInsertTrans("cicil", kode, tanggal,
                                "", 1, "", decimal.Parse(pembayaran), base_entry);

                                context.SaveChanges();

                            }

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
    }
}
