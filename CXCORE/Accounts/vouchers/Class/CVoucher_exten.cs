// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:21:27 PM

using System.Data;
using CodexsunLib;
using System.Collections.Generic;
using System;

namespace CodexsunCore
{
    public class CVoucher_exten
    {
        #region[Entity Data]

        private static Voucher EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Voucher obj = new Voucher()
                    {
                        Voucher_id = redr[VOUCHER.VOUCHER_ID].ToString(),
                        Company_id = redr[VOUCHER.COMPANY_ID].ToString(),
                        Voucher_no = redr[VOUCHER.VOUCHER_NO].ToString(),
                        Voucher_date = redr[VOUCHER.VOUCHER_DATE].ToString(),
                        Vouchertype_id = redr[VOUCHERTYPE.VOUCHERTYPE_NAME].ToString(),
                        Order_id = redr[ORDER.ORDER_NAME].ToString(),
                        Ledger_id = redr[LEDGER.LEDGER_NAME].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Purpose = redr[VOUCHER.PURPOSE].ToString(),
                        Credit = redr[VOUCHER.CREDIT].ToString(),
                        Debit = redr[VOUCHER.DEBIT].ToString(),
                        Notes = redr[VOUCHER.NOTES].ToString(),
                        Active_id = redr[VOUCHER.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Voucher();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Voucher> EntityList(string q)
        {
            List<Voucher> list = new List<Voucher>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Voucher obj = new Voucher()
                    {
                        Voucher_id = redr[VOUCHER.VOUCHER_ID].ToString(),
                        Company_id = redr[VOUCHER.COMPANY_ID].ToString(),
                        Voucher_no = redr[VOUCHER.VOUCHER_NO].ToString(),
                        Voucher_date = redr[VOUCHER.VOUCHER_DATE].ToString(),
                        Vouchertype_id = redr[VOUCHERTYPE.VOUCHERTYPE_NAME].ToString(),
                        Order_id = redr[ORDER.ORDER_NAME].ToString(),
                        Ledger_id = redr[LEDGER.LEDGER_NAME].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Purpose = redr[VOUCHER.PURPOSE].ToString(),
                        Credit = redr[VOUCHER.CREDIT].ToString(),
                        Debit = redr[VOUCHER.DEBIT].ToString(),
                        Notes = redr[VOUCHER.NOTES].ToString(),
                        Active_id = redr[VOUCHER.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };

                    list.Add(obj);
                }

                redr.Close();
            }
            return list;
        }

        #endregion[Entity List]

        #region[Active]

        public static List<Voucher> Active(DAL DAL)
        {
            string q = " SELECT " + VOUCHER.VOUCHER_TBL + ".* \r\n";
            q += ", " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_NAME + " \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NAME + " \r\n";
            q += ", " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " INNER JOIN  " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + " = " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + ORDER.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + ")\r\n";
            q += " INNER JOIN  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + LEDGER.LEDGER_ID + " = " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_ID + ")\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VOUCHER.VOUCHER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Voucher> NotActive(DAL DAL)
        {
            string q = " SELECT " + VOUCHER.VOUCHER_TBL + ".* \r\n";
            q += ", " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_NAME + " \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NAME + " \r\n";
            q += ", " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " INNER JOIN  " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + " = " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + ORDER.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + ")\r\n";
            q += " INNER JOIN  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + LEDGER.LEDGER_ID + " = " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_ID + ")\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VOUCHER.VOUCHER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Voucher PKId(string v, DAL DAL)
        {
            string q = " SELECT " + VOUCHER.VOUCHER_TBL + ".* \r\n";
            q += ", " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_NAME + " \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NAME + " \r\n";
            q += ", " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " INNER JOIN  " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + " = " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + ORDER.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + ")\r\n";
            q += " INNER JOIN  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + LEDGER.LEDGER_ID + " = " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_ID + ")\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VOUCHER.VOUCHER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Voucher SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + VOUCHER.VOUCHER_TBL + ".* \r\n";
            q += ", " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_NAME + " \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NAME + " \r\n";
            q += ", " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " INNER JOIN  " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + " = " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + ORDER.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + ")\r\n";
            q += " INNER JOIN  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + LEDGER.LEDGER_ID + " = " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_ID + ")\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VOUCHER.VOUCHER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_NO + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_NO + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Search by name]


        public static List<Voucher> Searchfilter(string vno, string vno_1, string vdate, string vdate_1, string vtype, string vorder, string vledger, string vparty, string vpurpose, DAL DAL)
        {
            string q = " SELECT " + VOUCHER.VOUCHER_TBL + ".* \r\n";
            q += ", " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_NAME + " \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NAME + " \r\n";
            q += ", " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " INNER JOIN  " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + " = " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + ORDER.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + ")\r\n";
            q += " INNER JOIN  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + LEDGER.LEDGER_ID + " = " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_ID + ")\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VOUCHER.VOUCHER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE  1 = 1\r\n";

            if (vno_1 != "")
            {
                q += " AND " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_NO + " BETWEEN '" + vno + "' AND '" + vno_1 + "' \r\n";
            }
            else
            {
                if (vno != "")
                {
                    q += " AND " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_NO + "  = '" + vno + "' \r\n";
                }
            }

            if (vdate_1 != "")
            {
                q += " AND " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_DATE + "  BETWEEN " + ConvertTO.SqlDate(vdate) + " AND " + ConvertTO.SqlDate(vdate_1) + " \r\n";
            }
            else
            {
                if (vdate != "")
                {
                    q += " AND " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_DATE + "  = " + ConvertTO.SqlDate(vdate) + " \r\n";
                }
            }

            if (vtype != null)
            {
                if (vtype != "")
                {
                    q += " AND " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHERTYPE_ID + "  = '" + vtype + "' \r\n";
                }
            }

            if (vorder != null)
            {
                if (vorder != "")
                {
                    q += " AND " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.ORDER_ID + "  = '" + vorder + "' \r\n";
                }
            }

            if (vledger != null)
            {
                if (vledger != "")
                {
                    q += " AND " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.LEDGER_ID + "  = '" + vledger + "' \r\n";
                }
            }

            if (vparty != null)
            {
                if (vparty != "") 
                {
                    q += " AND " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.PARTY_ID + "  = '" + vparty + "' \r\n";
                }
            }

                if (vpurpose != "")
                {
                    q += " AND " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.PURPOSE + "  = '" + vpurpose + "' \r\n";
                }

            q += " ORDER BY  " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + VOUCHER.VOUCHER_TBL + ".* \r\n";
            q += ", " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_NAME + " \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NAME + " \r\n";
            q += ", " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " INNER JOIN  " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + " = " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + ORDER.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + ")\r\n";
            q += " INNER JOIN  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + LEDGER.LEDGER_ID + " = " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_ID + ")\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + PARTY.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VOUCHER.VOUCHER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_NO + ";\r\n";

            return DAL.Listdata(q);
        }


        public static DataTable Voucher_no_lookup(DAL DAL)
        {
            string q = " SELECT * FROM " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " ORDER BY  " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable Voucher_date_lookup(DAL DAL)
        {
            string q = " SELECT DISTINCT " + VOUCHER.VOUCHER_DATE + " FROM " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " ORDER BY  " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(VOUCHER.VOUCHER_DATE, typeof(string));

            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][VOUCHER.VOUCHER_DATE] + "")
                    );
                }
            }
            return tbl;

        }

        public static DataTable Vouchertype_lookup(DAL DAL)
        {
            string q = " SELECT DISTINCT \r\n";
            q += VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_NAME + " \r\n";
            q += " FROM  " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " INNER JOIN  " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHERTYPE_ID + " = " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + ");\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable Orderref_lookup(DAL DAL)
        {
            string q = " SELECT DISTINCT \r\n";
            q += " " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NAME + " \r\n";
            q += " FROM  " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + ");\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable Ledger_lookup(DAL DAL)
        {
            string q = " SELECT DISTINCT \r\n";
            q += " " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_NAME + " \r\n";
            q += " FROM  " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " INNER JOIN  " + LEDGER.LEDGER_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.LEDGER_ID + " = " + LEDGER.LEDGER_TBL + "." + LEDGER.LEDGER_ID + ");\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable Party_lookup(DAL DAL)
        {
            string q = " SELECT DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + " \r\n";
            q += " ON( " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.LEDGER_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ");\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable Purpose_lookup(DAL DAL)
        {
            string q = " SELECT DISTINCT " + VOUCHER.PURPOSE + " FROM " + VOUCHER.VOUCHER_TBL + " \r\n";
            q += " ORDER BY  " + VOUCHER.VOUCHER_TBL + "." + VOUCHER.VOUCHER_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Voucher obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Voucher_no;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Voucher obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Voucher_id;
            }
            return "";
        }

        #endregion[Get id - Name]

        #region[GetNext_No]

        public static string GetNext_No
        {
            get
            {
                string q = "SELECT " + VOUCHER.VOUCHER_NO + " FROM " + VOUCHER.VOUCHER_TBL + "\r\n";
                q += " WHERE " + VOUCHER.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + VOUCHER.VOUCHER_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[VOUCHER.VOUCHER_NO].ToString())) + 1).ToString();
                    }
                    redr.Close();
                    return Core.One;
                }
            }
        }





        #endregion[GetNext_No]

        #region[Total]
        public static string GetDebitTotal
        {
            get
            {
                string q = "SELECT SUM(DEBIT) FROM VOUCHER_TBL";
                return new DAL().ExecuteScalar(q).ToString();
            }
        }

        public static string GetCreditTotal
        {
            get
            {
                string q = "SELECT SUM(CREDIT) FROM VOUCHER_TBL";
                return new DAL().ExecuteScalar(q).ToString();
            }
        }

        #endregion[Total]

    }//cls
}//ns
