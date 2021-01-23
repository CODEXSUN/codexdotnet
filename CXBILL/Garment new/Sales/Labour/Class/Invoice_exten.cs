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
    public class COffset_labour_exten
    {
        #region[Entity Data]

        private static Offset_labour EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_labour obj = new Offset_labour()
                    {
                        Offset_labour_id = redr[OFFSET_LABOUR.OFFSET_LABOUR_ID].ToString(),
                        Uniqueno = redr[OFFSET_LABOUR.UNIQUENO].ToString(),
                        Company_id = redr[OFFSET_LABOUR.COMPANY_ID].ToString(),
                        Acy_id = redr[OFFSET_LABOUR.ACY_ID].ToString(),
                        Offset_labour_no = Convert.ToInt32(redr[OFFSET_LABOUR.OFFSET_LABOUR_NO].ToString()),
                        Offset_labour_date = redr[OFFSET_LABOUR.OFFSET_LABOUR_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[OFFSET_LABOUR.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[OFFSET_LABOUR.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[OFFSET_LABOUR.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[OFFSET_LABOUR.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[OFFSET_LABOUR.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[OFFSET_LABOUR.GSTTOTAL].ToString()),
                        Ledger_id = redr[OFFSET_LABOUR.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[OFFSET_LABOUR.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[OFFSET_LABOUR.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[OFFSET_LABOUR.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[OFFSET_LABOUR.REFERED_AMT].ToString()),
                        Locked = redr[OFFSET_LABOUR.LOCKED].ToString(),
                        Notes = redr[OFFSET_LABOUR.NOTES].ToString(),
                        Active_id = redr[OFFSET_LABOUR.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Offset_labour();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Offset_labour> EntityList(string q)
        {
            List<Offset_labour> list = new List<Offset_labour>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_labour obj = new Offset_labour()
                    {
                        Offset_labour_id = redr[OFFSET_LABOUR.OFFSET_LABOUR_ID].ToString(),
                        Uniqueno = redr[OFFSET_LABOUR.UNIQUENO].ToString(),
                        Company_id = redr[OFFSET_LABOUR.COMPANY_ID].ToString(),
                        Acy_id = redr[OFFSET_LABOUR.ACY_ID].ToString(),
                        Offset_labour_no = Convert.ToInt32(redr[OFFSET_LABOUR.OFFSET_LABOUR_NO].ToString()),
                        Offset_labour_date = redr[OFFSET_LABOUR.OFFSET_LABOUR_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[OFFSET_LABOUR.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[OFFSET_LABOUR.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[OFFSET_LABOUR.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[OFFSET_LABOUR.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[OFFSET_LABOUR.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[OFFSET_LABOUR.GSTTOTAL].ToString()),
                        Ledger_id = redr[OFFSET_LABOUR.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[OFFSET_LABOUR.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[OFFSET_LABOUR.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[OFFSET_LABOUR.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[OFFSET_LABOUR.REFERED_AMT].ToString()),
                        Locked = redr[OFFSET_LABOUR.LOCKED].ToString(),
                        Notes = redr[OFFSET_LABOUR.NOTES].ToString(),
                        Active_id = redr[OFFSET_LABOUR.ACTIVE_ID].ToString(),
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

        public static List<Offset_labour> Unrefer(DAL DAL)
        {
            string q = " SELECT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + ".* \r\n";

            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";

            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";

            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Unrefer]

        #region[refer]

        public static List<Offset_labour> Refer(DAL DAL)
        {
            string q = " SELECT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";

            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";

            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[refer]

        #region[showall]

        public static List<Offset_labour> Showall(DAL DAL)
        {
            string q = " SELECT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";

            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";

            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[showall]

        #region[not active]

        public static List<Offset_labour> Notactive(DAL DAL)
        {
            string q = " SELECT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";

            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";

            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND NOT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[not active]

        #region[PKId]

        public static Offset_labour PKId(string id, DAL DAL)
        {
            string q = " SELECT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";

            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";

            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + " = '" + id + "' \r\n";
            q += " AND NOT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_NO + ";\r\n";

            return EntityData(q);
        }

        #endregion[PKId]

        #region[Searchby]

        public static List<Offset_labour> Searchby(string no, string date, string dateTo, string party, DAL DAL)
        {
            string q = " SELECT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";

            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";

            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_NO + " = '" + no + "'\r\n";
            }



            if (dateTo != "")
            {

                q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_DATE + "  BETWEEN " + ConvertTO.SqlDate(date) + " AND " + ConvertTO.SqlDate(dateTo) + " \r\n";
            }
            else
            {
                if (date != "")
                {

                    q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
                }

            }

            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Searchby]

        #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_NO + " \r\n";
            q += " FROM  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + " \r\n";
            q += " WHERE " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_DATE + " \r\n";
            q += " FROM  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + " \r\n";
            q += " WHERE " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(OFFSET_LABOUR.OFFSET_LABOUR_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][OFFSET_LABOUR.OFFSET_LABOUR_DATE] + "")
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
                string q = "SELECT " + OFFSET_LABOUR.OFFSET_LABOUR_NO + " FROM " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "\r\n";
                q += " WHERE " + OFFSET_LABOUR.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + OFFSET_LABOUR.OFFSET_LABOUR_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[OFFSET_LABOUR.OFFSET_LABOUR_NO].ToString())) + 1);
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
                Offset_labour obj = PKId(pkValue, new DAL());
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
            Offset_labour obj = PKId(Id, new DAL());

            if (obj != null)
            {
                return obj.Offset_labour_no.ToString();
            }
            return "";
        }

        public static string GetId_Name(string No)
        {
            List<Offset_labour> list = Searchby(No, "", "", "", new DAL());

            if (list.Count != 0)
            {
                return list[0].Offset_labour_id;
            }
            return "";
        }

        public static string FindInvoiceGstTotal(string No)
        {
            List<Offset_labour> list = Searchby(No, "", "", "", new DAL());

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
