using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using SRS.DeskApp.DAO;
namespace SRS.DeskApp
{
    public partial class MasterlistChart : MetroForm
    {
        public MasterlistChart()
        {
            InitializeComponent();
            this.metroPanel1.MouseWheel += new MouseEventHandler(panel1_MouseWheel);
            this.metroPanel1.MouseMove += new MouseEventHandler(panel1_MouseWheel);
        }

       

        public Dictionary<DateTime, int> chartdatas = new Dictionary<DateTime, int>();
        public static int ChartPageNo;
        public static int CountData;
        public static int MaxPage;
        private void MasterlistChart_Load(object sender, EventArgs e)
        {
            ChartPageNo = 1;
            RefreshChart(1, 30);
        }

        public void RefreshChart(int PageNo = 1, int ShowCount = 30)
        {
            this.chart1.Titles.Clear();
            this.chart1.Series.Clear();

            var datafrom = GlobalController.loadTTA();
            List<Context.Tiket> masters = new List<Context.Tiket>();
            foreach (var data in datafrom)
            {
                //Context.Tiket mm = new Context.Tiket();
                masters.Add(data);
            }

            Dictionary<string, int> datas = GlobalController.LoadTTAByDate(masters);
            this.chart1.Palette = ChartColorPalette.SeaGreen;

            this.chart1.Titles.Add("Tanggal Kontrak");

            int i = 0;
            Series series;
            if (this.chart1.Series.Where(x => x.Name == "Tanggal Kontrak").Count() <= 0)
            {
                series = new Series();
                series = this.chart1.Series.Add("Tanggal Kontrak");
            }

            Dictionary<DateTime, int> datasx = new Dictionary<DateTime, int>();
            foreach (var t in datas) //.Take(50))
            {
                if (t.Key.Trim().Equals(""))
                {
                    datasx.Add(new DateTime(1999, 1, 1), t.Value);
                }
                else
                {
                    try
                    {
                        var aasd = t.Key.Trim().Split(' ').ToArray();
                        var godate = aasd[0].Split('/');
                        DateTime d = new DateTime(Convert.ToInt32(godate[2]), Convert.ToInt32(godate[0]), Convert.ToInt32(godate[1]));
                        datasx.Add(d, t.Value);
                    }
                    catch { }
                }
                i++;

            }
            chartdatas = datasx;
            ChartPageNo = PageNo;
            CountData = datasx.Count();

            if (CountData % 30 > 0)
                MaxPage = (CountData / 30);
            else
                MaxPage = (CountData / 30) + 1;

            if (CountData >= 30)
            {
                BtNext.Enabled = true;
                BtPrev.Enabled = false;
            }

            if (ChartPageNo == 1)
            {
                foreach (var y in datasx.Take(30))
                {
                    if (y.Key == new DateTime(1999, 1, 1))
                        this.chart1.Series["Tanggal Kontrak"].Points.AddXY("No Tanggal Kontrak", y.Value);
                    else
                        this.chart1.Series["Tanggal Kontrak"].Points.AddXY(y.Key.ToString("dd-MM-yyyy"), y.Value);

                }
            }
            else
            {
                foreach (var y in datasx.Skip(PageNo * ShowCount).Take(30))
                {
                    if (y.Key == new DateTime(1999, 1, 1))
                        this.chart1.Series["Tanggal Kontrak"].Points.AddXY("No Tanggal Kontrak", y.Value);
                    else
                        this.chart1.Series["Tanggal Kontrak"].Points.AddXY(y.Key.ToString("dd-MM-yyyy"), y.Value);

                }
            }
            chart1.Series["Tanggal Kontrak"].ToolTip = "Tanggal Kontrak : #VALX, Jumlah : #VALY";
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            //chart1.ChartAreas[0].AxisY.CustomLabels= "";
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            Series ser1 = new Series("Series1");
            this.chart1.Series.Remove( ser1);

            tbPaging.Text = PageNo.ToString();

        }

        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta < 0)
                {
                    chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                }

                if (e.Delta > 0)
                {
                    double xMin = chart1.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = chart1.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = chart1.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = chart1.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                    double posXStart = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    double posXFinish = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    double posYStart = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    double posYFinish = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    chart1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    chart1.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtLast_Click_1(object sender, EventArgs e)
        {
            if (CountData % 30 > 0)
            {
                ChartPageNo = CountData / 30; // ada sisa bagi
            }
            else
            {
                // full 
                ChartPageNo = CountData / 30 - 1;
            }
            if (ChartPageNo == 0)
            {
                ChartPageNo = 1;
            }

            RefreshChart(ChartPageNo, 30);

            BtNext.Enabled = false;
            BtPrev.Enabled = true;
        }

        private void BtFirst_Click_1(object sender, EventArgs e)
        {
            RefreshChart();

            BtPrev.Enabled = false;
            BtNext.Enabled = true;
        }

        private void BtNext_Click_1(object sender, EventArgs e)
        {
            ChartPageNo = ChartPageNo + 1;
            BtPrev.Enabled = true;
            RefreshChart(ChartPageNo);

            if (ChartPageNo >= MaxPage)
            {
                BtNext.Enabled = false;
                BtPrev.Enabled = true;
            }
            else
            {
                BtNext.Enabled = true;
                BtPrev.Enabled = true;
            }

        }

        private void BtPrev_Click(object sender, EventArgs e)
        {
            ChartPageNo = ChartPageNo -1;
            BtNext.Enabled = true;
            RefreshChart(ChartPageNo);


            if (ChartPageNo <= 1)
            {
                BtNext.Enabled = true;
                BtPrev.Enabled = false;
            }
            else
            {

                BtNext.Enabled = true;
                BtPrev.Enabled = true;
            }
        }
    }
}
