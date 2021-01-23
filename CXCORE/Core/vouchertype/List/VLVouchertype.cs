// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:47:54 PM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXCORE 
{ 
    public partial class LVouchertype : UserControl 
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
                         LoadData(CVouchertype_exten.NotActive(new DAL())); 
                     } 
                     else 
                     { 
                         LoadData(CVouchertype_exten.Active(new DAL())); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CVouchertype_exten.NotActive(new DAL())); 
                     } 
                     else 
                     { 
                         LoadData(CVouchertype_exten.Active(new DAL())); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_vouchertype_name.Text != "") 
                     { 
                     List<Vouchertype> list = new List<Vouchertype> 
                     { 
                     CVouchertype_exten.SearchName(txt_vouchertype_name.Text, new DAL()) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CVouchertype_exten.Active(new DAL())); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CVouchertype_exten.Active(new DAL())); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Vouchertype> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[VOUCHERTYPE.VOUCHERTYPE_ID].Value = list[r].Vouchertype_id; 
                 row.Cells[VOUCHERTYPE.VOUCHERTYPE_NAME].Value = list[r].Vouchertype_name; 
                 row.Cells[VOUCHERTYPE.METHOD_ID].Value = list[r].Method_id; 
                 row.Cells[VOUCHERTYPE.NOTES].Value = list[r].Notes; 
                 row.Cells[VOUCHERTYPE.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[VOUCHERTYPE.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
