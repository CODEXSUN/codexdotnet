// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2020 08.01.05 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CContacttype_exten
    {
        #region[Entity Data]

        private static Contacttype EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Contacttype obj = new Contacttype()
                    {
                        Contacttype_id = redr[CONTACTTYPE.CONTACTTYPE_ID].ToString(),
                        Contacttype_name = redr[CONTACTTYPE.CONTACTTYPE_NAME].ToString(),
                        Notes = redr[CONTACTTYPE.NOTES].ToString(),
                        Active_id = redr[CONTACTTYPE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Contacttype();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Contacttype> EntityList(string q)
        {
            List<Contacttype> list = new List<Contacttype>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Contacttype obj = new Contacttype()
                    {
                        Contacttype_id = redr[CONTACTTYPE.CONTACTTYPE_ID].ToString(),
                        Contacttype_name = redr[CONTACTTYPE.CONTACTTYPE_NAME].ToString(),
                        Notes = redr[CONTACTTYPE.NOTES].ToString(),
                        Active_id = redr[CONTACTTYPE.ACTIVE_ID].ToString(),
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

        public static List<Contacttype> Active()
        {
            string q = " SELECT " + CONTACTTYPE.CONTACTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CONTACTTYPE.CONTACTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CONTACTTYPE.CONTACTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Contacttype> NotActive()
        {
            string q = " SELECT " + CONTACTTYPE.CONTACTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CONTACTTYPE.CONTACTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CONTACTTYPE.CONTACTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Contacttype PKId(string v)
        {
            string q = " SELECT " + CONTACTTYPE.CONTACTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CONTACTTYPE.CONTACTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CONTACTTYPE.CONTACTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Contacttype SearchName(string v)
        {
            string q = " SELECT " + CONTACTTYPE.CONTACTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CONTACTTYPE.CONTACTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CONTACTTYPE.CONTACTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup()
        {
            string q = " SELECT " + CONTACTTYPE.CONTACTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + CONTACTTYPE.CONTACTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + CONTACTTYPE.CONTACTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_NAME + ";\r\n";

            return new DAL().Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Contacttype obj = PKId(_pId);

            if (obj != null)
            {
                return obj.Contacttype_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Contacttype obj = SearchName(_pName);

            if (obj != null)
            {
                return obj.Contacttype_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
