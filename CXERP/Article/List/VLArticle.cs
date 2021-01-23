// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 09:42:04 PM

using System.Windows.Forms; 
using System.Collections.Generic; 
using CXLIB; 
 
namespace CXERP 
{ 
    public partial class LArticle
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
                         LoadData(CArticle_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CArticle_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.notactive: 
  
                     if (chk_notactive.Checked == true) 
                     { 
                         LoadData(CArticle_exten.NotActive()); 
                     } 
                     else 
                     { 
                         LoadData(CArticle_exten.Active()); 
                     } 
  
                     break; 
  
                 case ListOption.Search: 
                     if (txt_article_no.Text != "") 
                     { 
                     List<Article> list = new List<Article> 
                     { 
                     CArticle_exten.SearchName(txt_article_no.Text) 
                     }; 
                     LoadData(list); 
                     } 
                     else 
                     { 
                         LoadData(CArticle_exten.Active()); 
                     } 
                     break; 
  
                 default: 
                     LoadData(CArticle_exten.Active()); 
                     break; 
             } 
         } 
  
         #endregion[list Option] 
  
         #region[Load Data] 
  
         public void LoadData(List<Article> list) 
         { 
             listgrid.RowCount = 0; 
             listgrid.RowCount = list.Count; 
             for (int r = 0; r < list.Count; r++) 
             { 
                 DataGridViewRow row = listgrid.Rows[r]; 
                 
                 row.Cells[ARTICLE.ARTICLE_ID].Value = list[r].Article_id; 
                 row.Cells[ARTICLE.PO_ID].Value = list[r].Po_id; 
                 row.Cells[ARTICLE.ARTICLE_NO].Value = list[r].Article_no; 
                 row.Cells[ARTICLE.PRODUCT_ID].Value = list[r].Product_id; 
                 row.Cells[ARTICLE.HSNCODE_ID].Value = list[r].Hsncode_id; 
                 row.Cells[ARTICLE.SIZES_ID].Value = list[r].Sizes_id; 
                 row.Cells[ARTICLE.COLOURS_ID].Value = list[r].Colours_id; 
                 row.Cells[ARTICLE.QTY].Value = list[r].Qty; 
                 row.Cells[ARTICLE.PRICE].Value = list[r].Price; 
                 row.Cells[ARTICLE.BARCODE].Value = list[r].Barcode; 
                 row.Cells[ARTICLE.NOTES].Value = list[r].Notes; 
                 row.Cells[ARTICLE.ACTIVE_ID].Value = list[r].Active_id; 
                 row.Cells[ARTICLE.USER_ID].Value = list[r].User_id; 
             } 
         } 
         
         #endregion[Load Data] 
 
 }//cls 
}//ns 
