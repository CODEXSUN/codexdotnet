//// Version : 4.0.0.2 Date : 10-08-2020
//// Auto Generated
//// last update : 23-01-2021 08:39:04 PM

//using System; 
//using System.Data; 
//using CXLIB; 
//using CXCORE; 

//namespace AXCODE
//{
//    public static class U_Po
//    {
//        #region[]

//            public static void GetUpdated(string OldDB)
//            {

//                string tablename = PO.PO_TBL;

//                int count = GetCount(tablename, OldDB);

//                for (int i = 1; i <= count; i++)
//                {
//                    var obj = GetOldData(i, OldDB);

//                if (obj != null)
//                {
//                    InsertData(obj);
//                }
//                }
//            }

//        #endregion[]

//        #region[Get Count]

//            private static int GetCount(string tablename, string OldDB)
//            {
//                string ID = (tablename.Remove((tablename).Length - 4).ToUpper()) + "_ID";

//                string q = "USE " + OldDB + "; ";
//                q += "SELECT * FROM " + tablename + " ORDER BY " + ID + " DESC LIMIT 1 ; ";

//                using (IDataReader redr = new DAL().Listreader(q))
//                {
//                    while (redr.Read() == true)
//                    {
//                        int lastId = Convert.ToInt32(redr[ID]);

//                        return lastId;
//                    }
//                    return 0;
//                }
//            }

//        #endregion[Get Count]

//        #region[Get Old data]

//            private static Po GetOldData(int id, string OldDB)
//            {
//                string q = "USE " + OldDB + "; ";
//                q += "SELECT * FROM " + PO.PO_TBL + " WHERE " + PO.PO_ID + " = '" + id + "'; ";

//                using (IDataReader redr = new DAL().Listreader(q))
//                {
//                    while (redr.Read() == true)
//                    {
//                        Po obj = new Po
//                        {
//                        Po_no = redr[PO.PO_NO].ToString(),
//                        Po_date = redr[PO.PO_DATE].ToString(),
//                        Notes = redr[PO.NOTES].ToString(),
//                        Active_id = redr[PO.ACTIVE_ID].ToString(),
//                        User_id = "1"
//                        };

//                        return obj;
//                    }
//                    return null;
//                }
//            }

//        #endregion[Get Old data]

//#region[Check data]

//            private static bool CheckData(Po obj)
//            {
//                string q = "USE CODEXSUN_DB; ";
//                q += "SELECT * FROM " + PO.PO_TBL + " WHERE " + PO.PO_NO + " = '" + obj.Po_name + "'; ";

//                using (IDataReader redr = new DAL().Listreader(q))
//                {
//                    while (redr.Read() == true)
//                    {
//                        obj.Po_id = redr[PO.PO_ID].ToString();

//                        CPo.Update(obj, new DAL());

//                        return true;
//                    }
//                    return false;
//                }
//            }
//            #endregion[Check data]

//        #region[Insert data]

//            private static void InsertData(Po obj)
//            {
//                if (CheckData(obj) == false)
//                {
//                    CPo.Insert(obj, new DAL());
//                };

//            }
//        #endregion[Insert data]

//    }//cls
//}//ns
