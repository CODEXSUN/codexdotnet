// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:28:28 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CBundle_exten
    {
        #region[Entity Data]

        private static Bundle EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Bundle obj = new Bundle()
                    {
                        Bundle_id = redr[BUNDLE.BUNDLE_ID].ToString(),
                        Bundle_name = redr[BUNDLE.BUNDLE_NAME].ToString(),
                        Notes = redr[BUNDLE.NOTES].ToString(),
                        Active_id = redr[BUNDLE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Bundle();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Bundle> EntityList(string q)
        {
            List<Bundle> list = new List<Bundle>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Bundle obj = new Bundle()
                    {
                        Bundle_id = redr[BUNDLE.BUNDLE_ID].ToString(),
                        Bundle_name = redr[BUNDLE.BUNDLE_NAME].ToString(),
                        Notes = redr[BUNDLE.NOTES].ToString(),
                        Active_id = redr[BUNDLE.ACTIVE_ID].ToString(),
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

        public static List<Bundle> Active(DAL DAL)
        {
            string q = " SELECT " + BUNDLE.BUNDLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + BUNDLE.BUNDLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + BUNDLE.BUNDLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + BUNDLE.BUNDLE_TBL + "." + BUNDLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + BUNDLE.BUNDLE_TBL + "." + BUNDLE.BUNDLE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + BUNDLE.BUNDLE_TBL + "." + BUNDLE.BUNDLE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Bundle> NotActive(DAL DAL)
        {
            string q = " SELECT " + BUNDLE.BUNDLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + BUNDLE.BUNDLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + BUNDLE.BUNDLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + BUNDLE.BUNDLE_TBL + "." + BUNDLE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + BUNDLE.BUNDLE_TBL + "." + BUNDLE.BUNDLE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + BUNDLE.BUNDLE_TBL + "." + BUNDLE.BUNDLE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Bundle PKId(string v, DAL DAL)
        {
            string q = " SELECT " + BUNDLE.BUNDLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + BUNDLE.BUNDLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + BUNDLE.BUNDLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + BUNDLE.BUNDLE_TBL + "." + BUNDLE.BUNDLE_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Bundle SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + BUNDLE.BUNDLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + BUNDLE.BUNDLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + BUNDLE.BUNDLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + BUNDLE.BUNDLE_TBL + "." + BUNDLE.BUNDLE_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + BUNDLE.BUNDLE_TBL + "." + BUNDLE.BUNDLE_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + BUNDLE.BUNDLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + BUNDLE.BUNDLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + BUNDLE.BUNDLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + BUNDLE.BUNDLE_TBL + "." + BUNDLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + BUNDLE.BUNDLE_TBL + "." + BUNDLE.BUNDLE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + BUNDLE.BUNDLE_TBL + "." + BUNDLE.BUNDLE_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Bundle obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Bundle_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Bundle obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Bundle_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
