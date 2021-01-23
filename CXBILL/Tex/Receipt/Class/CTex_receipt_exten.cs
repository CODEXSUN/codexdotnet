// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:14 AM
// last update : 13-03-2018

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class CTex_receipt_exten
    {
         #region[Entity Data]

        private static Tex_receipt EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Tex_receipt obj = new Tex_receipt()
                    {
                        Tex_receipt_id = redr[TEX_RECEIPT.TEX_RECEIPT_ID].ToString(),
                        Tex_receipt_no = redr[TEX_RECEIPT.TEX_RECEIPT_NO].ToString(),
                        Tex_receipt_date = redr[TEX_RECEIPT.TEX_RECEIPT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Cheq_no = redr[TEX_RECEIPT.CHEQ_NO].ToString(),
                        Receipt_amount = redr[TEX_RECEIPT.TEX_RECEIPT_AMOUNT].ToString(),
                        Cheq_date = redr[TEX_RECEIPT.CHEQ_DATE].ToString(),
                        Bank_id = redr[BANK.BANK_NAME].ToString(),
                        Total_amount = redr[TEX_RECEIPT.TOTAL_AMOUNT].ToString(),
                        Notes = redr[TEX_RECEIPT.NOTES].ToString(),
                        Active_id = redr[TEX_RECEIPT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Tex_receipt();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Tex_receipt> EntityList(string q)
         {
             List<Tex_receipt> list = new List<Tex_receipt>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Tex_receipt obj = new Tex_receipt()
                     {
                        Tex_receipt_id = redr[TEX_RECEIPT.TEX_RECEIPT_ID].ToString(),
                        Tex_receipt_no = redr[TEX_RECEIPT.TEX_RECEIPT_NO].ToString(),
                        Tex_receipt_date = redr[TEX_RECEIPT.TEX_RECEIPT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Cheq_no = redr[TEX_RECEIPT.CHEQ_NO].ToString(),
                        Receipt_amount = redr[TEX_RECEIPT.TEX_RECEIPT_AMOUNT].ToString(),
                        Cheq_date = redr[TEX_RECEIPT.CHEQ_DATE].ToString(),
                        Bank_id = redr[TEX_RECEIPT.BANK_ID].ToString(),
                        Total_amount = redr[TEX_RECEIPT.TOTAL_AMOUNT].ToString(),
                        Notes = redr[TEX_RECEIPT.NOTES].ToString(),
                        Active_id = redr[TEX_RECEIPT.ACTIVE_ID].ToString(),
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

         public static List<Tex_receipt> Unrefer(DAL DAL)
         {
            string q = " SELECT " + TEX_RECEIPT.TEX_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TEX_RECEIPT.TEX_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
           // q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            //q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " ORDER BY  " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<Tex_receipt> Refer(DAL DAL)
         {
            string q = " SELECT " + TEX_RECEIPT.TEX_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TEX_RECEIPT.TEX_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " ORDER BY  " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<Tex_receipt> Showall(DAL DAL)
         {
            string q = " SELECT " + TEX_RECEIPT.TEX_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TEX_RECEIPT.TEX_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<Tex_receipt> Notactive(DAL DAL)
         {
            string q = " SELECT " + TEX_RECEIPT.TEX_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TEX_RECEIPT.TEX_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static Tex_receipt PKId(string id, DAL DAL)
         {
            string q = " SELECT " + TEX_RECEIPT.TEX_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TEX_RECEIPT.TEX_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_ID + " = '" + id + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_NO + ";\r\n";

             return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<Tex_receipt> Searchby(string no, string date, string party, DAL DAL)
         {
            string q = " SELECT " + TEX_RECEIPT.TEX_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TEX_RECEIPT.TEX_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_NO + " = '" + no + "'\r\n";
            }
            if (date != "")
            {

                q += " AND " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " ORDER BY  " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_NO + " \r\n";
            q += " FROM  " + TEX_RECEIPT.TEX_RECEIPT_TBL + " \r\n";
            q += " WHERE " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + TEX_RECEIPT.TEX_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_DATE + " \r\n";
            q += " FROM  " + TEX_RECEIPT.TEX_RECEIPT_TBL + " \r\n";
            q += " WHERE " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + TEX_RECEIPT.TEX_RECEIPT_TBL + "." + TEX_RECEIPT.TEX_RECEIPT_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(TEX_RECEIPT.TEX_RECEIPT_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][TEX_RECEIPT.TEX_RECEIPT_DATE] + "")
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
                string q = "SELECT " + TEX_RECEIPT.TEX_RECEIPT_NO + " FROM " + TEX_RECEIPT.TEX_RECEIPT_TBL + "\r\n";
                q += " WHERE " + TEX_RECEIPT.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + TEX_RECEIPT.TEX_RECEIPT_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[TEX_RECEIPT.TEX_RECEIPT_NO].ToString())) + 1).ToString();
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
             Tex_receipt obj = PKId(Id, new DAL()); 
 
             if (obj != null) 
             { 
                 return obj.Tex_receipt_no; 
             } 
             return ""; 
         } 
 
         public static string GetId_Name(string No) 
         { 
             List<Tex_receipt> list = Searchby(No, "", "", new DAL()); 
 
             if (list.Count != 0) 
             { 
                 return list[0].Tex_receipt_id; 
             } 
             return ""; 
         } 
 
         #endregion[Get id - No] 
         
    }//cls
}//ns
