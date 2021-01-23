// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 13-07-2020 08:01:31 AM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LShipping : UserControl 
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
                         LoadData(CShipping_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CShipping_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CShipping_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CShipping_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_shipping_name.Text != "") 
                     { 
                     List<Shipping> list = new List<Shipping> 
                     { 
                     CShipping_exten.SearchName(txt_shipping_name.Text) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CShipping_exten.Active()); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CShipping_exten.Active()); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Shipping> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[SHIPPING.SHIPPING_ID].Value = list[r].Shipping_id; 
                 row.Cells[SHIPPING.SHIPPING_NAME].Value = list[r].Shipping_name; 
                 row.Cells[SHIPPING.NOTES].Value = list[r].Notes; 
                 row.Cells[SHIPPING.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[SHIPPING.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
