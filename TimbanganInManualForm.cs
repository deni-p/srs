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
using AForge.Video;

namespace SRS.DeskApp
{
    public partial class TimbanganInManualForm : MetroForm
    {
        public  Dictionary<int,string> noTimbangan;
        public tbl_transit_timbangan manualInput;
        private tbl_pendaftaran_mobil t;
        public TimbanganInManualForm()
        {
            InitializeComponent();
        }


        public int IDrequest;
        private void TimbanganInManualForm_Load(object sender, EventArgs e)
        {
           
            lbLine.Text = this.noTimbangan.FirstOrDefault().Key.ToString();
            var status =    this.noTimbangan.FirstOrDefault().Value.ToString();
            if (status.Equals("T"))
            {
                metroLabel2.Visible = false;
                tbBeratKotor.Visible = false;
            }

            //if (status.Equals("W"))
            //{
            //    var yu = GlobalController.GetSharedByID(IDrequest);

            //    tbDriver.ReadOnly= true;
            //    tbNoTTA.ReadOnly = true;
            //    tbNoMobil.ReadOnly = true;

            //    tbDriver.Text = yu.Driver;
            //    tbNoTTA.Text = yu.NoTTA;
            //    tbNoMobil.Text= yu.PlatNo;
            //}
        }

        public tbl_transit_timbangan response;
        private void btSimpan_Click(object sender, EventArgs e)
        {
            manualInput = new tbl_transit_timbangan();
            manualInput.gross_weight = Convert.ToDecimal(tbBeratKotor.Text);
            manualInput.driver = tbDriver.Text;
            manualInput.create_date =DateTime.Now;
            manualInput.date_in = DateTime.Now;
            manualInput.car_id = tbNoMobil.Text;
            manualInput.status_in = 1;

            try
            {
                response = GlobalController.SaveTimbanganManual(manualInput);

                MetroFramework.MetroMessageBox.Show(this, "Data Berhasil disimpan", "Informasi", MessageBoxButtons.OK);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                MetroFramework.MetroMessageBox.Show(this, "Terjadi kesalahan input", "Informasi", MessageBoxButtons.OK);
            
            }
            //this.Close();


        }

        private void btnSerchTTA_Click(object sender, EventArgs e)
        {
            t = GlobalController.GetPendaftaranByLastTTA(tbNoTTA.Text);
            if (t != null)
            {
                tbNoMobil.Text = t.car_id;
                tbDriver.Text = t.driver;
            }
            else
            {
                MessageBox.Show("Nomor TTA " + tbNoTTA.Text + " Belum Terdaftar Di Bagian pendaftaran");
            }
        }
        private void CloseCurrentVideoSource()
        {
            if (videoSourcePlayer1.VideoSource != null)
            {
                videoSourcePlayer1.SignalToStop();

                // wait ~ 3 seconds
                for (int i = 0; i < 30; i++)
                {
                    if (!videoSourcePlayer1.IsRunning)
                        break;
                    System.Threading.Thread.Sleep(100);
                }

                if (videoSourcePlayer1.IsRunning)
                {
                    videoSourcePlayer1.Stop();
                }

                videoSourcePlayer1.VideoSource = null;
            }
        }
        private void btnPlayCam_Click(object sender, EventArgs e)
        {
            MJPEGStream mjpegSource = new MJPEGStream(txtUrl.Text);
            if (checkBox1.Checked)
            {
                mjpegSource.Login = txtUsername.Text;
                mjpegSource.Password = txtPassword.Text;
            }
           
            OpenVideoSource(mjpegSource);
        }
        private void OpenVideoSource(IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // stop current video source
            CloseCurrentVideoSource();

            // start new video source
            videoSourcePlayer1.VideoSource = source;
            videoSourcePlayer1.Start();

            this.Cursor = Cursors.Default;
        }

        private void btnStopCam_Click(object sender, EventArgs e)
        {
            CloseCurrentVideoSource();
        }
    }
}
