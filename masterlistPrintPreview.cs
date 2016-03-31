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
   

    public partial class masterlistPrintPreview : MetroForm
    {
        public masterlistPrintPreview()
        {
            InitializeComponent();
        }

        public FilterModel FilterPrint;

        private void masterlistPrintPreview_Load(object sender, EventArgs e)
        {

        }

        private void btShow_Click(object sender, EventArgs e)
        {
            FilterPrint = new FilterModel();
            FilterPrint.From = dtFrom.Value;
            FilterPrint.To = dtTo.Value;
            this.Close();
        }
    }
}
