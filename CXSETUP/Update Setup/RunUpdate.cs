using System;
using CXLIB;
using CXCORE;
using CXBILL;

namespace CXSETUP
{
    public static class RunUpdate
    {
        public static string screenText = "";
        ///
        public static event EventHandler Processing = null;

        public static void Install(Setup obj)
        {

            switch (obj.Mode)
            {
                case "Update":

                    CxCore(obj.Database);

                    screenText = "...";
                    Processing(null, null);

                    //InstallEntries(obj);

                    //screenText = "";
                    //Processing(null, null);

                    break;

            }

            //TODO:

        }

        #region[CXCORE]

        public static void CxCore(string OldDB)
        {
            //U_Role.GetUpdated(OldDB);

            //U_User.GetUpdated(OldDB);

            U_City.GetUpdated(OldDB);

            U_State.GetUpdated(OldDB);

            U_Country.GetUpdated(OldDB);

            U_Pincode.GetUpdated(OldDB);

           // U_Contacttype.GetUpdated(OldDB);

            //U_Producttype.GetUpdated(OldDB);

            U_Hsncode.GetUpdated(OldDB);

            U_Unit.GetUpdated(OldDB);

            U_Ledgergroup.GetUpdated(OldDB);

            U_Ledger.GetUpdated(OldDB);

           // U_Taxtype.GetUpdated(OldDB);

           // U_Salestype.GetUpdated(OldDB);

            U_Transport.GetUpdated(OldDB);

            U_Colours.GetUpdated(OldDB);

            U_Bank.GetUpdated(OldDB);

            U_Receipttype.GetUpdated(OldDB);

            //U_Ordertype.GetUpdated(OldDB);

        }

        public static void CXCoreUpdate1(string OldDB)
        {
             //U_Company.GetUpdated(OldDB);

            //U_Party.GetUpdated(OldDB);

            U_Producttype.GetUpdated(OldDB);
            U_Product.GetUpdated(OldDB);

           // U_Deliveredto.GetUpdated(OldDB);

           // U_Sizes.GetUpdated(OldDB);
        }


        #endregion[CXCORE]

        //#region[Entries]

        //private static void InstallEntries(Setup obj)
        //{
        //    //CxCommon(obj);

        //    //switch (obj.SoftwareType)
        //    //{

        //    //    case Softwares.GARMENT:
        //    //        CxGarment(obj);
        //    //        break;

        //    //    case Softwares.OFFSET:
        //    //        CxOffset(obj);
        //    //        break;

        //    //    case Softwares.OFFSET_1:
        //    //        CxOffset_1(obj);
        //    //        break;

        //    //    case Softwares.TEX:
        //    //        CXTex(obj);
        //    //        break;

        //    //    case Softwares.KNITTING:

        //    //        break;

        //    //    case Softwares.UPVC:
        //    //        CxUPVC(obj);
        //    //        break;

        //    }

        //}

        //#endregion[Entries]

        //#region[CXGARMENT]

        //public static void CxGarment(Setup obj)
        //{
        //    //new Garment_order_Tbl(OldDB);

        //    //screenText = "Installed Garment Order Table";
        //    //Processing(null, null);

        //    //new Garment_invoice_Tbl(OldDB);

        //    //screenText = "Installed Garment Invoice Table";
        //    //Processing(null, null);

        //    //new CXBILL.Receipt_Tbl(OldDB);

        //    //screenText = "Installed Garment Receipt Table";
        //    //Processing(null, null);

        //    //new Garment_Purchase_Tbl(OldDB);

        //    //screenText = "Installed Garment Purchase Table";
        //    //Processing(null, null);

        //    //new Garment_payment_Tbl(OldDB);

        //    //screenText = "Installed Garment Payment Table";
        //    //Processing(null, null);
        //}

        //#endregion[CXGARMENT]

    }
}
