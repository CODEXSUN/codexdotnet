// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:38:20 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CColours_exten
    {
        #region[Entity Data]

        private static Colours EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Colours obj = new Colours()
                    {
                        Colours_id = redr[COLOURS.COLOURS_ID].ToString(),
                        Colours_name = redr[COLOURS.COLOURS_NAME].ToString(),
                        Notes = redr[COLOURS.NOTES].ToString(),
                        Active_id = redr[COLOURS.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Colours();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Colours> EntityList(string q)
        {
            List<Colours> list = new List<Colours>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Colours obj = new Colours()
                    {
                        Colours_id = redr[COLOURS.COLOURS_ID].ToString(),
                        Colours_name = redr[COLOURS.COLOURS_NAME].ToString(),
                        Notes = redr[COLOURS.NOTES].ToString(),
                        Active_id = redr[COLOURS.ACTIVE_ID].ToString(),
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

        public static List<Colours> Active(DAL DAL)
        {
            string q = " SELECT " + COLOURS.COLOURS_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COLOURS.COLOURS_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COLOURS.COLOURS_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COLOURS.COLOURS_TBL + "." + COLOURS.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Colours> NotActive(DAL DAL)
        {
            string q = " SELECT " + COLOURS.COLOURS_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COLOURS.COLOURS_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COLOURS.COLOURS_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COLOURS.COLOURS_TBL + "." + COLOURS.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Colours PKId(string v, DAL DAL)
        {
            string q = " SELECT " + COLOURS.COLOURS_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COLOURS.COLOURS_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COLOURS.COLOURS_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Colours SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + COLOURS.COLOURS_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COLOURS.COLOURS_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COLOURS.COLOURS_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + COLOURS.COLOURS_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COLOURS.COLOURS_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COLOURS.COLOURS_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COLOURS.COLOURS_TBL + "." + COLOURS.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Colours obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Colours_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Colours obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Colours_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
