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
                    if (sSendData.jenis_mitra.Equals("Mandiri"))
                        cbJenisMitra.SelectedIndex = 0;
                    else
                        cbJenisMitra.SelectedIndex = 1;

                    tbAlamatKTP.Text = sSendData.alamat_ktp;
                    tbNoKTP.Text = sSendData.no_ktp;
                    tbNoHp.Text = sSendData.no_hp;
                    tbNoKontrak.Text = sSendData.no_kontrak;
                    tbTglKontrak.Value = Convert.ToDateTime(sSendData.tgl_kontrak);
                    tbLuas2.Text = sSendData.luas.ToString();
                    tbKategori.Text = sSendData.kategori;
                    tbVarietas.Text = sSendData.varietas;
                    tbTglTanam.Value = Convert.ToDateTime(sSendData.tgl_tanam);

                    if (sSendData.rayon.Equals("Barat"))
                        cbRayon.SelectedIndex = 0;
                    else if (sSendData.rayon.Equals("Timur"))
                        cbRayon.SelectedIndex = 1;
                    else
                        cbRayon.SelectedIndex = 2;


                    tbPenanggungjawabRegion.Text = sSendData.penanggung_jawab;
                    tbKoordinatX.Text = sSendData.koordinat_x;
                    tbKoordinatY.Text = sSendData.koordinat_y;
                    tbKelurahan.Text = sSendData.kelurahan;
                    tbKecamatan.Text = sSendData.kecamatan;
                    tbKabupaten.Text = sSendData.kabupaten;
                    tbNoRek.Text = sSendData.no_rek;
                    tbANRek.Text = sSendData.an_rek;
                    tbBank.Text = sSendData.bank_rek;
                    tbKUD.Text = sSendData.kud;
                    tbTglPanen.Value = Convert.ToDateTime(sSendData.tgl_panen);
                    tbEstTCH.Text = sSendData.est_tch.ToString();
                    tbEstHasil.Text = sSendData.est_hasil_panen.ToString();
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
                    if (SendData.jenis_mitra.Equals("Mandiri"))
                        cbJenisMitra.SelectedIndex = 0;
                    else
                        cbJenisMitra.SelectedIndex = 1;

                    tbAlamatKTP.Text = SendData.alamat_ktp;
                    tbNoKTP.Text = SendData.no_ktp;
                    tbNoHp.Text = SendData.no_hp;
                    tbNoKontrak.Text = SendData.no_kontrak;
                    tbTglKontrak.Value = Convert.ToDateTime(SendData.tgl_kontrak);
                    tbLuas2.Text = SendData.luas.ToString();
                    tbKategori.Text = SendData.kategori;
                    tbVarietas.Text = SendData.varietas;
                    tbTglTanam.Value = Convert.ToDateTime(SendData.tgl_tanam);

                    if (SendData.jenis_mitra.Equals("Barat"))
                        cbRayon.SelectedIndex = 0;
                    else if (SendData.jenis_mitra.Equals("Timur"))
                        cbRayon.SelectedIndex = 1;
                    else
                        cbRayon.SelectedIndex = 2;


                    tbPenanggungjawabRegion.Text = SendData.penanggung_jawab;
                    tbKoordinatX.Text = SendData.koordinat_x;
                    tbKoordinatY.Text = SendData.koordinat_y;
                    tbKelurahan.Text = SendData.kelurahan;
                    tbKecamatan.Text = SendData.kecamatan;
                    tbKabupaten.Text = SendData.kabupaten;
                    tbNoRek.Text = SendData.no_rek;
                    tbANRek.Text = SendData.an_rek;
                    tbBank.Text = SendData.bank_rek;
                    tbKUD.Text = SendData.kud;
                    tbTglPanen.Value = Convert.ToDateTime(SendData.tgl_panen);
                    tbEstTCH.Text = SendData.est_tch.ToString();
                    tbEstHasil.Text = SendData.est_hasil_panen.ToString();
                    tbRadius.Text = SendData.est_radius;


                    metroButton1.Text = "Perbaharui";
                }
                var datafrom = UploadExcelForm.MasterlistsPublic;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        public static Context.Masterlist2 masterData;

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
            containErr.Add(CheckError(tbKategori));
            containErr.Add(CheckError(tbVarietas));

            containErr.Add(CheckError(tbPenanggungjawabRegion));
            containErr.Add(CheckError(tbKoordinatX));
            containErr.Add(CheckError(tbKoordinatY));
            containErr.Add(CheckError(tbKelurahan   ));
            containErr.Add(CheckError(tbKecamatan));
            containErr.Add(CheckError(tbKabupaten));

            if (!containErr.Contains(false))
            {

                Context.Masterlist2 fix = new Context.Masterlist2();

                fix.ID = 0;
                fix.kode_mitra = tbKodeMitra.Text;
                fix.nama_mitra = tbNamaMitra.Text;
                fix.ketua_kelompok = tbKetuaKelompok.Text;
                fix.nama_kelompok = tbNamaKelompok.Text;
                fix.jenis_mitra = cbJenisMitra.Items[cbJenisMitra.SelectedIndex].ToString();
                fix.alamat_ktp = tbAlamatKTP.Text;
                fix.no_ktp = tbNoKTP.Text;
                fix.no_hp = tbNoHp.Text;
                fix.no_kontrak = tbNoKontrak.Text;
                fix.tgl_kontrak = tbTglKontrak.Value;
                fix.luas = Convert.ToDouble(tbLuas2.Text);
                fix.kategori = tbKategori.Text;
                fix.varietas = tbVarietas.Text;
                fix.tgl_tanam = tbTglTanam.Value;
                fix.rayon = cbRayon.Items[cbRayon.SelectedIndex].ToString();
                fix.penanggung_jawab = tbPenanggungjawabRegion.Text;
                fix.koordinat_x = tbKoordinatX.Text;
                fix.koordinat_y = tbKoordinatY.Text;
                fix.kelurahan = tbKelurahan.Text;
                fix.kecamatan = tbKecamatan.Text;
                fix.kabupaten = tbKabupaten.Text;
                fix.no_rek = tbNoRek.Text;
                fix.an_rek = tbANRek.Text;
                fix.bank_rek = tbBank.Text;
                fix.kud = tbKUD.Text;
                fix.tgl_panen = tbTglPanen.Value;
                fix.est_tch = Convert.ToDouble(tbEstTCH.Text);
                fix.est_hasil_panen = Convert.ToDouble(tbEstHasil.Text);
                fix.est_radius =  tbRadius.Text;
                fix.est_ritase = Convert.ToInt16(tbRitase.Text);


                masterData = new Context.Masterlist2();
                masterData = fix;

                if (isOpenFromMaster == true)
                {
                    // always update
                    masterData.ID = Convert.ToInt32(tbID.Text);
                    GlobalController.UpdateMasterlist2(masterData);
                    MetroFramework.MetroMessageBox.Show(this, "Data berhasil diperbaharui", "Informasi", MessageBoxButtons.OK);

                }
                this.Close();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Cek inputan anda, isian tidak boleh kosong", "Informasi", MessageBoxButtons.OK);
            }

        }

        private void tbLandArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void tbLuas_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLuas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.Text.Length == 0)
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
            if (e.KeyChar == '.' && this.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
