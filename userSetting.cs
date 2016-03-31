using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SRS.DeskApp.Context;
using SRS.DeskApp.DAO;
namespace SRS.DeskApp
{
    public partial class userSetting : SRS.DeskApp.MetroForm
    {
        public static int user_id=0;
        private device_config config;
        private List<user_master_menu> listMenu=new List<user_master_menu>();
        public userSetting()
        {
            InitializeComponent();
           // chkListAccess.SelectedItem = "Text";
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<user_access_list> list = new List<user_access_list>();
            for (int i = 0; i < listBox1.Items.Count - 1; i++)
            {
                try
                {
                    ListMenu c = listBox1.Items[i] as ListMenu;
                    if (c != null)
                    {
                        user_access_list ual = new user_access_list();
                        ual.form_id = c.user_master_menu.form_id;
                        ual.user_id = user_id;//.ToString();
                        list.Add(ual);
                    }
                }
                catch { }
            }

            if (list.Count > 0)
            {
                string msgError = "";

                if (GlobalController.SaveAccessMenuUser(list,user_id, out msgError))
                {
                    MessageBox.Show("Add Date Success....");
                }
                else
                {
                    MessageBox.Show("Error :" + msgError);
                }
            }
        }

        private void userSetting_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           listMenu = GlobalController.GetMenu();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            listBox1.Items.Clear();
            foreach (user_master_menu f in listMenu)
            {
                ListMenu u = new ListMenu();
                u.Text = f.caption;
                u.user_master_menu = f;
                listBox1.Items.Add(u);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }
    }
    public class ListMenu
    {
        private string Text1;

        public string Text
        {
            get { return Text1; }
            set { Text1 = value; }
        }
        private user_master_menu User_master_menu;

        public user_master_menu user_master_menu
        {
            get { return User_master_menu; }
            set { User_master_menu = value; }
        }
        private bool allowed;

        public bool Allowed
        {
            get { return allowed; }
            set { allowed = value; }
        }
    }
}
