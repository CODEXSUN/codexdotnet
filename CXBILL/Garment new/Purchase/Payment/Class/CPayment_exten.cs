// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:14 AM
// last update : 13-03-2018

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class CPayment_exten
    {
        #region[Entity Data]

        private static Payment EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Payment obj = new Payment()
                    {
                        Payment_id = redr[PAYMENT.PAYMENT_ID].ToString(),
                        Payment_no = redr[PAYMENT.PAYMENT_NO].ToString(),
                        Payment_date = redr[PAYMENT.PAYMENT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Cheque_no = redr[PAYMENT.CHEQUE_NO].ToString(),
                        Payment_amount = redr[PAYMENT.PAYMENT_AMOUNT].ToString(),
                        Cheque_date = redr[PAYMENT.CHEQUE_DATE].ToString(),
                        Bank_id = redr[BANK.BANK_NAME].ToString(),
                        //Total_amount = redr[PAYMENT.TOTAL_AMOUNT].ToString(),
                        Notes = redr[PAYMENT.NOTES].ToString(),
                        Active_id = redr[PAYMENT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Payment();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Payment> EntityList(string q)
        {
            List<Payment> list = new List<Payment>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Payment obj = new Payment()
                    {
                        Payment_id = redr[PAYMENT.PAYMENT_ID].ToString(),
                        Payment_no = redr[PAYMENT.PAYMENT_NO].ToString(),
                        Payment_date = redr[PAYMENT.PAYMENT_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Receipttype_id = redr[RECEIPTTYPE.RECEIPTTYPE_NAME].ToString(),
                        Cheque_no = redr[PAYMENT.CHEQUE_NO].ToString(),
                        Payment_amount = redr[PAYMENT.PAYMENT_AMOUNT].ToString(),
                        Cheque_date = redr[PAYMENT.CHEQUE_DATE].ToString(),
                        Bank_id = redr[PAYMENT.BANK_ID].ToString(),
                        //Total_amount = redr[PAYMENT.TOTAL_AMOUNT].ToString(),
                        Notes = redr[PAYMENT.NOTES].ToString(),
                        Active_id = redr[PAYMENT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };

                    list.Add(obj);
                }

                redr.Close();
            }
            return list;
        }

        #endregion[Entity List]

        #region[Unrefer]

        public static List<Payment> Unrefer(DAL DAL)
        {
            string q = " SELECT " + PAYMENT.PAYMENT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PAYMENT.PAYMENT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            // q += " AND NOT " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_ID + " = '" + Core.One + "' \r\n";
            //q += " AND " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " ORDER BY  " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Unrefer]

        #region[refer]

        public static List<Payment> Refer(DAL DAL)
        {
            string q = " SELECT " + PAYMENT.PAYMENT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PAYMENT.PAYMENT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_ID + " = '" + Core.One + "' \r\n";
            //q += " AND NOT " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " ORDER BY  " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[refer]

        #region[showall]

        public static List<Payment> Showall(DAL DAL)
        {
            string q = " SELECT " + PAYMENT.PAYMENT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PAYMENT.PAYMENT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[showall]

        #region[not active]

        public static List<Payment> Notactive(DAL DAL)
        {
            string q = " SELECT " + PAYMENT.PAYMENT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PAYMENT.PAYMENT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[not active]

        #region[PKId]

        public static Payment PKId(string id, DAL DAL)
        {
            string q = " SELECT " + PAYMENT.PAYMENT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + BANK.BANK_TBL + "." + BANK.BANK_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PAYMENT.PAYMENT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_ID + " = '" + id + "' \r\n";
            //q += " AND NOT " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_NO + ";\r\n";

            return EntityData(q);
        }

        #endregion[PKId]

        #region[Searchby]

        public static List<Payment> Searchby(string no, string date, string party, DAL DAL)
        {
            string q = " SELECT " + PAYMENT.PAYMENT_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += ", " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PAYMENT.PAYMENT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " INNER JOIN  " + RECEIPTTYPE.RECEIPTTYPE_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.RECEIPTTYPE_ID + " = " + RECEIPTTYPE.RECEIPTTYPE_TBL + "." + RECEIPTTYPE.RECEIPTTYPE_ID + " )\r\n";
            q += " INNER JOIN  " + BANK.BANK_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.BANK_ID + " = " + BANK.BANK_TBL + "." + BANK.BANK_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_ID + " = '" + Core.One + "' \r\n";
            if (no != "")
            {
                q += " AND " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_NO + " = '" + no + "'\r\n";
            }
            if (date != "")
            {

                q += " AND " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " ORDER BY  " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Searchby]

        #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_NO + " \r\n";
            q += " FROM  " + PAYMENT.PAYMENT_TBL + " \r\n";
            q += " WHERE " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + PAYMENT.PAYMENT_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_DATE + " \r\n";
            q += " FROM  " + PAYMENT.PAYMENT_TBL + " \r\n";
            q += " WHERE " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.PAYMENT_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(PAYMENT.PAYMENT_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][PAYMENT.PAYMENT_DATE] + "")
                    );
                }
            }
            return tbl;
        }

        #endregion[GetforLookup]

        #region[GetNext_No]

        public static string GetNext_No
        {
            get
            {
                string q = "SELECT " + PAYMENT.PAYMENT_NO + " FROM " + PAYMENT.PAYMENT_TBL + "\r\n";
                q += " WHERE " + PAYMENT.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " AND " + PAYMENT.PAYMENT_TBL + "." + PAYMENT.ACY_ID + " = '" + Current.Acy_id + "'  \r\n";
                q += " ORDER BY " + PAYMENT.PAYMENT_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[PAYMENT.PAYMENT_NO].ToString())) + 1).ToString();
                    }
                    redr.Close();
                    return Core.One;
                }
            }
        }

        #endregion[GetNext_No]

        //#region[Lock Status]

        //public static bool LockStatus(string pkValue)
        //{
        //    if (pkValue != null)
        //    {
        //        Payment obj = PKId(pkValue, new DAL());
        //        if (obj.Locked == Core.Unlocked)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //#endregion[Lock Status]

        #region[Get id - No] 

        public static string GetName_Id(string Id)
        {
            Payment obj = PKId(Id, new DAL());

            if (obj != null)
            {
                return obj.Payment_no;
            }
            return "";
        }

        public static string GetId_Name(string No)
        {
            List<Payment> list = Searchby(No, "", "", new DAL());

            if (list.Count != 0)
            {
                return list[0].Payment_id;
            }
            return "";
        }

        #endregion[Get id - No] 

    }//cls
}//ns
