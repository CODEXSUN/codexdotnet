// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:02:33 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CAcy_exten
    {
        #region[Entity Data]

        private static Acy EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Acy obj = new Acy()
                    {
                        Acy_id = redr[ACY.ACY_ID].ToString(),
                        Acy_name = redr[ACY.ACY_NAME].ToString(),
                        Acy_desc = redr[ACY.ACY_DESC].ToString(),
                        Notes = redr[ACY.NOTES].ToString(),
                        Active_id = redr[ACY.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Acy();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Acy> EntityList(string q)
        {
            List<Acy> list = new List<Acy>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Acy obj = new Acy()
                    {
                        Acy_id = redr[ACY.ACY_ID].ToString(),
                        Acy_name = redr[ACY.ACY_NAME].ToString(),
                        Acy_desc = redr[ACY.ACY_DESC].ToString(),
                        Notes = redr[ACY.NOTES].ToString(),
                        Active_id = redr[ACY.ACTIVE_ID].ToString(),
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

        public static List<Acy> Active(DAL DAL)
        {
            string q = " SELECT " + ACY.ACY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ACY.ACY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ACY.ACY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ACY.ACY_TBL + "." + ACY.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ACY.ACY_TBL + "." + ACY.ACY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ACY.ACY_TBL + "." + ACY.ACY_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Acy> NotActive(DAL DAL)
        {
            string q = " SELECT " + ACY.ACY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ACY.ACY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ACY.ACY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ACY.ACY_TBL + "." + ACY.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + ACY.ACY_TBL + "." + ACY.ACY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ACY.ACY_TBL + "." + ACY.ACY_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Acy PKId(string v, DAL DAL)
        {
            string q = " SELECT " + ACY.ACY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ACY.ACY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ACY.ACY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ACY.ACY_TBL + "." + ACY.ACY_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Acy SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + ACY.ACY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ACY.ACY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ACY.ACY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ACY.ACY_TBL + "." + ACY.ACY_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + ACY.ACY_TBL + "." + ACY.ACY_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + ACY.ACY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ACY.ACY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ACY.ACY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ACY.ACY_TBL + "." + ACY.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ACY.ACY_TBL + "." + ACY.ACY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ACY.ACY_TBL + "." + ACY.ACY_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Acy obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Acy_name;
            }
            return "";
        }

        public static string GetDesc_Id(string _pId)
        {
            Acy obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Acy_desc;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Acy obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Acy_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
