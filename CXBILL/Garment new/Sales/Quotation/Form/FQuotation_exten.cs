// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:58 PM
// last update : 17-08-2017


using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;
using CXCORE;

namespace CXBILL
{
    public partial class FQuotation 
    {

        #region[Grid Event]

        void Editgrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcTotals();
        }

        void Editgrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue + "" == "")
            {
                return;
            }
            string vColName = editgrid.Columns[e.ColumnIndex].Name;
            switch (vColName)
            {
                case QUOTATIONITEMS.QTY:
                    decimal newDecimal;
                    if (decimal.TryParse(e.FormattedValue.ToString(), out newDecimal) == false || newDecimal < 0)
                    {
                        MessageBox.Show(this.FindForm(), "The value must be an number.", "Number Check...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        editgrid.CancelEdit();
                        e.Cancel = true;
                    }
                    break;
            }
        }

        void Editgrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string vColName = editgrid.Columns[e.ColumnIndex].Name;
            if (vColName != Core.SLNO && editgrid[Core.SLNO, e.RowIndex].Value + "" != "*")
            {
                for (int r = 0; r < editgrid.RowCount; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];
                    row.Cells[Core.SLNO].Value = " " + (r + 1) + "";
                    CalcTotals();
                }
            }
            switch (vColName)
            {
                case QUOTATIONITEMS.QTY:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
                case QUOTATIONITEMS.PRICE:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
            }

        }

        void Editgrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (editgrid.Focused == false)
            {
                return;
            }
            if (editgrid.ReadOnly == true)
            {
                return;
            }
            if (editgrid.CurrentCell != null)
            {
                lookupRow = editgrid.CurrentCell.RowIndex;
                lookupCol = editgrid.CurrentCell.ColumnIndex;
                lookupColName = editgrid.Columns[lookupCol].Name;

                switch (lookupColName)
                {

                    case QUOTATIONITEMS.PRODUCT_ID:
                        ShowLookupForm();
                        break;
                    case QUOTATIONITEMS.SIZES_ID:
                        ShowLookupForm();
                        break;
                }
            }
        }

        #endregion[Grid Event]

        #region[Calc Total]

        private void CalcRow(int pRowIndex)
        {

            decimal vPrice = ConvertTO.Decimal(editgrid[QUOTATIONITEMS.PRICE, pRowIndex].Value);

            decimal vQty = ConvertTO.Decimal(editgrid[QUOTATIONITEMS.QTY, pRowIndex].Value);

            decimal vtaxableAmount = vQty * vPrice;

            editgrid[QUOTATIONITEMS.TAXABLEAMOUNT, pRowIndex].Value = (decimal.Round(vtaxableAmount, 2)).ToString();
        }

        private decimal vTotTaxable = 0M;
        private decimal vTotCgst = 0M;
        private decimal vTotSgst = 0M;
        private decimal vTotIgst = 0M;
        private decimal vTotQty = 0M;
        decimal vRoundoff = 0M;

        private void CalcTotals()
        {
            vTotTaxable = 0M;
            vTotCgst = 0M;
            vTotSgst = 0M;
            vTotIgst = 0M;
            vTotQty = 0M;
            vRoundoff = 0M;

            for (int r = 0; r <= editgrid.Rows.Count - 1; r++)
            {
                vTotQty += ConvertTO.Decimal(editgrid[QUOTATIONITEMS.QTY, r].Value);

                vTotTaxable += ConvertTO.Decimal(editgrid[QUOTATIONITEMS.TAXABLEAMOUNT, r].Value);

            }

            decimal vSub_total = vTotTaxable + vTotCgst + vTotSgst + vTotIgst;

            decimal VAdditional = 0M;
            decimal vNettotal = 0M;


            if (txt_additional.Text.Contains("-"))
            {
                VAdditional = Convert.ToDecimal("0" + txt_additional.Text.Replace("-", ""));

                vNettotal = vSub_total - VAdditional;
            }
            else
            {
                VAdditional = Convert.ToDecimal("0" + txt_additional.Text);

                vNettotal = vSub_total + VAdditional;
            }

            decimal rounded = Math.Round(vNettotal);

            if (rounded > vNettotal)
            {
                vRoundoff = rounded - vNettotal;
            }
            else
            {
                vRoundoff = vNettotal - rounded;
            }

            gsttotal = (vTotCgst + vTotSgst + vTotIgst).ToString();

            txt_grandtotal.Text = ConvertTO.Decimal2d(rounded.ToString());

            totalQty = vTotQty + "";
        }

        private string gsttotal;
        private string totalQty;

        void RefreshRowtotal()
        {
            for (int r = 0; r < editgrid.RowCount; r++)
            {
                CalcRow(r);
            }
            CalcTotals();
        }

        #endregion[Calc Total]

        #region[Look up]

        private int lookupRow;
        private int lookupCol;
        private string lookupColName;
        private LookupForm frmLookup;
        public void ShowLookupForm()
        {
            FrmLookup_LookupHide(null, null);

            frmLookup = new LookupForm();

            switch (lookupColName)
            {
                case QUOTATIONITEMS.PRODUCT_ID:
                    {
                        frmLookup.LookupColNames = new string[] { PRODUCT.PRODUCT_NAME };
                        frmLookup.SelectedPkValue = editgrid[QUOTATIONITEMS.PRODUCT_ID, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        if (txt_party_id.Text != "")
                        {
                           
                                                frmLookup.LookupList = CProduct_exten.GetforLookup(new DAL());
                                                frmLookup.LoadLookupList();
                        }
                    }
                    break;

                case QUOTATIONITEMS.SIZES_ID:

                    frmLookup.LookupColNames = new string[] { SIZES.SIZES_NAME};
                    frmLookup.SelectedPkValue = editgrid[QUOTATIONITEMS.SIZES_ID, lookupRow].Value;
                    frmLookup.AllowNewEntry = true;
                    frmLookup.AllowEmptySelection = true;
                    frmLookup.LookupList = CSizes_exten.GetforLookup(new DAL());
                    frmLookup.LoadLookupList();

                    break;

                default:
                    throw new Exception("'" + lookupColName + "' Not Found");
            }
            frmLookup.LookupSelected += new EventHandler(FrmLookup_LookupSelected);
            frmLookup.AfterSelection += new EventHandler(FrmLookup_AfterSelection);
            frmLookup.LookupHide += new EventHandler(FrmLookup_LookupHide);
            frmLookup.NewEntryNeeded += new LookupForm.NewEntryHandler(FrmLookup_NewEntryNeeded);
            frmLookup.Owner = this.FindForm();
            //////////
            frmLookup.Show();
            //////////
            int vWidth = frmLookup.GetAutoWidth();
            int vCellWidth = editgrid.Columns[lookupColName].Width;
            if (vWidth < vCellWidth) vWidth = vCellWidth;
            frmLookup.AutoFillLastColumn();

            int vHeight = frmLookup.GetAutoHeight();

            Rectangle screenRect = Global.GetScreenRect(editgrid);
            frmLookup.Bounds = Global.GetSnapRect(screenRect, vWidth, vHeight);
        }

        void FrmLookup_LookupSelected(object sender, EventArgs e)
        {
            System.Data.DataRow vEntity = frmLookup.SelectedEntity;

            switch (lookupColName)
            {
                
                case QUOTATIONITEMS.PRODUCT_ID:
                    if (vEntity == null)
                    {
                        editgrid[QUOTATIONITEMS.PRODUCT_ID, lookupRow].Value = "";
                    }
                    else
                    {

                        editgrid[QUOTATIONITEMS.PRODUCT_ID, lookupRow].Value = Checks.RemoveEscape(vEntity[PRODUCT.PRODUCT_NAME].ToString());
                        editgrid.CurrentCell = editgrid[QUOTATIONITEMS.PRODUCT_ID, lookupRow];

                    }
                    break;

                case QUOTATIONITEMS.SIZES_ID:
                    if (vEntity == null)
                    {
                        editgrid[QUOTATIONITEMS.SIZES_ID, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[QUOTATIONITEMS.SIZES_ID, lookupRow].Value = vEntity[SIZES.SIZES_NAME];
                    }
                    break;
            }
        }

        void FrmLookup_AfterSelection(object sender, EventArgs e)
        {
            editgrid.FocusNextCell();
        }
        void FrmLookup_LookupHide(object sender, EventArgs e)
        {
            Application.DoEvents();
            Application.DoEvents();
            if (frmLookup != null)
            {
                frmLookup.Dispose();
                frmLookup = null;
            }
        }

        void FrmLookup_NewEntryNeeded(object sender, string pValue)
        {
            switch (lookupColName)
            {
                case QUOTATIONITEMS.PRODUCT_ID:
                    Product_NewEntry(pValue);
                    break;
                case QUOTATIONITEMS.SIZES_ID:
                    Sizes_NewEntry(pValue);
                    break;
            }
        }

        #endregion[Look up]

        #region [New Entry]

        #region [Product]

        private FProduct xproduct = null;
        void Product_NewEntry(string pValue)
        {
            if (xproduct == null)
            {
                xproduct = new FProduct();
                xproduct.FProduct_NeedToRefresh += Xproduct_refresh;
            }
            this.Parent.Controls.Add(xproduct);
            xproduct.Dock = DockStyle.Fill;
            xproduct.Show();
            xproduct.BringToFront();
            xproduct.Focus();
            xproduct.SetAction(BtnEvent.New, null);
            xproduct.SetFocus();
            xproduct.setname(pValue);
        }
        private void Xproduct_refresh(object sender, EventArgs e)
        {
            editgrid[QUOTATIONITEMS.PRODUCT_ID, lookupRow].Value = xproduct.GetName();
            editgrid.Focus();
            editgrid.CurrentCell = editgrid[QUOTATIONITEMS.SIZES_ID, lookupRow];

        }

        #endregion [Product]

        #region [Sizes]

        private FSizes xsizes = null;
        void Sizes_NewEntry(string pValue)
        {
            if (xsizes == null)
            {
                xsizes = new FSizes();
                xsizes.FSizes_NeedToRefresh += Xsizes_refresh;
            }
            this.Parent.Controls.Add(xsizes);
            xsizes.Dock = DockStyle.Fill;
            xsizes.Show();
            xsizes.BringToFront();
            xsizes.Focus();
            xsizes.SetAction(BtnEvent.New, null);
            xsizes.SetFocus();
            xsizes.setname(pValue);
        }
        private void Xsizes_refresh(object sender, EventArgs e)
        {
            editgrid[QUOTATIONITEMS.SIZES_ID, lookupRow].Value = xsizes.GetName();
            editgrid.Focus();
            editgrid.CurrentCell = editgrid[QUOTATIONITEMS.QTY, lookupRow];

        }

        #endregion [Product]

        #endregion [New Entry]

    }//cls
}//ns
