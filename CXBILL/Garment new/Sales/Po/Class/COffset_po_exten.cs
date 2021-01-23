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
    public class COffset_po_exten
    {
         #region[Entity Data]

        private static Offset_po EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Offset_po obj = new Offset_po()
                    {
                        Offset_po_id = redr[OFFSET_PO.OFFSET_PO_ID].ToString(),
                        Offset_po_no = redr[OFFSET_PO.OFFSET_PO_NO].ToString(),
                        Offset_po_date = redr[OFFSET_PO.OFFSET_PO_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Party_po_ref = redr[OFFSET_PO.PARTY_PO_REF].ToString(),
                        Delivery_date = redr[OFFSET_PO.DELIVERY_DATE].ToString(),
                        Total_qty = redr[OFFSET_PO.TOTAL_QTY].ToString(),
                        Total_amount = redr[OFFSET_PO.TOTAL_AMOUNT].ToString(),
                        Refered_no = redr[OFFSET_PO.REFERED_NO].ToString(),
                        Locked = redr[OFFSET_PO.LOCKED].ToString(),
                        Notes = redr[OFFSET_PO.NOTES].ToString(),
                        Active_id = redr[OFFSET_PO.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Offset_po();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Offset_po> EntityList(string q)
         {
             List<Offset_po> list = new List<Offset_po>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Offset_po obj = new Offset_po()
                     {
                        Offset_po_id = redr[OFFSET_PO.OFFSET_PO_ID].ToString(),
                        Offset_po_no = redr[OFFSET_PO.OFFSET_PO_NO].ToString(),
                        Offset_po_date = redr[OFFSET_PO.OFFSET_PO_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Party_po_ref = redr[OFFSET_PO.PARTY_PO_REF].ToString(),
                        Delivery_date = redr[OFFSET_PO.DELIVERY_DATE].ToString(),
                        Total_qty = redr[OFFSET_PO.TOTAL_QTY].ToString(),
                        Total_amount = redr[OFFSET_PO.TOTAL_AMOUNT].ToString(),
                        Refered_no = redr[OFFSET_PO.REFERED_NO].ToString(),
                        Locked = redr[OFFSET_PO.LOCKED].ToString(),
                        Notes = redr[OFFSET_PO.NOTES].ToString(),
                        Active_id = redr[OFFSET_PO.ACTIVE_ID].ToString(),
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

         public static List<Offset_po> Unrefer(DAL DAL)
         {
            string q = " SELECT " + OFFSET_PO.OFFSET_PO_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_PO.OFFSET_PO_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<Offset_po> Refer(DAL DAL)
         {
            string q = " SELECT " + OFFSET_PO.OFFSET_PO_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_PO.OFFSET_PO_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " = '" + Core.One + "' \r\n";
            q += " AND NOT " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<Offset_po> Showall(DAL DAL)
         {
            string q = " SELECT " + OFFSET_PO.OFFSET_PO_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_PO.OFFSET_PO_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<Offset_po> Notactive(DAL DAL)
         {
            string q = " SELECT " + OFFSET_PO.OFFSET_PO_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_PO.OFFSET_PO_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND NOT " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static Offset_po PKId(string id, DAL DAL)
         {
            string q = " SELECT " + OFFSET_PO.OFFSET_PO_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_PO.OFFSET_PO_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " = '" + id + "' \r\n";
            q += " AND NOT " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + ";\r\n";

             return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<Offset_po> Searchby(string no, string date, string party, DAL DAL)
         {
            string q = " SELECT " + OFFSET_PO.OFFSET_PO_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + OFFSET_PO.OFFSET_PO_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_NO + " = '" + no + "'\r\n";
            }
            if (date != "")
            {

                q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + ";\r\n";

             return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_NO + " \r\n";
            q += " FROM  " + OFFSET_PO.OFFSET_PO_TBL + " \r\n";
            q += " WHERE " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + OFFSET_PO.OFFSET_PO_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_DATE + " \r\n";
            q += " FROM  " + OFFSET_PO.OFFSET_PO_TBL + " \r\n";
            q += " WHERE " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " = '" + Core.One + "' \r\n";
            q += " AND " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(OFFSET_PO.OFFSET_PO_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][OFFSET_PO.OFFSET_PO_DATE] + "")
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
                string q = "SELECT " + OFFSET_PO.OFFSET_PO_NO + " FROM " + OFFSET_PO.OFFSET_PO_TBL + "\r\n";
                q += " WHERE " + OFFSET_PO.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + OFFSET_PO.OFFSET_PO_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[OFFSET_PO.OFFSET_PO_NO].ToString())) + 1).ToString();
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
                Offset_po obj = PKId(pkValue, new DAL());
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
             Offset_po obj = PKId(Id, new DAL()); 
 
             if (obj != null) 
             { 
                 return obj.Offset_po_no; 
             } 
             return ""; 
         } 
 
         public static string GetId_Name(string No) 
         { 
             List<Offset_po> list = Searchby(No, "", "", new DAL()); 
 
             if (list.Count != 0) 
             { 
                 return list[0].Offset_po_id; 
             } 
             return ""; 
         } 
 
         #endregion[Get id - No] 
         
    }//cls
}//ns
