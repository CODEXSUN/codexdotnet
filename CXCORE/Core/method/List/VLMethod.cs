// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 08:21:03 PM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LMethod : UserControl 
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
                         LoadData(CMethod_exten.NotActive(new DAL())); 
                     } 
                     else 
                     { 
                         LoadData(CMethod_exten.Active(new DAL())); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CMethod_exten.NotActive(new DAL())); 
                     } 
                     else 
                     { 
                         LoadData(CMethod_exten.Active(new DAL())); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_method_name.Text != "") 
                     { 
                     List<Method> list = new List<Method> 
                     { 
                     CMethod_exten.SearchName(txt_method_name.Text, new DAL()) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CMethod_exten.Active(new DAL())); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CMethod_exten.Active(new DAL())); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Method> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[METHOD.METHOD_ID].Value = list[r].Method_id; 
                 row.Cells[METHOD.METHOD_NAME].Value = list[r].Method_name; 
                 row.Cells[METHOD.NOTES].Value = list[r].Notes; 
                 row.Cells[METHOD.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[METHOD.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
