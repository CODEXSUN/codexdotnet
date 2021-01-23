// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:38 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;

namespace CXACCOUNTS
{
    public static class U_Cash_in_hand
    {
        #region[]

        public static void GetUpdated(string OldDB)
        {

            string tablename = CASH_IN_HAND.CASH_IN_HAND_TBL;

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

        private static Cash_in_hand GetOldData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += "SELECT * FROM " + CASH_IN_HAND.CASH_IN_HAND_TBL + " WHERE " + CASH_IN_HAND.CASH_IN_HAND_ID + " = '" + id + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Cash_in_hand obj = new Cash_in_hand
                    {
                        Entry_date = redr[CASH_IN_HAND.ENTRY_DATE].ToString(),
                        Cash_receipt_id = redr[CASH_IN_HAND.CASH_RECEIPT_ID].ToString(),
                        Cash_payment_id = redr[CASH_IN_HAND.CASH_PAYMENT_ID].ToString(),
                        Receipt_amount = ConvertTO.Decimal(redr[CASH_IN_HAND.RECEIPT_AMOUNT].ToString()),
                        Payment_amount = ConvertTO.Decimal(redr[CASH_IN_HAND.PAYMENT_AMOUNT].ToString()),
                        Balance_amount = ConvertTO.Decimal(redr[CASH_IN_HAND.BALANCE_AMOUNT].ToString()),
                        Notes = redr[CASH_IN_HAND.NOTES].ToString(),
                        Active_id = redr[CASH_IN_HAND.ACTIVE_ID].ToString(),
                        User_id = "1"
                    };

                    return obj;
                }
                return null;
            }
        }

        #endregion[Get Old data]

        #region[Check data]

        private static bool CheckData(Cash_in_hand obj)
        {
            string q = "USE CODEXSUN_DB; ";
            q += "SELECT * FROM " + CASH_IN_HAND.CASH_IN_HAND_TBL + " WHERE " + CASH_IN_HAND.CASH_IN_HAND_ID + " = '" + obj.Cash_in_hand_id + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    obj.Cash_in_hand_id = redr[CASH_IN_HAND.CASH_IN_HAND_ID].ToString();

                    CCash_in_hand.Update(obj, new DAL());

                    return true;
                }
                return false;
            }
        }
        #endregion[Check data]

        #region[Insert data]

        private static void InsertData(Cash_in_hand obj)
        {
            if (CheckData(obj) == false)
            {
                CCash_in_hand.Insert(obj, new DAL());
            };

        }
        #endregion[Insert data]

    }//cls
}//ns
