// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:22:56 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CTransport_exten
    {
        #region[Entity Data]

        private static Transport EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Transport obj = new Transport()
                    {
                        Transport_id = redr[TRANSPORT.TRANSPORT_ID].ToString(),
                        Transport_name = redr[TRANSPORT.TRANSPORT_NAME].ToString(),
                        Notes = redr[TRANSPORT.NOTES].ToString(),
                        Active_id = redr[TRANSPORT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Transport();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Transport> EntityList(string q)
        {
            List<Transport> list = new List<Transport>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Transport obj = new Transport()
                    {
                        Transport_id = redr[TRANSPORT.TRANSPORT_ID].ToString(),
                        Transport_name = redr[TRANSPORT.TRANSPORT_NAME].ToString(),
                        Notes = redr[TRANSPORT.NOTES].ToString(),
                        Active_id = redr[TRANSPORT.ACTIVE_ID].ToString(),
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

        public static List<Transport> Active(DAL DAL)
        {
            string q = " SELECT " + TRANSPORT.TRANSPORT_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TRANSPORT.TRANSPORT_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TRANSPORT.TRANSPORT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Transport> NotActive(DAL DAL)
        {
            string q = " SELECT " + TRANSPORT.TRANSPORT_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TRANSPORT.TRANSPORT_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TRANSPORT.TRANSPORT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Transport PKId(string v, DAL DAL)
        {
            string q = " SELECT " + TRANSPORT.TRANSPORT_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TRANSPORT.TRANSPORT_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TRANSPORT.TRANSPORT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Transport SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + TRANSPORT.TRANSPORT_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TRANSPORT.TRANSPORT_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TRANSPORT.TRANSPORT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + TRANSPORT.TRANSPORT_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TRANSPORT.TRANSPORT_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TRANSPORT.TRANSPORT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Transport obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Transport_name;
            }
            return "-";
        }

        public static string GetId_Name(string _pName)
        {
            Transport obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Transport_id;
            }
            return "1";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
