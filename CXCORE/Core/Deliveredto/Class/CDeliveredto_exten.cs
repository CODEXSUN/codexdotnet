// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:46:35 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CDeliveredto_exten
    {
        #region[Entity Data]

        private static Deliveredto EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Deliveredto obj = new Deliveredto()
                    {
                        Deliveredto_id = redr[DELIVEREDTO.DELIVEREDTO_ID].ToString(),
                        Deliveredto_name = redr[DELIVEREDTO.DELIVEREDTO_NAME].ToString(),
                        Notes = redr[DELIVEREDTO.NOTES].ToString(),
                        Active_id = redr[DELIVEREDTO.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Deliveredto();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Deliveredto> EntityList(string q)
        {
            List<Deliveredto> list = new List<Deliveredto>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Deliveredto obj = new Deliveredto()
                    {
                        Deliveredto_id = redr[DELIVEREDTO.DELIVEREDTO_ID].ToString(),
                        Deliveredto_name = redr[DELIVEREDTO.DELIVEREDTO_NAME].ToString(),
                        Notes = redr[DELIVEREDTO.NOTES].ToString(),
                        Active_id = redr[DELIVEREDTO.ACTIVE_ID].ToString(),
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

        public static List<Deliveredto> Active(DAL DAL)
        {
            string q = " SELECT " + DELIVEREDTO.DELIVEREDTO_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + DELIVEREDTO.DELIVEREDTO_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + DELIVEREDTO.DELIVEREDTO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Deliveredto> NotActive(DAL DAL)
        {
            string q = " SELECT " + DELIVEREDTO.DELIVEREDTO_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + DELIVEREDTO.DELIVEREDTO_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + DELIVEREDTO.DELIVEREDTO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Deliveredto PKId(string v, DAL DAL)
        {
            string q = " SELECT " + DELIVEREDTO.DELIVEREDTO_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + DELIVEREDTO.DELIVEREDTO_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + DELIVEREDTO.DELIVEREDTO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Deliveredto SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + DELIVEREDTO.DELIVEREDTO_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + DELIVEREDTO.DELIVEREDTO_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + DELIVEREDTO.DELIVEREDTO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + DELIVEREDTO.DELIVEREDTO_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + DELIVEREDTO.DELIVEREDTO_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + DELIVEREDTO.DELIVEREDTO_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + DELIVEREDTO.DELIVEREDTO_TBL + "." + DELIVEREDTO.DELIVEREDTO_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Deliveredto obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Deliveredto_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Deliveredto obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Deliveredto_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
