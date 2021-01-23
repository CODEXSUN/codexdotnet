// Version : 4 dt : 04-10-2017
// Auto Generated
// 04-10-2017 10:21:50 PM
// last update : 04-10-2017

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class CUpvc_invoice_exten
    {
        #region[Entity Data]

        private static Upvc_invoice EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Upvc_invoice obj = new Upvc_invoice()
                    {
                        Upvc_invoice_id = redr[UPVC_INVOICE.UPVC_INVOICE_ID].ToString(),
                        Company_id = redr[UPVC_INVOICE.COMPANY_ID].ToString(),
                        Acy_id = redr[UPVC_INVOICE.ACY_ID].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Invoice_no = redr[UPVC_INVOICE.INVOICE_NO].ToString(),
                        Invoice_date = redr[UPVC_INVOICE.INVOICE_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Delivered_id = redr[UPVC_INVOICE.DELIVEREDTO_ID].ToString(),
                        Transport_id = redr[TRANSPORT.TRANSPORT_NAME].ToString(),
                        Vehicle_no = redr[UPVC_INVOICE.VEHICLE_NO].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[UPVC_INVOICE.TOTAL_QTY].ToString()),
                        Total_areasq = ConvertTO.Decimal(redr[UPVC_INVOICE.TOTAL_AREASQ].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[UPVC_INVOICE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[UPVC_INVOICE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[UPVC_INVOICE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[UPVC_INVOICE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[UPVC_INVOICE.GSTTOTAL].ToString()),
                        Ledger_id = redr[UPVC_INVOICE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[UPVC_INVOICE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[UPVC_INVOICE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[UPVC_INVOICE.GRANDTOTAL].ToString()),
                        Refered_no = ConvertTO.Decimal(redr[UPVC_INVOICE.REFERED_NO].ToString()),
                        Locked = redr[UPVC_INVOICE.LOCKED].ToString(),
                        Notes = redr[UPVC_INVOICE.NOTES].ToString(),
                        Active_id = redr[UPVC_INVOICE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Upvc_invoice();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Upvc_invoice> EntityList(string q)
        {
            List<Upvc_invoice> list = new List<Upvc_invoice>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Upvc_invoice obj = new Upvc_invoice()
                    {
                        Upvc_invoice_id = redr[UPVC_INVOICE.UPVC_INVOICE_ID].ToString(),
                        Company_id = redr[UPVC_INVOICE.COMPANY_ID].ToString(),
                        Acy_id = redr[UPVC_INVOICE.ACY_ID].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_ID].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Invoice_no = redr[UPVC_INVOICE.INVOICE_NO].ToString(),
                        Invoice_date = redr[UPVC_INVOICE.INVOICE_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Delivered_id = redr[UPVC_INVOICE.DELIVEREDTO_ID].ToString(),
                        Transport_id = redr[TRANSPORT.TRANSPORT_NAME].ToString(),
                        Vehicle_no = redr[UPVC_INVOICE.VEHICLE_NO].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[UPVC_INVOICE.TOTAL_QTY].ToString()),
                        Total_areasq = ConvertTO.Decimal(redr[UPVC_INVOICE.TOTAL_AREASQ].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[UPVC_INVOICE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[UPVC_INVOICE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[UPVC_INVOICE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[UPVC_INVOICE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[UPVC_INVOICE.GSTTOTAL].ToString()),
                        Ledger_id = redr[UPVC_INVOICE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[UPVC_INVOICE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[UPVC_INVOICE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[UPVC_INVOICE.GRANDTOTAL].ToString()),
                        Refered_no = ConvertTO.Decimal(redr[UPVC_INVOICE.REFERED_NO].ToString()),
                        Locked = redr[UPVC_INVOICE.LOCKED].ToString(),
                        Notes = redr[UPVC_INVOICE.NOTES].ToString(),
                        Active_id = redr[UPVC_INVOICE.ACTIVE_ID].ToString(),
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

        public static List<Upvc_invoice> Unrefer(DAL DAL)
        {
            string q = " SELECT " + UPVC_INVOICE.UPVC_INVOICE_TBL + ".* \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UPVC_INVOICE.UPVC_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Unrefer]

        #region[refer]

        public static List<Upvc_invoice> Refer(DAL DAL)
        {
            string q = " SELECT " + UPVC_INVOICE.UPVC_INVOICE_TBL + ".* \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UPVC_INVOICE.UPVC_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[refer]

        #region[showall]

        public static List<Upvc_invoice> Showall(DAL DAL)
        {
            string q = " SELECT " + UPVC_INVOICE.UPVC_INVOICE_TBL + ".* \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UPVC_INVOICE.UPVC_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[showall]

        #region[not active]

        public static List<Upvc_invoice> Notactive(DAL DAL)
        {
            string q = " SELECT " + UPVC_INVOICE.UPVC_INVOICE_TBL + ".* \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UPVC_INVOICE.UPVC_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[not active]

        #region[PKId]

        public static Upvc_invoice PKId(string id, DAL DAL)
        {
            string q = " SELECT " + UPVC_INVOICE.UPVC_INVOICE_TBL + ".* \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UPVC_INVOICE.UPVC_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.UPVC_INVOICE_ID + " = '" + id + "' \r\n";
            q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_NO + ";\r\n";

            return EntityData(q);
        }

        #endregion[PKId]

        #region[Searchby]

        public static List<Upvc_invoice> Searchby(string no, string date, string party, DAL DAL)
        {
            string q = " SELECT " + UPVC_INVOICE.UPVC_INVOICE_TBL + ".* \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UPVC_INVOICE.UPVC_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            if (no != "")
            {
                q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_NO + " = '" + no + "'\r\n";
            }
            if (date != "")
            {

                q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Searchby]

        #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_NO + " \r\n";
            q += " FROM  " + UPVC_INVOICE.UPVC_INVOICE_TBL + " \r\n";
            q += " WHERE " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + UPVC_INVOICE.UPVC_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_DATE + " \r\n";
            q += " FROM  " + UPVC_INVOICE.UPVC_INVOICE_TBL + " \r\n";
            q += " WHERE " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.INVOICE_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(UPVC_INVOICE.INVOICE_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][UPVC_INVOICE.INVOICE_DATE] + "")
                    );
                }
            }
            return tbl;
        }

        #endregion[GetforLookup]

        #region[GetNext_No]

        public static string GetNext_No
        {
            get
            {
                string q = "SELECT " + UPVC_INVOICE.INVOICE_NO + " FROM " + UPVC_INVOICE.UPVC_INVOICE_TBL + "\r\n";
                q += " WHERE " + UPVC_INVOICE.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " AND " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
                q += " ORDER BY " + UPVC_INVOICE.INVOICE_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[UPVC_INVOICE.INVOICE_NO].ToString())) + 1).ToString();
                    }
                    redr.Close();
                    return Core.One;
                }
            }
        }

        #endregion[GetNext_No]

        #region[Lock Status]

        public static bool LockStatus(string pkValue)
        {
            if (pkValue != null)
            {
                Upvc_invoice obj = PKId(pkValue, new DAL());
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
            Upvc_invoice obj = PKId(Id, new DAL());

            if (obj != null)
            {
                return obj.Invoice_no;
            }
            return "";
        }

        public static string GetId_Name(string No)
        {
            List<Upvc_invoice> list = Searchby(No, "", "", new DAL());

            if (list.Count != 0)
            {
                return list[0].Upvc_invoice_id;
            }
            return "";
        }

        #endregion[Get id - No] 



        internal static bool Producttype(string value)
        {
            Product obj = CProduct_exten.SearchName(value, new DAL());

            if (obj.Producttype_id == "Raw Material")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }//cls
}//ns
