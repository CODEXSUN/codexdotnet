// Version : 4 dt : 04-10-2017
// Auto Generated
// 05-10-2017 10:43:27 AM
// last update : 05-10-2017

using System;
using System.Collections.Generic;
using System.Data;
using CXBILL;
using CXCORE;
using CXERP;
using CXLIB;
using LABOUR = CXBILL_EXTEN.Labour.Const.LABOUR;

namespace CXBILL_EXTEN.Labour.Class
{
    public static class CLabour_exten
    {
        #region[Entity Data]

        private static Const.Labour EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Const.Labour obj = new Const.Labour()
                    {
                        Labour_id = redr[LABOUR.LABOUR_ID].ToString(),
                        Uniqueno = redr[LABOUR.UNIQUENO].ToString(),
                        Company_id = redr[LABOUR.COMPANY_ID].ToString(),
                        Acy_id = redr[LABOUR.ACY_ID].ToString(),
                        Order_id = redr[ORDER.ORDER_NO].ToString(),
                        Labour_no = redr[LABOUR.LABOUR_NO].ToString(),
                        Labour_date = redr[LABOUR.LABOUR_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Transport_id = redr[TRANSPORT.TRANSPORT_NAME].ToString(),
                        Deliveredto_id = redr[DELIVEREDTO.DELIVEREDTO_NAME].ToString(),
                        Bundel = redr[LABOUR.BUNDEL].ToString(),
                        Total_qty = redr[LABOUR.TOTAL_QTY].ToString(),
                        Total_taxable_amount = ConvertTO.Decimal(redr[LABOUR.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[LABOUR.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[LABOUR.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[LABOUR.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[LABOUR.GSTTOTAL].ToString()),
                        Ledger_id = redr[LABOUR.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[LABOUR.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[LABOUR.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[LABOUR.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[LABOUR.REFERED_AMT].ToString()),
                        Locked = redr[LABOUR.LOCKED].ToString(),
                        Notes = redr[LABOUR.NOTES].ToString(),
                        Active_id = redr[LABOUR.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Const.Labour();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Const.Labour> EntityList(string q)
        {
            List<Const.Labour> list = new List<Const.Labour>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Const.Labour obj = new Const.Labour()
                    {
                        Labour_id = redr[LABOUR.LABOUR_ID].ToString(),
                        Uniqueno = redr[LABOUR.UNIQUENO].ToString(),
                        Company_id = redr[LABOUR.COMPANY_ID].ToString(),
                        Acy_id = redr[LABOUR.ACY_ID].ToString(),
                        Order_id = redr[ORDER.ORDER_NO].ToString(),
                        Labour_no = redr[LABOUR.LABOUR_NO].ToString(),
                        Labour_date = redr[LABOUR.LABOUR_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Salestype_id = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Transport_id = redr[TRANSPORT.TRANSPORT_NAME].ToString(),
                        Deliveredto_id = redr[DELIVEREDTO.DELIVEREDTO_NAME].ToString(),
                        Bundel = redr[LABOUR.BUNDEL].ToString(),
                        Total_qty = redr[LABOUR.TOTAL_QTY].ToString(),
                        Total_taxable_amount = ConvertTO.Decimal(redr[LABOUR.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Total_cgst = ConvertTO.Decimal(redr[LABOUR.TOTAL_CGST].ToString()),
                        Total_sgst = ConvertTO.Decimal(redr[LABOUR.TOTAL_SGST].ToString()),
                        Total_igst = ConvertTO.Decimal(redr[LABOUR.TOTAL_IGST].ToString()),
                        Gsttotal = ConvertTO.Decimal(redr[LABOUR.GSTTOTAL].ToString()),
                        Ledger_id = redr[LABOUR.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[LABOUR.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[LABOUR.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[LABOUR.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[LABOUR.REFERED_AMT].ToString()),
                        Locked = redr[LABOUR.LOCKED].ToString(),
                        Notes = redr[LABOUR.NOTES].ToString(),
                        Active_id = redr[LABOUR.ACTIVE_ID].ToString(),
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

        public static List<Const.Labour> Unrefer()
        {
            string q = " SELECT " + LABOUR.LABOUR_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LABOUR.LABOUR_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + DELIVEREDTO.DELIVEREDTO_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.DELIVEREDTO_ID + " = " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LABOUR.LABOUR_TBL + "." + LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Unrefer]

        #region[refer]

        public static List<Const.Labour> Refer()
        {
            string q = " SELECT " + LABOUR.LABOUR_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LABOUR.LABOUR_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + DELIVEREDTO.DELIVEREDTO_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.DELIVEREDTO_ID + " = " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LABOUR.LABOUR_TBL + "." + LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + LABOUR.LABOUR_TBL + "." + LABOUR.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[refer]

        #region[showall]

        public static List<Const.Labour> Showall()
        {
            string q = " SELECT " + LABOUR.LABOUR_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LABOUR.LABOUR_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + DELIVEREDTO.DELIVEREDTO_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.DELIVEREDTO_ID + " = " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LABOUR.LABOUR_TBL + "." + LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[showall]

        #region[not active]

        public static List<Const.Labour> Notactive()
        {
            string q = " SELECT " + LABOUR.LABOUR_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LABOUR.LABOUR_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + DELIVEREDTO.DELIVEREDTO_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.DELIVEREDTO_ID + " = " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LABOUR.LABOUR_TBL + "." + LABOUR.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND NOT " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[not active]

        #region[PKId]

        public static Const.Labour PKId(string id)
        {
            string q = " SELECT " + LABOUR.LABOUR_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LABOUR.LABOUR_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + DELIVEREDTO.DELIVEREDTO_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.DELIVEREDTO_ID + " = " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_ID + " = '" + id + "' \r\n";
            q += " AND NOT " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_NO + ";\r\n";

            return EntityData(q);
        }

        #endregion[PKId]

        #region[Searchby]

        public static List<Const.Labour> Searchby(string no, string date, string dateTo, string party)
        {
            string q = " SELECT " + LABOUR.LABOUR_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + " \r\n";
            q += ", " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + " \r\n";
            q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + LABOUR.LABOUR_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + TAXTYPE.TAXTYPE_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.TAXTYPE_ID + " = " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + SALESTYPE.SALESTYPE_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.SALESTYPE_ID + " = " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + DELIVEREDTO.DELIVEREDTO_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.DELIVEREDTO_ID + " = " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + LABOUR.LABOUR_TBL + "." + LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_NO + " = '" + no + "'\r\n";
            }



            if (dateTo != "")
            {

                q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_DATE + "  BETWEEN " + ConvertTO.SqlDate(date) + " AND " + ConvertTO.SqlDate(dateTo) + " \r\n";
            }
            else
            {
                if (date != "")
                {

                    q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
                }

            }

            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Searchby]

        #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_NO + " \r\n";
            q += " FROM  " + LABOUR.LABOUR_TBL + " \r\n";
            q += " WHERE " + LABOUR.LABOUR_TBL + "." + LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + LABOUR.LABOUR_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + LABOUR.LABOUR_TBL + "." + LABOUR.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + LABOUR.LABOUR_TBL + "." + LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_DATE + " \r\n";
            q += " FROM  " + LABOUR.LABOUR_TBL + " \r\n";
            q += " WHERE " + LABOUR.LABOUR_TBL + "." + LABOUR.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(LABOUR.LABOUR_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][LABOUR.LABOUR_DATE] + "")
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
                string q = "SELECT " + LABOUR.LABOUR_NO + " FROM " + LABOUR.LABOUR_TBL + "\r\n";
                q += " WHERE " + LABOUR.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " AND " + LABOUR.LABOUR_TBL + "." + LABOUR.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
                q += " ORDER BY " + LABOUR.LABOUR_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[LABOUR.LABOUR_NO].ToString())) + 1);
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
                Const.Labour obj = PKId(pkValue);
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
            Const.Labour obj = PKId(Id);

            if (obj != null)
            {
                return obj.Labour_no.ToString();
            }
            return "";
        }

        public static string GetId_Name(string No)
        {
            List<Const.Labour> list = Searchby(No, "", "", "");

            if (list.Count != 0)
            {
                return list[0].Labour_id;
            }
            return "";
        }

        public static string FindLabourGstTotal(string No)
        {
            List<Const.Labour> list = Searchby(No, "", "", "");

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
                string grand_q = "SELECT SUM(" + LABOUR.GRANDTOTAL + ") " + LABOUR.GRANDTOTAL + " FROM " + LABOUR.LABOUR_TBL + " WHERE " + LABOUR.PARTY_ID + "= '" + party_id + "'";
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
