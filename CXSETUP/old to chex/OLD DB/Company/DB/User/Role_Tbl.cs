using CXCORE;
using CXLIB;

namespace CXSETUP
{
    public class Role_Tbl
    {

        public Role_Tbl(string database)
        {
            string q = USE.DB(database);

            q += CREATE.TABLE(ROLE.ROLE_TBL);
            q += Fields.Primary(ROLE.ROLE_ID);
            q += Fields.Unique(ROLE.ROLE_NAME);
            q += Fields.Notes();
            q += Fields.Active();
            new DAL().Execute(q);
        }

    }
}
