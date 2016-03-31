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
    public partial class MasterInventory : MetroForm
    {
        public MasterInventory()
        {
            InitializeComponent();
        }

        private void MasterInventory_Load(object sender, EventArgs e)
        {

        }

       

        private void metroButton1_Click(object sender, EventArgs e)
        {
            List<bool> containErr = new List<bool>();
            containErr.Add(CheckError(tbKodeBarang));
            containErr.Add(CheckError(tbNama));
            containErr.Add(CheckError(tbKeterangan));

            if (!containErr.Contains(false))
            {
                Context.m_inventory mInv = new Context.m_inventory();
                mInv.item_code = tbKodeBarang.Text;
                mInv.item_name = tbNama.Text;
                mInv.desc = tbKeterangan.Text;

                using (var srsCtx = new Context.SRSEntities())
                {
                    srsCtx.Entry(mInv).State = System.Data.Entity.EntityState.Added;
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

        public bool CheckError(MetroTextBox tb)
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
    }
}
