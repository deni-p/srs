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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
            this.Load += frmSetting_Load;
        }

        void frmSetting_Load(object sender, EventArgs e)
        {

            loadSetting();
            //throw new NotImplementedException();
        }
        private void loadSetting()
        {
            txtCSV.Text = Properties.Settings.Default.csv_file;
            txtCSVManual.Text = Properties.Settings.Default.csv_file_manual;
            IPAddressGate1.Text = Properties.Settings.Default.ip_gate1;
            IPAddressGate2.Text = Properties.Settings.Default.ip_gate2;
            IPAddressGate3.Text = Properties.Settings.Default.ip_gate3;
            IPAddressGate4.Text = Properties.Settings.Default.ip_gate4;
            IPAddressGate5.Text = Properties.Settings.Default.ip_gate5;
            IPAddressGate6.Text = Properties.Settings.Default.ip_gate6;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.csv_file = txtCSV.Text;
            Properties.Settings.Default.csv_file_manual = txtCSVManual.Text;
            Properties.Settings.Default.ip_core_sampling_line1 = IPAddressCoreSamplingLine1.Text;
            Properties.Settings.Default.ip_core_sampling_line2 = IPAddressCoreSamplingLine2.Text;
            Properties.Settings.Default.ip_gate1 = IPAddressGate1.Text;
            Properties.Settings.Default.ip_gate2 = IPAddressGate2.Text;
            Properties.Settings.Default.ip_gate3 = IPAddressGate3.Text;
            Properties.Settings.Default.ip_gate4 = IPAddressGate4.Text;
            Properties.Settings.Default.ip_gate5 = IPAddressGate5.Text;
            Properties.Settings.Default.ip_gate6 = IPAddressGate6.Text;
           
            Properties.Settings.Default.Save();
            loadSetting();
        }
    }
}
