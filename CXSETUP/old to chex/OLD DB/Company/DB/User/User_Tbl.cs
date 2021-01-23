using CXCORE;
using CXLIB;

namespace CXSETUP
{
    public class User_Tbl
    {
        public User_Tbl(string database)
        {

            string q = USE.DB(database);

            q += CREATE.TABLE(USER.USER_TBL);
            q += Fields.Primary(USER.USER_ID);
            q += Fields.Unique(USER.USER_NAME);
            //q += Fields.VAR200(USER.PASSWORD);
            //q += Fields.VAR500(USER.EMAIL);
            //q += Fields.DateTime(USER.CREATEDON);
            //q += Fields.Foreign(USER.USER_TBL, USER.ROLE_ID);
            q += Fields.Notes();
            q += Fields.Active();

            new DAL().Execute(q);
        }
    }

}
