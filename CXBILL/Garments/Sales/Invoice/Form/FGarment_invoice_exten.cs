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
    public partial class FGarment_invoice : UserControl
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
                case GARMENT_INVOICEITEMS.QTY:
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
                case GARMENT_INVOICEITEMS.QTY:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
                case GARMENT_INVOICEITEMS.PRICE:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
                case GARMENT_INVOICEITEMS.SGST_PERCENT:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
                case GARMENT_INVOICEITEMS.CGST_PERCENT:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
                case GARMENT_INVOICEITEMS.IGST_PERCENT:
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
                    case GARMENT_INVOICEITEMS.PRODUCT_ID:
                        ShowLookupForm();
                        break;
                }
            }
        }

        #endregion[Grid Event]

        #region[Calc Total]

        private void CalcRow(int pRowIndex)
        {

            decimal vPrice = ConvertTO.Decimal(editgrid[GARMENT_INVOICEITEMS.PRICE, pRowIndex].Value);

            decimal vQty = ConvertTO.Decimal(editgrid[GARMENT_INVOICEITEMS.QTY, pRowIndex].Value);

            decimal vtaxableAmount = vQty * vPrice;

            if (txt_taxtype_id.Text == Core.SGST)
            {
                decimal vSgst_per = ConvertTO.Decimal(editgrid[GARMENT_INVOICEITEMS.SGST_PERCENT, pRowIndex].Value);
                decimal vCgst_per = ConvertTO.Decimal(editgrid[GARMENT_INVOICEITEMS.CGST_PERCENT, pRowIndex].Value);

                decimal vSgst_amount = decimal.Round(((vtaxableAmount * vSgst_per) / 100), 2);
                decimal vCgst_amount = decimal.Round(((vtaxableAmount * vCgst_per) / 100), 2);

                editgrid[GARMENT_INVOICEITEMS.SGST_AMOUNT, pRowIndex].Value = (decimal.Round(vSgst_amount, 2)).ToString();
                editgrid[GARMENT_INVOICEITEMS.CGST_AMOUNT, pRowIndex].Value = (decimal.Round(vCgst_amount, 2)).ToString();
                editgrid[GARMENT_INVOICEITEMS.IGST_PERCENT, pRowIndex].Value = "";
                editgrid[GARMENT_INVOICEITEMS.IGST_AMOUNT, pRowIndex].Value = "";
            }
            else
            {
                decimal vIgst_per = ConvertTO.Decimal(editgrid[GARMENT_INVOICEITEMS.IGST_PERCENT, pRowIndex].Value);
                decimal vIgst_amount = decimal.Round(((vtaxableAmount * vIgst_per) / 100), 2);

                editgrid[GARMENT_INVOICEITEMS.SGST_AMOUNT, pRowIndex].Value = "";
                editgrid[GARMENT_INVOICEITEMS.SGST_PERCENT, pRowIndex].Value = "";
                editgrid[GARMENT_INVOICEITEMS.CGST_AMOUNT, pRowIndex].Value = "";
                editgrid[GARMENT_INVOICEITEMS.CGST_PERCENT, pRowIndex].Value = "";
                editgrid[GARMENT_INVOICEITEMS.IGST_AMOUNT, pRowIndex].Value = (decimal.Round(vIgst_amount, 2)).ToString();
            }

            editgrid[GARMENT_INVOICEITEMS.TAXABLEAMOUNT, pRowIndex].Value = (decimal.Round(vtaxableAmount, 2)).ToString();
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
                vTotQty += ConvertTO.Decimal(editgrid[GARMENT_INVOICEITEMS.QTY, r].Value);

                vTotTaxable += ConvertTO.Decimal(editgrid[GARMENT_INVOICEITEMS.TAXABLEAMOUNT, r].Value);

                vTotCgst += ConvertTO.Decimal(editgrid[GARMENT_INVOICEITEMS.CGST_AMOUNT, r].Value);

                vTotSgst += ConvertTO.Decimal(editgrid[GARMENT_INVOICEITEMS.SGST_AMOUNT, r].Value);

                vTotIgst += ConvertTO.Decimal(editgrid[GARMENT_INVOICEITEMS.IGST_AMOUNT, r].Value);
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

            txt_gsttotal.Text = (vTotCgst + vTotSgst + vTotIgst).ToString();

            txt_grandtotal.Text = ConvertTO.Decimal2d(rounded.ToString());

            txt_total_qty.Text = vTotQty + "";
        }

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

                case GARMENT_INVOICEITEMS.PRODUCT_ID:
                    {
                        frmLookup.LookupColNames = new string[] { PRODUCT.PRODUCT_NAME };
                        frmLookup.SelectedPkValue = editgrid[GARMENT_INVOICEITEMS.PRODUCT_ID, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        if (txt_party_id.Text != "")
                        {
                            frmLookup.LookupList = CProduct_exten.GetforLookup(new DAL());
                            frmLookup.LoadLookupList();
                        }
                    }
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

                case GARMENT_INVOICEITEMS.PRODUCT_ID:
                    if (vEntity == null)
                    {
                        editgrid[GARMENT_INVOICEITEMS.PRODUCT_ID, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[GARMENT_INVOICEITEMS.PRODUCT_ID, lookupRow].Value = vEntity[PRODUCT.PRODUCT_NAME];
                        editgrid.CurrentCell = editgrid[GARMENT_INVOICEITEMS.PRODUCT_ID, lookupRow];

                        //if (txt_taxtype_id.Text == "SGST")
                        //{
                        //    editgrid[GARMENT_INVOICEITEMS.SGST_PERCENT, lookupRow].Value = Ccoreplus.GetSgst_Name(vEntity[PRODUCT.PRODUCT_ID] + "");
                        //    editgrid[GARMENT_INVOICEITEMS.CGST_PERCENT, lookupRow].Value = Ccoreplus.GetCgst_Name(vEntity[PRODUCT.PRODUCT_ID] + "");
                        //}
                        //else if (txt_taxtype_id.Text == "IGST")
                        //{
                        //    editgrid[GARMENT_INVOICEITEMS.IGST_PERCENT, lookupRow].Value = Ccoreplus.GetIgst_Name(vEntity[PRODUCT.PRODUCT_ID] + "");
                        //}
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
                case GARMENT_INVOICEITEMS.PRODUCT_ID:
                    Product_NewEntry(pValue);
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
            editgrid[GARMENT_INVOICEITEMS.PRODUCT_ID, lookupRow].Value = xproduct.GetName();
            editgrid.Focus();
            editgrid.CurrentCell = editgrid[GARMENT_INVOICEITEMS.QTY, lookupRow];

        }

        #endregion [Product]

        #endregion [New Entry]

    }//cls
}//ns
