using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CXCORE;
using CXLIB;
using System.Data;
using CXBILL;
using CXBILL_EXTEN;
using CXSETUP;
using CXERP;


namespace CXTEST
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            string db = "dev_codexsun_db";


            new Style_Tbl(db);



            //Bundle_Tbl.InsertDefault_Bundle(db);


            //string OldDb = "amaltex_1920_db";
            //string OldDb = "sara_v3_db";

            //U_Deliveredto.GetUpdated(OldDb);



            //RunUpdate.CxCore(OldDb);

            //RunUpdate.CXCoreUpdate1(OldDb);

            //U_Invoice_from_GarmentSoftware.GetUpdated(OldDb);


            //U_Purchase_from_GarmentSoftware.GetUpdated(OldDb);

            //U_Tex_invoice.GetUpdated(OldDb);
            //U_Quotation.GetUpdated(OldDb);
            //U_QReceipt.GetUpdated(OldDb);
           //U_Receipt.GetUpdated(OldDb);
            //U_Party.GetUpdated(OldDb);


            //U_Invoice_from_sara.GetUpdated(OldDb);






        }
     
    }
}
