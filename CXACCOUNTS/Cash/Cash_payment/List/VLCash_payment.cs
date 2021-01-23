// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 06:41:07 AM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXACCOUNTS 
{ 
    public partial class LCash_payment 
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
                         LoadData(CCash_payment_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CCash_payment_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CCash_payment_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CCash_payment_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_order_ref.Text != "") 
                     { 
                     List<Cash_payment> list = new List<Cash_payment> 
                     { 
                     CCash_payment_exten.SearchName(txt_order_ref.Text) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CCash_payment_exten.Active()); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CCash_payment_exten.Active()); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Cash_payment> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[CASH_PAYMENT.CASH_PAYMENT_ID].Value = list[r].Cash_payment_id; 
                 row.Cells[CASH_PAYMENT.ORDER_ID].Value = list[r].Order_id; 
                 row.Cells[CASH_PAYMENT.PAYMENT_DATE].Value = ConvertTO.Date2S(list[r].Payment_date); 
                 row.Cells[CASH_PAYMENT.LEDGER_ID].Value = list[r].Ledger_id; 
                 row.Cells[CASH_PAYMENT.PURPOSE].Value = list[r].Purpose; 
                 row.Cells[CASH_PAYMENT.PARTY_ID].Value = list[r].Party_id; 
                 row.Cells[CASH_PAYMENT.PAYMENT_AMOUNT].Value = list[r].Payment_amount; 
                 row.Cells[CASH_PAYMENT.NOTES].Value = list[r].Notes; 
                 row.Cells[CASH_PAYMENT.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[CASH_PAYMENT.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
