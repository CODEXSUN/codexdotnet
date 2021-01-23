// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:37:39 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CUser_exten
    {
        #region[Entity Data]

        private static User EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    User obj = new User()
                    {
                        User_id = redr[USER.USER_ID].ToString(),
                        User_name = redr[USER.USER_NAME].ToString(),
                        User_password = redr[USER.USER_PASSWORD].ToString(),
                        Createon = redr[USER.CREATEON].ToString(),
                        //Role_id = redr[ROLE.ROLE_NAME].ToString(),
                        Entryby = redr[USER.ENTRYBY].ToString(),
                        Notes = redr[USER.NOTES].ToString(),
                        Active_id = redr[USER.ACTIVE_ID].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new User();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<User> EntityList(string q)
        {
            List<User> list = new List<User>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    User obj = new User()
                    {
                        User_id = redr[USER.USER_ID].ToString(),
                        User_name = redr[USER.USER_NAME].ToString(),
                        User_password = redr[USER.USER_PASSWORD].ToString(),
                        Createon = redr[USER.CREATEON].ToString(),
                        Role_id = redr[ROLE.ROLE_NAME].ToString(),
                        Entryby = redr[USER.ENTRYBY].ToString(),
                        Notes = redr[USER.NOTES].ToString(),
                        Active_id = redr[USER.ACTIVE_ID].ToString()
                    };

                    list.Add(obj);
                }

                redr.Close();
            }
            return list;
        }

        #endregion[Entity List]

        #region[Active]

        public static List<User> Active(DAL DAL)
        {
            string q = " SELECT " + USER.USER_TBL + ".* \r\n";
            q += ", " + ROLE.ROLE_TBL + "." + ROLE.ROLE_NAME + " \r\n";
            q += " FROM  " + USER.USER_TBL + " \r\n";
            q += " INNER JOIN  " + ROLE.ROLE_TBL + " \r\n";
            q += " ON( " + USER.USER_TBL + "." + ROLE.ROLE_ID + " = " + ROLE.ROLE_TBL + "." + ROLE.ROLE_ID + ")\r\n";
            q += " WHERE " + USER.USER_TBL + "." + USER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + USER.USER_TBL + "." + USER.USER_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + USER.USER_TBL + "." + USER.USER_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<User> NotActive(DAL DAL)
        {
            string q = " SELECT " + USER.USER_TBL + ".* \r\n";
            q += ", " + ROLE.ROLE_TBL + "." + ROLE.ROLE_NAME + " \r\n";
            q += " FROM  " + USER.USER_TBL + " \r\n";
            q += " INNER JOIN  " + ROLE.ROLE_TBL + " \r\n";
            q += " ON( " + USER.USER_TBL + "." + ROLE.ROLE_ID + " = " + ROLE.ROLE_TBL + "." + ROLE.ROLE_ID + ")\r\n";
            q += " WHERE " + USER.USER_TBL + "." + USER.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + USER.USER_TBL + "." + USER.USER_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + USER.USER_TBL + "." + USER.USER_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static User PKId(string v, DAL DAL)
        {
            string q = " SELECT " + USER.USER_TBL + ".* \r\n";
            q += ", " + ROLE.ROLE_TBL + "." + ROLE.ROLE_NAME + " \r\n";
            q += " FROM  " + USER.USER_TBL + " \r\n";
            q += " INNER JOIN  " + ROLE.ROLE_TBL + " \r\n";
            q += " ON( " + USER.USER_TBL + "." + ROLE.ROLE_ID + " = " + ROLE.ROLE_TBL + "." + ROLE.ROLE_ID + ")\r\n";
            q += " WHERE " + USER.USER_TBL + "." + USER.USER_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static User SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + USER.USER_TBL + ".* \r\n";
            //q += ", " + ROLE.ROLE_TBL + "." + ROLE.ROLE_NAME + " \r\n";
            q += " FROM  " + USER.USER_TBL + " \r\n";
            //q += " INNER JOIN  " + ROLE.ROLE_TBL + " \r\n";
            //q += " ON( " + USER.USER_TBL + "." + ROLE.ROLE_ID + " = " + ROLE.ROLE_TBL + "." + ROLE.ROLE_ID + ")\r\n";
            q += " WHERE " + USER.USER_TBL + "." + USER.USER_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + USER.USER_TBL + "." + USER.USER_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + USER.USER_TBL + ".* \r\n";
            q += ", " + ROLE.ROLE_TBL + "." + ROLE.ROLE_NAME + " \r\n";
            q += " FROM  " + USER.USER_TBL + " \r\n";
            q += " INNER JOIN  " + ROLE.ROLE_TBL + " \r\n";
            q += " ON( " + USER.USER_TBL + "." + ROLE.ROLE_ID + " = " + ROLE.ROLE_TBL + "." + ROLE.ROLE_ID + ")\r\n";
            q += " WHERE " + USER.USER_TBL + "." + USER.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + USER.USER_TBL + "." + USER.USER_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + USER.USER_TBL + "." + USER.USER_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            User obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.User_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            User obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.User_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
