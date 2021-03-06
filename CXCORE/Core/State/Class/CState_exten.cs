// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:15:52 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CState_exten
    {
        #region[Entity Data]

        private static State EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    State obj = new State()
                    {
                        State_id = redr[STATE.STATE_ID].ToString(),
                        State_name = redr[STATE.STATE_NAME].ToString(),
                        State_code = redr[STATE.STATE_CODE].ToString(),
                        Notes = redr[STATE.NOTES].ToString(),
                        Active_id = redr[STATE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new State();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<State> EntityList(string q)
        {
            List<State> list = new List<State>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    State obj = new State()
                    {
                        State_id = redr[STATE.STATE_ID].ToString(),
                        State_name = redr[STATE.STATE_NAME].ToString(),
                        State_code = redr[STATE.STATE_CODE].ToString(),
                        Notes = redr[STATE.NOTES].ToString(),
                        Active_id = redr[STATE.ACTIVE_ID].ToString(),
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

        public static List<State> Active(DAL DAL)
        {
            string q = " SELECT " + STATE.STATE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + STATE.STATE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + STATE.STATE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + STATE.STATE_TBL + "." + STATE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + STATE.STATE_TBL + "." + STATE.STATE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + STATE.STATE_TBL + "." + STATE.STATE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<State> NotActive(DAL DAL)
        {
            string q = " SELECT " + STATE.STATE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + STATE.STATE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + STATE.STATE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + STATE.STATE_TBL + "." + STATE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + STATE.STATE_TBL + "." + STATE.STATE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + STATE.STATE_TBL + "." + STATE.STATE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static State PKId(string v, DAL DAL)
        {
            string q = " SELECT " + STATE.STATE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + STATE.STATE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + STATE.STATE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + STATE.STATE_TBL + "." + STATE.STATE_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static State SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + STATE.STATE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + STATE.STATE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + STATE.STATE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + STATE.STATE_TBL + "." + STATE.STATE_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + STATE.STATE_TBL + "." + STATE.STATE_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + STATE.STATE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + STATE.STATE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + STATE.STATE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + STATE.STATE_TBL + "." + STATE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + STATE.STATE_TBL + "." + STATE.STATE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + STATE.STATE_TBL + "." + STATE.STATE_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            State obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.State_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            State obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.State_id;
            }
            return "";
        }

        public static string GetStateCode_Id(string _pId)
        {
            State obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.State_code;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
