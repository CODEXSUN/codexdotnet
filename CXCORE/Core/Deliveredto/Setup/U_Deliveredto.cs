// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;

namespace CXCORE
{
    public static class U_Deliveredto
    {
        #region[]

        public static void GetUpdated(string OldDB)
        {

            string tablename = DELIVEREDTO.DELIVEREDTO_TBL;

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
            q += "SELECT * FROM deliveryto_tbl ORDER BY DELIVERYTO_ID DESC LIMIT 1 ; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    int lastId = Convert.ToInt32(redr["DELIVERYTO_ID"]);

                    return lastId;
                }
                return 0;
            }
        }

        #endregion[Get Count]

        #region[Get Old data]

        private static Deliveredto GetOldData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += "SELECT * FROM deliveryto_tbl WHERE DELIVERYTO_ID = '" + id + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Deliveredto obj = new Deliveredto
                    {
                        Deliveredto_name = redr["DELIVERYTO_NAME"].ToString(),
                        Notes = redr[DELIVEREDTO.NOTES].ToString(),
                        Active_id = redr[DELIVEREDTO.ACTIVE_ID].ToString(),
                        User_id = "1"
                    };

                    return obj;
                }
                return null;
            }
        }

        #endregion[Get Old data]

        #region[Check data]

        private static bool CheckData(Deliveredto obj)
        {
            string q = "USE CODEXSUN_DB; ";
            q += "SELECT * FROM " + DELIVEREDTO.DELIVEREDTO_TBL + " WHERE " + DELIVEREDTO.DELIVEREDTO_NAME + " = '" + obj.Deliveredto_name + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    obj.Deliveredto_id = redr[DELIVEREDTO.DELIVEREDTO_ID].ToString();

                    CDeliveredto.Update(obj, new DAL());

                    return true;
                }
                return false;
            }
        }
        #endregion[Check data]

        #region[Insert data]

        private static void InsertData(Deliveredto obj)
        {
            if (CheckData(obj) == false)
            {
                CDeliveredto.Insert(obj, new DAL());
            };

        }
        #endregion[Insert data]

    }//cls
}//ns
