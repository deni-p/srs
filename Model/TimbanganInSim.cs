using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SRS.DeskApp.DAO;

namespace SRS.DeskApp.Model
{
    public class TimbanganInSim : Context.shared_timbangan_in
    {
        public static Context.shared_timbangan_in GetDataTimbanganInSim(StatusError statusError, int NoTimbangan)
        {
            Context.shared_timbangan_in res = new Context.shared_timbangan_in();

            string fff = DateTime.Now.ToString("fff");

            if (statusError == StatusError.ST)
            {
                res.BeratKotor = 0;
                res.Driver = "DRIVER " + fff;
                res.ID = 0;
                res.NoTimbangan = NoTimbangan;
                res.NoTTA = "TTA201506051100280006";
                res.PlatNo = "L " + fff + " TS";
                res.Status = StatusError.ST.ToString();
                res.TanggalProses = DateTime.Now;
            }
            else
                if (statusError == StatusError.SW)
                {
                    res.BeratKotor = 9999;
                    res.Driver = "DRIVER " + fff;
                    res.ID = 0;
                    res.NoTimbangan = NoTimbangan;
                    res.NoTTA = "TTA201506051100280006";
                    res.PlatNo = "L" + DateTime.Now.ToString("fff") + "TS";
                    res.Status = StatusError.SW.ToString();
                    res.TanggalProses = DateTime.Now;
                }
                else
                    if (statusError == StatusError.T)
                    {
                        res.BeratKotor = 0;
                        res.Driver = "";
                        res.ID = 0;
                        res.NoTimbangan = NoTimbangan;
                        res.NoTTA = "";
                        res.PlatNo = "";//"L" + DateTime.Now.ToString("fff") + "TS";
                        res.Status = StatusError.T.ToString();
                        res.TanggalProses = DateTime.Now;
                    }
                    else
                        if (statusError == StatusError.W)
                        {
                            res.BeratKotor = 0;
                            res.Driver = "DRIVER " + fff;
                            res.ID = 0;
                            res.NoTimbangan = NoTimbangan;
                            res.NoTTA = "TTA201506051100280006";
                            res.PlatNo = "L" + DateTime.Now.ToString("fff") + "TS";
                            res.Status = StatusError.W.ToString();
                            res.TanggalProses = DateTime.Now;
                        }
            return res;
        }
    }

    public enum StatusError
    {
        W, T, SW, ST
    }
}
