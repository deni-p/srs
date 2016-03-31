using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SRS.DeskApp
{
    public partial class frmListMenu : SRS.DeskApp.MetroForm
    {
        private static string id;

        public static string Id
        {
            get { return frmListMenu.id; }
            set { frmListMenu.id = value; }
        }
        public frmListMenu()
        {
            InitializeComponent();
        }
    }
}
