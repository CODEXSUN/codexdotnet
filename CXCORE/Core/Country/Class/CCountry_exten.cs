// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:45:30 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CCountry_exten
    {
        #region[Entity Data]

        private static Country EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Country obj = new Country()
                    {
                        Country_id = redr[COUNTRY.COUNTRY_ID].ToString(),
                        Country_name = redr[COUNTRY.COUNTRY_NAME].ToString(),
                        Notes = redr[COUNTRY.NOTES].ToString(),
                        Active_id = redr[COUNTRY.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Country();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Country> EntityList(string q)
        {
            List<Country> list = new List<Country>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Country obj = new Country()
                    {
                        Country_id = redr[COUNTRY.COUNTRY_ID].ToString(),
                        Country_name = redr[COUNTRY.COUNTRY_NAME].ToString(),
                        Notes = redr[COUNTRY.NOTES].ToString(),
                        Active_id = redr[COUNTRY.ACTIVE_ID].ToString(),
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

        public static List<Country> Active(DAL DAL)
        {
            string q = " SELECT " + COUNTRY.COUNTRY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COUNTRY.COUNTRY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COUNTRY.COUNTRY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Country> NotActive(DAL DAL)
        {
            string q = " SELECT " + COUNTRY.COUNTRY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COUNTRY.COUNTRY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COUNTRY.COUNTRY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Country PKId(string v, DAL DAL)
        {
            string q = " SELECT " + COUNTRY.COUNTRY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COUNTRY.COUNTRY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COUNTRY.COUNTRY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Country SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + COUNTRY.COUNTRY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COUNTRY.COUNTRY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COUNTRY.COUNTRY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + COUNTRY.COUNTRY_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + COUNTRY.COUNTRY_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + COUNTRY.COUNTRY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Country obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Country_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Country obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Country_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
