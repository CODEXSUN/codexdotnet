// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXCORE
{
    public static class U_Salestype
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = SALESTYPE.SALESTYPE_TBL;

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

            private static Salestype GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + SALESTYPE.SALESTYPE_TBL + " WHERE " + SALESTYPE.SALESTYPE_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Salestype obj = new Salestype
                        {
                        Salestype_name = redr[SALESTYPE.SALESTYPE_NAME].ToString(),
                        Notes = redr[SALESTYPE.NOTES].ToString(),
                        Active_id = redr[SALESTYPE.ACTIVE_ID].ToString(),
                        User_id = "1"
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Salestype obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + SALESTYPE.SALESTYPE_TBL + " WHERE " + SALESTYPE.SALESTYPE_NAME + " = '" + obj.Salestype_name + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Salestype_id = redr[SALESTYPE.SALESTYPE_ID].ToString();

                        CSalestype.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Salestype obj)
            {
                if (CheckData(obj) == false)
                {
                    CSalestype.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
