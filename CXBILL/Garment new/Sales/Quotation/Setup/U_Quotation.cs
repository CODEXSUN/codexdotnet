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
    public static class U_Quotation
    {
        #region[]

        public static void GetUpdated(string OldDB)
        {

            string tablename = QUOTATION.QUOTATION_TBL;

            int count = GetCount(tablename, OldDB);

            for (int i = 1; i <= count; i++)
            {
                Quotation obj = GetOldData(i, OldDB);
                List<Quotationitems> list = GetOldItemsData(i, OldDB);

                if (obj != null)
                {
                    InsertData(obj, list);
                }

            }
        }

        #endregion[]

        #region[Get Count]

        private static int GetCount(string tablename, string OldDB)
        {
            string ID = (tablename.Remove((tablename).Length - 4).ToUpper()) + "_ID";

            string q = "USE " + OldDB + "; ";
            q += "SELECT * FROM " + tablename + " ORDER BY " + ID + " DESC LIMIT 1 ; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    int lastId = Convert.ToInt32(redr[ID]);

                    return lastId;
                }
                return 0;
            }
        }

        #endregion[Get Count]

        #region[Get Old data]

        private static Quotation GetOldData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += " SELECT " + QUOTATION.QUOTATION_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + QUOTATION.QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_ID + "  = '" + id + "' \r\n";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Quotation obj = new Quotation
                    {
                        Uniqueno = redr[QUOTATION.UNIQUENO].ToString(),
                        Company_id = redr[QUOTATION.COMPANY_ID].ToString(),
                        Acy_id = redr[QUOTATION.ACY_ID].ToString(),
                        Order_id = "1",
                        Quotation_no = redr[QUOTATION.QUOTATION_NO].ToString(),
                        Quotation_date = redr[QUOTATION.QUOTATION_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[QUOTATION.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[QUOTATION.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Ledger_id = redr[QUOTATION.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[QUOTATION.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[QUOTATION.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[QUOTATION.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[QUOTATION.REFERED_AMT].ToString()),
                        Locked = redr[QUOTATION.LOCKED].ToString(),
                        Notes = redr[QUOTATION.NOTES].ToString(),
                        Active_id = redr[QUOTATION.ACTIVE_ID].ToString(),
                        User_id = "1",
                        
                    };

                    obj.Uniqueno = obj.Acy_id + "~" + obj.Company_id + "~" + obj.Quotation_no + "~(" + ConvertTO.Date2S(obj.Quotation_date) + ")";

                    return obj;
                }
                return null;
            }
        }

        #endregion[Get Old data]

        #region[Get Old items data]

        private static List<Quotationitems> GetOldItemsData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += " SELECT " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + ".* \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += " FROM  " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATIONITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";
            q += " ON(" + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATIONITEMS.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + " )\r\n";
            q += " WHERE " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATION.QUOTATION_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATIONITEMS.QUOTATIONITEMS_ID + ";\r\n";

            List<Quotationitems> list = new List<Quotationitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Quotationitems obj = new Quotationitems()
                    {
                        Quotationitems_id = "",
                        Quotation_id = "",
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Qty = redr[QUOTATIONITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[QUOTATIONITEMS.PRICE].ToString()),
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

        private static bool CheckData(Quotation obj)
        {
            string q = "USE CODEXSUN_DB; ";
            q += "SELECT * FROM " + QUOTATION.QUOTATION_TBL + " WHERE " + QUOTATION.UNIQUENO + " = '" + obj.Uniqueno + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    obj.Quotation_id = redr[QUOTATION.QUOTATION_ID].ToString();

                    CQuotation.Update(obj, new DAL());

                    return true;
                }
                return false;
            }
        }
        #endregion[Check data]

        #region[Insert data]

        private static void InsertData(Quotation obj, List<Quotationitems> items)
        {
            DAL dalsession;

            try
            {
                dalsession = new DAL();
                dalsession.BeginTransaction();

                List<Quotationitems> list_new = new List<Quotationitems>();
                if (obj != null)
                {
                    if (CheckData(obj) != true)
                    {

                        Quotation obj_new = new Quotation
                        {
                            Uniqueno = obj.Uniqueno,
                            Company_id = obj.Company_id,
                            Acy_id = obj.Acy_id,
                            Order_id = "1",
                            Quotation_no = obj.Quotation_no,
                            Quotation_date = obj.Quotation_date,
                            Party_id = CParty_exten.GetId_Name(obj.Party_id),
                            Total_qty = obj.Total_qty,
                            Total_taxable_amount = obj.Total_taxable_amount,
                            Ledger_id = obj.Ledger_id,
                            Additional = obj.Additional,
                            Rounds = obj.Rounds,
                            Grandtotal = obj.Grandtotal,
                            Refered_amt = obj.Refered_amt,
                            Locked = obj.Locked,
                            Notes = obj.Notes,
                            Active_id = obj.Active_id,
                            User_id = "1"
                        };

                        switch (obj.Company_id)
                        {
                            case "1":
                                obj_new.Company_id = "1";
                                obj_new.Acy_id = "2";
                                break;

                            case "2":
                                obj_new.Company_id = "1";
                                obj_new.Acy_id = "3";
                                break;

                            case "3":
                                obj_new.Company_id = "1";
                                obj_new.Acy_id = "4";
                                break;

                        }

                        obj_new.Uniqueno = obj_new.Acy_id + "~" + obj_new.Company_id + "~" + obj_new.Quotation_no;


                        CQuotation.Insert(obj_new, dalsession);
                        var vId = DAL.GetIdentity(dalsession);

                        for (int k = 0; k < items.Count; k++)
                        {
                            Quotationitems v = new Quotationitems()
                            {
                                Quotation_id = vId,
                                Product_id = CProduct_exten.GetId_Name(items[k].Product_id),
                                Sizes_id = CSizes_exten.GetId_Name(items[k].Sizes_id),
                                Qty = items[k].Qty,
                                Price = items[k].Price,
                                Refered_id = items[k].Refered_id,
                                Locked = items[k].Locked
                            };
                            list_new.Add(v);
                        }

                        CQuotationitems.Insert(list_new, dalsession);
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
