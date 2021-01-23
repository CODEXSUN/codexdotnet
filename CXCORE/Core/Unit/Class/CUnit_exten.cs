// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:23:08 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CUnit_exten
    {
        #region[Entity Data]

        private static Unit EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Unit obj = new Unit()
                    {
                        Unit_id = redr[UNIT.UNIT_ID].ToString(),
                        Unit_name = redr[UNIT.UNIT_NAME].ToString(),
                        Unit_desc = redr[UNIT.UNIT_DESC].ToString(),
                        Notes = redr[UNIT.NOTES].ToString(),
                        Active_id = redr[UNIT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Unit();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Unit> EntityList(string q)
        {
            List<Unit> list = new List<Unit>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Unit obj = new Unit()
                    {
                        Unit_id = redr[UNIT.UNIT_ID].ToString(),
                        Unit_name = redr[UNIT.UNIT_NAME].ToString(),
                        Unit_desc = redr[UNIT.UNIT_DESC].ToString(),
                        Notes = redr[UNIT.NOTES].ToString(),
                        Active_id = redr[UNIT.ACTIVE_ID].ToString(),
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

        public static List<Unit> Active(DAL DAL)
        {
            string q = " SELECT " + UNIT.UNIT_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UNIT.UNIT_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UNIT.UNIT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UNIT.UNIT_TBL + "." + UNIT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + UNIT.UNIT_TBL + "." + UNIT.UNIT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + UNIT.UNIT_TBL + "." + UNIT.UNIT_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Unit> NotActive(DAL DAL)
        {
            string q = " SELECT " + UNIT.UNIT_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UNIT.UNIT_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UNIT.UNIT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UNIT.UNIT_TBL + "." + UNIT.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + UNIT.UNIT_TBL + "." + UNIT.UNIT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + UNIT.UNIT_TBL + "." + UNIT.UNIT_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Unit PKId(string v, DAL DAL)
        {
            string q = " SELECT " + UNIT.UNIT_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UNIT.UNIT_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UNIT.UNIT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UNIT.UNIT_TBL + "." + UNIT.UNIT_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Unit SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + UNIT.UNIT_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UNIT.UNIT_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UNIT.UNIT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UNIT.UNIT_TBL + "." + UNIT.UNIT_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + UNIT.UNIT_TBL + "." + UNIT.UNIT_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + UNIT.UNIT_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UNIT.UNIT_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UNIT.UNIT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UNIT.UNIT_TBL + "." + UNIT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + UNIT.UNIT_TBL + "." + UNIT.UNIT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + UNIT.UNIT_TBL + "." + UNIT.UNIT_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Unit obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Unit_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Unit obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Unit_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
