using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRS.DeskApp.DAO;
using Equin.ApplicationFramework;
using System.IO;
using System.Threading;
using MetroFramework;
namespace SRS.DeskApp
{
    public partial class MasterListForm : MetroForm
    {
        public MasterListForm()
        {
            InitializeComponent();
        }

        //public static int tiket_id;

        private void MasterListForm_Load(object sender, EventArgs e)
        {
            
            List<Context.Masterlist2> mas = new List<Context.Masterlist2>();
            MasterlistsPublic = new BindingListView<Context.Masterlist2>(mas);
            metroGrid1.DataSource = MasterlistsPublic;
            RefreshGrid();
            //headerColumn();
        }
        BindingListView<Context.Masterlist2> biUser;
        public void RefreshGrid()
        {
            metroComboBox1.SelectedIndex = 0;
            var datas = GlobalController.GetMasterList2(tbSearch.Text, 0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));
            biUser = new BindingListView<Context.Masterlist2>(datas);
            metroGrid1.DataSource = biUser;
            if (datas != null && datas.Count() > 0)
            {
                headerColumn();
            }
            tbSearch.Focus();
            SetTotalShowData();
            BtPrev.Enabled = false;
        }

        private void headerColumn()
        {
            //metroGrid1.Columns[0].Visible = false;
            //metroGrid1.Columns[1].HeaderText = "KODE";
            //metroGrid1.Columns[2].HeaderText = "NAMA";
            //metroGrid1.Columns[3].HeaderText = "KETUA KEL";
            //metroGrid1.Columns[4].HeaderText = "NAMA KEL";
            //metroGrid1.Columns[5].HeaderText = "JENIS";
            //metroGrid1.Columns[6].HeaderText = "ALAMAT";
            //metroGrid1.Columns[7].HeaderText = "No KTP";
            //metroGrid1.Columns[8].HeaderText = "No HP";
            //metroGrid1.Columns[9].HeaderText = "No KONTRAK";
            //metroGrid1.Columns[10].HeaderText = "TGL KONTRAK";
            //metroGrid1.Columns[11].HeaderText = "LUAS (Ha)";
            //metroGrid1.Columns[12].Visible = false;
            //metroGrid1.Columns[13].Visible = false;
            //metroGrid1.Columns[14].Visible = false;
            //metroGrid1.Columns[15].Visible = false;
            //metroGrid1.Columns[16].Visible = false;
            //metroGrid1.Columns[17].Visible = false;
            //metroGrid1.Columns[18].Visible = false;
            //metroGrid1.Columns[19].Visible = false;
            //metroGrid1.Columns[20].Visible = false;
            //metroGrid1.Columns[21].Visible = false;
            //metroGrid1.Columns[22].Visible = false;
            //metroGrid1.Columns[23].Visible = false;
            //metroGrid1.Columns[24].Visible = false;
            //metroGrid1.Columns[25].Visible = false;
            //metroGrid1.Columns[26].Visible = false;
            //metroGrid1.Columns[27].Visible = false;
            //metroGrid1.Columns[28].Visible = false;
            //metroGrid1.Columns[29].Visible = false;
            //metroGrid1.Columns[30].Visible = false;
            //metroGrid1.Columns[31].Visible = false;
            //metroGrid1.Columns[32].Visible = false;
            //metroGrid1.Columns[33].Visible = false;
            foreach (DataGridViewColumn c in metroGrid1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Segoe UI", 12F, GraphicsUnit.Pixel);
                c.HeaderText = c.HeaderText.ToUpper();
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btNew_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var t = GlobalController.GetMasterList2(tbSearch.Text, 0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));
            biUser = new BindingListView<Context.Masterlist2>(t);
            metroGrid1.DataSource = biUser;
            SetTotalShowData();
        }

        private void SetTotalShowData()
        {
            var t = GlobalController.GetCountMasterList2(tbSearch.Text);
            lbTotalData.Text = "Total Data : " + t.ToString("0,0");

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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            var t = GlobalController.GetMasterList2(tbSearch.Text, 0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));
            biUser = new BindingListView<Context.Masterlist2>(t);
            metroGrid1.DataSource = biUser;
            SetTotalShowData();
        }

        public DataGridViewRow SelectedRow
        {
            get { return selectedRow; }
        }

        private DataGridViewRow selectedRow = null;


        private string GetlastIDFromDatagrid()
        {
            return metroGrid1.Rows[metroGrid1.Rows.Count - 1].Cells[0].Value.ToString();
        }

        private string GetfirstIDFromDatagrid()
        {
            return metroGrid1.Rows[0].Cells[0].Value.ToString();
        }

        private void BtFirst_Click(object sender, EventArgs e)
        {
            var datas = GlobalController.GetMasterList2(tbSearch.Text, 0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));

            metroGrid1.DataSource = datas;//con.GetListData(0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString())).ToList<Barang>();
            lbTotalData.Text = "0";
            LBLPaging.Text = "1";
            BtPrev.Enabled = false;
            BtNext.Enabled = true;

            int showdata = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());

            int coutnMaster = GlobalController.GetCountMasterList2(tbSearch.Text);

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

        private void BtPrev_Click(object sender, EventArgs e)
        {
            BtNext.Enabled = true;

            int cdatas = GlobalController.GetCountMasterList2(tbSearch.Text);
            int showdata = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());
            int posisi = Convert.ToInt32(LBLPaging.Text);

            int take = showdata;
            int skip = (posisi - 2) * showdata;

            var datas = GlobalController.GetMasterList2(tbSearch.Text, skip, take);
            var biUser = new BindingListView<Context.Masterlist2>(datas);
            LBLPaging.Text = (--posisi).ToString();
            if (posisi <= 1)
            {
                BtNext.Enabled = true;
                BtPrev.Enabled = false;
            }

            metroGrid1.DataSource = biUser;
        }

        private void BtNext_Click(object sender, EventArgs e)
        {
            BtPrev.Enabled = true;
            int totalData = GlobalController.GetCountMasterList2(tbSearch.Text);
            int recordPerpage = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());
            int page = Convert.ToInt32(LBLPaging.Text);

            int take = recordPerpage;
            int skip = (page) * recordPerpage;

            var listData = GlobalController.GetMasterList2(tbSearch.Text, skip, take);

            if (listData != null && listData.Count > 0)
            {

                var biUser = new BindingListView<Context.Masterlist2>(listData);


                metroGrid1.DataSource = biUser;
                LBLPaging.Text = (++page).ToString();
                // maximal next
                if ((recordPerpage * (Convert.ToInt32(LBLPaging.Text) - 1) + listData.Count) >= totalData)
                {
                    BtNext.Enabled = false;
                    BtPrev.Enabled = true;
                }
            }

        }

        private void BtLast_Click(object sender, EventArgs e)
        {
            int cdatas = GlobalController.GetCountMasterList2(tbSearch.Text);
            int showdata = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());

            var sisabagi = cdatas % showdata;
            int pembagian = cdatas / showdata;

            if (sisabagi > 0)
            {
                int skip = Convert.ToInt32(pembagian) * showdata;
                int take = showdata;

                var datas = GlobalController.GetMasterList2(tbSearch.Text, skip, take);
                var biUser = new BindingListView<Context.Masterlist2>(datas);

                metroGrid1.DataSource = biUser;

                LBLPaging.Text = (++pembagian).ToString();

            }
            else
            {
                var datas = GlobalController.GetMasterList2(tbSearch.Text, ((int)--pembagian) * showdata, showdata);
                var biUser = new BindingListView<Context.Masterlist2>(datas);
                metroGrid1.DataSource = biUser;

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = metroGrid1.SelectedRows;
            var user = rows[0].DataBoundItem;
        }

        public static int masterlis_id;
        private void metroGrid1_RowHeaderMouseDoubleClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = metroGrid1.SelectedRows;
            var IDs = 0;
            if (metroGrid1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                IDs = (int)metroGrid1.Rows[e.RowIndex].Cells[0].Value;
            }
            masterlis_id = IDs;

            //MasterListEntryForm f = new MasterListEntryForm();
            //MasterListEntryForm.SendData = null;
            //MasterListEntryForm.isOpenFromMaster = false;

            MasterListEntryForm m = new MasterListEntryForm();
            MasterListEntryForm.isOpenFromMaster = true;
            MasterListEntryForm.SendData = new Context.Masterlist2();
            MasterListEntryForm.SendData.ID = masterlis_id;
            m.ShowDialog();

            RefreshGrid();

            #region Obsolete

            //// var user = rows as DataRowView;
            //// var row = user.Row as DataRow;

            //// var val = row[0] as Context.Masterlist;

            ////// var t = ((ObjectView<SRS.DeskApp.Context.Masterlist>)user);


            //ReqData = (Context.Masterlist)user as Context.Masterlist;


            //////MetroFramework.MetroMessageBox.Show(this, string.Format("File : {0}, masterlist", u.PartnerName), "Informasi", MessageBoxButtons.OK);

            ////var t = System.Configuration.ConfigurationSettings.AppSettings["templatePath"];// Path.Combine(System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]), @"\template\Template KTM.xls");
            //////MetroFramework.MetroMessageBox.Show(this, string.Format("File : {0}, masterlist",t), "Informasi", MessageBoxButtons.OK);

            ////Workbook wb = new Workbook(t);
            ////var ws = wb.Worksheets[0];

            ////ws.Cells["C6"].Value = "";
            ////ws.Cells["C7"].Value = u.ContractDate;
            ////ws.Cells["H7"].Value = u.ContractDate;
            ////ws.Cells["C8"].Value = u.PartnerName;
            ////ws.Cells["C9"].Value = u.PartnerID;
            ////ws.Cells["C10"].Value = u.Address;
            ////ws.Cells["C11"].Value = "";
            ////ws.Cells["C12"].Value = u.LandArea;
            ////ws.Cells["C13"].Value = u.SubDistrict;
            ////ws.Cells["C14"].Value = u.SubDistrict;
            ////ws.Cells["C15"].Value = u.District;

            ////var outpa = System.Configuration.ConfigurationSettings.AppSettings["outPath"];// Path.Combine(System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]), @"\template\Template KTM.xls");

            ////string name = @outpa + DateTime.Now.ToString("dd-MMM-yyyy-hhmmss") + "-" + "Tiket-KTA" + ".xlsx";

            ////wb.Save(name, SaveFormat.Xlsx);
            ////MetroFramework.MetroMessageBox.Show(this, string.Format("File Berhasil disimpan di : {0}", name), "Informasi", MessageBoxButtons.OK);

            #endregion

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btInput_Click(object sender, EventArgs e)
        {
            //masterlis_id = 0;



            //MasterListEntryForm frm = new MasterListEntryForm();
            //MasterListEntryForm.isOpenFromMaster = true;
            //MasterListEntryForm.SendData.ID = 
            //frm.ShowDialog();
        }


        public List<Context.Tiket> GenerateNoTiket(List<Context.Tiket> Tikets)
        {
            List<Context.Tiket> tiks = new List<Context.Tiket>();
            int i = 0;
            foreach (var t in Tikets)
            {
                i++;
                t.NoTiket = "TA" + i.ToString("000000");
                //System.Threading.Thread.Sleep(1);
                tiks.Add(t);
            }
            return tiks;
        }

        private void metrometroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static BindingListView<Context.Masterlist2> MasterlistsPublic;
        private void btInput_Click_1(object sender, EventArgs e)
        {
            MasterListEntryForm f = new MasterListEntryForm();
            MasterListEntryForm.SendData = null;
            MasterListEntryForm.isOpenFromMaster = false;
            f.ShowDialog();

            Context.Masterlist2 newData = MasterListEntryForm.masterData;
            if (newData.est_radius != null)
            {
                var currentData = MasterlistsPublic.ToList();
                currentData.Add(newData);

                MasterlistsPublic = new BindingListView<Context.Masterlist2>(currentData);
                metroGrid1.DataSource = MasterlistsPublic;
                metroGrid1.Refresh();
                headerColumn();

                MasterListEntryForm.masterData = new Context.Masterlist2();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
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

        private void tbEntryTTA_Click(object sender, EventArgs e)
        {

            TTAForm fr = new TTAForm();
            TTAForm.TiketID = 0;
            //fr.MdiParent = base.MdiParent;
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.WindowState = FormWindowState.Normal;
            fr.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtFirst_Click_1(object sender, EventArgs e)
        {
            var datas = GlobalController.GetMasterList(tbSearch.Text, 0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString()));

            metroGrid1.DataSource = datas;//con.GetListData(0, Convert.ToInt32(metroComboBox1.SelectedItem.ToString())).ToList<Barang>();
            //LBLDataCount.Text = "0";
            LBLPaging.Text = "1";
            BtPrev.Enabled = false;
            BtNext.Enabled = true;

            int showdata = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());

            int coutnMaster = GlobalController.GetCountMasterList2(tbSearch.Text);

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

        private void BtNext_Click_1(object sender, EventArgs e)
        {
            BtPrev.Enabled = true;
            int cdatas = GlobalController.GetCountMasterList2(tbSearch.Text);
            int showdata = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());
            int posisi = Convert.ToInt32(LBLPaging.Text);

            int take = showdata;
            int skip = (posisi) * showdata;

            var datas = GlobalController.GetMasterList(tbSearch.Text, skip, take);

            if (datas != null && datas.Count > 0)
            {

                var biTiket = new BindingListView<Context.Masterlist2>(datas);


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

        private void BtLast_Click_1(object sender, EventArgs e)
        {
            int cdatas = GlobalController.GetCountMasterList2(tbSearch.Text);
            int showdata = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());

            var sisabagi = cdatas % showdata;
            int pembagian = cdatas / showdata;

            if (sisabagi > 0)
            {
                int skip = Convert.ToInt32(pembagian) * showdata;
                int take = showdata;

                var datas = GlobalController.GetMasterList(tbSearch.Text, skip, take);
                var biTiket = new BindingListView<Context.Masterlist2>(datas);

                metroGrid1.DataSource = biTiket;

                LBLPaging.Text = (++pembagian).ToString();

            }
            else
            {
                var datas = GlobalController.GetMasterList(tbSearch.Text, ((int)--pembagian) * showdata, showdata);
                var biTiket = new BindingListView<Context.Masterlist2>(datas);
                metroGrid1.DataSource = biTiket;

                LBLPaging.Text = (pembagian).ToString();

            }

            BtPrev.Enabled = true;
            BtNext.Enabled = false;

            if (showdata >= cdatas)
            {
                BtPrev.Enabled = false;
                BtNext.Enabled = false;
            }
        }

        private void BtPrev_Click_1(object sender, EventArgs e)
        {
            BtNext.Enabled = true;

            int cdatas = GlobalController.GetCountMasterList2(tbSearch.Text);
            int showdata = Convert.ToInt32(metroComboBox1.SelectedItem.ToString());
            int posisi = Convert.ToInt32(LBLPaging.Text);

            int take = showdata;
            int skip = (posisi - 2) * showdata;

            var datas = GlobalController.GetMasterList(tbSearch.Text, skip, take);
            var biTikets = new BindingListView<Context.Masterlist2>(datas);
            LBLPaging.Text = (--posisi).ToString();
            if (posisi <= 1)
            {
                BtNext.Enabled = true;
                BtPrev.Enabled = false;
            }

            metroGrid1.DataSource = biTikets;
        }

    }
}
