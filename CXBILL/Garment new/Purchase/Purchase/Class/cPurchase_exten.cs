// Version : 4 dt : 04-10-2017
// Auto Generated
// 05-10-2017 10:43:27 AM
// last update : 05-10-2017

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;
using CXERP;

namespace CXBILL
{
    public class CPurchase_exten
    {
        #region[Entity Data]

        private static Purchase EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Purchase obj = new Purchase()
                    {
                        Purchase_id = redr[PURCHASE.PURCHASE_ID].ToString(),
                        Order_id = redr[ORDER.ORDER_NO].ToString(),
                        Entry_no = redr[PURCHASE.ENTRY_NO].ToString(),
                        Purchase_no = redr[PURCHASE.PURCHASE_NO].ToString(),
                        Purchase_date = redr[PURCHASE.PURCHASE_DATE].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[PURCHASE.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[PURCHASE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[PURCHASE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[PURCHASE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[PURCHASE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[PURCHASE.GSTTOTAL].ToString()),
                        Ledger_id = redr[PURCHASE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[PURCHASE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[PURCHASE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[PURCHASE.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[PURCHASE.REFERED_AMT].ToString()),
                        Locked = redr[PURCHASE.LOCKED].ToString(),
                        Notes = redr[PURCHASE.NOTES].ToString(),
                        Active_id = redr[PURCHASE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Purchase();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Purchase> EntityList(string q)
        {
            List<Purchase> list = new List<Purchase>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Purchase obj = new Purchase()
                    {
                        Purchase_id = redr[PURCHASE.PURCHASE_ID].ToString(),
                        Order_id = redr[ORDER.ORDER_NO].ToString(),
                        Entry_no = redr[PURCHASE.ENTRY_NO].ToString(),
                        Purchase_no = redr[PURCHASE.PURCHASE_NO].ToString(),
                        Purchase_date = redr[PURCHASE.PURCHASE_DATE].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[PURCHASE.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[PURCHASE.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[PURCHASE.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[PURCHASE.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[PURCHASE.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[PURCHASE.GSTTOTAL].ToString()),
                        Ledger_id = redr[PURCHASE.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[PURCHASE.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[PURCHASE.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[PURCHASE.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[PURCHASE.REFERED_AMT].ToString()),
                        Locked = redr[PURCHASE.LOCKED].ToString(),
                        Notes = redr[PURCHASE.NOTES].ToString(),
                        Active_id = redr[PURCHASE.ACTIVE_ID].ToString(),
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

        public static List<Purchase> Unrefer()
        {
            string q = " SELECT " + PURCHASE.PURCHASE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PURCHASE.PURCHASE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ENTRY_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Unrefer]

        #region[refer]

        public static List<Purchase> Refer()
        {
            string q = " SELECT " + PURCHASE.PURCHASE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PURCHASE.PURCHASE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ENTRY_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[refer]

        #region[showall]

        public static List<Purchase> Showall()
        {
            string q = " SELECT " + PURCHASE.PURCHASE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PURCHASE.PURCHASE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ENTRY_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[showall]

        #region[not active]

        public static List<Purchase> Notactive(DAL DAL)
        {
            string q = " SELECT " + PURCHASE.PURCHASE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PURCHASE.PURCHASE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND NOT " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ENTRY_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[not active]

        #region[PKId]

        public static Purchase PKId(string id, DAL DAL)
        {
            string q = " SELECT " + PURCHASE.PURCHASE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PURCHASE.PURCHASE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " = '" + id + "' \r\n";
            q += " AND NOT " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ENTRY_NO + ";\r\n";

            return EntityData(q);
        }

        #endregion[PKId]

        #region[Searchby]

        public static List<Purchase> Searchby(string no, string date, string dateTo, string party)
        {
            string q = " SELECT " + PURCHASE.PURCHASE_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PURCHASE.PURCHASE_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_NO + " = '" + no + "'\r\n";
            }



            if (dateTo != "")
            {

                q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_DATE + "  BETWEEN " + ConvertTO.SqlDate(date) + " AND " + ConvertTO.SqlDate(dateTo) + " \r\n";
            }
            else
            {
                if (date != "")
                {

                    q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
                }

            }

            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ENTRY_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Searchby]

        #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_NO + " \r\n";
            q += " FROM  " + PURCHASE.PURCHASE_TBL + " \r\n";
            q += " WHERE " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ENTRY_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + PURCHASE.PURCHASE_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ENTRY_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_DATE + " \r\n";
            q += " FROM  " + PURCHASE.PURCHASE_TBL + " \r\n";
            q += " WHERE " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ENTRY_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(PURCHASE.PURCHASE_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][PURCHASE.PURCHASE_DATE] + "")
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
                string q = "SELECT " + PURCHASE.ENTRY_NO + " FROM " + PURCHASE.PURCHASE_TBL + "\r\n";
                q += " WHERE " + PURCHASE.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " AND " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
                q += " ORDER BY " + PURCHASE.ENTRY_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[PURCHASE.ENTRY_NO].ToString())) + 1).ToString();
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
                Purchase obj = PKId(pkValue, new DAL());
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
            Purchase obj = PKId(Id, new DAL());

            if (obj != null)
            {
                return obj.Purchase_no;
            }
            return "";
        }

        public static string GetId_Name(string No)
        {
            List<Purchase> list = Searchby(No, "", "", "");

            if (list.Count != 0)
            {
                return list[0].Purchase_id;
            }
            return "";
        }

        #endregion[Get id - No] 

    }//cls
}//ns
