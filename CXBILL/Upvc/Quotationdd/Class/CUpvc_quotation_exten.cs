// Version : 4 dt : 04-10-2017
// Auto Generated
// 04-10-2017 10:21:50 PM
// last update : 04-10-2017

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXUPVC
{
    public class CUpvc_quotation_exten
    {
         #region[Entity Data]

        private static Upvc_quotation EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                 while (redr.Read() == true)
                 {
                    Upvc_quotation obj = new Upvc_quotation()
                    {
                        Upvc_quotation_id = redr[UPVC_QUOTATION.UPVC_QUOTATION_ID].ToString(),
                        Salestype = redr[UPVC_QUOTATION.SALESTYPE].ToString(),
                        Upvc_salesmode_id = redr[UPVC_SALESMODE.UPVC_SALESMODE_NAME].ToString(),
                        Upvc_quotation_no = redr[UPVC_QUOTATION.UPVC_QUOTATION_NO].ToString(),
                        Upvc_quotation_date = redr[UPVC_QUOTATION.UPVC_QUOTATION_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Shipping_id = redr[UPVC_QUOTATION.SHIPPING_ID].ToString(),
                        //Transport_mode_id = redr[TRANSPORT.TRANSPORT_NAME].ToString(),
                        //Vehicle_no = redr[UPVC_QUOTATION.VEHICLE_NO].ToString(),
                        Total_qty = redr[UPVC_QUOTATION.TOTAL_QTY].ToString(),
                        Total_areasq = redr[UPVC_QUOTATION.TOTAL_AREASQ].ToString(),
                        Total_taxable_amount = redr[UPVC_QUOTATION.TOTAL_TAXABLE_AMOUNT].ToString(),
                        Total_cgst = redr[UPVC_QUOTATION.TOTAL_CGST].ToString(),
                        Total_sgst = redr[UPVC_QUOTATION.TOTAL_SGST].ToString(),
                        Total_igst = redr[UPVC_QUOTATION.TOTAL_IGST].ToString(),
                        Gsttotal = redr[UPVC_QUOTATION.GSTTOTAL].ToString(),
                        Ledger_id = redr[UPVC_QUOTATION.LEDGER_ID].ToString(),
                        Additional = redr[UPVC_QUOTATION.ADDITIONAL].ToString(),
                        Rounds = redr[UPVC_QUOTATION.ROUNDS].ToString(),
                        Grandtotal = redr[UPVC_QUOTATION.GRANDTOTAL].ToString(),
                        Refered_no = redr[UPVC_QUOTATION.REFERED_NO].ToString(),
                        Locked = redr[UPVC_QUOTATION.LOCKED].ToString(),
                        Notes = redr[UPVC_QUOTATION.NOTES].ToString(),
                        Active_id = redr[UPVC_QUOTATION.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                        };
                    return obj;
                 }
            redr.Close();
            return new Upvc_quotation();
            }
        }

        #endregion[Entity Data]

         #region[Entity List]

         private static List<Upvc_quotation> EntityList(string q)
         {
             List<Upvc_quotation> list = new List<Upvc_quotation>();

             using (IDataReader redr = new DAL().Listreader(q))
             {
                 while (redr.Read() == true)
                 {
                      Upvc_quotation obj = new Upvc_quotation()
                     {
                        Upvc_quotation_id = redr[UPVC_QUOTATION.UPVC_QUOTATION_ID].ToString(),
                        Salestype = redr[UPVC_QUOTATION.SALESTYPE].ToString(),
                        Upvc_salesmode_id = redr[UPVC_SALESMODE.UPVC_SALESMODE_NAME].ToString(),
                        Upvc_quotation_no = redr[UPVC_QUOTATION.UPVC_QUOTATION_NO].ToString(),
                        Upvc_quotation_date = redr[UPVC_QUOTATION.UPVC_QUOTATION_DATE].ToString(),
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Shipping_id = redr[UPVC_QUOTATION.SHIPPING_ID].ToString(),
                        //Transport_mode_id = redr[TRANSPORT.TRANSPORT_NAME].ToString(),
                        //Vehicle_no = redr[UPVC_QUOTATION.VEHICLE_NO].ToString(),
                        Total_qty = redr[UPVC_QUOTATION.TOTAL_QTY].ToString(),
                        Total_areasq = redr[UPVC_QUOTATION.TOTAL_AREASQ].ToString(),
                        Total_taxable_amount = redr[UPVC_QUOTATION.TOTAL_TAXABLE_AMOUNT].ToString(),
                        Total_cgst = redr[UPVC_QUOTATION.TOTAL_CGST].ToString(),
                        Total_sgst = redr[UPVC_QUOTATION.TOTAL_SGST].ToString(),
                        Total_igst = redr[UPVC_QUOTATION.TOTAL_IGST].ToString(),
                        Gsttotal = redr[UPVC_QUOTATION.GSTTOTAL].ToString(),
                        Ledger_id = redr[UPVC_QUOTATION.LEDGER_ID].ToString(),
                        Additional = redr[UPVC_QUOTATION.ADDITIONAL].ToString(),
                        Rounds = redr[UPVC_QUOTATION.ROUNDS].ToString(),
                        Grandtotal = redr[UPVC_QUOTATION.GRANDTOTAL].ToString(),
                        Refered_no = redr[UPVC_QUOTATION.REFERED_NO].ToString(),
                        Locked = redr[UPVC_QUOTATION.LOCKED].ToString(),
                        Notes = redr[UPVC_QUOTATION.NOTES].ToString(),
                        Active_id = redr[UPVC_QUOTATION.ACTIVE_ID].ToString(),
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

         public static List<Upvc_quotation> Unrefer(DAL DAL)
         {
            string q = " SELECT " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + ".* \r\n";
            q += ", " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "." + UPVC_SALESMODE.UPVC_SALESMODE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            //q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_SALESMODE_ID + " = " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "." + UPVC_SALESMODE.UPVC_SALESMODE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            //q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            //q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Unrefer]

         #region[refer]

         public static List<Upvc_quotation> Refer(DAL DAL)
         {
            string q = " SELECT " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + ".* \r\n";
            q += ", " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "." + UPVC_SALESMODE.UPVC_SALESMODE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            //q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_SALESMODE_ID + " = " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "." + UPVC_SALESMODE.UPVC_SALESMODE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            //q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            //q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND NOT " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.LOCKED + " = '" + Core.Unlocked + "'  \r\n";
            q += " AND " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[refer]

         #region[showall]

         public static List<Upvc_quotation> Showall(DAL DAL)
         {
            string q = " SELECT " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + ".* \r\n";
            q += ", " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "." + UPVC_SALESMODE.UPVC_SALESMODE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            //q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_SALESMODE_ID + " = " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "." + UPVC_SALESMODE.UPVC_SALESMODE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            //q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            //q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[showall]

         #region[not active]

         public static List<Upvc_quotation> Notactive(DAL DAL)
         {
            string q = " SELECT " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + ".* \r\n";
            q += ", " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "." + UPVC_SALESMODE.UPVC_SALESMODE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            //q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_SALESMODE_ID + " = " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "." + UPVC_SALESMODE.UPVC_SALESMODE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            //q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            //q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            q += " AND " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[not active]

         #region[PKId]

         public static Upvc_quotation PKId(string id, DAL DAL)
         {
            string q = " SELECT " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + ".* \r\n";
            q += ", " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "." + UPVC_SALESMODE.UPVC_SALESMODE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            //q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_SALESMODE_ID + " = " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "." + UPVC_SALESMODE.UPVC_SALESMODE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            //q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            //q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_ID + " = '" + id + "' \r\n";
            q += " AND " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_NO + ";\r\n";

             return EntityData(q);
         }

         #endregion[PKId]

         #region[Searchby]

         public static List<Upvc_quotation> Searchby(string no, string date, string party, DAL DAL)
         {
            string q = " SELECT " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + ".* \r\n";
            q += ", " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "." + UPVC_SALESMODE.UPVC_SALESMODE_NAME + " \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            //q += ", " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_SALESMODE_ID + " = " + UPVC_SALESMODE.UPVC_SALESMODE_TBL + "." + UPVC_SALESMODE.UPVC_SALESMODE_ID + " )\r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            //q += " INNER JOIN  " + TRANSPORT.TRANSPORT_TBL + "\r\n";
            //q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.TRANSPORT_ID + " = " + TRANSPORT.TRANSPORT_TBL + "." + TRANSPORT.TRANSPORT_ID + " )\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            if (no != "")
            {
                q += " AND " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_NO + " = '" + no + "'\r\n";
            }
            if (date != "")
            {

                q += " AND " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_DATE + " = " + ConvertTO.SqlDate(date) + "\r\n";
            }
            if (party != "")
            {
                q += " AND " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " = '" + party + "'  \r\n";
            }
            q += " AND " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_NO + ";\r\n";

             return EntityList(q);
         }

         #endregion[Searchby]

         #region[GetforLookup]

        public static DataTable LookupNo(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_NO + " \r\n";
            q += " FROM  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + " \r\n";
            q += " WHERE " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupParty(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_NO + ";\r\n";

            return DAL.Listdata(q);
        }

        public static DataTable LookupDate(DAL DAL)
        {
            string q = " SELECT  DISTINCT \r\n";
            q += " " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_DATE + " \r\n";
            q += " FROM  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + " \r\n";
            q += " WHERE " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            q += " AND " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.COMPANY_ID + " = '" + Current.Company_id + "'  \r\n";
            q += " ORDER BY  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_NO + ";\r\n";

            DataTable xtbl = DAL.Listdata(q);

            DataTable tbl = new DataTable();

            tbl.Columns.Add(UPVC_QUOTATION.UPVC_QUOTATION_DATE, typeof(string));
            if (xtbl.Rows.Count != 0)
            {
                for (int i = 0; i < xtbl.Rows.Count; i++)
                {
                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][UPVC_QUOTATION.UPVC_QUOTATION_DATE] + "")
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
                string q = "SELECT " + UPVC_QUOTATION.UPVC_QUOTATION_NO + " FROM " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "\r\n";
                q += " WHERE " + UPVC_QUOTATION.COMPANY_ID + " = " + Current.Company_id + " \r\n";
                q += " ORDER BY " + UPVC_QUOTATION.UPVC_QUOTATION_NO + " DESC LIMIT 1;\r\n";
                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        return ((Convert.ToInt32(redr[UPVC_QUOTATION.UPVC_QUOTATION_NO].ToString())) + 1).ToString();
                    }
                    redr.Close();
                    return Core.One;
                }
            }
        }

        #endregion[GetNext_No]

        #region[Lock Status]

        public static bool LockStatus(string pkValue)
        {
            if (pkValue != null)
            {
                Upvc_quotation obj = PKId(pkValue, new DAL());
                if (obj.Locked == Core.Unlocked)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion[Lock Status]

        #region[Get id - No] 
 
         public static string GetName_Id(string Id) 
         { 
             Upvc_quotation obj = PKId(Id, new DAL()); 
 
             if (obj != null) 
             { 
                 return obj.Upvc_quotation_no; 
             } 
             return ""; 
         } 
 
         public static string GetId_Name(string No) 
         { 
             List<Upvc_quotation> list = Searchby(No, "", "", new DAL()); 
 
             if (list.Count != 0) 
             { 
                 return list[0].Upvc_quotation_id; 
             } 
             return ""; 
         } 
 
         #endregion[Get id - No] 
         
    }//cls
}//ns
