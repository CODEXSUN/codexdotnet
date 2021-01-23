using CXLIB;
using System;
using System.Collections.Generic;
using System.Data;
using CXCORE;

namespace CXBILL
{
    public class CReportQuotationStatement
    {
        #region[Statement]
        public static List<ReportQuotaionStatement> Statement(string party_id, string fromDt, string toDt, string vouchertype)
        {
            List<ReportQuotaionStatement> list = new List<ReportQuotaionStatement>();

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

                    ReportQuotaionStatement obj = new ReportQuotaionStatement()
                    {
                        Sno = sl++,
                        Vno = redr[REPORTQUOTATIONSTATEMENT.SNO].ToString(),
                        Sdate = ConvertTO.Date2S(redr[REPORTQUOTATIONSTATEMENT.SDATE].ToString()),
                        S2date = ConvertTO.DDate(redr[REPORTQUOTATIONSTATEMENT.SDATE].ToString()),
                        Stype = redr[REPORTQUOTATIONSTATEMENT.STYPE].ToString(),
                        Cheque = redr[REPORTQUOTATIONSTATEMENT.CHEQUE].ToString(),
                        Quotaion_amount = ConvertTO.Decimal(redr[REPORTQUOTATIONSTATEMENT.QUOTATION_AMOUNT]),
                        Qreceipt_amount = ConvertTO.Decimal(redr[REPORTQUOTATIONSTATEMENT.QRECEIPT_AMOUNT]),
                        Party = redr[REPORTQUOTATIONSTATEMENT.PARTY].ToString(),
                        Opening = ConvertTO.Decimal(redr[REPORTQUOTATIONSTATEMENT.OPENING_BALANCE].ToString())
                    };

                    if (fromDt != "")
                    {
                        obj.Opening = vopening;
                    }

                    sa += ConvertTO.Decimal(redr[REPORTQUOTATIONSTATEMENT.QUOTATION_AMOUNT]);
                    re += ConvertTO.Decimal(redr[REPORTQUOTATIONSTATEMENT.QRECEIPT_AMOUNT]);

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
            q += " QUOTATION_AMOUNT, \r\n";
            q += " QRECEIPT_AMOUNT, \r\n";
            q += " OPENING_BALANCE \r\n";
            q += " FROM ( \r\n";

            q += " SELECT  \r\n";
            q += " COMPANY_ID, \r\n";
            q += "'Quotation' AS STYPE,\r\n";
            q += QUOTATION.QUOTATION_NO + " AS SNO,\r\n";
            q += QUOTATION.QUOTATION_DATE + " AS SDATE,\r\n";
            q += PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " AS PARTY,\r\n";
            q += " '' AS CHEQUE,\r\n";
            q += QUOTATION.GRANDTOTAL + " AS QUOTATION_AMOUNT,\r\n";
            q += " '' AS " + QRECEIPT.QRECEIPT_AMOUNT + ", \r\n";
            q += PARTY.PARTY_TBL + "." + PARTY.CREDIT_DAYS + " AS " + PARTY.OPENING_BALANCE + " \r\n";
            q += " FROM " + QUOTATION.QUOTATION_TBL + " \r\n";
            q += " INNER JOIN " + PARTY.PARTY_TBL + " ON(" + QUOTATION.QUOTATION_TBL + "." + QUOTATION.PARTY_ID + "  = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ") \r\n";
            q += " UNION ALL \r\n";

            q += " SELECT \r\n";
            q += " COMPANY_ID, \r\n";
            q += "'QReceipt' AS STYPE, \r\n";
            q += QRECEIPT.QRECEIPT_NO + " AS SNO, \r\n";
            q += QRECEIPT.QRECEIPT_DATE + " AS SDATE, \r\n";
            q += PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " AS PARTY,\r\n";
            q += " CHEQ_NO AS CHEQUE, \r\n";
            q += " '' AS QUOTATION_AMOUNT, \r\n";
            q += QRECEIPT.QRECEIPT_AMOUNT + ", \r\n";
            q += PARTY.PARTY_TBL + "." + PARTY.CREDIT_DAYS + " AS " + PARTY.OPENING_BALANCE + " \r\n";
            q += " FROM " + QRECEIPT.QRECEIPT_TBL + " \r\n";
            q += " INNER JOIN " + PARTY.PARTY_TBL + " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ")  \r\n";

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

            q += " ORDER BY SDATE, SNO, STYPE;\r\n";

            return q;
        }


        public static decimal Getopening(string party, string date)
        {
            string q = "SELECT \r\n";
            q += " SUM(" + QUOTATION.GRANDTOTAL + ") AS " + QUOTATION.GRANDTOTAL + " \r\n";
            q += ", 0 AS " + QRECEIPT.QRECEIPT_AMOUNT + " \r\n";
            q += ", " + PARTY.PARTY_NAME + " \r\n";
            q += ", " + PARTY.CREDIT_DAYS + " \r\n";
            q += " FROM " + QUOTATION.QUOTATION_TBL + "\r\n";
            q += " INNER JOIN " + PARTY.PARTY_TBL + " ON(" + QUOTATION.QUOTATION_TBL + "." + QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ") \r\n";
            q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'\r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_DATE + " <  " + ConvertTO.SqlDate(date) + " \r\n";
            q += " UNION ALL \r\n";
            q += " SELECT \r\n";
            q += " 0 AS " + QUOTATION.GRANDTOTAL + " \r\n";
            q += ", SUM(" + QRECEIPT.QRECEIPT_AMOUNT + ") AS " + QRECEIPT.QRECEIPT_AMOUNT + " \r\n";
            q += ", " + PARTY.PARTY_NAME + " \r\n";
            q += ", " + PARTY.CREDIT_DAYS + " \r\n";
            q += " FROM " + QRECEIPT.QRECEIPT_TBL + " \r\n";
            q += " INNER JOIN " + PARTY.PARTY_TBL + " ON(" + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ") \r\n";
            q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'\r\n";
            q += " AND " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_DATE + "<  " + ConvertTO.SqlDate(date) + " \r\n";

            DataTable tbl = new DAL().Listdata(q);

            decimal vgrandtotal = ConvertTO.Decimal(tbl.Rows[0]["" + QUOTATION.GRANDTOTAL + ""]);
            decimal vreceiptamount = ConvertTO.Decimal(tbl.Rows[1]["" + QRECEIPT.QRECEIPT_AMOUNT + ""]);
            decimal vopeningbalance = ConvertTO.Decimal(tbl.Rows[0]["" + PARTY.CREDIT_DAYS + ""]);

            return (vopeningbalance + vgrandtotal) - vreceiptamount;
        }

        #endregion[Statment Query]

    }//cls
}//ns
