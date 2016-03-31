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
namespace SRS.DeskApp
{
    public partial class UserListForm : MetroForm
    {
        //GlobalController con = new GlobalController();

        public UserListForm()
        {

            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            tbPaging.TextAlign = HorizontalAlignment.Center;
            comboBox1.SelectedIndex = 0;
        }
        BindingListView<Context.User> biUser;

        private void SetTotalShowData()
        {
            var t =GlobalController.GetCountUsers(tbSearch.Text);
            label4.Text = "Total Data : " + t.ToString();
        }
        public void RefreshGrid()
        {
            comboBox1.SelectedIndex = 0;
            var datas = GlobalController.GetUsers(tbSearch.Text, 0, Convert.ToInt32(comboBox1.SelectedItem.ToString()));
            biUser = new BindingListView<Context.User>(datas);
            dataGridView1.DataSource = biUser;
            headerColumn();
            tbSearch.Focus();
            SetTotalShowData();
            BtPrev.Enabled = false;
        }

        private void headerColumn()
        {
            dataGridView1.Columns[0].Visible = false; //ID
            dataGridView1.Columns[1].HeaderText = "User Name";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Full Name";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Create Date";
            dataGridView1.Columns[6].HeaderText = "Create By";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].HeaderText = "Role";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BarangCtrl con = new BarangCtrl();
            int coutUser = GlobalController.GetCountUsers(tbSearch.Text);
            int a = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            var datas = GlobalController.GetUsers(tbSearch.Text, 0, a);
            biUser = new BindingListView<Context.User>(datas);
            dataGridView1.DataSource = biUser;

            if (a >= coutUser)
            {
                BtNext.Enabled = false;
                BtPrev.Enabled = false;
            }
            else
            {
                BtNext.Enabled = true;
                //BtPrev.Enabled = true;

            }

            //SetTotalShowData();
        }



        public DataGridViewRow SelectedRow
        {
            get { return selectedRow; }
        }

        private DataGridViewRow selectedRow = null;


        private void DataGridView1_RowHeaderMouseDoubleClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            var user = rows[0].DataBoundItem;
            var u = ((ObjectView<SRS.DeskApp.Context.User>)(user)).Object;

            UserForm form2 = new UserForm();
            form2.id_update = u.ID;
            form2.ShowDialog();

            RefreshGrid();

        }

        private void DataGridView1_ColumnHeaderMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
            biUser.Sort = dataGridView1.Columns[e.ColumnIndex].Name;
            biUser.Filter = BindingListView<Context.User>.CreateItemFilter(new Predicate<Context.User>(
                delegate(Context.User user)
                {
                    return (user.Username.Contains(tbSearch.Text) ||
                        user.Fullname.Contains(tbSearch.Text) ||
                        user.Email.Contains(tbSearch.Text)
                        );
                }
            ));
        }


        private string GetlastIDFromDatagrid()
        {
            return dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value.ToString();
        }

        private string GetfirstIDFromDatagrid()
        {
            return dataGridView1.Rows[0].Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //FormDetilBarang form2 = new FormDetilBarang();
            //form2.ShowDialog();
            //RefreshGrid();
        }

        private void BtFirst_Click(object sender, EventArgs e)
        {
            //BarangCtrl con = new BarangCtrl();
            var datas = GlobalController.GetUsers(tbSearch.Text, 0, Convert.ToInt32(comboBox1.SelectedItem.ToString()));

            dataGridView1.DataSource = datas;//con.GetListData(0, Convert.ToInt32(comboBox1.SelectedItem.ToString())).ToList<Barang>();
            lbTotalData.Text = "0";
            tbPaging.Text = "1";
            BtPrev.Enabled = false;
            BtNext.Enabled = true;
        }

        private void BtLast_Click(object sender, EventArgs e)
        {
            //BarangCtrl con = new BarangCtrl();
            int cdatas = GlobalController.GetCountUsers(tbSearch.Text);
            int showdata = Convert.ToInt32(comboBox1.SelectedItem.ToString());

            var sisabagi = cdatas % showdata;
            int pembagian = cdatas / showdata;

            if (sisabagi > 0)
            {
                int skip = Convert.ToInt32(pembagian) * showdata;
                int take = showdata;

                var datas = GlobalController.GetUsers(tbSearch.Text, skip, take);
                var biUser = new BindingListView<Context.User>(datas);

                dataGridView1.DataSource = biUser;

                tbPaging.Text = (++pembagian).ToString();
                
            }
            else
            {
                var datas = GlobalController.GetUsers(tbSearch.Text, ((int)--pembagian) * showdata, showdata);
                var biUser = new BindingListView<Context.User>(datas);
                dataGridView1.DataSource = biUser;

                tbPaging.Text = (pembagian).ToString();

            }

            //(con.CountData() - Convert.ToInt32(comboBox1.SelectedItem.ToString())).ToString();
            BtPrev.Enabled = true;
            BtNext.Enabled = false;
        }

        private void BtPrev_Click(object sender, EventArgs e)
        {
            BtNext.Enabled = true;

            int cdatas = GlobalController.GetCountUsers(tbSearch.Text);
            int showdata = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            int posisi = Convert.ToInt32(tbPaging.Text);

            int take = showdata;
            int skip = (posisi - 2) * showdata;

            var datas = GlobalController.GetUsers(tbSearch.Text, skip, take);
            var biUser = new BindingListView<Context.User>(datas);
            tbPaging.Text = (--posisi).ToString();
            if (posisi  <= 1)
            {
                BtNext.Enabled = true;
                BtPrev.Enabled = false;
            }

            dataGridView1.DataSource = biUser;
        }

        private void BtNext_Click(object sender, EventArgs e)
        {
            BtPrev.Enabled = true;
            int cdatas = GlobalController.GetCountUsers(tbSearch.Text);
            int showdata = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            int posisi = Convert.ToInt32(tbPaging.Text);
    
            int take = showdata;
            int skip = (posisi) * showdata;

            var datas = GlobalController.GetUsers(tbSearch.Text, skip, take);
            var biUser = new BindingListView<Context.User>(datas);


            dataGridView1.DataSource = biUser;
            tbPaging.Text = (++posisi).ToString();
            // maximal next
            if ((showdata * (Convert.ToInt32(tbPaging.Text)-1) + datas.Count) >= cdatas)
            {
                BtNext.Enabled = false;
                BtPrev.Enabled = true;
            }


        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            var t = GlobalController.GetUsers(tbSearch.Text, 0, Convert.ToInt32(comboBox1.SelectedItem.ToString()));

            biUser = new BindingListView<Context.User>(t);

            dataGridView1.DataSource = biUser;
            SetTotalShowData();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            UserForm UserForm = new UserForm();
            UserForm.ShowDialog();
            RefreshGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user_id = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
                    user_id = int.Parse(row.Cells[0].Value.ToString());
                }
                catch { }
                break;
            }
          
            if (user_id == 0)
            {
                MessageBox.Show("Pilih User...");
                return;
            }
            else
            {
                userSetting f = new userSetting();
                userSetting.user_id = user_id;
                f.WindowState = FormWindowState.Normal;
                f.Show();
            }
        }


    }
}
