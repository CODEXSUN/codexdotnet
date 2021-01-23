using CXCORE;
using CXLIB;

namespace CXSETUP
{
    public class Pincode_Tbl
    {
        public Pincode_Tbl(string database)
        {
            string q = USE.DB(database);

            q += CREATE.TABLE(PINCODE.PINCODE_TBL);
            q += Fields.Primary(PINCODE.PINCODE_ID);
            q += Fields.Unique(PINCODE.PINCODE_NAME);
            q += Fields.Notes();
            q += Fields.Active();
            new DAL().Execute(q);
        }
    }
}
