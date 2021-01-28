// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 06:41:06 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;
using CXCORE;
using CXBILL;
using CXERP;

namespace CXACCOUNTS
{
    public class CCash_payment_exten
    {
         #region[Entity Data]

        private static Cash_payment EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Cash_payment obj = new Cash_payment()
                    {
                        Cash_payment_id = redr[CASH_PAYMENT.CASH_PAYMENT_ID].ToString(),
                        Order_id = redr[ORDER.ORDER_NO].ToString(),
                        Payment_date = redr[CASH_PAYMENT.PAYMENT_DATE].ToString(),
                        Ledger_id = redr[LEDGER.LEDGER_NAME].ToString(),
                        Purpose = redr[CASH_PAYMENT.PURPOSE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Payment_amount = ConvertTO.Decimal(redr[CASH_PAYMENT.PAYMENT_AMOUNT].ToString()),
                        Notes = redr[CASH_PAYMENT.NOTES].ToString(),
                        Active_id = redr[CASH_PAYMENT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Cash_payment();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Cash_payment> EntityList(string q)
         {
             List<Cash_payment> list = new List<Cash_payment>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Cash_payment obj = new Cash_payment()
                     {
                        Cash_payment_id = redr[CASH_PAYMENT.CASH_PAYMENT_ID].ToString(),
                        Order_id = redr[ORDER.ORDER_NO].ToString(),
                        Payment_date = redr[CASH_PAYMENT.PAYMENT_DATE].ToString(),
                        Ledger_id = redr[LEDGER.LEDGER_NAME].ToString(),
                        Purpose = redr[CASH_PAYMENT.PURPOSE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Payment_amount = ConvertTO.Decimal(redr[CASH_PAYMENT.PAYMENT_AMOUNT].ToString()),
                        Notes = redr[CASH_PAYMENT.NOTES].ToString(),
                        Active_id = redr[CASH_PAYMENT.ACTIVE_ID].ToString(),
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

         public static List<Cash_payment> Active()
         {
            string q = " SELECT " + CASH_PAYMENT.CASH_PAYMENT_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_PAYMENT.CASH_PAYMENT_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + ORDER.ORDER_ID + " = " + ORDER.ORDER_TBL+ "." +ORDER.ORDER_ID + ")\r\n";
            q += " INNER JOIN  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + LEDGER.LEDGER_ID + " = " + LEDGER.LEDGER_TBL+ "." +LEDGER.LEDGER_ID + ")\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL+ "." +PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Cash_payment> NotActive()
         {
            string q = " SELECT " + CASH_PAYMENT.CASH_PAYMENT_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_PAYMENT.CASH_PAYMENT_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + ORDER.ORDER_ID + " = " + ORDER.ORDER_TBL+ "." +ORDER.ORDER_ID + ")\r\n";
            q += " INNER JOIN  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + LEDGER.LEDGER_ID + " = " + LEDGER.LEDGER_TBL+ "." +LEDGER.LEDGER_ID + ")\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL+ "." +PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Cash_payment PKId(string v)
         {
            string q = " SELECT " + CASH_PAYMENT.CASH_PAYMENT_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_PAYMENT.CASH_PAYMENT_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + ORDER.ORDER_ID + " = " + ORDER.ORDER_TBL+ "." +ORDER.ORDER_ID + ")\r\n";
            q += " INNER JOIN  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + LEDGER.LEDGER_ID + " = " + LEDGER.LEDGER_TBL+ "." +LEDGER.LEDGER_ID + ")\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL+ "." +PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Cash_payment SearchName(string v)
         {
            string q = " SELECT " + CASH_PAYMENT.CASH_PAYMENT_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_PAYMENT.CASH_PAYMENT_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + ORDER.ORDER_ID + " = " + ORDER.ORDER_TBL+ "." +ORDER.ORDER_ID + ")\r\n";
            q += " INNER JOIN  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + LEDGER.LEDGER_ID + " = " + LEDGER.LEDGER_TBL+ "." +LEDGER.LEDGER_ID + ")\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL+ "." +PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup()
         {
            string q = " SELECT " + CASH_PAYMENT.CASH_PAYMENT_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_PAYMENT.CASH_PAYMENT_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + ORDER.ORDER_ID + " = " + ORDER.ORDER_TBL+ "." +ORDER.ORDER_ID + ")\r\n";
            q += " INNER JOIN  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + LEDGER.LEDGER_ID + " = " + LEDGER.LEDGER_TBL+ "." +LEDGER.LEDGER_ID + ")\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL+ "." +PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + ";\r\n";

             return new DAL().Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string v)
        {
            Cash_payment obj = PKId(v);

             if (obj != null)
            {
                return obj.Cash_payment_id;
            }
            return "";
        }

         public static string GetId_Name(string v)
        {
            Cash_payment obj = SearchName(v);

             if (obj != null)
            {
                return obj.Cash_payment_id;
            }
            return "";
        }

         #endregion[Get id - Name]

    }//cls
}//ns
