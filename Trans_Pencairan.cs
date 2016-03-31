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
using SAPbobsCOM;

namespace SRS.DeskApp
{
    public partial class Trans_Pencairan : MetroForm
    {
        private String jenisBayar = "cair";
        private Context.Masterlist2 listpetani;
        Sap saExport = new Sap();

        Validasi vl = new Validasi();
       
        public Trans_Pencairan()
        {
            InitializeComponent();
        }



        private void Trans_Pencairan_Load(object sender, EventArgs e)
        {
            //BindingListView<Context.Masterlist2> biUser;
            //var datas = GlobalController.RefershPetani(100);
            //biUser = new BindingListView<Context.Masterlist2>(datas);
            //GridList.DataSource = biUser;
          
            //tbKodePetani.Focus();
            //GridLayout();
            //GridList.Visible = false;
            //GridList.Left = tbTglDisetujui.Left;
            //GridList.Top = tbKodePetani.Top + tbKodePetani.Height + 3;
            //GridList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            BindPetani();
            tbKodePetani.Focus();
            GridLayout();
            GridList.Visible = false;
            GridList.Left = tbTglDisetujui.Left;
            GridList.Top = tbKodePetani.Top + tbKodePetani.Height + 3;
            GridList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            

        }

        private void GridLayout()        {
            
            //GridList.Columns[2].HeaderText = "ALAMAT";
            //GridList.Columns[2].Width = 160;            
            GridList.DefaultCellStyle.Font = new Font("Segoe UI", 9F, GraphicsUnit.Pixel);

            
        }

        private void setHiddenCollumn()
        {
            GridList.Columns[1].HeaderText = "KODE";
            GridList.Columns[2].HeaderText = "NAMA";
            GridList.Columns[6].HeaderText = "ALAMAT";
            GridList.Columns[22].HeaderText = "NOREK";
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


        SRSEntities ptn = new SRSEntities();

        private void BindPetani()
        {
            var showPetani = ( from ml in ptn.Masterlist2
                               where ml.jenis_mitra == "KPPE"
                               orderby ml.kode_mitra
                               select new
                               {
                                   KODE  = ml.kode_mitra,
                                   NAMA = ml.nama_mitra,
                                   ALAMAT = ml.alamat_ktp,
                                   NOREK = ml.no_rek

                               }).Distinct().ToList();
            GridList.DataSource = showPetani;
        }

        public void ShowPetani()
        {
            //var showPtn = (from tcs in ptn.tbl_transit_core_sampling
            //                  join tpm in ptn.tbl_pendaftaran_mobil on tcs.base_entry equals tpm.doc_entry
            //                  join ml2 in ptn.Masterlist2 on tpm.card_code_reg equals ml2.kode_mitra
            //                  where tcs.create_date >= DateTime.Now
            //                  select new
            //                  {
            //                      bs = tcs.base_entry,
            //                      cr = tpm.card_code_reg,
            //                      nm = ml2.nama_mitra,
            //                      kk= ml2.ketua_kelompok,
            //                      nk = ml2.nama_kelompok,
            //                      alm = ml2.alamat_ktp,
            //                      hr = tcs.harga,
            //                      cd = tcs.create_date
            //                  }).Distinct().ToList();

            var showPtn = (from ml in ptn.Masterlist2                           
                           select new
                           {
                               KODE = ml.kode_mitra,
                               NAMA = ml.nama_mitra,
                               NOREK = ml.no_rek
                                                                                         
                           }).Distinct().ToList();

            GridList.DataSource = showPtn;
        }

       

        private void btSimpan_Click(object sender, EventArgs e)
        {
            
            var qry = from t in ptn.trans_data_type
                      select t;
            var jml = qry.Count();
            if (jml>0)
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
                    //saExport.insertTrans(jenisBayar, tbKodePetani.Text, tbTglDisetujui.Value,
                    //                tbKeterangan.Text, 1, "", decimal.Parse(tbJumlah.Text), "" , jnsMitra);
                } 
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Tabel Type transaksi masih kosong", "Informasi", MessageBoxButtons.OK);
            }
            
        }

        private void tbKodePetani_Leave(object sender, EventArgs e)
        {
            
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
            GridList.BringToFront();
        }

        private void GridList_Leave(object sender, EventArgs e)
        {
            GridList.Visible = false;
        }

        BindingListView<Context.Masterlist2> biUser;
        private void tbKodePetani_TextChanged(object sender, EventArgs e)
        {
            //var t = GlobalController.SearchMasterPetani(tbKodePetani.Text, 0, 100);
            var t = GlobalController.SearchDataPetani(tbKodePetani.Text, 0, 100);
            biUser = new BindingListView<Context.Masterlist2>(t);
            
            GridList.DataSource = biUser;
            //setHiddenCollumn();
        }

        

        private void Trans_Pencairan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GridList.Visible = false;
            }
        }

        private void tbKodePetani_Click(object sender, EventArgs e)
        {

        }
        
        private void tbJumlah_Validating(object sender, CancelEventArgs e)
        {
            
            vl.ValidateCtrl(tbJumlah, "angka", errorProvider1, errorProvider2, errorProvider3);
            
        }

        private void GridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbKodePetani.Text = GridList.Rows[e.RowIndex].Cells[0].Value.ToString();

            GridList.Visible = false;

            vl.ValidateCtrl(tbJumlah, "kosong", errorProvider1, errorProvider2, errorProvider3);
        }

        private void tbJumlah_TextChanged(object sender, EventArgs e)
        {

        }

       
        
    }
}
