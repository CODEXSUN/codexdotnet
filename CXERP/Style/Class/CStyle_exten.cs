// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 14-06-2019 09:02:20 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXERP
{
    public static class CStyle_exten
    {
         #region[Entity Data]

        private static Style EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Style obj = new Style()
                    {
                        Style_id = redr[STYLE.STYLE_ID].ToString(),
                        Uniqueno = redr[STYLE.UNIQUENO].ToString(),
                        Company_id = redr[STYLE.COMPANY_ID].ToString(),
                        Acy_id = redr[STYLE.ACY_ID].ToString(),
                        Style_no = redr[STYLE.STYLE_NO].ToString(),
                        Style_date = redr[STYLE.STYLE_DATE].ToString(),
                        Locked = redr[STYLE.LOCKED].ToString(),
                        Notes = redr[STYLE.NOTES].ToString(),
                        Active_id = redr[STYLE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Style();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Style> EntityList(string q)
         {
             List<Style> list = new List<Style>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Style obj = new Style()
                     {
                        Style_id = redr[STYLE.STYLE_ID].ToString(),
                        Uniqueno = redr[STYLE.UNIQUENO].ToString(),
                        Company_id = redr[STYLE.COMPANY_ID].ToString(),
                        Acy_id = redr[STYLE.ACY_ID].ToString(),
                        Style_no = redr[STYLE.STYLE_NO].ToString(),
                        Style_date = redr[STYLE.STYLE_DATE].ToString(),
                        Locked = redr[STYLE.LOCKED].ToString(),
                        Notes = redr[STYLE.NOTES].ToString(),
                        Active_id = redr[STYLE.ACTIVE_ID].ToString(),
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

         public static List<Style> Unrefer()
         {
            string q = " SELECT " + STYLE.STYLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + STYLE.STYLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + STYLE.STYLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + STYLE.STYLE_TBL + "." + STYLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + STYLE.STYLE_TBL + "." + STYLE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + STYLE.STYLE_TBL + "." + STYLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_DATE + "\r\n";
            q += " ,  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<Style> Refer()
         {
            string q = " SELECT " + STYLE.STYLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + STYLE.STYLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + STYLE.STYLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + STYLE.STYLE_TBL + "." + STYLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + STYLE.STYLE_TBL + "." + STYLE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + STYLE.STYLE_TBL + "." + STYLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_DATE + "\r\n";
            q += " ,  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<Style> Showall()
         {
            string q = " SELECT " + STYLE.STYLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + STYLE.STYLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + STYLE.STYLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + STYLE.STYLE_TBL + "." + STYLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + STYLE.STYLE_TBL + "." + STYLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_DATE + "\r\n";
            q += " ,  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<Style> Notactive()
         {
            string q = " SELECT " + STYLE.STYLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + STYLE.STYLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + STYLE.STYLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + STYLE.STYLE_TBL + "." + STYLE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + STYLE.STYLE_TBL + "." + STYLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_DATE + "\r\n";
            q += " ,  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static Style PKId(string id)
         {
            string q = " SELECT " + STYLE.STYLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + STYLE.STYLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + STYLE.STYLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + STYLE.STYLE_TBL + "." + STYLE.STYLE_ID + " = '" + id + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + STYLE.STYLE_TBL + "." + STYLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_DATE + "\r\n";
            q += " ,  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_NO + ";\r\n";

            return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<Style> Searchby(string no, string date, string dateTo, string party)
         {
            string q = " SELECT " + STYLE.STYLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + STYLE.STYLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + STYLE.STYLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + STYLE.STYLE_TBL + "." + STYLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + STYLE.STYLE_TBL + "." + STYLE.STYLE_NO + " = '" + no + "'\r\n";
            }
            if (dateTo != "")
            {
                q += " AND " + STYLE.STYLE_TBL + "." + STYLE.STYLE_DATE + "  BETWEEN " + ConvertTO.SqlDate(date) + " AND " + ConvertTO.SqlDate(dateTo) + "\r\n";
            }
            else if (date != "")
            {

                q += " AND " + STYLE.STYLE_TBL + "." + STYLE.STYLE_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + STYLE.STYLE_TBL + "." + STYLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_DATE + "\r\n";
            q += " ,  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + STYLE.STYLE_TBL + "." + STYLE.STYLE_NO + " \r\n";
            q += " FROM  " + STYLE.STYLE_TBL + " \r\n";
            q += " WHERE " + STYLE.STYLE_TBL + "." + STYLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + STYLE.STYLE_TBL + "." + STYLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_DATE + "\r\n";
            q += " ,  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        public static DataTable LookupParty()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + STYLE.STYLE_TBL + " \r\n";
            q += " WHERE " + STYLE.STYLE_TBL + "." + STYLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + STYLE.STYLE_TBL + "." + STYLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_DATE + "\r\n";
            q += " ,  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        public static DataTable LookupDate()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + STYLE.STYLE_TBL + "." + STYLE.STYLE_DATE + " \r\n";
            q += " FROM  " + STYLE.STYLE_TBL + " \r\n";
            q += " WHERE " + STYLE.STYLE_TBL + "." + STYLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + STYLE.STYLE_TBL + "." + STYLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_DATE + "\r\n";
            q += " ,  " + STYLE.STYLE_TBL + "." + STYLE.STYLE_NO + ";\r\n";

            DataTable xtbl = new DAL().Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(STYLE.STYLE_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][STYLE.STYLE_DATE] + "")
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
                string q = "SELECT " + STYLE.STYLE_NO + " FROM " + STYLE.STYLE_TBL + "\r\n";
                q += " WHERE " + STYLE.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + STYLE.STYLE_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[STYLE.STYLE_NO].ToString())) + 1).ToString();
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
                Style obj = PKId(pkValue);
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
            Style obj = PKId(_pId);

             if (obj != null)
            {
                return obj.Style_no;
            }
            return "";
        }

         public static string GetId_Name(string no, string date, string dateTo, string party)
        {
            var list = Searchby(no, date, dateTo, party);

             if (list.Count != 0)
            {
                return list[0].Style_id;
            }
            return "";
        }

         #endregion[Get id - FieldsName]

    }//cls
}//ns
