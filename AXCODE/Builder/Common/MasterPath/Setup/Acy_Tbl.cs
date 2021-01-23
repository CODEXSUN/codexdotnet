// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 29-01-2019 09:51:18 AM

using CXLIB; 

namespace CXSETUP
{
    public class Acy
    {
        #region[Create Table]

        public Acy(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(ACY.ACY_TBL);
            q += Fields.Primary(ACY.ACY_ID);
            q += Fields.Unique_500(ACY.ACY_NAME); 
            q += Fields.VAR500(ACY.ACY_DESC); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(ACY.ACY_TBL);
            q += Fields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

    }//cls
}//ns
