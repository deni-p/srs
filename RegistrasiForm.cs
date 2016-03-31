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
using MetroFramework.Controls;
using SRS.DeskApp.DAO;
using System.Diagnostics;
using System.IO;
using Equin.ApplicationFramework;


namespace SRS.DeskApp
{
    public partial class RegistrasiForm : MetroForm
    {
        //private string ttaNumber;
        private int status_baca_kartu = 0;
        private Context.Tiket tiket;
        private Context.Masterlist2 listpetani;
        private Context.tbl_pendaftaran_mobil pendaftaran;
        private bool regstatus =false;
        

        //Context.tbl_pendaftaran_mobil t2 = GlobalController.GetPendaftaranMobil(tiket.NoTiket);
       

        //private bool found = false;
        public RegistrasiForm()
        {
            InitializeComponent();
        }

        private void RegistrasiForm_Load(object sender, EventArgs e)
        {

            BindingListView<Context.Masterlist2> biUser;
            var datas = GlobalController.RefershPetani(100);
            biUser = new BindingListView<Context.Masterlist2>(datas);
            GridList.DataSource = biUser;
            tbNoTiketTTA.Focus();
            GridLayout();
            GridList.Visible = false;
            GridList.Left = tbAlamatPetani1.Left;
            GridList.Top = tbNamaPetani2.Top + tbNamaPetani2.Height+3;
            GridList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //tbNamaPetani2.GotFocus += new System.EventHandler(this.tbNamaPetani2_GotFocus);
        }
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
        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (tiket == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "No TTA tidak Terdaftar", "Informasi", MessageBoxButtons.OK);
                return;
            }

            if (tbNoTruck.Text == "" || tbNoTruck.Text == "-" )
            {
                MetroFramework.MetroMessageBox.Show(this, "Anda belum memasukkan Nomor Kendaraan", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Exclamation );
                tbNoTruck.BackColor = Color.Gold;
                tbNoTruck.Focus();

                return;
            }
            if (tbNamaDriver.Text == "" || tbNamaDriver.Text == "-")
            {
                MetroFramework.MetroMessageBox.Show(this, "Anda belum memasukkan Nama Driver", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbNamaDriver.BackColor = Color.Gold;
                tbNamaDriver.Focus();
                return;
            }
            if (tbLuasPanen.Text == "0.00" || tbLuasPanen.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Anda belum memasukkan Estimasi Luas Panen", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbLuasPanen.BackColor = Color.Gold;
                tbLuasPanen.Focus();
                return;
            }
            if (tbNamaPetani2.Text == "-" || tbNamaPetani2.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Anda belum melakukan validasi nama dan kode petani", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MChkValidasi.Focus();
                return;
            }

            tiket.NamaPetani = tbNamaPetani1.Text;
            tiket.NamaPetani2 = tbNamaPetani2.Text;
            tiket.KodeMitra = tbKodeMitra.Text;
            tiket.KodeMitra2 = tbKodeMitra2.Text;
            tiket.est_luas_panen  = Convert.ToDecimal(tbLuasPanen.Text);
            tiket.NamaKUD = tbNamaKUD.Text;
            tiket.Driver = tbNamaDriver.Text;
            tiket.NoTruck = tbNoTruck.Text;
            tiket.CreateDate = DateTime.Now;
            tiket.UpdateDate   = DateTime.Now;
            tiket.Alamat = tbAlamatPetani1.Text;

            tiket.VarietasTebu = tbVarietas.Text;
            tiket.LokasiDesa = tbDesa.Text;
            tiket.LokasiKab = tbKab.Text;
            tiket.LokasiKec = tbKec.Text;
            tiket.DibuatOleh = Login2.UserLogin.Username.ToString();
            tiket.DiserahkanOlehJabatan = tbJabatan.Text;
            tiket.PenanggungJawab = tbpenanggungjawabRegion.Text;
            tiket.PenanggungJawabJabatan = tbJabatan2.Text;
            tiket.rayon = tbRayon.Text;

            lblProgress.Text = "Silahkan Ditunggu Sedang Proses Menyimpan Data";
            lblProgress.Visible = true;
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Enabled = true;
            Application.DoEvents();

            new System.Threading.Thread(() =>
            {
                string msgError = GlobalController.SavePendaftaranMobil(tiket, Login2.UserLogin, chkGandengan.Checked);
                this.Invoke((MethodInvoker)delegate
                {
                    lblProgress.Visible = false;
                    progressBar1.Visible = false;
                    lblProgress.Enabled = false;

                    if (msgError != "")
                    {
                        MessageBox.Show(msgError);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(this,"Simpan Data Sukses...Silahkan tekan tombol TAB","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information );
                    }
                    pendaftaran = GlobalController.GetPendaftaranMobil(tiket, out msgError);
                    if (pendaftaran != null)
                    {
                        btnTab.Enabled = true;
                        btSimpan.Enabled = false;
                        btReset.Enabled = false;
                        lblStatusWrite.Text = "Silahkan Tekan Tombol Tab, Untuk Meyimpan Data Ke Kartu";
                        btnTab.Focus();
                    }
                    else
                    {
                        MessageBox.Show(msgError);
                    }
                });
                
            }).Start();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (tbNoTiketTTA.Text != "")
            {
                string msg = "";
                var notiket = tbNoTiketTTA.Text;
                bool valids = GlobalController.ValidasiPendaftaranTiket(notiket, out msg);

                if (valids == false) //NEW REGISTERED
                {
                    regstatus = true;

                    tiket = GlobalController.GetTiketByNoTTA(notiket);
                    if (tiket == null)
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "No TTA tidak Terdaftar\r\nApakah anda memasukkan Petani Non Register ?", "Informasi", MessageBoxButtons.OKCancel ,MessageBoxIcon.Warning);
                        DialogResult dialogResult = MetroMessageBox.Show(this, "Nama Petani tidak terdaftar\r\nSilahkan melakukan pendaftaran Petani baru", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogResult == DialogResult.Yes)
                        {
                            tbTglTTA.Text = DateTime.Now.ToString();
                            return;
                        }
                        else
                        {
                            return;
                        }

                    }
                    btSimpan.Enabled = true;
                    btReset.Enabled = true;
                    btnTab.Enabled = false;

                    tbNamaKUD.Text = tiket.NamaKUD;
                    tbNamaPetani1.Text = tiket.NamaPetani;
                    tbNamaPetani2.Text = "-";// tiket.NamaPetani2;
                    tbKodeMitra.Text = tiket.KodeMitra;
                    tbKodeMitra2.Text = "-";// tiket.KodeMitra2;
                    tbAlamatPetani1.Text = tiket.Alamat;
                    //tbAlamatPetani2.Text = tiket.Alamat2;
                    tbTglTTA.Text = tiket.tglTTA.ToString();
                    tbTglRegister.Text = DateTime.Now.Date.ToString();
                    tbLuasPanen.Text = "0.00";// tiket.LuasLahan.ToString();
                    tbVarietas.Text = tiket.VarietasTebu;
                    tbKec.Text = tiket.LokasiKec;
                    tbKab.Text = tiket.LokasiKab;
                    tbDesa.Text = tiket.LokasiDesa;
                    tbDibuatOleh.Text = tiket.DibuatOleh;
                    tbJabatan.Text = "Operator";// tiket.DiserahkanOlehJabatan;
                    tbpenanggungjawabRegion.Text = tiket.PenanggungJawab;
                    tbJabatan2.Text = "Supervisor";// tiket.PenanggungJawabJabatan;
                    tbNamaDriver.Text = "-";// tiket.Driver;
                    tbNoTruck.Text = "-"; //tiket.NoTruck;
                }
                // REGISTERED TTA ALREADY EXIST
                else
                {
                    regstatus = false;
                    MetroMessageBox.Show(this, msg, "Validasi TTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbNoTiketTTA.Text = "";
                    tbNoTiketTTA.Focus();
                }
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private bool startProcess(string app, string param)
        {
            try
            {
                Console.WriteLine("Current Directory:" + Directory.GetCurrentDirectory());
                Process p = new Process();
                
               // System.Diagnostics.ProcessStartInfo p = new System.Diagnostics.ProcessStartInfo();
                p.StartInfo.WorkingDirectory = @System.IO.Directory.GetCurrentDirectory()+@"\app\registrasi\";
                p.StartInfo.FileName = app;
                p.StartInfo.Arguments = param;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.WaitForExit();
                //System.Diagnostics.Process.Start(p);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Error Execute File:" + app + " Param:" + param);
                return false;
            }
        }
        private void btnTab_Click(object sender, EventArgs e)
        {
            btnTab.Enabled = false;
            lblStatusWrite.Visible = true;
            //Simpan ke kartu
            new System.Threading.Thread(() =>
            {
                Console.WriteLine("Write Kartu DocEntry:" + pendaftaran.doc_entry.ToString());
                if (startProcess(@"PRegistrasi.exe", pendaftaran.doc_entry.ToString()))
                {
                    int count = 0;
                    while (true)
                    {

                      Context.tbl_pendaftaran_mobil t2=GlobalController.GetStatusTulisKartu(pendaftaran.doc_entry);
                      if (t2.status == 1)
                      {
                          this.Invoke((MethodInvoker)delegate{
                              MessageBox.Show("Tulis Pendaftaran Kartu SUkses...");
                          });
                          break;
                      }
                      System.Threading.Thread.Sleep(1000);
                      count++;
                    }
                    Console.WriteLine("Registrasi Kartu Sukses....");
                    //btReset.Enabled = true;
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show("Tulis Pendaftaran Kartu Error, Silahkan Ulangi Lagi...");
                        btnTab.Enabled = true;
                    });   
                }
            }).Start();
            btReset.Enabled = true;
            //bgMonitorStatusKartu.RunWorkerAsync();            
        }

        private void bgMonitorStatusKartu_DoWork(object sender, DoWorkEventArgs e)
        {
            int cnt = 0;
            while (!bgMonitorStatusKartu.CancellationPending)
            {
                var data = GlobalController.CekStatusReadWriteKartu(tbNoTiketTTA.Text);
                status_baca_kartu = data.status.Value;
                if (status_baca_kartu == 1)
                {
                    break;
                }
                else
                {
                    cnt++;
                    if (cnt >= 5) //tunggu sampai 5 detik
                    {
                        break;
                    }
                }
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
        public void ResetControl()
        {
            tbAlamatPetani1.Text = "";
            tbDibuatOleh.Text = "";
            tbNamaDriver.Text = "";
            tbKodeMitra.Text = "";
            tbKodeMitra2.Text = "";
            tbDesa.Text = "";
            tbKab.Text = "";
            tbKec.Text = "";
            tbLuasPanen.Text = "0.00";
            tbNamaKUD.Text = "";
            tbNamaPetani1.Text = "";// tiket.NamaPetani;
            tbNamaPetani2.Text = "";//
            tbNoTiketTTA.Text = "";//
            tbNoTruck.Text = "";//
            tbpenanggungjawabRegion.Text = "";
            tbDibuatOleh.Text = "";
            tbJabatan.Text = "";
            tbJabatan2.Text = "";
            tbVarietas.Text = "";
            tbKodeMitra.Text = "";
        }
        private void bgMonitorStatusKartu_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (status_baca_kartu == 1)
            {
                lblStatusWrite.Text = "Proses Menyimpan Data Ke Kartu Sukses";                
            }
            status_baca_kartu = 0;
        }

        private void bgWorkerSearchTTA_DoWork(object sender, DoWorkEventArgs e)
        {
            var notiket = tbNoTiketTTA.Text;
            tiket = GlobalController.GetTiketByNoTTA(notiket);
            bgWorkerSearchTTA.ReportProgress(1);
            if (tiket != null)
            {
                bool gandengan = false;
                this.Invoke((MethodInvoker)delegate
                {
                    gandengan = chkGandengan.Checked;
                });
                GlobalController.SavePendaftaranMobil(tiket, Login2.UserLogin, gandengan);
            }

        }

        private void bgWorkerSearchTTA_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                
            }
        }

        private void bgWorkerSearchTTA_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void lblStatusWrite_Click(object sender, EventArgs e)
        {

        }

        private void tbNumCard_Click(object sender, EventArgs e)
        {

        }

        private void tbNoTiketTTA_Click(object sender, EventArgs e)
        {

        }

        private void tbNoTiketTTA_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("test");
            if (e.KeyCode == Keys.Enter && tbNoTiketTTA.Text != "-" && tbNoTiketTTA.Text != "")
            { 
                metroButton1_Click(sender, null);
                if (regstatus == true)
                {
                    tbNoTruck.Focus();
                }
                    
                //SendKeys.Send("{TAB}");
                //e.Handled = true;
                //e.SuppressKeyPress = true;
            }
            
        }

        private void lblProgress_Click(object sender, EventArgs e)
        {

        }

        private void MChkValidasi_CheckedChanged(object sender, EventArgs e)
        {
            if (MChkValidasi.Checked)
            {
                tbNamaPetani2.Text = tbNamaPetani1.Text;
                tbKodeMitra2.Text = tbKodeMitra.Text;
            }
            else
            {
                tbNamaPetani2.Text = "-";
                tbKodeMitra2.Text = "-";
            }
        }

        private void chkGandengan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbNamaPetani2_Click(object sender, EventArgs e)
        {
            //GridList.Visible = true;
        }

        public static BindingListView<Context.Masterlist2> MasterlistsPublic;
        private void tbNamaPetani2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GridList.Visible = false;
            }
            ////GridList.Visible = true;
            //if (e.KeyCode == Keys.Enter)
            //{
            //    var Petani2 = tbNamaPetani2.Text;
            //    listpetani = GlobalController.GetPetani2(Petani2);

            //    if (listpetani == null)
            //    {
            //        //DialogResult dialogResult = MetroMessageBox.Show(this,"Nama Petani tidak terdaftar\r\nEntry ke master petani ", "Konfirmasi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //        DialogResult dialogResult = MetroMessageBox.Show(this,"Nama Petani tidak terdaftar\r\nSilahkan melakukan pendaftaran", "Konfirmasi", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation );
            //        //if (dialogResult == DialogResult.Yes)
            //        //{
            //        //    MasterListEntryForm f = new MasterListEntryForm();
            //        //    MasterListEntryForm.SendData = null;
            //        //    MasterListEntryForm.isOpenFromMaster = false;
            //        //    f.ShowDialog();
            //        //    //Context.Masterlist2 newData = MasterListEntryForm.masterData;

            //        //    //if (newData != null)
            //        //    //{
            //        //    //    var currentData = MasterlistsPublic.ToList();
            //        //    //    currentData.Add(newData);

            //        //    //    MasterlistsPublic = new BindingListView<Context.Masterlist2>(currentData);
            //        //    //    metroGrid1.DataSource = MasterlistsPublic;
            //        //    //    metroGrid1.Refresh();
            //        //    //    headerColumn();
            //        //    //}    
            //        //}
            //        //else
            //        //{
            //        //    return;
            //        //}
            //    }
            //    else
            //    {
            //        string strMessage =  "Nama Petani tidak sama dengan data TTA\r\nApakah anda akan mengupdate data dengan petani " + listpetani.nama_mitra;
            //        string test = listpetani.nama_mitra;

            //        DialogResult dialogResult = MetroMessageBox.Show(this,strMessage, "Konfirmasi", MessageBoxButtons.YesNo , MessageBoxIcon.Question );
            //        if (dialogResult == DialogResult.Yes)
            //        {
            //            tbNamaPetani2.Text = listpetani.nama_mitra;
            //            tbKodeMitra2.Text = listpetani.kode_mitra;
            //            tbAlamatPetani1.Text = listpetani.alamat_ktp;
            //            tbKec.Text = listpetani.kecamatan;
            //            tbKab.Text = listpetani.kabupaten;
            //            tbDesa.Text = listpetani.kelurahan;
            //            tbVarietas.Text = listpetani.varietas;
            //            tbpenanggungjawabRegion.Text = listpetani.penanggung_jawab;
            //            tbNamaPetani2.BackColor = Color.White;

            //        }
            //    }
            //    btSimpan.Enabled = true;
            //    btnTab.Enabled = false;
            //}
        }

        private void tbNoTruck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                tbNoTruck.BackColor = Color.White;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbNamaDriver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                tbNamaDriver.BackColor = Color.White;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void chkGandengan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbTglTTA_Click(object sender, EventArgs e)
        {

        }

        private void tbTglTTA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbNamaKUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbTglRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbNamaPetani1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbKodeMitra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbKodeMitra2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbAlamatPetani1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbLuasPanen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                tbLuasPanen.BackColor = Color.White;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void MChkValidasi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbVarietas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbDesa_Click(object sender, EventArgs e)
        {

        }

        private void tbDesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbKec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbKab_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbDibuatOleh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbJabatan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbpenanggungjawabRegion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbJabatan2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbpenanggungjawabRegion_Click(object sender, EventArgs e)
        {

        }

        private void tbNoTruck_Click(object sender, EventArgs e)
        {

        }
        public static BindingListView<Context.Masterlist2> Masterlistsbaru;
        private void metroButton2_Click(object sender, EventArgs e)
        {
            TTAEntryNonRegister f = new TTAEntryNonRegister();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            f.WindowState = FormWindowState.Normal;
        }

        private void lblProgress_Click_1(object sender, EventArgs e)
        {

        }
        BindingListView<Context.Masterlist2> biUser;
        private void tbNamaPetani2_TextChanged(object sender, EventArgs e)
        {
            //GridList.Visible = true;
            var t = GlobalController.SearchMasterPetani(tbNamaPetani2.Text, 0, 100);
            biUser = new BindingListView<Context.Masterlist2>(t);
            GridList.DataSource = biUser;
        }

        private void GridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Petani2;
            Petani2 =(int) GridList.Rows[e.RowIndex].Cells[0].Value;

            //Console.WriteLine(GridList.Rows[e.RowIndex].Cells[3].Value);

            listpetani = GlobalController.GetPetani2(Petani2);

            tbNamaPetani2.Text = listpetani.nama_mitra;
            tbKodeMitra2.Text = listpetani.kode_mitra;
            tbAlamatPetani1.Text = listpetani.alamat_ktp;
            tbKec.Text = listpetani.kecamatan;
            tbKab.Text = listpetani.kabupaten;
            tbDesa.Text = listpetani.kelurahan;
            tbVarietas.Text = listpetani.varietas;
            tbpenanggungjawabRegion.Text = listpetani.penanggung_jawab;
            tbNamaPetani2.BackColor = Color.White;
            tbRayon.Text = listpetani.rayon;

            btSimpan.Enabled = true;
            btReset.Enabled =true;
            btnTab.Enabled = false;
            GridList.Visible = false;
        }

        private void GridList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistrasiForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tbLuasPanen_Click(object sender, EventArgs e)
        {

        }

        private void tbLuasPanen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbLuasPanen.Text.Length == 0)
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
            if (e.KeyChar == '.' && tbLuasPanen.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void GridList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbNoTiketTTA_Click_1(object sender, EventArgs e)
        {

        }

        private void tbNamaPetani2_Leave(object sender, EventArgs e)
        {
            if (GridList.Focused)
                GridList.Visible = true;
            else
                GridList.Visible = false;
        }

        private void tbNamaPetani2_Enter(object sender, EventArgs e)
        {
            GridList.Visible = true;
            
        }

        private void GridList_Leave(object sender, EventArgs e)
        {
            GridList.Visible = false;
        }

        private void lblStatusWrite_Click_1(object sender, EventArgs e)
        {

        }


    }
}
