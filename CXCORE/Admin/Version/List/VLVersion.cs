// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 10:29:15 AM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LVersion
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
                         LoadData(CVersion_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CVersion_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CVersion_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CVersion_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_version_name.Text != "") 
                     { 
                     List<Version> list = new List<Version> 
                     { 
                     CVersion_exten.SearchName(txt_version_name.Text) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CVersion_exten.Active()); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CVersion_exten.Active()); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Version> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[VERSION.VERSION_ID].Value = list[r].Version_id; 
                 row.Cells[VERSION.VERSION_NAME].Value = list[r].Version_name; 
                 row.Cells[VERSION.CREATED_ON].Value = list[r].Created_on; 
                 row.Cells[VERSION.CHANGES].Value = list[r].Changes; 
                 row.Cells[VERSION.NOTES].Value = list[r].Notes; 
                 row.Cells[VERSION.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[VERSION.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
