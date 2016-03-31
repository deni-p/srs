using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAPbobsCOM;

namespace SRS.DeskApp
{
    public partial class MDIMainForm : Form
    {
        

        public MDIMainForm()
        {
            InitializeComponent();
        }

      


        private void MDIMainForm_Load(object sender, EventArgs e)
        {
            if (Login2.UserLogin != null)
            {
                timer1.Start();
            }
            else
            {
                Application.Exit();
            }
            //SplashScreen spalsh = new SplashScreen();
            //Login Login = new Login();
            //spalsh.ShowDialog();
            //Login.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox1 = new AboutBox1();
            AboutBox1.MdiParent = this;
            AboutBox1.Show();
        }

    

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barangToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UserListForm FrmSearch = new UserListForm();
            FrmSearch.MdiParent = this;
            FrmSearch.Show();
            FrmSearch.WindowState = FormWindowState.Maximized;

            FrmSearch.BringToFront();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to Exit this Application?", "Sugar Cane Reception System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("dd MMMM yyyy");
            toolStripStatusLabel2.Text = DateTime.Now.ToString("hh:mm:ss") ;
        }

        private void metroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroForm f = new MetroForm();
            f.MdiParent = this;
            f.Show();
            
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void dataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterListEntryForm MasterListEntryForm = new MasterListEntryForm();
            MasterListEntryForm.MdiParent = this;
            MasterListEntryForm.Show();
            MasterListEntryForm.WindowState = FormWindowState.Maximized;

            MasterListEntryForm.BringToFront();
        }

        private void uploadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadExcelForm FrmSearch = new UploadExcelForm();
            FrmSearch.MdiParent = this;
            FrmSearch.Show();
            FrmSearch.WindowState = FormWindowState.Maximized;

            FrmSearch.BringToFront();
        }

        private void masterlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterListForm FrmSearch = new MasterListForm();
            FrmSearch.MdiParent = this;
            FrmSearch.Show();
            FrmSearch.WindowState = FormWindowState.Maximized;

            FrmSearch.BringToFront();
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrasiTTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrasiForm FrmSearch = new RegistrasiForm();
            FrmSearch.MdiParent = this;
            FrmSearch.Show();
            FrmSearch.WindowState = FormWindowState.Normal;

            FrmSearch.BringToFront();
        }

        private void daftarTTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rTiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTAListForm FrmSearch = new TTAListForm();
            FrmSearch.MdiParent = this;
            FrmSearch.StartPosition = FormStartPosition.CenterScreen;
            FrmSearch.Show();
            FrmSearch.WindowState = FormWindowState.Maximized;

            FrmSearch.BringToFront();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UploadExcelForm FrmSearch = new UploadExcelForm();
            FrmSearch.MdiParent = this;
            FrmSearch.Show();
            FrmSearch.WindowState = FormWindowState.Maximized;

            FrmSearch.BringToFront();
        }

        private void xMLReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //XMLReaderForm x = new XMLReaderForm();
            //x.Show();
        }

        private void timbanganInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimbanganMasukForm FrmSearch = new TimbanganMasukForm();
            FrmSearch.MdiParent = this;
            FrmSearch.WindowState = FormWindowState.Normal;
            FrmSearch.StartPosition = FormStartPosition.CenterScreen;

            FrmSearch.Show();
            
            

            FrmSearch.BringToFront();
        }

        private void coreSamplingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoreSamplingForm FrmSearch = new CoreSamplingForm();
            FrmSearch.MdiParent = this;
            FrmSearch.Show();

            FrmSearch.WindowState = FormWindowState.Normal;
            FrmSearch.StartPosition = FormStartPosition.CenterScreen;

            FrmSearch.BringToFront();
            
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadExcelForm FrmSearch = new UploadExcelForm();
            FrmSearch.MdiParent = this;
            FrmSearch.Show();
            FrmSearch.WindowState = FormWindowState.Maximized;

            FrmSearch.BringToFront();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            RegistrasiForm  FrmSearch = new RegistrasiForm ();
            FrmSearch.MdiParent = this;
            FrmSearch.Show();
            FrmSearch.WindowState = FormWindowState.Normal;

            FrmSearch.BringToFront();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TimbanganMasukForm FrmSearch = new TimbanganMasukForm();
            FrmSearch.MdiParent = this;
            FrmSearch.Show();
            FrmSearch.StartPosition = FormStartPosition.CenterParent;
            FrmSearch.WindowState = FormWindowState.Normal;

            FrmSearch.BringToFront();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CoreSamplingForm FrmSearch = new CoreSamplingForm();
            FrmSearch.MdiParent = this;
            FrmSearch.Show();
            FrmSearch.WindowState = FormWindowState.Normal;

            FrmSearch.BringToFront();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.Show();
        }

        private void unloadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnloading FrmSearch = new frmUnloading();
            FrmSearch.MdiParent = this;
            FrmSearch.Show();
            FrmSearch.WindowState = FormWindowState.Maximized;
            FrmSearch.BringToFront();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserListForm f = new UserListForm();
            f.Show();
            f.WindowState = FormWindowState.Maximized;
            f.BringToFront();
        }

        private void deviceSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceConfigurationForm dcf = new DeviceConfigurationForm();
            dcf.Show();
            dcf.WindowState = FormWindowState.Normal;
            dcf.StartPosition = FormStartPosition.CenterScreen;
            dcf.BringToFront();
        }

        private void registrasiPetaniBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrasiNewForm FrmSearch = new RegistrasiNewForm();
            FrmSearch.MdiParent = this;
            FrmSearch.Show();
            FrmSearch.WindowState = FormWindowState.Normal;

            FrmSearch.BringToFront();
        }

        private void MDIMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort. 
            if (MessageBox.Show(this,"Do you want to Exit this Application ?","Sugar Cane Reception System",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Call method to save file...
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void menuTransaksi_Click(object sender, EventArgs e)
        {
            

            
        }

        private void menuKredit_Click(object sender, EventArgs e)
        {
            
            
        }

        private void kreditKKPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trans_Pencairan FrmCair = new Trans_Pencairan();
            FrmCair.MdiParent = this;
            FrmCair.Show();
            FrmCair.WindowState = FormWindowState.Normal;

            FrmCair.BringToFront();
        }

        private void kKPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransGr FrmCicil = new TransGr();
            FrmCicil.MdiParent = this;
            FrmCicil.Show();
            FrmCicil.WindowState = FormWindowState.Normal;

            FrmCicil.BringToFront();
        }

        private void nonKKPEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransCicilan FrmJualTebu = new TransCicilan();
            FrmJualTebu.MdiParent = this;
            FrmJualTebu.Show();
            FrmJualTebu.WindowState = FormWindowState.Normal;

            FrmJualTebu.BringToFront();
        }

        private void menuMutasi_Click(object sender, EventArgs e)
        {

        }

        private void penerimaanTebuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransGrPo FrmPenerimaanTebu = new FrmTransGrPo();
            FrmPenerimaanTebu.MdiParent = this;
            FrmPenerimaanTebu.Show();
            FrmPenerimaanTebu.WindowState = FormWindowState.Normal;
            FrmPenerimaanTebu.BringToFront();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MasterInventory FrmInventory = new MasterInventory();
            //FrmInventory.MdiParent = this;
            //FrmInventory.Show();
            //FrmInventory.WindowState = FormWindowState.Normal;
            //FrmInventory.BringToFront();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterAcc FrmMasterAcc = new MasterAcc();
            FrmMasterAcc.MdiParent = this;
            FrmMasterAcc.Show();
            FrmMasterAcc.WindowState = FormWindowState.Normal;
            FrmMasterAcc.BringToFront();
        }
    }
}
