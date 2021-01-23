using CXCORE;
using CXLIB;

namespace CXSETUP
{
    public class City_Tbl
    {
        public City_Tbl(string database)
        {
            string q = USE.DB(database);

            q += CREATE.TABLE(CITY.CITY_TBL);
            q += Fields.Primary(CITY.CITY_ID);
            q += Fields.Unique(CITY.CITY_NAME);
            q += Fields.Notes();
            q += Fields.Active();
            new DAL().Execute(q);
        }
    }
}
