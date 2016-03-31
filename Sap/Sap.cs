using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbobsCOM;
using System.ComponentModel;
using System.Data;
using SRS.DeskApp.Context;
using MetroFramework;
using MetroFramework.Controls;

namespace SRS.DeskApp
{
    public class Sap
    {
       
        private static SRSEntities context = new Context.SRSEntities();
        private BusinessPartners vBP;
        tbl_transit_core_sampling tcs;

        private long nErr;
        private String errMsg;
        private int lRetCode = 0;
        private int key;

        private long stat;

        private String idPetani;

        SAPbobsCOM.Company oCom = new SAPbobsCOM.Company();

        public Sap()
        {

            oCom.Server = @"DERIT-PC\SQL2012";

            oCom.DbServerType = BoDataServerTypes.dst_MSSQL2012;
            oCom.CompanyDB = "SBODEMOUS";
            oCom.UserName = "manager";
            oCom.Password = "manager";

            oCom.DbUserName = "sa";
            oCom.DbPassword = "silit";
            oCom.UseTrusted = false;

            //oCom.Server = "192.168.80.6";

            //oCom.DbServerType = BoDataServerTypes.dst_MSSQL2012;
            //oCom.CompanyDB = "ktm_testing";
            //oCom.UserName = "manager";
            //oCom.Password = "password";

            //oCom.DbUserName = "sa";
            //oCom.DbPassword = "password#01";
            //oCom.UseTrusted = false;
            oCom.language = SAPbobsCOM.BoSuppLangs.ln_English;
        }

        public void ConnectServer()
        {
            if (oCom.Connected == false)
            {
                try
                {
                    oCom.LicenseServer = "localhost:30000"; //"192.168.80.6:30000";
                    
                    stat = oCom.Connect();
                }
                catch (Exception x)
                {

                    throw new Exception(x.Message);
                }
                if (stat != 0)
                {
                    Console.WriteLine(oCom.GetLastErrorDescription());
                }
            }

        }

        static string IncrementID(string startValue, int numNonDigits)
        {
            string nonDigits = startValue.Substring(0, numNonDigits);
            int len = startValue.Length - numNonDigits;
            int number = int.Parse(startValue.Substring(numNonDigits));
            number++;
            if (number >= Math.Pow(10, len)) number = 1; // mulai lgi ke 1
            return String.Format("{0}{1:D" + len.ToString() + "}", nonDigits, number);
        } 

        public void insertTrans(String jenisTransaksi, String partnerID, DateTime dateIssued,
            String refNotes, int yearPeriod, String createBy, decimal jmlBayar, String baseEntry, String jenisMitra)
        {
            string tipeTr;

            String trnID;
            decimal debet = 0;
            decimal kredit = 0;

            if (jenisTransaksi == "cair")
            {
                tipeTr = "F-RCPT";
                debet = jmlBayar;
            }
            else
            {
                tipeTr = "F-ISSUED";
                kredit = jmlBayar;
            }

            int jmlPetani = (from th in context.trans_data_header
                             where th.partner_id == partnerID
                             select th).Count();
            var cariIDTransPetani = (from th in context.trans_data_header
                                     where th.partner_id == partnerID
                                     select th.trans_id).ToList();
            foreach (String item in cariIDTransPetani)
            {
                this.idPetani = item;
            }
            int brs = (from th in context.trans_data_header
                       select th).Count();

            if (jmlPetani == 0)
            {
                Console.WriteLine("Buat Rekening Baru");

                trnID = IncrementID("tr-000000" + brs, 9);

                String qryHeader = "INSERT INTO  trans_data_header(trans_id, partner_id, year_period, create_by)";
                qryHeader += "VALUES('" + trnID + "', '" + partnerID + "', " + yearPeriod + ", '" + createBy + "') ";

                String qryLine = "INSERT INTO trans_data_line(trans_id,type_trans, date_issued, debet, credit, ";
                qryLine += "ref_notes, base_entry) VALUES";
                qryLine += "( '" + trnID + "', '" + tipeTr + "' , '" + dateIssued + "', " + debet + ", " + kredit + ", '" + refNotes + "', '" + baseEntry + "')";

                int simpanHeader = context.Database.ExecuteSqlCommand(qryHeader);

                int simpanDetail = context.Database.ExecuteSqlCommand(qryLine);
            }
            else
            {
                Console.WriteLine("jgn buat rekening baru, tpi buat transaksi detil baru dg trans_id sama dgn master");

                String qryLine = "INSERT INTO trans_data_line(trans_id,type_trans, date_issued, debet, credit, ";
                qryLine += "ref_notes, base_entry) VALUES";
                qryLine += "( '" + this.idPetani + "', '" + tipeTr + "' , '" + dateIssued + "', " + debet + ", " + kredit + ", '" + refNotes + "', '" + baseEntry + "')";

                int simpanDetail = context.Database.ExecuteSqlCommand(qryLine);
            }
        }

        private  void UpdateKeyGr( int docEntry, int baseEntry, String grKey, DateTime update_date)
        {
            try
            {
                var t = context.tbl_transit_core_sampling.Where(x => (x.base_entry == baseEntry) 
                    && (x.doc_entry == docEntry) ).FirstOrDefault();
                t.grkey = grKey;
                t.update_date = update_date;
                context.SaveChanges();
                Console.WriteLine("Updated GrKey");                
            }
            catch (Exception ex)
            {
                Console.WriteLine("GrKey Error:" + ex.Message);
            }

        }

        private void UpdateKeyInvoice( Int32 docEntry,  int baseEntry, String invKey, DateTime update_date)
        {
            try
            {
                var t = context.tbl_transit_core_sampling.Where(x => (x.base_entry == baseEntry) 
                    && (x.doc_entry == docEntry) ).FirstOrDefault();
                t.invoicekey = invKey;
                t.update_date = update_date;
                context.SaveChanges();
                Console.WriteLine("Updated inventoryKey");
            }
            catch (Exception ex)
            {
                Console.WriteLine("inventory Key Error:" + ex.Message);
            }

        }

        private void UpdateKeyOpay(int baseEntry, String invKey, DateTime update_date)
        {
            try
            {
                var t = context.tbl_transit_core_sampling.Where(x => x.base_entry == baseEntry).FirstOrDefault();
                t.invoicekey = invKey;
                t.update_date = update_date;
                context.SaveChanges();
                Console.WriteLine("Updated inventoryKey");
            }
            catch (Exception ex)
            {
                Console.WriteLine("inventory Key Error:" + ex.Message);
            }

        }

        public int SaveBP(String cardCode, String cardName, String ctName, String ctAddress, BoCardTypes vendor, 
            String penanggungJawab)
        {

            BusinessPartners vBP = oCom.GetBusinessObject(BoObjectTypes.oBusinessPartners);
            vBP.CardCode = cardCode;
            vBP.CardName = cardName;
            vBP.CardType = vendor;
            vBP.ContactPerson = penanggungJawab;
            vBP.ContactEmployees.Add();

            vBP.ContactEmployees.SetCurrentLine(0);
            vBP.ContactEmployees.Name = ctName;
            vBP.ContactEmployees.Address = ctAddress;
            
            
            lRetCode = vBP.Add();

            if (lRetCode != 0)
            {
                if (lRetCode == -10) {
                    Console.WriteLine( cardCode + " Tidak dapat disimpan, Duplicate Data");
                    Console.WriteLine(oCom.GetLastErrorDescription());
                    return 0;                    
                }
                throw new Exception(oCom.GetLastErrorDescription());
            }
            else
            {
                Console.WriteLine(oCom.GetLastErrorDescription());
                Console.WriteLine(oCom.GetNewObjectKey());
                return 1;// Convert.ToInt32(oCom.GetNewObjectKey());
            }

        }
        
        public int SaveGRPO(String cardCode, DateTime docDate, DateTime docDueDate,
            String itemCode, Double quantity, Double unitPrice)
        {
            try
            {
                SAPbobsCOM.Documents vGrpo = oCom.GetBusinessObject(BoObjectTypes.oPurchaseDeliveryNotes);
                //SAPbobsCOM.Documents vGrpo = oCom.GetBusinessObject(BoObjectTypes.oPurchaseInvoices);
                //vGrpo.Series = 0;
                vGrpo.CardCode = cardCode;
                vGrpo.DocDate = docDate; 
                vGrpo.DocDueDate = docDueDate;


                vGrpo.Lines.ItemCode = itemCode;
                vGrpo.Lines.Quantity = quantity;
                vGrpo.Lines.UnitPrice =  unitPrice;
                vGrpo.Lines.WarehouseCode = "LMG01";  //Aktifkan ini klu sdh konek d server Labinta, jk offline mk jgn pkai
                vGrpo.Lines.Add();
                
                

                lRetCode = vGrpo.Add();
                //===============================================mulai ini

            }
            catch (Exception x)
            {
                Console.WriteLine(x.ToString());
                Console.WriteLine(oCom.GetLastErrorDescription());
            }

            if (lRetCode != 0)
            {
                Console.WriteLine(oCom.GetLastErrorDescription());
                
                
                throw new Exception(oCom.GetLastErrorDescription());
            }
            else
            {
                Console.WriteLine( oCom.GetLastErrorDescription () );
                Console.WriteLine(oCom.GetNewObjectKey());
                return Convert.ToInt32(oCom.GetNewObjectKey());
            }

            
        }


        public int saveAPInvoice(int docEntry, int baseEntry, String cardCode, DateTime docDate, DateTime docDueDate,
            String itemCode, Decimal quantity, Decimal unitPrice)
        {
          
            try
            {
                int keygrpo;
                
                keygrpo = SaveGRPO(cardCode, docDate, docDueDate, itemCode, Convert.ToDouble( quantity) 
                            ,  Convert.ToDouble( unitPrice) );

                SAPbobsCOM.Documents vGrpo = oCom.GetBusinessObject(BoObjectTypes.oPurchaseDeliveryNotes);
                SAPbobsCOM.Documents vAPIn =  oCom.GetBusinessObject(BoObjectTypes.oPurchaseInvoices);

                UpdateKeyGr( docEntry,  Convert.ToInt32(baseEntry), keygrpo.ToString(), DateTime.Now );

                
                bool obj;
                obj = vGrpo.GetByKey(keygrpo);

                

                vAPIn.CardCode = vGrpo.CardCode;
                vAPIn.DocDate = vGrpo.DocDate; 
                vAPIn.DocDueDate = vGrpo.DocDueDate;
                            

                Console.WriteLine ( vGrpo.Lines.Count);

                for (int i = 0; i < vGrpo.Lines.Count ; i++)
                {
                    vAPIn.Lines.SetCurrentLine(i);

                    vAPIn.Lines.BaseType = 20;
                    vAPIn.Lines.Quantity = vGrpo.Lines.Quantity;
                    vAPIn.Lines.ItemCode = vGrpo.Lines.ItemCode;
                    vAPIn.Lines.BaseLine = vGrpo.Lines.LineNum;
                    vAPIn.Lines.BaseEntry = vGrpo.Lines.DocEntry;
                    
                    vAPIn.Lines.Add();
                }
                                                
                lRetCode =  vAPIn.Add();
            }
            catch (Exception x)
            {

                Console.WriteLine(oCom.GetLastErrorDescription());
            }

            if (lRetCode != 0)
            {
                Console.WriteLine(oCom.GetLastErrorDescription());
                throw new Exception(oCom.GetLastErrorDescription());
            }
            else
            {
                int keyInv = Convert.ToInt32(oCom.GetNewObjectKey());

                
                UpdateKeyInvoice( docEntry, Convert.ToInt32(baseEntry), keyInv.ToString(), DateTime.Now);
                return Convert.ToInt32(oCom.GetNewObjectKey());
                
                
            }

            
        }

        public int saveOutGoingPayment(int keyAPInv, String cardCode, DateTime docDate, double docTotal, String jnsMitra,
            string cashAccount, String arAccount, String exAccount)
        {
            try
            {
                SAPbobsCOM.Payments vOGP = oCom.GetBusinessObject(BoObjectTypes.oVendorPayments);
                SAPbobsCOM.Documents vAPIn = oCom.GetBusinessObject(BoObjectTypes.oPurchaseInvoices);

                bool obj;
                obj = vAPIn.GetByKey(keyAPInv); 

                vOGP.DocObjectCode = BoPaymentsObjectType.bopot_OutgoingPayments;
                vOGP.DocType = BoRcptTypes.rSupplier;
                vOGP.CardCode = cardCode;
                vOGP.DocDate = docDate;

                switch (jnsMitra)
                {
                    case "MANDIRI":
                        vOGP.CashSum = docTotal;
                        vOGP.CashAccount = cashAccount;// "_SYS00000000003";//"_SYS00000000010";//cashAccount;
                        break;
                    case "KPPE":
                        //vOGP.TransferSum = docTotal;
                        //vOGP.TransferAccount = arAccount;
                        vOGP.CashSum = docTotal;
                        vOGP.CashAccount = arAccount;
                        break;
                    case "OWN":
                        vOGP.TransferSum = docTotal ;
                        vOGP.TransferAccount = exAccount;
                        break;
                }

                //vOGP.CashSum = docTotal; // ini gandengane cash account loh                
                //vOGP.CashAccount = cashAccount; // ini untuk simpan cash account

                //vOGP.TransferAccount = cashAccount; // iki sak gandengan gawe transfer
                //vOGP.TransferSum = docTotal;        // yo iki pisan tho

                vOGP.Invoices.InvoiceType = BoRcptInvTypes.it_PurchaseInvoice; // ini untuk type pembayaran
                vOGP.Invoices.DocEntry = vAPIn.DocEntry;
                vOGP.Invoices.Add();

                

                lRetCode = vOGP.Add();


            }
            catch (Exception)
            {

                Console.WriteLine(oCom.GetLastErrorDescription());
            }

            if (lRetCode != 0)
            {
                if (lRetCode == -10)
                {
                    Console.WriteLine(oCom.GetLastErrorDescription());
                    return 0;
                }
                else
                {
                    Console.WriteLine(oCom.GetLastErrorDescription());
                    throw new Exception(oCom.GetLastErrorDescription());
                }
            }
            else
            {
                

                Console.WriteLine(oCom.GetLastErrorDescription());
                Console.WriteLine(oCom.GetNewObjectKey());
                return Convert.ToInt32(oCom.GetNewObjectKey());
            }
        }
    }
}