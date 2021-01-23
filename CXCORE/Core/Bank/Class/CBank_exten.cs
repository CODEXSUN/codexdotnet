// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CBank_exten
    {
        #region[Entity Data]

        private static Bank EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Bank obj = new Bank()
                    {
                        Bank_id = redr[BANK.BANK_ID].ToString(),
                        Bank_name = redr[BANK.BANK_NAME].ToString(),
                        Account_number = redr[BANK.ACCOUNT_NUMBER].ToString(),
                        Ifsc_code = redr[BANK.IFSC_CODE].ToString(),
                        Opening_balance = ConvertTO.Decimal(redr[BANK.OPENING_BALANCE].ToString()),
                        Notes = redr[BANK.NOTES].ToString(),
                        Active_id = redr[BANK.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Bank();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Bank> EntityList(string q)
        {
            List<Bank> list = new List<Bank>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Bank obj = new Bank()
                    {
                        Bank_id = redr[BANK.BANK_ID].ToString(),
                        Bank_name = redr[BANK.BANK_NAME].ToString(),
                        Account_number = redr[BANK.ACCOUNT_NUMBER].ToString(),
                        Ifsc_code = redr[BANK.IFSC_CODE].ToString(),
                        Opening_balance = ConvertTO.Decimal(redr[BANK.OPENING_BALANCE].ToString()),
                        Notes = redr[BANK.NOTES].ToString(),
                        Active_id = redr[BANK.ACTIVE_ID].ToString(),
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

        public static List<Bank> Active(DAL DAL)
        {
            string q = " SELECT " + BANK.BANK_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + BANK.BANK_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + BANK.BANK_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + BANK.BANK_TBL + "." + BANK.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + BANK.BANK_TBL + "." + BANK.BANK_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + BANK.BANK_TBL + "." + BANK.BANK_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Bank> NotActive(DAL DAL)
        {
            string q = " SELECT " + BANK.BANK_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + BANK.BANK_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + BANK.BANK_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + BANK.BANK_TBL + "." + BANK.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + BANK.BANK_TBL + "." + BANK.BANK_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + BANK.BANK_TBL + "." + BANK.BANK_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Bank PKId(string v, DAL DAL)
        {
            string q = " SELECT " + BANK.BANK_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + BANK.BANK_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + BANK.BANK_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + BANK.BANK_TBL + "." + BANK.BANK_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Bank SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + BANK.BANK_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + BANK.BANK_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + BANK.BANK_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + BANK.BANK_TBL + "." + BANK.BANK_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + BANK.BANK_TBL + "." + BANK.BANK_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + BANK.BANK_TBL + ".* \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + BANK.BANK_TBL + " \r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + BANK.BANK_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + BANK.BANK_TBL + "." + BANK.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + BANK.BANK_TBL + "." + BANK.BANK_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + BANK.BANK_TBL + "." + BANK.BANK_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Bank obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Bank_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Bank obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Bank_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
