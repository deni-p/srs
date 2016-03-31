using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using ExcelLibrary;
using Aspose.Cells;
//using MongoDB.Bson;


namespace SRS.DeskApp.Controller
{
    using SRS.DeskApp.Context;
    using SRS.DeskApp.DAO;
    using System.IO;
    using Aspose.Cells;
    using System.ComponentModel;
    using System.Windows.Forms;
    //using ExcelLibrary.SpreadSheet;

    public static class Repository
    {
        public static void ClearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                try
                {
                    fi.Delete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Clear Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                ClearFolder(di.FullName);
                di.Delete();
            }
        }

        public static List<Masterlist2> Extract(string Path, out string ErrorMsg, bool SaveToDB = false, int SheetIndex = 0, System.IO.FileMode FileMode = System.IO.FileMode.Open)
        {
            System.IO.FileStream fstream = new System.IO.FileStream(
                       System.IO.Path.GetFullPath(@Path),
                       FileMode);
            try
            {
                List<Masterlist2> results = new List<Masterlist2>();
                Workbook workbook = new Workbook(@Path);

                int ActivWorksheet = workbook.Worksheets.Count();

                Worksheet worksheet = workbook.Worksheets[SheetIndex];


                int maxcolumn = worksheet.Cells.MaxColumn;
                int maxRow = worksheet.Cells.MaxRow;

                string StartRange = worksheet.Cells.FirstCell.Name.ToString(); ;//CellsHelper.CellIndexToName(maxRow, maxcolumn);
                string EndRange = CellsHelper.CellIndexToName(maxRow, maxcolumn);

                Range range = worksheet.Cells.CreateRange(StartRange, EndRange);
                //Loop Baris
                for (int j = 1; j < range.RowCount ; j++)
                {
                    Context.Masterlist2 masterlist = new Masterlist2();

                    DateTime dt = new DateTime(1900, 1, 1);

                    masterlist.kode_mitra = range[j, 0].Value == null ? "" : range[j, 0].Value.ToString();
                    Console.WriteLine(masterlist.kode_mitra);
                    masterlist.nama_mitra = range[j, 1].Value == null ? "" : range[j, 1].Value.ToString();
                    masterlist.ketua_kelompok = range[j, 2].Value == null ? "" : range[j, 2].Value.ToString();
                    masterlist.nama_kelompok = range[j, 3].Value == null ? "" : range[j, 3].Value.ToString();
                    masterlist.jenis_mitra = range[j, 4].Value == null ? "" : range[j, 4].Value.ToString();
                    masterlist.alamat_ktp = range[j, 5].Value == null ? "" : range[j, 5].Value.ToString();
                    masterlist.no_ktp = range[j, 6].Value == null ? "" : range[j, 6].Value.ToString();
                    masterlist.no_hp = range[j, 7].Value == null ? "" : range[j, 7].Value.ToString();
                    masterlist.no_kontrak = range[j, 8].Value == null ? "" : range[j, 8].Value.ToString();
                    try
                    {
                        masterlist.tgl_kontrak = range[j, 9].Value == null ? new DateTime(1900, 1, 1) : Convert.ToDateTime(range[j, 9].Value);
                    }
                    catch 
                    {
                        masterlist.tgl_kontrak = new DateTime(1900, 1, 1);
                    }
                    masterlist.luas = range[j, 10].Value == null ? 0 : Convert.ToDecimal(range[j, 10].Value);
                    masterlist.kategori = range[j, 11].Value == null ? "" : range[j, 11].Value.ToString();
                    masterlist.varietas = range[j, 12].Value == null ? "" : range[j, 12].Value.ToString();

                    try
                    {
                        masterlist.tgl_tanam = range[j, 13].Value == null ? new DateTime(1900, 1, 1) : Convert.ToDateTime(range[j, 13].Value);
                    }
                    catch (Exception ex)
                    {
                        masterlist.tgl_tanam = new DateTime(1900, 1, 1);
                    }

                    masterlist.rayon = range[j, 14].Value == null ? "" : range[j, 14].Value.ToString();
                    masterlist.penanggung_jawab = range[j, 15].Value == null ? "" : range[j, 15].Value.ToString();
                    masterlist.koordinat_x = range[j, 16].Value == null ? "" : range[j, 16].Value.ToString();
                    masterlist.koordinat_y = range[j, 17].Value == null ? "" : range[j, 17].Value.ToString();
                    masterlist.kelurahan = range[j, 18].Value == null ? "" : range[j, 18].Value.ToString();
                    masterlist.kecamatan = range[j, 19].Value == null ? "" : range[j, 19].Value.ToString();
                    masterlist.kabupaten = range[j, 20].Value == null ? "" : range[j, 20].Value.ToString();
                    masterlist.no_rek = range[j, 21].Value == null ? "" : range[j, 21].Value.ToString();
                    masterlist.an_rek = range[j, 22].Value == null ? "" : range[j, 22].Value.ToString();
                    masterlist.bank_rek = range[j, 23].Value == null ? "" : range[j, 23].Value.ToString();
                    masterlist.kud = range[j, 24].Value == null ? "" : range[j, 24].Value.ToString();
                    masterlist.year_period = Convert.ToInt16(DateTime.Now.Year.ToString());
                    masterlist.period_trx = DateTime.Now.Year.ToString()+"-"+ DateTime.Now.Month.ToString();
                    masterlist.reg_status = false;


                    try
                    {
                        masterlist.tgl_panen = range[j, 25].Value == null ? new DateTime(1900, 1, 1) : Convert.ToDateTime(range[j, 25].Value);
                    }
                    catch (Exception ex)
                    {
                        masterlist.tgl_panen = new DateTime(1900, 1, 1);
                    }
                    try
                    {
                        masterlist.est_tch = range[j, 26].Value == null ? 0 : Convert.ToDecimal(range[j, 26].Value);
                        //ton perHA
                    }
                    catch (Exception ex)
                    {
                        masterlist.est_tch = 0;
                    }
                    try
                    {
                        masterlist.est_hasil_panen = range[j, 27].Value == null ? 0 : Convert.ToDecimal(range[j, 27].Value);
                    }
                    catch (Exception ex)
                    {
                        masterlist.est_hasil_panen = 0;
                    }
                    try
                    {
                        masterlist.est_radius = range[j, 29].Value == null ? "" : range[j, 29].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        masterlist.est_radius = "-";
                    }
                    try
                    {
                        masterlist.est_ritase = range[j, 28].Value == null ? 0 : Convert.ToDecimal(range[j, 28].Value);
                    }
                    catch (Exception ex)
                    {
                        masterlist.est_ritase = 0;
                    }
                    //masterlist.est_radius = range[j, 28].Value == null ? "" : range[j, 28].Value.ToString();

                    results.Add(masterlist);


                }


                if (SaveToDB == true)
                {
                    GlobalController.SaveMasterlist2(results);
                }

                fstream.Dispose();
                ErrorMsg = "";
                return results;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Load Excel:" + ex.Message);
                fstream.Dispose();
                ErrorMsg = string.Format("{0}\n{1}\n{2}", ex.Message, ex.InnerException, ex.StackTrace);
                return null;
            }

            //ErrorMsg = "";
            //return null;

        }

        public static bool ExtractTiket(string Path, out string ErrorMsg, bool SaveToDB = false, int SheetIndex = 0, System.IO.FileMode FileMode = System.IO.FileMode.Open)
        {
            System.IO.FileStream fstream = new System.IO.FileStream(
                       System.IO.Path.GetFullPath(@Path),
                       FileMode);
            try
            {
                Workbook workbook = new Workbook(@Path);
                int ActivWorksheet = workbook.Worksheets.Count();

                Worksheet worksheet = workbook.Worksheets[SheetIndex];

                //int maxcolumn = worksheet.Cells.MaxColumn;
                //int maxRow = worksheet.Cells.MaxRow;

                Aspose.Cells.Range range = worksheet.Cells.MaxDisplayRange;

                int x = 0;
                for (int col = 18; col < range.ColumnCount ; col++)
                {
                    List<Tiket> tikets = new List<Tiket>();
                    try
                    {
                        if (range[0, col].Value == null) continue;
                        DateTime date2 = range[0, col].DateTimeValue;
                        DateTime date = new DateTime(date2.Year, date2.Month, date2.Day);

                        for (int row = 1; row < range.RowCount ; row++)
                        {
                            int jumlah = 0;// range[row, col].Value == null ? 0 : int.Parse(range[row, col].Value.ToString());
                            try
                            {
                                int.TryParse(range[row, col].Value.ToString(), out jumlah);
                            }
                            catch { }
                            //Console.WriteLine("ID:" + row);
                            //Console.WriteLine("Jumlah Data:" + jumlah);
                            //Console.WriteLine(range[row, 0].Value != null ? range[row, 0].Value.ToString() : "");
                            //Console.WriteLine(date);
                            for (int i = 0; i < jumlah ; i++)
                            {
                                try
                                {
                                    
                                    Tiket t = new Tiket();
                                    x++;
                                    //Console.WriteLine("ID:" + x);
                                    //Console.WriteLine("Jumlah Data:" + jumlah);
                                    //Console.WriteLine(range[row, 0].Value != null ? range[row, 0].Value.ToString() : "");
                                    //Console.WriteLine(date);
                                    t.ID  = x;
                                    t.NoTiket = "-";     //TA" + x.ToString("000000");
                                    t.NoTruck = "-";
                                    t.KodeMitra2 = "X";
                                    t.kategori = "-";
                                    t.KodeRegister = "-";
                                    t.KodeRegister2 = "-";
                                    t.LokasiDesa = "-";
                                    t.LokasiKab = "-";
                                    t.LokasiKec = "-";
                                    t.NamaKUD = "-";
                                    t.PenanggungJawab = "-";
                                    t.PenanggungJawabJabatan = "-";
                                    t.Alamat = "";
                                    t.Alamat2 = "";
                                    //t.create_date = DateTime.Now;
                                    t.CreateBy = Login2.UserLogin.Username.ToString();
                                    t.CreateDate = DateTime.Now;
                                    t.CreateTerminal = "-";
                                    //t.DibuatOleh = "0";
                                    t.DiserahkanOlehJabatan = "0";
                                    t.Driver = "-";
                                    t.EstBeratTebu = 0;
                                    t.PenanggungJawab = "-";
                                    //t.update_date = DateTime.Now;
                                    t.UpdateBy = Login2.UserLogin.Username.ToString();
                                    t.UpdateTerminal = "-";
                                    t.UpdateDate = DateTime.Now;
                                    t.NamaPetani = "-";
                                    t.NamaPetani2 = "-";
                                    t.no_kontrak = "-";
                                    t.tglKontrak = DateTime.Now;
                                    t.est_luas_panen = 0;
                                    t.id_status = false ;

                                    try
                                    {
                                        
                                        t.KodeMitra = range[row, 0].Value != null ? range[row, 0].Value.ToString() : "";
                                        //Console.WriteLine("Kode Mitra:" + t.KodeMitra);
                                        
                                        //t.NamaPetani = t.KodeMitra;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 1:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.LuasLahan = range[row, 1].Value != null ? Convert.ToDecimal(range[row, 1].Value.ToString()) : 0;

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 2:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.kategori = range[row, 2].Value != null ? range[row, 2].Value.ToString() : "";

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 3:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.VarietasTebu = range[row, 3].Value != null ? range[row, 3].Value.ToString() : "";
                                    }
                                    catch (Exception ex)
                                    {
                                        t.VarietasTebu = "";
                                        Console.WriteLine("Error parse 4:" + ex.Message);
                                    }
                                    try
                                    {
                                        DateTime dt;
                                        DateTime.TryParse(range[row, 4].Value.ToString(), out dt);
                                        if (dt != null)
                                        {
                                            t.tgl_panen = dt;
                                        }
                                        else
                                        {
                                            t.tgl_panen = date;
                                        }
                                        //t.tgl_panen = range[row, 4].Value != null ? range[row, 4].DateTimeValue : DateTime.Now;

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 5:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.est_tch = range[row, 5].Value != null ? Convert.ToDecimal(range[row, 5].Value.ToString()) : 0;


                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 6:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.est_hasil_panen = range[row, 6].Value != null ? Convert.ToDecimal(range[row, 6].Value.ToString()) : 0;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 7:" + ex.Message);
                                    }
                                    try
                                    {
                                        int ritase = 0;
                                        int.TryParse(range[row, 7].Value.ToString(), out ritase);
                                        t.est_ritase = ritase;

                                    }
                                    catch (Exception ex)
                                    {
                                        t.est_ritase = 0;
                                        Console.WriteLine("Error parse 8:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.est_radius = range[row, 8].Value != null ? range[row, 8].Value.ToString() : "";
                                        //string radius = range[row, 8].Value != null ? range[row, 8].Value.ToString() : "";
                                        //radius = radius.ToLower();
                                        //radius = radius.Replace("km", "").Replace(">", "").Replace("<", "");
                                        //t.est_radius = int.Parse(radius);
                                    }
                                    catch (Exception ex)
                                    {
                                        t.est_radius = "0";
                                        Console.WriteLine("Erro parse 9:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.tglTTA = date;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Erro parse 10:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.DibuatOleh = Login2.UserLogin.Username.ToString();
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Erro parse 10:" + ex.Message);
                                    }

                                    //foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(t))
                                    //{
                                    //    string name = descriptor.Name;
                                    //    object value = descriptor.GetValue(t);
                                    //    Console.WriteLine("{0}={1}", name, value);
                                    //}
                                    //tikets.Add(t);
                                    try
                                    {
                                        t.no_kontrak = range[row, 9].Value != null ? range[row, 9].Value.ToString() : "";
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 3:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.NamaPetani = range[row, 10].Value != null ? range[row, 10].Value.ToString() : "";

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 3:" + ex.Message);
                                    }

                                    try
                                    {
                                        t.LokasiDesa = range[row, 11].Value != null ? range[row, 11].Value.ToString() : "";

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 3:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.LokasiKec = range[row, 12].Value != null ? range[row, 12].Value.ToString() : "";

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 3:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.LokasiKab = range[row, 13].Value != null ? range[row, 13].Value.ToString() : "";

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 3:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.NamaKUD = range[row, 14].Value != null ? range[row, 14].Value.ToString() : "";

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 3:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.Alamat = range[row, 15].Value != null ? range[row, 15].Value.ToString() : "";

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 3:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.PenanggungJawab = range[row, 16].Value != null ? range[row, 16].Value.ToString() : "";

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 3:" + ex.Message);
                                    }
                                    try
                                    {
                                        t.rayon  = range[row, 17].Value != null ? range[row, 17].Value.ToString() : "";

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error parse 3:" + ex.Message);
                                    }
                                    try
                                    {
                                        GlobalController.SaveTiket3(t);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Erro save data:" + ex.Message);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error Parse:" + ex.Message);
                                }
                            }
                            Application.DoEvents();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error Parse 2:" + ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Load Excel:" + ex.Message);
                fstream.Dispose();
                ErrorMsg = string.Format("{0}\n{1}\n{2}", ex.Message, ex.InnerException, ex.StackTrace);
                return false;
            }
            fstream.Dispose();
            ErrorMsg = "";
            return false;
        }

    }
    class Temp
    {
        DateTime dt;

        public DateTime Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        int jumlah;

        public int Jumlah
        {
            get { return jumlah; }
            set { jumlah = value; }
        }
        int bln;

        public int Bln
        {
            get { return bln; }
            set { bln = value; }
        }
    }
}
