// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXCORE
{
    public static class U_Defaultlogin
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = DEFAULTLOGIN.DEFAULTLOGIN_TBL;

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

            private static Defaultlogin GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + DEFAULTLOGIN.DEFAULTLOGIN_TBL + " WHERE " + DEFAULTLOGIN.DEFAULTLOGIN_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Defaultlogin obj = new Defaultlogin
                        {
                        Defaultlogin_name = redr[DEFAULTLOGIN.DEFAULTLOGIN_NAME].ToString(),
                        Default_password = redr[DEFAULTLOGIN.DEFAULT_PASSWORD].ToString(),
                        Createon = redr[DEFAULTLOGIN.CREATEON].ToString(),
                        Notes = redr[DEFAULTLOGIN.NOTES].ToString(),
                        Active_id = redr[DEFAULTLOGIN.ACTIVE_ID].ToString(),
                        User_id = "1"
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Defaultlogin obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + DEFAULTLOGIN.DEFAULTLOGIN_TBL + " WHERE " + DEFAULTLOGIN.DEFAULTLOGIN_NAME + " = '" + obj.Defaultlogin_name + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Defaultlogin_id = redr[DEFAULTLOGIN.DEFAULTLOGIN_ID].ToString();

                        CDefaultlogin.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Defaultlogin obj)
            {
                if (CheckData(obj) == false)
                {
                    CDefaultlogin.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
