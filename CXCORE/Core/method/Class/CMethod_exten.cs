// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 08:21:03 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CMethod_exten
    {
         #region[Entity Data]

        private static Method EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Method obj = new Method()
                    {
                        Method_id = redr[METHOD.METHOD_ID].ToString(),
                        Method_name = redr[METHOD.METHOD_NAME].ToString(),
                        Notes = redr[METHOD.NOTES].ToString(),
                        Active_id = redr[METHOD.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Method();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Method> EntityList(string q)
         {
             List<Method> list = new List<Method>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Method obj = new Method()
                     {
                        Method_id = redr[METHOD.METHOD_ID].ToString(),
                        Method_name = redr[METHOD.METHOD_NAME].ToString(),
                        Notes = redr[METHOD.NOTES].ToString(),
                        Active_id = redr[METHOD.ACTIVE_ID].ToString(),
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

         public static List<Method> Active(DAL DAL)
         {
            string q = " SELECT " + METHOD.METHOD_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + METHOD.METHOD_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + METHOD.METHOD_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + METHOD.METHOD_TBL + "." + METHOD.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + METHOD.METHOD_TBL + "." + METHOD.METHOD_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + METHOD.METHOD_TBL + "." + METHOD.METHOD_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[Active]

         #region[NotActive]

         public static List<Method> NotActive(DAL DAL)
         {
            string q = " SELECT " + METHOD.METHOD_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + METHOD.METHOD_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + METHOD.METHOD_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + METHOD.METHOD_TBL + "." + METHOD.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + METHOD.METHOD_TBL + "." + METHOD.METHOD_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + METHOD.METHOD_TBL + "." + METHOD.METHOD_NAME + ";\r\n";

             return EntityList(q);
         }

         #endregion[NotActive]

         #region[Primary Key]

         public static Method PKId(string v, DAL DAL)
         {
            string q = " SELECT " + METHOD.METHOD_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + METHOD.METHOD_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + METHOD.METHOD_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + METHOD.METHOD_TBL + "." + METHOD.METHOD_ID + "  = '" + v + "' \r\n";

             return EntityData(q);
         }

         #endregion[Primary Key]

         #region[Search by name]

         public static Method SearchName(string v, DAL DAL)
         {
            string q = " SELECT " + METHOD.METHOD_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + METHOD.METHOD_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + METHOD.METHOD_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + METHOD.METHOD_TBL + "." + METHOD.METHOD_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + METHOD.METHOD_TBL + "." + METHOD.METHOD_NAME + ";\r\n";

             return EntityData(q);
         }

         #endregion[Search by name]

         #region[Look up]

         public static DataTable GetforLookup(DAL DAL)
         {
            string q = " SELECT " + METHOD.METHOD_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + METHOD.METHOD_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + METHOD.METHOD_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + METHOD.METHOD_TBL + "." + METHOD.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + METHOD.METHOD_TBL + "." + METHOD.METHOD_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + METHOD.METHOD_TBL + "." + METHOD.METHOD_NAME + ";\r\n";

             return DAL.Listdata(q);
         }

         #endregion[Look up]

        #region[Get id - Name]

         public static string GetName_Id(string _pId)
        {
            Method obj = PKId(_pId, new DAL());

             if (obj != null)
            {
                return obj.Method_name;
            }
            return "";
        }

         public static string GetId_Name(string _pName)
        {
            Method obj = SearchName(_pName, new DAL());

             if (obj != null)
            {
                return obj.Method_id;
            }
            return "";
        }

         #endregion[Get id - Name]

    }//cls
}//ns
