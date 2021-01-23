// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 22-03-2019 12:58:19 PM

using System.Data;
using CXLIB;

namespace CXCORE
{
    public class CDefaultcompany_exten
    {
        #region[Entity Data]

        private static Defaultcompany EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))

            {
                while (redr.Read() == true)
                {
                    Defaultcompany obj = new Defaultcompany()
                    {
                        Defaultcompany_id = redr[DEFAULTCOMPANY.DEFAULTCOMPANY_ID].ToString(),
                        Company_id = redr[DEFAULTCOMPANY.COMPANY_ID].ToString(),
                        Acy_id = redr[DEFAULTCOMPANY.ACY_ID].ToString()
                    };

                    return obj;
                }

                redr.Close();
                return new Defaultcompany();

            }
        }

        #endregion[Entity Data]

        #region[Primary Key]

        public static Defaultcompany PKId(string v, DAL DAL)
        {
            string q = " SELECT * FROM " + DEFAULTCOMPANY.DEFAULTCOMPANY_TBL + "\r\n";
            q += " WHERE " + DEFAULTCOMPANY.DEFAULTCOMPANY_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

    }//cls
}//ns
