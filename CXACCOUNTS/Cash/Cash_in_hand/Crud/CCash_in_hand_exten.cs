// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:37 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;
using CXCORE;

namespace CXACCOUNTS
{
    public class CCash_in_hand_exten
    {
         #region[Entity Data]

        private static Cash_in_hand EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Cash_in_hand obj = new Cash_in_hand()
                    {
                        Cash_in_hand_id = redr[CASH_IN_HAND.CASH_IN_HAND_ID].ToString(),
                        Entry_date = redr[CASH_IN_HAND.ENTRY_DATE].ToString(),
                        Cash_receipt_id = redr[CASH_RECEIPT.CASH_RECEIPT_ID].ToString(),
                        Cash_payment_id = redr[CASH_PAYMENT.CASH_PAYMENT_ID].ToString(),
                        Receipt_amount = ConvertTO.Decimal(redr[CASH_IN_HAND.RECEIPT_AMOUNT].ToString()),
                        Payment_amount = ConvertTO.Decimal(redr[CASH_IN_HAND.PAYMENT_AMOUNT].ToString()),
                        Balance_amount = ConvertTO.Decimal(redr[CASH_IN_HAND.BALANCE_AMOUNT].ToString()),
                        Notes = redr[CASH_IN_HAND.NOTES].ToString(),
                        Active_id = redr[CASH_IN_HAND.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Cash_in_hand();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Cash_in_hand> EntityList(string q)
         {
             List<Cash_in_hand> list = new List<Cash_in_hand>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Cash_in_hand obj = new Cash_in_hand()
                     {
                        Cash_in_hand_id = redr[CASH_IN_HAND.CASH_IN_HAND_ID].ToString(),
                        Entry_date = redr[CASH_IN_HAND.ENTRY_DATE].ToString(),
                        Cash_receipt_id = redr[CASH_RECEIPT.CASH_RECEIPT_ID].ToString(),
                        Cash_payment_id = redr[CASH_PAYMENT.CASH_PAYMENT_ID].ToString(),
                        Receipt_amount = ConvertTO.Decimal(redr[CASH_IN_HAND.RECEIPT_AMOUNT].ToString()),
                        Payment_amount = ConvertTO.Decimal(redr[CASH_IN_HAND.PAYMENT_AMOUNT].ToString()),
                        Balance_amount = ConvertTO.Decimal(redr[CASH_IN_HAND.BALANCE_AMOUNT].ToString()),
                        Notes = redr[CASH_IN_HAND.NOTES].ToString(),
                        Active_id = redr[CASH_IN_HAND.ACTIVE_ID].ToString(),
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

         public static List<Cash_in_hand> Active()
         {
            string q = " SELECT " + CASH_IN_HAND.CASH_IN_HAND_TBL + ".* \r\n";
            q += ", " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " \r\n";
            q += ", " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_IN_HAND.CASH_IN_HAND_TBL + " \r\n";
            q += " INNER JOIN  " + CASH_RECEIPT.CASH_RECEIPT_TBL + " \r\n";
            q += " ON( " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " = " + CASH_RECEIPT.CASH_RECEIPT_TBL+ "." +CASH_RECEIPT.CASH_RECEIPT_ID + ")\r\n";
            q += " INNER JOIN  " + CASH_PAYMENT.CASH_PAYMENT_TBL + " \r\n";
            q += " ON( " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " = " + CASH_PAYMENT.CASH_PAYMENT_TBL+ "." +CASH_PAYMENT.CASH_PAYMENT_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_IN_HAND.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_IN_HAND.CASH_IN_HAND_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_IN_HAND.CASH_IN_HAND_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Cash_in_hand> NotActive()
         {
            string q = " SELECT " + CASH_IN_HAND.CASH_IN_HAND_TBL + ".* \r\n";
            q += ", " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " \r\n";
            q += ", " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_IN_HAND.CASH_IN_HAND_TBL + " \r\n";
            q += " INNER JOIN  " + CASH_RECEIPT.CASH_RECEIPT_TBL + " \r\n";
            q += " ON( " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " = " + CASH_RECEIPT.CASH_RECEIPT_TBL+ "." +CASH_RECEIPT.CASH_RECEIPT_ID + ")\r\n";
            q += " INNER JOIN  " + CASH_PAYMENT.CASH_PAYMENT_TBL + " \r\n";
            q += " ON( " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " = " + CASH_PAYMENT.CASH_PAYMENT_TBL+ "." +CASH_PAYMENT.CASH_PAYMENT_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_IN_HAND.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_IN_HAND.CASH_IN_HAND_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_IN_HAND.CASH_IN_HAND_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Cash_in_hand PKId(string v)
         {
            string q = " SELECT " + CASH_IN_HAND.CASH_IN_HAND_TBL + ".* \r\n";
            q += ", " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " \r\n";
            q += ", " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_IN_HAND.CASH_IN_HAND_TBL + " \r\n";
            q += " INNER JOIN  " + CASH_RECEIPT.CASH_RECEIPT_TBL + " \r\n";
            q += " ON( " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " = " + CASH_RECEIPT.CASH_RECEIPT_TBL+ "." +CASH_RECEIPT.CASH_RECEIPT_ID + ")\r\n";
            q += " INNER JOIN  " + CASH_PAYMENT.CASH_PAYMENT_TBL + " \r\n";
            q += " ON( " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " = " + CASH_PAYMENT.CASH_PAYMENT_TBL+ "." +CASH_PAYMENT.CASH_PAYMENT_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_IN_HAND.CASH_IN_HAND_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Cash_in_hand SearchName(string v)
         {
            string q = " SELECT " + CASH_IN_HAND.CASH_IN_HAND_TBL + ".* \r\n";
            q += ", " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " \r\n";
            q += ", " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_IN_HAND.CASH_IN_HAND_TBL + " \r\n";
            q += " INNER JOIN  " + CASH_RECEIPT.CASH_RECEIPT_TBL + " \r\n";
            q += " ON( " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " = " + CASH_RECEIPT.CASH_RECEIPT_TBL+ "." +CASH_RECEIPT.CASH_RECEIPT_ID + ")\r\n";
            q += " INNER JOIN  " + CASH_PAYMENT.CASH_PAYMENT_TBL + " \r\n";
            q += " ON( " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " = " + CASH_PAYMENT.CASH_PAYMENT_TBL+ "." +CASH_PAYMENT.CASH_PAYMENT_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_IN_HAND.CASH_IN_HAND_ID + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_IN_HAND.CASH_IN_HAND_ID + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup()
         {
            string q = " SELECT " + CASH_IN_HAND.CASH_IN_HAND_TBL + ".* \r\n";
            q += ", " + CASH_RECEIPT.CASH_RECEIPT_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " \r\n";
            q += ", " + CASH_PAYMENT.CASH_PAYMENT_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CASH_IN_HAND.CASH_IN_HAND_TBL + " \r\n";
            q += " INNER JOIN  " + CASH_RECEIPT.CASH_RECEIPT_TBL + " \r\n";
            q += " ON( " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_RECEIPT.CASH_RECEIPT_ID + " = " + CASH_RECEIPT.CASH_RECEIPT_TBL+ "." +CASH_RECEIPT.CASH_RECEIPT_ID + ")\r\n";
            q += " INNER JOIN  " + CASH_PAYMENT.CASH_PAYMENT_TBL + " \r\n";
            q += " ON( " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_PAYMENT.CASH_PAYMENT_ID + " = " + CASH_PAYMENT.CASH_PAYMENT_TBL+ "." +CASH_PAYMENT.CASH_PAYMENT_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_IN_HAND.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_IN_HAND.CASH_IN_HAND_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CASH_IN_HAND.CASH_IN_HAND_TBL + "." + CASH_IN_HAND.CASH_IN_HAND_ID + ";\r\n";

             return new DAL().Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string v)
        {
            Cash_in_hand obj = PKId(v);

             if (obj != null)
            {
                return obj.Cash_in_hand_id;
            }
            return "";
        }

         public static string GetId_Name(string v)
        {
            Cash_in_hand obj = SearchName(v);

             if (obj != null)
            {
                return obj.Cash_in_hand_id;
            }
            return "";
        }

         #endregion[Get id - Name]

    }//cls
}//ns
