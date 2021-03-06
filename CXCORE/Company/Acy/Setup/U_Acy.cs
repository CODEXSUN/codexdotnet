// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXCORE
{
    public static class U_Acy
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = ACY.ACY_TBL;

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

            private static Acy GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + ACY.ACY_TBL + " WHERE " + ACY.ACY_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Acy obj = new Acy
                        {
                        Acy_name = redr[ACY.ACY_NAME].ToString(),
                        From_date = redr[ACY.FROM_DATE].ToString(),
                        To_date = redr[ACY.TO_DATE].ToString(),
                        Notes = redr[ACY.NOTES].ToString(),
                        Active_id = redr[ACY.ACTIVE_ID].ToString(),
                        User_id = "1"
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Acy obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + ACY.ACY_TBL + " WHERE " + ACY.ACY_NAME + " = '" + obj.Acy_name + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Acy_id = redr[ACY.ACY_ID].ToString();

                        CAcy.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Acy obj)
            {
                if (CheckData(obj) == false)
                {
                    CAcy.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
