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
using MetroFramework;
using System.IO;
namespace SRS.DeskApp
{
    public partial class CoreSamplingManualForm : MetroForm
    {
        tbl_transit_core_sampling tManual;
        public CoreSamplingManualForm()
        {
            InitializeComponent();
        }


        public int lineId;
        public string status;
        public string no_tta;
        public static Context.tbl_transit_core_sampling manualReq;
        private void CoreSamplingManualForm_Load(object sender, EventArgs e)
        {
            if (manualReq != null)
            {
                lbPOL.Visible = true;
                lbBrix.Visible = true;
                lbBar.Visible = true;
                tbBarcode.Visible = true;
                tbBrix.Visible = true;
                tbPOL.Visible = true;

                tbBarcode.ReadOnly = false;
                tbBrix.ReadOnly = false;
                tbPOL.ReadOnly = false;

                //tbNoTTA.Text = manualReq.;
                tbNoMobil.Text = manualReq.car_id;
                tbDriver.Text = manualReq.driver;
            }
            
            
        }
        
        public static tbl_transit_core_sampling response;
        private void btSimpan_Click(object sender, EventArgs e)
        {
            var t = GlobalController.CheckTableTransitTimbangan(tbNoTTA.Text);
            if (t != null)
            {
                tbl_transit_core_sampling shd = new tbl_transit_core_sampling();

                shd.num_at_card= tbBarcode.Text;
                shd.brix_manual = Convert.ToDecimal(tbBrix.Text);
                shd.pol_manual = Convert.ToDecimal(tbPOL.Text);
                shd.status = 1;// status;
                //shd.li = lineId;
                //shd. = tbNoTTA.Text;
                shd.car_id = tbNoMobil.Text;
                shd.create_date = DateTime.Now;
                shd.driver = tbDriver.Text;

                var data = GlobalController.SaveCoreSamplingManual(shd);
                if (data != null)
                {
                    MetroMessageBox.Show(this, "Data Telah Tersimpan", "Informasi");
                    response = shd;
                    this.Dispose();
                }
                else
                {
                    MetroMessageBox.Show(this, "Data gagal tersimpan, silahkan cek inputan anda", "Informasi");
                    response = null;
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Tidak ada Transaksi Timbangan Masuk per hari ini untuk Kode TTA tersebut", "Informasi");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //No	Date		Time		Factory ID		Operator	Pol(5)	Dilt	Pol*Dilt	Temp	Tube	WL	Brix(11)	Dilt	Brix*Dilt	Temp	Density		Method	% Pol		HK		Nira		Factor	RS		Comment	
            //1	    30-04-15	20:56:01	Kebun Tebu Mas	Uji Coba	45.99	1.00	45.99		29.99	200		587	13.67	1.00	13.67		28.67	1.052291	Dry		11.363204	83.13	10.440486	0.85	8.874	Bacode 6	
            //2	30-04-15	20:55:07	Kebun Tebu Mas	Uji Coba	52.52	1.00	52.52	29.43	200	587	15.07	1.00	15.07	28.77	1.058259	Dry	12.903455	85.62	12.036837	0.85	10.231	barcode 5	
            //3	30-04-15	20:54:28	Kebun Tebu Mas	Uji Coba	49.99	1.00	49.99	30.65	200	587	13.92	1.00	13.92	29.91	1.053352	Dry	12.339082	88.64	11.706715	0.85	9.951	Barcode 4	
            //4	30-04-15	20:53:09	Kebun Tebu Mas	Uji Coba	47.96	1.00	47.96	28.95	200	587	12.54	1.00	12.54	28.88	1.047521	Dry	11.903918	94.93	11.649485	0.85	9.902	barcode 3	
            //5	30-04-15	20:52:18	Kebun Tebu Mas	Uji Coba	50.44	1.00	50.44	29.99	200	587	14.76	1.00	14.76	29.67	1.056932	Dry	12.407986	84.06	11.467180	0.85	9.747	Barcode 2	
            //6	30-04-15	20:51:28	Kebun Tebu Mas	Uji Coba	52.87	1.00	52.87	29.67	200	587	15.29	1.00	15.29	30.02	1.059203	Dry	12.977873	84.88	12.053022	0.85	10.245	Barcode 1	
            tManual = new tbl_transit_core_sampling();
            DataNIROnline data = new DataNIROnline();
            string path = @Properties.Settings.Default.csv_file_manual;
            string[] files = null;
            try
            {
                files = System.IO.Directory.GetFiles(@path, "*.*");

                if (files.Length > 0)
                {
                    foreach (string file in files)
                    {
                        FileStream stream = File.Open(@file, FileMode.Open);
                        try
                        {
                            int length = (int)stream.Length;  // get file length
                            byte[] buffer = new byte[length];            // create buffer
                            int cnt;                            // actual number of bytes read
                            int sum = 0;                          // total number of bytes read
                            int i = 0;
                            // read until Read method returns 0 (end of the stream has been reached)
                            while ((cnt = stream.Read(buffer, sum, length - sum)) > 0)
                                sum += cnt;  // sum is a buffer offset for next reading]

                            string yourText = Encoding.UTF8.GetString(buffer);
                            string[] splits = yourText.Split(new char[] { '\r', '\n' });
                            foreach (string str in splits)
                            {
                                if (str.Trim().Length <= 0) continue;
                                string[] datas = str.Split(',');
                                //i=0 abaikan data header
                                if (i > 0)
                                {
                                    
                                    try
                                    {
                                        //datas[5] = datas[5].Replace(">", "");
                                        //datas[5] = datas[5].Replace(".", ",");
                                        //id-ID
                                        tManual.pol_nir = Decimal.Parse(datas[5]);

                                    }
                                    catch (Exception ex)
                                    {
                                        //dataNIR.Success = false;
                                        Console.WriteLine("Read POL Error:" + ex.Message);
                                        Console.WriteLine("Data Pol Error:" + datas[10]);
                                    }
                                    try
                                    {
                                        //datas[10] = datas[10].Replace(">", "");
                                        //datas[10] = datas[10].Replace(".", ",");
                                        data.Brix = Decimal.Parse(datas[11]);

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Read BRIX Entry Error:" + ex.Message);
                                        Console.WriteLine("Data Brix Error:" + datas[10]);
                                    }
                                    try
                                    {
                                        data.Barcode = datas[22];
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Read Base Entry Error:" + ex.Message);
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
                        catch (Exception ex) 
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message , "Informasi");
                        }
                    }
                }
            }
            catch { }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
