// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 25-01-2021 10:14:36 AM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXERP 
{ 
    public partial class LPo
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
                         LoadData(CPo_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CPo_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CPo_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CPo_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_po_no.Text != "") 
                     { 
                     List<Po> list = new List<Po> 
                     { 
                     CPo_exten.SearchName(txt_po_no.Text) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CPo_exten.Active()); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CPo_exten.Active()); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Po> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[PO.PO_ID].Value = list[r].Po_id; 
                 row.Cells[PO.PO_NO].Value = list[r].Po_no; 
                 row.Cells[PO.PO_DATE].Value = ConvertTO.Date2S(list[r].Po_date); 
                 row.Cells[PO.DELIVERY_DATE].Value = ConvertTO.Date2S(list[r].Delivery_date); 
                 row.Cells[PO.NOTES].Value = list[r].Notes; 
                 row.Cells[PO.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[PO.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
