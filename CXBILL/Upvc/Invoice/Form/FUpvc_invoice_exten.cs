// Version : 3 dt : 01-08-2017
// Auto Generated
// 23-08-2017 10:05:48 AM
// last update : 23-08-2017

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;
using CXCORE;

namespace CXBILL
{
    public partial class FUpvc_invoice : UserControl
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
                case UPVC_INVOICEITEMS.QTY:
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
                case UPVC_INVOICEITEMS.WIDTHS:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
                case UPVC_INVOICEITEMS.HEIGHTS:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
                case UPVC_INVOICEITEMS.QTY:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
                case UPVC_INVOICEITEMS.PRICE:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
                case UPVC_INVOICEITEMS.SGST_PERCENT:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
                case UPVC_INVOICEITEMS.CGST_PERCENT:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
                case UPVC_INVOICEITEMS.IGST_PERCENT:
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
                    case UPVC_INVOICEITEMS.PRODUCT_ID:
                        ShowLookupForm();
                        break;
                }
            }
        }

        #endregion[Grid Event]

        #region[Calc Total]

        private void CalcRow(int pRowIndex)
        {
            decimal vtaxableAmount = 0M;
            decimal vCalculation = ConvertTO.Decimal("304.8");
            decimal vWidths = ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.WIDTHS, pRowIndex].Value);
            decimal vHeights = ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.HEIGHTS, pRowIndex].Value);

            decimal vAreasq = decimal.Round(((vWidths / vCalculation) * (vHeights / vCalculation)),2);

           

            decimal vPrice = ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.PRICE, pRowIndex].Value);

            decimal vrateperpcs = vAreasq * vPrice;

            decimal vQty = ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.QTY, pRowIndex].Value);




            decimal TotalAreasq = vAreasq * vQty;


            editgrid[UPVC_INVOICEITEMS.AREASQ, pRowIndex].Value = (decimal.Round(TotalAreasq, 2)).ToString();


            if (editgrid[UPVC_INVOICEITEMS.PRODUCT_ID, pRowIndex].Value != null)
            {
                if (CUpvc_invoice_exten.Producttype(editgrid[UPVC_INVOICEITEMS.PRODUCT_ID, pRowIndex].Value.ToString()) == true)
                {
                    vtaxableAmount = vQty * vPrice;
                }
                else
                {
                    vtaxableAmount = vQty * vrateperpcs;
                }
            }

            if (txt_taxtype_id.Text == Core.SGST)
            {
                decimal vSgst_per = ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.SGST_PERCENT, pRowIndex].Value);
                decimal vCgst_per = ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.CGST_PERCENT, pRowIndex].Value);

                decimal vSgst_amount = decimal.Round(((vtaxableAmount * vSgst_per) / 100), 2);
                decimal vCgst_amount = decimal.Round(((vtaxableAmount * vCgst_per) / 100), 2);

                editgrid[UPVC_INVOICEITEMS.SGST_AMOUNT, pRowIndex].Value = (decimal.Round(vSgst_amount, 2)).ToString();
                editgrid[UPVC_INVOICEITEMS.CGST_AMOUNT, pRowIndex].Value = (decimal.Round(vCgst_amount, 2)).ToString();
                editgrid[UPVC_INVOICEITEMS.IGST_PERCENT, pRowIndex].Value = "";
                editgrid[UPVC_INVOICEITEMS.IGST_AMOUNT, pRowIndex].Value = "";
            }
            else
            {
                decimal vIgst_per = ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.IGST_PERCENT, pRowIndex].Value);
                decimal vIgst_amount = decimal.Round(((vtaxableAmount * vIgst_per) / 100), 2);

                editgrid[UPVC_INVOICEITEMS.SGST_AMOUNT, pRowIndex].Value = "";
                editgrid[UPVC_INVOICEITEMS.SGST_PERCENT, pRowIndex].Value = "";
                editgrid[UPVC_INVOICEITEMS.CGST_AMOUNT, pRowIndex].Value = "";
                editgrid[UPVC_INVOICEITEMS.CGST_PERCENT, pRowIndex].Value = "";
                editgrid[UPVC_INVOICEITEMS.IGST_AMOUNT, pRowIndex].Value = (decimal.Round(vIgst_amount, 2)).ToString();
            }

            editgrid[UPVC_INVOICEITEMS.TAXABLEAMOUNT, pRowIndex].Value = (decimal.Round(vtaxableAmount, 2)).ToString();
        }



        private decimal vTotAreasq = 0M;
        private decimal vTotTaxable = 0M;
        private decimal vTotCgst = 0M;
        private decimal vTotSgst = 0M;
        private decimal vTotIgst = 0M;
        private decimal vTotQty = 0M;
        private decimal vRoundoff = 0M;

        private void CalcTotals()
        {
            vTotAreasq = 0M;
            vTotTaxable = 0M;
            vTotCgst = 0M;
            vTotSgst = 0M;
            vTotIgst = 0M;
            vTotQty = 0M;
            vRoundoff = 0M;

            for (int r = 0; r <= editgrid.Rows.Count - 1; r++)
            {
                vTotAreasq += ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.AREASQ, r].Value);

                vTotQty += ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.QTY, r].Value);

                vTotTaxable += ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.TAXABLEAMOUNT, r].Value);

                vTotCgst += ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.CGST_AMOUNT, r].Value);

                vTotSgst += ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.SGST_AMOUNT, r].Value);

                vTotIgst += ConvertTO.Decimal(editgrid[UPVC_INVOICEITEMS.IGST_AMOUNT, r].Value);
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

                case UPVC_INVOICEITEMS.PRODUCT_ID:
                    {
                        frmLookup.LookupColNames = new string[] { PRODUCT.PRODUCT_NAME };
                        frmLookup.SelectedPkValue = editgrid[UPVC_INVOICEITEMS.PRODUCT_ID, lookupRow].Value;
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
                    throw new System.Exception("'" + lookupColName + "' Not Found");
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
                case UPVC_INVOICEITEMS.PRODUCT_ID:
                    if (vEntity == null)
                    {
                        editgrid[UPVC_INVOICEITEMS.PRODUCT_ID, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[UPVC_INVOICEITEMS.PRODUCT_ID, lookupRow].Value = vEntity[PRODUCT.PRODUCT_NAME];

                        //editgrid[UPVC_INVOICEITEMS.SGST_PERCENT, lookupRow].Value = Ccoreplus.GetSgst_Name(vEntity[PRODUCT.PRODUCT_NAME] + "");
                        //editgrid[UPVC_INVOICEITEMS.CGST_PERCENT, lookupRow].Value = Ccoreplus.GetCgst_Name(vEntity[PRODUCT.PRODUCT_NAME] + "");
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
                case UPVC_INVOICEITEMS.PRODUCT_ID:
                    FproductNewEntry(pValue);
                    break;
            }
        }

        #endregion[Look up]

        #region [New Entry]

        private FProduct xproduct = null;
        void FproductNewEntry(string pValue)
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
            editgrid[UPVC_INVOICEITEMS.PRODUCT_ID, lookupRow].Value = xproduct.GetName();
            editgrid.Focus();
            editgrid.CurrentCell = editgrid[UPVC_INVOICEITEMS.QTY, lookupRow];

        }

        #endregion [New Entry]

    }//cls
}//ns
