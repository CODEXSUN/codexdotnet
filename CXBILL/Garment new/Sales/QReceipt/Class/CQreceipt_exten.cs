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
    public class CQreceipt_exten
    {
         #region[Entity Data]

        private static QReceipt EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    QReceipt obj = new QReceipt()
                    {
                        Qreceipt_id = redr[QRECEIPT.QRECEIPT_ID].ToString(),
                        Qreceipt_no = redr[QRECEIPT.QRECEIPT_NO].ToString(),
                        Qreceipt_date = redr[QRECEIPT.QRECEIPT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Cheq_no = redr[QRECEIPT.CHEQ_NO].ToString(),
                        Qreceipt_amount = redr[QRECEIPT.QRECEIPT_AMOUNT].ToString(),
                        Cheq_date = redr[QRECEIPT.CHEQ_DATE].ToString(),
                        Bank_id = redr[BANK.BANK_NAME].ToString(),
                        Total_amount = redr[QRECEIPT.TOTAL_AMOUNT].ToString(),
                        Notes = redr[QRECEIPT.NOTES].ToString(),
                        Active_id = redr[QRECEIPT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new QReceipt();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<QReceipt> EntityList(string q)
         {
             List<QReceipt> list = new List<QReceipt>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      QReceipt obj = new QReceipt()
                     {
                        Qreceipt_id = redr[QRECEIPT.QRECEIPT_ID].ToString(),
                        Qreceipt_no = redr[QRECEIPT.QRECEIPT_NO].ToString(),
                        Qreceipt_date = redr[QRECEIPT.QRECEIPT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Cheq_no = redr[QRECEIPT.CHEQ_NO].ToString(),
                        Qreceipt_amount = redr[QRECEIPT.QRECEIPT_AMOUNT].ToString(),
                        Cheq_date = redr[QRECEIPT.CHEQ_DATE].ToString(),
                        Bank_id = redr[QRECEIPT.BANK_ID].ToString(),
                        Total_amount = redr[QRECEIPT.TOTAL_AMOUNT].ToString(),
                        Notes = redr[QRECEIPT.NOTES].ToString(),
                        Active_id = redr[QRECEIPT.ACTIVE_ID].ToString(),
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

         public static List<QReceipt> Unrefer(DAL DAL)
         {
            string q = " SELECT " + QRECEIPT.QRECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + QRECEIPT.QRECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
           // q += " AND NOT " + QRECEIPT.RECEIPT_TBL + "." + QRECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<QReceipt> Refer(DAL DAL)
         {
            string q = " SELECT " + QRECEIPT.QRECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + QRECEIPT.QRECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + QRECEIPT.RECEIPT_TBL + "." + QRECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            //q += " AND NOT " + QRECEIPT.RECEIPT_TBL + "." + QRECEIPT.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<QReceipt> Showall(DAL DAL)
         {
            string q = " SELECT " + QRECEIPT.QRECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + QRECEIPT.QRECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + QRECEIPT.RECEIPT_TBL + "." + QRECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<QReceipt> Notactive(DAL DAL)
         {
            string q = " SELECT " + QRECEIPT.QRECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + QRECEIPT.QRECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + QRECEIPT.RECEIPT_TBL + "." + QRECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static QReceipt PKId(string id, DAL DAL)
         {
            string q = " SELECT " + QRECEIPT.QRECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + QRECEIPT.QRECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_ID + " = '" + id + "' \r\n";
            //q += " AND NOT " + QRECEIPT.RECEIPT_TBL + "." + QRECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_NO + ";\r\n";

             return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<QReceipt> Searchby(string no, string date, string party, DAL DAL)
         {
            string q = " SELECT " + QRECEIPT.QRECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + QRECEIPT.QRECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + QRECEIPT.RECEIPT_TBL + "." + QRECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_NO + " = '" + no + "'\r\n";
            }
            if (date != "")
            {

                q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_NO + " \r\n";
            q += " FROM  " + QRECEIPT.QRECEIPT_TBL + " \r\n";
            q += " WHERE " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + QRECEIPT.RECEIPT_TBL + "." + QRECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + QRECEIPT.QRECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + QRECEIPT.RECEIPT_TBL + "." + QRECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_DATE + " \r\n";
            q += " FROM  " + QRECEIPT.QRECEIPT_TBL + " \r\n";
            q += " WHERE " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + QRECEIPT.RECEIPT_TBL + "." + QRECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(QRECEIPT.QRECEIPT_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][QRECEIPT.QRECEIPT_DATE] + "")
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
                string q = "SELECT " + QRECEIPT.QRECEIPT_NO + " FROM " + QRECEIPT.QRECEIPT_TBL + "\r\n";
                q += " WHERE " + QRECEIPT.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
                q += " ORDER BY " + QRECEIPT.QRECEIPT_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[QRECEIPT.QRECEIPT_NO].ToString())) + 1).ToString();
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
             QReceipt obj = PKId(Id, new DAL()); 
 
             if (obj != null) 
             { 
                 return obj.Qreceipt_no; 
             } 
             return ""; 
         } 
 
         public static string GetId_Name(string No) 
         { 
             List<QReceipt> list = Searchby(No, "", "", new DAL()); 
 
             if (list.Count != 0) 
             { 
                 return list[0].Qreceipt_id; 
             } 
             return ""; 
         } 
 
         #endregion[Get id - No] 
         
    }//cls
}//ns
