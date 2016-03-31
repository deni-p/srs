using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using SRS.DeskApp.DAO;
using SRS.DeskApp.Context;
using System.Threading.Tasks;

namespace SRS.DeskApp
{
    public partial class TTAPrinting : MetroForm
    {
        public TTAPrinting()
        {
            InitializeComponent();
        }

        //if (MetroMessageBox.Show(this, "Generate Data ?", "Informasi", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
        //{

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Refresh();
            Cursor.Current = Cursors.WaitCursor;
            string TAStart = TxtNoScan.Text;
            int JmlTiket = 0;
            Console.WriteLine(TAStart.Substring(TAStart.Length - 6));

            int TANumber = Convert.ToInt16(TAStart.Substring(TAStart.Length - 6));
            int RecNo = Convert.ToInt16(TxtRecNo.Text);
            if (ChkAll.Checked)
            {
                var t = GlobalController.GetCountTiketFilter("");
                JmlTiket = t + TANumber;
            }
            else
            {
                JmlTiket = Convert.ToInt16(TxtJumlahTiket.Text) + TANumber;
            }

            //EMPTYING RECORD
            GlobalController.DeleteTiketTemplate();
            int x = RecNo;
            for (var i = TANumber; i < JmlTiket; i++)
            {
                tiket_template TTA = new tiket_template();
                TTA.ID = x;
                TTA.NoTiket = "TA" + i.ToString("000000");
                x++;
                //Console.WriteLine(i);
                GlobalController.SaveGenerateTiketNo(TTA);
            }

            bool cekdouble = GlobalController.GetDoubleTiket();
            if (cekdouble == true)
            {
                this.Hide();
                Cursor.Current = Cursors.Default;
                if (Login2.UserLogin.Username.ToUpper() == "ADMIN")
                {
                    DialogResult dialogResult = MetroMessageBox.Show(this, "TTA Number sudah ada \r\n Apakah anda yakin akan merubah susunan nomor tiket ?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        GlobalController.UpdateTTA();
                        //pBar.Visible = false;
                        //pBar.Enabled = false;
                        this.Hide();
                        Cursor.Current = Cursors.Default;
                        MetroMessageBox.Show(this, "Generate Data Selesai", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                }
                else
                {
                    MetroMessageBox.Show(this, "TTA Number sudah ada \r\n Anda tidak memiliki akses untuk merubah nomor tiket", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Show();
            }
            else
            {
                GlobalController.UpdateTTA();
                //pBar.Visible = false;
                //pBar.Enabled = false;
                this.Hide();
                Cursor.Current = Cursors.Default;
                MetroMessageBox.Show(this, "Generate Data Selesai", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAll.Checked)
            {
                TxtJumlahTiket.Enabled = false;
                TxtJumlahTiket.BackColor = Color.Gray;
                var t = GlobalController.GetCountTiket("");
                TxtJumlahTiket.Text = t.ToString();// ("0,0");
            }
            else
            {
                TxtJumlahTiket.Enabled = true;
                TxtJumlahTiket.BackColor = Color.White;
                TxtJumlahTiket.Text = TxtRecNo.Text;
            }

        }

        private void TTAPrinting_Load(object sender, EventArgs e)
        {

        }

        private void TxtRecNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtJumlahTiket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
