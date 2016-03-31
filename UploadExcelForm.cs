using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRS.DeskApp.Controller;
using MetroFramework;
using SRS.DeskApp.DAO;
using Equin.ApplicationFramework;
using System.Threading;
using System.Drawing.Printing;
using System.IO;
using SAPbobsCOM;

namespace SRS.DeskApp
{
    public partial class UploadExcelForm : MetroForm
    {
        string file;
        string msg;
        List<Context.Masterlist2> masterlists;

        Sap saExport = new Sap();
         
        long rt;
        long errCode;
        String errMsg;

        public UploadExcelForm()
        {
            InitializeComponent();
        }



        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.StreamReader sr = new
                    System.IO.StreamReader(openFileDialog1.FileName);
                    lb1.Text = openFileDialog1.FileName;
                    sr.Close();
                    if (openFileDialog1.CheckFileExists)
                    {
                        btnShow.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Open File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            
        }
        public static BindingListView<Context.Masterlist2> MasterlistsPublic;
        private void metroButton2_Click(object sender, EventArgs e)
        {
            //progressBar1.Visible = true;
            //progressBar1.Style = ProgressBarStyle.Marquee;
            //progressBar1.Enabled = true;
            

            file = openFileDialog1.InitialDirectory + openFileDialog1.FileName;

            if (MetroFramework.MetroMessageBox.Show(this, "Apakah anda akan memproses data ini? \n pemrosesan data akan membutuhkan waktu beberapa saat, silahkan menunggu hingga data ditampil pada tabel dibawah ini", "Information", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                progressBar1.Visible = true;
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.Enabled = true;
                backgroundWorker1.RunWorkerAsync();
            }

        }


        private void headerColumn()
        {
            metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[1].HeaderText = "Kode";
            metroGrid1.Columns[2].HeaderText = "Nama";
            metroGrid1.Columns[3].HeaderText = "Ketua Kel";
            metroGrid1.Columns[4].HeaderText = "Nama Kel";
            metroGrid1.Columns[5].HeaderText = "Jenis";
            metroGrid1.Columns[6].HeaderText = "Alamat";
            metroGrid1.Columns[7].HeaderText = "No KTP";
            metroGrid1.Columns[8].HeaderText = "No HP";
            metroGrid1.Columns[9].HeaderText = "No Kontrak";
            metroGrid1.Columns[10].HeaderText = "Tgl Kontrak";
            metroGrid1.Columns[11].HeaderText = "Luas (Ha)";
            metroGrid1.Columns[12].Visible = false;
            metroGrid1.Columns[13].Visible = false;
            metroGrid1.Columns[14].Visible = false;
            metroGrid1.Columns[15].Visible = false;
            metroGrid1.Columns[16].Visible = false;
            metroGrid1.Columns[17].Visible = false;
            metroGrid1.Columns[18].Visible = false;
            metroGrid1.Columns[19].Visible = false;
            metroGrid1.Columns[20].Visible = false;
            metroGrid1.Columns[21].Visible = false;
            metroGrid1.Columns[22].Visible = false;
            metroGrid1.Columns[23].Visible = false;
            metroGrid1.Columns[24].Visible = false;
            metroGrid1.Columns[25].Visible = false;
            metroGrid1.Columns[26].Visible = false;
            metroGrid1.Columns[27].Visible = false;
            metroGrid1.Columns[28].Visible = false;
            metroGrid1.Columns[29].Visible = false;
            metroGrid1.Columns[30].Visible = false;
            metroGrid1.Columns[31].Visible = false;
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            var result = MasterlistsPublic.ToList();
            if (result.Count > 0)
            {
                MasterlistChart mc = new MasterlistChart();
                mc.ShowDialog();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Tidak ada data yang diproses", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroMessageBox.Show(this, "Anda akan menghapus semua data Petani ?\r\nPastikan data telah terbackup", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                List<Context.Masterlist2> mas = new List<Context.Masterlist2>();
                MasterlistsPublic = new BindingListView<Context.Masterlist2>(mas);
                metroGrid1.DataSource = MasterlistsPublic;
                GlobalController.DeleteTempMasterList();

                return;
            }

        }

        
        private void metroButton3_Click(object sender, EventArgs e)
        {
            
            
            
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Enabled = true;
            var result = MasterlistsPublic.ToList();
            GlobalController.InsertMasterlist2(result);
            Application.DoEvents();

            MetroFramework.MetroMessageBox.Show(this, "Data, berhasil ditambahkan", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            progressBar1.Visible = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Enabled = false;
        }
        
        
        private void UploadExcelForm_Load(object sender, EventArgs e)
        {
            List<Context.Masterlist2> mas = new List<Context.Masterlist2>();
            MasterlistsPublic = new BindingListView<Context.Masterlist2>(mas);
            metroGrid1.DataSource = MasterlistsPublic;
            headerColumn();

            saExport.ConnectServer();

        }
        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            MasterListEntryForm f = new MasterListEntryForm();
            MasterListEntryForm.SendData = null;
            MasterListEntryForm.isOpenFromMaster = false;
            f.ShowDialog();

            Context.Masterlist2 newData = MasterListEntryForm.masterData;

            if (newData != null)
            {
                var currentData = MasterlistsPublic.ToList();
                currentData.Add(newData);

                MasterlistsPublic = new BindingListView<Context.Masterlist2>(currentData);
                metroGrid1.DataSource = MasterlistsPublic;
                metroGrid1.Refresh();
                headerColumn();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

            metroGrid1.DataSource = MasterlistsPublic.Where(x => x.alamat_ktp.Contains(tbSearch.Text)
                || x.kabupaten.Contains(tbSearch.Text)
                || x.kelurahan.Contains(tbSearch.Text)
                || x.kecamatan.Contains(tbSearch.Text)
                || x.nama_mitra.Contains(tbSearch.Text)
                || x.kode_mitra.Contains(tbSearch.Text)
                || x.nama_kelompok.Contains(tbSearch.Text)
                || x.ketua_kelompok.Contains(tbSearch.Text)
                ).ToList(); ;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void metroGrid1_RowHeaderMouseDoubleClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = metroGrid1.SelectedRows;
            var ux = rows[0].DataBoundItem;
            var u = ((ObjectView<SRS.DeskApp.Context.Masterlist2>)(ux)).Object;

            MasterListEntryForm f = new MasterListEntryForm();
            MasterListEntryForm.SendData = (Context.Masterlist2)u;
            MasterListEntryForm.isOpenFromMaster = false;
            f.ShowDialog();
            Context.Masterlist2 newData = MasterListEntryForm.masterData;

            if (newData != null)
            {
                var currentData = MasterlistsPublic.ToList();
                var deletedData = currentData.Where(x => x.no_kontrak == newData.no_kontrak).FirstOrDefault();

                currentData.Remove(deletedData);
                currentData.Add(newData);

                MasterlistsPublic = new BindingListView<Context.Masterlist2>(currentData);
                metroGrid1.DataSource = MasterlistsPublic;
                metroGrid1.Refresh();
                headerColumn();
            }

        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.Document = "";
            //ReadDocument();

          
            masterlistPrintPreview f = new masterlistPrintPreview();
            f.ShowDialog();
        }

        public DateTime SetNearestNextDay(DateTime curDate, Dictionary<DateTime, int> availDays)
        {
            DateTime retDate = new DateTime();
            retDate = curDate;
            var daysMore = availDays.Where(x => x.Key > curDate);
            foreach (var dm in daysMore.OrderBy(x => x.Key))
            {
                if (dm.Value < 6)
                {
                    retDate = dm.Key;
                    break;
                }
            }
            return retDate;
        }
        Dictionary<DateTime, int> daysGroup = new Dictionary<DateTime, int>();

        public void ResetDaysGroup()
        {
            var result = MasterlistsPublic.ToList();
            daysGroup = new  Dictionary<DateTime, int>();
            foreach (var f in result.GroupBy(x => x.no_kontrak))
            {
                daysGroup.Add(Convert.ToDateTime(f.Key), f.ToList().Count());
            }
        }
        private void btSmart_Click(object sender, EventArgs e)
        {
            //var result = MasterlistsPublic.ToList();
            //ResetDaysGroup();
            //foreach (var y in result.GroupBy(b => b.no_kontrak))
            //{
            //    // group more than 6 per day
            //    if (y.ToList().Count > 6)
            //    {
            //        int totalProcessData =   y.ToList().Count() - 6;

            //        for(int i=0 ; i<totalProcessData; i++)
            //        {
            //            DateTime CurDate = Convert.ToDateTime(MasterlistsPublic.Where(x => x.no_kontrak.Equals(y.ToList()[i].no_kontrak)).FirstOrDefault().no_kontrak);
            //            DateTime NowDate = SetNearestNextDay(CurDate, daysGroup);
            //            MasterlistsPublic.Where(x => x.no_kontrak.Equals(y.ToList()[i].no_kontrak)).FirstOrDefault().tgl_kontrak = NowDate;
            //            ResetDaysGroup();
            //        }

            //    }
            //}

            //MetroFramework.MetroMessageBox.Show(this, "Proses pemerataan tanggal telah selesai dilakukan", "Informasi", MessageBoxButtons.OK);

        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            List<Context.Tiket> tikets = new List<Context.Tiket>();
            var result = MasterlistsPublic.ToList();

            var userLog = Login2.UserLogin;

            foreach (var y in result)
            {
                Context.Tiket tk = new Context.Tiket();

                tk.Alamat = y.alamat_ktp;
                tk.Alamat2 = y.alamat_ktp;
                tk.DibuatOleh = "";
                tk.DiserahkanOlehJabatan = "";
                tk.Driver = "";
                tk.KodeMitra = y.kode_mitra;
                tk.KodeRegister = "";
                tk.KodeRegister2 = "";
                tk.LokasiDesa = y.kelurahan;
                tk.LokasiKab = y.kabupaten;
                tk.LokasiKec = y.kecamatan;
                tk.LuasLahan = Convert.ToDecimal( y.luas);
                tk.NamaKUD = y.kud;
                tk.NamaPetani = y.nama_mitra;
                tk.NamaPetani2 = "";
                tk.NoTiket = "";
                tk.NoTruck = "";
                tk.PenanggungJawab = "";
                tk.PenanggungJawabJabatan = "";
                tk.tglKontrak = y.tgl_kontrak;
                tk.tglTTA = new DateTime();  // generator berdasarkan tgl panen + 1
                tk.VarietasTebu = y.varietas;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          //  string errorMsg = "";
            masterlists = Repository.Extract(file, out msg, false);

            //string Path = openFileDialog1.InitialDirectory + openFileDialog1.FileName;

            //if (MetroFramework.MetroMessageBox.Show(this, "Apakah anda akan memproses data ini? \n pemrosesan data akan membutuhkan waktu beberapa saat, silahkan menunggu hingga data ditampil pada tabel dibawah ini", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    string errorMsg = "";
            //    var masterlists = Repository.Extract(Path, out errorMsg, false);
            //    var datas = masterlists;
            //    MasterlistsPublic = new BindingListView<Context.Masterlist2>(datas);
            //    metroGrid1.DataSource = MasterlistsPublic;
            //    headerColumn();
            //    MetroFramework.MetroMessageBox.Show(this, "Data Selesai Diproses", "Informasi", MessageBoxButtons.OK);

            //}
            //else
            //{

            //}
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = false;
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Enabled = false;

            MasterlistsPublic = new BindingListView<Context.Masterlist2>(masterlists);
            metroGrid1.DataSource = MasterlistsPublic;
            headerColumn();
            MetroFramework.MetroMessageBox.Show(this, "Data Selesai Diproses", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            //saExport.saveAPInvoice("ZUHRI-A-06", DateTime.Now,
            //    DateTime.Now, "A00002", 10, 1000, 60000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //saExport.saveAPInvoice();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //saExport.SaveGRPO("c12345", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString(), "C00001", 10, 1000, 60000);

        }

        private void btSAP_Click(object sender, EventArgs e)
        {
            var result = MasterlistsPublic.GroupBy( kodemitra => kodemitra.kode_mitra)
                .Select(grp => grp.First()).ToList();

            foreach (var item in result)
            {
                saExport.SaveBP(item.kode_mitra, item.nama_mitra, item.ketua_kelompok,
                    item.alamat_ktp, SAPbobsCOM.BoCardTypes.cSupplier, item.penanggung_jawab);
            }
            MetroFramework.MetroMessageBox.Show(this, "Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




    }
}
