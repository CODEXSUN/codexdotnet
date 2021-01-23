// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:23:39 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LProduct
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Product_Id = new DataGridViewTextBoxColumn();
            col_Product_Id.Name = PRODUCT.PRODUCT_ID;
            col_Product_Id.HeaderText = "PRODUCT_ID ";
            col_Product_Id.Visible = false;
            col_Product_Id.Width = 100;
            col_Product_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Product_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Product_Id);

            DataGridViewTextBoxColumn col_sn = new DataGridViewTextBoxColumn();
            col_sn.Name = "SN";
            col_sn.HeaderText = "";
            //col_sn.Visible = false; 
            col_sn.Width = 40;
            col_sn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_sn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_sn);

            DataGridViewTextBoxColumn col_Product_name = new DataGridViewTextBoxColumn();
            col_Product_name.Name = PRODUCT.PRODUCT_NAME;
            col_Product_name.HeaderText = "PRODUCT";
            //col_Product_name.Visible = false; 
            col_Product_name.Width = 500;
            col_Product_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Product_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Product_name);

            DataGridViewTextBoxColumn col_Producttype_id = new DataGridViewTextBoxColumn();
            col_Producttype_id.Name = PRODUCT.PRODUCTTYPE_ID;
            col_Producttype_id.HeaderText = "PRODUCT TYPE";
            //col_Producttype_id.Visible = false; 
            col_Producttype_id.Width = 188;
            col_Producttype_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Producttype_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Producttype_id);

            DataGridViewTextBoxColumn col_Hsncode_id = new DataGridViewTextBoxColumn();
            col_Hsncode_id.Name = PRODUCT.HSNCODE_ID;
            col_Hsncode_id.HeaderText = "HSN CODE";
            //col_Hsncode_id.Visible = false; 
            col_Hsncode_id.Width = 150;
            col_Hsncode_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Hsncode_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Hsncode_id);

            DataGridViewTextBoxColumn col_Unit_id = new DataGridViewTextBoxColumn();
            col_Unit_id.Name = PRODUCT.UNIT_ID;
            col_Unit_id.HeaderText = "UNIT";
            //col_Unit_id.Visible = false; 
            col_Unit_id.Width = 100;
            col_Unit_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Unit_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Unit_id);

            DataGridViewTextBoxColumn col_Purchase_price = new DataGridViewTextBoxColumn();
            col_Purchase_price.Name = PRODUCT.PURCHASE_PRICE;
            col_Purchase_price.HeaderText = "PURCHASE PRICE";
            //col_Purchase_price.Visible = false; 
            col_Purchase_price.Width = 212;
            col_Purchase_price.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Purchase_price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Purchase_price);

            DataGridViewTextBoxColumn col_Selling_price = new DataGridViewTextBoxColumn();
            col_Selling_price.Name = PRODUCT.SELLING_PRICE;
            col_Selling_price.HeaderText = "SELLING PRICE";
            //col_Selling_price.Visible = false; 
            col_Selling_price.Width = 200;
            col_Selling_price.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Selling_price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Selling_price);

            DataGridViewTextBoxColumn col_Sgst_percent = new DataGridViewTextBoxColumn();
            col_Sgst_percent.Name = PRODUCT.SGST_PERCENT;
            col_Sgst_percent.HeaderText = "SGST    %";
            //col_Sgst_percent.Visible = false; 
            col_Sgst_percent.Width = 150;
            col_Sgst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Sgst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Sgst_percent);

            DataGridViewTextBoxColumn col_Cgst_percent = new DataGridViewTextBoxColumn();
            col_Cgst_percent.Name = PRODUCT.CGST_PERCENT;
            col_Cgst_percent.HeaderText = "CGST    %";
            //col_Cgst_percent.Visible = false; 
            col_Cgst_percent.Width = 150;
            col_Cgst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Cgst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Cgst_percent);

            DataGridViewTextBoxColumn col_Igst_percent = new DataGridViewTextBoxColumn();
            col_Igst_percent.Name = PRODUCT.IGST_PERCENT;
            col_Igst_percent.HeaderText = "IGST     %";
            //col_Igst_percent.Visible = false; 
            col_Igst_percent.Width = 162;
            col_Igst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Igst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Igst_percent);

            DataGridViewTextBoxColumn col_Opening_stock = new DataGridViewTextBoxColumn();
            col_Opening_stock.Name = PRODUCT.OPENING_STOCK;
            col_Opening_stock.HeaderText = "OPENING STOCK";
            //col_Opening_stock.Visible = false; 
            col_Opening_stock.Width = 200;
            col_Opening_stock.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Opening_stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Opening_stock);

            DataGridViewTextBoxColumn col_Opening_price = new DataGridViewTextBoxColumn();
            col_Opening_price.Name = PRODUCT.OPENING_PRICE;
            col_Opening_price.HeaderText = "OPENING PRICE";
            //col_Opening_price.Visible = false; 
            col_Opening_price.Width = 200;
            col_Opening_price.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Opening_price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Opening_price);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = PRODUCT.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = PRODUCT.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = PRODUCT.USER_ID;
            col_User_Id.HeaderText = "ENTRY BY";
            //col_User_Id.Visible = false; 
            col_User_Id.Width = 120;
            col_User_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_User_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_User_Id);

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
            if (fproduct == null)
            {
                fproduct = new FProduct();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fproduct.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_producttype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_product_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_product_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_product_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_product_name.BackColor = Theme.lbl_BackColor;
            lbl_product_name.BorderColor = Theme.lbl_BorderColor;
            lbl_product_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fproduct == null)
            {
                fproduct = new FProduct();
            }
            fproduct.FProduct_NeedToRefresh += VProduct_NeedToRefresh;
            Parent.Controls.Add(fproduct);
            fproduct.Dock = DockStyle.Fill;
            fproduct.Show();
            fproduct.BringToFront();

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
            fproduct.SetAction(BtnEvent.New, null);
            fproduct.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fproduct.SetAction(BtnEvent.Edit, pkValue);
                fproduct.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fproduct.SetAction(BtnEvent.Delete, pkValue);
                fproduct.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fproduct.SetAction(BtnEvent.Print, pkValue);
                fproduct.SetFocus();
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

        public void Product_lookup()
        {
            txt_product_name.LookupColNames = new string[] { PRODUCT.PRODUCT_NAME };
            txt_product_name.LookupUpdate += txt_product_LookupUpdate;
            txt_product_name.AllowNewEntry = true;
            txt_product_name.NewEntryNeeded += txt_product_NewEntryNeeded;
        }
        void txt_product_LookupUpdate(object sender, EventArgs e)
        {
            txt_product_name.LookupList = CProduct_exten.GetforLookup(new DAL());
        }
        private FProduct fsproduct = null;
        void txt_product_NewEntryNeeded(object sender, string pValue)
        {
            if (fsproduct == null)
            {
                fsproduct = new FProduct();
            }
            Parent.Controls.Add(fsproduct);
            fsproduct.Dock = DockStyle.Fill;
            fsproduct.Show();
            fsproduct.BringToFront();
            fsproduct.Focus();

            fsproduct.SetAction(BtnEvent.New, null);
            fsproduct.SetFocus();
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
                selPkValue = vSelRow.Cells[PRODUCT.PRODUCT_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VProduct_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
