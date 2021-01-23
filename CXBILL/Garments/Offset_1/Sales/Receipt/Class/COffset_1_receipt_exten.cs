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
    public class COffset_1_receipt_exten
    {
         #region[Entity Data]

        private static Offset_1_receipt EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Offset_1_receipt obj = new Offset_1_receipt()
                    {
                        Offset_1_receipt_id = redr[OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_ID].ToString(),
                        Offset_1_receipt_no = redr[OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO].ToString(),
                        Offset_1_receipt_date = redr[OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Cheq_no = redr[OFFSET_1_RECEIPT.CHEQ_NO].ToString(),
                        Receipt_amount = redr[OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_AMOUNT].ToString(),
                        Cheq_date = redr[OFFSET_1_RECEIPT.CHEQ_DATE].ToString(),
                        Bank_id = redr[BANK.BANK_NAME].ToString(),
                        Total_amount = redr[OFFSET_1_RECEIPT.TOTAL_AMOUNT].ToString(),
                        Notes = redr[OFFSET_1_RECEIPT.NOTES].ToString(),
                        Active_id = redr[OFFSET_1_RECEIPT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Offset_1_receipt();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Offset_1_receipt> EntityList(string q)
         {
             List<Offset_1_receipt> list = new List<Offset_1_receipt>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Offset_1_receipt obj = new Offset_1_receipt()
                     {
                        Offset_1_receipt_id = redr[OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_ID].ToString(),
                        Offset_1_receipt_no = redr[OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO].ToString(),
                        Offset_1_receipt_date = redr[OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Cheq_no = redr[OFFSET_1_RECEIPT.CHEQ_NO].ToString(),
                        Receipt_amount = redr[OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_AMOUNT].ToString(),
                        Cheq_date = redr[OFFSET_1_RECEIPT.CHEQ_DATE].ToString(),
                        Bank_id = redr[OFFSET_1_RECEIPT.BANK_ID].ToString(),
                        Total_amount = redr[OFFSET_1_RECEIPT.TOTAL_AMOUNT].ToString(),
                        Notes = redr[OFFSET_1_RECEIPT.NOTES].ToString(),
                        Active_id = redr[OFFSET_1_RECEIPT.ACTIVE_ID].ToString(),
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

         public static List<Offset_1_receipt> Unrefer(DAL DAL)
         {
            string q = " SELECT " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            // q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            //q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.LOCKED + " = '" + Core.Unlocked + "'  \r\n";

            q += " AND " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";

            q += " ORDER BY  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<Offset_1_receipt> Refer(DAL DAL)
         {
            string q = " SELECT " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<Offset_1_receipt> Showall(DAL DAL)
         {
            string q = " SELECT " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            //q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            //q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            //q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<Offset_1_receipt> Notactive(DAL DAL)
         {
            string q = " SELECT " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n"; 
            q += " ORDER BY  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static Offset_1_receipt PKId(string id, DAL DAL)
         {
            string q = " SELECT " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_ID + " = '" + id + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + ";\r\n";

             return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<Offset_1_receipt> Searchby(string no, string date, string party, DAL DAL)
         {
            string q = " SELECT " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + " = '" + no + "'\r\n";
            }
            if (date != "")
            {

                q += " AND " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " ORDER BY  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + " \r\n";
            q += " FROM  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " \r\n";
            q += " WHERE " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE + " \r\n";
            q += " FROM  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " \r\n";
            q += " WHERE " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE] + "")
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
                string q = "SELECT " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + " FROM " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "\r\n";
                q += " WHERE " + OFFSET_1_RECEIPT.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO].ToString())) + 1).ToString();
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
             Offset_1_receipt obj = PKId(Id, new DAL()); 
 
             if (obj != null) 
             { 
                 return obj.Offset_1_receipt_no; 
             } 
             return ""; 
         } 
 
         public static string GetId_Name(string No) 
         { 
             List<Offset_1_receipt> list = Searchby(No, "", "", new DAL()); 
 
             if (list.Count != 0) 
             { 
                 return list[0].Offset_1_receipt_id; 
             } 
             return ""; 
         } 
 
         #endregion[Get id - No] 
         
    }//cls
}//ns
