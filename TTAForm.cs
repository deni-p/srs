using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRS.DeskApp.DAO;
using MetroFramework;
using MetroFramework.Controls;
using System.IO;
using Equin.ApplicationFramework;

namespace SRS.DeskApp
{
    public partial class TTAForm : MetroForm
    {
        public TTAForm()
        {
            InitializeComponent();
            
        }

        private Context.Masterlist2 listpetani;
        private Context.Tiket tiketing;
        public static int TiketID;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

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
        private void MasterListEntryForm2_Load(object sender, EventArgs e)
        {
            BindingListView<Context.Masterlist2> biUser;
            var datas = GlobalController.RefershPetani(100);
            biUser = new BindingListView<Context.Masterlist2>(datas);
            GridList.DataSource = biUser;
            tbNamaKUD.Focus();
            GridLayout();
            GridList.Visible = false;
            GridList.Left = tbAlamatPetani1.Left;
            GridList.Top = tbNamaPetani1.Top + tbNamaPetani1.Height + 3;
            GridList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FillComboKabupaten();
            //tbNamaPetani1.LostFocus += new System.EventHandler(tbNamaPetani1_LostFocus);
            tbNoTiketTTA.Enabled = false;

            if (TiketID > 0)
            {
                var ReqData = GlobalController.GetTiketByID(TiketID);

                //tbNoTiketTTA.Enabled = false;
                tbAlamatPetani1.Text = ReqData.Alamat;
                tbAlamatPetani2.Text = ReqData.Alamat2;
                tbDibuatOleh.Text = ReqData.DibuatOleh;
                tbDiserahkanOlehJabatan.Text = ReqData.DiserahkanOlehJabatan;
                tbNamaDriver.Text = ReqData.Driver;
                tbKodeRegister.Text = ReqData.KodeRegister;
                tbKodeRegister2.Text = ReqData.KodeRegister2;
                cbKelurahan.Text = ReqData.LokasiDesa;

                cbKabupaten.Text = ReqData.LokasiKab;
                cbKecamatan.Text = ReqData.LokasiKec;
                tbLuasLahan.Text = ReqData.LuasLahan.ToString();
                tbNamaKUD.Text = ReqData.NamaKUD;
                tbNamaPetani1.Text = ReqData.NamaPetani;// tiket.NamaPetani;
                tbNamaPetani2.Text = ReqData.NamaPetani2;//
                tbNoTiketTTA.Text = ReqData.NoTiket;//
                tbNoTruck.Text = ReqData.NoTruck;//
                tbpenanggungjawabRegion.Text = ReqData.PenanggungJawab;
                tbPenanggunjawabJabatan.Text = ReqData.PenanggungJawabJabatan;
                tbVarietas.Text = ReqData.VarietasTebu;
                tbKodeMitra.Text = ReqData.KodeMitra;
                dtTglKontrak.Value = Convert.ToDateTime(ReqData.tglKontrak == null ? new DateTime(2015, 1, 1) : ReqData.tglKontrak);
                dtTTA.Value = Convert.ToDateTime(ReqData.tglTTA == null ? new DateTime(2015, 1, 1) : ReqData.tglTTA);

                tbKategori.Text = ReqData.kategori;
                tbestch.Text = ReqData.est_tch.ToString();
                tbritase.Text = ReqData.est_ritase.ToString();
                tbhasilpanen.Text = ReqData.est_hasil_panen.ToString();
                tbradius.Text = ReqData.est_radius;
                tbRayon.Text = ReqData.rayon;
                tbNoKontrak.Text = ReqData.no_kontrak;
                dtTGLPanen.Value = Convert.ToDateTime(ReqData.tgl_panen == null ? new DateTime(2015, 1, 1) : ReqData.tgl_panen);


                btSimpan.Text = "Perbaharui";
                btReset.Visible = true;

            }
            else
            {
                tbKategori.Text = "-";
                tbestch.Text = "0";
                tbritase.Text = "0";
                tbhasilpanen.Text = "0";
                tbradius.Text = "0";
                tbRayon.Text = "-";
                tbNoKontrak.Text = "-";
                //dtTGLPanen.Value = DateTime.Now.ToString();
            }
        }
        //private void tbNamaPetani1_LostFocus(object sender, EventArgs e)
        //{
        //    if (GridList.Focused)
        //        GridList.Visible=true;
        //    // Update the other text boxes here
        //}
        private void GridLayout()
        {
            GridList.Columns[2].HeaderText = "PETANI";
            GridList.Columns[6].HeaderText = "ALAMAT";
            //GridList.Columns[21].HeaderText = "KAB";
            GridList.Columns[1].HeaderText = "KODE";
            foreach (DataGridViewColumn c in GridList.Columns)
            {
                //Console.WriteLine(c.Index);
                if (c.Index != 1 && c.Index != 2 && c.Index != 6)// && c.Index != 21)
                {
                    c.Visible = false;
                }
                else
                {
                    if (c.Index == 1) { c.Width = 100; }
                    if (c.Index == 2) { c.Width = 125; }
                    if (c.Index == 6) { c.Width = 125; }
                    //if (c.Index == 21) { c.Width = 60; }
                    c.DefaultCellStyle.Font = new Font("Segoe UI", 9F, GraphicsUnit.Pixel);
                }
            }
        }
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



        public void ResetControl()
        {
            tbAlamatPetani1.Text = "";
            tbAlamatPetani2.Text = "";
            tbDibuatOleh.Text = "";
            tbDiserahkanOlehJabatan.Text = "";
            tbNamaDriver.Text = "";
            tbKodeRegister.Text = "";
            tbKodeRegister2.Text = "";
            cbKelurahan.Text = "";
            cbKabupaten.Text = "";
            cbKecamatan.Text = "";
            tbLuasLahan.Text = "0.00";
            tbNamaKUD.Text = "";
            tbNamaPetani1.Text = "";// tiket.NamaPetani;
            tbNamaPetani2.Text = "";//
            tbNoTiketTTA.Text = "";//
            tbNoTruck.Text = "";//
            tbpenanggungjawabRegion.Text = "";
            tbPenanggunjawabJabatan.Text = "";
            tbVarietas.Text = "";
            tbKodeMitra.Text = "";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            List<bool> containErr = new List<bool>();
            containErr.Add(CheckError(tbAlamatPetani1));
            //containErr.Add(CheckError(tbAlamatPetani2));
            containErr.Add(CheckError(tbDibuatOleh));
            //containErr.Add(CheckError(tbDiserahkanOlehJabatan));
            //containErr.Add(CheckError(tbNamaDriver));
            //containErr.Add(CheckError(tbKodeRegister));
            //containErr.Add(CheckError(tbKodeRegister2));
            containErr.Add(CheckError(tbKodeMitra));
            //containErr.Add(CheckError(cbKelurahan));
            //containErr.Add(CheckError(cbKabupaten));
            //containErr.Add(CheckError(cbKecamatan));
            containErr.Add(CheckError(tbNamaKUD));
            containErr.Add(CheckError(tbNamaPetani1));
            //containErr.Add(CheckError(tbNamaPetani2));
            //containErr.Add(CheckError(tbNoTiketTTA));
            //containErr.Add(CheckError(tbNoTruck));
            containErr.Add(CheckError(tbpenanggungjawabRegion));
            containErr.Add(CheckError(tbPenanggunjawabJabatan));
            containErr.Add(CheckError(tbVarietas));

            if (!containErr.Contains(false))
            {

                Context.Tiket u = new Context.Tiket();

                u.Alamat = tbAlamatPetani1.Text;
                u.DibuatOleh = tbDibuatOleh.Text;
                u.DiserahkanOlehJabatan = Login2.UserLogin.Username.ToString();
                u.LokasiDesa = cbKelurahan.Text;
                u.LokasiKab = cbKabupaten.Text;
                u.LokasiKec = cbKecamatan.Text;
                u.LuasLahan = Convert.ToDecimal(tbLuasLahan.Text);
                u.NamaKUD = tbNamaKUD.Text;
                u.NamaPetani = tbNamaPetani1.Text;// tiket.NamaPetani;
                u.NoTiket = tbNoTiketTTA.Text;//
                u.PenanggungJawab = tbpenanggungjawabRegion.Text;
                u.PenanggungJawabJabatan = tbPenanggunjawabJabatan.Text;
                u.VarietasTebu = tbVarietas.Text;
                u.KodeMitra = tbKodeMitra.Text;
                u.tglKontrak = dtTglKontrak.Value.Date;
                u.tglTTA = dtTTA.Value.Date;
                u.kategori =tbKategori.Text;
                u.est_tch=Convert.ToDecimal(tbestch.Text);
                u.est_ritase = Convert.ToDecimal(tbritase.Text);
                u.est_hasil_panen = Convert.ToDecimal(tbhasilpanen.Text);
                u.est_radius = tbradius.Text;
                u.rayon = tbRayon.Text;
                u.no_kontrak=tbNoKontrak.Text;
                u.tgl_panen = dtTGLPanen.Value.Date;

                if (TiketID > 0)
                {
                    u.ID = TiketID;
                    //SIMPAN EDITED TIKET DALAM HISTORY TABLE TIKET
                    GlobalController.InsertHistoryTiket(u.ID);
                }
                else
                {
                    TiketID = 0;
                    u.ID = 0;
                }
               
                //SIMPAN EDITED TIKET
                var t = GlobalController.SaveTiket(u, Login2.UserLogin);

                if (TiketID > 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data Berhasil diperbaharui", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information );
                    this.Close();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data Berhasil disimpan", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information );
                    //ResetControl();
                    TiketID = t.ID;
                    this.Close();
                }
            }
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
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            //var y = GlobalController.GetTiketByID(TTAListForm.tiket_id);
            //if (y != null)
            //{
            //    var u = y;
            //    var t = System.Configuration.ConfigurationSettings.AppSettings["templateTiket"];// Path.Combine(System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]), @"\template\Template KTM.xls");
            //    var outpa = System.Configuration.ConfigurationSettings.AppSettings["outPath"];// Path.Combine(System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]), @"\template\Template KTM.xls");
            //    int i = 1;

            //    SRS.DeskApp.Controller.Repository.ClearFolder(@outpa);

            //    string datePrint = DateTime.Now.ToString("yyyy-MM-dd") + @"\";
            //    Workbook wb = new Workbook(t);
            //    var ws = wb.Worksheets[0];

            //    ws.Cells["H5"].Value = u.NoTiket;
            //    ws.Cells["H6"].Value = u.NamaKUD;
            //    ws.Cells["H8"].Value = Convert.ToDateTime( u.tglKontrak).ToString("dd MMM yyyy");
            //    ws.Cells["C9"].Value = u.NamaPetani;
            //    ws.Cells["C10"].Value = u.KodeRegister;
            //    ws.Cells["C11"].Value = u.Alamat;
            //    ws.Cells["C12"].Value = u.NoTruck;
            //    ws.Cells["C13"].Value = u.VarietasTebu;
            //    ws.Cells["C14"].Value = u.LokasiDesa;
            //    ws.Cells["C15"].Value = u.LokasiKec;
            //    ws.Cells["C16"].Value = u.LokasiKab;

            //    ws.Cells["B28"].Value = u.DiserahkanOleh;
            //    ws.Cells["E28"].Value = u.PenanggungJawab;

            //    string name = @outpa + datePrint + "Tiket.xlsx";

            //    if (!Directory.Exists(@outpa + datePrint))
            //    {
            //        Directory.CreateDirectory(@outpa + datePrint);
            //    }

            //    wb.Save(name, SaveFormat.Xlsx);
            //    i++;
            //    try
            //    {
            //        wb.Save(@outpa + datePrint + "Tiket.pdf", SaveFormat.Pdf);
            //        if (MetroFramework.MetroMessageBox.Show(this, string.Format("File Berhasil disimpan di : {0} \nApakah anda akan membuka file?", @outpa + datePrint), "Informasi", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            //        {
            //            System.Diagnostics.Process.Start(@outpa + datePrint + "TIKET.pdf");
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        MetroFramework.MetroMessageBox.Show(this, string.Format("Terjadi Kesalahan, \nSilahkan tutup file {0} agar proses generate file dapat dilakukan", @outpa + datePrint + "Tiket.pdf"), "Informasi", MessageBoxButtons.OK);
            //    }

            //}
            //else
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Tidak ada data yang akan dicetak", "Informasi", MessageBoxButtons.OK);
            //}
        }

      

        private void tbDiserahkanOlehJabatan_Click(object sender, EventArgs e)
        {

        }

        private void tbNamaDriver_Click(object sender, EventArgs e)
        {

        }

        private void tbNoTiketTTA_Click(object sender, EventArgs e)
        {

        }

        private void tbNamaPetani1_Click(object sender, EventArgs e)
        {
            GridList.Visible = true;
        }
        BindingListView<Context.Masterlist2> biUser;
        private void tbNamaPetani1_TextChanged(object sender, EventArgs e)
        {
            //GridList.Visible = true;

            var t = GlobalController.SearchMasterPetani(tbNamaPetani1.Text, 0, 100);
            biUser = new BindingListView<Context.Masterlist2>(t);
            GridList.DataSource = biUser;
        }

        private void GridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Petani2;
            Petani2 = (int)GridList.Rows[e.RowIndex].Cells[0].Value;

            //Console.WriteLine(GridList.Rows[e.RowIndex].Cells[3].Value);
            
            listpetani = GlobalController.GetPetani2(Petani2);
            tbKodeMitra.Text = listpetani.kode_mitra;
            tbNamaPetani1.Text = listpetani.nama_mitra;
            tbAlamatPetani1.Text = listpetani.alamat_ktp;
            cbKecamatan.Text = listpetani.kecamatan;
            cbKabupaten.Text = listpetani.kabupaten;
            cbKelurahan.Text = listpetani.kelurahan;
            tbVarietas.Text = listpetani.varietas;
            tbpenanggungjawabRegion.Text = listpetani.penanggung_jawab;
            tbNamaPetani2.BackColor = Color.White;
            tbKategori.Text = listpetani.kategori;
            tbestch.Text = listpetani.est_tch.ToString();
            tbritase.Text = listpetani.est_ritase.ToString();
            tbhasilpanen.Text = listpetani.est_hasil_panen.ToString();
            tbradius.Text = listpetani.est_radius;
            tbRayon.Text = listpetani.rayon;
            tbNoKontrak.Text = listpetani.no_kontrak;
            dtTGLPanen.Value = Convert.ToDateTime(listpetani.tgl_panen);
            tbDibuatOleh.Text = Login2.UserLogin.Username.ToString();

            btSimpan.Enabled = true;
            btReset.Enabled = true;
            //btSimpan.Enabled = false;
            GridList.Visible = false;
        }

        private void GridList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbNoTiketTTA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDibuatOleh.Text = Login2.UserLogin.Username.ToString();

                dtTTA.Focus();
                //SendKeys.Send("{TAB}");
                //e.Handled = true;
                //e.SuppressKeyPress = true;
            }
        }

        private void tbNamaPetani1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GridList.Visible = false;
            }
        }

        private void cbKecamatan_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void tbLuasLahan_Click(object sender, EventArgs e)
        {

        }

        private void tbLuasLahan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbLuasLahan.Text.Length == 0)
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
            if (e.KeyChar == '.' && tbLuasLahan.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void tbLuasLahan_Click_1(object sender, EventArgs e)
        {

        }

        private void tbNoTiketTTA_Leave(object sender, EventArgs e)
        {
            tbDibuatOleh.Text = Login2.UserLogin.Username.ToString();
        }

        private void tbNoTiketTTA_Validating(object sender, CancelEventArgs e)
        {
            if (tbNoTiketTTA.Text != "")
            {
                string msg = "";
                var notiket = tbNoTiketTTA.Text;
                tiketing = GlobalController.GetTiketByNoTTA(notiket);
                if (tiketing != null)
                {
                    string msg2 = "Nomor Tiket sudah ada pada daftar Master Tiket";
                    bool valids = GlobalController.ValidasiPendaftaranTiket(notiket, out msg);
                    if (valids == true) //NEW REGISTERED
                    {
                        MetroMessageBox.Show(this, msg2 + "\r\n" + msg, "Validasi TTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbNoTiketTTA.Text = "";
                        e.Cancel = true;
                    }
                    else
                    {
                        MetroMessageBox.Show(this, msg2, "Validasi TTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbNoTiketTTA.Text = "";
                        e.Cancel = true;
                    }
                }
            }
        }

        private void tbNamaPetani1_Enter(object sender, EventArgs e)
        {
            if (GridList.Visible == true)
            {
                GridList.Visible = false;
            }
            else
            {
                GridList.Visible = true;
            }
        }

        private void tbNamaPetani1_Leave(object sender, EventArgs e)
        {

            //GridList.Visible = false;
            //if (GridList.Focused)
            //    GridList.Visible = true;
            //else
            //    GridList.Visible = false;
        }

        private void GridList_Enter(object sender, EventArgs e)
        {
            GridList.Visible = true;
        }

        private void GridList_Leave(object sender, EventArgs e)
        {
            GridList.Visible = true;
        }

        private void GridList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbKelurahan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
