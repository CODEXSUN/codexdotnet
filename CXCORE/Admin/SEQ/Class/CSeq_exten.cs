// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 14-07-2020 07:57:11 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;
using System;

namespace CXCORE
{
    public class CSeq_exten
    {
         #region[Entity Data]

        private static Seq EntityData(string q,DAL dal)
        {
            using (IDataReader redr = dal.Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Seq obj = new Seq()
                    {
                        Seq_id = redr[SEQ.SEQ_ID].ToString(),
                        Seq_no = ConvertTO.Integer(redr[SEQ.SEQ_NO].ToString()),
                        Comp_code = ConvertTO.Integer(redr[SEQ.COMP_CODE].ToString()),
                        Dc_no = ConvertTO.Integer(redr[SEQ.DC_NO].ToString()),
                        Po_no = ConvertTO.Integer(redr[SEQ.PO_NO].ToString()),
                        Inv_no = ConvertTO.Integer(redr[SEQ.INV_NO].ToString()),
                        Receipt_no = ConvertTO.Integer(redr[SEQ.RECEIPT_NO].ToString()),
                        Purchase_no = ConvertTO.Integer(redr[SEQ.PURCHASE_NO].ToString()),
                        Payment_no = ConvertTO.Integer(redr[SEQ.PAYMENT_NO].ToString()),
                        Cashbook_no = ConvertTO.Integer(redr[SEQ.CASHBOOK_NO].ToString()),
                        Bankbook_no = ConvertTO.Integer(redr[SEQ.BANKBOOK_NO].ToString()),
                        };
                    return obj;
                 }
            redr.Close();
            return new Seq();
            }
        }

        #endregion[Entity Data]

        public static string GetNextNo(string v,DAL dal)
        {
            string q = " SELECT  * FROM " + SEQ.SEQ_TBL + "\r\n";
            q += " WHERE " + SEQ.SEQ_TBL + "." + SEQ.SEQ_ID + "  = '1'; \r\n";

            Seq obj = EntityData(q,dal);

            if (obj != null)
            {
                switch (v) 
                {
                    case SEQ.PO_NO:
                        return obj.Po_no.ToString();
                    case SEQ.DC_NO:
                        return obj.Dc_no.ToString();
                    case SEQ.INV_NO:
                        return obj.Inv_no.ToString();
                    case SEQ.RECEIPT_NO:
                        return obj.Receipt_no.ToString();
                    case SEQ.PURCHASE_NO:
                        return obj.Purchase_no.ToString();
                    case SEQ.PAYMENT_NO:
                        return obj.Payment_no.ToString();
                    case SEQ.QUOTATION_NO:
                        return obj.Payment_no.ToString();
                    case SEQ.QRECEIPT_NO:
                        return obj.Payment_no.ToString();
                } 
            }
            return "0";
        }

        public static void UpdateNextNo(string v, DAL dalsession) 
        {
            if (v.Length != 0)
            {
                string q = "UPDATE " + SEQ.SEQ_TBL + " SET";

                switch (v)
                {

                    case SEQ.PO_NO:
                        q += " " + SEQ.PO_NO + " = " + SEQ.PO_NO + " +1 \r\n ";
                        break;
                    case SEQ.DC_NO:
                        q += " " + SEQ.DC_NO + " = " + SEQ.DC_NO + " +1 \r\n ";
                        break;
                    case SEQ.INV_NO:
                        q += " " + SEQ.INV_NO + " = " + SEQ.INV_NO + " +1 \r\n ";
                        break;
                    case SEQ.RECEIPT_NO:
                        q += " " + SEQ.RECEIPT_NO + " = " + SEQ.RECEIPT_NO + " +1 \r\n ";
                        break;
                    case SEQ.QUOTATION_NO:
                        q += " " + SEQ.QUOTATION_NO + " = " + SEQ.QUOTATION_NO + " +1 \r\n ";
                        break;
                    case SEQ.QRECEIPT_NO:
                        q += " " + SEQ.QRECEIPT_NO + " = " + SEQ.QRECEIPT_NO + " +1 \r\n ";
                        break;
                }

                q += "  WHERE " + SEQ.SEQ_ID + " = '1'";

                dalsession.Execute(q);
            }
        }

    }//cls
}//ns
