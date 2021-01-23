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
    public static class U_QReceipt
    {
        #region[]

        public static void GetUpdated(string OldDB)
        {

            string tablename = QRECEIPT.QRECEIPT_TBL;

            int count = GetCount(tablename, OldDB);

            for (int i = 1; i <= count; i++)
            {
                QReceipt obj = GetOldData(i, OldDB);
                List<QReceiptitems> list = GetOldItemsData(i, OldDB);

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

        private static QReceipt GetOldData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += " SELECT " + QRECEIPT.QRECEIPT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += " FROM  " + QRECEIPT.QRECEIPT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " WHERE " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_ID + "  = '" + id + "' \r\n";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    QReceipt obj = new QReceipt
                    {
                        Qreceipt_id = "",
                        Uniqueno = "",
                        Company_id = "1",
                        Acy_id = redr[QRECEIPT.COMPANY_ID].ToString(),
                        Qreceipt_no = redr[QRECEIPT.QRECEIPT_NO].ToString(),
                        Qreceipt_date = redr[QRECEIPT.QRECEIPT_DATE].ToString(),
                        Party_id = CParty_exten.GetId_Name(redr[PARTY.PARTY_NAME].ToString()),
                        Receipttype_id =CReceipttype_exten.GetId_Name(redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString()),
                        Cheq_no = redr[QRECEIPT.CHEQ_NO].ToString(),
                        Qreceipt_amount = (redr[QRECEIPT.QRECEIPT_AMOUNT].ToString()),
                        Cheq_date = redr[QRECEIPT.CHEQ_DATE].ToString(),
                        Bank_id = CBank_exten.GetId_Name(redr[BANK.BANK_NAME].ToString()),
                        Total_amount = (redr[QRECEIPT.TOTAL_AMOUNT].ToString()),
                        Notes = redr[QRECEIPT.NOTES].ToString(),
                        Active_id = redr[QRECEIPT.ACTIVE_ID].ToString(),
                        User_id = "1",
                        
                    };

                    obj.Uniqueno = obj.Acy_id + "~" + obj.Company_id + "~" + obj.Qreceipt_no;

                    return obj;
                }
                return null;
            }
        }

        #endregion[Get Old data]

        #region[Get Old items data]

        private static List<QReceiptitems> GetOldItemsData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += " SELECT " + QRECEIPTITEMS.QRECEIPTITEMS_TBL + ".* \r\n";
            q += " FROM  " + QRECEIPTITEMS.QRECEIPTITEMS_TBL + " \r\n";
            q += " WHERE " + QRECEIPTITEMS.QRECEIPTITEMS_TBL + "." + QRECEIPT.QRECEIPT_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + QRECEIPTITEMS.QRECEIPTITEMS_TBL + "." + QRECEIPTITEMS.QRECEIPTITEMS_ID + ";\r\n";

            List<QReceiptitems> list = new List<QReceiptitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    QReceiptitems obj = new QReceiptitems()
                    {
                        Qreceiptitems_id = "",
                        Qreceipt_id = "",
                        Qreceipt_by = redr[QRECEIPTITEMS.QRECEIPT_BY].ToString(),
                        Quotation_no = redr[QRECEIPTITEMS.QUOTATION_NO].ToString(),
                        Quotation_amount = ConvertTO.Decimal(redr[QRECEIPTITEMS.QUOTATION_AMOUNT].ToString()),
                        Qreceipt_amount = ConvertTO.Decimal(redr[QRECEIPTITEMS.QRECEIPT_AMOUNT].ToString()),
                    };

                    list.Add(obj);
                }

                return list;
            }
        }

        #endregion[Get Old data]

        #region[Check data]

        private static bool CheckData(QReceipt obj)
        {
            string q = "USE CODEXSUN_DB; ";
            q += "SELECT * FROM " + QRECEIPT.QRECEIPT_TBL + " WHERE " + QRECEIPT.UNIQUENO + " = '" + obj.Uniqueno + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    obj.Qreceipt_id = redr[QRECEIPT.QRECEIPT_ID].ToString();

                    //CQReceipt.Update(obj, new DAL());

                    MessageBox.Show("err");

                    return true;
                }
                return false;
            }
        }
        #endregion[Check data]

        #region[Insert data]

        private static void InsertData(QReceipt obj, List<QReceiptitems> items)
        {
            DAL dalsession;

            try
            {
                dalsession = new DAL();
                dalsession.BeginTransaction();

                List<QReceiptitems> list_new = new List<QReceiptitems>();
                if (obj != null)
                {
                    if (CheckData(obj) != true)
                    {
                        CQreceipt.Insert(obj, dalsession);
                        var vId = DAL.GetIdentity(dalsession);

                        for (int k = 0; k < items.Count; k++)
                        {
                            QReceiptitems v = new QReceiptitems()
                            {
                                Qreceipt_id = vId,
                                Qreceipt_by = items[k].Qreceipt_by,
                                Quotation_no = items[k].Quotation_no,
                                Quotation_amount = items[k].Quotation_amount,
                                Qreceipt_amount = items[k].Qreceipt_amount
                            };
                            list_new.Add(v);
                        }

                        CQreceiptitems.Insert(list_new, dalsession);
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
