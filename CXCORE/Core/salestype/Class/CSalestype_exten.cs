// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:11:05 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CSalestype_exten
    {
        #region[Entity Data]

        private static Salestype EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Salestype obj = new Salestype()
                    {
                        Salestype_id = redr[SALESTYPE.SALESTYPE_ID].ToString(),
                        Salestype_name = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Notes = redr[SALESTYPE.NOTES].ToString(),
                        Active_id = redr[SALESTYPE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Salestype();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Salestype> EntityList(string q)
        {
            List<Salestype> list = new List<Salestype>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Salestype obj = new Salestype()
                    {
                        Salestype_id = redr[SALESTYPE.SALESTYPE_ID].ToString(),
                        Salestype_name = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Notes = redr[SALESTYPE.NOTES].ToString(),
                        Active_id = redr[SALESTYPE.ACTIVE_ID].ToString(),
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

        public static List<Salestype> Active(DAL DAL)
        {
            string q = " SELECT " + SALESTYPE.SALESTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SALESTYPE.SALESTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SALESTYPE.SALESTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Salestype> NotActive(DAL DAL)
        {
            string q = " SELECT " + SALESTYPE.SALESTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SALESTYPE.SALESTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SALESTYPE.SALESTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Salestype PKId(string v, DAL DAL)
        {
            string q = " SELECT " + SALESTYPE.SALESTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SALESTYPE.SALESTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SALESTYPE.SALESTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Salestype SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + SALESTYPE.SALESTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SALESTYPE.SALESTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SALESTYPE.SALESTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + SALESTYPE.SALESTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SALESTYPE.SALESTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SALESTYPE.SALESTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + SALESTYPE.SALESTYPE_TBL + "." + SALESTYPE.SALESTYPE_ID + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Salestype obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Salestype_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Salestype obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Salestype_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
