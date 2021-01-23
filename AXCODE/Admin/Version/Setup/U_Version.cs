// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 10:29:15 AM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXCORE
{
    public static class U_Version
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = VERSION.VERSION_TBL;

                int count = GetCount(tablename, OldDB);

                for (int i = 1; i <= count; i++)
                {
                    var obj = GetOldData(i, OldDB);

                if (obj != null)
                {
                    InsertData(obj);
                }
                }
            }

        #endregion[]

        #region[Get Count]

            private static int GetCount(string tablename, string OldDB)
            {
                string ID = (tablename.Remove((tablename).Length - 4).ToUpper()) + "_ID";

                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + tablename + " ORDER BY " + ID + " DESC LIMIT 1 ; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        int lastId = Convert.ToInt32(redr[ID]);

                        return lastId;
                    }
                    return 0;
                }
            }

        #endregion[Get Count]

        #region[Get Old data]

            private static Version GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + VERSION.VERSION_TBL + " WHERE " + VERSION.VERSION_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Version obj = new Version
                        {
                        Version_name = redr[VERSION.VERSION_NAME].ToString(),
                        Created_on = redr[VERSION.CREATED_ON].ToString(),
                        Changes = redr[VERSION.CHANGES].ToString(),
                        Notes = redr[VERSION.NOTES].ToString(),
                        Active_id = redr[VERSION.ACTIVE_ID].ToString(),
                        User_id = "1"
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Version obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + VERSION.VERSION_TBL + " WHERE " + VERSION.VERSION_NAME + " = '" + obj.Version_name + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Version_id = redr[VERSION.VERSION_ID].ToString();

                        CVersion.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Version obj)
            {
                if (CheckData(obj) == false)
                {
                    CVersion.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
