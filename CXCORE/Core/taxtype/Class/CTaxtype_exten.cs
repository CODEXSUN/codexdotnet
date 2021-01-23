// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:22:51 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CTaxtype_exten
    {
        #region[Entity Data]

        private static Taxtype EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Taxtype obj = new Taxtype()
                    {
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_ID].ToString(),
                        Taxtype_name = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Notes = redr[TAXTYPE.NOTES].ToString(),
                        Active_id = redr[TAXTYPE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Taxtype();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Taxtype> EntityList(string q)
        {
            List<Taxtype> list = new List<Taxtype>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Taxtype obj = new Taxtype()
                    {
                        Taxtype_id = redr[TAXTYPE.TAXTYPE_ID].ToString(),
                        Taxtype_name = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Notes = redr[TAXTYPE.NOTES].ToString(),
                        Active_id = redr[TAXTYPE.ACTIVE_ID].ToString(),
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

        public static List<Taxtype> Active(DAL DAL)
        {
            string q = " SELECT " + TAXTYPE.TAXTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TAXTYPE.TAXTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TAXTYPE.TAXTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Taxtype> NotActive(DAL DAL)
        {
            string q = " SELECT " + TAXTYPE.TAXTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TAXTYPE.TAXTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TAXTYPE.TAXTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Taxtype PKId(string v, DAL DAL)
        {
            string q = " SELECT " + TAXTYPE.TAXTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TAXTYPE.TAXTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TAXTYPE.TAXTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Taxtype SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + TAXTYPE.TAXTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TAXTYPE.TAXTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TAXTYPE.TAXTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + TAXTYPE.TAXTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + TAXTYPE.TAXTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + TAXTYPE.TAXTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + TAXTYPE.TAXTYPE_TBL + "." + TAXTYPE.TAXTYPE_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Taxtype obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Taxtype_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Taxtype obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Taxtype_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
