// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXCORE
{
    public static class U_Taxtype
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = TAXTYPE.TAXTYPE_TBL;

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

            private static Taxtype GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + TAXTYPE.TAXTYPE_TBL + " WHERE " + TAXTYPE.TAXTYPE_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Taxtype obj = new Taxtype
                        {
                        Taxtype_name = redr[TAXTYPE.TAXTYPE_NAME].ToString(),
                        Notes = redr[TAXTYPE.NOTES].ToString(),
                        Active_id = redr[TAXTYPE.ACTIVE_ID].ToString(),
                        User_id = "1"
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Taxtype obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + TAXTYPE.TAXTYPE_TBL + " WHERE " + TAXTYPE.TAXTYPE_NAME + " = '" + obj.Taxtype_name + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Taxtype_id = redr[TAXTYPE.TAXTYPE_ID].ToString();

                        CTaxtype.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Taxtype obj)
            {
                if (CheckData(obj) == false)
                {
                    CTaxtype.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
