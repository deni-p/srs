using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SRS.DeskApp.Context;
using SRS.DeskApp.Controller;
using SRS.DeskApp.DAO;
using System.Diagnostics;

namespace SRS.DeskApp
{
    public partial class TimbanganOut : SRS.DeskApp.MetroForm
    {
        public TimbanganOut()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<tbl_transit_scan_id_timbangan> list = GlobalController.GetTransitScanIDTimbanganOut();
            List<device_config> devices = GlobalController.GetDeviceConfigByLocation("TIMBANG OUT");
            Dictionary<int, tbl_transit_timbangan> timbangs = GlobalController.GetStatusTransitTimbangan2();
            foreach (tbl_transit_scan_id_timbangan t in list)
            {

                tbl_transit_timbangan t2 = null;
                timbangs.TryGetValue(t.base_entry, out t2);
                if (t2 == null) continue;
                switch (t.status_out)
                {
                    case 1:
                        this.Invoke((MethodInvoker)delegate
                        {
                            foreach (device_config d in devices)
                            {
                                switch (d.id)
                                {
                                    case 1:
                                        tbCarID1.Text = t.car_id;
                                        tbNetto1.Text = t2.car_weight.ToString();
                                        tbDriver1.Text = t.driver;
                                        break;
                                    case 2:
                                        tbCarID2.Text = t.car_id;
                                        tbNetto2.Text = t2.car_weight.ToString();
                                        tbDriver2.Text = t.driver;
                                        break;
                                    case 3:
                                        tbCarID3.Text = t.car_id;
                                        tbNetto3.Text = t2.car_weight.ToString();
                                        tbDriver3.Text = t.driver;
                                        break;
                                }
                                
                            }
                        });
                        break;
                    case 2:
                        break;
                }
            }
        }
        private bool startProcess(string workDir, string pathFile, string args)
        {
            bool status = false;
            try
            {
                //192.168.1.100
                Process p = new Process();
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.WorkingDirectory = workDir;
                p.StartInfo.FileName = pathFile;
                p.StartInfo.Arguments = args;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                status = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Start Process Error:" + ex.Message);
                status = false;
            }

            return status;
        }
        private void print1_Click(object sender, EventArgs e)
        {
            tbl_transit_timbangan t;
            //tbl_pendaftaran_mobil m;
            report1.Load(@"report\invoice.frx");
            (report1.FindObject("txtNamaPetani") as FastReport.TextObject).Text = "[nama_petani]";
            (report1.FindObject("txtTTA") as FastReport.TextObject).Text = "[tta_number]";
            (report1.FindObject("txtCarID") as FastReport.TextObject).Text = "[car_id]";
            (report1.FindObject("txtDriver") as FastReport.TextObject).Text = "[driver]";
            (report1.FindObject("txtDateIn") as FastReport.TextObject).Text = "[date_in]";
            (report1.FindObject("txtDateOut") as FastReport.TextObject).Text = "[date_out]";
            (report1.FindObject("txtGrossWeight") as FastReport.TextObject).Text = "[gross_weight]";
            (report1.FindObject("txtCarWeight") as FastReport.TextObject).Text = "[car_weight]";
            (report1.FindObject("txtNetto") as FastReport.TextObject).Text = "[netto]";
            (report1.FindObject("txtRendemen") as FastReport.TextObject).Text = "[rendemen]";
            (report1.FindObject("txtHargaTebu") as FastReport.TextObject).Text = "[harga_tebu]";
            (report1.FindObject("txtPotongan") as FastReport.TextObject).Text = "[potongan]";
            (report1.FindObject("txtNilai") as FastReport.TextObject).Text = "[nilai]";
            report1.Show();
        }

        private void save1_Click(object sender, EventArgs e)
        {
            string workDir=System.IO.Directory.GetCurrentDirectory()+@"\app\timbangmasuk\";
            startProcess(workDir, "PTimbangMasuk.exe", "");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            report1.Load(@"report\invoice.frx");
            report1.Design();
        }
    }
}
