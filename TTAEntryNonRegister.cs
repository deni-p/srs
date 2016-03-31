using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using SRS.DeskApp.DAO;
using System.IO;

namespace SRS.DeskApp
{
    public partial class TTAEntryNonRegister : MetroForm
    {
        public TTAEntryNonRegister()
        {
            InitializeComponent();
        }
        public static Context.Masterlist2   entrypetani;
        public static bool isOpenFromMaster;
        public bool CheckError(MetroTextBox tb)
        {
            string text = tb.Text;

            if (text.Trim().Length <= 0)
            {
                errorProvider1.SetError(tb, "Wajib diisi");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }

        }
        private void TTAEntryNonRegister_Load(object sender, EventArgs e)
        {
            FillComboKabupaten();
        }

        private void FillComboKabupaten()
        {
            Context.SRSEntities c = new Context.SRSEntities();
            {
                cbKabupaten.DataSource = (from Kab in c.tbl_kabupaten
                                          orderby Kab.kab_id ascending
                                          select Kab).ToList();


                cbKabupaten.DisplayMember = "kab_name";
                cbKabupaten.ValueMember = "kab_id";
                cbKabupaten.Text = "";
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            List<bool> containErr = new List<bool>();
            containErr.Add(CheckError(tbKodeMitra));
            containErr.Add(CheckError(tbNamaMitra));
            //containErr.Add(CheckError(tbKabupaten));
            //containErr.Add(CheckError(tbKecamatan));
            //containErr.Add(CheckError(tbKelurahan));
            //containErr.Add(CheckError(tbAlamatKTP));
            containErr.Add(CheckError(tbAlamatKTP));

            if (!containErr.Contains(false))
            {
                Context.Masterlist2 fix = new Context.Masterlist2();

                fix.ID = 0;
                fix.kode_mitra = tbKodeMitra.Text;
                fix.nama_mitra = tbNamaMitra.Text;
                fix.alamat_ktp = tbAlamatKTP.Text;
                fix.kabupaten = cbKabupaten.Text;
                fix.kecamatan = cbKecamatan.Text;
                fix.kelurahan = cbKelurahan.Text;
                fix.jenis_mitra = "Mandiri";
                fix.rayon ="Timur";
                fix.tgl_kontrak = DateTime.Now;
                fix.tgl_panen = DateTime.Now;
                fix.tgl_tanam = DateTime.Now;
                //entrypetani = fix;
                GlobalController.insertnonregister(fix);

                //if (isOpenFromMaster == true)
                //{
                //    // always update
                //    //entrypetani.ID = Convert.ToInt32(tbID.Text);
                //    //GlobalController.UpdateMasterlist2(entrypetani);
                //    MetroFramework.MetroMessageBox.Show(this, "Data berhasil diperbaharui", "Informasi", MessageBoxButtons.OK);

                //}
                this.Close();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Cek inputan anda, isian tidak boleh kosong", "Informasi", MessageBoxButtons.OK);
            }
        }

        private void cbKabupaten_SelectedIndexChanged(object sender, EventArgs e)
        {
            Context.SRSEntities c = new Context.SRSEntities();
            {
                var query = (from kab in c.tbl_kabupaten
                             where kab.kab_name == cbKabupaten.Text
                             select new { kab.kab_id });



                cbKecamatan.DataSource = (from kec in c.tbl_kecamatan
                                          where kec.kab_id == query.FirstOrDefault().kab_id
                                          select kec).ToList();


                cbKecamatan.DisplayMember = "kec_name";
                cbKecamatan.ValueMember = "kec_id";
            }
        }

        private void cbKecamatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Context.SRSEntities c = new Context.SRSEntities();
            {
                var query = (from kab in c.tbl_kabupaten
                             where kab.kab_name == cbKabupaten.Text
                             select new { kab.kab_id });

                var query1 = (from Kec in c.tbl_kecamatan
                              where Kec.kec_name == cbKecamatan.Text
                              select new { Kec.kec_id });

                cbKelurahan.DataSource = (from Kel in c.tbl_kelurahan
                                          where Kel.kab_id == query.FirstOrDefault().kab_id && Kel.kec_id == query1.FirstOrDefault().kec_id
                                          select Kel).ToList();


                cbKelurahan.DisplayMember = "kel_name";
                cbKelurahan.ValueMember = "kel_id";
            }
        }
    }
}
