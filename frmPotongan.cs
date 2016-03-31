using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SRS.DeskApp
{
    public partial class frmPotongan : SRS.DeskApp.MetroForm
    {
        public frmPotongan()
        {
            InitializeComponent();
        }

        private void btn2P_Click(object sender, EventArgs e)
        {
            MetroButton btn = sender as MetroButton;
            txtPotongan.Text = btn.Tag.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
