// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:07:41 AM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CReceipttype_exten
    {
        #region[Entity Data]

        private static Receipttype EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Receipttype obj = new Receipttype()
                    {
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_ID].ToString(),
                        Receipttype_name = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Notes = redr[RECEIPTTYPE.NOTES].ToString(),
                        Active_id = redr[RECEIPTTYPE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Receipttype();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Receipttype> EntityList(string q)
        {
            List<Receipttype> list = new List<Receipttype>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Receipttype obj = new Receipttype()
                    {
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_ID].ToString(),
                        Receipttype_name = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Notes = redr[RECEIPTTYPE.NOTES].ToString(),
                        Active_id = redr[RECEIPTTYPE.ACTIVE_ID].ToString(),
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

        public static List<Receipttype> Active(DAL DAL)
        {
            string q = " SELECT " + RECEIPTTYPE.RECEIPTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + RECEIPTTYPE.RECEIPTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Receipttype> NotActive(DAL DAL)
        {
            string q = " SELECT " + RECEIPTTYPE.RECEIPTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + RECEIPTTYPE.RECEIPTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Receipttype PKId(string v, DAL DAL)
        {
            string q = " SELECT " + RECEIPTTYPE.RECEIPTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + RECEIPTTYPE.RECEIPTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Receipttype SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + RECEIPTTYPE.RECEIPTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + RECEIPTTYPE.RECEIPTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + RECEIPTTYPE.RECEIPTTYPE_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + RECEIPTTYPE.RECEIPTTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Receipttype obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Receipttype_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Receipttype obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Receipttype_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
