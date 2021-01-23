// Version : 4 dt : 04-10-2017
// Auto Generated
// 05-10-2017 10:43:27 AM
// last update : 05-10-2017

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class COffset_1_invoice_exten
    {
        #region[Entity Data]

        private static Offset_1_invoice EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_1_invoice obj = new Offset_1_invoice()
                    {
                        Offset_1_invoice_id = redr[OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID].ToString(),
                        Uniqueno = redr[OFFSET_1_INVOICE.UNIQUENO].ToString(),
                        Company_id = redr[OFFSET_1_INVOICE.COMPANY_ID].ToString(),
                        Acy_id = redr[OFFSET_1_INVOICE.ACY_ID].ToString(),
                        Offset_1_invoice_no = Convert.ToInt32(redr[OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO].ToString()),
                        Offset_1_invoice_date = redr[OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.GSTTOTAL].ToString()),
                        Ledger_id = redr[OFFSET_1_INVOICE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.REFERED_AMT].ToString()),
                        Locked = redr[OFFSET_1_INVOICE.LOCKED].ToString(),
                        Notes = redr[OFFSET_1_INVOICE.NOTES].ToString(),
                        Active_id = redr[OFFSET_1_INVOICE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Offset_1_invoice();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Offset_1_invoice> EntityList(string q)
        {
            List<Offset_1_invoice> list = new List<Offset_1_invoice>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_1_invoice obj = new Offset_1_invoice()
                    {
                        Offset_1_invoice_id = redr[OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID].ToString(),
                        Uniqueno = redr[OFFSET_1_INVOICE.UNIQUENO].ToString(),
                        Company_id = redr[OFFSET_1_INVOICE.COMPANY_ID].ToString(),
                        Acy_id = redr[OFFSET_1_INVOICE.ACY_ID].ToString(),
                        Offset_1_invoice_no = Convert.ToInt32(redr[OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO].ToString()),
                        Offset_1_invoice_date = redr[OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.GSTTOTAL].ToString()),
                        Ledger_id = redr[OFFSET_1_INVOICE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[OFFSET_1_INVOICE.REFERED_AMT].ToString()),
                        Locked = redr[OFFSET_1_INVOICE.LOCKED].ToString(),
                        Notes = redr[OFFSET_1_INVOICE.NOTES].ToString(),
                        Active_id = redr[OFFSET_1_INVOICE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };

                    list.Add(obj);
                }

                redr.Close();
            }
            return list;
        }

        #endregion[Entity List]

        #region[Unrefer]

        public static List<Offset_1_invoice> Unrefer(DAL DAL)
        {
            string q = " SELECT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + ".* \r\n";

            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";

            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";

            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Unrefer]

        #region[refer]

        public static List<Offset_1_invoice> Refer(DAL DAL)
        {
            string q = " SELECT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";

            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";

            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[refer]

        #region[showall]

        public static List<Offset_1_invoice> Showall(DAL DAL)
        {
            string q = " SELECT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";

            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";

            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[showall]

        #region[not active]

        public static List<Offset_1_invoice> Notactive(DAL DAL)
        {
            string q = " SELECT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";

            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";

            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND NOT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[not active]

        #region[PKId]

        public static Offset_1_invoice PKId(string id, DAL DAL)
        {
            string q = " SELECT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";

            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";

            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " = '" + id + "' \r\n";
            q += " AND NOT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + ";\r\n";

            return EntityData(q);
        }

        #endregion[PKId]

        #region[Searchby]

        public static List<Offset_1_invoice> Searchby(string no, string date, string dateTo, string party, DAL DAL)
        {
            string q = " SELECT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";

            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";

            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + " = '" + no + "'\r\n";
            }



            if (dateTo != "")
            {

                q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE + "  BETWEEN " + ConvertTO.SqlDate(date) + " AND " + ConvertTO.SqlDate(dateTo) + " \r\n";
            }
            else
            {
                if (date != "")
                {

                    q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
                }

            }

            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Searchby]

        #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " \r\n";
            q += " WHERE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " \r\n";
            q += " WHERE " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE] + "")
                    );
                }
            }
            return tbl;
        }

        #endregion[GetforLookup]

        #region[GetNext_No]

        public static int GetNext_No
        {
            get
            {
                string q = "SELECT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + " FROM " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "\r\n";
                q += " WHERE " + OFFSET_1_INVOICE.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO].ToString())) + 1);
                    }
                    redr.Close();
                    return 1;
                }
            }
        }

        #endregion[GetNext_No]

        #region[Lock Status]

        public static bool LockStatus(string pkValue)
        {
            if (pkValue != null)
            {
                Offset_1_invoice obj = PKId(pkValue, new DAL());
                if (obj.Locked == Core.Unlocked)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion[Lock Status]

        #region[Get id - No] 

        public static string GetName_Id(string Id)
        {
            Offset_1_invoice obj = PKId(Id, new DAL());

            if (obj != null)
            {
                return obj.Offset_1_invoice_no.ToString();
            }
            return "";
        }

        public static string GetId_Name(string No)
        {
            List<Offset_1_invoice> list = Searchby(No, "", "", "", new DAL());

            if (list.Count != 0)
            {
                return list[0].Offset_1_invoice_id;
            }
            return "";
        }

        public static string FindInvoiceGstTotal(string No)
        {
            List<Offset_1_invoice> list = Searchby(No, "", "", "", new DAL());

            if (list.Count != 0)
            {
                return list[0].Gsttotal.ToString();
            }
            return "";
        }

        #endregion[Get id - No] 

        public static decimal GetBalance(string party_id)
        {
            if (party_id != null)
            {

                //string opening_q = "SELECT " + PARTY.OPENING_BALANCE + " FROM " + PARTY.PARTY_TBL + " WHERE " + PARTY.PARTY_ID + " = '" + party_id + "'";
                //string grand_q = "SELECT SUM(" + OFFSET_1_INVOICE.GRANDTOTAL + ") " + OFFSET_1_INVOICE.GRANDTOTAL + " FROM " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " WHERE " + OFFSET_1_INVOICE.PARTY_ID + "= '" + party_id + "'";
                //string Receipt_q = "SELECT SUM(" + RECEIPT.RECEIPT_AMOUNT + ") " + RECEIPT.RECEIPT_AMOUNT + " FROM " + RECEIPT.RECEIPT_TBL + " WHERE " + RECEIPT.PARTY_ID + " = '" + party_id + "'";

                //string vOpening = new DAL().ExecuteScalar(opening_q).ToString();
                //string vGrand = new DAL().ExecuteScalar(grand_q).ToString();
                //string vReceipt = new DAL().ExecuteScalar(Receipt_q).ToString();

                //decimal balance = (ConvertTO.Decimal(vOpening) + ConvertTO.Decimal(vGrand)) - ConvertTO.Decimal(vReceipt);

                //return balance;
            }
            return 0;
        }

    }//cls
}//ns
