using CXLIB;
using System;
using System.Collections.Generic;
using System.Data;
using CXCORE;
using System.Diagnostics;
using CXOFFSET_1;

namespace CXBILL
{
    public class RcPartystatement
    {

        #region[Statement]
        public static List<Statement> Statement(string party_id, string fromDt, string toDt, string vouchertype)
        {
            List<Statement> list = new List<Statement>();

            string q = StatementQuery(party_id, fromDt, toDt, vouchertype);


            int sl = 0; decimal sa = 0M; decimal re = 0M;


            decimal vopening = 0M;

            if (fromDt != "")
            {
                vopening = Getopening(party_id, fromDt);
            }

            using (IDataReader redr = new DAL().Listreader(q))
            {

                while (redr.Read() == true)
                {

                    Statement obj = new Statement()
                    {
                        Sno = sl++,
                        Vno = redr[STATEMENT.SNO].ToString(),
                        Sdate = ConvertTO.Date2S(redr[STATEMENT.SDATE].ToString()),
                        S2date = ConvertTO.DDate(redr[STATEMENT.SDATE].ToString()),
                        Stype = redr[STATEMENT.STYPE].ToString(),
                        Cheque = redr[STATEMENT.CHEQUE].ToString(),
                        Sales_amount = ConvertTO.Decimal(redr[STATEMENT.SALES_AMOUNT]),
                        Receipt_amount = ConvertTO.Decimal(redr[STATEMENT.RECEIPT_AMOUNT]),
                        Party = redr[STATEMENT.PARTY].ToString(),
                        Opening = ConvertTO.Decimal(redr[STATEMENT.OPENING_BALANCE].ToString())
                    };

                    if (fromDt != "")
                    {
                        obj.Opening = vopening;
                    }

                    sa += ConvertTO.Decimal(redr[STATEMENT.SALES_AMOUNT]);
                    re += ConvertTO.Decimal(redr[STATEMENT.RECEIPT_AMOUNT]);

                    obj.Balance_amount = (sa + obj.Opening) - re;

                    list.Add(obj);

                    if ((fromDt != "") && (toDt != ""))
                    {
                        list[0].Stmdate = "Statement  " + fromDt + "  to  " + toDt;
                    }
                    else
                    {
                        if (list.Count != 0)
                        {
                            list[0].Stmdate = "Statement  " + list[0].Sdate + "  to  " + list[list.Count - 1].Sdate;
                        }
                    }
                }
            }

            return list;
        }

        #endregion[Statement]

        #region[Statment Query]

        private static string StatementQuery(string party_id, string fromDt, string toDt, string vouchertype)
        {

            String q = " SELECT \r\n";
            q += " COMPANY_ID, \r\n";
            q += " STYPE, \r\n";
            q += " SNO, \r\n";
            q += " SDATE, \r\n";
            q += " PARTY, \r\n";
            q += " CHEQUE, \r\n";
            q += " SALES_AMOUNT, \r\n";
            q += " RECEIPT_AMOUNT, \r\n";
            q += " OPENING_BALANCE \r\n";
            q += " FROM ( \r\n";

            q += " SELECT  \r\n";
            q += " " + OFFSET_1_INVOICE.COMPANY_ID + ", \r\n";
            q += " 'Invoice' AS STYPE, \r\n";
            q += " " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + " AS SNO, \r\n";
            q += " " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE + " AS SDATE, \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " AS PARTY, \r\n";
            q += " '' AS CHEQUE, \r\n";
            q += " " + OFFSET_1_INVOICE.GRANDTOTAL + " AS SALES_AMOUNT, \r\n";
            q += " '' AS RECEIPT_AMOUNT, \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.OPENING_BALANCE + " AS OPENING_BALANCE \r\n";
            q += " FROM " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " \r\n";
            q += " INNER JOIN " + PARTY.PARTY_TBL + " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ") \r\n";
            q += " UNION ALL \r\n";

            q += " SELECT \r\n";
            q += " " + OFFSET_1_RECEIPT.COMPANY_ID + ", \r\n";
            q += "'Receipt' AS STYPE, \r\n";
            q += " " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + " AS SNO, \r\n";
            q += " " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE + " AS SDATE, \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " AS PARTY, \r\n";
            q += " CHEQ_NO AS CHEQUE, \r\n";
            q += " '' AS SALES_AMOUNT, \r\n";
            q += " " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_AMOUNT + ", \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.OPENING_BALANCE + " AS OPENING_BALANCE \r\n";
            q += " FROM " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + " \r\n";
            q += " INNER JOIN " + PARTY.PARTY_TBL + " ON(" + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ") \r\n";

            //q += " SELECT \r\n";
            //q += " COMPANY_ID, \r\n";
            //q += "'Debit Note' AS STYPE, \r\n";
            //q += " DEBIT_NO, \r\n";
            //q += " DEBIT_DATE, \r\n";
            //q += " PARTY_ID, \r\n";
            //q += " NULL AS SALES_AMOUNT, \r\n";
            //q += " DEBIT__AMOUNT \r\n";
            //q += " FROM DEBIT_TBL \r\n";

            q += " ) s \r\n";

            //q += " WHERE COMPANY_ID =  " + Current.Company_id + " \r\n";
            q += " WHERE SNO <> '0' \r\n";

            if ((party_id != "") && (party_id != null))
            {
                q += " AND PARTY  =  '" + party_id + "' \r\n";
            }
            //
            if ((fromDt != "") && (fromDt != null))
            {
                if ((toDt != "") && (toDt != null))
                {
                    q += " AND  SDATE BETWEEN " + ConvertTO.SqlDate(fromDt) + " AND  " + ConvertTO.SqlDate(toDt) + " \r\n";
                }
                else
                {
                    q += " AND  SDATE BETWEEN " + ConvertTO.SqlDate(fromDt) + " AND  " + ConvertTO.SqlDate(DateTime.Now.ToString()) + " \r\n";
                }
            }

            //if ((vouchertype != "") && (vouchertype != null))
            //{
            //    q += " AND STYPE  =  '" + vouchertype + "' \r\n";
            //}

            q += " ORDER BY SDATE, SNO ;\r\n";

            return q;
        }


        public static decimal Getopening(string party, string date)
        {
            string q = "SELECT \r\n";
            q += " SUM(GRANDTOTAL) AS GRANDTOTAL \r\n";
            q += ", 0 AS RECEIPT_AMOUNT \r\n";
            q += ", PARTY_NAME \r\n";
            q += ", OPENING_BALANCE \r\n";
            q += " FROM INVOICE_TBL \r\n";
            q += " INNER JOIN PARTY_TBL ON(INVOICE_TBL.PARTY_ID = PARTY_TBL.PARTY_ID) \r\n";
            q += " AND PARTY_TBL.PARTY_NAME = '" + party + "' \r\n";
            q += " AND INVOICE_DATE <  " + ConvertTO.SqlDate(date) + " \r\n";
            q += " UNION ALL \r\n";
            q += " SELECT \r\n";
            q += " 0 AS GRANDTOTAL \r\n";
            q += ", SUM(RECEIPT_AMOUNT) AS RECEIPT_AMOUNT \r\n";
            q += ", PARTY_NAME \r\n";
            q += ", OPENING_BALANCE \r\n";
            q += " FROM RECEIPT_TBL \r\n";
            q += " INNER JOIN PARTY_TBL ON(RECEIPT_TBL.PARTY_ID = PARTY_TBL.PARTY_ID) \r\n";
            q += " AND PARTY_TBL.PARTY_NAME = '" + party + "'\r\n";
            q += " AND RECEIPT_DATE<  " + ConvertTO.SqlDate(date) + " \r\n";

            DataTable tbl = new DAL().Listdata(q);

            decimal vgrandtotal = ConvertTO.Decimal(tbl.Rows[0]["GRANDTOTAL"]);
            decimal vreceiptamount = ConvertTO.Decimal(tbl.Rows[1]["RECEIPT_AMOUNT"]);
            decimal vopeningbalance = ConvertTO.Decimal(tbl.Rows[0]["OPENING_BALANCE"]);

            return (vopeningbalance + vgrandtotal) - vreceiptamount;
        }




        #endregion[Statment Query]

    }//cls
}//ns
