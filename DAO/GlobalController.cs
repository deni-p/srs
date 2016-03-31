using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRS.DeskApp.Context;
using System.Net;
using System.ComponentModel;
using System.Data.Entity.Validation;
//using System.Data.Entity.Infrastructure;
using System.Data.Entity;


namespace SRS.DeskApp.DAO
{
    public static class GlobalController
    {
        private static SRSEntities context = new Context.SRSEntities();
        private static string _localcompname;
        //private IObjectContextAdapter dbContext;
        

        private static string localcompname
        {
            get
            {
                return Dns.GetHostName(); ;
            }
            set
            {
                _localcompname = value;
            }
        }
        public static tbl_transit_scan_id_timbangan GetStatus_tbl_transit_scan_id_timbangan_bydevice(device_config d)
        {
            try
            {
                using (var db = new SRSEntities())
                {

                    string query = @"
                select * from [tbl_transit_scan_id_timbangan] where
                DATEPART(day,[date_in]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[date_in]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[date_in]) = DATEPART(year,GETDATE()) and status_in2 = '0' and scan_in_ip_address='" + d.device_ip + "'";
                    query = @"
                select * from [tbl_transit_scan_id_timbangan] where status_in2 = '0' and scan_in_ip_address='" + d.device_ip + "'";
                    //query = @"select * from [tbl_transit_scan_id_timbangan] where status_in ='0'";
                    Console.WriteLine(query);
                    var datas = db.Database.SqlQuery<tbl_transit_scan_id_timbangan>(query);
                    return datas.ToList().FirstOrDefault();
                }
                //context = new Context.SRSEntities();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR Query:"+ ex.Message);
                return null;
            }
        }
        public static rendeman get_rendemen(double rendemen)
        {

            var data = context.Database.SqlQuery<rendeman>("select * from rendemen where rendemen='" + rendemen.ToString() + "'");
            if (data != null && data.ToList().Count() > 0)
            {
                Console.WriteLine("Rendemen Found");
                try
                {
                    rendeman t = data.ToList().FirstOrDefault();
                    return t;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Rendemen Not Found");
                return null;
            }
        }
        public static List<user_master_menu> GetMenu()
        {
            try
            {
                var user = context.user_master_menu.ToList();
                if (user != null)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Get User By Name Error:" + ex.Message);
                return null;
            }
        }
        public static bool SaveAccessMenuUser(List<user_access_list> newList,int user_id, out string err)
        {
            
            try
            {
                var existing = context.user_access_list.Where(x => x.user_id == user_id);
                if(existing !=null && existing.ToList().Count()>0){
                    List<user_access_list>old=existing.ToList();
                    context.user_access_list.RemoveRange(newList);
                    context.SaveChanges();
                }
                foreach (user_access_list l in newList)
                {
                    context.user_access_list.Add(l);
                }
                
                context.SaveChanges();
                err = "";
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine("Get User By Name Error:" + ex.Message);
                return false;
            }
        }
        public static User GetUserById(int id)
        {
            try
            {
                var user = context.Users.Where(x => x.ID == id);
                if (user != null && user.Count() > 0)
                    return user.FirstOrDefault();
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Get User By ID Error:" + ex.Message);
                return null;
            }
        }
        public static User GetUserByUserName(string uname)
        {
            try
            {
                var user = context.Users.Where(x => x.Username.ToLower() == uname.ToLower());
                if (user != null)
                {
                    return user.FirstOrDefault();
                }
                else
                {
                    return null;
                }
                //foreach (User u in user)
                //{
                //    Console.WriteLine(u.Username);
                //}
                //if (user != null && user.Count() > 0)
                //    return user.FirstOrDefault();
                //else
                //    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Get User By Name Error:" + ex.Message);
                return null;
            }
        }
        public static Masterlist2  GetPetani2(int IDPetani)
        {
            try
            {
                var roger = context.Masterlist2.Where(x => x.ID.Equals(IDPetani));
                if (roger != null && roger.Count() > 0)
                    return roger.FirstOrDefault();
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Get Petani 2 error ; " + ex.Message);
                return null;
            }
        }

        //public static Tiket GetPetani2(string NamaPetani)
        //{
        //    try
        //    {
        //        var roger = context.Masterlist2.Where(x => x.nama_mitra.Equals(NamaPetani));
        //        if (roger != null && roger.Count() > 0)
        //            return roger.FirstOrDefault();
        //        else
        //            return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Get Petani 2 error ; " + ex.Message);
        //        return null;
        //    }
        //}

        public static Tiket GetTiketByNoTTA(string NoTTA)
        {
            try
            {
                var user = context.Tikets.Where(x => x.NoTiket.Equals(NoTTA));
                if (user != null && user.Count() > 0)
                    return user.FirstOrDefault();
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Get Tiket By NoTTA Error:" + ex.Message);
                return null;
            }
        }

        public static bool ValidasiPendaftaranTiket(string NoTTA, out string msg)
        {
            try
            {
                var user = context.tbl_pendaftaran_mobil.Where(x => x.tta_number.Equals(NoTTA));
                if (user != null && user.Count() > 0)
                {
                    msg = "Tiket " + NoTTA + " sudah ter-register";
                    return true;
                }
                    
                else
                {
                    msg = "";
                    return false;
                }
                    
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                Console.WriteLine("Validasi Error:" + ex.Message);
                return false;
            }
        }

        public static bool SaveUser(User user, out string msg, User userLogin)
        {
            try
            {
                if (userLogin == null)
                {
                    msg = "You dont have authorize to do this process";
                    return false;
                }
                else
                {
                    var exist=GetUserByUserName(user.Username);
                    if ( exist != null && user.ID >0 )
                    {
                        msg = "User Name Already Exist";
                        return false;
                    }
                    else
                    {
                        user.UpdateBy = userLogin.Username;
                        user.UpdateTerminal = localcompname;
                        user.UpdateDate = DateTime.Now;

                        if (user.ID == 0)
                        {
                            // new user
                            user.CreateBy = userLogin.Username;
                            user.CreateTerminal = localcompname;
                            user.CreateDate = DateTime.Now;
                            msg = "User Have been Add";
                            context.Users.Add(user);
                            context.SaveChanges();
                        }
                        else
                        {
                            // update user
                            User u = context.Users.Where(x => x.ID == user.ID).FirstOrDefault();
                            u.Password = user.Password;
                            u.Fullname = user.Fullname;
                            u.Email = user.Email;
                            u.RoleName = user.RoleName;
                            msg = "User Have been Update";
                            context.SaveChanges();
                        }
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static List<User> GetUsers(string filter, int skip, int take)
        {
            var users = context.Users.Where(x =>
                x.Username.Contains(filter) ||
                x.Fullname.Contains(filter) ||
                x.Email.Contains(filter)
                ).OrderBy(x => x.ID).Skip(skip).Take(take);
            if (users.Count() > 0)
                return users.ToList();
            else
                return null;
        }
        public static int GetCountUsers(string filter, int skip, int take)
        {
            var users = context.Users.Where(x =>
                x.Username.Contains(filter) ||
                x.Fullname.Contains(filter) ||
                x.Email.Contains(filter)
                ).OrderBy(x => x.ID).Skip(skip).Take(take).Count();
            return users;
        }
        public static int GetCountUsers(string filter)
        {
            var users = context.Users.Where(x =>
                x.Username.Contains(filter) ||
                x.Fullname.Contains(filter) ||
                x.Email.Contains(filter)).Count();
            return users;
        }

        public static void InsertMasterlist(List<Masterlist2> masters)
        {
            try
            {
                foreach (var master in masters)
                    SaveMasterlist(master);
            }
            catch (Exception ex)
            {
                
            }

        }

        public static List<user_master_form> GetMasterForms()
        {
            var res = context.user_master_form.ToList();
            return res;

        }
        public static List<Masterlist2> LoadAllMasterlist2()
        {
            var res = context.Masterlist2.ToList();
            return res;

        }
        public static List<Tiket> LoadAllTikets()
        {
            var res = context.Tikets.ToList();
            return res;
        }

        public static void InsertMasterlist2(List<Masterlist2> masters)
        {
            try
            {
                SaveMasterlist2(masters);
            }
            catch (Exception ex)
            {

            }

        }
       
        public static void SaveMasterlist2(Masterlist2 master)
        {
            try
            {
                context.Masterlist2.Add(master);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

            }

        }
        public static bool UpdateTiket(int id, string tta)
        {
            var data= context.Database.SqlQuery<Tiket>("select * from Tiket where id='"+ id.ToString() +"'");
            if (data != null && data.ToList().Count()>0)
            {
                Console.WriteLine("Tiket Found To Update...");
                try
                {
                    Tiket t = data.ToList().FirstOrDefault();
                    t.NoTiket = tta;
                    context.SaveChanges();
                    Console.WriteLine("Update Tiket Sukses...");
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Find Record Tiket, ID:" + id + " Not Found");
            }
            return false;
        }
        public static bool SaveChangeAllTiket()
        {
            try
            {  
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static void insertnonregister(Masterlist2 fix)
        {
            try
            {
                if (fix.ID == 0)
                {
                    context.Masterlist2.Add(fix);
                    context.SaveChanges();
                }
                
            }
            catch (Exception ex)
            {

            }
        }
            
        public static void UpdateMasterlist2(Masterlist2 master)
        {
            try
            {
                if (master.ID == 0)
                {
                    // new 
                    context.Masterlist2.Add(master);
                    context.SaveChanges();

                    //return master;
                }
                else
                {
                    var fix = context.Masterlist2.Where(x => x.ID == master.ID).FirstOrDefault();

                    fix.kode_mitra = master.kode_mitra;
                    fix.nama_mitra = master.nama_mitra;
                    fix.ketua_kelompok = master.ketua_kelompok;
                    fix.nama_kelompok = master.nama_kelompok;
                    fix.jenis_mitra = master.jenis_mitra;
                    fix.alamat_ktp = master.alamat_ktp;
                    fix.no_ktp = master.no_ktp;
                    fix.no_hp = master.no_hp;
                    fix.no_kontrak = master.no_kontrak;
                    fix.tgl_kontrak = master.tgl_kontrak;
                    fix.luas = master.luas;//Convert.ToDouble(tbLuas.Text);
                    fix.kategori = master.kategori;//tbKategori.Text;
                    fix.varietas = master.varietas;//tbVarietas.Text;
                    fix.tgl_tanam = master.tgl_tanam; //tbTglTanam.Value;
                    fix.rayon = master.rayon;
                    fix.penanggung_jawab = master.penanggung_jawab;
                    fix.koordinat_x = master.koordinat_x;
                    fix.koordinat_y = master.koordinat_y;
                    fix.kelurahan = master.kelurahan;
                    fix.kecamatan = master.kecamatan;
                    fix.kabupaten = master.kabupaten;
                    fix.no_rek = master.no_rek;
                    fix.an_rek = master.an_rek;
                    fix.bank_rek = master.bank_rek;
                    fix.kud = master.kud;
                    fix.tgl_panen = master.tgl_panen;
                    fix.est_tch = master.est_tch;
                    fix.est_hasil_panen = master.est_hasil_panen;
                    fix.est_radius = master.est_radius;
                    fix.reg_status = false; // 0 = PETANI LAMA ; 1 = PETANI BARU
                    fix.est_ritase = Convert.ToDecimal(master.est_ritase);
                    fix.year_period = Convert.ToInt16(DateTime.Now.Year.ToString());
                    fix.period_trx = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString();
                    context.SaveChanges();
                }
                
            }
            catch (Exception ex)
            {

            }

        }


        public static void SaveMasterlist(Masterlist2 master)
        {
            try
            {
                context.Masterlist2.Add(master);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

            }

        }

     

        public static void SaveMasterlist2(List<Masterlist2> master2)
        {
            try
            {
                context.Masterlist2.AddRange(master2);
                context.SaveChanges();
                
            }
            catch (Exception ex)
            {

            }

        }

        public static List<Masterlist2> GetMasterLists(DateTime From, DateTime To)
        {

            string Fromx = From.ToString("yyy-MM-dd");
            string Tox = To.ToString("yyy-MM-dd");
            //SRSEntities en = new SRSEntities();
            //var y =  en.Masterlists.SqlQuery("select * from MasterList where ContractDate >='" + Fromx + "' and ContractDate <='" + Tox + "'");

            //var users = context.Masterlist2
            //    .Where(x => x.cont >= From && x.ContractDate <= To)
            //    .OrderBy(x => x.ContractDate);
            //if (users.Count() > 0)
            //    return users.ToList();
            //else
                return null;
        }

        public static List<Masterlist2> GetAllMasterList()
        {
            var users = context.Masterlist2.OrderBy(x => x.nama_mitra);
            if (users.Count() > 0)
                return users.ToList();
            else
                return null;
        }

        public static Masterlist2 GetMasterListByID(int ID)
        {
            var ml = context.Masterlist2.Where(x => x.ID == ID);

            return ml.FirstOrDefault();
        }
        public static Masterlist2 GetMasterList2ByID(int ID)
        {
            var ml = context.Masterlist2.Where(x => x.ID == ID);

            return ml.FirstOrDefault();
        }
        public static List<Masterlist2> GetMasterList(string filter, int skip, int take)
        {
            var users = context.Masterlist2.Where(x =>
                x.nama_mitra.Contains(filter) ||
                x.no_kontrak.Contains(filter) ||
                x.alamat_ktp.Contains(filter)
                ).OrderBy(x => x.ID).Skip(skip).Take(take);
            if (users.Count() > 0)
                return users.ToList();
            else
                return null;
        }

        public static List<Masterlist2> GetMasterList2(string filter, int skip, int take)
        {
            var users = context.Masterlist2.Where(x =>
                x.kode_mitra.Contains(filter) ||
                x.nama_mitra.Contains(filter) ||
                x.kabupaten.Contains(filter) ||
                x.kecamatan.Contains(filter) ||
                x.kelurahan.Contains(filter) ||
                x.alamat_ktp.Contains(filter)
                ).OrderBy(x => x.ID).Skip(skip).Take(take);
            if (users.Count() > 0)
                return users.ToList();
            else
                return null;
        }

        public static int GetCountMasterList2(string filter)
        {
            var users = context.Masterlist2.Where(x =>
                x.kode_mitra.Contains(filter) ||
                x.nama_mitra.Contains(filter) ||
                x.kabupaten.Contains(filter) ||
                x.kecamatan.Contains(filter) ||
                x.kelurahan.Contains(filter) ||
                x.alamat_ktp.Contains(filter)).Count();
            return users;
        }
        public static int GetCountTTA(string filter)
        {
            var users = context.Tikets.Where(x =>
                x.NamaPetani.Contains(filter) ||
                x.NoTruck.Contains(filter) ||
                x.NamaKUD.Contains(filter) ||
                x.NamaPetani2.Contains(filter) ||
                x.KodeMitra.Contains(filter) ||
                x.KodeMitra2.Contains(filter)).Count();
            return users;
        }
        public static List<Masterlist2> GetTiket(string filter, int skip, int take)
        {
            var users = context.Masterlist2.Where(x =>
                x.kode_mitra.Contains(filter) ||
                x.nama_mitra.Contains(filter) ||
                x.kabupaten.Contains(filter) ||
                x.kecamatan.Contains(filter) ||
                x.kelurahan.Contains(filter) ||
                x.alamat_ktp.Contains(filter)
                ).OrderBy(x => x.ID).Skip(skip).Take(take);
            if (users.Count() > 0)
                return users.ToList();
            else
                return null;
        }
        public static int GetCountMasterList(string filter)
        {
            var users = context.Masterlist2.Where(x =>
                x.kabupaten.Contains(filter) ||
                x.kecamatan.Contains(filter) ||
                x.kelurahan.Contains(filter) ||
                x.nama_mitra.Contains(filter)).Count();
            return users;
        }


        public static Dictionary<string, int> LoadMasterListByDate(List<Context.Tiket> list)
        {
            Dictionary<string, int> datas = new Dictionary<string, int>();
            var group = list.GroupBy(x => x.tglTTA);

            foreach (var item in group)
            {
                int count = item.ToList().Count;
                string dt = item.Key.ToString();
                datas.Add(dt, count);
            }

            return datas;
        }


        public static Dictionary<string, int> LoadTTAByDate(List<Context.Tiket> list)
        {
            Dictionary<string, int> datas = new Dictionary<string, int>();
            var group = list.GroupBy(x => x.tglTTA);

            foreach (var item in group)
            {
                int count = item.ToList().Count;
                string dt = item.Key.ToString();
                datas.Add(dt, count);
            }

            return datas;
        }


        public static Dictionary<string, int> LoadMasterListByDate()
        {
            Dictionary<string, int> datas = new Dictionary<string, int>();
            var group = context.Masterlist2.GroupBy(x => x.tgl_kontrak);

            foreach (var item in group)
            {
                int count = item.ToList().Count;
                string dt = item.Key.ToString();
                datas.Add(dt, count);
            }

            return datas;
        }

        public static void DeleteTempMasterList()
        {   
            //context.Masterlists.RemoveRange(context.Masterlists.Where(x => x.ID > 0));
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE masterlist2");
            context = new Context.SRSEntities();
            //context.Masterlists.
            //context.Entry( (context.Masterlists).Reload();
        }
        public static void DeleteTapError(int docentry)
        {
            context.tbl_pendaftaran_mobil.RemoveRange(context.tbl_pendaftaran_mobil.Where(x=> x.doc_entry == docentry));
            context.SaveChanges();
        }
        public static void DeleteTiketTemplate()
        {
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE tiket_template");
            context  = new Context.SRSEntities();

        }

        //public static void ReloadEntity<TEntity>(this DbContext context, TEntity entity)
        //where TEntity : class
        //{
        //    context.Entry(entity).Reload();
        //}
        public static void DeleteTiketTA()
        {
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE tiket");
            context = new Context.SRSEntities();

            //context.SaveChanges();
        }

        public static bool UpdateTTA()
        {
            try
            {
                context.Database.ExecuteSqlCommand("UPDATE Tiket SET NoTiket = tiket_template.NoTiket, id_status = 0 FROM Tiket INNER JOIN tiket_template ON Tiket.ID = tiket_template.ID");
                context = new Context.SRSEntities();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Update Tiket TA" + ex.Message);
                return false;
            }
        }
        public static Tiket GetTiketByID(int ID)
        {
            var ml = context.Tikets.Where(x => x.ID == ID);

            return ml.FirstOrDefault();
        }

        public static bool SaveTiket(List<Tiket> tikets, User UserLogin)
        {
            try
            {
                foreach (var tiket in tikets)
                {
                    tiket.CreateBy = UserLogin.Username;
                    tiket.CreateTerminal = localcompname;
                    tiket.CreateDate = DateTime.Now;
                    tiket.UpdateBy = UserLogin.Username;
                    tiket.UpdateTerminal = localcompname;
                    tiket.UpdateDate = DateTime.Now;
                }
                    context.Tikets.AddRange(tikets);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static string SavePendaftaranMobil2(Tiket tiket, Context.User user, bool gandengan)
        {
            try
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(tiket))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(tiket);
                    Console.WriteLine("{0}={1}", name, value);
                }

                //return;
                tbl_pendaftaran_mobil tbl = new tbl_pendaftaran_mobil();
                //tbl.doc_entry = 10;
                tbl.car_type = gandengan;
                tbl.doc_date = DateTime.Now;
                //tbl.nama_petani = tiket.NamaPetani;
                tbl.card_name = tiket.NamaPetani2;
                tbl.card_code = tiket.KodeMitra2;
                //tbl.card_code_reg = tiket.KodeMitra;
                //tbl.card_name_reg = tiket.NamaPetani;
                tbl.tta_number = tiket.NoTiket;
                tbl.tta_date = tiket.tglTTA;
                tbl.car_id = tiket.NoTruck;
                tbl.driver = tiket.Driver;
                tbl.create_date = DateTime.Now;
                tbl.update_date = DateTime.Now;
                tbl.user_sign = user.ID;
                tbl.ip_address = "192.168.1.100";
                tbl.num_at_card = "00001";
                tbl.status = 0;

                context.tbl_pendaftaran_mobil.Add(tbl);
                context.SaveChanges();

                //string sql = "INSERT INTO tbl_pendaftaran_mobil";

                return "";
            }
            catch (DbEntityValidationException ex)
            {
                //System.Data.Entity.Validation.DbEntityValidationException
                foreach (var failure in ex.EntityValidationErrors)
                {
                    string validationErrors = "";

                    foreach (var error in failure.ValidationErrors)
                    {
                        validationErrors += error.PropertyName + "  " + error.ErrorMessage + Environment.NewLine;
                    }
                    Console.WriteLine(validationErrors);
                }
                Console.WriteLine("Error Save Pendaftaran Mobil" + ex.Message);
                return "Error Save Pendaftaran Mobil" + ex.Message;
            }

        }
        public static string SavePendaftaranMobil(Tiket tiket, Context.User user, bool gandengan)
        {
            try
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(tiket))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(tiket);
                    Console.WriteLine("{0}={1}", name, value);
                }
                
                //return;
                tbl_pendaftaran_mobil tbl = new tbl_pendaftaran_mobil();
                //tbl.doc_entry = 10;
                tbl.car_type = gandengan;
                tbl.doc_date = DateTime.Now;
                //tbl.nama_petani = tiket.NamaPetani;
                tbl.card_name=tiket.NamaPetani2;
                tbl.card_code = tiket.KodeMitra2;
                tbl.card_code_reg = tiket.KodeMitra;
                tbl.card_name_reg = tiket.NamaPetani;
                tbl.tta_number = tiket.NoTiket;
                tbl.tta_date = tiket.tglTTA;
                tbl.car_id = tiket.NoTruck;
                tbl.driver = tiket.Driver;
                tbl.create_date = DateTime.Now;
                tbl.update_date  = DateTime.Now;
                tbl.user_sign = user.ID;
                tbl.ip_address = "192.168.1.100";
                tbl.num_at_card = "00001";
                tbl.status = 0;

                context.tbl_pendaftaran_mobil.Add(tbl);
                context.SaveChanges();

                //string sql = "INSERT INTO tbl_pendaftaran_mobil";

                return "";
            }
            catch (DbEntityValidationException ex)
            {
                //System.Data.Entity.Validation.DbEntityValidationException
                foreach (var failure in ex.EntityValidationErrors)
                {
                    string validationErrors = "";

                    foreach (var error in failure.ValidationErrors)
                    {
                        validationErrors += error.PropertyName + "  " + error.ErrorMessage+Environment.NewLine;
                    }
                    Console.WriteLine(validationErrors);
                }
                Console.WriteLine("Error Save Pendaftaran Mobil"+ ex.Message);
                return "Error Save Pendaftaran Mobil" + ex.Message;
            }
            
        }
        public static tbl_pendaftaran_mobil GetPendaftaranMobil(Tiket t, out string errMsg ){
            try
            {
              
                //context = new Context.SRSEntities();
                string query = @"
                select * from [tbl_pendaftaran_mobil] where
                DATEPART(day,[create_date]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[create_date]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[create_date]) = DATEPART(year,GETDATE()) and 
                status=0 AND tta_number='"+ t.NoTiket +"'";
                //return context.tbl_pendaftaran_mobil.First(x => x.create_date.Value == t.create_date.Value && x.tta_number == t.NoTiket);
                errMsg = "";
                List<tbl_pendaftaran_mobil> list = context.Database.SqlQuery<tbl_pendaftaran_mobil>(query).OrderByDescending(x => x.create_date).ToList();
                return list.FirstOrDefault();
                
            }
            catch (DbEntityValidationException ex)
            {
                string validationErrors = "";
                //System.Data.Entity.Validation.DbEntityValidationException
                foreach (var failure in ex.EntityValidationErrors)
                {
                    

                    foreach (var error in failure.ValidationErrors)
                    {
                        validationErrors += error.PropertyName + "  " + error.ErrorMessage + Environment.NewLine;
                    }
                    Console.WriteLine(validationErrors);
                }
              //  Console.WriteLine("Error Save Pendaftaran Mobil" + ex.Message);
                errMsg= "Error Save Pendaftaran Mobil" + validationErrors;
                return null;
            }
        }
        public static tbl_pendaftaran_mobil GetPendaftaranByLastTTA(string tta)
        {
            try
            {
                string query = @"
                select * from [tbl_pendaftaran_mobil] where
                DATEPART(day,[create_date]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[create_date]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[create_date]) = DATEPART(year,GETDATE()) AND tta_number='" + tta  + "' ORDER by create_date DESC";
                var list= context.Database.SqlQuery<tbl_pendaftaran_mobil>(query);
                if (list != null)
                {
                    return list.ToList().First();
                }
                else
                {
                    return null;
                }
                //return context.tbl_pendaftaran_mobil.First(x => x.create_date.Value == t.create_date.Value && x.tta_number == t.NoTiket);
            }
            catch (Exception ex)
            {
                //return null;
                Console.WriteLine("Error Get Pendaftaran Mobil:" + ex.Message);
                return null;
            }
        }
        public static tbl_pendaftaran_mobil GetStatusTulisKartu(int doc_entry)
        {
            try
            {
                //context = new Context.SRSEntities();
                string query = @"
                select * from [tbl_pendaftaran_mobil] where
                DATEPART(day,[create_date]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[create_date]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[create_date]) = DATEPART(year,GETDATE()) and doc_entry='"+ doc_entry.ToString() +"'";
                return context.Database.SqlQuery<tbl_pendaftaran_mobil>(query).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Get Pendaftaran Mobil:" + ex.Message);
                return null;
            }
        }
        //2015-06-13 06:52:50.553
        public static bool UpdateStatusTulisKartu(int doc_entry)
        {
            try
            {
                //context = new Context.SRSEntities();
                string query = @"
                UPDATE tbl_pendaftaran_mobil set status='2' WHERE doc_entry='"+ doc_entry.ToString() +"'";
                //return context.Database.SqlQuery(query);
                tbl_pendaftaran_mobil t = context.tbl_pendaftaran_mobil.First(x => x.doc_entry == doc_entry);
                if (t != null)
                {
                    t.status = 2;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Get Pendaftaran Mobil:" + ex.Message);
                return false;
            }
        }
        public static Tiket SaveTiket(Tiket tiket, User UserLogin)
        {
            try
            {

                if (tiket.ID == 0)
                {
                    // new 
                    tiket.CreateBy = UserLogin.Username;
                    tiket.CreateTerminal = localcompname;
                    tiket.CreateDate = DateTime.Now;
                    tiket.UpdateBy = UserLogin.Username;
                    tiket.UpdateTerminal = localcompname;
                    tiket.UpdateDate = DateTime.Now;
                    context.Tikets.Add(tiket);
                    context.SaveChanges();

                    return tiket;
                }
                else
                {
                    // update 
                    Tiket u = context.Tikets.Where(x => x.ID == tiket.ID).FirstOrDefault();
                    u.Alamat = tiket.Alamat;
                    u.Alamat2 = tiket.Alamat2;
                    u.DibuatOleh = tiket.DibuatOleh;
                    u.DiserahkanOlehJabatan = tiket.DiserahkanOlehJabatan;
                    u.Driver = tiket.Driver;
                    u.KodeRegister = tiket.KodeRegister; //Petani
                    u.KodeRegister2 = tiket.KodeRegister2; //Mitra
                    u.LokasiDesa = tiket.LokasiDesa;
                    u.LokasiKab = tiket.LokasiKab;
                    u.LokasiKec = tiket.LokasiKec;
                    u.LuasLahan = tiket.LuasLahan;
                    u.NamaKUD = tiket.NamaKUD;
                    u.NamaPetani = tiket.NamaPetani;
                    u.NamaPetani2 = tiket.NamaPetani2;
                    u.NoTiket = tiket.NoTiket;
                    u.NoTruck = tiket.NoTruck;
                    u.KodeMitra = tiket.KodeMitra;
                    u.PenanggungJawab = tiket.PenanggungJawab;
                    u.PenanggungJawabJabatan = tiket.PenanggungJawabJabatan;
                    u.VarietasTebu = tiket.VarietasTebu;

                    u.tglKontrak = tiket.tglKontrak;
                    u.tglTTA = tiket.tglTTA;

                    u.kategori = tiket.kategori;
                    u.est_tch = tiket.est_tch;
                    u.est_ritase = tiket.est_ritase;
                    u.est_hasil_panen = tiket.est_hasil_panen;
                    u.est_radius = tiket.est_radius;
                    u.rayon = tiket.rayon;
                    u.no_kontrak = tiket.no_kontrak;
                    u.tgl_panen = tiket.tgl_panen;

                    u.UpdateBy = UserLogin.Username;
                    u.UpdateTerminal = localcompname;
                    u.UpdateDate = DateTime.Now;

                    context.SaveChanges();

                    return tiket;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Tiket SaveRegNewTiket(Tiket tiket, User UserLogin)
        {
            try
            {

                    // new 
                    tiket.CreateBy = UserLogin.Username;
                    tiket.CreateTerminal = localcompname;
                    tiket.CreateDate = DateTime.Now;
                    tiket.UpdateBy = UserLogin.Username;
                    tiket.UpdateTerminal = localcompname;
                    tiket.UpdateDate = DateTime.Now;
                    context.Tikets.Add(tiket);
                    context.SaveChanges();

                    return tiket;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static bool SaveTiket2(List<Tiket> tikets)
        {
            try
            {
                context.Tikets.AddRange(tikets);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public static bool SaveGenerateTiketNo(tiket_template tiket)
        {
            try
            {
                context.tiket_template.Add(tiket);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool SaveTiket3(Tiket tiket)
        {
            try
            {
                context.Tikets.Add(tiket);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static List<Tiket> GetAllTikets()
        {
            var users = context.Tikets.OrderBy(x => x.ID);
            if (users.Count() > 0)
                return users.ToList();
            else
                return null;
        }

        public static List<Tiket> GetTglTikets(DateTime From, DateTime To)
        {

            //string Fromx = From.ToString("yyy-MM-dd");
            //string Tox = To.ToString("yyy-MM-dd");
            //SRSEntities en = new SRSEntities();
            //var y = en.Tikets.SqlQuery ("select * from Tiket where ContractDate >='" + Fromx + "' and ContractDate <='" + Tox + "'");

            var users = context.Tikets
                .Where(x => x.tglTTA >= From && x.tglTTA <= To)
                .OrderBy(x => x.tglTTA);

            if (users.Count() > 0)
                return users.ToList();
            else
            return null;
        }

        public static List<Tiket> GetTikets(string filter, int skip, int take)
        {
            //var datas = context.Tikets.Where(x =>
            //    x.NamaPetani.Contains(filter) ||
            //    x.NamaPetani2.Contains(filter) ||
            //    x.NoTruck.Contains(filter) ||
            //    x.NoTiket.Contains(filter)
            //    ).OrderBy(x => x.ID).Take(take);

            //context.Database.ExecuteSqlCommand("SELECT TOP(" + take + ") * FROM Tiket ORDER BY ID");
            //string query = @"SELECT TOP(" + take + ") * FROM Tiket ORDER BY ID";
            string query = @"SELECT * FROM Tiket ORDER BY ID";
            var datas = context.Database.SqlQuery<Tiket>(query).Skip(skip).Take(take);

            //var datas = context.Tikets.Where(x =>
            //    x.NamaPetani.Contains(filter) ||
            //    x.NamaPetani2.Contains(filter) ||
            //    x.NoTruck.Contains(filter) ||
            //    x.NoTiket.Contains(filter)
            //    ).OrderBy(x => x.ID).Skip(skip).Take(take);
            
            //Skip(skip).

            //var datas = context.Tikets.Where(x =>
            //    x.NamaPetani.Contains(filter) ||
            //    x.NamaPetani2.Contains(filter) ||
            //    x.NoTruck.Contains(filter) ||
            //    x.NoTiket.Contains(filter)
            //    ).OrderBy(x => x.rayon).Take(take)
            //    .OrderBy(x => x.ID);

            if (datas.Count() > 0)
                return datas.ToList();
            else
                return null;
        }

        public static bool GetDoubleTiket()
        {
            try
            {
                string query = @"SELECT Tiket.NoTiket FROM  Tiket INNER JOIN  tiket_template ON Tiket.NoTiket = tiket_template.NoTiket";
                var looklist = context.Database.SqlQuery<string>(query);

                if (looklist.Count() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public static List<Tiket> PrintTikets(int nfrom, int nto, int take)
        {
            //string query = @"SELECT TOP(" + take + ") * FROM Tiket ORDER BY ID";
            string query = @"SELECT * FROM Tiket WHERE ID >= " + nfrom + " AND ID <= " + nto  + " ORDER BY ID";
            var datas = context.Database.SqlQuery<Tiket>(query);
            //var datas = context.Database.SqlQuery<Tiket>(query).Where(x => x.ID >= nfrom || x.ID <= nto).Take(take);

            if (datas.Count() > 0)
                return datas.ToList();
            else
                return null;
        }
        public static List<Masterlist2> RefershPetani(int take)
        {
            //            string query = @"
            //                SELECT TOP(" + take + ") * FROM Tiket ORDER BY ID";
            //string query = @"SELECT TOP(" + take + ") ID, NamaKUD, NoTiket, NamaPetani, Alamat, LuasLahan, VarietasTebu, LokasiDesa, LokasiKec, LokasiKab, KodeMitra, tglTTA, est_tch, est_ritase, est_hasil_panen, est_radius, est_luas_panen, rayon, id_status FROM Tiket ORDER BY ID";
            string query = @"SELECT TOP(" + take + ") * FROM MASTERLIST2 ORDER BY kabupaten, kode_mitra";

            try
            {
                var datas = context.Database.SqlQuery<Masterlist2>(query);
                if (datas != null)
                {
                    if (datas.ToList().Count > 0)
                    {
                        return datas.ToList();
                    }
                    else
                    {
                        return null;
                    }
                }
            }catch {
                
            }
            return null;

        }
        public static List<Tiket> RefershTiket(int take)
        {
//            string query = @"
//                SELECT TOP(" + take + ") * FROM Tiket ORDER BY ID";
            //string query = @"SELECT TOP(" + take + ") ID, NamaKUD, NoTiket, NamaPetani, Alamat, LuasLahan, VarietasTebu, LokasiDesa, LokasiKec, LokasiKab, KodeMitra, tglTTA, est_tch, est_ritase, est_hasil_panen, est_radius, est_luas_panen, rayon, id_status FROM Tiket ORDER BY ID";
            string query = @"SELECT TOP(" + take + ") * FROM Tiket ORDER BY ID";
            var datas = context.Database.SqlQuery<Tiket>(query);
            if (datas != null && datas.ToList().Count > 0)
            {
                return datas.ToList();
            }
            else
            {
                return null;
            }

        }
        public static List<Tiket> SearchTiketKontrak(string filter, int skip, int take)
        {
            var users = context.Tikets.Where(x =>
                x.no_kontrak.Contains(filter)
                ).OrderBy(x => x.ID).Skip(skip).Take(take);

            if (users.Count() > 0)
                return users.ToList();
            else
                return null;
        }
        public static List<Tiket> SearchTiketRayon(string filter, int skip, int take)
        {
            var users = context.Tikets.Where(x =>
                x.rayon.Contains(filter)
                ).OrderBy(x => x.ID).Skip(skip).Take(take);

            if (users.Count() > 0)
                return users.ToList();
            else
                return null;
        }
        public static List<Tiket> SearchTiketPetani(string filter, int skip, int take)
        {
            var users = context.Tikets.Where(x =>
                x.NamaPetani.Contains(filter)
                ).OrderBy(x => x.ID);

            if (users.Count() > 0)
                return users.ToList();
            else
                return null;
        }
        public static List<Masterlist2> SearchMasterPetani(string filter, int skip, int take)
        {
            var users = context.Masterlist2.Where(x =>
                x.kode_mitra.Contains(filter) & x.jenis_mitra == "KPPE"
                ).OrderBy(x => x.ID).Take(take);

            //var users = context.Tikets.Where(x =>
            //    x.NamaPetani.Contains(filter)
            //    ).OrderBy(x => x.ID);

            if (users.Count() > 0)
                return users.ToList();
            else
                return null;
        }
        public static List<Masterlist2> SearchDataPetani(string filter, int skip, int take)
        {
            var users = context.Masterlist2.Where(x =>
                x.kode_mitra.Contains(filter) & x.jenis_mitra == "KPPE"
                ).OrderBy(x => x.ID).Distinct().Take(take);

            if (users.Count() > 0)
                return users.ToList();
            else
                return null;
        }
       
        public static List<Masterlist2> SearchDataPetaniNonKKPE(string filter, int skip, int take)
        {
            var users = context.Masterlist2.Where(x =>
                x.kode_mitra.Contains(filter) & x.jenis_mitra != "KPPE"
                ).OrderBy(x => x.ID).Distinct().Take(take);

            

            //var showPtn = (from tcs in ptn.tbl_transit_core_sampling
            //               join tpm in ptn.tbl_pendaftaran_mobil on tcs.base_entry equals tpm.doc_entry
            //               join ml2 in ptn.Masterlist2 on tpm.card_code_reg equals ml2.kode_mitra
            //               join tt in ptn.tbl_transit_timbangan on tpm.doc_entry equals tt.base_entry
            //               where ml2.jenis_mitra != filter
            //               select new
            //               {
            //                   PETANI = tpm.card_code_reg,
            //                   NAMA = tpm.card_name,
            //                   ALAMAT = ml2.alamat_ktp,
            //                   BERAT_TEBU = tt.gross_weight,
            //                   HARGA = tcs.pembayaran
            //               }).Distinct().ToList();

            if (users.Count() > 0)
                return users.ToList();
            else
                return null;
        }
        

        public static int GetCountTiketFilter(string filter)
        {
            var tikets = context.Tikets.Where(x =>
                 x.NamaPetani.Contains(filter) ||
                x.rayon.Contains(filter) ||
                x.no_kontrak.Contains(filter)).Count();
            return tikets;
        }
        public static int GetCountTiket(string filter)
        {
            var tikets = context.Tikets.Where(x =>
                 x.NamaPetani.Contains(filter) ||
                x.NamaPetani2.Contains(filter) ||
                x.NoTruck.Contains(filter) ||
                x.NoTiket.Contains(filter)).Count();
            return tikets;
        }

        public static List<tbl_transit_scan_id_device> GetTransitScanIDDevice()
        {
            try
            {
                //context = new Context.SRSEntities();
                string query = @"
                select * from [tbl_transit_scan_id_device] where
                DATEPART(day,[date_in]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[date_in]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[date_in]) = DATEPART(year,GETDATE()) and 
                status ='0' and device_type='R'";
                var datas = context.Database.SqlQuery<tbl_transit_scan_id_device>(query);
                if (datas != null && datas.ToList().Count > 0)
                {
                    return datas.ToList();
                }
                else
                {
                    return null;
                }
                
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public static List<tbl_transit_scan_id_device> GetTransitScanIDDeviceUnloading()
        {
            try
            {
                //context = new Context.SRSEntities();
                string query = @"
                select * from [tbl_transit_scan_id_device] where
                DATEPART(day,[date_in]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[date_in]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[date_in]) = DATEPART(year,GETDATE()) and 
                status ='0' and device_type='R'";
                var datas = context.Database.SqlQuery<tbl_transit_scan_id_device>(query);
                if (datas != null && datas.ToList().Count > 0)
                {
                    return datas.ToList();
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
       
        public static bool UpdatePotonganUnloading(string potongan, string base_entry)
        {
            try
            {
                //context = new Context.SRSEntities();
                string query = @"
                UPDATE tbl_transit_timbangan SET potongan='" + potongan + "' WHERE base_entry='" + base_entry  + "'";
                int res=context.Database.ExecuteSqlCommand(query);               
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static tbl_transit_timbangan SaveTimbanganManual(tbl_transit_timbangan sd)
        {
            try
            {
                //context.tbl_transit_timbangan.Add(sd);
                //context.SaveChanges();
                return sd;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public static bool Update_tbl_transit_scan_id_timbangan(int doc_entry, int status)
        {
            try
            {
                //string query = @"update tbl_transit_scan_id_timbangan set status_id='1' where doc_entry='" + doc_entry.ToString() + "'";
                var t = context.tbl_transit_scan_id_timbangan.Where(x => x.base_entry == doc_entry).FirstOrDefault();
                if (t != null)
                {
                    t.status_in2 = status;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                //context.Database.ExecuteSqlCommand(query);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool Update_tbl_transit_timbangan(int doc_entry, int status)
        {
            try
            {
                //string query = @"update tbl_transit_scan_id_timbangan set status_id='1' where doc_entry='" + doc_entry.ToString() + "'";
                var t = context.tbl_transit_timbangan.Where(x => x.base_entry == doc_entry).FirstOrDefault();
                if (t != null)
                {
                    t.status_in2 = status;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                //context.Database.ExecuteSqlCommand(query);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static List<tbl_transit_scan_id_timbangan> GetStatus_tbl_transit_scan_id_timbangan()
        {
            try
            {
                //context = new Context.SRSEntities();
                string query = @"
                select * from [tbl_transit_scan_id_timbangan] where
                DATEPART(day,[date_in]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[date_in]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[date_in]) = DATEPART(year,GETDATE()) and status_in2 ='0'";

                //query = @"select * from [tbl_transit_scan_id_timbangan] where status_in ='0'";
                var datas = context.Database.SqlQuery<tbl_transit_scan_id_timbangan>(query);
                return datas.ToList();
                //var showdata = datas.ToList();
                //var group = datas.GroupBy(x => x.doc_entry);

                //List<tbl_transit_scan_id_timbangan> res = new List<tbl_transit_scan_id_timbangan>();

                //foreach (var g in group)
                //{
                //    var ggg = g.ToList().OrderByDescending(x => x.date_in);
                //    var lastData = ggg.FirstOrDefault();
                //    res.Add(lastData);
                //}

                //return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static List<tbl_transit_scan_id_timbangan> GetTransitScanIDTimbanganOut()
        {
            try
            {
                //context = new Context.SRSEntities();
                string query = @"
                select * from [tbl_transit_scan_id_timbangan] where
                DATEPART(day,[date_in]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[date_in]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[date_in]) = DATEPART(year,GETDATE()) and 
                status_out ='1'";
                var datas = context.Database.SqlQuery<tbl_transit_scan_id_timbangan>(query);
                if (datas != null && datas.ToList().Count > 0)
                {
                    return datas.ToList();
                }
                else
                {
                    return null;
                }            
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Dictionary<int,tbl_transit_timbangan> GetStatusTransitTimbangan2()
        {
            try
            {
                //context = new Context.SRSEntities();
                string query = @"
                select * from [tbl_transit_timbangan] where
                DATEPART(day,[date_in]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[date_in]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[date_in]) = DATEPART(year,GETDATE()) and 
                status_out ='1'";
                var datas = context.Database.SqlQuery<tbl_transit_timbangan>(query);
                return datas.ToDictionary(x=>x.base_entry, x=> x);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static List<device_config> GetDeviceConfigByLocation(string location)
        {
            try
            {
                var res = context.device_config.Where(x => x.location == location).ToList();
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static device_config GetDeviceConfigByLocationAndIndex(string location, int index)
        {
            try
            {
                var res = context.device_config.Where(x => x.location == location && x.id == index);
                if (res != null && res.ToList().Count() > 0)
                {
                   return res.ToList().FirstOrDefault();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static List<tbl_transit_timbangan> GetStatusTransitTimbangan()
        {
            try
            {
                string query = @"
                select * from [tbl_transit_timbangan] where
                DATEPART(day,[date_in]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[date_in]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[date_in]) = DATEPART(year,GETDATE()) and 
                status_in=0";
                var datas = context.Database.SqlQuery<tbl_transit_timbangan>(query);
                
                return datas.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static tbl_transit_scan_id_timbangan GetStatus_mugi_update_on_tbl_transit_scan_id_timbangan(int base_entry)
        {
            try
            {
                using (var db = new SRSEntities())
                {
                    string query = @"
                select * from [tbl_transit_scan_id_timbangan] where
                DATEPART(day,[date_in]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[date_in]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[date_in]) = DATEPART(year,GETDATE()) and base_entry='" + base_entry + "'";
                    var datas = db.Database.SqlQuery<tbl_transit_scan_id_timbangan>(query);
                    if (datas != null && datas.ToList().Count > 0)
                    {
                        return datas.ToList().First();
                    }
                    else
                    {
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static tbl_transit_timbangan GetStatus_tbl_transit_timbangan(int base_entry)
        {
            try
            {
                using (var db = new SRSEntities())
                {
                    string query = @"
                select * from [tbl_transit_timbangan] where
                DATEPART(day,[date_in]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[date_in]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[date_in]) = DATEPART(year,GETDATE()) and base_entry='" + base_entry + "'";
                    var datas = db.Database.SqlQuery<tbl_transit_timbangan>(query);
                    if (datas != null && datas.ToList().Count > 0)
                    {
                        return datas.ToList().First();
                    }
                    else
                    {
                        return null;
                    }
                }
               
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static List<tbl_transit_timbangan> GetTimbanganDataInProgressTimer()
        {
            return null;
//            try
//            {

//                //context = new Context.SRSEntities();

//                string query = @"
//                select * from [tbl_transit_timbangan] where
//                DATEPART(day,[TanggalProses]) = DATEPART(day,GETDATE()) and 
//DATEPART(month,[TanggalProses]) = DATEPART(month,GETDATE()) and 
//DATEPART(year,[TanggalProses]) = DATEPART(year,GETDATE()) and 
// status in ('W','T','ST','SW','S')
//
//";
//                var datas = context.Database.SqlQuery<shared_timbangan_in>(query);

//                ////var datas = context.shared_timbangan_in.Where(x => 
//                ////    //x.NoTimbangan == LineID
//                ////    ( x.TanggalProses.Year == DateTime.Now.Year 
//                ////    &&  x.TanggalProses.Month == DateTime.Now.Month
//                ////    && x.TanggalProses.Day == DateTime.Now.Day )
//                ////    && (x.Status.Equals("W")
//                ////    || x.Status.Equals("T")
//                ////    || x.Status.Equals("ST")
//                ////    || x.Status.Equals("SW")
//                ////    || x.Status.Equals("M"))
//                ////    );

//                var showdata = datas.ToList();
//                var group = datas.GroupBy(x => x.NoTimbangan);

//                List<shared_timbangan_in> res = new List<shared_timbangan_in>();

//                foreach (var g in group)
//                {
//                    var ggg = g.ToList().OrderByDescending(x => x.TanggalProses);


//                    var lastData = ggg.FirstOrDefault();
//                  //  if (!lastData.Status.Equals("S"))
//                        res.Add(lastData);
//                }

//                return res;
//            }
//            catch (Exception ex)
//            {
//                return null;
//            }
        }

        public static List<shared_timbangan_in> GetTimbanganDataInProgress()
        {
            try
            {

                //context = new Context.SRSEntities();

                string query = @"
                select * from [shared_timbangan_in] where
                DATEPART(day,[TanggalProses]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[TanggalProses]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[TanggalProses]) = DATEPART(year,GETDATE()) and 
                 status in ('W','T','ST','SW')

";
                var datas = context.Database.SqlQuery<shared_timbangan_in>(query);

                ////var datas = context.shared_timbangan_in.Where(x => 
                ////    //x.NoTimbangan == LineID
                ////    ( x.TanggalProses.Year == DateTime.Now.Year 
                ////    &&  x.TanggalProses.Month == DateTime.Now.Month
                ////    && x.TanggalProses.Day == DateTime.Now.Day )
                ////    && (x.Status.Equals("W")
                ////    || x.Status.Equals("T")
                ////    || x.Status.Equals("ST")
                ////    || x.Status.Equals("SW")
                ////    || x.Status.Equals("M"))
                ////    );
                var group = datas.GroupBy(x => x.NoTimbangan);

                List<shared_timbangan_in> res = new List<shared_timbangan_in>();

                foreach (var g in group)
                {
                    var lastData = g.ToList().OrderByDescending(x => x.TanggalProses).FirstOrDefault();
                    if (!lastData.Status.Equals("S"))
                        res.Add(lastData);
                }

                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static tbl_transit_scan_id_timbangan GetLastTimbanganByPlatAndTTA(string Plat, string scan_in_ip_address)
        {


            string query = @"select * from [tbl_transit_timbangan] where
                DATEPART(day,[TanggalProses]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[TanggalProses]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[TanggalProses]) = DATEPART(year,GETDATE()) and [status_in] ='1' and
                car_id ='" + Plat + "' and scan_in_ip_address = " + scan_in_ip_address;
            var datas = context.Database.SqlQuery<tbl_transit_scan_id_timbangan>(query);

            return datas.FirstOrDefault();
        }

        public static List<shared_timbangan_in> GetTimbanganDataWaitForSuccess()
        {
            try
            {

                //context = new Context.SRSEntities();

                string query = @"select * from [shared_timbangan_in] where
                DATEPART(day,[TanggalProses]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[TanggalProses]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[TanggalProses]) = DATEPART(year,GETDATE()) and 
                 status in ('SW','S') 

";
                var datas = context.Database.SqlQuery<shared_timbangan_in>(query);
                var group = datas.GroupBy(x => x.NoTimbangan);

                List<shared_timbangan_in> res = new List<shared_timbangan_in>();

                foreach (var g in group)
                {

                    var groupplat = g.ToList().GroupBy(x => x.PlatNo);

                    foreach (var gpl in groupplat.ToList())
                    {
                        if (gpl.ToList().Where(x => x.Status.Equals("S")).Count() <= 0
                            && gpl.ToList().Where(x => x.Status.Equals("SW")).Count() > 0
                            )
                        {
                            // belum di triger STATUS S oleh user
                            var single = gpl.OrderByDescending(x => x.TanggalProses).FirstOrDefault();
                            res.Add(single);
                        }
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

//        public static List<Transaksi> CheckStatusUpdateCoreSampling(string NoTTA)
//        {
//            try
//            {
//                string query = @"select * from Transaksi where
//                DATEPART(day,[TglTimbanganIn]) = DATEPART(day,GETDATE()) and 
//DATEPART(month,[TglTimbanganIn]) = DATEPART(month,GETDATE()) and 
//DATEPART(year,[TglTimbanganIn]) = DATEPART(year,GETDATE())  and 
//		LineTimbanganIn is not null and 
//		NoTTA = '" +NoTTA+  "' ";
//                var datas = context.Database.SqlQuery<Transaksi>(query);

//                return datas.ToList().OrderByDescending(x=>x.TglTimbanganIn).ToList();
//            }
//            catch (Exception ex)
//            {
//                return null;
//            }
//        }


        public static tbl_pendaftaran_mobil CekStatusReadWriteKartu(string NoTTA)
        {
            try
            {
                string query = @"select * from tbl_pendaftaran_mobil where
                DATEPART(day,[doc_date]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[doc_date]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[doc_date]) = DATEPART(year,GETDATE())  and tta_number = '" + NoTTA + "' ORDER BY doc_date DESC";
                var datas = context.Database.SqlQuery<tbl_pendaftaran_mobil>(query);

                return datas.FirstOrDefault();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static List<Tiket> LoadFieldTiket()
        {
            try
            {
                //string query = @"SELECT UPPER(COLUMN_NAME) AS FieldName FROM field_object WHERE (TABLE_NAME = 'Tiket') ORDER BY UPPER(COLUMN_NAME)";
                string query = @"SELECT ORDINAL_POSITION, COLUMN_NAME FROM tiket_field_object";// WHERE (TABLE_NAME = 'Tiket') ORDER BY UPPER(COLUMN_NAME)";
                //string query = @"SELECTINFORMATION_SCHEMA.COLUMNS.COLUMN_NAME, INFORMATION_SCHEMA.COLUMNS.ORDINAL_POSITION
                    //FROM INFORMATION_SCHEMA.COLUMNS INNER JOIN INFORMATION_SCHEMA.TABLES ON INFORMATION_SCHEMA.COLUMNS.TABLE_NAME = INFORMATION_SCHEMA.TABLES.TABLE_NAME
                    //WHERE (INFORMATION_SCHEMA.COLUMNS.TABLE_NAME = N'Tiket')
                    //ORDER BY INFORMATION_SCHEMA.COLUMNS.TABLE_NAME";
                var datas = context.Database.SqlQuery<Tiket>(query);

                return datas.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static List<Tiket> loadTTA()
        {
            try
            {
                string query = @"select * from tiket order by tglTTA";
                var datas = context.Database.SqlQuery<Tiket>(query);
                return datas.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //public static bool SaveTimbanganInTransaksi(Transaksi tr)
        //{
        //    try
        //    {
        //        context.Transaksis.Add(tr);
        //        context.SaveChanges();
        //        return  true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return  false;

        //    }

        //}

        public static shared_timbangan_in GetSharedByID(int ID)
        {
            var ml = context.shared_timbangan_in.Where(x => x.ID == ID);

            return ml.FirstOrDefault();

        }


        public static Dictionary<string, int> LoadMasterListByDate(List<Context.Masterlist2> list)
        {
            Dictionary<string, int> datas = new Dictionary<string, int>();
            var group = list.GroupBy(x => x.tgl_kontrak);

            foreach (var item in group)
            {
                int count = item.ToList().Count * 6;
                string dt = item.Key.ToString();
                datas.Add(dt, count);
            }

            return datas;
        }


        public static tbl_transit_core_sampling SaveCoreSamplingManual(tbl_transit_core_sampling tr)
        {
            try
            {
                var t = context.tbl_transit_core_sampling.Where(x => x.base_entry == tr.base_entry).FirstOrDefault();
                if (t != null)
                {
                    t.status = 1;
                    t.create_date= DateTime.Now;
                    //t.time = DateTime.Now.ToString("HH:mm:dd");
                    t.potongan = tr.potongan;
                    t.brix_manual = tr.brix_manual;
                    t.pol_manual = tr.pol_manual;
                    t.pol_nir = tr.pol_nir;
                    t.brix_nir = tr.brix_nir;
                    context.SaveChanges();
                }
                return tr;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Save Core Sampling Manual Error");
                return null;

            }

        }

        public static tbl_transit_core_sampling GetCoreSamplingByBaseEntry(int base_entry)
        {
            try
            {
                var ml = context.tbl_transit_core_sampling.Where(x => x.base_entry == base_entry);
                return ml.FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static List<tbl_transit_core_sampling> GetStatusCoreSamplingInProgress()
        {
            try
            {
                var users = context.tbl_transit_core_sampling.Where(x =>
                x.create_date.Value.Day == DateTime.Now.Day &&
                x.create_date.Value.Month  == DateTime.Now.Month  &&
                x.create_date.Value.Year  == DateTime.Now.Year && 
                (x.status==0));

                if (users.Count() > 0)
                    return users.ToList();
                else
                    return null;

//                string query = @"
//                select * from tbl_transit_core_sampling WHERE
//                DATEPART(day,[create_date]) = DATEPART(day,GETDATE()) and 
//                DATEPART(month,[create_date]) = DATEPART(month,GETDATE()) and 
//                DATEPART(year,[create_date]) = DATEPART(year,GETDATE()) AND status=0";// AND device_type='C'";
//                var datas = context.Database.SqlQuery<tbl_transit_core_sampling>(query);
//                if (datas != null)
//                {
//                    return datas.ToList();
//                }
//                else
//                {
//                    return null;
//                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetStatusCoreSamplingInProgress Error:" + ex.Message);
                return null;
            }
        }


        public static bool UpdateCoreSampling(tbl_transit_core_sampling tbl)
        {
            try
            {
                var t = context.tbl_transit_core_sampling.Where(x => x.doc_entry == tbl.doc_entry).FirstOrDefault();
                t.status = 1;
                t.pol_nir = tbl.pol_nir;
                t.brix_nir = tbl.brix_nir;
                t.rendemen_nir = tbl.rendemen_nir;
                context.SaveChanges();
                Console.WriteLine("UpdateCoreSampling OK");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("UpdateCoreSampling Error:" + ex.Message);
                return false;
            }

        }

        

        public static bool UpdateStatusCoreSamplingManual(tbl_transit_core_sampling tbl)
        {
            try
            {
                var t = context.tbl_transit_core_sampling.Where(x => x.doc_entry.Equals(tbl.doc_entry)).FirstOrDefault();
                t.status = 1;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static tbl_transit_core_sampling GetCoreSamplingByDocEntry(int doc_entry)
        {
            try
            {
                var t = context.tbl_transit_core_sampling.Where(x => x.doc_entry.Equals(doc_entry.ToString())).FirstOrDefault();
                return t;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static tbl_transit_timbangan CheckTableTransitTimbangan(string  base_entry)
        {
            string query = @"select * from tbl_transit_timbangan where
                DATEPART(day,[TglTimbanganIn]) = DATEPART(day,GETDATE()) and 
                DATEPART(month,[date_in]) = DATEPART(month,GETDATE()) and 
                DATEPART(year,[date_in]) = DATEPART(year,GETDATE())  and
                [base_entry] ='" + base_entry + "'";
            var datas = context.Database.SqlQuery<tbl_transit_timbangan>(query);
            return datas.FirstOrDefault();

        }
        public static bool SaveDevice(device_config dc, out string msg, User userLogin)
        {
            try
            {
                if (userLogin == null)
                {
                    msg = "You dont have authorize to do this process";
                    return false;
                }
                else
                {
                    //var exist = GetUserByUserName(dc.Username);
                    //if (exist != null && dc.ID > 0)
                    //{
                    //    msg = "User Name Already Exist";
                    //    return false;
                    //}
                    //else
                    //{
                    //    dc.UpdateBy = userLogin.Username;
                    //    dc.UpdateTerminal = localcompname;
                    //    dc.UpdateDate = DateTime.Now;

                    if (dc.device_id == 0)
                    {
                        // new device

                        dc.create_by = userLogin.Username;
                        //dc.cre = localcompname;
                        dc.create_date = DateTime.Now;
                        msg = "Device Configuration Have been Add";
                        context.device_config.Add(dc);
                        //context.Users.Add(dc);
                        context.SaveChanges();
                    }
                    else
                    {
                        // update device
                        device_config dc1 = context.device_config.Where(x => x.device_id == dc.device_id).FirstOrDefault();
                        dc.device_name = dc1.device_name;
                        dc.device_ip = dc1.device_ip;
                        dc.location = dc1.location;
                        dc.id = dc1.id;
                        msg = "User Have been Update";
                        context.SaveChanges();
                    }
                    return true;
                }
            }

            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static bool InsertHistoryTiket(int IDs)
        {
            try
            {
                //context = new Context.SRSEntities();
                string query = @"
                    INSERT INTO tiket_history
                      (id_ref, NamaKUD, NoTiket, NamaPetani, NamaPetani2, KodeRegister, KodeRegister2, Alamat, Alamat2, DibuatOleh, DiserahkanOlehJabatan, PenanggungJawab, 
                      PenanggungJawabJabatan, Driver, NoTruck, LuasLahan, VarietasTebu, LokasiDesa, LokasiKec, LokasiKab, KodeMitra, CreateDate, CreateBy, CreateTerminal, 
                      UpdateDate, UpdateBy, UpdateTerminal, tglTTA, tglKontrak, EstBeratTebu, KodeMitra2, kategori, est_tch, est_ritase, est_hasil_panen, est_radius, tgl_panen, 
                      no_kontrak, est_luas_panen, rayon, id_status, tiket_master_id)
                    SELECT     ID, NamaKUD, NoTiket, NamaPetani, NamaPetani2, KodeRegister, KodeRegister2, Alamat, Alamat2, DibuatOleh, DiserahkanOlehJabatan, PenanggungJawab, 
                      PenanggungJawabJabatan, Driver, NoTruck, LuasLahan, VarietasTebu, LokasiDesa, LokasiKec, LokasiKab, KodeMitra, CreateDate, CreateBy, CreateTerminal, 
                      UpdateDate, UpdateBy, UpdateTerminal, tglTTA, tglKontrak, EstBeratTebu, KodeMitra2, kategori, est_tch, est_ritase, est_hasil_panen, est_radius, tgl_panen, 
                      no_kontrak, est_luas_panen, rayon, id_status, tiket_master_id
                      FROM Tiket WHERE (ID =" + IDs + ")";

                context.Database.ExecuteSqlCommand(query);
                context = new Context.SRSEntities();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Update History Tiket" + ex.Message);
                return false;
            }
        }

    }
}
