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

using SRS.DeskApp.DAO;
using System.Net;
namespace SRS.DeskApp
{
    public partial class Login2 : MetroForm
    {
        string username;
        string password;
        bool success = false;
        string msg = "";
        public Login2()
        {
            InitializeComponent();
        }

        private void Login2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            this.WindowState = FormWindowState.Maximized;
        }
        public static Context.User UserLogin;
        public static string HostLogin;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.MarqueeAnimationSpeed = 100;
            progressBar1.Style = ProgressBarStyle.Marquee;

            //progressBar1.Enabled = true;
            btnLogin.Enabled = false;
            btnExit.Enabled = false;

            Application.DoEvents();
            label1.Visible = true;
            username = tbUID.Text;
            password = tbPass.Text;

            backgroundWorker1.RunWorkerAsync();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this,"Do you want to Exit this Application?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            success = false;
            msg="";
            var usr = GlobalController.GetUserByUserName(username);
            if (usr != null)
            {
                if (usr.Password.Equals(password))
                {
                    //MetroMessageBox.Show(this, "Selamat Datang", "Informasi");
                    UserLogin = new Context.User();
                    UserLogin = usr;
                    HostLogin = Dns.GetHostName();
                    success = true;
                    //this.Close();
                }
                else
                {
                    msg="User name atau Password anda tidak sesuai";
                   // MetroMessageBox.Show(this, "User name atau Password anda tidak sesuai");
                }
            }
            else
            {
                 msg="Tidak ada user yang terdaftar atas nama {0}"+ username;
                //MetroMessageBox.Show(this, string.Format("Tidak ada user yang terdaftar atas nama {0}", tbUID.Text));
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Enabled = false;
            progressBar1.Visible = false;
            btnExit.Enabled = true;
            btnLogin.Enabled = true;
            label1.Visible = false;
            if(msg !=""){
                MetroMessageBox.Show(this, msg);
            }else{
                this.Close();
            }
        }

        private void tbUID_Click(object sender, EventArgs e)
        {

        }

        private void tbUID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroButton1_Click(sender, null);
            }
        }
    }
}
