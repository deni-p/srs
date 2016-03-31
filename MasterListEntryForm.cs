using Equin.ApplicationFramework;
using MetroFramework.Controls;
using SRS.DeskApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRS.DeskApp
{
    public partial class MasterListEntryForm : MetroForm
    {
        public MasterListEntryForm()
        {
            InitializeComponent();
        }

        public static Context.Masterlist2 SendData;
        public static bool isOpenFromMaster;
        private void MasterListEntryForm_Load(object sender, EventArgs e)
        {
            FillComboKabupaten();
            FillComboKategori();
            FillComboJenisMitra();
            if (isOpenFromMaster == true)
            {
                var sSendData = GlobalController.GetMasterList2ByID(SendData.ID);
                // save
                if (sSendData != null)
                {
                    // get data from UploadExcelForm
                    tbID.Text = sSendData.ID.ToString();
                    tbKodeMitra.Text = sSendData.kode_mitra;
                    tbNamaMitra.Text = sSendData.nama_mitra;
                    tbKetuaKelompok.Text = sSendData.ketua_kelompok;
                    tbNamaKelompok.Text = sSendData.nama_kelompok;
                    cbJenisMitra.Text = sSendData.jenis_mitra;
                    //if (sSendData.jenis_mitra.Equals("Mandiri"))
                    //    cbJenisMitra.SelectedIndex = 0;
                    //else
                    //    cbJenisMitra.SelectedIndex = 1;

                    tbAlamatKTP.Text = sSendData.alamat_ktp;
                    tbNoKTP.Text = sSendData.no_ktp;
                    tbNoHp.Text = sSendData.no_hp;
                    tbNoKontrak.Text = sSendData.no_kontrak;
                    tbTglKontrak.Value = Convert.ToDateTime(sSendData.tgl_kontrak);
                    tbLuas.Text = sSendData.luas.ToString();
                    cbkategori.Text = sSendData.kategori;
                    tbVarietas.Text = sSendData.varietas;
                    tbTglTanam.Value = Convert.ToDateTime(sSendData.tgl_tanam);
                    if (sSendData.rayon.ToString() == null || sSendData.rayon.ToString() == "")
                    {
                        cbRayon.SelectedIndex = 0;
                    }
                    else
                    {
                        cbRayon.Text = sSendData.rayon.ToString();
                    }


                    //if (sSendData.jenis_mitra.Equals("Barat"))
                    //    cbRayon.SelectedIndex = 0;
                    //else if (sSendData.jenis_mitra.Equals("Timur"))
                    //    cbRayon.SelectedIndex = 1;
                    //else
                    //    cbRayon.SelectedIndex = 2;


                    tbPenanggungjawabRegion.Text = sSendData.penanggung_jawab;
                    tbKoordinatX.Text = sSendData.koordinat_x;
                    tbKoordinatY.Text = sSendData.koordinat_y;
                    cbKabupaten.Text = sSendData.kabupaten;
                    cbKecamatan.Text = sSendData.kecamatan;
                    cbKelurahan.Text = sSendData.kelurahan;
                    tbNoRek.Text = sSendData.no_rek;
                    tbANRek.Text = sSendData.an_rek;
                    tbBank.Text = sSendData.bank_rek;
                    tbKUD.Text = sSendData.kud;
                    tbTglPanen.Value = Convert.ToDateTime(sSendData.tgl_panen);
                    tbEstTCH.Text = sSendData.est_tch.ToString();
                    tbEstHasil.Text = sSendData.est_hasil_panen.ToString();
                    tbRitase.Text = sSendData.est_ritase.ToString();
                    tbRadius.Text = sSendData.est_radius;

                    //tbvalue_1.Text = sSendData.value_1;
                    //tbvalue_2.Text = sSendData.value_2;


                    metroButton1.Text = "Perbaharui";
                }
            }
            else
            {
                if (SendData != null)
                {
                    // get data from UploadExcelForm
                    tbKodeMitra.Text = SendData.kode_mitra;
                    tbNamaMitra.Text = SendData.nama_mitra;
                    tbKetuaKelompok.Text = SendData.ketua_kelompok;
                    tbNamaKelompok.Text = SendData.nama_kelompok;
                    cbJenisMitra.Text = SendData.jenis_mitra;

                    //if (SendData.jenis_mitra.Equals("Mandiri"))
                    //    cbJenisMitra.SelectedIndex = 0;
                    //else
                    //    cbJenisMitra.SelectedIndex = 1;

                    tbAlamatKTP.Text = SendData.alamat_ktp;
                    tbNoKTP.Text = SendData.no_ktp;
                    tbNoHp.Text = SendData.no_hp;
                    tbNoKontrak.Text = SendData.no_kontrak;
                    tbTglKontrak.Value = Convert.ToDateTime(SendData.tgl_kontrak);
                    tbLuas.Text = SendData.luas.ToString();
                    cbkategori.Text = SendData.kategori;
                    tbVarietas.Text = SendData.varietas;
                    tbTglTanam.Value = Convert.ToDateTime(SendData.tgl_tanam);
                    cbRayon.Text = SendData.rayon;

                    //if (SendData.jenis_mitra.Equals("Barat"))
                    //    cbRayon.SelectedIndex = 0;
                    //else if (SendData.jenis_mitra.Equals("Timur"))
                    //    cbRayon.SelectedIndex = 1;
                    //else
                    //    cbRayon.SelectedIndex = 2;


                    tbPenanggungjawabRegion.Text = SendData.penanggung_jawab;
                    tbKoordinatX.Text = SendData.koordinat_x;
                    tbKoordinatY.Text = SendData.koordinat_y;
                    cbKabupaten.Text = SendData.kabupaten;
                    cbKecamatan.Text = SendData.kecamatan;
                    cbKelurahan.Text = SendData.kelurahan;
                    tbNoRek.Text = SendData.no_rek;
                    tbANRek.Text = SendData.an_rek;
                    tbBank.Text = SendData.bank_rek;
                    tbKUD.Text = SendData.kud;
                    tbTglPanen.Value = Convert.ToDateTime(SendData.tgl_panen);
                    tbEstTCH.Text = SendData.est_tch.ToString();
                    tbEstHasil.Text = SendData.est_hasil_panen.ToString();
                    tbRadius.Text = SendData.est_radius;
                    tbRitase.Text = SendData.est_ritase.ToString();
                    //tbvalue_1.Text = SendData.value_1;
                    //tbvalue_2.Text = SendData.value_2;


                    metroButton1.Text = "Perbaharui";
                }
                var datafrom = MasterListForm.MasterlistsPublic;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        public static Context.Masterlist2 masterData;

        public bool CheckError(MetroTextBox tb)
        {

             string text = tb.Text;

             if (text== "")
             {
                 errorProvider1.SetError(tb, "Wajib diisi");
                 return false;
             }
             else
             {
                 //errorProvider1.Clear();
                 errorProvider1.SetError(tb, "");
                 return true;
             }
        

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {



            List<bool> containErr = new List<bool>();
            containErr.Add(CheckError(tbKodeMitra));
            containErr.Add(CheckError(tbNamaMitra));
            containErr.Add(CheckError(tbKetuaKelompok));
            containErr.Add(CheckError(tbNamaKelompok));
            containErr.Add(CheckError(tbAlamatKTP));
            containErr.Add(CheckError(tbNoKTP));
            containErr.Add(CheckError(tbNoHp));
            containErr.Add(CheckError(tbNoKontrak));
            //containErr.Add(CheckError(tbKategori));
            containErr.Add(CheckError(tbVarietas));
            containErr.Add(CheckError(tbPenanggungjawabRegion));
            containErr.Add(CheckError(tbKoordinatX));
            containErr.Add(CheckError(tbKoordinatY));
            //containErr.Add(CheckError(tbKelurahan));
            //containErr.Add(CheckError(tbKecamatan));
            containErr.Add(CheckError(tbLuas));
            containErr.Add(CheckError(tbRitase));
            containErr.Add(CheckError(tbRadius));

            if (!containErr.Contains(false))
            {
                Context.Masterlist2 fix = new Context.Masterlist2();

                fix.ID = 0;
                fix.kode_mitra = tbKodeMitra.Text;
                fix.nama_mitra = tbNamaMitra.Text;
                fix.ketua_kelompok = tbKetuaKelompok.Text;
                fix.nama_kelompok = tbNamaKelompok.Text;
                //Console.WriteLine(cbJenisMitra.Text);
                fix.jenis_mitra = cbJenisMitra.Text; //cbJenisMitra.SelectedValue.ToString(); 
                fix.alamat_ktp = tbAlamatKTP.Text;
                fix.no_ktp = tbNoKTP.Text;
                fix.no_hp = tbNoHp.Text;
                fix.no_kontrak = tbNoKontrak.Text;
                fix.tgl_kontrak = tbTglKontrak.Value.Date;
                fix.luas = Convert.ToDecimal(tbLuas.Text);
                fix.kategori = cbkategori.Text;
                fix.varietas = tbVarietas.Text;
                fix.tgl_tanam = tbTglTanam.Value.Date;
                fix.rayon = cbRayon.Text;// .Items[cbRayon.SelectedIndex].ToString();
                fix.penanggung_jawab = tbPenanggungjawabRegion.Text;
                fix.koordinat_x = tbKoordinatX.Text;
                fix.koordinat_y = tbKoordinatY.Text;
                fix.kelurahan = cbKelurahan.Text;
                fix.kecamatan = cbKecamatan.Text;
                fix.kabupaten = cbKabupaten.Text;
                fix.no_rek = tbNoRek.Text;
                fix.an_rek = tbANRek.Text;
                fix.bank_rek = tbBank.Text;
                fix.kud = tbKUD.Text;
                fix.tgl_panen = tbTglPanen.Value.Date;
                fix.est_tch = Convert.ToDecimal(tbEstTCH.Text);
                fix.est_hasil_panen = Convert.ToDecimal(tbEstHasil.Text);
                fix.est_radius = tbRadius.Text;
                fix.reg_status = false; // 0 = PETANI LAMA ; 1 = PETANI BARU
                fix.est_ritase = Convert.ToDecimal(tbRitase.Text);
                fix.year_period = Convert.ToInt16(DateTime.Now.Year.ToString());
                fix.period_trx = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString();

                masterData = new Context.Masterlist2();
                masterData = fix;

                if (isOpenFromMaster == true)
                {
                    // always update
                    masterData.ID = Convert.ToInt32(tbID.Text);
                    GlobalController.UpdateMasterlist2(masterData);
                    MetroFramework.MetroMessageBox.Show(this, "Data berhasil diperbaharui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    GlobalController.UpdateMasterlist2(masterData);
                    Application.DoEvents();

                }
                //masterData = new Context.Masterlist2();
                this.Close();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Cek inputan anda, isian tidak boleh kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void tbLandArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbLuas_Click(object sender, EventArgs e)
        {

        }

        private void tbLuas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbLuas.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && tbLuas.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void tbEstTCH_Click(object sender, EventArgs e)
        {

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

        private void FillComboKategori()
        {
            Context.SRSEntities c = new Context.SRSEntities();
            {
                cbkategori.DataSource = (from H in c.lookup_header
                                         join D in c.lookup_line on H.header_id equals D.header_id
                                         where H.header_id == 2
                                         select D).ToList();


                cbkategori.DisplayMember = "line_desc";
                cbkategori.ValueMember = "line_id";
                cbkategori.Text = "";
            }
        }

        private void FillComboJenisMitra()
        {
            Context.SRSEntities c = new Context.SRSEntities();
            {
                cbJenisMitra.DataSource = (from H in c.lookup_header
                                           join D in c.lookup_line on H.header_id equals D.header_id
                                           where H.header_id == 1
                                           select D).ToList();


                cbJenisMitra.DisplayMember = "line_desc";
                cbJenisMitra.ValueMember = "header_id";
                cbJenisMitra.Text = "";
            }
        }

        private void tbEstTCH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbEstTCH.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && tbEstTCH.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void tbEstHasil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbEstHasil.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && tbEstHasil.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void tbRitase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbRitase.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && tbRitase.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
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

        private void cbKelurahan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbLuas_Click_1(object sender, EventArgs e)
        {

        }

        private void cbJenisMitra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MasterListEntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //masterData = new Context.Masterlist2();
        }

        private void tbNamaMitra_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbNamaMitra);
        }

        private void tbKodeMitra_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbKodeMitra);
           
        }

        private void tbKetuaKelompok_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbKetuaKelompok);
        }

        private void tbAlamatKTP_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbAlamatKTP);
        }

        private void tbNoKTP_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbNoKTP);
        }

        private void tbNoHp_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbNoHp);
        }

        private void tbNoKontrak_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbNoKontrak);
        }

        private void tbLuas_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbLuas);
        }

        private void tbVarietas_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbVarietas);
        }

        private void tbPenanggungjawabRegion_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbPenanggungjawabRegion);
        }

        private void tbKoordinatX_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbKoordinatX);
        }

        private void tbKoordinatY_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbKoordinatY);
        }

        private void tbNoRek_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbNoRek);
        }

        private void tbANRek_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbANRek);
        }

        private void tbBank_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbBank);
        }

        private void tbKUD_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbKUD);
        }

        private void tbEstTCH_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void tbEstTCH_Validating(object sender, CancelEventArgs e)
        {
           // CheckError(tbEstTCH);
        }

        private void tbEstHasil_Validating(object sender, CancelEventArgs e)
        {
            //CheckError(tbEstHasil);
        }

        private void tbRitase_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbRitase);
        }

        private void tbRadius_Validating(object sender, CancelEventArgs e)
        {
            CheckError(tbRadius);
        }

        private void tbAlamatKTP_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void tbNamaKelompok_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void tbKetuaKelompok_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void tbNamaMitra_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void tbKodeMitra_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }
    }
}
