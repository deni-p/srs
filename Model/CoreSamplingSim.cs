using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SRS.DeskApp.DAO;
namespace SRS.DeskApp.Model
{
    public class CoreSamplingSim : Context.shared_core_sampling
    {
        public static Context.tbl_transit_core_sampling GetDataCoreSamplingSim(StatusError statusError, int NoTimbangan)
        {
            Context.tbl_transit_core_sampling res = new Context.tbl_transit_core_sampling();

            string fff = DateTime.Now.ToString("fff");

            if (statusError == StatusError.ST)
            {
                res.pol_manual = 0;
                res.brix_manual = 0;
                //res.BARCODE = "";
                res.driver = "DRIVER " + fff;
                res.id_basket = "0";
                //res.Line = NoTimbangan;
                //res.tta = "TTA201506051100280006";
                res.car_id= "L " + fff + " TS";
                res.status = 0;// StatusError.ST.ToString();
                res.create_date = DateTime.Now;
            }
            else if (statusError == StatusError.SW)
            {
                //res.POL = 6876;
                //res.BRIX = 6876;
                //res.BARCODE = "877909076986";
                //res.Driver = "DRIVER " + fff;
                //res.ID = 0;
                //res.Line = NoTimbangan;
                //res.NoTTA = "TTA201506051100280006";
                //res.PlatNo = "L" + DateTime.Now.ToString("fff") + "TS";
                //res.Status = StatusError.SW.ToString();
                //res.TanggalProses = DateTime.Now;
            }
            else if (statusError == StatusError.T)
            {
                //res.POL = 0;
                //res.BRIX = 0;
                //res.BARCODE = "";
                //res.Driver = "";
                //res.ID = 0;
                //res.Line= NoTimbangan;
                //res.NoTTA = "";
                //res.PlatNo = "";//"L" + DateTime.Now.ToString("fff") + "TS";
                //res.Status = StatusError.T.ToString();
                //res.TanggalProses = DateTime.Now;
            }
            else if (statusError == StatusError.W)
            {
                //res.POL = 0;
                //res.BRIX = 0;
                //res.BARCODE = "";
                //res.Driver = "DRIVER " + fff;
                //res.ID = 0;
                //res.Line = NoTimbangan;
                //res.NoTTA = "TTA201506051100280006";
                //res.PlatNo = "L" + DateTime.Now.ToString("fff") + "TS";
                //res.Status = StatusError.W.ToString();
                //res.TanggalProses = DateTime.Now;
            }
            return res;
        }
    }
}
