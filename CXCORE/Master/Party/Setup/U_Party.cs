// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;

namespace CXCORE
{
    public static class U_Party
    {
        #region[]

        public static void GetUpdated(string OldDB)
        {

            string tablename = PARTY.PARTY_TBL;

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

        private static Party GetOldData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";
            q += " SELECT " + PARTY.PARTY_TBL + ".* \r\n";
            q += ", " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_NAME + " \r\n";
            q += ", " + CITY.CITY_TBL + "." + CITY.CITY_NAME + " \r\n";
            q += ", " + STATE.STATE_TBL + "." + STATE.STATE_NAME + " \r\n";
            q += ", " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + " \r\n";
            q += ", " + PINCODE.PINCODE_TBL + "." + PINCODE.PINCODE_NAME + " \r\n";
            q += " FROM  " + PARTY.PARTY_TBL + " \r\n";
            q += " INNER JOIN  " + CONTACTTYPE.CONTACTTYPE_TBL + " \r\n";
            q += " ON( " + PARTY.PARTY_TBL + "." + CONTACTTYPE.CONTACTTYPE_ID + " = " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + CITY.CITY_TBL + " \r\n";
            q += " ON( " + PARTY.PARTY_TBL + "." + CITY.CITY_ID + " = " + CITY.CITY_TBL + "." + CITY.CITY_ID + ")\r\n";
            q += " INNER JOIN  " + STATE.STATE_TBL + " \r\n";
            q += " ON( " + PARTY.PARTY_TBL + "." + STATE.STATE_ID + " = " + STATE.STATE_TBL + "." + STATE.STATE_ID + ")\r\n";
            q += " INNER JOIN  " + COUNTRY.COUNTRY_TBL + " \r\n";
            q += " ON( " + PARTY.PARTY_TBL + "." + COUNTRY.COUNTRY_ID + " = " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_ID + ")\r\n";
            q += " INNER JOIN  " + PINCODE.PINCODE_TBL + " \r\n";
            q += " ON( " + PARTY.PARTY_TBL + "." + PINCODE.PINCODE_ID + " = " + PINCODE.PINCODE_TBL + "." + PINCODE.PINCODE_ID + ")\r\n";
            q += " WHERE " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + "  = '" + id + "';\r\n";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Party obj = new Party
                    {
                        Party_name = redr[PARTY.PARTY_NAME].ToString(),
                        Contacttype_id = CContacttype_exten.GetId_Name(redr[CONTACTTYPE.CONTACTTYPE_NAME].ToString()),
                        Contact_person = redr[PARTY.CONTACT_PERSON].ToString(),
                        Street_1 = redr["STREET1"].ToString(),
                        Street_2 = redr["STREET2"].ToString(),
                        City_id = CCity_exten.GetId_Name(redr[CITY.CITY_NAME].ToString()),
                        State_id = CState_exten.GetId_Name(redr[STATE.STATE_NAME].ToString()),
                        Country_id = CCountry_exten.GetId_Name(redr[COUNTRY.COUNTRY_NAME].ToString()),
                        Pincode_id = CPincode_exten.GetId_Name(redr[PINCODE.PINCODE_NAME].ToString()),
                        Phone = redr[PARTY.PHONE].ToString(),
                        Cell = redr[PARTY.CELL].ToString(),
                        Email = redr[PARTY.EMAIL].ToString(),
                        Website = redr[PARTY.WEBSITE].ToString(),
                        Gstin = redr[PARTY.GSTIN].ToString(),
                        Pan = redr[PARTY.PAN].ToString(),
                        Opening_balance = ConvertTO.Decimal(redr[PARTY.OPENING_BALANCE].ToString()),
                        Credit_days = ConvertTO.Decimal(redr[PARTY.CREDIT_DAYS].ToString()),
                        Notes = redr[PARTY.NOTES].ToString(),
                        Active_id = redr[PARTY.ACTIVE_ID].ToString(),
                        User_id = "1"
                    };

                    return obj;
                }
                return null;
            }
        }

        #endregion[Get Old data]

        #region[Check data]

        private static bool CheckData(Party obj)
        {
            string q = "USE CODEXSUN_DB; ";
            q += "SELECT * FROM " + PARTY.PARTY_TBL + " WHERE " + PARTY.PARTY_NAME + " = '" + obj.Party_name + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    obj.Party_id = redr[PARTY.PARTY_ID].ToString();

                    CParty.Update(obj, new DAL());

                    return true;
                }
                return false;
            }
        }
        #endregion[Check data]

        #region[Insert data]

        private static void InsertData(Party obj)
        {
            if (CheckData(obj) == false)
            {
                CParty.Insert(obj, new DAL());
            };

        }
        #endregion[Insert data]

    }//cls
}//ns
