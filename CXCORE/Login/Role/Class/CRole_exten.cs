// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:34:52 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CRole_exten
    {
        #region[Entity Data]

        private static Role EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Role obj = new Role()
                    {
                        Role_id = redr[ROLE.ROLE_ID].ToString(),
                        Role_name = redr[ROLE.ROLE_NAME].ToString(),
                        Notes = redr[ROLE.NOTES].ToString(),
                        Active_id = redr[ROLE.ACTIVE_ID].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Role();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Role> EntityList(string q)
        {
            List<Role> list = new List<Role>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Role obj = new Role()
                    {
                        Role_id = redr[ROLE.ROLE_ID].ToString(),
                        Role_name = redr[ROLE.ROLE_NAME].ToString(),
                        Notes = redr[ROLE.NOTES].ToString(),
                        Active_id = redr[ROLE.ACTIVE_ID].ToString()
                    };

                    list.Add(obj);
                }

                redr.Close();
            }
            return list;
        }

        #endregion[Entity List]

        #region[Active]

        public static List<Role> Active(DAL DAL)
        {
            string q = " SELECT " + ROLE.ROLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ROLE.ROLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ROLE.ROLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ROLE.ROLE_TBL + "." + ROLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ROLE.ROLE_TBL + "." + ROLE.ROLE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ROLE.ROLE_TBL + "." + ROLE.ROLE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Role> NotActive(DAL DAL)
        {
            string q = " SELECT " + ROLE.ROLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ROLE.ROLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ROLE.ROLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ROLE.ROLE_TBL + "." + ROLE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + ROLE.ROLE_TBL + "." + ROLE.ROLE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ROLE.ROLE_TBL + "." + ROLE.ROLE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Role PKId(string v, DAL DAL)
        {
            string q = " SELECT " + ROLE.ROLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ROLE.ROLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ROLE.ROLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ROLE.ROLE_TBL + "." + ROLE.ROLE_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Role SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + ROLE.ROLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ROLE.ROLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ROLE.ROLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ROLE.ROLE_TBL + "." + ROLE.ROLE_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + ROLE.ROLE_TBL + "." + ROLE.ROLE_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + ROLE.ROLE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ROLE.ROLE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ROLE.ROLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ROLE.ROLE_TBL + "." + ROLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ROLE.ROLE_TBL + "." + ROLE.ROLE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ROLE.ROLE_TBL + "." + ROLE.ROLE_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Role obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Role_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Role obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Role_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
