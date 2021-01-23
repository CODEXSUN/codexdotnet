// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 22-10-2018 10:45:00 AM

using CXBILL; 
using CXLIB; 
 
namespace CXSETUP 
{ 
    public class Acy_Tbl 
    { 

        #region[]

        public Invoice_Tbl(string database)
        {
            if (Check.Table("ACY_TBL", database) == false)
            {
                Insert(database);
            }
            else
            {
                Update(database);
            }
        }

        #endregion[]

        #region[Insert]

        public void Insert(string database) 
        { 
            string q = USE.DB(database); 

            q += CREATE.TABLE(ACY.ACY_TBL); 
            q += Fields.Primary(ACY.ACY_ID); 
            q += Fields.Unique(ACY.UNIQUENO); 
            q += Fields.Foreign(ACY.ACY_TBL, ACY.COMPANY_ID); 
            q += Fields.Foreign(ACY.ACY_TBL, ACY.DIV_ID); 
            q += Fields.Foreign(ACY.ACY_TBL, ACY.ACY_ID); 
            q += Fields.Notes(); 
            q += Fields.Active(); 
            q += Fields.User_id(ACY.ACY_TBL); 
            new DAL().Execute(q); 
        } 
        #endregion[Insert]

        #region[Update]

        public void Update(string database) 
        { 
            string q = USE.DB(database); 

            new DAL().Execute(q); 
        } 

        #endregion[Update]

    }//cls
}//ns
