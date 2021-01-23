// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:24:15 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;

namespace CXCORE
{
    public static class U_State
    {
        #region[]

        public static void GetUpdated(string OldDB)
        {

            string tablename = STATE.STATE_TBL;

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

        private static State GetOldData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += "SELECT * FROM " + STATE.STATE_TBL + " WHERE " + STATE.STATE_ID + " = '" + id + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    State obj = new State
                    {
                        State_name = redr[STATE.STATE_NAME].ToString(),
                        State_code = redr[STATE.STATE_CODE].ToString(),
                        Notes = redr[STATE.NOTES].ToString(),
                        Active_id = redr[STATE.ACTIVE_ID].ToString(),
                        User_id = "1"
                    };

                    return obj;
                }
                return null;
            }
        }

        #endregion[Get Old data]

        #region[Check data]

        private static bool CheckData(State obj)
        {
            string q = "USE CODEXSUN_DB; ";
            q += "SELECT * FROM " + STATE.STATE_TBL + " WHERE " + STATE.STATE_NAME + " = '" + obj.State_name + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    obj.State_id = redr[STATE.STATE_ID].ToString();

                    CState.Update(obj, new DAL());

                    return true;
                }
                return false;
            }
        }
        #endregion[Check data]

        #region[Insert data]

        private static void InsertData(State obj)
        {
            if (CheckData(obj) == false)
            {
                CState.Insert(obj, new DAL());
            };

        }
        #endregion[Insert data]

    }//cls
}//ns
