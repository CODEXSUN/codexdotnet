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
    public class COffset_dc_exten
    {
         #region[Entity Data]

        private static Offset_dc EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Offset_dc obj = new Offset_dc()
                    {
                        Offset_dc_id = redr[OFFSET_DC.OFFSET_DC_ID].ToString(),
                        Offset_dc_no = redr[OFFSET_DC.OFFSET_DC_NO].ToString(),
                        Offset_dc_date = redr[OFFSET_DC.OFFSET_DC_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Total_qty = redr[OFFSET_DC.TOTAL_QTY].ToString(),
                        Refered_no = redr[OFFSET_DC.REFERED_NO].ToString(),
                        Locked = redr[OFFSET_DC.LOCKED].ToString(),
                        Notes = redr[OFFSET_DC.NOTES].ToString(),
                        Active_id = redr[OFFSET_DC.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Offset_dc();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Offset_dc> EntityList(string q)
         {
             List<Offset_dc> list = new List<Offset_dc>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Offset_dc obj = new Offset_dc()
                     {
                        Offset_dc_id = redr[OFFSET_DC.OFFSET_DC_ID].ToString(),
                        Offset_dc_no = redr[OFFSET_DC.OFFSET_DC_NO].ToString(),
                        Offset_dc_date = redr[OFFSET_DC.OFFSET_DC_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Total_qty = redr[OFFSET_DC.TOTAL_QTY].ToString(),
                        Refered_no = redr[OFFSET_DC.REFERED_NO].ToString(),
                        Locked = redr[OFFSET_DC.LOCKED].ToString(),
                        Notes = redr[OFFSET_DC.NOTES].ToString(),
                        Active_id = redr[OFFSET_DC.ACTIVE_ID].ToString(),
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

         public static List<Offset_dc> Unrefer(DAL DAL)
         {
            string q = " SELECT " + OFFSET_DC.OFFSET_DC_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_DC.OFFSET_DC_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<Offset_dc> Refer(DAL DAL)
         {
            string q = " SELECT " + OFFSET_DC.OFFSET_DC_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_DC.OFFSET_DC_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<Offset_dc> Showall(DAL DAL)
         {
            string q = " SELECT " + OFFSET_DC.OFFSET_DC_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_DC.OFFSET_DC_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<Offset_dc> Notactive(DAL DAL)
         {
            string q = " SELECT " + OFFSET_DC.OFFSET_DC_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_DC.OFFSET_DC_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND NOT " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static Offset_dc PKId(string id, DAL DAL)
         {
            string q = " SELECT " + OFFSET_DC.OFFSET_DC_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_DC.OFFSET_DC_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " = '" + id + "' \r\n";
            q += " AND NOT " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + ";\r\n";

             return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<Offset_dc> Searchby(string no, string date, string party, DAL DAL)
         {
            string q = " SELECT " + OFFSET_DC.OFFSET_DC_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_DC.OFFSET_DC_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + " = '" + no + "'\r\n";
            }
            if (date != "")
            {

                q += " AND " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + " \r\n";
            q += " FROM  " + OFFSET_DC.OFFSET_DC_TBL + " \r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + OFFSET_DC.OFFSET_DC_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_DATE + " \r\n";
            q += " FROM  " + OFFSET_DC.OFFSET_DC_TBL + " \r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(OFFSET_DC.OFFSET_DC_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][OFFSET_DC.OFFSET_DC_DATE] + "")
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
                string q = "SELECT " + OFFSET_DC.OFFSET_DC_NO + " FROM " + OFFSET_DC.OFFSET_DC_TBL + "\r\n";
                q += " WHERE " + OFFSET_DC.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + OFFSET_DC.OFFSET_DC_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[OFFSET_DC.OFFSET_DC_NO].ToString())) + 1).ToString();
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
                Offset_dc obj = PKId(pkValue, new DAL());
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
             Offset_dc obj = PKId(Id, new DAL()); 
 
             if (obj != null) 
             { 
                 return obj.Offset_dc_no; 
             } 
             return ""; 
         } 
 
         public static string GetId_Name(string No) 
         { 
             List<Offset_dc> list = Searchby(No, "", "", new DAL()); 
 
             if (list.Count != 0) 
             { 
                 return list[0].Offset_dc_id; 
             } 
             return ""; 
         } 
 
         #endregion[Get id - No] 
         
    }//cls
}//ns
