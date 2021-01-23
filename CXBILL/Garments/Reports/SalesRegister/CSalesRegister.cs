using CXLIB;
using System;
using System.Collections.Generic;
using System.Data;
using CXCORE;
using System.Diagnostics;

namespace CXBILL
{
    public class RCSalesRegister
    {
        #region[List]

        public static List<Salesregister> Register(string party_id, string fromDt, string toDt)
        {
            List<Salesregister> list = new List<Salesregister>();

            string q = SQuery(party_id, fromDt, toDt);

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Salesregister obj = new Salesregister()
                    {
                        Sdate = ConvertTO.Date2S(redr[SALESREGISTER.SDATE].ToString()),
                        Partyname = redr[SALESREGISTER.PARTYNAME].ToString(),
                        Vno = redr[SALESREGISTER.VNO].ToString(),
                        Stype = redr[SALESREGISTER.STYPE].ToString(),
                        Sales_amount = ConvertTO.Decimal(redr[SALESREGISTER.SALES_AMOUNT]),
                        Gst_amount = ConvertTO.Decimal(redr[SALESREGISTER.GST_AMOUNT])
                    };
                    list.Add(obj);
                }
            }

            return list;
        }

        #endregion[List]

        #region[SQuery]

        private static string SQuery(string party_id, string fromDt, string toDt)
        {

            String q = " SELECT \r\n";
            q += " COMPANY_ID, \r\n";
            q += " SDATE, \r\n";
            q += " PARTYNAME, \r\n";
            q += " VNO, \r\n";
            q += " STYPE, \r\n";
            q += " SALES_AMOUNT, \r\n";
            q += " GST_AMOUNT \r\n";
            q += " FROM ( \r\n";

            q += " SELECT  \r\n";
            q += " " + GARMENT_INVOICE.COMPANY_ID + ", \r\n";
            q += " " + GARMENT_INVOICE.GARMENT_INVOICE_DATE + " AS SDATE, \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " AS PARTYNAME, \r\n";
            q += " " + GARMENT_INVOICE.GARMENT_INVOICE_NO + " AS VNO, \r\n";
            q += " 'Sales' AS STYPE, \r\n";
            q += " " + GARMENT_INVOICE.GRANDTOTAL + " AS SALES_AMOUNT, \r\n";
            q += " " + GARMENT_INVOICE.GSTTOTAL + " AS GST_AMOUNT \r\n";

            q += " FROM " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " \r\n";
            q += " INNER JOIN " + PARTY.PARTY_TBL + " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ") \r\n";

            q += " ) s \r\n";

            q += " WHERE COMPANY_ID =  " + Current.Company_id + " \r\n";
            q += " AND VNO <> '0' \r\n";

            if ((party_id != "") && (party_id != null))
            {
                q += " AND PARTYNAME  =  '" + party_id + "' \r\n";
            }
            
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
            q += " ORDER BY SDATE,VNO;\r\n";

            return q;
        }

        #endregion[SQuery]

    }//cls
}//ns
