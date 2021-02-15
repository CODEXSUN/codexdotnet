// Version : 5.0.0.0 Date : 27-01-2021
// Auto Generated
// last update : 28-01-2021 10:30:12 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXERP
{
    public static class CInward_exten
    {
         #region[Entity Data]

        private static Inward EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Inward obj = new Inward()
                    {
                        Inward_id = redr[INWARD.INWARD_ID].ToString(),
                        Uniqueno = redr[INWARD.UNIQUENO].ToString(),
                        Company_id = redr[INWARD.COMPANY_ID].ToString(),
                        Acy_id = redr[INWARD.ACY_ID].ToString(),
                        Order_id = redr[ORDER.ORDER_NO].ToString(),
                        Inward_no = redr[INWARD.INWARD_NO].ToString(),
                        Inward_date = redr[INWARD.INWARD_DATE].ToString(),
                        Party_dcno = redr[INWARD.PARTY_DCNO].ToString(),
                        Party_id = redr[INWARD.PARTY_ID].ToString(),
                        Total_bundel = redr[INWARD.TOTAL_BUNDEL].ToString(),
                        Total_qty = redr[INWARD.TOTAL_QTY].ToString(),
                        Refered_qty = redr[INWARD.REFERED_QTY].ToString(),
                        Locked = redr[INWARD.LOCKED].ToString(),
                        Notes = redr[INWARD.NOTES].ToString(),
                        Active_id = redr[INWARD.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Inward();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Inward> EntityList(string q)
         {
             List<Inward> list = new List<Inward>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Inward obj = new Inward()
                     {
                        Inward_id = redr[INWARD.INWARD_ID].ToString(),
                        Uniqueno = redr[INWARD.UNIQUENO].ToString(),
                        Company_id = redr[INWARD.COMPANY_ID].ToString(),
                        Acy_id = redr[INWARD.ACY_ID].ToString(),
                        Order_id = redr[ORDER.ORDER_NO].ToString(),
                        Inward_no = redr[INWARD.INWARD_NO].ToString(),
                        Inward_date = redr[INWARD.INWARD_DATE].ToString(),
                        Party_dcno = redr[INWARD.PARTY_DCNO].ToString(),
                        Party_id = redr[INWARD.PARTY_ID].ToString(),
                        Total_bundel = redr[INWARD.TOTAL_BUNDEL].ToString(),
                        Total_qty = redr[INWARD.TOTAL_QTY].ToString(),
                        Refered_qty = redr[INWARD.REFERED_QTY].ToString(),
                        Locked = redr[INWARD.LOCKED].ToString(),
                        Notes = redr[INWARD.NOTES].ToString(),
                        Active_id = redr[INWARD.ACTIVE_ID].ToString(),
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

         public static List<Inward> Unrefer()
         {
            string q = " SELECT " + INWARD.INWARD_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + INWARD.INWARD_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + INWARD.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + INWARD.INWARD_TBL + "." + INWARD.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + INWARD.INWARD_TBL + "." + INWARD.INWARD_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + INWARD.INWARD_TBL + "." + INWARD.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + INWARD.INWARD_TBL + "." + INWARD.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + INWARD.INWARD_TBL + "." + INWARD.INWARD_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<Inward> Refer()
         {
            string q = " SELECT " + INWARD.INWARD_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + INWARD.INWARD_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + INWARD.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + INWARD.INWARD_TBL + "." + INWARD.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + INWARD.INWARD_TBL + "." + INWARD.INWARD_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + INWARD.INWARD_TBL + "." + INWARD.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + INWARD.INWARD_TBL + "." + INWARD.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + INWARD.INWARD_TBL + "." + INWARD.INWARD_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<Inward> Showall()
         {
            string q = " SELECT " + INWARD.INWARD_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + INWARD.INWARD_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + INWARD.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + INWARD.INWARD_TBL + "." + INWARD.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + INWARD.INWARD_TBL + "." + INWARD.INWARD_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + INWARD.INWARD_TBL + "." + INWARD.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + INWARD.INWARD_TBL + "." + INWARD.INWARD_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<Inward> Notactive()
         {
            string q = " SELECT " + INWARD.INWARD_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + INWARD.INWARD_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + INWARD.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + INWARD.INWARD_TBL + "." + INWARD.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND NOT " + INWARD.INWARD_TBL + "." + INWARD.INWARD_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + INWARD.INWARD_TBL + "." + INWARD.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + INWARD.INWARD_TBL + "." + INWARD.INWARD_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static Inward PKId(string id)
         {
            string q = " SELECT " + INWARD.INWARD_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + INWARD.INWARD_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + INWARD.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + INWARD.INWARD_TBL + "." + INWARD.INWARD_ID + " = '" + id + "' \r\n";
            q += " AND NOT " + INWARD.INWARD_TBL + "." + INWARD.INWARD_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + INWARD.INWARD_TBL + "." + INWARD.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + INWARD.INWARD_TBL + "." + INWARD.INWARD_NO + ";\r\n";

             return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<Inward> Searchby(string no, string date, string dateTo, string party)
         {
            string q = " SELECT " + INWARD.INWARD_TBL + ".* \r\n";
            q += ", " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + INWARD.INWARD_TBL + " \r\n";
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + INWARD.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + INWARD.INWARD_TBL + "." + INWARD.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + INWARD.INWARD_TBL + "." + INWARD.INWARD_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + INWARD.INWARD_TBL + "." + INWARD.INWARD_NO + " = '" + no + "'\r\n";
            }
            if (dateTo != "")
            {
                q += " AND " + INWARD.INWARD_TBL + "." + INWARD.INWARD_DATE + "  BETWEEN " + ConvertTO.SqlDate(date) + " AND " + ConvertTO.SqlDate(dateTo) + "\r\n";
            }
            else if (date != "")
            {

                q += " AND " + INWARD.INWARD_TBL + "." + INWARD.INWARD_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + INWARD.INWARD_TBL + "." + INWARD.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + INWARD.INWARD_TBL + "." + INWARD.INWARD_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + INWARD.INWARD_TBL + "." + INWARD.INWARD_NO + " \r\n";
            q += " FROM  " + INWARD.INWARD_TBL + " \r\n";
            q += " WHERE " + INWARD.INWARD_TBL + "." + INWARD.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + INWARD.INWARD_TBL + "." + INWARD.INWARD_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + INWARD.INWARD_TBL + "." + INWARD.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + INWARD.INWARD_TBL + "." + INWARD.INWARD_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        public static DataTable LookupParty()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + INWARD.INWARD_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + INWARD.INWARD_TBL + "." + INWARD.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + INWARD.INWARD_TBL + "." + INWARD.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + INWARD.INWARD_TBL + "." + INWARD.INWARD_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + INWARD.INWARD_TBL + "." + INWARD.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + INWARD.INWARD_TBL + "." + INWARD.INWARD_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        public static DataTable LookupDate()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + INWARD.INWARD_TBL + "." + INWARD.INWARD_DATE + " \r\n";
            q += " FROM  " + INWARD.INWARD_TBL + " \r\n";
            q += " WHERE " + INWARD.INWARD_TBL + "." + INWARD.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + INWARD.INWARD_TBL + "." + INWARD.INWARD_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + INWARD.INWARD_TBL + "." + INWARD.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + INWARD.INWARD_TBL + "." + INWARD.INWARD_NO + ";\r\n";

            DataTable xtbl = new DAL().Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(INWARD.INWARD_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][INWARD.INWARD_DATE] + "")
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
                string q = "SELECT " + INWARD.INWARD_NO + " FROM " + INWARD.INWARD_TBL + "\r\n";
                q += " WHERE " + INWARD.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + INWARD.INWARD_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[INWARD.INWARD_NO].ToString())) + 1).ToString();
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
                Inward obj = PKId(pkValue);
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
            Inward obj = PKId(_pId);

             if (obj != null)
            {
                return obj.Inward_no;
            }
            return "";
        }

         public static string GetId_Name(string _pName)
        {
            var list = Searchby("","","",_pName);

             if (list.Count != 0)
            {
                return list[0].Inward_id;
            }
            return "";
        }

         #endregion[Get id - FieldsName]

    }//cls
}//ns
