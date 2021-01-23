// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXCORE
{
    public static class U_Hsncode
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = HSNCODE.HSNCODE_TBL;

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

            private static Hsncode GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + HSNCODE.HSNCODE_TBL + " WHERE " + HSNCODE.HSNCODE_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Hsncode obj = new Hsncode
                        {
                        Hsncode_name = redr[HSNCODE.HSNCODE_NAME].ToString(),
                        Description = redr[HSNCODE.DESCRIPTION].ToString(),
                        Notes = redr[HSNCODE.NOTES].ToString(),
                        Active_id = redr[HSNCODE.ACTIVE_ID].ToString(),
                        User_id = "1"
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Hsncode obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + HSNCODE.HSNCODE_TBL + " WHERE " + HSNCODE.HSNCODE_NAME + " = '" + obj.Hsncode_name + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Hsncode_id = redr[HSNCODE.HSNCODE_ID].ToString();

                        CHsncode.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Hsncode obj)
            {
                if (CheckData(obj) == false)
                {
                    CHsncode.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
