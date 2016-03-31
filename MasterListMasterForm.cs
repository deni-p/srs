using MetroFramework.Controls;
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
namespace SRS.DeskApp
{
    public partial class MasterListMasterForm : MetroForm
    {
        public MasterListMasterForm()
        {
            InitializeComponent();
        }
        private void MasterListMasterForm_Load(object sender, EventArgs e)
        {

            if (MasterListForm.masterlis_id != null && MasterListForm.masterlis_id > 0)
            {
                var ReqData = GlobalController.GetMasterListByID(MasterListForm.masterlis_id);

                tbAddress.Text = ReqData.alamat_ktp;
                tbContactNo.Text = ReqData.no_kontrak;
                metroDateTime1.Value = Convert.ToDateTime(ReqData.tgl_kontrak== null ? new DateTime(1900, 1, 1) : ReqData.tgl_kontrak);
                tbContractNo.Text = ReqData.no_kontrak;
                tbDistrict.Text = ReqData.rayon;
                tbID.Text = ReqData.ID.ToString();
                //fix.ID = 0; // Masterlist.ID;
                tbLandArea.Text = ReqData.luas.ToString();
                tbPartnerId.Text = ReqData.kode_mitra;
                tbPartnerName.Text = ReqData.nama_mitra;// Masterlist.PartnerName;
                tbRegion.Text = ReqData.kabupaten;// Masterlist.Region;
                tbSubDistrict.Text = ReqData.kabupaten; // Masterlist.SubDistrict;
                tbSuperVisor.Text = ReqData.kecamatan; // Masterlist.Supervisor;

                tbContractNo.ReadOnly = true;
                metroButton1.Text = "Perbaharui";
            }
        }

        public bool CheckError(MetroTextBox tb)
        {
            string text = tb.Text;

            if (text.Trim().Length <= 0)
            {
               ep1.SetError(tb, "Wajib diisi");
                return false;
            }
            else
            {
                ep1.Clear();
                return true;
            }

        }
        public bool CheckError(TextBox tb)
        {
            string text = tb.Text;

            if (text.Trim().Length <= 0)
            {
                ep1.SetError(tb, "Wajib diisi");
                return false;
            }
            else
            {
                ep1.Clear();
                return true;
            }

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            List<bool> containErr = new List<bool>();
            containErr.Add(CheckError(tbDistrict));
            containErr.Add(CheckError(tbAddress));
            containErr.Add(CheckError(tbContactNo));
            containErr.Add(CheckError(tbContractNo));
            containErr.Add(CheckError(tbSubDistrict));
            containErr.Add(CheckError(tbPartnerName));
            containErr.Add(CheckError(tbPartnerId));
            containErr.Add(CheckError(textBox1));
            //containErr.Add(CheckError(tbLandArea));
            containErr.Add(CheckError(tbSuperVisor));
            containErr.Add(CheckError(tbRegion));

            if (!containErr.Contains(false))
            {
                Context.Masterlist2 fix = new Context.Masterlist2();

                //fix.Address = tbAddress.Text;
                //fix.ContactNo = tbContactNo.Text;
                //fix.ContractDate = metroDateTime1.Value;
                //fix.ContractNo = tbContractNo.Text;
                //fix.District = tbDistrict.Text;
                //    fix.ID = Convert.ToInt32( tbID.Text);
                //fix.LandArea = Convert.ToInt32(tbLandArea.Text);
                //fix.PartnerID = tbPartnerId.Text;
                //fix.PartnerName = tbPartnerName.Text;// Masterlist.PartnerName;
                //fix.Region = tbRegion.Text;// Masterlist.Region;
                //fix.SubDistrict = tbSubDistrict.Text; // Masterlist.SubDistrict;
                //fix.Supervisor = tbSuperVisor.Text; // Masterlist.Supervisor;

                //GlobalController.SaveMasterlist(fix);

                MetroFramework.MetroMessageBox.Show(this, "Data Berhasil disimpan", "Informasi", MessageBoxButtons.OK);
                this.Close();
            }

        }

    }
}
