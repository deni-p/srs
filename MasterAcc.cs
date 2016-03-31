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
using SRS.DeskApp.DAO;

namespace SRS.DeskApp
{
    public partial class MasterAcc : MetroForm
    {
        public MasterAcc()
        {
            InitializeComponent();
        }

        private void MasterAcc_Load(object sender, EventArgs e)
        {

        }
        private bool CheckError(MetroTextBox tb)
        {

            string text = tb.Text;

            if (text == "")
            {
                errorProvider1.SetError(tb, "Wajib diisi");
                return false;
            }
            else
            {
                //errorProvider1.Clear();
                errorProvider1.SetError(tb, "");
                return true;
            }


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            List<bool> containErr = new List<bool>();
            containErr.Add(CheckError(tbKodeInventory));
            containErr.Add(CheckError(tbExpenses));
            containErr.Add(CheckError(tbCash));
            containErr.Add(CheckError(tbAcReceivable));

            if (!containErr.Contains(false))
            {
                Context.m_conf_acc mAcc = new Context.m_conf_acc();
                mAcc.inv_code = tbKodeInventory.Text;
                mAcc.cash_acc_no = tbCash.Text;
                mAcc.ar_acc_no = tbAcReceivable.Text;
                mAcc.ex_acc_no = tbExpenses.Text;

                using (var srsCtx = new Context.SRSEntities())
                {
                    srsCtx.Entry(mAcc).State = System.Data.Entity.EntityState.Added;
                    srsCtx.SaveChanges();

                    MetroFramework.MetroMessageBox.Show(this, "Data berhasil disimpan",
                        "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, 
                    "Cek inputan anda, isian tidak boleh kosong", "Informasi", MessageBoxButtons.OK);
            }
        }

        
    }
}
