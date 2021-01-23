// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 07:41:20 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CParty_exten
    {
        #region[Entity Data]

        private static Party EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Party obj = new Party()
                    {
                        Party_id = redr[PARTY.PARTY_ID].ToString(),
                        Party_name = redr[PARTY.PARTY_NAME].ToString(),
                        Contacttype_id = redr[CONTACTTYPE.CONTACTTYPE_NAME].ToString(),
                        Contact_person = redr[PARTY.CONTACT_PERSON].ToString(),
                        Street_1 = redr[PARTY.STREET_1].ToString(),
                        Street_2 = redr[PARTY.STREET_2].ToString(),
                        City_id = redr[CITY.CITY_NAME].ToString(),
                        State_id = redr[STATE.STATE_NAME].ToString(),
                        Country_id = redr[COUNTRY.COUNTRY_NAME].ToString(),
                        Pincode_id = redr[PINCODE.PINCODE_NAME].ToString(),
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
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Party();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Party> EntityList(string q)
        {
            List<Party> list = new List<Party>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Party obj = new Party()
                    {
                        Party_id = redr[PARTY.PARTY_ID].ToString(),
                        Party_name = redr[PARTY.PARTY_NAME].ToString(),
                        Contacttype_id = redr[CONTACTTYPE.CONTACTTYPE_NAME].ToString(),
                        Contact_person = redr[PARTY.CONTACT_PERSON].ToString(),
                        Street_1 = redr[PARTY.STREET_1].ToString(),
                        Street_2 = redr[PARTY.STREET_2].ToString(),
                        City_id = redr[CITY.CITY_NAME].ToString(),
                        State_id = redr[STATE.STATE_NAME].ToString(),
                        Country_id = redr[COUNTRY.COUNTRY_NAME].ToString(),
                        Pincode_id = redr[PINCODE.PINCODE_NAME].ToString(),
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
                        User_id = redr[USER.USER_NAME].ToString()
                    };

                    list.Add(obj);
                }

                redr.Close();
            }
            return list;
        }

        #endregion[Entity List]

        #region[Active]

        public static List<Party> Active(DAL DAL)
        {
            string q = " SELECT " + PARTY.PARTY_TBL + ".* \r\n";
            q += ", " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_NAME + " \r\n";
            q += ", " + CITY.CITY_TBL + "." + CITY.CITY_NAME + " \r\n";
            q += ", " + STATE.STATE_TBL + "." + STATE.STATE_NAME + " \r\n";
            q += ", " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + " \r\n";
            q += ", " + PINCODE.PINCODE_TBL + "." + PINCODE.PINCODE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
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
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PARTY.PARTY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PARTY.PARTY_TBL + "." + PARTY.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Party> NotActive(DAL DAL)
        {
            string q = " SELECT " + PARTY.PARTY_TBL + ".* \r\n";
            q += ", " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_NAME + " \r\n";
            q += ", " + CITY.CITY_TBL + "." + CITY.CITY_NAME + " \r\n";
            q += ", " + STATE.STATE_TBL + "." + STATE.STATE_NAME + " \r\n";
            q += ", " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + " \r\n";
            q += ", " + PINCODE.PINCODE_TBL + "." + PINCODE.PINCODE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
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
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PARTY.PARTY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PARTY.PARTY_TBL + "." + PARTY.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Party PKId(string v, DAL DAL)
        {
            string q = " SELECT " + PARTY.PARTY_TBL + ".* \r\n";
            q += ", " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_NAME + " \r\n";
            q += ", " + CITY.CITY_TBL + "." + CITY.CITY_NAME + " \r\n";
            q += ", " + STATE.STATE_TBL + "." + STATE.STATE_NAME + " \r\n";
            q += ", " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + " \r\n";
            q += ", " + PINCODE.PINCODE_TBL + "." + PINCODE.PINCODE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
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
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PARTY.PARTY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Party SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + PARTY.PARTY_TBL + ".* \r\n";
            q += ", " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_NAME + " \r\n";
            q += ", " + CITY.CITY_TBL + "." + CITY.CITY_NAME + " \r\n";
            q += ", " + STATE.STATE_TBL + "." + STATE.STATE_NAME + " \r\n";
            q += ", " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + " \r\n";
            q += ", " + PINCODE.PINCODE_TBL + "." + PINCODE.PINCODE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
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
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PARTY.PARTY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + PARTY.PARTY_TBL + ".* \r\n";
            q += ", " + CONTACTTYPE.CONTACTTYPE_TBL + "." + CONTACTTYPE.CONTACTTYPE_NAME + " \r\n";
            q += ", " + CITY.CITY_TBL + "." + CITY.CITY_NAME + " \r\n";
            q += ", " + STATE.STATE_TBL + "." + STATE.STATE_NAME + " \r\n";
            q += ", " + COUNTRY.COUNTRY_TBL + "." + COUNTRY.COUNTRY_NAME + " \r\n";
            q += ", " + PINCODE.PINCODE_TBL + "." + PINCODE.PINCODE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
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
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PARTY.PARTY_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PARTY.PARTY_TBL + "." + PARTY.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Party obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Party_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Party obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Party_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
