using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SRS.DeskApp.DAO;
using SRS.DeskApp.Context;
namespace SRS.DeskApp
{
    public partial class UserForm : MetroForm
    {
        public UserForm()
        {
            InitializeComponent();
        }
        public int id_update { get; set; }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            lbid.Text = "0";
            cbRole.DataSource = new Role().Roles;

            cbRole.SelectedIndex = 0;
            if (id_update != null && id_update > 0)
            {
                lbid.Text = id_update.ToString();
                User u = GlobalController.GetUserById(Convert.ToInt32(id_update));
                tbEmail.Text = u.Email;
                tbFullname.Text = u.Fullname;
                tbPassword.Text = u.Password;
                tbUserName.Text = u.Username;
                if (u.RoleName.Equals("Administrator"))
                    cbRole.SelectedIndex = 0;
                else if (u.RoleName.Equals("Operator"))
                    cbRole.SelectedIndex = 1;
                else if (u.RoleName.Equals("Register"))
                    cbRole.SelectedIndex = 2;
                else if (u.RoleName.Equals("Payment"))
                    cbRole.SelectedIndex = 3;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            
        }

        private bool ValidateControlOnSave()
        {
            List<bool> bools = new List<bool>();
            bools.Add( SetErrorOnControl(tbUserName));
            bools.Add(SetErrorOnControl(tbPassword));
            bools.Add(SetErrorOnControl(tbFullname));
            bools.Add(SetErrorOnControl(tbEmail));

            if (bools.Contains(false))
                return false;
            else
                return true;
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            SetErrorOnControl(tbUserName);
        }
        
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            SetErrorOnControl(tbPassword);

        }
        
        private void tbFullname_TextChanged(object sender, EventArgs e)
        {
            SetErrorOnControl(tbFullname);
        }
        
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            SetErrorOnControl(tbEmail);
        }
        
        private bool SetErrorOnControl(TextBox tb)
        {
            bool x = false;
            if (tb.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(tb, "Value Cannot null");
            }
            else
            {
                x = true;
                errorProvider1.Clear();
            }
            return x;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (ValidateControlOnSave())
            {
                if (MessageBox.Show("Do you want to save this data?", "Information", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //Mode Update user
                    string msg = "";
                    if (id_update != null && id_update > 0)
                    {
                        User u = new User();
                        u = GlobalController.GetUserById(id_update);
                        u.Username = tbUserName.Text;
                        u.Fullname = tbFullname.Text;
                        u.Email = tbEmail.Text;
                        u.RoleName = cbRole.Items[cbRole.SelectedIndex].ToString();// cbRole.SelectedValue[ cbRole.SelectedIndex]
                        u.Password = tbPassword.Text;
                        GlobalController.SaveUser(u, out msg, Login2.UserLogin);
                        MessageBox.Show(msg);
                    }
                    else
                    {
                        //Mode Insert User
                        User u = new User();
                        u.Username = tbUserName.Text;
                        u.Fullname = tbFullname.Text;
                        u.Email = tbEmail.Text;
                        u.RoleName = cbRole.Items[cbRole.SelectedIndex].ToString();// cbRole.SelectedValue[ cbRole.SelectedIndex]
                        u.Password = tbPassword.Text;
                        GlobalController.SaveUser(u, out msg,Login2.UserLogin);
                        MessageBox.Show(msg);
                    }
                }
            }
        }
    
    }
}
