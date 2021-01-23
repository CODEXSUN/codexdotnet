// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:47 PM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXACCOUNTS
{
    public static class U_Cash_receipt
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = CASH_RECEIPT.CASH_RECEIPT_TBL;

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

            private static Cash_receipt GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + CASH_RECEIPT.CASH_RECEIPT_TBL + " WHERE " + CASH_RECEIPT.CASH_RECEIPT_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Cash_receipt obj = new Cash_receipt
                        {
                        Receipt_date = redr[CASH_RECEIPT.RECEIPT_DATE].ToString(),
                        Party_id = redr[CASH_RECEIPT.PARTY_ID].ToString(),
                        Purpose = redr[CASH_RECEIPT.PURPOSE].ToString(),
                        Receipt_amount = ConvertTO.Decimal(redr[CASH_RECEIPT.RECEIPT_AMOUNT].ToString()),
                        Notes = redr[CASH_RECEIPT.NOTES].ToString(),
                        Active_id = redr[CASH_RECEIPT.ACTIVE_ID].ToString(),
                        User_id = "1"
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Cash_receipt obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + CASH_RECEIPT.CASH_RECEIPT_TBL + " WHERE " + CASH_RECEIPT.CASH_RECEIPT_NAME + " = '" + obj.Cash_receipt_name + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Cash_receipt_id = redr[CASH_RECEIPT.CASH_RECEIPT_ID].ToString();

                        CCash_receipt.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Cash_receipt obj)
            {
                if (CheckData(obj) == false)
                {
                    CCash_receipt.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
