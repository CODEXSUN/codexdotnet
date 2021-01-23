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
    public class CQuotation_exten
    {
        #region[Entity Data]

        private static Quotation EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Quotation obj = new Quotation()
                    {
                        Quotation_id = redr[QUOTATION.QUOTATION_ID].ToString(),
                        Quotation_no = redr[QUOTATION.QUOTATION_NO].ToString(),
                        Quotation_date = redr[QUOTATION.QUOTATION_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[QUOTATION.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[QUOTATION.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Ledger_id = redr[QUOTATION.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[QUOTATION.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[QUOTATION.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[QUOTATION.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[QUOTATION.REFERED_AMT].ToString()),
                        Locked = redr[QUOTATION.LOCKED].ToString(),
                        Notes = redr[QUOTATION.NOTES].ToString(),
                        Active_id = redr[QUOTATION.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Quotation();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Quotation> EntityList(string q)
        {
            List<Quotation> list = new List<Quotation>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Quotation obj = new Quotation()
                    {
                        Quotation_id = redr[QUOTATION.QUOTATION_ID].ToString(),
                        Quotation_no = redr[QUOTATION.QUOTATION_NO].ToString(),
                        Quotation_date = redr[QUOTATION.QUOTATION_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Total_qty = ConvertTO.Decimal(redr[QUOTATION.TOTAL_QTY].ToString()),
                        Total_taxable_amount = ConvertTO.Decimal(redr[QUOTATION.TOTAL_TAXABLE_AMOUNT].ToString()),
                        Ledger_id = redr[QUOTATION.LEDGER_ID].ToString(),
                        Additional = ConvertTO.Decimal(redr[QUOTATION.ADDITIONAL].ToString()),
                        Rounds = ConvertTO.Decimal(redr[QUOTATION.ROUNDS].ToString()),
                        Grandtotal = ConvertTO.Decimal(redr[QUOTATION.GRANDTOTAL].ToString()),
                        Refered_amt = ConvertTO.Decimal(redr[QUOTATION.REFERED_AMT].ToString()),
                        Locked = redr[QUOTATION.LOCKED].ToString(),
                        Notes = redr[QUOTATION.NOTES].ToString(),
                        Active_id = redr[QUOTATION.ACTIVE_ID].ToString(),
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

        public static List<Quotation> Unrefer(DAL DAL)
        {
            string q = " SELECT " + QUOTATION.QUOTATION_TBL + ".* \r\n";

            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + QUOTATION.QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Unrefer]

        #region[refer]

        public static List<Quotation> Refer(DAL DAL)
        {
            string q = " SELECT " + QUOTATION.QUOTATION_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + QUOTATION.QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[refer]

        #region[showall]

        public static List<Quotation> Showall(DAL DAL)
        {
            string q = " SELECT " + QUOTATION.QUOTATION_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + QUOTATION.QUOTATION_TBL + " \r\n";

            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[showall]

        #region[not active]

        public static List<Quotation> Notactive(DAL DAL)
        {
            string q = " SELECT " + QUOTATION.QUOTATION_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + QUOTATION.QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND NOT " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[not active]

        #region[PKId]

        public static Quotation PKId(string id, DAL DAL)
        {
            string q = " SELECT " + QUOTATION.QUOTATION_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + QUOTATION.QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_ID + " = '" + id + "' \r\n";
            q += " AND NOT " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_NO + ";\r\n";

            return EntityData(q);
        }

        #endregion[PKId]

        #region[Searchby]

        public static List<Quotation> Searchby(string no, string date, string dateTo, string party, DAL DAL)
        {
            string q = " SELECT " + QUOTATION.QUOTATION_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + QUOTATION.QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_NO + " = '" + no + "'\r\n";
            }

            if (dateTo != "")
            {

                q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_DATE + "  BETWEEN " + ConvertTO.SqlDate(date) + " AND " + ConvertTO.SqlDate(dateTo) + " \r\n";
            }
            else
            {
                if (date != "")
                {

                    q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
                }

            }

            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Searchby]

        #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_NO + " \r\n";
            q += " FROM  " + QUOTATION.QUOTATION_TBL + " \r\n";
            q += " WHERE " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + QUOTATION.QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_DATE + " \r\n";
            q += " FROM  " + QUOTATION.QUOTATION_TBL + " \r\n";
            q += " WHERE " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
            q += " ORDER BY  " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(QUOTATION.QUOTATION_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][QUOTATION.QUOTATION_DATE] + "")
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
                string q = "SELECT " + QUOTATION.QUOTATION_NO + " FROM " + QUOTATION.QUOTATION_TBL + "\r\n";
                q += " WHERE " + QUOTATION.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " AND " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
                q += " ORDER BY " + QUOTATION.QUOTATION_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[QUOTATION.QUOTATION_NO].ToString())) + 1);
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
                Quotation obj = PKId(pkValue, new DAL());
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
            Quotation obj = PKId(Id, new DAL());

            if (obj != null)
            {
                return obj.Quotation_no.ToString();
            }
            return "";
        }

        public static string GetId_Name(string No)
        {
            List<Quotation> list = Searchby(No, "", "", "", new DAL());

            if (list.Count != 0)
            {
                return list[0].Quotation_id;
            }
            return "";
        }

        #endregion[Get id - No] 

        public static decimal GetBalance(string party_id)
        {
            if (party_id != null)
            {

                string opening_q = "SELECT " + PARTY.CREDIT_DAYS + " FROM " + PARTY.PARTY_TBL + " WHERE " + PARTY.PARTY_ID + " = '" + party_id + "'";
                string grand_q = "SELECT SUM(" + QUOTATION.GRANDTOTAL + ") " + QUOTATION.GRANDTOTAL + " FROM " + QUOTATION.QUOTATION_TBL + " WHERE " + QUOTATION.PARTY_ID + "= '" + party_id + "'";
                string Receipt_q = "SELECT SUM(" + QRECEIPT.QRECEIPT_AMOUNT + ") " + QRECEIPT.QRECEIPT_AMOUNT + " FROM " + QRECEIPT.QRECEIPT_TBL + " WHERE " + QRECEIPT.PARTY_ID + " = '" + party_id + "'";

                string vOpening = new DAL().ExecuteScalar(opening_q).ToString();
                string vGrand = new DAL().ExecuteScalar(grand_q).ToString();
                string vReceipt = new DAL().ExecuteScalar(Receipt_q).ToString();

                decimal balance = (ConvertTO.Decimal(vOpening) + ConvertTO.Decimal(vGrand)) - ConvertTO.Decimal(vReceipt);

                return balance;
            }
            return 0;
        }

    }//cls
}//ns
