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

namespace SRS.DeskApp
{
    public partial class TTAPrintFilter : MetroForm
    {
        public TTAPrintFilter()
        {
            InitializeComponent();
        }
        public FilterPrint PrintID;
        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            PrintID = new FilterPrint();
            if (TxtFrom.Text != "" && TxtTo.Text != "")
            {
                PrintID.From = Convert.ToInt32(TxtFrom.Text);
                PrintID.To = Convert.ToInt32(TxtTo.Text);
                this.Close();
            }
            else
            {
                this.Hide();
                MetroMessageBox.Show(this, "Masukkan ID", "Print Filter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Show();
            }    
            
        }

        private void TxtFrom_Click(object sender, EventArgs e)
        {

        }

        private void TxtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtFrom.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && TxtFrom.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }

        private void TxtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
