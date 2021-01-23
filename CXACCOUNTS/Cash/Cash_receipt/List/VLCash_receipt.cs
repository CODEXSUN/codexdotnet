// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:47 PM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXACCOUNTS 
{ 
    public partial class LCash_receipt 
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
                         LoadData(CCash_receipt_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CCash_receipt_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CCash_receipt_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CCash_receipt_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_receipt_date.Text != "") 
                     { 
                     List<Cash_receipt> list = new List<Cash_receipt> 
                     { 
                     CCash_receipt_exten.SearchName(txt_receipt_date.Text) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CCash_receipt_exten.Active()); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CCash_receipt_exten.Active()); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Cash_receipt> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[CASH_RECEIPT.CASH_RECEIPT_ID].Value = list[r].Cash_receipt_id; 
                 row.Cells[CASH_RECEIPT.RECEIPT_DATE].Value = ConvertTO.Date2S(list[r].Receipt_date); 
                 row.Cells[CASH_RECEIPT.PARTY_ID].Value = list[r].Party_id; 
                 row.Cells[CASH_RECEIPT.PURPOSE].Value = list[r].Purpose; 
                 row.Cells[CASH_RECEIPT.RECEIPT_AMOUNT].Value = list[r].Receipt_amount; 
                 row.Cells[CASH_RECEIPT.NOTES].Value = list[r].Notes; 
                 row.Cells[CASH_RECEIPT.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[CASH_RECEIPT.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
