// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 06:41:07 AM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXCORE
{
    public static class U_Cash_payment
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = CASH_PAYMENT.CASH_PAYMENT_TBL;

                int count = GetCount(tablename, OldDB);

                for (int i = 1; i <= count; i++)
                {
                    var obj = GetOldData(i, OldDB);

                if (obj != null)
                {
                    InsertData(obj);
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

            private static Cash_payment GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + CASH_PAYMENT.CASH_PAYMENT_TBL + " WHERE " + CASH_PAYMENT.CASH_PAYMENT_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Cash_payment obj = new Cash_payment
                        {
                        Order_id = redr[CASH_PAYMENT.ORDER_ID].ToString(),
                        Payment_date = redr[CASH_PAYMENT.PAYMENT_DATE].ToString(),
                        Ledger_id = redr[CASH_PAYMENT.LEDGER_ID].ToString(),
                        Purpose = redr[CASH_PAYMENT.PURPOSE].ToString(),
                        Party_id = redr[CASH_PAYMENT.PARTY_ID].ToString(),
                        Payment_amount = ConvertTO.Decimal(redr[CASH_PAYMENT.PAYMENT_AMOUNT].ToString()),
                        Notes = redr[CASH_PAYMENT.NOTES].ToString(),
                        Active_id = redr[CASH_PAYMENT.ACTIVE_ID].ToString(),
                        User_id = "1"
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Cash_payment obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + CASH_PAYMENT.CASH_PAYMENT_TBL + " WHERE " + CASH_PAYMENT.CASH_PAYMENT_NAME + " = '" + obj.Cash_payment_name + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Cash_payment_id = redr[CASH_PAYMENT.CASH_PAYMENT_ID].ToString();

                        CCash_payment.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Cash_payment obj)
            {
                if (CheckData(obj) == false)
                {
                    CCash_payment.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
