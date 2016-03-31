using SRS.DeskApp.Context;
using SRS.DeskApp.DAO;
 
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
    public partial class DeviceConfigurationForm : MetroForm 
    {

        private Context.device_config devConfig;
 

        public DeviceConfigurationForm()
        {
            InitializeComponent();
        }

        private void DeviceConfigurationForm_Load(object sender, EventArgs e)
        {

        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
               //Mode Update user
                    string msg = "";
                    //if (id_update != null && id_update > 0)
                    //{
                      
                        //User u = new User ();
                        

                        device_config dc = new device_config();
                        //Mode Insert Device
                        //User u = new User();
                        dc.device_name  = tbNamaPerangkat.Text;
                        dc.device_ip = tbAlamatIP.Text ;
                        dc.location = cbLokasiPerangkat.Text;
                        dc.status = Convert.ToBoolean (cbStatus.Text);
                        //dc.status = Convert ( cbStatus.Items [cbStatus.SelectedIndex ].ToString().;  
                        dc.id = Convert.ToInt16  (  cbIdPosisi.Text);  
                                   

                        GlobalController.SaveDevice(dc, out msg,Login2.UserLogin);
                        MessageBox.Show(msg);
                    }
                }    

        }
    

