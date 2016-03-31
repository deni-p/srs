using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRS.DeskApp
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void OK_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "admin" && tbPassword.Text == "admin")
            {
                MessageBox.Show(this, "Login Sukses", "Informasi", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("UID atau Password anda Salah");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit this Application?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }


      
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit this Application?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
