// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:47 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;
using CXCORE;

namespace CXACCOUNTS
{
    public class CCash_receipt_exten
    {
         #region[Entity Data]

        private static Cash_receipt EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Cash_receipt obj = new Cash_receipt()
                    {
                        Cash_receipt_id = redr[CASH_RECEIPT.CASH_RECEIPT_ID].ToString(),
                        Receipt_date = redr[CASH_RECEIPT.RECEIPT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Purpose = redr[CASH_RECEIPT.PURPOSE].ToString(),
                        Receipt_amount = ConvertTO.Decimal(redr[CASH_RECEIPT.RECEIPT_AMOUNT].ToString()),
                        Notes = redr[CASH_RECEIPT.NOTES].ToString(),
                        Active_id = redr[CASH_RECEIPT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Cash_receipt();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Cash_receipt> EntityList(string q)
         {
             List<Cash_receipt> list = new List<Cash_receipt>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Cash_receipt obj = new Cash_receipt()
                     {
                        Cash_receipt_id = redr[CASH_RECEIPT.CASH_RECEIPT_ID].ToString(),
                        Receipt_date = redr[CASH_RECEIPT.RECEIPT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Purpose = redr[CASH_RECEIPT.PURPOSE].ToString(),
                        Receipt_amount = ConvertTO.Decimal(redr[CASH_RECEIPT.RECEIPT_AMOUNT].ToString()),
                        Notes = redr[CASH_RECEIPT.NOTES].ToString(),
                        Active_id = redr[CASH_RECEIPT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                     };

                     list.Add(obj);
                 }

             redr.Close();
             }
             return list;
         }

         #endregion[Entity List]

         #region[Active]

         public static List<Cash_receipt> Active()
         {
            string q = " SELECT " + CASH_RECEIPT.CASH_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_RECEIPT.CASH_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL+ "." +PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Cash_receipt> NotActive()
         {
            string q = " SELECT " + CASH_RECEIPT.CASH_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_RECEIPT.CASH_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL+ "." +PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Cash_receipt PKId(string v)
         {
            string q = " SELECT " + CASH_RECEIPT.CASH_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_RECEIPT.CASH_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL+ "." +PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Cash_receipt SearchName(string v)
         {
            string q = " SELECT " + CASH_RECEIPT.CASH_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_RECEIPT.CASH_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL+ "." +PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup()
         {
            string q = " SELECT " + CASH_RECEIPT.CASH_RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_RECEIPT.CASH_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL+ "." +PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + ";\r\n";

             return new DAL().Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string v)
        {
            Cash_receipt obj = PKId(v);

             if (obj != null)
            {
                return obj.Cash_receipt_id;
            }
            return "";
        }

         public static string GetId_Name(string v)
        {
            Cash_receipt obj = SearchName(v);

             if (obj != null)
            {
                return obj.Cash_receipt_id;
            }
            return "";
        }

         #endregion[Get id - Name]

    }//cls
}//ns
