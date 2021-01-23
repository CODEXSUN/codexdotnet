// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:18 AM

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class CGarment_invoice_exten
    {
         #region[Entity Data]

        private static Garment_invoice EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Garment_invoice obj = new Garment_invoice()
                    {
                        Garment_invoice_id = redr[GARMENT_INVOICE.GARMENT_INVOICE_ID].ToString(),
                        Uniqueno = redr[GARMENT_INVOICE.UNIQUENO].ToString(),
                        Company_id = redr[GARMENT_INVOICE.COMPANY_ID].ToString(),
                        Acy_id = redr[GARMENT_INVOICE.ACY_ID].ToString(),
                        Order_id = redr[ORDER.ORDER_NO].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Garment_invoice_no = redr[GARMENT_INVOICE.GARMENT_INVOICE_NO].ToString(),
                        Garment_invoice_date = redr[GARMENT_INVOICE.GARMENT_INVOICE_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[GARMENT_INVOICE.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[GARMENT_INVOICE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[GARMENT_INVOICE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[GARMENT_INVOICE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[GARMENT_INVOICE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[GARMENT_INVOICE.GSTTOTAL].ToString()),
                        Ledger_id = redr[GARMENT_INVOICE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[GARMENT_INVOICE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[GARMENT_INVOICE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[GARMENT_INVOICE.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[GARMENT_INVOICE.REFERED_AMT].ToString()),
                        Locked = redr[GARMENT_INVOICE.LOCKED].ToString(),
                        Notes = redr[GARMENT_INVOICE.NOTES].ToString(),
                        Active_id = redr[GARMENT_INVOICE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Garment_invoice();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Garment_invoice> EntityList(string q)
         {
             List<Garment_invoice> list = new List<Garment_invoice>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Garment_invoice obj = new Garment_invoice()
                     {
                        Garment_invoice_id = redr[GARMENT_INVOICE.GARMENT_INVOICE_ID].ToString(),
                        Uniqueno = redr[GARMENT_INVOICE.UNIQUENO].ToString(),
                        Company_id = redr[GARMENT_INVOICE.COMPANY_ID].ToString(),
                        Acy_id = redr[GARMENT_INVOICE.ACY_ID].ToString(),
                        Order_id = redr[ORDER.ORDER_NO].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Garment_invoice_no = redr[GARMENT_INVOICE.GARMENT_INVOICE_NO].ToString(),
                        Garment_invoice_date = redr[GARMENT_INVOICE.GARMENT_INVOICE_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[GARMENT_INVOICE.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[GARMENT_INVOICE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[GARMENT_INVOICE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[GARMENT_INVOICE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[GARMENT_INVOICE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[GARMENT_INVOICE.GSTTOTAL].ToString()),
                        Ledger_id = redr[GARMENT_INVOICE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[GARMENT_INVOICE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[GARMENT_INVOICE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[GARMENT_INVOICE.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[GARMENT_INVOICE.REFERED_AMT].ToString()),
                        Locked = redr[GARMENT_INVOICE.LOCKED].ToString(),
                        Notes = redr[GARMENT_INVOICE.NOTES].ToString(),
                        Active_id = redr[GARMENT_INVOICE.ACTIVE_ID].ToString(),
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

         public static List<Garment_invoice> Unrefer()
         {
            string q = " SELECT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<Garment_invoice> Refer()
         {
            string q = " SELECT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<Garment_invoice> Showall()
         {
            string q = " SELECT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<Garment_invoice> Notactive()
         {
            string q = " SELECT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND NOT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static Garment_invoice PKId(string id)
         {
            string q = " SELECT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + " = '" + id + "' \r\n";
            q += " AND NOT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_NO + ";\r\n";

             return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<Garment_invoice> Searchby(string no, string date, string dateTo, string party)
         {
            string q = " SELECT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_NO + " = '" + no + "'\r\n";
            }
            if (dateTo != "")
            {
                q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_DATE + "  BETWEEN " + ConvertTO.SqlDate(date) + " AND " + ConvertTO.SqlDate(dateTo) + "\r\n";
            }
            else if (date != "")
            {

                q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_NO + " \r\n";
            q += " FROM  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " \r\n";
            q += " WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        public static DataTable LookupParty()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        public static DataTable LookupDate()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_DATE + " \r\n";
            q += " FROM  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " \r\n";
            q += " WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_NO + ";\r\n";

            DataTable xtbl = new DAL().Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(GARMENT_INVOICE.GARMENT_INVOICE_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][GARMENT_INVOICE.GARMENT_INVOICE_DATE] + "")
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
                string q = "SELECT " + GARMENT_INVOICE.GARMENT_INVOICE_NO + " FROM " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "\r\n";
                q += " WHERE " + GARMENT_INVOICE.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + GARMENT_INVOICE.GARMENT_INVOICE_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[GARMENT_INVOICE.GARMENT_INVOICE_NO].ToString())) + 1).ToString();
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
                Garment_invoice obj = PKId(pkValue);
                if (obj.Locked == Core.Unlocked)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion[Lock Status]

        #region[Get id - FieldsName]

         public static string GetName_Id(string _pId)
        {
            Garment_invoice obj = PKId(_pId);

             if (obj != null)
            {
                return obj.Garment_invoice_no;
            }
            return "";
        }

         public static string GetId_Name(string _pName)
        {
            var list = Searchby("","","",_pName);

             if (list.Count != 0)
            {
                return list[0].Garment_invoice_id;
            }
            return "";
        }

         #endregion[Get id - FieldsName]

    }//cls
}//ns
