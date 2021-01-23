// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:38 PM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXACCOUNTS 
{ 
    public partial class LCash_in_hand
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
                         LoadData(CCash_in_hand_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CCash_in_hand_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CCash_in_hand_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CCash_in_hand_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_cash_in_hand_id.Text != "") 
                     { 
                     List<Cash_in_hand> list = new List<Cash_in_hand> 
                     { 
                     CCash_in_hand_exten.SearchName(txt_cash_in_hand_id.Text) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CCash_in_hand_exten.Active()); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CCash_in_hand_exten.Active()); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Cash_in_hand> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[CASH_IN_HAND.CASH_IN_HAND_ID].Value = list[r].Cash_in_hand_id; 
                 row.Cells[CASH_IN_HAND.ENTRY_DATE].Value = list[r].Entry_date; 
                 row.Cells[CASH_IN_HAND.CASH_RECEIPT_ID].Value = list[r].Cash_receipt_id; 
                 row.Cells[CASH_IN_HAND.CASH_PAYMENT_ID].Value = list[r].Cash_payment_id; 
                 row.Cells[CASH_IN_HAND.RECEIPT_AMOUNT].Value = list[r].Receipt_amount; 
                 row.Cells[CASH_IN_HAND.PAYMENT_AMOUNT].Value = list[r].Payment_amount; 
                 row.Cells[CASH_IN_HAND.BALANCE_AMOUNT].Value = list[r].Balance_amount; 
                 row.Cells[CASH_IN_HAND.NOTES].Value = list[r].Notes; 
                 row.Cells[CASH_IN_HAND.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[CASH_IN_HAND.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
