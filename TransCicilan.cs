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
using SRS.DeskApp.DAO;
using Equin.ApplicationFramework;
using System.Data.Entity.SqlServer;



namespace SRS.DeskApp
{
    public partial class TransCicilan : MetroForm
    {
        private String jenisBayar = "cicil";
        SRSEntities ptn = new SRSEntities();
        Validasi vl = new Validasi();

        public TransCicilan()
        {
            InitializeComponent();
        }

        private void TransCicilan_Load(object sender, EventArgs e)
        {
            ShowPetani();
            //BindPetani();
            //setHiddenCollumn();
            tbKodePetani.Focus();

            GridList.Visible = false;
            GridList.Left = tbTglDisetujui.Left;
            GridList.Top = tbKodePetani.Top + tbKodePetani.Height + 3;
            GridList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
        public void ShowPetani()
        {
            //where tcs.create_date >= DateTime.Now

            var showPtn = (from tcs in ptn.tbl_transit_core_sampling
                           join tpm in ptn.tbl_pendaftaran_mobil on tcs.base_entry equals tpm.doc_entry
                           join ml2 in ptn.Masterlist2 on tpm.card_code_reg equals ml2.kode_mitra
                           join tt in ptn.tbl_transit_timbangan on tpm.doc_entry equals tt.base_entry
                           where ml2.jenis_mitra != "KKPE" //& SqlFunctions.DateDiff("day", tcs.create_date, DateTime.Now) > 0
                           select new
                           {
                               PETANI = tpm.card_code_reg,
                               NAMA = tpm.card_name,
                               ALAMAT = ml2.alamat_ktp,
                               BERAT_TEBU = tt.gross_weight,
                               HARGA = tcs.pembayaran
                           }).Distinct().ToList();

            GridList.DataSource = showPtn;
        }
        
        private void setHiddenCollumn()
        {
            GridList.Columns[1].HeaderText = "PETANI";
            GridList.Columns[2].HeaderText = "NAMA";
            GridList.Columns[6].HeaderText = "ALAMAT";
            GridList.Columns[21].HeaderText = "BERAT TEBU";
            GridList.Columns[22].HeaderText = "HARGA JUAL";
            foreach (DataGridViewColumn c in GridList.Columns)
            {

                if (c.Index != 1 && c.Index != 2 && c.Index != 6 && c.Index != 22)
                {
                    c.Visible = false;
                }
                else
                {
                    if (c.Index == 1) { c.Width = 100; }
                    if (c.Index == 2) { c.Width = 125; }
                    if (c.Index == 6) { c.Width = 125; }
                    if (c.Index == 22) { c.Width = 100; }
                    //if (c.Index == 21) { c.Width = 60; }
                    c.DefaultCellStyle.Font = new Font("Segoe UI", 9F, GraphicsUnit.Pixel);
                }
            }
        }

        private void BindPetani()
        {
            var showPetani = (from ml in ptn.Masterlist2
                              where ml.jenis_mitra != "KPPE"
                              orderby ml.kode_mitra
                              select new
                              {
                                  KODE = ml.kode_mitra,
                                  NAMA = ml.nama_mitra,
                                  ALAMAT = ml.alamat_ktp,
                                  NOREK = ml.no_rek

                              }).Distinct().ToList();
            GridList.DataSource = showPetani;
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (tbKodePetani.Text != "")
            {
                using (var context = new SRSEntities())
                {
                    context.spInsertTrans(jenisBayar, tbKodePetani.Text, tbTglDisetujui.Value,
                        tbKeterangan.Text, 1, "", decimal.Parse(tbJumlah.Text), "");
                    context.SaveChanges();

                    MetroFramework.MetroMessageBox.Show(this, "Data berhasil disimpan", "Informasi", MessageBoxButtons.OK);
                }
            }
        }

        private void tbKodePetani_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GridList.Visible = false;
            }
        }

        private void tbKodePetani_Enter(object sender, EventArgs e)
        {
            GridList.Visible = true;
        }

        private void GridList_Leave(object sender, EventArgs e)
        {
            GridList.Visible = false;
        }

        private void GridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string kp = GridList.SelectedRows[0].Cells[0].Value.ToString();
            string berat = GridList.SelectedRows[0].Cells[3].Value.ToString();
            string pembayaran = GridList.SelectedRows[0].Cells[4].Value.ToString();
            //tbKodePetani.Text = GridList.Rows[e.RowIndex].Cells[1].Value.ToString();

            tbKodePetani.Text = kp;
            tbJumlah.Text = pembayaran;
            tbBerat.Text = berat;
            

            GridList.Visible = false;
            vl.ValidateCtrl(tbJumlah, "kosong", errorProvider1, errorProvider2, errorProvider3);
        }

        BindingListView<Context.Masterlist2> biUser;
        private void tbKodePetani_TextChanged(object sender, EventArgs e)
        {
            
            //var t = GlobalController.SearchDataPetaniNonKKPE(tbKodePetani.Text, 0, 100);
            //biUser = new BindingListView<Context.Masterlist2>(t);
            var showPtn = (from tcs in ptn.tbl_transit_core_sampling
                           join tpm in ptn.tbl_pendaftaran_mobil on tcs.base_entry equals tpm.doc_entry
                           join ml2 in ptn.Masterlist2 on tpm.card_code_reg equals ml2.kode_mitra
                           join tt in ptn.tbl_transit_timbangan on tpm.doc_entry equals tt.base_entry
                           where ml2.kode_mitra.Contains(tbKodePetani.Text) & ml2.jenis_mitra != "KKPE" //& SqlFunctions.DateDiff("day", tcs.create_date, DateTime.Now) > 0
                           select new
                           {
                               PETANI = tpm.card_code_reg,
                               NAMA = tpm.card_name,
                               ALAMAT = ml2.alamat_ktp,
                               BERAT_TEBU = tt.gross_weight,
                               HARGA = tcs.pembayaran
                           }).Distinct().ToList();

            GridList.DataSource = showPtn;

            GridList.DataSource = biUser;
            setHiddenCollumn();
        }

        

    }
}
