//using Aspose.Cells;
using Equin.ApplicationFramework;
using FastReport.Barcode;
using MetroFramework;
using MetroFramework.Controls;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using SRS.DeskApp.Controller;
using SRS.DeskApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MetroFramework.Controls;

namespace SRS.DeskApp
{
    public partial class TTAListForm : MetroForm
    {
        public TTAListForm()
        {
            InitializeComponent();
           
        }

        private void DaftarTiketForm_Load(object sender, EventArgs e)
        {
            
            RefreshGrid();
            FillCombobox();
            //UpdateFont();
        }
        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in metroGrid1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 9F, GraphicsUnit.Pixel);
            }
        }
        private void headerColumn()
        {
            //0.	ID
            //1.	NamaKUD
            //2.	NoTiket
            //3.	NamaPetani
            //4.	NamaPetani2
            //5.	KodeRegister
            //6.	KodeRegister2
            //7.	Alamat
            //8.	Alamat2
            //9.	DibuatOleh
            //10.	DiserahkanOlehJabatan
            //11.	PenanggungJawab
            //12.	PenanggungJawabJabatan
            //13.	Driver
            //14.	NoTruck
            //15.	LuasLahan
            //16.	VarietasTebu
            //17.	LokasiDesa
            //18.	LokasiKec
            //19.	LokasiKab
            //20.	KodeMitra
            //21.	CreateDate
            //22.	CreateBy
            //23.	CreateTerminal
            //24.	UpdateDate
            //25.	UpdateBy
            //26.	UpdateTerminal
            //27.	tglTTA
            //28.	tglKontrak
            //29.	EstBeratTebu
            //30.	KodeMitra2
            //31.	kategori
            //32.	est_tch
            //33.	est_ritase
            //34.	est_hasil_panen
            //35.	est_radius
            //36.	tgl_panen
            //37.	no_kontrak
            //38.	est_luas_panen
            //39.	rayon
            //40.	id_status
            //41.	tiket_master_id
   

            //metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[1].HeaderText = "KUD";
            metroGrid1.Columns[2].HeaderText = "NO TIKET";
            metroGrid1.Columns[3].HeaderText = "PETANI";
            metroGrid1.Columns[7].HeaderText = "ALAMAT";
            metroGrid1.Columns[7].Width =1000;
            metroGrid1.Columns[15].Width = 600;
            metroGrid1.Columns[15].HeaderText = "LUAS LAHAN";

            metroGrid1.Columns[16].HeaderText = "VARIETAS";
            metroGrid1.Columns[17].HeaderText = "DESA";
            metroGrid1.Columns[18].HeaderText = "KEC";
            metroGrid1.Columns[19].HeaderText = "KAB";
            metroGrid1.Columns[20].HeaderText = "KODE MITRA";
            metroGrid1.Columns[27].HeaderText = "TGL TTA";
            metroGrid1.Columns[32].HeaderText = "EST TCH";
            metroGrid1.Columns[33].HeaderText = "EST RITASE";
            metroGrid1.Columns[34].HeaderText = "EST HASIL PANEN";
            metroGrid1.Columns[35].HeaderText = "EST RADIUS";
            metroGrid1.Columns[38].HeaderText = "LUAS PANEN";
            metroGrid1.Columns[39].HeaderText = "RAYON";
            metroGrid1.Columns[40].HeaderText = "PRINTED";

            metroGrid1.Columns[4].Visible = false;
            metroGrid1.Columns[5].Visible = false; //.HeaderText = "Kode Reg";
            metroGrid1.Columns[6].Visible = false;
            metroGrid1.Columns[8].Visible = false;
            metroGrid1.Columns[9].Visible = false;
            metroGrid1.Columns[10].Visible = false;
            metroGrid1.Columns[11].Visible = false;
            metroGrid1.Columns[12].Visible = false;
            metroGrid1.Columns[13].Visible = false;
            metroGrid1.Columns[14].Visible = false;
            metroGrid1.Columns[21].Visible = false;
            metroGrid1.Columns[22].Visible = false;
            metroGrid1.Columns[23].Visible = false;
            metroGrid1.Columns[24].Visible = false;
            metroGrid1.Columns[25].Visible = false;
            metroGrid1.Columns[26].Visible = false;
            metroGrid1.Columns[28].Visible = false;
            metroGrid1.Columns[29].Visible = false;
            metroGrid1.Columns[30].Visible = false;
            metroGrid1.Columns[31].Visible = false;
            metroGrid1.Columns[36].Visible = false;
            metroGrid1.Columns[37].Visible = false;
            metroGrid1.Columns[41].Visible = false;
            foreach (DataGridViewColumn c in metroGrid1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Segoe UI", 12F, GraphicsUnit.Pixel);
            }
        }

        BindingListView<Context.Tiket> biUser;
        public void RefreshGrid()
        {
            
            //metroGrid1.DataSource = null;
            //if (metroComboBox1.SelectedIndex = -1)
            //{
            metroComboBox1.SelectedIndex = 0;
            //}
            
            TxtSearch.Text = "";
            //Console.WriteLine(metroComboBox1.SelectedIndex);
            //biUser.Dispose();
            var datas = GlobalController.RefershTiket(Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));
            biUser = new BindingListView<Context.Tiket>(datas);
            
            //metroGrid1.DataSource = typeof(List<>);
            //biUser.Refresh();
            metroGrid1.DataSource = datas;
            //metroGrid1.AutoResizeColumns();
            //metroGrid1.Refresh();

            //metroGrid1.DataSource = biUser;
            if (datas != null && datas.Count() > 0) 
            {
                headerColumn();
            }

            TxtSearch.Focus();
            SetTotalShowData();
            BtPrev.Enabled = false;
            //metroGrid1.Refresh();

        }

        private void btInput_Click(object sender, EventArgs e)
        {
            TTAForm fr = new TTAForm();
            TTAForm.TiketID = 0;
            //tiket_id = 0;
            //fr.MdiParent = base.MdiParent;
            fr.WindowState = FormWindowState.Normal;
            fr.ShowDialog();
            
        }
        private void SetTotalShowDataFilter()
        {
            var t = GlobalController.GetCountTiketFilter(TxtSearch.Text);
            LBLDataCount.Text = "Total Data : " + t.ToString("0,0");

            if (t < Convert.ToInt32(metroComboBox1.SelectedItem.ToString()))
            {
                BtNext.Enabled = false;
                BtPrev.Enabled = false;
            }
            else
            {
                BtNext.Enabled = true;
                BtPrev.Enabled = false;
            }
        }
        private void SetTotalShowData()
        {
            var t = GlobalController.GetCountTiket(TxtSearch.Text);
            LBLDataCount.Text = "Total Data : " + t.ToString("0,0");

            if (t < Convert.ToInt32(metroComboBox1.SelectedItem.ToString()))
            {
                BtNext.Enabled = false;
                BtPrev.Enabled = false;
            }
            else
            {
                BtNext.Enabled = true;
                BtPrev.Enabled = false;
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = metroGrid1.SelectedRows;
            var user = rows[0].DataBoundItem;
        }

        //public static int tiket_id;

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var t = GlobalController.GetTikets(TxtSearch.Text, 0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));
            biUser = new BindingListView<Context.Tiket>(t);
            metroGrid1.DataSource = biUser;
            SetTotalShowData();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroMessageBox.Show(this,"Hapus semua data Tiket ?", "Konfirmasi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                GlobalController.DeleteTiketTA();
                RefreshGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private static BindingListView<Context.Tiket> TiketFieldName;
        private void FillCombobox()
        {


            //var tiketlist = GlobalController.LoadFieldTiket ();
            //TiketFieldName = new BindingListView<Context.Tiket>(tiketlist);
            //CmbSearchBy.DataSource = TiketFieldName;
            
            CmbSearchBy.Items.Add("NAMAPETANI");
            CmbSearchBy.Items.Add("TGLTTA");
            CmbSearchBy.Items.Add("RAYON");
            CmbSearchBy.Items.Add("NO_KONTRAK");

            //CmbSearchBy.DisplayMember = "COLUMN_NAME";
            //CmbSearchBy.ValueMember = "ORDINAL_POSITION";
            //CmbSearchBy.Invalidate();

            //CmbSearchBy.DisplayMember = "FieldName";

        }

        public static BindingListView<Context.Tiket> TiketlistsPublic;
        private void metroButton3_Click(object sender, EventArgs e)
        {
            var tiketlist = GlobalController.loadTTA();
            TiketlistsPublic = new BindingListView<Context.Tiket>(tiketlist);
            metroGrid1.DataSource = TiketlistsPublic;

            var result = TiketlistsPublic.ToList();
            if (result.Count > 0)
            {
                MasterlistChart mc = new MasterlistChart();
                mc.ShowDialog();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Tidak ada data yang diproses", "Informasi", MessageBoxButtons.OK);
            }
        }

        private void BtNext_Click(object sender, EventArgs e)
        {
            BtPrev.Enabled = true;
            int cdatas = GlobalController.GetCountTTA(TxtSearch.Text);
            int showdata = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());
            int posisi = Convert.ToInt32(LBLPaging.Text);

            int take = showdata;
            int skip = (posisi) * showdata;

            var datas = GlobalController.GetTikets(TxtSearch.Text, skip, take);

            if (datas != null && datas.Count > 0)
            {

                var biTiket = new BindingListView<Context.Tiket>(datas);


                metroGrid1.DataSource = biTiket;
                LBLPaging.Text = (++posisi).ToString();
                // maximal next
                if ((showdata * (Convert.ToInt32(LBLPaging.Text) - 1) + datas.Count) >= cdatas)
                {
                    BtNext.Enabled = false;
                    BtPrev.Enabled = true;
                }
            }
        }

        private void BtPrev_Click(object sender, EventArgs e)
        {
            BtNext.Enabled = true;

            int cdatas = GlobalController.GetCountTTA(TxtSearch.Text);
            int showdata = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());
            int posisi = Convert.ToInt32(LBLPaging.Text);

            int take = showdata;
            int skip = (posisi - 2) * showdata;

            var datas = GlobalController.GetTikets(TxtSearch.Text, skip, take);
            var biTikets = new BindingListView<Context.Tiket>(datas);
            LBLPaging.Text = (--posisi).ToString();
            if (posisi <= 1)
            {
                BtNext.Enabled = true;
                BtPrev.Enabled = false;
            }

            metroGrid1.DataSource = biTikets;
        }

        private void BtLast_Click(object sender, EventArgs e)
        {
            int cdatas = GlobalController.GetCountTTA(TxtSearch.Text);
            int showdata = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());

            var sisabagi = cdatas % showdata;
            int pembagian = cdatas / showdata;

            if (sisabagi > 0)
            {
                int skip = Convert.ToInt32(pembagian) * showdata;
                int take = showdata;

                var datas = GlobalController.GetTikets(TxtSearch.Text, skip, take);
                var biTiket = new BindingListView<Context.Tiket>(datas);

                metroGrid1.DataSource = biTiket;

                LBLPaging.Text = (++pembagian).ToString();

            }
            else
            {
                var datas = GlobalController.GetTikets(TxtSearch.Text, ((int)--pembagian) * showdata, showdata);
                var biTiket = new BindingListView<Context.Tiket>(datas);
                metroGrid1.DataSource = biTiket;

                LBLPaging.Text = (pembagian).ToString();

            }

            //(con.CountData() - Convert.ToInt32(metroComboBox1.SelectedItem.ToString())).ToString();
            BtPrev.Enabled = true;
            BtNext.Enabled = false;

            if (showdata >= cdatas)
            {
                BtPrev.Enabled = false;
                BtNext.Enabled = false;
            }
        }

        private void BtFirst_Click(object sender, EventArgs e)
        {
            var datas = GlobalController.GetTikets(TxtSearch.Text, 0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));

            metroGrid1.DataSource = datas;//con.GetListData(0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString())).ToList<Barang>();
            //LBLDataCount.Text = "0";
            LBLPaging.Text = "1";
            BtPrev.Enabled = false;
            BtNext.Enabled = true;

            int showdata = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());

            int coutnMaster = GlobalController.GetCountTiket(TxtSearch.Text);

            if (showdata < coutnMaster)
            {
                BtPrev.Enabled = false;
                BtNext.Enabled = true;
            }
            else
            {
                BtPrev.Enabled = false;
                BtNext.Enabled = false;
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            TTAPrintFilter  f = new TTAPrintFilter ();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
            FilterPrint fPrint = new FilterPrint();

            if (f.PrintID != null)
            {
                fPrint = f.PrintID;
                try
                {

                    btPrint.Enabled = false;
                    int totalData = GlobalController.GetCountTiket(TxtSearch.Text);
                    Console.WriteLine("Total Data:" + totalData.ToString());
                    int recordPerPage = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());
                    Console.WriteLine("recordPerPage:" + totalData.ToString());
                    int posisi = Convert.ToInt32(LBLPaging.Text);
                    //int posisi = Convert.ToInt32(LBLPaging.Text);
                    Console.WriteLine("posisi:" + posisi.ToString());
                    int take = recordPerPage;
                    int skip = posisi * recordPerPage;
                    string search = TxtSearch.Text;
                    //int nstart = 3;
                    //int nstop = 7;

                    new System.Threading.Thread(() =>
                    {
                        try
                        {
                            var datas = GlobalController.PrintTikets(fPrint.From, fPrint.To, take);
                            if (datas.Count <= 0)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    MessageBox.Show("Data Kosong");
                                });
                                return;
                            }

                            //report1.Load(@"d:\test.frx");

                            ////report1.GetDataSource("User");
                            //FastReport.TextObject nama = report1.FindObject("txtNama") as FastReport.TextObject;
                            //nama.Text = "[User.Nama]";
                            //FastReport.TextObject alamat = report1.FindObject("txtAlamat") as FastReport.TextObject;
                            //alamat.Text = "[User.Alamat]";


                            //report1.RegisterData(listData, "User");
                            //report1.GetDataSource("User").Enabled = true;
                            //(report1.FindObject("Data1") as DataBand).DataSource = report1.GetDataSource("User");

                            //report1.Show();

                            this.Invoke((MethodInvoker)delegate
                            {
                                report1.Load(@"Report\tta.frx");
                                //FastReport.Barcode bc;
                                //FastReport.Barcode.Barcode39Extended bc = new FastReport.Barcode.Barcode39Extended();

                                //Context.Tiket t;

                                // t.NamaPetani
                                //t.NoTiket
                                // t.KodeMitra
                                //(report1.FindObject("txtNoTTA") as BarcodeObject).Text = "[Tiket.NoTiket]";

                                FastReport.TextObject txtTglTiket = report1.FindObject("txtTglTiket") as FastReport.TextObject;
                                txtTglTiket.Text = "[Tiket.tglTTA]";

                                FastReport.TextObject txtNamaPetani = report1.FindObject("txtNamaPetani") as FastReport.TextObject;
                                txtNamaPetani.Text = "[Tiket.NamaPetani]"; //namaPetani
                                FastReport.TextObject txtAlamatKTP = report1.FindObject("txtAlamatKTP") as FastReport.TextObject;
                                txtAlamatKTP.Text = "[Tiket.Alamat]";

                                FastReport.TextObject txtNoTruk = report1.FindObject("txtNoTruk") as FastReport.TextObject;
                                txtNoTruk.Text = "[Tiket.NoTruck]";
                                FastReport.TextObject txtEstLuasPanen = report1.FindObject("txtEstLuasPanen") as FastReport.TextObject;
                                txtEstLuasPanen.Text = "[Tiket.LuasLahan]";
                                FastReport.TextObject txtVarietasTebu = report1.FindObject("txtVarietasTebu") as FastReport.TextObject;
                                txtVarietasTebu.Text = "[Tiket.VarietasTebu]";
                                FastReport.TextObject txtDesaa = report1.FindObject("txtDesa") as FastReport.TextObject;
                                txtDesaa.Text = "[Tiket.LokasiDesa]";
                                FastReport.TextObject txtKecamatan = report1.FindObject("txtKecamatan") as FastReport.TextObject;
                                txtKecamatan.Text = "[Tiket.LokasiKec]";
                                FastReport.TextObject txtKabupaten = report1.FindObject("txtKabupaten") as FastReport.TextObject;
                                txtKabupaten.Text = "[Tiket.LokasiKab]";
                                FastReport.TextObject txtDibuatOleh = report1.FindObject("txtDibuatOleh") as FastReport.TextObject;
                                txtDibuatOleh.Text = "[Tiket.DibuatOleh]";
                                FastReport.TextObject txtPenanggungJawan = report1.FindObject("txtPenanggungJawab") as FastReport.TextObject;
                                txtPenanggungJawan.Text = "[Tiket.PenanggungJawab]";

                                FastReport.TextObject TxtNoKontrak = report1.FindObject("TxtNoKontrak") as FastReport.TextObject;
                                if (TxtNoKontrak != null)
                                {
                                    TxtNoKontrak.Text = "[Tiket.no_kontrak]";
                                }
                                FastReport.TextObject TxtKodeMitra = report1.FindObject("TxtKodeMitra") as FastReport.TextObject;
                                if (TxtKodeMitra != null)
                                {
                                    TxtKodeMitra.Text = "[Tiket.KodeMitra]";
                                }
                                FastReport.TextObject TxtKUD = report1.FindObject("TxtKUD") as FastReport.TextObject;
                                TxtKUD.Text = "[Tiket.NamaKUD]";

                                FastReport.TextObject txtNoTTA = report1.FindObject("txtNoTTA") as FastReport.TextObject;
                                txtNoTTA.Text = "[Tiket.NoTiket]";

                                report1.RegisterData(datas, "Tiket");
                                report1.GetDataSource("Tiket").Enabled = true;
                                (report1.FindObject("Data1") as FastReport.DataBand).DataSource = report1.GetDataSource("Tiket");

                                //BarcodeObject txtNoTTA = report1.FindObject("txtNoTTA") as BarcodeObject;
                                //txtNoTTA.Barcode= new FastReport.Barcode.Barcode39();
                                //txtNoTTA.ShowText = true;
                                //txtNoTTA.SymbologyName = "Code39";
                                ////txtNoTTA.Text = ;
                                //txtNoTTA.DataColumn = "[Tiket.NoTiket]";



                                report1.Show();
                            });
                        }
                        catch (Exception ex)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                MessageBox.Show("Error Load Report..." + ex.Message);
                            });
                        }
                    }).Start();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Print:" + ex.Message);
                }
                finally
                {
                    btPrint.Enabled = true;
                }
            }
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        private void toggle(bool enable)
        {
            btnChart.Enabled = enable;
            btnDelete.Enabled = enable;
            btnExport.Enabled = enable;
            btnUpload.Enabled = enable;

            var c = GetAll(this, typeof(Button));
            foreach (Button b in c)
            {
                b.Enabled = enable;
            }
            var c2 = GetAll(this, typeof(MetroButton));
            foreach (MetroButton b in c2)
            {
                b.Enabled = enable;
            }
            progressBar1.Visible = !enable;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Enabled = !enable;
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.StreamReader sr = new
                    System.IO.StreamReader(openFileDialog1.FileName);
                    sr.Close();

                    string path = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                    string errMsg = "";
                    if (openFileDialog1.CheckFileExists)
                    {
                        toggle(false);
                        progressBar1.Visible = true;
                        progressBar1.Style = ProgressBarStyle.Marquee;
                        progressBar1.Enabled = true;
                        
                        new System.Threading.Thread(() =>
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            
                            Repository.ExtractTiket(path, out errMsg, true, 0);
                            this.Invoke((MethodInvoker)delegate
                            {
                                if (errMsg.Trim().Length > 0)
                                {
                                    Cursor.Current = Cursors.Default;
                                    MessageBox.Show("Error:" + errMsg);
                                    RefreshGrid();
                                }
                                else
                                {
                                    Cursor.Current = Cursors.Default;
                                    MessageBox.Show(this, "Upload Data Sukses....","Upload Tiket",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    progressBar1.Visible = false;
                                    progressBar1.Enabled = false;
                                    RefreshGrid();
                                }
                                toggle(true);
                            });
                        }).Start();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Open File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    //Application.Exit();

                }

            }

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            GlobalController.SaveChangeAllTiket();
        }

        private void metroGrid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("metroGrid1_CellEndEdit");
            int id = 0;
            try
            {
                if (int.TryParse(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString(), out id))
                {
                    string tta = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    //Console.WriteLine("ID:" + id.ToString() +", TTA:"+ tta);
                    metroGrid1.Enabled = false;
                    new System.Threading.Thread(() =>
                    {
                        bool success=GlobalController.UpdateTiket(id, tta);
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (!success)
                            {
                                MessageBox.Show("Update TTA Error:"+ tta);
                            }
                            metroGrid1.Enabled = true;
                        });
                        

                    }).Start();
                }
            }
            catch {
                metroGrid1.Enabled = true;
            }
            
            //e.RowIndex
        }

        private void metroGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // Console.WriteLine("metroGrid1_CellValueChanged");
        }

        private void metroGrid1_DataMemberChanged(object sender, EventArgs e)
        {
           // Console.WriteLine("metroGrid1_DataMemberChanged");
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            report1.Load(@"Report\tta.frx");
            report1.Design();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string SelFilter = (string)CmbSearchBy.SelectedItem;
            switch (SelFilter)
            {
                case "NAMAPETANI":
                    var t = GlobalController.SearchTiketPetani(TxtSearch.Text, 0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));
                    biUser = new BindingListView<Context.Tiket>(t);
                break;
                case "RAYON":
                    var a = GlobalController.SearchTiketRayon(TxtSearch.Text, 0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));
                    biUser = new BindingListView<Context.Tiket>(a);
                break;
                case "NO_KONTRAK":
                    var b = GlobalController.SearchTiketKontrak(TxtSearch.Text, 0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));
                    biUser = new BindingListView<Context.Tiket>(b);
                break;
                default:
                    var c = GlobalController.SearchTiketKontrak(TxtSearch.Text, 0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));
                    biUser = new BindingListView<Context.Tiket>(c);
                break;
            }

            
            metroGrid1.DataSource = biUser;
            SetTotalShowDataFilter();

            //var t = GlobalController.GetTikets(TxtSearch.Text, 0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));
            //biUser = new BindingListView<Context.Tiket>(t);
            //metroGrid1.DataSource = biUser;
            //SetTotalShowData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            TTAPrinting  f = new TTAPrinting ();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Normal;
            f.Show();

            f.BringToFront();

            //RefreshGrid();
        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {

        }

        private void CmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelFilter = (string) CmbSearchBy.SelectedItem;
            if (SelFilter == "TGLTTA")
            {
                TxtSearch.Text = "";
                TTAFilterTGL f = new TTAFilterTGL();
                f.ShowDialog();
                FilterModel fifi = new FilterModel();
                if (f.FilterPrint != null)
                {
                    fifi = f.FilterPrint;
                    var datasource = GlobalController.GetTglTikets(fifi.From, fifi.To);
                    biUser = new BindingListView<Context.Tiket>(datasource);
                    metroGrid1.DataSource = biUser;
                    SetTotalShowData();
                }
                
            }
            else
            {
                TxtSearch.Text = "";
                TxtSearch.Focus();
             }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = metroGrid1.SelectedRows;
            var IDs = 0;
            if (metroGrid1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                IDs = (int)metroGrid1.Rows[e.RowIndex].Cells[0].Value;
            }
            TTAForm.TiketID = IDs;

            TTAForm m = new TTAForm();
            m.ShowDialog();

            RefreshGrid();
        }

        private void metroPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
