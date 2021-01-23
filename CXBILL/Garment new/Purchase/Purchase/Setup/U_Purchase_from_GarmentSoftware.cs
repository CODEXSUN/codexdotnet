// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CXBILL
{
    public static class U_Purchase_from_GarmentSoftware
    {
        #region[]

        public static void GetUpdated(string OldDB)
        {
            int count = GetCount(OldDB);
            
            for (int i = 1; i <= count; i++)
            {
                Purchase obj = GetOldData(i, OldDB);
                List<Purchaseitems> list = GetOldItemsData(i, OldDB);

                if (obj != null) 
                {
                    InsertData(obj, list);
                }
                
            }
        }

        #endregion[]

        #region[Get Count]

        private static int GetCount( string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += "SELECT * FROM " + PURCHASE.PURCHASE_TBL + " ORDER BY " + PURCHASE.PURCHASE_ID + " DESC LIMIT 1 ; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    int lastId = Convert.ToInt32(redr[PURCHASE.PURCHASE_ID]);

                    return lastId;
                }
                return 0;
            }
        }

        #endregion[Get Count]

        #region[Get Old data]

        private static Purchase GetOldData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += " SELECT " + PURCHASE.PURCHASE_TBL + ".* \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + PURCHASE.PURCHASE_TBL + " \r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " = '" + id + "' \r\n";
            //q += " ORDER BY  " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_NO + ";\r\n";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Purchase obj = new Purchase
                    {
                        Uniqueno = "",
                        Company_id = redr[PURCHASE.COMPANY_ID].ToString(),
                        Acy_id = redr[PURCHASE.ACY_ID].ToString(),
                        Order_id = "1",
                        Entry_no = redr[PURCHASE.ENTRY_NO].ToString(),
                        Purchase_no = redr[PURCHASE.PURCHASE_NO].ToString(),
                        Purchase_date = redr[PURCHASE.PURCHASE_DATE].ToString(),
                        Party_id = CParty_exten.GetId_Name(redr[PARTY.PARTY_NAME].ToString()),
                        Taxtype_id = CTaxtype_exten.GetId_Name(redr[TAXTYPE.TAXTYPE_NAME].ToString()),
                        Salestype_id = CSalestype_exten.GetId_Name(redr[SALESTYPE.SALESTYPE_NAME].ToString()),
                        Total_qty = ConvertTO.Decimal(redr[PURCHASE.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[PURCHASE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[PURCHASE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[PURCHASE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[PURCHASE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[PURCHASE.GSTTOTAL].ToString()),
                        Ledger_id = redr[PURCHASE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[PURCHASE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[PURCHASE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[PURCHASE.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[PURCHASE.REFERED_AMT].ToString()),
                        Locked = redr[PURCHASE.LOCKED].ToString(),
                        Notes = redr[PURCHASE.NOTES].ToString(),
                        Active_id = redr[PURCHASE.ACTIVE_ID].ToString(),
                        User_id = "1"
                    };

                    obj.Uniqueno = obj.Acy_id + "~" + obj.Company_id + "~" + obj.Entry_no + "~(" + ConvertTO.Date2S(obj.Purchase_date)+")" ;

                    return obj;
                }
                return null;
            }
        }

        #endregion[Get Old data]

        #region[Get Old items data]

        private static List<Purchaseitems> GetOldItemsData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += " SELECT " + PURCHASEITEMS.PURCHASEITEMS_TBL + ".* \r\n";
            q += ", " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + PURCHASEITEMS.PURCHASEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PURCHASE.PURCHASE_TBL + "\r\n";
            q += " ON(" + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.PURCHASE_ID + " = " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASE.PURCHASE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.PURCHASEITEMS_ID + ";\r\n";

            List<Purchaseitems> list = new List<Purchaseitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Purchaseitems obj = new Purchaseitems()
                    {
                        Purchaseitems_id = "",
                        Purchase_id = "",
                        Product_id = CProduct_exten.GetId_Name(redr[PRODUCT.PRODUCT_NAME].ToString()),
                        Sizes_id = "1",
                        Qty = ConvertTO.Decimal(redr[PURCHASEITEMS.QTY].ToString()),
                        Price = ConvertTO.Decimal(redr[PURCHASEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[PURCHASEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[PURCHASEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[PURCHASEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = "0",
                        Locked = "0",
                    };

                    list.Add(obj);
                }

                return list;
            }
        }

        #endregion[Get Old data]

        #region[Check data]

        private static bool CheckData(Purchase obj)
        {
            string q = "USE CODEXSUN_DB; ";
            q += "SELECT * FROM " + INVOICE.INVOICE_TBL + " WHERE " + INVOICE.UNIQUENO + " = '" + obj.Uniqueno + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    obj.Purchase_id = redr[INVOICE.INVOICE_ID].ToString();

                    CPurchase.Update(obj, new DAL());

                    return true;
                }
                return false;
            }
        }
        #endregion[Check data]

        #region[Insert data]

        private static void InsertData(Purchase obj, List<Purchaseitems> items)
        {
            DAL dalsession;

            try
            {
                dalsession = new DAL();
                dalsession.BeginTransaction();

                List<Purchaseitems> list_new = new List<Purchaseitems>();
                if (obj != null)
                {
                    if (CheckData(obj) != true)
                    {


                        Purchase obj_new = obj;



                        switch (obj.Company_id)
                        {
                            case "1":
                                obj_new.Company_id = "1";
                                obj_new.Acy_id = "3";
                                break;

                            case "2":
                                obj_new.Company_id = "2";
                                obj_new.Acy_id = "3";
                                break;

                            case "3":
                                obj_new.Company_id = "3";
                                obj_new.Acy_id = "3";
                                break;

                            case "4":
                                obj_new.Company_id = "4";
                                obj_new.Acy_id = "3";
                                break;

                            case "5":
                                obj_new.Company_id = "5";
                                obj_new.Acy_id = "3";
                                break;

                            case "6":
                                obj_new.Company_id = "6";
                                obj_new.Acy_id = "3";
                                break;

                            case "7":
                                obj_new.Company_id = "1";
                                obj_new.Acy_id = "4";
                                break;

                            case "8":
                                obj_new.Company_id = "2";
                                obj_new.Acy_id = "4";
                                break;

                            case "9":
                                obj_new.Company_id = "3";
                                obj_new.Acy_id = "4";
                                break;

                            case "10":
                                obj_new.Company_id = "4";
                                obj_new.Acy_id = "4";
                                break;

                            case "11":
                                obj_new.Company_id = "5";
                                obj_new.Acy_id = "4";
                                break;

                            case "12":
                                obj_new.Company_id = "6";
                                obj_new.Acy_id = "4";
                                break;

                            case "13":
                                obj_new.Company_id = "7";
                                obj_new.Acy_id = "4";
                                break;

                            case "14":
                                obj_new.Company_id = "8";
                                obj_new.Acy_id = "4";
                                break;

                            case "15":
                                obj_new.Company_id = "9";
                                obj_new.Acy_id = "4";
                                break;


                        }

                        obj_new.Uniqueno = obj_new.Acy_id + "~" + obj_new.Company_id + "~" + obj_new.Entry_no + "~(" + ConvertTO.Date2S(obj_new.Purchase_date) + ")";


                        CPurchase.Insert(obj_new, dalsession);
                        var vId = DAL.GetIdentity(dalsession);

                        for (int k = 0; k < items.Count; k++)
                        {
                            Purchaseitems v = new Purchaseitems()
                            {
                                Purchase_id =vId,
                                Product_id = items[k].Product_id,
                                Sizes_id = items[k].Sizes_id,
                                Qty = items[k].Qty,
                                Price = items[k].Price,
                                Cgst_percent = items[k].Cgst_percent,
                                Sgst_percent = items[k].Sgst_percent,
                                Igst_percent = items[k].Igst_percent,
                                Refered_id = items[k].Refered_id,
                                Locked = items[k].Locked
                            };
                            list_new.Add(v);
                        }

                        CPurchaseitems.Insert(list_new, dalsession);
                        dalsession.Commit();
                    }
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("error : " + ex);
            }

        }

        #endregion[Insert data]

    }//cls
}//ns
