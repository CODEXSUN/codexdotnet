// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:33 PM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LCity 
    { 
        #region[list Option] 
  
         public void ListRefresh() 
         { 
             List_Option(fAction); 
         } 
         
         private ListOption fAction = ListOption.active; 
         public void List_Option(ListOption pAction) 
         { 
             fAction = pAction; 
             
             switch (fAction) 
             { 
                 case ListOption.active: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CCity_exten.NotActive(new DAL())); 
                     } 
                     else 
                     { 
                         LoadData(CCity_exten.Active(new DAL())); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CCity_exten.NotActive(new DAL())); 
                     } 
                     else 
                     { 
                         LoadData(CCity_exten.Active(new DAL())); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_city_name.Text != "") 
                     { 
                     List<City> list = new List<City> 
                     { 
                     CCity_exten.SearchName(txt_city_name.Text, new DAL()) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CCity_exten.Active(new DAL())); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CCity_exten.Active(new DAL())); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<City> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[CITY.CITY_ID].Value = list[r].City_id; 
                 row.Cells[CITY.CITY_NAME].Value = list[r].City_name; 
                 row.Cells[CITY.NOTES].Value = list[r].Notes; 
                 row.Cells[CITY.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[CITY.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
