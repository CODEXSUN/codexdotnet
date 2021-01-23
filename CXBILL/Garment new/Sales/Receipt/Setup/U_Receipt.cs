// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CXBILL
{
    public static class U_Receipt
    {
        #region[]

        public static void GetUpdated(string OldDB)
        {

            string tablename = RECEIPT.RECEIPT_TBL;

            int count = GetCount(tablename, OldDB);

            for (int i = 1; i <= count; i++)
            {
                Receipt obj = GetOldData(i, OldDB);
                List<Receiptitems> list = GetOldItemsData(i, OldDB);

                if (obj != null)
                {
                    InsertData(obj, list);
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

        private static Receipt GetOldData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += " SELECT " + RECEIPT.RECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += " FROM  " + RECEIPT.RECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + RECEIPT.RECEIPT_TBL + "." + RECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " WHERE " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID + "  = '" + id + "' \r\n";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Receipt obj = new Receipt
                    {
                        Receipt_id = "",
                        Uniqueno = "",
                        Company_id = "1",
                        Acy_id = redr[RECEIPT.ACY_ID].ToString(),
                        Receipt_no = redr[RECEIPT.RECEIPT_NO].ToString(),
                        Receipt_date = redr[RECEIPT.RECEIPT_DATE].ToString(),
                        Party_id = CParty_exten.GetId_Name(redr[PARTY.PARTY_NAME].ToString()),
                        Receipttype_id = CReceipttype_exten.GetId_Name(redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString()),
                        Cheq_no = redr[RECEIPT.CHEQ_NO].ToString(),
                        Receipt_amount = ConvertTO.Decimal(redr[RECEIPT.RECEIPT_AMOUNT].ToString()),
                        Cheq_date = redr[RECEIPT.CHEQ_DATE].ToString(),
                        Bank_id = CBank_exten.GetId_Name(redr[BANK.BANK_NAME].ToString()),
                        Total_amount = ConvertTO.Decimal(redr[RECEIPT.TOTAL_AMOUNT].ToString()),
                        Notes = redr[RECEIPT.NOTES].ToString(),
                        Active_id = redr[RECEIPT.ACTIVE_ID].ToString(),
                        User_id = "1",

                    };

                    obj.Uniqueno = obj.Acy_id + "~" + obj.Company_id + "~" + obj.Receipt_no;

                    return obj;
                }
                return null;
            }
        }

        #endregion[Get Old data]

        #region[Get Old items data]

        private static List<Receiptitems> GetOldItemsData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += " SELECT " + RECEIPTITEMS.RECEIPTITEMS_TBL + ".* \r\n";
            q += " FROM  " + RECEIPTITEMS.RECEIPTITEMS_TBL + " \r\n";
            q += " WHERE " + RECEIPTITEMS.RECEIPTITEMS_TBL + "." + RECEIPT.RECEIPT_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + RECEIPTITEMS.RECEIPTITEMS_TBL + "." + RECEIPTITEMS.RECEIPTITEMS_ID + ";\r\n";

            List<Receiptitems> list = new List<Receiptitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Receiptitems obj = new Receiptitems()
                    {
                        Receiptitems_id = "",
                        Receipt_id = "",
                        Receipt_by = redr[RECEIPTITEMS.RECEIPT_BY].ToString(),
                        Invoiced_no = redr[RECEIPTITEMS.INVOICED_NO].ToString(),
                        Invoiced_amount = redr[RECEIPTITEMS.INVOICED_AMOUNT].ToString(),
                        Receipt_amount = ConvertTO.Decimal(redr[RECEIPTITEMS.RECEIPT_AMOUNT].ToString()),
                    };

                    list.Add(obj);
                }

                return list;
            }
        }

        #endregion[Get Old data]

        #region[Check data]

        private static bool CheckData(Receipt obj)
        {
            string q = "USE CODEXSUN_DB; ";
            q += "SELECT * FROM " + RECEIPT.RECEIPT_TBL + " WHERE " + RECEIPT.UNIQUENO + " = '" + obj.Uniqueno + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    obj.Receipt_id = redr[RECEIPT.RECEIPT_ID].ToString();

                    //CReceipt.Update(obj, new DAL());

                    MessageBox.Show("err");

                    return true;
                }
                return false;
            }
        }
        #endregion[Check data]

        #region[Insert data]

        private static void InsertData(Receipt obj, List<Receiptitems> items)
        {
            DAL dalsession;

            try
            {
                dalsession = new DAL();
                dalsession.BeginTransaction();

                List<Receiptitems> list_new = new List<Receiptitems>();
                if (obj != null)
                {
                    if (CheckData(obj) != true)
                    {
                        CReceipt.Insert(obj, dalsession);
                        var vId = DAL.GetIdentity(dalsession);

                        for (int k = 0; k < items.Count; k++)
                        {
                            Receiptitems v = new Receiptitems()
                            {
                                Receipt_id = vId,
                                Receipt_by = items[k].Receipt_by,
                                Invoiced_no = items[k].Invoiced_no,
                                Invoiced_amount = items[k].Invoiced_amount,
                                Receipt_amount = items[k].Receipt_amount
                            };
                            list_new.Add(v);
                        }

                        CReceiptitems.Insert(list_new, dalsession);
                        dalsession.Commit();
                    }
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("error : " + ex);
            }

        }

        #endregion[Insert data]

    }//cls
}//ns
