using CXCORE;
using CXLIB;

namespace CXSETUP
{
    public class Country_Tbl
    {
        public Country_Tbl(string database)
        {
            string q = USE.DB(database);

            q += CREATE.TABLE(COUNTRY.COUNTRY_TBL);
            q += Fields.Primary(COUNTRY.COUNTRY_ID);
            q += Fields.Unique(COUNTRY.COUNTRY_NAME);
            q += Fields.Notes();
            q += Fields.Active();
            new DAL().Execute(q);
        }
    }
}
