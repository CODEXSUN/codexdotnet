// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 08:38:56 PM

using System; 
using System.Drawing; 
using System.Windows.Forms; 
using CXLIB; 
 
namespace CXERP 
{ 
    public partial class LArticle
    { 

         #region[Init Grid]

         private void InitGrid()
         {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Article_Id = new DataGridViewTextBoxColumn();
            col_Article_Id.Name = ARTICLE.ARTICLE_ID;
            col_Article_Id.HeaderText = "ARTICLE_ID ";
            col_Article_Id.Visible = false; 
            col_Article_Id.Width = 100;
            col_Article_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Article_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Article_Id );

            DataGridViewTextBoxColumn col_Po_id = new DataGridViewTextBoxColumn();
            col_Po_id.Name = ARTICLE.PO_ID;
            col_Po_id.HeaderText = "PO NO";
            //col_Po_id.Visible = false; 
            col_Po_id.Width = 100;
            col_Po_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Po_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Po_id);

            DataGridViewTextBoxColumn col_Article_no = new DataGridViewTextBoxColumn();
            col_Article_no.Name = ARTICLE.ARTICLE_NO;
            col_Article_no.HeaderText = "ARTICLE NO";
            //col_Article_no.Visible = false; 
            col_Article_no.Width = 162;
            col_Article_no.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Article_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Article_no);

            DataGridViewTextBoxColumn col_Product_id = new DataGridViewTextBoxColumn();
            col_Product_id.Name = ARTICLE.PRODUCT_ID;
            col_Product_id.HeaderText = "DESCRIBTION";
            //col_Product_id.Visible = false; 
            col_Product_id.Width = 175;
            col_Product_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Product_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Product_id);

            DataGridViewTextBoxColumn col_Hsncode_id = new DataGridViewTextBoxColumn();
            col_Hsncode_id.Name = ARTICLE.HSNCODE_ID;
            col_Hsncode_id.HeaderText = "HSN CODE";
            //col_Hsncode_id.Visible = false; 
            col_Hsncode_id.Width = 100;
            col_Hsncode_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Hsncode_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Hsncode_id);

            DataGridViewTextBoxColumn col_Size_id = new DataGridViewTextBoxColumn();
            col_Size_id.Name = ARTICLE.SIZES_ID;
            col_Size_id.HeaderText = "SIZES";
            //col_Size_id.Visible = false; 
            col_Size_id.Width = 100;
            col_Size_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Size_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Size_id);

            DataGridViewTextBoxColumn col_Colour_id = new DataGridViewTextBoxColumn();
            col_Colour_id.Name = ARTICLE.COLOURS_ID;
            col_Colour_id.HeaderText = "COLOURS";
            //col_Colour_id.Visible = false; 
            col_Colour_id.Width = 100;
            col_Colour_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Colour_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Colour_id);

            DataGridViewTextBoxColumn col_Qty = new DataGridViewTextBoxColumn();
            col_Qty.Name = ARTICLE.QTY;
            col_Qty.HeaderText = "QTY";
            //col_Qty.Visible = false; 
            col_Qty.Width = 100;
            col_Qty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Qty);

            DataGridViewTextBoxColumn col_Price = new DataGridViewTextBoxColumn();
            col_Price.Name = ARTICLE.PRICE;
            col_Price.HeaderText = "PRICE";
            //col_Price.Visible = false; 
            col_Price.Width = 100;
            col_Price.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Price);

            DataGridViewTextBoxColumn col_Barcode = new DataGridViewTextBoxColumn();
            col_Barcode.Name = ARTICLE.BARCODE;
            col_Barcode.HeaderText = "BARCODE";
            //col_Barcode.Visible = false; 
            col_Barcode.Width = 100;
            col_Barcode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Barcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Barcode);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = ARTICLE.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false; 
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes );

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = ARTICLE.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false; 
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id );

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = ARTICLE.USER_ID;
            col_User_Id.HeaderText = "ENTRY BY";
            //col_User_Id.Visible = false; 
            col_User_Id.Width = 120;
            col_User_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_User_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_User_Id );

            DataGridViewTextBoxColumn colFiller = new DataGridViewTextBoxColumn();
            colFiller.Name = "FILLER";
            colFiller.HeaderText = "";
            colFiller.ReadOnly = true;
            colFiller.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            colFiller.SortMode = DataGridViewColumnSortMode.NotSortable;
            colFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            listgrid.Columns.Add(colFiller);
}

            #endregion[Init Grid]

         #region[Grid Action]

         void Listgrid_RowAction(object sender, EventArgs e)
         {
             if (listgrid.SelectedRow == null)
             {
                 return;
             }
             if (farticle == null)
             {
                 farticle = new FArticle();
             }
             BuildForm();
             string pkValue = GetSelectedPkValue();
             if (pkValue != null)
             {
                 farticle.SetAction(BtnEvent.Open, pkValue);
             }
         }

         #endregion[Grid Action]

         #region[Enter Event]

         private void Txt_articletype_Enter(object sender, EventArgs e)
         {
             Change_infocus();
             lbl_article_name.BackColor = Theme.lbl_EnterBackColor;
             lbl_article_name.BorderColor = Theme.lbl_EnterBorderColor;
             lbl_article_name.ForeColor = Theme.lbl_EnterForeColor;
         }
         private void Change_infocus()
         {
             lbl_article_name.BackColor = Theme.lbl_BackColor;
             lbl_article_name.BorderColor = Theme.lbl_BorderColor;
             lbl_article_name.ForeColor = Theme.lbl_ForeColor;
         }

         #endregion[Enter Event]

         #region[Build Form]

         private void BuildForm()
         {
             if (farticle == null)
             {
                 farticle = new FArticle();
             }
             farticle.FArticle_NeedToRefresh += VArticle_NeedToRefresh;
             Parent.Controls.Add(farticle);
             farticle.Dock = DockStyle.Fill;
             farticle.Show();
             farticle.BringToFront();
             
         }

         #endregion[Build Form]

         #region[Checkbox Event] 

                private void Chk_notactive_CheckedChanged(object sender, EventArgs e) 
                { 
                    List_Option(ListOption.notactive); 
                } 

         #endregion[Checkbox Event] 

         #region[Btn Event] 

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        private void Btn_new_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
                farticle.SetAction(BtnEvent.New, null); 
                farticle.SetFocus(); 
        } 

        private void Btn_edit_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                farticle.SetAction(BtnEvent.Edit, pkValue); 
                farticle.SetFocus(); 
            } 
        } 

        private void Btn_delete_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                farticle.SetAction(BtnEvent.Delete, pkValue); 
                farticle.SetFocus(); 
            } 
        } 

        private void Btn_print_Click(object sender, EventArgs e) 
        { 
            BuildForm(); 
            string pkValue = GetSelectedPkValue(); 
            if (pkValue != null) 
            { 
                farticle.SetAction(BtnEvent.Print, pkValue); 
                farticle.SetFocus(); 
            } 
        } 

        private void Btn_close_Click(object sender, EventArgs e) 
        { 
            Hide(); 
            RaiseEvent_NeedToRefresh(); 
        } 

        private void Btn_search_Click(object sender, EventArgs e)
        {
            List_Option(ListOption.Search);
        }

         #endregion[Btn Event] 

         #region[lookup] 

         public void Article_lookup()
         {
             txt_article_no.LookupColNames = new string[] { ARTICLE.PO_ID };
            txt_article_no.LookupUpdate += txt_article_LookupUpdate;
            txt_article_no.AllowNewEntry = true;
            txt_article_no.NewEntryNeeded += txt_article_NewEntryNeeded;
         }
         void txt_article_LookupUpdate(object sender, EventArgs e)
         {
            txt_article_no.LookupList = CArticle_exten.GetforLookup();
         }
         private FArticle fsarticle = null;
         void txt_article_NewEntryNeeded(object sender, string pValue)
         {
             if (fsarticle == null)
             {
                 fsarticle = new FArticle();
             }
             Parent.Controls.Add(fsarticle);
             fsarticle.Dock = DockStyle.Fill;
             fsarticle.Show();
             fsarticle.BringToFront();
             fsarticle.Focus();
             
             fsarticle.SetAction(BtnEvent.New, null);
             fsarticle.SetFocus();
         }

         #endregion[lookup] 

         #region[Get selected pk value]

         private string GetSelectedPkValue()
         {
             DataGridViewRow vSelRow = null;
             if (listgrid.SelectedRows != null && listgrid.SelectedRows.Count != 0)
             {
                 vSelRow = listgrid.SelectedRows[0];
             }
             
             string selPkValue = null;
             if (vSelRow != null)
             {
                 selPkValue = vSelRow.Cells[ARTICLE.ARTICLE_ID].Value.ToString();
             }
             return selPkValue;
         }

         #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VArticle_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

}//cls
}//ns
