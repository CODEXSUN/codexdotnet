// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXKNITTING
{
    public class CReceipt_exten
    {
         #region[Entity Data]

        private static Knitting_Receipt EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Knitting_Receipt obj = new Knitting_Receipt()
                    {
                        Knitting_Receipt_id = redr[KNITTING_RECEIPT.KNITTING_RECEIPT_ID].ToString(),
                        Knitting_Receipt_no = redr[KNITTING_RECEIPT.KNITTING_RECEIPT_NO].ToString(),
                        Knitting_Receipt_date = redr[KNITTING_RECEIPT.KNITTING_RECEIPT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Cheq_no = redr[KNITTING_RECEIPT.CHEQ_NO].ToString(),
                        Receipt_amount = redr[KNITTING_RECEIPT.KNITTING_RECEIPT_AMOUNT].ToString(),
                        Cheq_date = redr[KNITTING_RECEIPT.CHEQ_DATE].ToString(),
                        Bank_id = redr[BANK.BANK_NAME].ToString(),
                        Total_amount = redr[KNITTING_RECEIPT.TOTAL_AMOUNT].ToString(),
                        Notes = redr[KNITTING_RECEIPT.NOTES].ToString(),
                        Active_id = redr[KNITTING_RECEIPT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Knitting_Receipt();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Knitting_Receipt> EntityList(string q)
         {
             List<Knitting_Receipt> list = new List<Knitting_Receipt>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Knitting_Receipt obj = new Knitting_Receipt()
                     {
                        Knitting_Receipt_id = redr[KNITTING_RECEIPT.KNITTING_RECEIPT_ID].ToString(),
                        Knitting_Receipt_no = redr[KNITTING_RECEIPT.KNITTING_RECEIPT_NO].ToString(),
                        Knitting_Receipt_date = redr[KNITTING_RECEIPT.KNITTING_RECEIPT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Cheq_no = redr[KNITTING_RECEIPT.CHEQ_NO].ToString(),
                        Receipt_amount = redr[KNITTING_RECEIPT.KNITTING_RECEIPT_AMOUNT].ToString(),
                        Cheq_date = redr[KNITTING_RECEIPT.CHEQ_DATE].ToString(),
                        Bank_id = redr[KNITTING_RECEIPT.BANK_ID].ToString(),
                        Total_amount = redr[KNITTING_RECEIPT.TOTAL_AMOUNT].ToString(),
                        Notes = redr[KNITTING_RECEIPT.NOTES].ToString(),
                        Active_id = redr[KNITTING_RECEIPT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                     };

                     list.Add(obj);
                 }

             redr.Close();
             }
             return list;
         }

         #endregion[Entity List]

         #region[Unrefer]

         public static List<Knitting_Receipt> Unrefer(DAL DAL)
         {
            string q = " SELECT " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
           // q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            //q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " ORDER BY  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<Knitting_Receipt> Refer(DAL DAL)
         {
            string q = " SELECT " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " ORDER BY  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<Knitting_Receipt> Showall(DAL DAL)
         {
            string q = " SELECT " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<Knitting_Receipt> Notactive(DAL DAL)
         {
            string q = " SELECT " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static Knitting_Receipt PKId(string id, DAL DAL)
         {
            string q = " SELECT " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_ID + " = '" + id + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + ";\r\n";

             return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<Knitting_Receipt> Searchby(string no, string date, string party, DAL DAL)
         {
            string q = " SELECT " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + " = '" + no + "'\r\n";
            }
            if (date != "")
            {

                q += " AND " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " ORDER BY  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + " \r\n";
            q += " FROM  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + " \r\n";
            q += " WHERE " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_DATE + " \r\n";
            q += " FROM  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + " \r\n";
            q += " WHERE " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(KNITTING_RECEIPT.KNITTING_RECEIPT_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][KNITTING_RECEIPT.KNITTING_RECEIPT_DATE] + "")
                    );
                }
            }
            return tbl;
        }

         #endregion[GetforLookup]

        #region[GetNext_No]

        public static string GetNext_No
        {
            get
            {
                string q = "SELECT " + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + " FROM " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "\r\n";
                q += " WHERE " + KNITTING_RECEIPT.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + KNITTING_RECEIPT.KNITTING_RECEIPT_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[KNITTING_RECEIPT.KNITTING_RECEIPT_NO].ToString())) + 1).ToString();
                    }
                     redr.Close();
                    return Core.One;
                }
            }
        }

        #endregion[GetNext_No]

        //#region[Lock Status]

        //public static bool LockStatus(string pkValue)
        //{
        //    if (pkValue != null)
        //    {
        //        Receipt obj = PKId(pkValue, new DAL());
        //        if (obj.Locked == Core.Unlocked)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //#endregion[Lock Status]

        #region[Get id - No] 
 
         public static string GetName_Id(string Id) 
         { 
             Knitting_Receipt obj = PKId(Id, new DAL()); 
 
             if (obj != null) 
             { 
                 return obj.Knitting_Receipt_no; 
             } 
             return ""; 
         } 
 
         public static string GetId_Name(string No) 
         { 
             List<Knitting_Receipt> list = Searchby(No, "", "", new DAL()); 
 
             if (list.Count != 0) 
             { 
                 return list[0].Knitting_Receipt_id; 
             } 
             return ""; 
         } 
 
         #endregion[Get id - No] 
         
    }//cls
}//ns
