// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 15-05-2019 06:44:13 PM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LOrdertype : UserControl 
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
                         LoadData(COrdertype_exten.NotActive(new DAL())); 
                     } 
                     else 
                     { 
                         LoadData(COrdertype_exten.Active(new DAL())); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(COrdertype_exten.NotActive(new DAL())); 
                     } 
                     else 
                     { 
                         LoadData(COrdertype_exten.Active(new DAL())); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_ordertype_name.Text != "") 
                     { 
                     List<Ordertype> list = new List<Ordertype> 
                     { 
                     COrdertype_exten.SearchName(txt_ordertype_name.Text, new DAL()) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(COrdertype_exten.Active(new DAL())); 
                     } 
                     break; 
  
                 default: 
                     LoadData(COrdertype_exten.Active(new DAL())); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Ordertype> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[ORDERTYPE.ORDERTYPE_ID].Value = list[r].Ordertype_id; 
                 row.Cells[ORDERTYPE.ORDERTYPE_NAME].Value = list[r].Ordertype_name; 
                 row.Cells[ORDERTYPE.NOTES].Value = list[r].Notes; 
                 row.Cells[ORDERTYPE.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[ORDERTYPE.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
