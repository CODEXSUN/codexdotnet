// Version : 4 dt : 04-10-2017
// Auto Generated
// 04-10-2017 10:00:53 PM
// last update : 04-10-2017

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class Ccoreplus
    {
        #region[Get id - Name]

        public static string GetStateCode(string _pName)
        {
            State obj = CState_exten.SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.State_code;
            }
            return "";
        }


        public static string GetCity_id(string _id)
        {
            Party obj = CParty_exten.PKId(_id, new DAL());

            if (obj != null)
            {
                return obj.City_id;
            }
            return "";
        }

        #endregion[Get id - Name]

        public static string GetSgst_Name(string _pName)
        {
            Product obj = CProduct_exten.SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Sgst_percent;
            }
            return "";
        }

        public static string GetCgst_Name(string _pName)
        {
            Product obj = CProduct_exten.SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Cgst_percent;
            }
            return "";
        }

        public static string GetIgst_Name(string _pName)
        {
            Product obj = CProduct_exten.SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Igst_percent;
            }
            return "";
        }

        public static string GetHsncode_Id(string product_id)
        {
            Product obj = CProduct_exten.PKId(product_id, new DAL());

            if (obj != null)
            {
                return (obj.Hsncode_id);
            }
            return "";
        }

        public static string GetHsncode_name(string name)
        {
            Product obj = CProduct_exten.SearchName(name, new DAL());

            if (obj != null)
            {
                return obj.Hsncode_id;
            }
            return "";
        }


        public static List<Company> GetCount()
        {
            string q = "SELECT * FROM " + COMPANY.COMPANY_TBL;

            List<Company> list = new List<Company>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Company obj = new Company()
                    {
                        Company_id = redr[COMPANY.COMPANY_ID].ToString(),
                        Company_name = redr[COMPANY.COMPANY_NAME].ToString()
                    };
                    list.Add(obj);
                }
                redr.Close();
            }
            return list;
        }

    }//cls
}//ns
