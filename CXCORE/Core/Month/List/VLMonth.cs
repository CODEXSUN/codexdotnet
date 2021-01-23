// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 15-10-2019 10:05:59 AM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LMonth : CxControl 
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
                         LoadData(CMonth_exten.NotActive(new DAL())); 
                     } 
                     else 
                     { 
                         LoadData(CMonth_exten.Active(new DAL())); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CMonth_exten.NotActive(new DAL())); 
                     } 
                     else 
                     { 
                         LoadData(CMonth_exten.Active(new DAL())); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_month_name.Text != "") 
                     { 
                     List<Month> list = new List<Month> 
                     { 
                     CMonth_exten.SearchName(txt_month_name.Text, new DAL()) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CMonth_exten.Active(new DAL())); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CMonth_exten.Active(new DAL())); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Month> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[MONTH.MONTH_ID].Value = list[r].Month_id; 
                 row.Cells[MONTH.MONTH_NAME].Value = list[r].Month_name; 
                 row.Cells[MONTH.MONTH_STARTS].Value = ConvertTO.Date2S(list[r].Month_starts); 
                 row.Cells[MONTH.MONTH_ENDS].Value = ConvertTO.Date2S(list[r].Month_ends); 
                 row.Cells[MONTH.NOTES].Value = list[r].Notes; 
                 row.Cells[MONTH.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[MONTH.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
