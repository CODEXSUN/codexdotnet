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
    public class CTex_Invoice_exten
    {
        #region[Entity Data]

        private static Tex_Invoice EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Tex_Invoice obj = new Tex_Invoice()
                    {
                        Tex_invoice_id = redr[TEX_INVOICE.TEX_INVOICE_ID].ToString(),
                        Uniqueno = redr[TEX_INVOICE.UNIQUENO].ToString(),
                        Company_id = redr[TEX_INVOICE.COMPANY_ID].ToString(),
                        Acy_id = redr[TEX_INVOICE.ACY_ID].ToString(),
                        Order_id = redr[ORDER.ORDER_NO].ToString(),
                        Invoice_no = redr[TEX_INVOICE.INVOICE_NO].ToString(),
                        Invoice_date = redr[TEX_INVOICE.INVOICE_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Transport_id = redr[TRANSPORT.TRANSPORT_NAME].ToString(),
                        Deliveredto_id = redr[DELIVEREDTO.DELIVEREDTO_NAME].ToString(),
                        Bundel = redr[TEX_INVOICE.BUNDEL].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[TEX_INVOICE.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[TEX_INVOICE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[TEX_INVOICE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[TEX_INVOICE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[TEX_INVOICE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[TEX_INVOICE.GSTTOTAL].ToString()),
                        Ledger_id = redr[TEX_INVOICE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[TEX_INVOICE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[TEX_INVOICE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[TEX_INVOICE.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[TEX_INVOICE.REFERED_AMT].ToString()),
                        Locked = redr[TEX_INVOICE.LOCKED].ToString(),
                        Notes = redr[TEX_INVOICE.NOTES].ToString(),
                        Active_id = redr[TEX_INVOICE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Tex_Invoice();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Tex_Invoice> EntityList(string q)
        {
            List<Tex_Invoice> list = new List<Tex_Invoice>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Tex_Invoice obj = new Tex_Invoice()
                    {
                        Tex_invoice_id = redr[TEX_INVOICE.TEX_INVOICE_ID].ToString(),
                        Uniqueno = redr[TEX_INVOICE.UNIQUENO].ToString(),
                        Company_id = redr[TEX_INVOICE.COMPANY_ID].ToString(),
                        Acy_id = redr[TEX_INVOICE.ACY_ID].ToString(),
                        Order_id = redr[ORDER.ORDER_NO].ToString(),
                        Invoice_no = redr[TEX_INVOICE.INVOICE_NO].ToString(),
                        Invoice_date = redr[TEX_INVOICE.INVOICE_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Transport_id = redr[TRANSPORT.TRANSPORT_NAME].ToString(),
                        Deliveredto_id = redr[DELIVEREDTO.DELIVEREDTO_NAME].ToString(),
                        Bundel = redr[TEX_INVOICE.BUNDEL].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[TEX_INVOICE.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[TEX_INVOICE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[TEX_INVOICE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[TEX_INVOICE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[TEX_INVOICE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[TEX_INVOICE.GSTTOTAL].ToString()),
                        Ledger_id = redr[TEX_INVOICE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[TEX_INVOICE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[TEX_INVOICE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[TEX_INVOICE.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[TEX_INVOICE.REFERED_AMT].ToString()),
                        Locked = redr[TEX_INVOICE.LOCKED].ToString(),
                        Notes = redr[TEX_INVOICE.NOTES].ToString(),
                        Active_id = redr[TEX_INVOICE.ACTIVE_ID].ToString(),
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

        public static List<Tex_Invoice> Unrefer()
        {
            string q = " SELECT " + TEX_INVOICE.TEX_INVOICE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TEX_INVOICE.TEX_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + DELIVEREDTO.DELIVEREDTO_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.DELIVEREDTO_ID + " = " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Unrefer]

        #region[refer]

        public static List<Tex_Invoice> Refer()
        {
            string q = " SELECT " + TEX_INVOICE.TEX_INVOICE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TEX_INVOICE.TEX_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + DELIVEREDTO.DELIVEREDTO_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.DELIVEREDTO_ID + " = " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[refer]

        #region[showall]

        public static List<Tex_Invoice> Showall()
        {
            string q = " SELECT " + TEX_INVOICE.TEX_INVOICE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TEX_INVOICE.TEX_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + DELIVEREDTO.DELIVEREDTO_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.DELIVEREDTO_ID + " = " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[showall]

        #region[not active]

        public static List<Tex_Invoice> Notactive()
        {
            string q = " SELECT " + TEX_INVOICE.TEX_INVOICE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TEX_INVOICE.TEX_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + DELIVEREDTO.DELIVEREDTO_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.DELIVEREDTO_ID + " = " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND NOT " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[not active]

        #region[PKId]

        public static Tex_Invoice PKId(string id)
        {
            string q = " SELECT " + TEX_INVOICE.TEX_INVOICE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TEX_INVOICE.TEX_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + DELIVEREDTO.DELIVEREDTO_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.DELIVEREDTO_ID + " = " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + " = '" + id + "' \r\n";
            q += " AND NOT " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_NO + ";\r\n";

            return EntityData(q);
        }

        #endregion[PKId]

        #region[Searchby]

        public static List<Tex_Invoice> Searchby(string no, string date, string dateTo, string party)
        {
            string q = " SELECT " + TEX_INVOICE.TEX_INVOICE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TEX_INVOICE.TEX_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + DELIVEREDTO.DELIVEREDTO_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.DELIVEREDTO_ID + " = " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_NO + " = '" + no + "'\r\n";
            }



            if (dateTo != "")
            {

                q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_DATE + "  BETWEEN " + ConvertTO.SqlDate(date) + " AND " + ConvertTO.SqlDate(dateTo) + " \r\n";
            }
            else
            {
                if (date != "")
                {

                    q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
                }

            }

            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Searchby]

        #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_NO + " \r\n";
            q += " FROM  " + TEX_INVOICE.TEX_INVOICE_TBL + " \r\n";
            q += " WHERE " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + TEX_INVOICE.TEX_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_DATE + " \r\n";
            q += " FROM  " + TEX_INVOICE.TEX_INVOICE_TBL + " \r\n";
            q += " WHERE " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(TEX_INVOICE.INVOICE_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][TEX_INVOICE.INVOICE_DATE] + "")
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
                string q = "SELECT " + TEX_INVOICE.INVOICE_NO + " FROM " + TEX_INVOICE.TEX_INVOICE_TBL + "\r\n";
                q += " WHERE " + TEX_INVOICE.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " AND " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
                q += " ORDER BY " + TEX_INVOICE.INVOICE_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[TEX_INVOICE.INVOICE_NO].ToString())) + 1);
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
                Tex_Invoice obj = PKId(pkValue);
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
            Tex_Invoice obj = PKId(Id);

            if (obj != null)
            {
                return obj.Invoice_no.ToString();
            }
            return "";
        }

        public static string GetId_Name(string No)
        {
            List<Tex_Invoice> list = Searchby(No, "", "", "");

            if (list.Count != 0)
            {
                return list[0].Tex_invoice_id;
            }
            return "";
        }

        public static string FindInvoiceGstTotal(string No)
        {
            List<Tex_Invoice> list = Searchby(No, "", "", "");

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

                string opening_q = "SELECT " + PARTY.OPENING_BALANCE + " FROM " + PARTY.PARTY_TBL + " WHERE " + PARTY.PARTY_ID + " = '" + party_id + "'";
                string grand_q = "SELECT SUM(" + TEX_INVOICE.GRANDTOTAL + ") " + TEX_INVOICE.GRANDTOTAL + " FROM " + TEX_INVOICE.TEX_INVOICE_TBL + " WHERE " + TEX_INVOICE.PARTY_ID + "= '" + party_id + "'";
                //string Receipt_q = "SELECT SUM(" + Receipt.RECEIPT_AMOUNT + ") " + RECEIPT.RECEIPT_AMOUNT + " FROM " + RECEIPT.RECEIPT_TBL + " WHERE " + RECEIPT.PARTY_ID + " = '" + party_id + "'";

                string vOpening = new DAL().ExecuteScalar(opening_q).ToString();
                string vGrand = new DAL().ExecuteScalar(grand_q).ToString();
                //string vReceipt = new DAL().ExecuteScalar(Receipt_q).ToString();

                //decimal balance = (ConvertTO.Decimal(vOpening) + ConvertTO.Decimal(vGrand)) - ConvertTO.Decimal(vReceipt);

                //return balance;
            }
            return 0;
        }

    }//cls
}//ns
