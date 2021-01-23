// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 07:48:01 AM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LAcy : UserControl 
    { 
        #region[list Option] 
  
         public void ListRefresh() 
         { 
             List_Option(fAction); 
         } 
         
         private ListOption fAction = ListOption.active; 
         public void List_Option(ListOption action) 
         { 
             fAction = action; 
             
             switch (fAction) 
             { 
                 case ListOption.active: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CAcy_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CAcy_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CAcy_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CAcy_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_acy_name.Text != "") 
                     { 
                     List<Acy> list = new List<Acy> 
                     { 
                     CAcy_exten.SearchName(txt_acy_name.Text) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CAcy_exten.Active()); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CAcy_exten.Active()); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Acy> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[ACY.ACY_ID].Value = list[r].Acy_id; 
                 row.Cells[ACY.ACY_NAME].Value = list[r].Acy_name; 
                 row.Cells[ACY.FROM_DATE].Value = list[r].From_date; 
                 row.Cells[ACY.TO_DATE].Value = list[r].To_date; 
                 row.Cells[ACY.NOTES].Value = list[r].Notes; 
                 row.Cells[ACY.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[ACY.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
