// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 14-06-2019 09:02:20 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public static class COrder_exten
    {
         #region[Entity Data]

        private static Order EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Order obj = new Order()
                    {
                        Order_id = redr[ORDER.ORDER_ID].ToString(),
                        Uniqueno = redr[ORDER.UNIQUENO].ToString(),
                        Company_id = redr[ORDER.COMPANY_ID].ToString(),
                        Acy_id = redr[ORDER.ACY_ID].ToString(),
                        Order_no = redr[ORDER.ORDER_NO].ToString(),
                        Order_date = redr[ORDER.ORDER_DATE].ToString(),
                        Ordertype_id = redr[ORDERTYPE.ORDERTYPE_NAME].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Party_ref = redr[ORDER.PARTY_REF].ToString(),
                        Style_ref = redr[ORDER.STYLE_REF].ToString(),
                        Refered_no = redr[ORDER.REFERED_NO].ToString(),
                        Locked = redr[ORDER.LOCKED].ToString(),
                        Notes = redr[ORDER.NOTES].ToString(),
                        Active_id = redr[ORDER.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Order();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Order> EntityList(string q)
         {
             List<Order> list = new List<Order>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Order obj = new Order()
                     {
                        Order_id = redr[ORDER.ORDER_ID].ToString(),
                        Uniqueno = redr[ORDER.UNIQUENO].ToString(),
                        Company_id = redr[ORDER.COMPANY_ID].ToString(),
                        Acy_id = redr[ORDER.ACY_ID].ToString(),
                        Order_no = redr[ORDER.ORDER_NO].ToString(),
                        Order_date = redr[ORDER.ORDER_DATE].ToString(),
                        Ordertype_id = redr[ORDERTYPE.ORDERTYPE_NAME].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Party_ref = redr[ORDER.PARTY_REF].ToString(),
                        Style_ref = redr[ORDER.STYLE_REF].ToString(),
                        Refered_no = redr[ORDER.REFERED_NO].ToString(),
                        Locked = redr[ORDER.LOCKED].ToString(),
                        Notes = redr[ORDER.NOTES].ToString(),
                        Active_id = redr[ORDER.ACTIVE_ID].ToString(),
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

         public static List<Order> Unrefer()
         {
            string q = " SELECT " + ORDER.ORDER_TBL + ".* \r\n";
            q += ", " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ORDER.ORDER_TBL + " \r\n";
            q += " INNER JOIN  " + ORDERTYPE.ORDERTYPE_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.ORDERTYPE_ID + " = " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ORDER.ORDER_TBL + "." + ORDER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ORDER.ORDER_TBL + "." + ORDER.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + ORDER.ORDER_TBL + "." + ORDER.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_DATE + "\r\n";
            q += " ,  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<Order> Refer()
         {
            string q = " SELECT " + ORDER.ORDER_TBL + ".* \r\n";
            q += ", " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ORDER.ORDER_TBL + " \r\n";
            q += " INNER JOIN  " + ORDERTYPE.ORDERTYPE_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.ORDERTYPE_ID + " = " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ORDER.ORDER_TBL + "." + ORDER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + ORDER.ORDER_TBL + "." + ORDER.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_DATE + "\r\n";
            q += " ,  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<Order> Showall()
         {
            string q = " SELECT " + ORDER.ORDER_TBL + ".* \r\n";
            q += ", " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ORDER.ORDER_TBL + " \r\n";
            q += " INNER JOIN  " + ORDERTYPE.ORDERTYPE_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.ORDERTYPE_ID + " = " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ORDER.ORDER_TBL + "." + ORDER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ORDER.ORDER_TBL + "." + ORDER.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_DATE + "\r\n";
            q += " ,  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<Order> Notactive()
         {
            string q = " SELECT " + ORDER.ORDER_TBL + ".* \r\n";
            q += ", " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ORDER.ORDER_TBL + " \r\n";
            q += " INNER JOIN  " + ORDERTYPE.ORDERTYPE_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.ORDERTYPE_ID + " = " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ORDER.ORDER_TBL + "." + ORDER.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ORDER.ORDER_TBL + "." + ORDER.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_DATE + "\r\n";
            q += " ,  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static Order PKId(string id)
         {
            string q = " SELECT " + ORDER.ORDER_TBL + ".* \r\n";
            q += ", " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ORDER.ORDER_TBL + " \r\n";
            q += " INNER JOIN  " + ORDERTYPE.ORDERTYPE_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.ORDERTYPE_ID + " = " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + id + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ORDER.ORDER_TBL + "." + ORDER.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_DATE + "\r\n";
            q += " ,  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + ";\r\n";

            return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<Order> Searchby(string no, string date, string dateTo, string party)
         {
            string q = " SELECT " + ORDER.ORDER_TBL + ".* \r\n";
            q += ", " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ORDER.ORDER_TBL + " \r\n";
            q += " INNER JOIN  " + ORDERTYPE.ORDERTYPE_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.ORDERTYPE_ID + " = " + ORDERTYPE.ORDERTYPE_TBL + "." + ORDERTYPE.ORDERTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ORDER.ORDER_TBL + "." + ORDER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " = '" + no + "'\r\n";
            }
            if (dateTo != "")
            {
                q += " AND " + ORDER.ORDER_TBL + "." + ORDER.ORDER_DATE + "  BETWEEN " + ConvertTO.SqlDate(date) + " AND " + ConvertTO.SqlDate(dateTo) + "\r\n";
            }
            else if (date != "")
            {

                q += " AND " + ORDER.ORDER_TBL + "." + ORDER.ORDER_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + ORDER.ORDER_TBL + "." + ORDER.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_DATE + "\r\n";
            q += " ,  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + ";\r\n";

            return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + " \r\n";
            q += " FROM  " + ORDER.ORDER_TBL + " \r\n";
            q += " WHERE " + ORDER.ORDER_TBL + "." + ORDER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ORDER.ORDER_TBL + "." + ORDER.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_DATE + "\r\n";
            q += " ,  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        public static DataTable LookupParty()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + ORDER.ORDER_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + ORDER.ORDER_TBL + "." + ORDER.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + ORDER.ORDER_TBL + "." + ORDER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ORDER.ORDER_TBL + "." + ORDER.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_DATE + "\r\n";
            q += " ,  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        public static DataTable LookupDate()
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + ORDER.ORDER_TBL + "." + ORDER.ORDER_DATE + " \r\n";
            q += " FROM  " + ORDER.ORDER_TBL + " \r\n";
            q += " WHERE " + ORDER.ORDER_TBL + "." + ORDER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + ORDER.ORDER_TBL + "." + ORDER.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_DATE + "\r\n";
            q += " ,  " + ORDER.ORDER_TBL + "." + ORDER.ORDER_NO + ";\r\n";

            DataTable xtbl = new DAL().Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(ORDER.ORDER_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][ORDER.ORDER_DATE] + "")
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
                string q = "SELECT " + ORDER.ORDER_NO + " FROM " + ORDER.ORDER_TBL + "\r\n";
                q += " WHERE " + ORDER.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + ORDER.ORDER_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[ORDER.ORDER_NO].ToString())) + 1).ToString();
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
                Order obj = PKId(pkValue);
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
            Order obj = PKId(_pId);

             if (obj != null)
            {
                return obj.Order_no;
            }
            return "";
        }

         public static string GetId_Name(string no, string date, string dateTo, string party)
        {
            var list = Searchby(no, date, dateTo, party);

             if (list.Count != 0)
            {
                return list[0].Order_id;
            }
            return "";
        }

         #endregion[Get id - FieldsName]

    }//cls
}//ns
