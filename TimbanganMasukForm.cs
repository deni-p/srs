using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRS.DeskApp.DAO;
using SRS.DeskApp.Context;
using SRS.DeskApp.Model;
using System.Diagnostics;

namespace SRS.DeskApp
{
    public partial class TimbanganMasukForm : MetroForm
    {
        //string ip_gate1;
        //string ip_gate2;
        //string ip_gate3;
        //string ip_gate4;
        enum StateTimbangan { stNone, stGetInfoTimbangan, stFree, stDriverTab, stDialLedOn, stDialLedOnError, stDialLedOnOK, stDialLedOff, stDialLedOffError, stDialLedOffOK, stWaitTimbangan, stOpenBarrierGate, stWaitToFree }
        List<tbl_transit_scan_id_timbangan> listStatusScanIDTimbangan = new List<tbl_transit_scan_id_timbangan>();
        List<tbl_transit_scan_id_timbangan> listGateWaitToOpen = new List<tbl_transit_scan_id_timbangan>();
        //doc_entry, info timbangan
        Dictionary<int, InfoTimbangan> listInfoTimbangan = new Dictionary<int, InfoTimbangan>();
        Dictionary<int, tbl_transit_timbangan> listStatusTimbangan = new Dictionary<int, tbl_transit_timbangan>();
        Dictionary<int, StateTimbangan> lastState = new Dictionary<int, StateTimbangan>();
        Dictionary<int, string> ipaddress = new Dictionary<int, string>();

        //List<device_config> listDeviceConfig = new List<device_config>();

        ManualResetEvent evt = new ManualResetEvent(true);
        bool bgWorkerStart = false;
        bool waitToClose = false;
        bool requestCloseForm = false;
        DateTime startTime = new DateTime();
        TimeSpan elapsedTime = new TimeSpan();

        public TimbanganMasukForm()
        {
            InitializeComponent();
            //this.FormClosing += TimbanganMasukForm_FormClosing;
        }
        private void waitClose()
        {

        }



        private void TimbanganMasukForm_Load(object sender, EventArgs e)
        {
            bgWorkerStart = true;
            //lblTimer1.ForeColor = Color.Black;;

            // listDeviceConfig = GlobalController.GetDeviceConfigByLocation("Timbangan Masuk");
            bgWorkerMonitorTimbangan.RunWorkerAsync();
            //timer1.Start();
        }

        public void setColorButton(MetroButton mb, string Text)
        {
            mb.UseCustomBackColor = true;
            mb.Text = Text;
            mb.BackColor = Color.FromArgb(238, 43, 49); ; //  rgb
        }

        public void setReleaseButton(MetroButton bt, int noTim)
        {
            bt.UseCustomBackColor = true;
            bt.BackColor = Color.FromArgb(45, 204, 112); ; //  rgb

            bt.Text = "Release";
        }



        public void ReSetLabelDialogByTimer(MetroTextBox plat, MetroTextBox sopir, MetroTextBox ukuran)
        {
            plat.Text = "";
            sopir.Text = "";
            ukuran.Text = "0";
        }
        public void SetLabelDialogByTimer(tbl_transit_timbangan a, MetroTextBox plat, MetroTextBox sopir, MetroTextBox ukuran)
        {
            plat.Text = a.car_id;
            sopir.Text = a.driver;
            ukuran.Text = a.gross_weight.ToString();
        }

        public void SetLabelDialog(TimbanganInManualForm a, MetroTextBox plat, MetroTextBox sopir, MetroTextBox ukuran)
        {
            if (a.response != null)
            {
                plat.Text = a.response.car_id;
                sopir.Text = a.response.driver;
                ukuran.Text = a.response.gross_weight.ToString();
            }
        }

        public void ReSetButtonDialog(int lineID, MetroButton mb, Label lb)
        {
            mb.Text = lineID.ToString();
            mb.BackColor = Color.Gainsboro;
            lb.Text = "0";
        }


        public void SetSStatusShared(shared_timbangan_in temp)
        {
            temp.ID = 0;
            temp.Status = "S";
            // GlobalController.SaveTimbanganManual(temp);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            MetroButton btn = (MetroButton)sender;
            //string ip = btn.Tag.ToString();
            string ip = "";
            switch (int.Parse(btn.Tag.ToString()))
            {
                case 1:
                    ip = lbid1.Text;
                    break;
                case 2:
                    ip = lbid2.Text;
                    break;
                case 3:
                    ip = lbid3.Text;
                    break;
                case 4:
                    ip = lbid4.Text;
                    break;
                case 5:
                    ip = lbid5.Text;
                    break;
                case 6:
                    ip = lbid6.Text;
                    break;
            }

            if (btn.Text == "Open Gate")
            {
                btn.Enabled = false;
                string workDirectory = @System.IO.Directory.GetCurrentDirectory() + @"\app\opengate\";
                if (startProcess(workDirectory, "POpenGate.exe", ip))
                {
                    MessageBox.Show(this, "Open Gate Sukses...", "Timbangan Masuk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Open Gate Error...", "Timbangan Masuk", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //MessageBox.Show("Open Gate Error...");
                }

                btn.Enabled = false;
                btn.BackColor = Color.Gray;
                btn.ForeColor = Color.Black;
                btn.Text = btn.Tag.ToString();

                switch (int.Parse(btn.Tag.ToString()))
                {
                    case 1:
                        lbid1.Text = "";
                        t1plat.Text = "";
                        t1sopir.Text = "";
                        t1ukuran.Text = "";
                        break;
                    case 2:
                        lbid2.Text = "";
                        t2plat.Text = "";
                        t2sopir.Text = "";
                        t2ukuran.Text = "";
                        break;
                    case 3:
                        lbid3.Text = "";
                        t3plat.Text = "";
                        t3sopir.Text = "";
                        t3ukuran.Text = "";
                        break;
                    case 4:
                        lbid4.Text = "";
                        t4plat.Text = "";
                        t4sopir.Text = "";
                        t4ukuran.Text = "";
                        break;
                    case 5:
                        lbid5.Text = "";
                        t5plat.Text = "";
                        t5sopir.Text = "";
                        t5ukuran.Text = "";
                        break;
                    case 6:
                        lbid6.Text = "";
                        t6plat.Text = "";
                        t6sopir.Text = "";
                        t6ukuran.Text = "";
                        break;
                }
                //btn.Text = "";
            }

            else if (btn.Text == "Manual")
            {
                //mode deffault, jika di klik menampilkan form timbangan masuk manual
                TimbanganInManualForm a = new TimbanganInManualForm();

                a.noTimbangan = new Dictionary<int, string>();
                a.noTimbangan.Add(1, b1.Text);
                a.ShowDialog();
                if (a.response != null)
                {
                    SetLabelDialog(a, t1plat, t1sopir, t1ukuran);
                    b1.Text = "1";
                }
                a.noTimbangan.Remove(1);
            }
        }

        private bool startProcess(string workDirectory, string fileExe, string args)
        {
            bool status = false;
            try
            {
                Process p = new Process();
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.FileName = fileExe;
                //p.StartInfo.WorkingDirectory = @SRS.DeskApp.Setting.externalAppPath;// workDirectory;
                p.StartInfo.WorkingDirectory = Properties.Settings.Default.externalAppPath;
                p.StartInfo.Arguments = args;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
            }

            return status;
        }

        private void update_label_button(string label, string ip_address)
        {
            this.Invoke((MethodInvoker)delegate
            {
                List<device_config> list = GlobalController.GetDeviceConfigByLocation("TIMBANGAN IN");
                foreach (device_config d in list)
                {
                    if (ip_address == d.device_ip && d.id == 1)
                    {
                        b1.Text = label;
                        b1.UseCustomBackColor = true;
                        b1.UseCustomForeColor = true;
                        b1.BackColor = Color.Green;
                        b1.ForeColor = Color.White;
                        b1.Enabled = true;
                        break;
                    }
                    if (ip_address == d.device_ip && d.id == 2)
                    {
                        b2.Text = label;
                        b2.UseCustomBackColor = true;
                        b2.UseCustomForeColor = true;
                        b2.BackColor = Color.Green;
                        b2.ForeColor = Color.White;
                        b2.Enabled = true;
                        break;
                    }
                    if (ip_address == d.device_ip && d.id == 3)
                    {
                        b3.Text = label;
                        b3.UseCustomBackColor = true;
                        b3.UseCustomForeColor = true;
                        b3.BackColor = Color.Green;
                        b3.ForeColor = Color.White;
                        b3.Enabled = true;
                        break;
                    }
                    if (ip_address == d.device_ip && d.id == 4)
                    {
                        b4.Text = label;
                        b4.UseCustomBackColor = true;
                        b4.UseCustomForeColor = true;
                        b4.BackColor = Color.Green;
                        b4.ForeColor = Color.White;
                        b4.Enabled = true;
                        break;
                    }
                    if (ip_address == d.device_ip && d.id == 5)
                    {
                        b5.Text = label;
                        b5.UseCustomBackColor = true;
                        b5.UseCustomForeColor = true;
                        b5.BackColor = Color.Green;
                        b5.ForeColor = Color.White;
                        b5.Enabled = true;
                        break;
                    }
                    if (ip_address == d.device_ip && d.id == 6)
                    {
                        b6.Text = label;
                        b6.UseCustomBackColor = true;
                        b6.UseCustomForeColor = true;
                        b6.BackColor = Color.Green;
                        b6.ForeColor = Color.White;
                        b6.Enabled = true;
                        break;
                    }
                }

            });

        }

        private void update_info_timbangan(tbl_transit_timbangan t, device_config d)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    update_info_timbangan(t, d);
                    return;
                });
            }

            if (t.bridge_in_ip_address == d.device_ip && d.id == 1)
            {
                //t1ukuran.Text = Convert.ToDouble(t.gross_weight).ToString();
                t1ukuran.Text = string.Format("{0:#,##0}", double.Parse(t.gross_weight.ToString()));
                t1sopir.Text = t.driver;
                t1plat.Text = t.car_id;
                return;
            }
            if (t.bridge_in_ip_address == d.device_ip && d.id == 2)
            {
                t2ukuran.Text = string.Format("{0:#,##0}", double.Parse(t.gross_weight.ToString()));
                t2sopir.Text = t.driver;
                t2plat.Text = t.car_id;
                return;
            }
            if (t.bridge_in_ip_address == d.device_ip && d.id == 3)
            {
                t3ukuran.Text = string.Format("{0:#,##0}", double.Parse(t.gross_weight.ToString()));
                t3sopir.Text = t.driver;
                t3plat.Text = t.car_id;
                return;
            }
            if (t.bridge_in_ip_address == d.device_ip && d.id == 4)
            {
                t4ukuran.Text = string.Format("{0:#,##0}", double.Parse(t.gross_weight.ToString()));
                t4sopir.Text = t.driver;
                t4plat.Text = t.car_id;
                return;
            }
            if (t.bridge_in_ip_address == d.device_ip && d.id == 5)
            {
                t5ukuran.Text = string.Format("{0:#,##0}", double.Parse(t.gross_weight.ToString()));
                t5sopir.Text = t.driver;
                t5plat.Text = t.car_id;
                return;
            }
            if (t.bridge_in_ip_address == d.device_ip && d.id == 6)
            {
                t6ukuran.Text = string.Format("{0:#,##0}", double.Parse(t.gross_weight.ToString()));
                t6sopir.Text = t.driver;
                t6plat.Text = t.car_id;
            }

        }

        private void update_info_kendaraan(tbl_transit_scan_id_timbangan t, device_config d)
        {
            if (IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        Console.WriteLine(t.scan_in_ip_address + ":" + d.device_ip);
                        if (t.scan_in_ip_address == d.device_ip && d.id == 1)
                        {
                            //t1ukuran.Text = t..ToString();
                            t1sopir.Text = t.driver;
                            t1plat.Text = t.car_id;
                            b1.Tag = "1"; // t.scan_in_ip_address;
                            lbid1.Text = t.scan_in_ip_address;
                            return;
                        }
                        if (t.scan_in_ip_address == d.device_ip && d.id == 2)
                        {
                            // t2ukuran.Text = t.gross_weight.ToString();
                            t2sopir.Text = t.driver;
                            t2plat.Text = t.car_id;
                            b2.Tag = "2"; //t.scan_in_ip_address;
                            lbid2.Text = t.scan_in_ip_address;
                            return;
                        }
                        if (t.scan_in_ip_address == d.device_ip && d.id == 3)
                        {
                            // t3ukuran.Text = t.gross_weight.ToString();
                            t3sopir.Text = t.driver;
                            t3plat.Text = t.car_id;
                            b3.Tag = "3"; //t.scan_in_ip_address;
                            lbid3.Text = t.scan_in_ip_address;
                            return;
                        }
                        if (t.scan_in_ip_address == d.device_ip && d.id == 4)
                        {
                            //t4ukuran.Text = t.gross_weight.ToString();
                            t4sopir.Text = t.driver;
                            t4plat.Text = t.car_id;
                            b4.Tag = "4"; //t.scan_in_ip_address;
                            lbid4.Text = t.scan_in_ip_address;
                            return;
                        }
                        if (t.scan_in_ip_address == d.device_ip && d.id == 5)
                        {
                            //t5ukuran.Text = t.gross_weight.ToString();
                            t5sopir.Text = t.driver;
                            t5plat.Text = t.car_id;
                            b5.Tag = "5"; //t.scan_in_ip_address;
                            lbid5.Text = t.scan_in_ip_address;
                            return;
                        }
                        if (t.scan_in_ip_address == d.device_ip && d.id == 6)
                        {
                            //t6ukuran.Text = t.gross_weight.ToString();
                            t6sopir.Text = t.driver;
                            t6plat.Text = t.car_id;
                            b6.Tag = "6"; //t.scan_in_ip_address;
                            lbid6.Text = t.scan_in_ip_address;
                            return;
                        }
                    }
                    catch { }
                });
            }
        }
        private void update_label_button(string label, device_config d)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (d.id == 1)
                {
                    b1.Text = label;
                    b1.UseCustomBackColor = true;
                    b1.UseCustomForeColor = true;
                    b1.BackColor = Color.Green;
                    b1.ForeColor = Color.White;
                    b1.Enabled = true;
                    return;
                }
                if (d.id == 2)
                {
                    b2.Text = label;
                    b2.UseCustomBackColor = true;
                    b2.UseCustomForeColor = true;
                    b2.BackColor = Color.Green;
                    b2.ForeColor = Color.White;
                    b2.Enabled = true;
                    return;
                }
                if (d.id == 3)
                {
                    b3.Text = label;
                    b3.UseCustomBackColor = true;
                    b3.UseCustomForeColor = true;
                    b3.BackColor = Color.Green;
                    b3.ForeColor = Color.White;
                    b3.Enabled = true;
                    return;
                }
                if (d.id == 4)
                {
                    b4.Text = label;
                    b4.UseCustomBackColor = true;
                    b4.UseCustomForeColor = true;
                    b4.BackColor = Color.Green;
                    b4.ForeColor = Color.White;
                    b4.Enabled = true;
                    return;
                }
                if (d.id == 5)
                {
                    b5.Text = label;
                    b5.UseCustomBackColor = true;
                    b5.UseCustomForeColor = true;
                    b5.BackColor = Color.Green;
                    b5.ForeColor = Color.White;
                    b5.Enabled = true;
                    return;
                }
                if (d.id == 6)
                {
                    b6.Text = label;
                    b6.UseCustomBackColor = true;
                    b6.UseCustomForeColor = true;
                    b6.BackColor = Color.Green;
                    b6.ForeColor = Color.White;
                    b6.Enabled = true;
                    return;
                }

            });

        }

        private void enable_tombol_manual(string label, device_config d, bool enable)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (d.id == 1)
                {
                    manualInput1.Text = label;
                    manualInput1.UseCustomBackColor = true;
                    manualInput1.UseCustomForeColor = true;
                    manualInput1.BackColor = Color.Green;
                    manualInput1.ForeColor = Color.White;
                    //manualInput1.Enabled = enable;
                    manualInput1.Enabled = true;
                    return;
                }
                if (d.id == 2)
                {
                    manualInput2.Text = label;
                    manualInput2.UseCustomBackColor = true;
                    manualInput2.UseCustomForeColor = true;
                    manualInput2.BackColor = Color.Green;
                    manualInput2.ForeColor = Color.White;
                    manualInput2.Enabled = enable;
                    return;
                }
                if (d.id == 3)
                {
                    manualInput3.Text = label;
                    manualInput3.UseCustomBackColor = true;
                    manualInput3.UseCustomForeColor = true;
                    manualInput3.BackColor = Color.Green;
                    manualInput3.ForeColor = Color.White;
                    manualInput3.Enabled = enable;
                    return;
                }
                if (d.id == 4)
                {
                    manualInput3.Text = label;
                    manualInput3.UseCustomBackColor = true;
                    manualInput3.UseCustomForeColor = true;
                    manualInput3.BackColor = Color.Green;
                    manualInput3.ForeColor = Color.White;
                    manualInput3.Enabled = enable;
                    return;
                }
                if (d.id == 5)
                {
                    manualInput5.Text = label;
                    manualInput5.UseCustomBackColor = true;
                    manualInput5.UseCustomForeColor = true;
                    manualInput5.BackColor = Color.Green;
                    manualInput5.ForeColor = Color.White;
                    manualInput5.Enabled = enable;
                    return;
                }
                if (d.id == 6)
                {
                    manualInput6.Text = label;
                    manualInput6.UseCustomBackColor = true;
                    manualInput6.UseCustomForeColor = true;
                    manualInput6.BackColor = Color.Green;
                    manualInput6.ForeColor = Color.White;
                    manualInput6.Enabled = enable;
                    return;
                }

            });

        }
        private void clear_form(device_config d)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (d.id == 1)
                {
                    t1ukuran.Clear();
                    t1sopir.Clear();
                    t1plat.Clear();
                    return;
                }
                if (d.id == 2)
                {
                    t2ukuran.Clear();
                    t2sopir.Clear();
                    t2plat.Clear();
                    return;
                }
                if (d.id == 3)
                {
                    t3ukuran.Clear();
                    t3sopir.Clear();
                    t3plat.Clear();
                    return;
                }
                if (d.id == 4)
                {
                    t4ukuran.Clear();
                    t4sopir.Clear();
                    t4plat.Clear();
                    return;
                }
                if (d.id == 5)
                {
                    t5ukuran.Clear();
                    t5sopir.Clear();
                    t5plat.Clear();
                    return;
                }
                if (d.id == 6)
                {
                    t6ukuran.Clear();
                    t6sopir.Clear();
                    t6plat.Clear();
                    return;
                }
            });
        }
        object locker = new object();
        Dictionary<int, Thread> gatewayactives = new Dictionary<int, Thread>();
        private void bgWorkerMonitorTimbangan_DoWork(object sender, DoWorkEventArgs e)
        {
            bgWorkerStart = true;

            while (!bgWorkerMonitorTimbangan.CancellationPending)
            {
                List<device_config> list = GlobalController.GetDeviceConfigByLocation("TIMBANGAN IN");
                if (list == null)
                {
                    Console.WriteLine("Device Timbangan In Empty..");
                    System.Threading.Thread.Sleep(10000);
                    continue;
                }
                foreach (device_config d in list)
                {
                    if (!gatewayactives.ContainsKey(d.id.Value))
                    {
                        try
                        {
                            Thread th = new Thread(() => ProcessThread(d));
                            gatewayactives.Add(d.id.Value, th);
                            th.Start();

                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
                System.Threading.Thread.Sleep(10000);
            }
        }   

        private void ProcessThread(device_config c)
        {
            Thread th;
            gatewayactives.TryGetValue(c.id.Value, out th);
            StateTimbangan st = StateTimbangan.stNone;
            device_config device = c;
            try
            {
                while (th.ThreadState != System.Threading.ThreadState.AbortRequested)
                {
                    tbl_transit_scan_id_timbangan t = null;
                    try
                    {
                        t = GlobalController.GetStatus_tbl_transit_scan_id_timbangan_bydevice(device);
                    }
                    catch { }

                    if (t == null)
                    {
                        Console.WriteLine("Not Data... Sleep: 3 Sec");
                        System.Threading.Thread.Sleep(3000);
                        continue;
                    }

                    if (t.status_in2 == 0)
                    {
                        if (st == StateTimbangan.stNone)
                        {
                            st = StateTimbangan.stFree;
                            update_info_kendaraan(t, device);
                            // StateTimbangan st2;
                            //Panggil aplikasi untuk menyalakan lampu menjadi hijau dan membunyikan suara
                            String workingDir = System.IO.Directory.GetCurrentDirectory() + @"\app\Timbang Masuk\";
                            int retry = 0;
                            while (true)
                            {
                                if (startProcess(workingDir, "PSoundGreenLight.exe", "192.168.1.100"))//t.scan_in_ip_address))
                                {
                                    st = StateTimbangan.stGetInfoTimbangan;
                                    break;
                                }
                                else
                                {
                                    st = StateTimbangan.stDialLedOnError;
                                    if (++retry >= 3)
                                    {
                                        //Update tombol Manual
                                        enable_tombol_manual("Manual", device, true);
                                        st = StateTimbangan.stNone;
                                        break;
                                    }
                                    System.Threading.Thread.Sleep(3000);
                                }
                            }
                        }

                        if (st == StateTimbangan.stGetInfoTimbangan)
                        {
                            //looping ambil data mungi sampai ready
                            int retry = 0;
                            while ((++retry <= 30) || (th.ThreadState != System.Threading.ThreadState.AbortRequested)) //batas waktu 30 detik
                            {
                                tbl_transit_timbangan st3 = GlobalController.GetStatus_tbl_transit_timbangan(t.base_entry);
                                tbl_transit_scan_id_timbangan st4 = GlobalController.GetStatus_mugi_update_on_tbl_transit_scan_id_timbangan(t.base_entry);
                                if (st4 != null && st3 != null)
                                {
                                    update_info_timbangan(st3, device);

                                    /*
                                     * st3.status_in>=1, berarti mugi sudah selesai melakukan timbangan
                                     * status_in>=1 diupdate oleh mugi
                                     */
                                    if (st4.status_in == 1)
                                    {
                                        st = StateTimbangan.stNone;
                                        update_label_button("Open Gate", device);
                                        enable_tombol_manual("Manual", device, false);
                                        GlobalController.Update_tbl_transit_scan_id_timbangan(t.base_entry, 1);
                                        GlobalController.Update_tbl_transit_timbangan(t.base_entry, 1);
                                        break;
                                    }
                                }
                                System.Threading.Thread.Sleep(1000);
                            }
                        }
                    }
                    Console.WriteLine("Sleep... Thread");
                    Thread.Sleep(3000);
                }
            }
            catch (System.Threading.ThreadAbortException ex)
            {

            }

            Console.WriteLine("Thread " + device.id.ToString() + " Closed");

            //StateTimbangan st = StateTimbangan.stNone;
            //device_config device = c;
            //while (bgWorkerStart)
            //{
            //    if (!bgWorkerStart)
            //    {
            //        break;
            //    }
            //    //Console.WriteLine(device.device_ip);

            //    tbl_transit_scan_id_timbangan t = GlobalController.GetStatus_tbl_transit_scan_id_timbangan_bydevice(device);
            //    if (t == null)
            //    {
            //        //Console.WriteLine("T=NULL");
            //        //clear_form(device);
            //        System.Threading.Thread.Sleep(3000);
            //        continue;
            //    }
            //    if (t.status_in2 == 0)
            //    {
            //        //Console.WriteLine("STATUS_IN2==0");
            //        if (st == StateTimbangan.stNone)
            //        {
            //            st = StateTimbangan.stFree;
            //            update_info_kendaraan(t, device);

            //            StateTimbangan st2;
            //            //Panggil aplikasi untuk menyalakan lampu menjadi hijau dan membunyikan suara
            //            String workingDir = System.IO.Directory.GetCurrentDirectory() + @"\app\unloading\";
            //            int retry = 0;
            //            while (true)
            //            {
            //                if (startProcess(workingDir, "PTurnONLed.exe", t.scan_in_ip_address))
            //                {
            //                    st = StateTimbangan.stGetInfoTimbangan;
            //                    break;
            //                }
            //                else
            //                {
            //                    st2 = StateTimbangan.stDialLedOnError;
            //                    if (++retry >= 3)
            //                    {
            //                        //Update tombol Manual
            //                        enable_tombol_manual("Manual", device, true);
            //                        st = StateTimbangan.stNone;
            //                        break;
            //                    }
            //                    System.Threading.Thread.Sleep(3000);
            //                }
            //            }
            //        }

            //        if (st == StateTimbangan.stGetInfoTimbangan)
            //        {
            //            //looping ambil data mungi sampai ready
            //            int retry = 0;
            //            while (++retry <= 30) //batas waktu 30 detik
            //            {
            //                tbl_transit_timbangan st3 = GlobalController.GetStatus_tbl_transit_timbangan(t.base_entry);
            //                tbl_transit_scan_id_timbangan st4 = GlobalController.GetStatus_mugi_update_on_tbl_transit_scan_id_timbangan(t.base_entry);
            //                if (st4 != null && st3 != null)
            //                {
            //                    update_info_timbangan(st3, device);

            //                    /*
            //                    * st3.status_in>=1, berarti mugi sudah selesai melakukan timbangan
            //                    * status_in>=1 diupdate oleh mugi
            //                    */
            //                    if (st3.status_in == 1)
            //                    {
            //                        st = StateTimbangan.stNone;
            //                        update_label_button("Open Gate", device);
            //                        enable_tombol_manual("Manual", device, false);
            //                        GlobalController.Update_tbl_transit_scan_id_timbangan(t.base_entry, 1);
            //                        GlobalController.Update_tbl_transit_timbangan(t.base_entry, 1);
            //                        break;
            //                    }
            //                }
            //                System.Threading.Thread.Sleep(1000);
            //            }
            //        }
            //    }
            //}

        }
        private void bgWorkerMonitorTimbangan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgWorkerStart = false;
            if (waitToClose)
            {
                this.Close();
            }
        }

        private void bgWorkerMonitorTimbangan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //    if (e.ProgressPercentage == 1)
            //    {
            //        //Status=0 Timbangan Progress...
            //        //Status=1 Timbangan Selesai
            //        //Status=2 Tombol hijau sudah tekan, dan gate dibuka
            //        //jiks status=2 reset semua
            //        foreach (tbl_transit_scan_id_timbangan t in listStatusScanIDTimbangan)
            //        {
            //            switch (t.status_in)
            //            {
            //                //jalankan status_id=1 diluar background worker untuk menghindrasi illegal access cross thread
            //                case 0:
            //                    t1plat.Text = t.car_id;
            //                    t1sopir.Text = t.driver;
            //                    b1.BackColor = Color.Gray;
            //                    b1.Text = "Process";
            //                    b1.Enabled = true;
            //                    break;
            //                case 1:
            //                    t1plat.Text = t.car_id;
            //                    t1sopir.Text = t.driver;
            //                    b1.BackColor = Color.Green;
            //                    b1.Text = "Open Gate";
            //                    b1.Enabled = true;
            //                    break;
            //                case 2: //Kosongi data
            //                    b1.Enabled = false;
            //                    b1.BackColor = Color.Gray;
            //                    b1.Text = "Empty";
            //                    t1plat.Text = "";
            //                    t1sopir.Text = "";
            //                    break;
            //            }
            //        }
            //        evt.Set();
            //    }

            //    if (e.ProgressPercentage == 2) 
            //    { 
            //    //update status tabel
            //        foreach (tbl_transit_timbangan t2 in listStatusTimbangan)
            //        {
            //            switch (t2.status_in)
            //            {
            //                case 0:

            //                    switch (t2.bridge_in_ip_address)
            //                    {
            //                        case "192.168.1.1":
            //                            t1ukuran.Text = t.net_weight.ToString();
            //                            //t1ukuran.BackColor = Color.Yellow;
            //                            break;
            //                        case "192.168.1.2":
            //                            t2ukuran.Text = t.net_weight.ToString();
            //                            t2ukuran.BackColor = Color.Yellow;
            //                            break;
            //                        case "192.168.1.3":
            //                            break;
            //                        case "192.168.1.4":
            //                            break;
            //                        case "192.168.1.5":
            //                            break;
            //                        case "192.168.1.6":
            //                            break;
            //                    }
            //                    break;
            //                case 1:
            //                    switch (t.bridge_in_ip_address)
            //                    {
            //                        case "192.168.1.1":
            //                            t1ukuran.Text = t.net_weight.ToString();
            //                            t1ukuran.BackColor = Color.White;
            //                            break;
            //                        case "192.168.1.2":
            //                            t2ukuran.Text = t.net_weight.ToString();
            //                            t2ukuran.BackColor = Color.White;
            //                            break;
            //                        case "192.168.1.3":
            //                            break;
            //                        case "192.168.1.4":
            //                            break;
            //                        case "192.168.1.5":
            //                            break;
            //                        case "192.168.1.6":
            //                            break;
            //                    }
            //                    break;
            //                case 2:
            //                    break;
            //            }
            //        }
            //    }

            //    evt.Set();
        }

        private void bgWorkerDBFetcher_DoWork(object sender, DoWorkEventArgs e)
        {



        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime = DateTime.Now - startTime;
            lblTimer1.Text = elapsedTime.ToString("mm':'ss");
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            timer1.Interval = (1000) * (1);
            timer1.Enabled = true;
            timer1.Start();
            startTime = DateTime.Now;
        }


        private void metroButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }


        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTimer1_Click(object sender, EventArgs e)
        {

        }

        private void ReleaseTimer()
        {
            timer1.Interval = (1000) * (1);
            timer1.Enabled = true;
            timer1.Start();
            startTime = DateTime.Now;
        }

        private void manualInput1_Click(object sender, EventArgs e)
        {
            MetroButton btn = (MetroButton)sender;
            TimbanganInManualForm a = new TimbanganInManualForm();
            a.noTimbangan = new Dictionary<int, string>();
            a.noTimbangan.Add(1, b1.Text);
            if (a.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int id = int.Parse(btn.Tag.ToString());
                switch (id)
                {
                    case 1:
                        //reset form line 1
                        SetLabelDialog(a, t1plat, t1sopir, t1ukuran);
                        break;
                }
            }
            a.noTimbangan.Remove(1);
        }

        private void TimbanganMasukForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (requestCloseForm == false)
            {
                e.Cancel = true;
                Thread th = new Thread(() =>
                {
                    bgWorkerMonitorTimbangan.CancelAsync();

                    foreach (Thread t in gatewayactives.Values)
                    {
                        if (t.ThreadState == System.Threading.ThreadState.Running)
                        {
                            try
                            {
                                t.Abort();
                            }
                            catch { }
                        }

                    }
                    requestCloseForm = true;
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Close();
                    });
                });
                th.Start();
            }
        }

        private void manualInput2_Click(object sender, EventArgs e)
        {

        }

        //private void TimbanganMasukForm_FormClosed(object sender, FormClosingEventArgs e)
        //{

        //    if (bgWorkerStart)
        //    {
        //        bgWorkerMonitorTimbangan.CancelAsync();
        //        e.Cancel = true;
        //        waitToClose = true;
        //    }
        //}

        //private void TimbanganMasukForm_FormClosing_1(object sender, FormClosingEventArgs e)
        //{
        //    if (requestCloseForm == false)
        //    {
        //        e.Cancel = true;
        //        Thread th = new Thread(() =>
        //        {
        //            bgWorkerMonitorTimbangan.CancelAsync();

        //            foreach (Thread t in gatewayactives.Values)
        //            {
        //                if (t.ThreadState == System.Threading.ThreadState.Running)
        //                {
        //                    try
        //                    {
        //                        t.Abort();
        //                    }
        //                    catch { }
        //                }

        //            }
        //            requestCloseForm = true;
        //            this.Invoke((MethodInvoker)delegate
        //            {
        //                this.Close();
        //            });
        //        });
        //        th.Start();
        //    }
        //}
    }
}
