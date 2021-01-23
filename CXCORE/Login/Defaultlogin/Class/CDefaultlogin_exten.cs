// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 22-03-2019 12:58:24 PM

using System.Data;
using CXLIB;

namespace CXCORE
{
    public class CDefaultlogin_exten
    {
        #region[Entity Data]

        private static Defaultlogin EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Defaultlogin obj = new Defaultlogin()
                    {
                        Defaultlogin_id = redr[DEFAULTLOGIN.DEFAULTLOGIN_ID].ToString(),
                        Defaultlogin_name = redr[DEFAULTLOGIN.DEFAULTLOGIN_NAME].ToString(),
                        Default_password = redr[DEFAULTLOGIN.DEFAULT_PASSWORD].ToString(),
                        Createon = redr[DEFAULTLOGIN.CREATEON].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Defaultlogin();
            }
        }

        #endregion[Entity Data]

        #region[Primary Key]

        public static Defaultlogin PKId(string v, DAL DAL)
        {
            string q = " SELECT * FROM " + DEFAULTLOGIN.DEFAULTLOGIN_TBL + " \r\n";
            q += " WHERE " + DEFAULTLOGIN.DEFAULTLOGIN_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

    }//cls
}//ns
