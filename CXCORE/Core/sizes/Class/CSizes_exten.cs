// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:15:22 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CSizes_exten
    {
        #region[Entity Data]

        private static Sizes EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Sizes obj = new Sizes()
                    {
                        Sizes_id = redr[SIZES.SIZES_ID].ToString(),
                        Sizes_name = redr[SIZES.SIZES_NAME].ToString(),
                        Notes = redr[SIZES.NOTES].ToString(),
                        Active_id = redr[SIZES.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Sizes();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Sizes> EntityList(string q)
        {
            List<Sizes> list = new List<Sizes>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Sizes obj = new Sizes()
                    {
                        Sizes_id = redr[SIZES.SIZES_ID].ToString(),
                        Sizes_name = redr[SIZES.SIZES_NAME].ToString(),
                        Notes = redr[SIZES.NOTES].ToString(),
                        Active_id = redr[SIZES.ACTIVE_ID].ToString(),
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

        public static List<Sizes> Active(DAL DAL)
        {
            string q = " SELECT " + SIZES.SIZES_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SIZES.SIZES_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SIZES.SIZES_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SIZES.SIZES_TBL + "." + SIZES.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Sizes> NotActive(DAL DAL)
        {
            string q = " SELECT " + SIZES.SIZES_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SIZES.SIZES_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SIZES.SIZES_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SIZES.SIZES_TBL + "." + SIZES.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Sizes PKId(string v, DAL DAL)
        {
            string q = " SELECT " + SIZES.SIZES_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SIZES.SIZES_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SIZES.SIZES_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Sizes SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + SIZES.SIZES_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SIZES.SIZES_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SIZES.SIZES_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + SIZES.SIZES_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + SIZES.SIZES_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + SIZES.SIZES_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + SIZES.SIZES_TBL + "." + SIZES.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Sizes obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Sizes_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Sizes obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Sizes_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
