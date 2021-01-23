// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2020 07.29.30 PM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace AXCODE 
{ 
    public partial class LNamespaces : UserControl 
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
                         LoadData(CNamespaces_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CNamespaces_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CNamespaces_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CNamespaces_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_namespaces_name.Text != "") 
                     { 
                     List<Namespaces> list = new List<Namespaces> 
                     { 
                     CNamespaces_exten.SearchName(txt_namespaces_name.Text) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CNamespaces_exten.Active()); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CNamespaces_exten.Active()); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Namespaces> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[NAMESPACES.NAMESPACES_ID].Value = list[r].Namespaces_id; 
                 row.Cells[NAMESPACES.NAMESPACES_NAME].Value = list[r].Namespaces_name; 
                 row.Cells[NAMESPACES.NOTES].Value = list[r].Notes; 
                 row.Cells[NAMESPACES.ACTIVE_ID].Value = list[r].Active_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
