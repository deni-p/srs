using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SRS.DeskApp
{
    public class Validasi
    {

        public  void ValidateCtrl(Control c, String jenis, ErrorProvider ep1, ErrorProvider ep2, ErrorProvider ep3)
        {
            switch (jenis)
            {
                case "kosong":
                    if (c.Text == string.Empty)
                    {
                        ep1.SetError(c, "Tidak boleh kosong");
                        ep2.SetError(c, "");
                        ep3.SetError(c, "");
                    }
                    else
                    {
                        ep1.SetError(c, "");
                        ep2.SetError(c, "");
                        ep3.SetError(c, "v");
                    }
                    break;
                case "angka":
                    if (c.Text == string.Empty)
                    {
                        ep1.SetError(c, "Tidak boleh kosong");
                        ep2.SetError(c, "");
                        ep3.SetError(c, "");
                    }
                    else
                    {
                        Regex numberchk = new Regex(@"^([0-9]*|\d*)$");
                        if (numberchk.IsMatch(c.Text))
                        {
                            ep1.SetError(c, "");
                            ep2.SetError(c, "");
                            ep3.SetError(c, "v");
                        }
                        else
                        {
                            ep1.SetError(c, "");
                            ep2.SetError(c, "Format input tidak sesuai");
                            ep3.SetError(c, "");
                        }
                    }
                    break;
                default:
                    if (c.Text == string.Empty)
                    {
                        ep1.SetError(c, "Tidak boleh kosong");
                        ep2.SetError(c, "");
                        ep3.SetError(c, "");
                    }
                    else
                    {
                        ep1.SetError(c, "");
                        ep2.SetError(c, "");
                        ep3.SetError(c, "v");
                    }
                    break;
            }
        }
    }
}
