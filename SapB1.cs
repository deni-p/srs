using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbobsCOM;
namespace SRS.DeskApp
{
    class SapB1
    {
        Company vCom = new Company();

        long rt;
        long errCode;
        String errMsg;

        public Boolean Connect()
        {
            vCom.Server = @"DERIT-PC\SQL2012";
            vCom.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2012;
            vCom.CompanyDB = "jatis";

            vCom.UserName = "manager";
            vCom.Password = "jatis";

            //oCom.LicenseServer =  @oCom.Server + ":30000";
            vCom.DbUserName = "sa";
            vCom.DbPassword = "silit";

            vCom.UseTrusted = false;
            vCom.language = SAPbobsCOM.BoSuppLangs.ln_English;

            rt = vCom.Connect();
            Console.WriteLine(vCom.GetLastErrorDescription());
            if (rt != 0)
            {
                Console.WriteLine(vCom.GetLastErrorDescription());
                return false;
            }
            else {
                return true;
            }
        }
    }
}
