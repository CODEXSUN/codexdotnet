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
    public static class CArticle_exten
    {
         #region[Entity Data]

        private static Article EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Article obj = new Article()
                    {
                        Article_id = redr[ARTICLE.ARTICLE_ID].ToString(),
                        Uniqueno = redr[ARTICLE.UNIQUENO].ToString(),
                        Company_id = redr[ARTICLE.COMPANY_ID].ToString(),
                        Acy_id = redr[ARTICLE.ACY_ID].ToString(),
                        Article_no = redr[ARTICLE.ARTICLE_NO].ToString(),
                        Article_date = redr[ARTICLE.ARTICLE_DATE].ToString(),
                        Locked = redr[ARTICLE.LOCKED].ToString(),
                        Notes = redr[ARTICLE.NOTES].ToString(),
                        Active_id = redr[ARTICLE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Article();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Article> EntityList(string q)
         {
             List<Article> list = new List<Article>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Article obj = new Article()
                     {
                        Article_id = redr[ARTICLE.ARTICLE_ID].ToString(),
                        Uniqueno = redr[ARTICLE.UNIQUENO].ToString(),
                        Company_id = redr[ARTICLE.COMPANY_ID].ToString(),
                        Acy_id = redr[ARTICLE.ACY_ID].ToString(),
                        Article_no = redr[ARTICLE.ARTICLE_NO].ToString(),
                        Article_date = redr[ARTICLE.ARTICLE_DATE].ToString(),
                        Locked = redr[ARTICLE.LOCKED].ToString(),
                        Notes = redr[ARTICLE.NOTES].ToString(),
                        Active_id = redr[ARTICLE.ACTIVE_ID].ToString(),
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

         public static List<Article> Unrefer()
         {
            string q = " SELECT " + ARTICLE.ARTICLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ARTICLE.ARTICLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_DATE + "\r\n";
            q += " ,  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<Article> Refer()
         {
            string q = " SELECT " + ARTICLE.ARTICLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ARTICLE.ARTICLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_DATE + "\r\n";
            q += " ,  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<Article> Showall()
         {
            string q = " SELECT " + ARTICLE.ARTICLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ARTICLE.ARTICLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_DATE + "\r\n";
            q += " ,  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<Article> Notactive()
         {
            string q = " SELECT " + ARTICLE.ARTICLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ARTICLE.ARTICLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_DATE + "\r\n";
            q += " ,  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static Article PKId(string id)
         {
            string q = " SELECT " + ARTICLE.ARTICLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ARTICLE.ARTICLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_ID + " = '" + id + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_DATE + "\r\n";
            q += " ,  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<Article> Searchby(string no, string date, string dateTo, string party)
         {
            string q = " SELECT " + ARTICLE.ARTICLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ARTICLE.ARTICLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + " = '" + no + "'\r\n";
            }
            if (dateTo != "")
            {
                q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_DATE + "  BETWEEN " + ConvertTO.SqlDate(date) + " AND " + ConvertTO.SqlDate(dateTo) + "\r\n";
            }
            else if (date != "")
            {

                q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_DATE + "\r\n";
            q += " ,  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_DATE + "\r\n";
            q += " ,  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        public static DataTable LookupParty()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_DATE + "\r\n";
            q += " ,  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        public static DataTable LookupDate()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_DATE + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_DATE + "\r\n";
            q += " ,  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            DataTable xtbl = new DAL().Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(ARTICLE.ARTICLE_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][ARTICLE.ARTICLE_DATE] + "")
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
                string q = "SELECT " + ARTICLE.ARTICLE_NO + " FROM " + ARTICLE.ARTICLE_TBL + "\r\n";
                q += " WHERE " + ARTICLE.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + ARTICLE.ARTICLE_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[ARTICLE.ARTICLE_NO].ToString())) + 1).ToString();
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
                Article obj = PKId(pkValue);
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
            Article obj = PKId(_pId);

             if (obj != null)
            {
                return obj.Article_no;
            }
            return "";
        }

         public static string GetId_Name(string no, string date, string dateTo, string party)
        {
            var list = Searchby(no, date, dateTo, party);

             if (list.Count != 0)
            {
                return list[0].Article_id;
            }
            return "";
        }

         #endregion[Get id - FieldsName]

    }//cls
}//ns
