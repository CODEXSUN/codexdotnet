// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXCORE
{
    public static class U_Seq
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = SEQ.SEQ_TBL;

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

            private static Seq GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + SEQ.SEQ_TBL + " WHERE " + SEQ.SEQ_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Seq obj = new Seq
                        {
                        Seq_no = redr[SEQ.SEQ_NO].ToString(),
                        Comp_code = ConvertTO.Integer(redr[SEQ.COMP_CODE].ToString()),
                        Order_no = ConvertTO.Integer(redr[SEQ.ORDER_NO].ToString()),
                        Dc_no = ConvertTO.Integer(redr[SEQ.DC_NO].ToString()),
                        Po_no = ConvertTO.Integer(redr[SEQ.PO_NO].ToString()),
                        Inv_no = ConvertTO.Integer(redr[SEQ.INV_NO].ToString()),
                        Receipt_no = ConvertTO.Integer(redr[SEQ.RECEIPT_NO].ToString()),
                        Quotation_no = ConvertTO.Integer(redr[SEQ.QUOTATION_NO].ToString()),
                        Qreceipt_no = ConvertTO.Integer(redr[SEQ.QRECEIPT_NO].ToString()),
                        Purchase_no = ConvertTO.Integer(redr[SEQ.PURCHASE_NO].ToString()),
                        Payment_no = ConvertTO.Integer(redr[SEQ.PAYMENT_NO].ToString()),
                        Cashbook_no = ConvertTO.Integer(redr[SEQ.CASHBOOK_NO].ToString()),
                        Bankbook_no = ConvertTO.Integer(redr[SEQ.BANKBOOK_NO].ToString()),
                        Notes = redr[SEQ.NOTES].ToString(),
                        Active_id = redr[SEQ.ACTIVE_ID].ToString(),
                        User_id = "1"
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Seq obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + SEQ.SEQ_TBL + " WHERE " + SEQ.SEQ_NAME + " = '" + obj.Seq_name + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Seq_id = redr[SEQ.SEQ_ID].ToString();

                        CSeq.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Seq obj)
            {
                if (CheckData(obj) == false)
                {
                    CSeq.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
