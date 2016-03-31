using SRS.DeskApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SRS.DeskApp.Context;
using MetroFramework.Controls;

namespace SRS.DeskApp
{
    public partial class frmUnloading : SRS.DeskApp.MetroForm
    {
        
        enum UnloadingState {stFree,stReadyUnloading,stUnloadingProgress,stFinishUnloading}
        private Dictionary<int, UnloadingState> lastState = new Dictionary<int, UnloadingState>();
        public frmUnloading()
        {
            InitializeComponent();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!bgWorker.CancellationPending)
            {


                List<tbl_transit_scan_id_device> list = GlobalController.GetTransitScanIDDeviceUnloading();
                List<device_config> listDevices = GlobalController.GetDeviceConfigByLocation("UNLOADING");

                foreach (tbl_transit_scan_id_device t in list)
                {

                    UnloadingState state;
                    switch (t.status)
                    {
                        case 0:
                            lastState.TryGetValue(t.base_entry, out state);
                            if (state == null)
                            {
                                state = UnloadingState.stFree;
                                lastState.Add(t.base_entry, state);
                            }

                            switch (state)
                            {
                                case UnloadingState.stFree:
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        foreach (device_config d in listDevices)
                                        {
                                            if (t.device_ip_address == d.device_ip && d.id==1)
                                            {
                                                btn1.BackColor = Color.Green;
                                                btn1.Enabled = true;
                                                btn1.Text = "Unloading";
                                            }
                                            if (t.device_ip_address == d.device_ip && d.id == 2)
                                            {
                                                btn2.BackColor = Color.Green;
                                                btn2.Enabled = true;
                                                btn2.Text = "Unloading";
                                            }
                                            if (t.device_ip_address == d.device_ip && d.id == 3)
                                            {
                                                btn3.BackColor = Color.Green;
                                                btn3.Enabled = true;
                                                btn3.Text = "Unloading";
                                            }
                                        }                                       
                                    });
                                    state = UnloadingState.stReadyUnloading;
                                    break;
                                case UnloadingState.stUnloadingProgress:
                                    //
                                    break;
                            }
                            break;
                    }
                }
                System.Threading.Thread.Sleep(1000);
            }

        }
        private bool startProcess(string workDir, string pathFile, string args)
        {
            bool status = false;
            try
            {
                //192.168.1.100
             //   Process p = new Process();
                //p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //p.StartInfo.WorkingDirectory = workDir;
                //p.StartInfo.FileName = pathFile;
                //p.StartInfo.Arguments = args;
                //p.StartInfo.UseShellExecute = false;
                //p.StartInfo.RedirectStandardOutput = true;
                //p.StartInfo.RedirectStandardError = true;
                //status = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Start Process Error:" + ex.Message);
                status = false;
            }

            return status;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MetroButton btn = sender as MetroButton;
            if (btn.Text == "Unloading")
            {
                string workDir = @System.IO.Directory.GetCurrentDirectory() + @"\app\unloading\";
                if (startProcess(workDir, "PUnloading.exe", ""))
                {
                    MessageBox.Show("Unloading Sukses...");
                }
            }
            else
            {
                frmPotongan f = new frmPotongan();
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MetroButton btn2 = sender as MetroButton;
                    btn2.BackColor = Color.Gray;
                    int id = int.Parse(btn2.Tag.ToString());
                    switch (id)
                    {
                        case 1:
                            btn2.BackColor = Color.Gray;
                            break;
                    }
                }
            }
        }

        private void frmUnloading_Load(object sender, EventArgs e)
        {

        }
    }
}
