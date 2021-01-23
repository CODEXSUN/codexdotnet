// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 14-07-2020 10:01:13 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class CReceipt_exten
    {
         #region[Entity Data]

        private static Receipt EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Receipt obj = new Receipt()
                    {
                        Receipt_id = redr[RECEIPT.RECEIPT_ID].ToString(),
                        Uniqueno = redr[RECEIPT.UNIQUENO].ToString(),
                        Company_id = redr[RECEIPT.COMPANY_ID].ToString(),
                        Acy_id = redr[RECEIPT.ACY_ID].ToString(),
                        Receipt_no = redr[RECEIPT.RECEIPT_NO].ToString(),
                        Receipt_date = redr[RECEIPT.RECEIPT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Cheq_no = redr[RECEIPT.CHEQ_NO].ToString(),
                        Receipt_amount = ConvertTO.Decimal(redr[RECEIPT.RECEIPT_AMOUNT].ToString()),
                        Cheq_date = redr[RECEIPT.CHEQ_DATE].ToString(),
                        Bank_id = redr[BANK.BANK_NAME].ToString(),
                        Total_amount = ConvertTO.Decimal(redr[RECEIPT.TOTAL_AMOUNT].ToString()),
                        Notes = redr[RECEIPT.NOTES].ToString(),
                        Active_id = redr[RECEIPT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Receipt();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Receipt> EntityList(string q)
         {
             List<Receipt> list = new List<Receipt>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Receipt obj = new Receipt()
                     {
                        Receipt_id = redr[RECEIPT.RECEIPT_ID].ToString(),
                        Uniqueno = redr[RECEIPT.UNIQUENO].ToString(),
                        Company_id = redr[RECEIPT.COMPANY_ID].ToString(),
                        Acy_id = redr[RECEIPT.ACY_ID].ToString(),
                        Receipt_no = redr[RECEIPT.RECEIPT_NO].ToString(),
                        Receipt_date = redr[RECEIPT.RECEIPT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Cheq_no = redr[RECEIPT.CHEQ_NO].ToString(),
                        Receipt_amount = ConvertTO.Decimal(redr[RECEIPT.RECEIPT_AMOUNT].ToString()),
                        Cheq_date = redr[RECEIPT.CHEQ_DATE].ToString(),
                        Bank_id = redr[BANK.BANK_NAME].ToString(),
                        Total_amount = ConvertTO.Decimal(redr[RECEIPT.TOTAL_AMOUNT].ToString()),
                        Notes = redr[RECEIPT.NOTES].ToString(),
                        Active_id = redr[RECEIPT.ACTIVE_ID].ToString(),
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

         public static List<Receipt> Unrefer()
         {
            string q = " SELECT " + RECEIPT.RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + RECEIPT.RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            //q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<Receipt> Refer()
         {
            string q = " SELECT " + RECEIPT.RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + RECEIPT.RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            //q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<Receipt> Showall()
         {
            string q = " SELECT " + RECEIPT.RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + RECEIPT.RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<Receipt> Notactive()
         {
            string q = " SELECT " + RECEIPT.RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + RECEIPT.RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static Receipt PKId(string id)
         {
            string q = " SELECT " + RECEIPT.RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + RECEIPT.RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + id + "' \r\n";
            q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
                        q += " ORDER BY  " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_NO + ";\r\n";

             return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<Receipt> Searchby(string no, string date, string dateTo, string party)
         {
            string q = " SELECT " + RECEIPT.RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + RECEIPT.RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_NO + " = '" + no + "'\r\n";
            }
            if (dateTo != "")
            {
                q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_DATE + "  BETWEEN " + ConvertTO.SqlDate(date) + " AND " + ConvertTO.SqlDate(dateTo) + "\r\n";
            }
            else if (date != "")
            {

                q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_NO + " \r\n";
            q += " FROM  " + RECEIPT.RECEIPT_TBL + " \r\n";
            q += " WHERE " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        public static DataTable LookupParty()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + RECEIPT.RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        public static DataTable LookupDate()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_DATE + " \r\n";
            q += " FROM  " + RECEIPT.RECEIPT_TBL + " \r\n";
            q += " WHERE " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_NO + ";\r\n";

            DataTable xtbl = new DAL().Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(RECEIPT.RECEIPT_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][RECEIPT.RECEIPT_DATE] + "")
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
                string q = "SELECT " + RECEIPT.RECEIPT_NO + " FROM " + RECEIPT.RECEIPT_TBL + "\r\n";
                q += " WHERE " + RECEIPT.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " AND " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
                q += " ORDER BY " + RECEIPT.RECEIPT_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[RECEIPT.RECEIPT_NO].ToString())) + 1).ToString();
                    }
                     redr.Close();
                    return Core.One;
                }
            }
        }

        #endregion[GetNext_No]

        #region[Lock Status]

        public static bool LockStatus(string pkValue)
        {
            if (pkValue != null)
            {
                //Receipt obj = PKId(pkValue);
                //if (obj.Locked == Core.Unlocked)
                //{
                //    return false;
                //}
            }
            return true;
        }

        #endregion[Lock Status]

        #region[Get id - FieldsName]

         public static string GetName_Id(string _pId)
        {
            Receipt obj = PKId(_pId);

             if (obj != null)
            {
                return obj.Receipt_no;
            }
            return "";
        }

         public static string GetId_Name(string _pName)
        {
            var list = Searchby("","","",_pName);

             if (list.Count != 0)
            {
                return list[0].Receipt_id;
            }
            return "";
        }

         #endregion[Get id - FieldsName]

    }//cls
}//ns
