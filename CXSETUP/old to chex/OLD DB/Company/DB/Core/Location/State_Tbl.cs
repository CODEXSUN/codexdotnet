using CXCORE;
using CXLIB;

namespace CXSETUP
{
    public class State_Tbl
    {
        public State_Tbl(string database)
        {
            string q = USE.DB(database);

            q += CREATE.TABLE(STATE.STATE_TBL);
            q += Fields.Primary(STATE.STATE_ID);
            q += Fields.Unique(STATE.STATE_NAME);
            q += Fields.Notes();
            q += Fields.Active();
            new DAL().Execute(q);
        }
    }
}
