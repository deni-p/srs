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
using MetroFramework.Controls;

namespace SRS.DeskApp
{
    public partial class TTAFilterTGL : MetroForm
    {
        public TTAFilterTGL()
        {
            InitializeComponent();
        }
        public FilterModel FilterPrint;
        private void btShow_Click(object sender, EventArgs e)
        {
            FilterPrint = new FilterModel();
            //FilterPrint.From = dtFrom.Value;
            FilterPrint.From = new DateTime(dtFrom.Value.Year, dtFrom.Value.Month, dtFrom.Value.Day );
            FilterPrint.To = new DateTime(dtTo.Value.Year, dtTo.Value.Month, dtTo.Value.Day);
            this.Close();
        }
    }
}
