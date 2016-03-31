using MetroFramework;
using SRS.DeskApp.Context;
using SRS.DeskApp.DAO;
using SRS.DeskApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using pSX;
using System.Diagnostics;
using System.Globalization;

namespace SRS.DeskApp
{
    public partial class CoreSamplingForm : MetroForm
    {
        ManualResetEvent evt = new ManualResetEvent(true);
        List<tbl_transit_core_sampling> listCoreSampling = new List<tbl_transit_core_sampling>();
        bool waitFile = false;
        bool readFileSuccess = false;
        public CoreSamplingForm()
        {
            InitializeComponent();   
        }


        private void CoreSamplingForm_Load(object sender, EventArgs e)
        {
            b2barstatus.BackColor = Color.Gray;
            b1barstatus.BackColor = Color.Gray;
            if (!Directory.Exists("polnir"))
            {
                try
                {
                    Directory.CreateDirectory("polnir");
                }
                catch { }
            }
            bwMonitorCoreSampling.RunWorkerAsync();
           // timer1.Enabled = true;
        }
        private double nilai_npp = 0; //auto
        private double faktor_rendemen = 0.66; //manually
        private double rendemen_hitungan = 0;
        private double insentif1 = 70;
        private double insentif2 = 72.5;
        private double insentif3 = 75;
        private double insentif4 = 77.5;

        private double r_ptr_baru = 0;
        private double bag_ptr_baru = 0;
        private double rendemen = 0;

        private rendeman hitung_rendemen(double pol, double brix)
        {
            try
            {
                nilai_npp = pol - (0.4 * (brix - pol));
                rendemen_hitungan = nilai_npp * faktor_rendemen;
                bag_ptr_baru = r_ptr_baru * rendemen;

                rendemen = Math.Round(rendemen_hitungan,2);
                return GlobalController.get_rendemen(rendemen);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private void b1manual_Click(object sender, EventArgs e)
        {
            CoreSamplingManualForm c = new CoreSamplingManualForm();
            c.no_tta = lb1tta.Text;
            Context.tbl_transit_core_sampling sam = new tbl_transit_core_sampling();
            sam.driver = t1sopir.Text;
            sam.car_id = t1plat.Text;
            CoreSamplingManualForm.manualReq =sam;
           
            c.ShowDialog();

        }

        public void SaveCoreSampling()
        {

        }

        public void SetFormAfterDialog(int line)
        {
           // GlobalController
            if (CoreSamplingManualForm.response != null)
            {
                if (line == 1)
                {
                    var t = CoreSamplingManualForm.response;
                    t1plat.Text = t.car_id;
                    t1sopir.Text = t.driver;
                    t1pol.Text = t.pol_manual.ToString();
                    t1brix.Text = t.brix_manual.ToString();
                   // t1barcode.Text = t.ba;

                }
                else
                {
                    var t = CoreSamplingManualForm.response;
                    t2plat.Text = t.car_id;
                    t2sopir.Text = t.driver;
                    t2pol.Text = t.pol_manual.ToString();
                    t2brix.Text = t.brix_manual.ToString();
                }

            }
        }

     

        private void b2manual_Click(object sender, EventArgs e)
        {
            CoreSamplingManualForm c = new CoreSamplingManualForm();
            c.no_tta = lb2tta.Text;
            Context.tbl_transit_core_sampling sam = new tbl_transit_core_sampling();
            sam.driver = t2sopir.Text;
            sam.car_id = t2plat.Text;
            CoreSamplingManualForm.manualReq = sam;
            c.ShowDialog();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //    panel1.Visible = true;
            //else
            //    panel1.Visible = false;
        }

        private void bt1TabSukses_Click(object sender, EventArgs e)
        {
            Context.tbl_transit_core_sampling timbIn = new tbl_transit_core_sampling();
            timbIn = CoreSamplingSim.GetDataCoreSamplingSim(StatusError.ST, 1);
            GlobalController.SaveCoreSamplingManual(timbIn);
            MetroFramework.MetroMessageBox.Show(this, "Data simulasi SUKSES TAB Berhasil Ditambahkan di Line 1", "Informasi");
        }

        //private void b1TabGagal_Click(object sender, EventArgs e)
        //{
        //    Context.shared_core_sampling timbIn = new shared_core_sampling();
        // //   timbIn = CoreSamplingSim.GetDataCoreSamplingSim(StatusError.T, 1);
        //   // GlobalController.SaveSharedCoreSamplingManual(timbIn);
        //   // MetroFramework.MetroMessageBox.Show(this, "Data simulasi GAGAL TAB Berhasil Ditambahkan di Line 1", "Informasi");
        //}

        //private void bt1WSukses_Click(object sender, EventArgs e)
        //{
        //    Context.shared_core_sampling timbIn = new shared_core_sampling();
        //   // timbIn = CoreSamplingSim.GetDataCoreSamplingSim(StatusError.SW, 1);
        //   // GlobalController.SaveSharedCoreSamplingManual(timbIn);
        //   // MetroFramework.MetroMessageBox.Show(this, "Data simulasi SUKSES SAMPLING Berhasil Ditambahkan di Line 1", "Informasi");
        //}

        //private void bt1WGagal_Click(object sender, EventArgs e)
        //{
        //    Context.shared_core_sampling timbIn = new shared_core_sampling();
        //    //timbIn = CoreSamplingSim.GetDataCoreSamplingSim(StatusError.W, 1);
        //   // GlobalController.SaveSharedCoreSamplingManual(timbIn);
        //   // MetroFramework.MetroMessageBox.Show(this, "Data simulasi GAGAL SAMPLING Berhasil Ditambahkan di Line 1", "Informasi");
        //}

        private void bt1status_Click(object sender, EventArgs e)
        {
            if (bt1status.Text.Equals("SW") || bt1status.Text.Equals("W") || bt1status.Text.Equals("ST"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Proses telah memasuki tahap perhitungan sampling\nSilahkan menunggu", "Informasi");
            }
            else
            {
                CoreSamplingManualForm c = new CoreSamplingManualForm();
                //CoreSamplingManualForm.lineId = 1;
                //CoreSamplingManualForm.status = "ST";
                c.ShowDialog();
                SetFormAfterDialog(1);
            }
        }

        private void bt2status_Click(object sender, EventArgs e)
        {
            if (bt2status.Text.Equals("SW") || bt2status.Text.Equals("W") || bt2status.Text.Equals("ST"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Proses telah memasuki tahap perhitungan sampling\nSilahkan menunggu", "Informasi");
            }
            else
            {
                CoreSamplingManualForm c = new CoreSamplingManualForm();
                //CoreSamplingManualForm.lineId = 2;
               // CoreSamplingManualForm.status = "ST";
                c.ShowDialog();
                SetFormAfterDialog(2);
            }

        }

        //private void bt2TabSukses_Click(object sender, EventArgs e)
        //{
        //    Context.shared_core_sampling timbIn = new shared_core_sampling();
        //  //  timbIn = CoreSamplingSim.GetDataCoreSamplingSim(StatusError.ST, 2);
        //  //  GlobalController.SaveSharedCoreSamplingManual(timbIn);
        //   // MetroFramework.MetroMessageBox.Show(this, "Data simulasi SUKSES TAB Berhasil Ditambahkan di Line 2", "Informasi");
        //}

        //private void b2TabGagal_Click(object sender, EventArgs e)
        //{
        //    Context.shared_core_sampling timbIn = new shared_core_sampling();
        //  //  timbIn = CoreSamplingSim.GetDataCoreSamplingSim(StatusError.T, 2);
        //   // GlobalController.SaveSharedCoreSamplingManual(timbIn);
        //   // MetroFramework.MetroMessageBox.Show(this, "Data simulasi GAGAL TAB Berhasil Ditambahkan di Line 2", "Informasi");
        //}

        //private void bt2WSukses_Click(object sender, EventArgs e)
        //{
        //    Context.shared_core_sampling timbIn = new shared_core_sampling();
        //    //timbIn = CoreSamplingSim.GetDataCoreSamplingSim(StatusError.SW, 2);
        //   // GlobalController.SaveSharedCoreSamplingManual(timbIn);
        //   // MetroFramework.MetroMessageBox.Show(this, "Data simulasi SUKSES SAMPLING Berhasil Ditambahkan di Line 2", "Informasi");
        //}

        //private void bt2WGagal_Click(object sender, EventArgs e)
        //{
        //    Context.shared_core_sampling timbIn = new shared_core_sampling();
        //    //timbIn = CoreSamplingSim.GetDataCoreSamplingSim(StatusError.W, 2);
        //    //GlobalController.SaveSharedCoreSamplingManual(timbIn);
        //    //MetroFramework.MetroMessageBox.Show(this, "Data simulasi GAGAL SAMPLING Berhasil Ditambahkan di Line 2", "Informasi");
        //}
        private void update_info(tbl_transit_core_sampling t)
        {

        }
        enum StateCoreSampling { stFree,stDialLedON,stDialLedOnError,stDialLedOnOK,stDialNIROnline,stDialNIROnlineOK,stDialNIROnlineError }
        Dictionary<int, StateCoreSampling> listState = new Dictionary<int, StateCoreSampling>();
        
        private void bwMonitorCoreSampling_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!bwMonitorCoreSampling.CancellationPending)
            {
                //Console.WriteLine("Enter BW Monitor");
                List<device_config> listDeviceConfig = GlobalController.GetDeviceConfigByLocation("CORESAMPLING");
                listCoreSampling = GlobalController.GetStatusCoreSamplingInProgress();
                if (listCoreSampling == null)
                {
                    Console.WriteLine("listCoreSampling == null");
                    System.Threading.Thread.Sleep(1000);
                    continue;
                }
                Console.WriteLine("listCoreSampling.Count  = " + listCoreSampling.Count.ToString());
                foreach (tbl_transit_core_sampling t in listCoreSampling)
                {
                    switch (t.status)
                    {
                        case 0:
                            StateCoreSampling state = StateCoreSampling.stFree;
                            if (!listState.TryGetValue(t.base_entry, out state))
                            {
                                try
                                {
                                    state = StateCoreSampling.stFree;
                                    listState.Add(t.base_entry, state);
                                }
                                catch { }

                            }

                            if (state == StateCoreSampling.stFree)
                            {
                                //Tampilkan data tab coresampling terbaru
                                this.Invoke((MethodInvoker)delegate
                                {
                                    Console.WriteLine("IP Address:" + t.device_ip_address);

                                    foreach (device_config d in listDeviceConfig)
                                    {
                                        if (t.device_ip_address == d.device_ip && d.id == 1)
                                        {
                                            lbid1.Text = t.base_entry.ToString();
                                            t1plat.Text = t.car_id;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().PlatNo;
                                            t1sopir.Text = t.driver;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().Driver;
                                            t1pol.Text = "";// t.pol_nir.ToString();// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().POL.ToString();
                                            t1brix.Text = "";// t.brix_nir.ToString();// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BRIX.ToString();
                                            t1barcode.Text = "";//t.num_at_card;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BARCODE.ToString();

                                            //bt1status.Text = "W";
                                            bt1status.UseCustomBackColor = true;
                                            bt1status.BackColor = Color.Gray;
                                        }
                                        if (t.device_ip_address == d.device_ip && d.id == 2)
                                        {
                                            //Console.WriteLine("POL:" + t.car_id);
                                            //Tampilkan data dengan mengabaikan info status
                                            lbid2.Text = t.base_entry.ToString();
                                            t2plat.Text = t.car_id;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().PlatNo;
                                            t2sopir.Text = t.driver;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().Driver;
                                            t2pol.Text = "";//t.pol_nir.ToString();// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().POL.ToString();
                                            t2brix.Text = "";//t.brix_nir.ToString();// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BRIX.ToString();
                                            t2barcode.Text = "";//t.num_at_card;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BARCODE.ToString();

                                            //bt2status.Text = "W";
                                            bt2status.UseCustomBackColor = true;
                                            bt2status.BackColor = Color.Gray;
                                        }
                                    }
                                });
                            }

                            //cek jika ada file di folder polbrix yang gagal diupdate ke server
                            if (File.Exists(@"polbrix\" + t.doc_entry.ToString() + ".txt"))
                            {

                                //simpan ke database file yang gagal disimpan didatabase
                                try
                                {
                                    StreamReader reader = new StreamReader(@"polbrix\" + t.doc_entry.ToString() + ".txt");
                                    int? doc_entry = 0;
                                    int? base_entry = 0;
                                    int? pol_nir = 0;
                                    int? brix_nir = 0;
                                    int? pol_manual = 0;
                                    int? brix_manual = 0;
                                    int? status = 0;
                                    int? retry = 0;
                                    try
                                    {
                                        doc_entry = Int32.Parse(reader.ReadLine());
                                        base_entry = Int32.Parse(reader.ReadLine());
                                        pol_nir = Int32.Parse(reader.ReadLine());
                                        brix_nir = Int32.Parse(reader.ReadLine());
                                        pol_manual = Int32.Parse(reader.ReadLine());
                                        brix_manual = Int32.Parse(reader.ReadLine());
                                        status = Int32.Parse(reader.ReadLine());
                                        retry = Int32.Parse(reader.ReadLine());

                                        // tbl_transit_core_sampling t2 = GlobalController.GetCoreSamplingByDocEntry(doc_entry.Value);
                                        if (t != null)
                                        {
                                            rendeman rr = hitung_rendemen((double)pol_nir, (double)brix_nir);
                                            if (rr != null)
                                            {
                                                t.pol_nir = Convert.ToInt64(pol_nir);
                                                t.brix_nir = Convert.ToInt64(brix_nir);
                                                t.status = 1;
                                                t.rendemen_nir = rr.rendemen;
                                                if (!GlobalController.UpdateCoreSampling(t))
                                                {
                                                    try
                                                    {
                                                        StreamWriter writer = new StreamWriter(@"polbrix\" + t.doc_entry.ToString() + ".txt");
                                                        writer.WriteLine(t.doc_entry);
                                                        writer.WriteLine(t.base_entry);
                                                        writer.WriteLine(t.pol_nir);
                                                        writer.WriteLine(t.brix_nir);
                                                        writer.WriteLine(t.pol_manual);
                                                        writer.WriteLine(t.brix_manual);
                                                        writer.WriteLine("1"); //status
                                                        writer.WriteLine(++retry); //retry
                                                        writer.Close();
                                                    }//error resave file
                                                    catch { }
                                                }
                                            }
                                        }
                                    } //Error real line
                                    catch { }
                                } //Error read file
                                catch { }
                            }
                            else
                            {
                                //2230493688
                                //Connect to NIR Online
                                listState.TryGetValue(t.base_entry, out state);
                                state = StateCoreSampling.stDialNIROnline;
                                if (connectNIROnline(t.base_entry.ToString()))
                                {
                                    //loop until timeout
                                    DataNIROnline data = readFileCSV(t.base_entry);
                                    if (data.Success)
                                    {

                                        state = StateCoreSampling.stDialNIROnlineOK;
                                        //Tampilkan hasil po/brix dari alat NIR Online
                                        this.Invoke((MethodInvoker)delegate
                                        {
                                            switch (t.device_ip_address)
                                            {
                                                case "192.168.50.227":
                                                    t1pol.Text = data.Pol.ToString();
                                                    t1brix.Text = data.Brix.ToString();
                                                    break;
                                                case "192.168.50.228":
                                                    t2pol.Text = data.Pol.ToString();
                                                    t2brix.Text = data.Brix.ToString();
                                                    break;
                                                default:
                                                    t1pol.Text = data.Pol.ToString();
                                                    t1brix.Text = data.Brix.ToString();
                                                    break;
                                            }

                                        });
                                        try
                                        {
                                            //Lookup table rendemen
                                            rendeman rr = hitung_rendemen((double)data.Pol, (double)data.Brix);
                                            if (rr != null)
                                            {
                                                t.pol_nir = data.Pol;
                                                t.brix_nir = data.Brix;
                                                t.status = 1;
                                                t.rendemen_nir = rr.rendemen;
                                                //Log ke file jika gagal update ke server MSSQL
                                                if (!GlobalController.UpdateCoreSampling(t))
                                                {
                                                    try
                                                    {
                                                        StreamWriter writer = new StreamWriter(@"polbrix\" + t.doc_entry.ToString() + ".txt");
                                                        writer.WriteLine(t.doc_entry);
                                                        writer.WriteLine(t.base_entry);
                                                        writer.WriteLine(t.pol_nir);
                                                        writer.WriteLine(t.brix_nir);
                                                        writer.WriteLine(t.pol_manual);
                                                        writer.WriteLine(t.brix_manual);
                                                        writer.WriteLine("1"); //status
                                                        writer.WriteLine("0"); //retry
                                                        writer.Close();
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        Console.WriteLine("Log File DOc ENtry:" + t.doc_entry.ToString() + " Error:" + ex.Message);
                                                    }
                                                }
                                                else
                                                {
                                                    state = StateCoreSampling.stDialLedON;
                                                    string workDir = @System.IO.Directory.GetCurrentDirectory() + @"\app\unloading\";
                                                    if (startProcess(workDir, "PTurnONLed.exe", t.device_ip_address))
                                                    {
                                                        Console.WriteLine("Start Process Turn ON LED OK");
                                                        this.Invoke((MethodInvoker)delegate
                                                        {
                                                            bt1status.BackColor = Color.Green;
                                                            // bt1status.Text = "Open Gate";
                                                        });
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Start Process Turn ON LED Error");
                                                    }
                                                }
                                            }//end if renemen not null
                                        }
                                        catch { }
                                    }
                                    else
                                    {
                                        state = StateCoreSampling.stDialNIROnlineError;
                                    }
                                }
                                else //koneksi ke NIR Online gagal
                                {
                                    try
                                    {
                                        t.status = 1;
                                        if (GlobalController.UpdateCoreSampling(t))
                                        {
                                            //
                                        }
                                    }
                                    catch { }
                                    //Aktifkan Tombol Manual    
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        foreach (device_config d in listDeviceConfig)
                                        {
                                            if (t.device_ip_address == d.device_ip && d.id == 1)
                                            {
                                                b1manual.UseCustomBackColor = true;
                                                b1manual.BackColor = Color.Green;
                                                b1manual.Enabled = true;
                                            }
                                            if (t.device_ip_address == d.device_ip && d.id == 2)
                                            {
                                                b2manual.UseCustomBackColor = true;
                                                b2manual.BackColor = Color.Green;
                                                b2manual.Enabled = true;
                                            }
                                        }
                                    });
                                }
                            }
                            break;
                        case 1:

                            break;
                    }
                }
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void bwMonitorCoreSampling_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("bwMonitorCoreSampling_ProgressChanged");
            if (e.ProgressPercentage == 1 && listCoreSampling != null)
            {
                Console.WriteLine("listCoreSampling != null");
                foreach (tbl_transit_core_sampling t in listCoreSampling)
                {
                    switch (t.status.Value)
                    {
                        case 0:
                            switch (t.device_ip_address)
                            {
                                case "192.168.50.227":
                                    //Console.WriteLine("POL:" + t.car_id);
                                    //Tampilkan data dengan mengabaikan info status
                                    t1plat.Text = t.car_id;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().PlatNo;
                                    t1sopir.Text = t.driver;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().Driver;
                                    t1pol.Text = t.pol_nir.ToString();// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().POL.ToString();
                                    t1brix.Text = t.brix_nir.ToString();// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BRIX.ToString();
                                    t1barcode.Text = t.num_at_card;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BARCODE.ToString();

                                    bt1status.Text = "W";
                                    bt1status.UseCustomBackColor = true;
                                    bt1status.BackColor = Color.Gray;
                                    break;
                                case "192.168.50.228":
                                    //Console.WriteLine("POL:" + t.car_id);
                                    //Tampilkan data dengan mengabaikan info status
                                    t2plat.Text = t.car_id;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().PlatNo;
                                    t2sopir.Text = t.driver;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().Driver;
                                    t2pol.Text = t.pol_nir.ToString();// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().POL.ToString();
                                    t2brix.Text = t.brix_nir.ToString();// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BRIX.ToString();
                                    t2barcode.Text = t.num_at_card;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BARCODE.ToString();

                                    bt2status.Text = "W";
                                    bt2status.UseCustomBackColor = true;
                                    bt2status.BackColor = Color.Gray;
                                    break;
                            }

                            break;
                        case 1:
                            switch (t.device_ip_address)
                            {
                                case "192.168.50.227":
                                    //Console.WriteLine("POL:" + t.car_id);
                                    //Tampilkan data dengan mengabaikan info status
                                    t1plat.Text = t.car_id;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().PlatNo;
                                    t1sopir.Text = t.driver;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().Driver;
                                    t1pol.Text = t.pol_nir.ToString();// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().POL.ToString();
                                    t1brix.Text = t.brix_nir.ToString();// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BRIX.ToString();
                                    t1barcode.Text = t.num_at_card;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BARCODE.ToString();

                                    bt1status.Text = "W";
                                    bt1status.UseCustomBackColor = true;
                                    bt1status.BackColor = Color.Green;
                                    break;
                                case "192.168.50.228":
                                    //Console.WriteLine("POL:" + t.car_id);
                                    //Tampilkan data dengan mengabaikan info status
                                    t2plat.Text = t.car_id;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().PlatNo;
                                    t2sopir.Text = t.driver;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().Driver;
                                    t2pol.Text = t.pol_nir.ToString();// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().POL.ToString();
                                    t2brix.Text = t.brix_nir.ToString();// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BRIX.ToString();
                                    t2barcode.Text = t.num_at_card;// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BARCODE.ToString();

                                    bt2status.Text = "W";
                                    bt2status.UseCustomBackColor = true;
                                    bt2status.BackColor = Color.Green;
                                    break;
                            }

                            break;
                        default:
                            switch (t.device_ip_address)
                            {
                                case "192.168.50.227":
                                    t1plat.Text = "";// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().PlatNo;
                                    t1sopir.Text = "";// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().Driver;
                                    t1pol.Text = "";// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().POL.ToString();
                                    t1brix.Text = "";// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BRIX.ToString();
                                    t1barcode.Text = "";// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BARCODE.ToString();

                                    bt1status.Text = "W";
                                    bt1status.UseCustomBackColor = true;
                                    bt1status.BackColor = Color.Gray;
                                    break;
                                case "192.168.50.228":
                                    t2plat.Text = "";// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().PlatNo;
                                    t2sopir.Text = "";// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().Driver;
                                    t2pol.Text = "";// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().POL.ToString();
                                    t2brix.Text = "";// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BRIX.ToString();
                                    t2barcode.Text = "";// dataW.Where(x => x.Status.Equals("W") && x.Line == 1).OrderByDescending(x => x.TanggalProses).FirstOrDefault().BARCODE.ToString();

                                    bt2status.Text = "W";
                                    bt2status.UseCustomBackColor = true;
                                    bt2status.BackColor = Color.Gray;
                                    break;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("evt.Set()");
            evt.Set();
        }


        private DataNIROnline readFileCSV(int base_entry)
        {
            //start timer
            byte count = 0;
            //bool fileExist = false;
            waitFile = true;
            DataNIROnline dataNIR = new DataNIROnline();
            dataNIR.Success = false;
            dataNIR.Pol = 0;
            dataNIR.Brix = 0;
            dataNIR.House = "";

            //string sep = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;

            int i = 0;
            string[] Documents = null;
            while (true)
            {
                try
                {
                    Console.WriteLine("Read File CSV Progress...");
                    //E:\CRONOS PROJECT\JATIS\SUGAR LABINTA\project\SRS NEW\CORE SAMPLING\CSV House-1
                    //Documents = System.IO.Directory.GetFiles(@"\\CORE SAMPLING\CSV\House-1\Post\", "*.csv");
                    Documents = System.IO.Directory.GetFiles(@"C:\ktm\dbase\", "*.csv");
                    if (Documents.Length <= 0)
                    {
                        Console.WriteLine("File CSV Still not available");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("File CSV available,Total:" + Documents.Length.ToString());
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Read File CSV Error:" + ex.Message);
                    count++;
                    Thread.Sleep(1000);
                }
            }
            if (Documents == null)
            {
                return dataNIR;
            }

            foreach (string file in Documents)
            {
                FileStream stream = File.Open(@file, FileMode.Open);
                NumberStyles style;
                CultureInfo provider;

                style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
                provider = new CultureInfo("id-ID");
                //byte[] buffer;
                try
                {
                    int length = (int)stream.Length;  // get file length
                    byte[] buffer = new byte[length];            // create buffer
                    int cnt;                            // actual number of bytes read
                    int sum = 0;                          // total number of bytes read

                    // read until Read method returns 0 (end of the stream has been reached)
                    while ((cnt = stream.Read(buffer, sum, length - sum)) > 0)
                        sum += cnt;  // sum is a buffer offset for next reading]

                    string yourText = Encoding.UTF8.GetString(buffer);
                    string[] splits = yourText.Split(new char[] { '\r', '\n' });
                    foreach (string str in splits)
                    {
                        if (str.Trim().Length <= 0) continue;
                        string[] datas = str.Split(',');
                        if (i > 0)
                        {
                            try
                            {
                                dataNIR.Base_entry = Convert.ToInt32(datas[3]);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Read Base Entry Error:" + ex.Message);
                            }
                            try
                            {
                                if (datas[8].ToLower().Equals("pol"))
                                {
                                    datas[10] = datas[10].Replace(">", "");
                                    datas[10] = datas[10].Replace(".", ",");
                                    //id-ID
                                    dataNIR.Pol = Decimal.Parse(datas[10], style, provider);
                                    dataNIR.Success = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                dataNIR.Success = false;
                                Console.WriteLine("Read POL Error:" + ex.Message);
                                Console.WriteLine("Data Pol Error:" + datas[10]);
                            }
                            try
                            {
                                if (datas[8].ToLower().Equals("brix"))
                                {
                                    datas[10] = datas[10].Replace(">", "");
                                    datas[10] = datas[10].Replace(".", ",");
                                    dataNIR.Brix = Decimal.Parse(datas[10], style, provider);
                                    dataNIR.Success = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                dataNIR.Success = false;
                                Console.WriteLine("Read BRIX Entry Error:" + ex.Message);
                                Console.WriteLine("Data Brix Error:" + datas[10]);
                            }
                        }
                        i++;
                    }
                }
                finally
                {
                    stream.Close();
                }
                try
                {
                    string dest = file.Replace(@"\\PC-PC\Export\CSV\House-1\Post", @"\\PC-PC\Export\Backup");
                    File.Move(file, @dest);
                }
                catch (Exception ex) { }
            }
            return dataNIR;
        }
        private bool startProcess(string workDir, string pathFile, string args)
        {
            bool status = false;
            try
            {
                //192.168.1.100
                Process p = new Process();
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //p.StartInfo.WorkingDirectory = @SRS.DeskApp.Setting.externalAppPath;// workDir;
                p.StartInfo.WorkingDirectory = Properties.Settings.Default.externalAppPath;
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
        private bool connectNIROnline(string base_entry)
        {
            Console.WriteLine("connectNIROnline, Base Entry:" + base_entry);
            int retry = 0;
            bool status = false;
            while (true)
            {
                if (retry >= 5)
                {
                    break;
                }
                try
                {
                    pSX.ucSPS a = new ucSPS();
                    a.Connect("192.168.10.1", 12345, false);
                    Thread.Sleep(2000);
                    a.Transact(">A1Z-");
                    Thread.Sleep(500);
                    a.Transact(">A1Z" + base_entry);// ' "001" = Truck Front, "002" = Truck Trailer, "_1" = Start counting sequence 
                    //  a.Transact(">A1PA1PRBF");//  '(">A1PRBF")   --> Recipe Field
                    // a.Transact(">A1OXX");//  ' Serial Number for Truck in ORDER Field
                    Thread.Sleep(500);
                    a.Disconnect();
                    status = true;
                    Console.WriteLine("Send Command to NIR Online SUccess...");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Send Command NIR OnlineError:" + ex.Message);
                    retry++;
                }
            }
            return status;
        }
        private void getCoreSamplingFromServer()
        {
            TcpClient client = new TcpClient("IP", 53211);
            if (client.Connected)
            {
                try
                {
                    // Translate the passed message into ASCII and store it as a Byte array.

                    //Create Network Stream
                    NetworkStream stream = client.GetStream();
                    // Prepare BBuffer to store the response bytes.
                    byte[] data = new Byte[256];
                    // String to store the response ASCII representation.
                    String responseData = String.Empty;

                    //1.Kirim perintah inisialisasi
                    string msg = "CMD1" + Environment.NewLine;
                    data = System.Text.Encoding.ASCII.GetBytes(msg);
                    // Send the message to the connected TcpServer. 
                    stream.Write(data, 0, data.Length);
                    // Read the first batch of the TcpServer response bytes.
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    //proses hasil response

                    //2.Kirim perintah kedua
                    //3.Kirim perintah ketiga
                    stream.Close();
                    //client.Close();
                }
                catch (ArgumentNullException ex)
                {
                    // txtResponse.Text = "ArgumentNullException: {0}" + ex.Message;
                }
                catch (SocketException ex)
                {
                    // txtResponse.Text = "SocketException: {0}" + ex.Message;
                }

            }
        }

        private void CoreSamplingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bwMonitorCoreSampling.CancelAsync();
        }
    }
}
