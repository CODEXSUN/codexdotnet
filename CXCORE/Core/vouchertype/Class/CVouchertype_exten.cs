// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:46:04 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CVouchertype_exten
    {
         #region[Entity Data]

        private static Vouchertype EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Vouchertype obj = new Vouchertype()
                    {
                        Vouchertype_id = redr[VOUCHERTYPE.VOUCHERTYPE_ID].ToString(),
                        Vouchertype_name = redr[VOUCHERTYPE.VOUCHERTYPE_NAME].ToString(),
                        Method_id = redr[METHOD.METHOD_NAME].ToString(),
                        Notes = redr[VOUCHERTYPE.NOTES].ToString(),
                        Active_id = redr[VOUCHERTYPE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Vouchertype();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Vouchertype> EntityList(string q)
         {
             List<Vouchertype> list = new List<Vouchertype>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Vouchertype obj = new Vouchertype()
                     {
                        Vouchertype_id = redr[VOUCHERTYPE.VOUCHERTYPE_ID].ToString(),
                        Vouchertype_name = redr[VOUCHERTYPE.VOUCHERTYPE_NAME].ToString(),
                        Method_id = redr[METHOD.METHOD_NAME].ToString(),
                        Notes = redr[VOUCHERTYPE.NOTES].ToString(),
                        Active_id = redr[VOUCHERTYPE.ACTIVE_ID].ToString(),
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

         public static List<Vouchertype> Active(DAL DAL)
         {
            string q = " SELECT " + VOUCHERTYPE.VOUCHERTYPE_TBL + ".* \r\n";
            q += ", " + METHOD.METHOD_TBL + "." + METHOD.METHOD_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + METHOD.METHOD_TBL + " \r\n";
            q += " ON( " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + METHOD.METHOD_ID + " = " + METHOD.METHOD_TBL+ "." +METHOD.METHOD_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Vouchertype> NotActive(DAL DAL)
         {
            string q = " SELECT " + VOUCHERTYPE.VOUCHERTYPE_TBL + ".* \r\n";
            q += ", " + METHOD.METHOD_TBL + "." + METHOD.METHOD_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + METHOD.METHOD_TBL + " \r\n";
            q += " ON( " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + METHOD.METHOD_ID + " = " + METHOD.METHOD_TBL+ "." +METHOD.METHOD_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Vouchertype PKId(string v, DAL DAL)
         {
            string q = " SELECT " + VOUCHERTYPE.VOUCHERTYPE_TBL + ".* \r\n";
            q += ", " + METHOD.METHOD_TBL + "." + METHOD.METHOD_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + METHOD.METHOD_TBL + " \r\n";
            q += " ON( " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + METHOD.METHOD_ID + " = " + METHOD.METHOD_TBL+ "." +METHOD.METHOD_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Vouchertype SearchName(string v, DAL DAL)
         {
            string q = " SELECT " + VOUCHERTYPE.VOUCHERTYPE_TBL + ".* \r\n";
            q += ", " + METHOD.METHOD_TBL + "." + METHOD.METHOD_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + METHOD.METHOD_TBL + " \r\n";
            q += " ON( " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + METHOD.METHOD_ID + " = " + METHOD.METHOD_TBL+ "." +METHOD.METHOD_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_NAME + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup(DAL DAL)
         {
            string q = " SELECT " + VOUCHERTYPE.VOUCHERTYPE_TBL + ".* \r\n";
            q += ", " + METHOD.METHOD_TBL + "." + METHOD.METHOD_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " INNER JOIN  " + METHOD.METHOD_TBL + " \r\n";
            q += " ON( " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + METHOD.METHOD_ID + " = " + METHOD.METHOD_TBL+ "." +METHOD.METHOD_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + VOUCHERTYPE.VOUCHERTYPE_TBL + "." + VOUCHERTYPE.VOUCHERTYPE_NAME + ";\r\n";

             return DAL.Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string _pId)
        {
            Vouchertype obj = PKId(_pId, new DAL());

             if (obj != null)
            {
                return obj.Vouchertype_name;
            }
            return "";
        }

         public static string GetId_Name(string _pName)
        {
            Vouchertype obj = SearchName(_pName, new DAL());

             if (obj != null)
            {
                return obj.Vouchertype_id;
            }
            return "";
        }

        public static string GetMethod_Name(string _pName)
        {
            Vouchertype obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Method_id;
            }
            return "";
        }

        public static string GetMethodid_Name(string _pName)
        {
            string q = " SELECT * FROM " + VOUCHERTYPE.VOUCHERTYPE_TBL + " \r\n";
            q += " WHERE " + VOUCHERTYPE.VOUCHERTYPE_NAME + "  = '" + _pName + "' \r\n";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Vouchertype obj = new Vouchertype()
                    {
                        Method_id = redr[METHOD.METHOD_ID].ToString(),
                    };
                    return obj.Method_id;
                }
                redr.Close();
            }
            return "";
        }


        #endregion[Get id - Name]

    }//cls
}//ns
