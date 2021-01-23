// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXCORE
{
    public static class U_Colours
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = COLOURS.COLOURS_TBL;

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

            private static Colours GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + COLOURS.COLOURS_TBL + " WHERE " + COLOURS.COLOURS_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Colours obj = new Colours
                        {
                        Colours_name = redr[COLOURS.COLOURS_NAME].ToString(),
                        Notes = redr[COLOURS.NOTES].ToString(),
                        Active_id = redr[COLOURS.ACTIVE_ID].ToString(),
                        User_id = "1"
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Colours obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + COLOURS.COLOURS_TBL + " WHERE " + COLOURS.COLOURS_NAME + " = '" + obj.Colours_name + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Colours_id = redr[COLOURS.COLOURS_ID].ToString();

                        CColours.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Colours obj)
            {
                if (CheckData(obj) == false)
                {
                    CColours.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
