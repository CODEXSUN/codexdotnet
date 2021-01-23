// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:33:13 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CProducttype_exten
    {
        #region[Entity Data]

        private static Producttype EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Producttype obj = new Producttype()
                    {
                        Producttype_id = redr[PRODUCTTYPE.PRODUCTTYPE_ID].ToString(),
                        Producttype_name = redr[PRODUCTTYPE.PRODUCTTYPE_NAME].ToString(),
                        Notes = redr[PRODUCTTYPE.NOTES].ToString(),
                        Active_id = redr[PRODUCTTYPE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Producttype();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Producttype> EntityList(string q)
        {
            List<Producttype> list = new List<Producttype>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Producttype obj = new Producttype()
                    {
                        Producttype_id = redr[PRODUCTTYPE.PRODUCTTYPE_ID].ToString(),
                        Producttype_name = redr[PRODUCTTYPE.PRODUCTTYPE_NAME].ToString(),
                        Notes = redr[PRODUCTTYPE.NOTES].ToString(),
                        Active_id = redr[PRODUCTTYPE.ACTIVE_ID].ToString(),
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

        public static List<Producttype> Active(DAL DAL)
        {
            string q = " SELECT " + PRODUCTTYPE.PRODUCTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PRODUCTTYPE.PRODUCTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Producttype> NotActive(DAL DAL)
        {
            string q = " SELECT " + PRODUCTTYPE.PRODUCTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PRODUCTTYPE.PRODUCTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Producttype PKId(string v, DAL DAL)
        {
            string q = " SELECT " + PRODUCTTYPE.PRODUCTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PRODUCTTYPE.PRODUCTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Producttype SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + PRODUCTTYPE.PRODUCTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PRODUCTTYPE.PRODUCTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + PRODUCTTYPE.PRODUCTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PRODUCTTYPE.PRODUCTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Producttype obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Producttype_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Producttype obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Producttype_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
