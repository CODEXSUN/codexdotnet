// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXCORE
{
    public static class U_Role
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = ROLE.ROLE_TBL;

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

            private static Role GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + ROLE.ROLE_TBL + " WHERE " + ROLE.ROLE_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Role obj = new Role
                        {
                        Role_name = redr[ROLE.ROLE_NAME].ToString(),
                        Notes = redr[ROLE.NOTES].ToString(),
                        Active_id = redr[ROLE.ACTIVE_ID].ToString(),
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Role obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + ROLE.ROLE_TBL + " WHERE " + ROLE.ROLE_NAME + " = '" + obj.Role_name + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Role_id = redr[ROLE.ROLE_ID].ToString();

                        CRole.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Role obj)
            {
                if (CheckData(obj) == false)
                {
                    CRole.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
