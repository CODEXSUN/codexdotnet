// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:58 PM
// last update : 17-08-2017


using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;
using CXCORE;

namespace CXERP
{
    public partial class FInward 
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
                case INWARDITEMS.QTY:
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
                case INWARDITEMS.QTY:
                    CalcRow(e.RowIndex);
                    CalcTotals();
                    break;
                case INWARDITEMS.BUNDLE:
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

                    case INWARDITEMS.PRODUCT_ID:
                        ShowLookupForm();
                        break;
                    case INWARDITEMS.SIZES_ID:
                        ShowLookupForm();
                        break;
                }
            }
        }

        #endregion[Grid Event]

        #region[Calc Total]

        private void CalcRow(int pRowIndex)
        {

            decimal vPrice = ConvertTO.Decimal(editgrid[INWARDITEMS.BUNDLE, pRowIndex].Value);

            decimal vQty = ConvertTO.Decimal(editgrid[INWARDITEMS.QTY, pRowIndex].Value);

            decimal vtaxableAmount = vQty * vPrice;

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
                vTotQty += ConvertTO.Decimal(editgrid[INWARDITEMS.QTY, r].Value);

                //vTotTaxable += ConvertTO.Decimal(editgrid[INWARDITEMS.TAXABLEAMOUNT, r].Value);

                //vTotCgst += ConvertTO.Decimal(editgrid[INWARDITEMS.CGST_AMOUNT, r].Value);

                //vTotSgst += ConvertTO.Decimal(editgrid[INWARDITEMS.SGST_AMOUNT, r].Value);

                //vTotIgst += ConvertTO.Decimal(editgrid[INWARDITEMS.IGST_AMOUNT, r].Value);
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


                //case INWARDITEMS.PO_ID:
                //    {
                //        //if (Customise.Inward_poid_dcid == true)
                //        //{

                //        //    frmLookup.LookupColNames = new string[] { PO.PO_NO, DC.DC_NO, DCITEMS.PRODUCT_ID, DCITEMS.QTY, DCITEMS.REFERED_QTY, POITEMS.PRICE };
                //        //    frmLookup.SelectedPkValue = editgrid[INWARDITEMS.PO_ID, lookupRow].Value;
                //        //    frmLookup.AllowNewEntry = true;
                //        //    frmLookup.AllowEmptySelection = true;
                //        //    //
                //        //    if (txt_party_id.Text != "")
                //        //    {
                //        //        frmLookup.LookupList = CPo_lookup.LookupbyPono(txt_party_id.Text);

                //        //        //frmLookup.LookupList = CPo_lookup.LookupPObyPartyforInward(CParty_exten.GetId_Name(txt_party_id.Text));
                //        //        frmLookup.LoadLookupList();
                //        //    }
                //        //    //
                //        //}
                //    }
                //    break;
                //
                //case INWARDITEMS.DC_ID:
                //    {
                //        if (Customise.Inward_poid_dcid == true)
                //        {

                //            //frmLookup.LookupColNames = new string[] { DC.DC_NO, DCITEMS.PRODUCT_ID, DCITEMS.QTY, DCITEMS.REFERED_QTY, POITEMS.PRICE };
                //            //frmLookup.SelectedPkValue = editgrid[INWARDITEMS.DC_ID, lookupRow].Value;
                //            //frmLookup.AllowNewEntry = true;
                //            //frmLookup.AllowEmptySelection = true;
                //            //// 
                //            //if (txt_party_id.Text != "")
                //            //{
                //            //    if (editgrid[DCITEMS.PO_ID, lookupRow].Value != null)
                //            //    {
                //            //        if (editgrid[DCITEMS.PO_ID, lookupRow].Value.ToString() != "")
                //            //        {
                //            //            if (editgrid[DCITEMS.PO_ID, lookupRow].Value.ToString() != Core.Without_Po)
                //            //            { }
                //            //            else
                //            //            {
                //            //                frmLookup.LookupList = CDc_Lookup.LookupDC_Party_forInward(CParty_exten.GetId_Name(txt_party_id.Text));
                //            //                frmLookup.LoadLookupList();
                //            //            }
                //            //        }
                //            //        else
                //            //        {
                //            //            frmLookup.LookupList = CDc_Lookup.LookupDC_Party_forInward(CParty_exten.GetId_Name(txt_party_id.Text));
                //            //            frmLookup.LoadLookupList();
                //            //        }
                //            //    }
                //            //    else
                //            //    {
                //            //        frmLookup.LookupList = CDc_Lookup.LookupDC_Party_forInward(CParty_exten.GetId_Name(txt_party_id.Text));
                //            //        frmLookup.LoadLookupList();
                //            //    }
                //            //}
                //            //
                //        }
                //    }
                //    break;

                case INWARDITEMS.PRODUCT_ID:
                    {
                        frmLookup.LookupColNames = new string[] { PRODUCT.PRODUCT_NAME };
                        frmLookup.SelectedPkValue = editgrid[INWARDITEMS.PRODUCT_ID, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        if (txt_party_id.Text != "")
                        {
                            //if (Customise.Inward_poid_dcid == true)
                            //{

                                //if (editgrid[DCITEMS.PO_ID, lookupRow].Value != null)
                                //{
                                //    if (editgrid[DCITEMS.DC_ID, lookupRow].Value != null)
                                //    {

                                //        if (editgrid[DCITEMS.PO_ID, lookupRow].Value.ToString() == Core.Without_Po)
                                //        {
                                //            if (editgrid[DCITEMS.DC_ID, lookupRow].Value.ToString() == Core.Without_Dc)
                                //            {
                                //                frmLookup.LookupList = CProduct_exten.GetforLookup(new DAL());
                                //                frmLookup.LoadLookupList();
                                //            }
                                //        }
                                //    }
                                //    else
                                //    {
                                //        frmLookup.LookupList = CProduct_exten.GetforLookup(new DAL());
                                //        frmLookup.LoadLookupList();
                                //    }
                                //}
                                //else
                                //{

                                //    frmLookup.LookupList = CProduct_exten.GetforLookup(new DAL());
                                //    frmLookup.LoadLookupList();
                            //    //}
                            //}

                            //if ((Customise.Inward_pono_dcno == true) || (Customise.Inward_Without_podc == true))
                            //{
                                frmLookup.LookupList = CProduct_exten.GetforLookup(new DAL());
                                frmLookup.LoadLookupList();
                            //}
                        }
                    }
                    break;

                case INWARDITEMS.SIZES_ID:

                    frmLookup.LookupColNames = new string[] { SIZES.SIZES_NAME};
                    frmLookup.SelectedPkValue = editgrid[INWARDITEMS.SIZES_ID, lookupRow].Value;
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
                //case INWARDITEMS.PO_ID:
                //    if (vEntity == null)
                //    {
                //        editgrid[INWARDITEMS.PO_ID, lookupRow].Value = "";
                //    }
                //    else
                //    {
                //        if (Customise.Inward_poid_dcid == true)
                //        {
                //            //editgrid[INWARDITEMS.PO_ID, lookupRow].Value = vEntity[PO.PO_NO];
                //            //if (vEntity[PO.PO_NO] + "" != Core.Without_Po)
                //            //{
                //                //editgrid[INWARDITEMS.DC_ID, lookupRow].Value = vEntity[DC.DC_NO];
                //                //editgrid[INWARDITEMS.DCITEMS_ID, lookupRow].Value = vEntity[DCITEMS.DCITEMS_ID];
                //                //editgrid[INWARDITEMS.PRODUCT_ID, lookupRow].Value = vEntity[DCITEMS.PRODUCT_ID];
                //                //editgrid[INWARDITEMS.QTY, lookupRow].Value = vEntity[DCITEMS.QTY];
                //                //editgrid[INWARDITEMS.PRICE, lookupRow].Value = vEntity[POITEMS.PRICE];

                //                if (txt_taxtype_id.Text == "SGST")
                //                {
                //                    editgrid[INWARDITEMS.SGST_PERCENT, lookupRow].Value = Ccoreplus.GetSgst_Name(vEntity[PRODUCT.PRODUCT_ID] + "");
                //                    editgrid[INWARDITEMS.CGST_PERCENT, lookupRow].Value = Ccoreplus.GetCgst_Name(vEntity[PRODUCT.PRODUCT_ID] + "");
                //                }
                //                else if (txt_taxtype_id.Text == "IGST")
                //                {
                //                    editgrid[INWARDITEMS.IGST_PERCENT, lookupRow].Value = Ccoreplus.GetIgst_Name(vEntity[PRODUCT.PRODUCT_ID] + "");
                //                }
                //                //editgrid.CurrentCell = editgrid[INWARDITEMS.PRICE, lookupRow];
                //            //}
                //            else
                //            {
                //                editgrid.CurrentCell = editgrid[INWARDITEMS.PO_ID, lookupRow];
                //            }
                //        }

                //    }
                //    break;
                //
                //case INWARDITEMS.DC_ID:
                //    if (vEntity == null)
                //    {
                //        editgrid[INWARDITEMS.DC_ID, lookupRow].Value = "";
                //    }
                //    else
                //    {
                //        if (Customise.Inward_poid_dcid == true)
                //        {
                //            //editgrid[INWARDITEMS.DC_ID, lookupRow].Value = vEntity[DC.DC_NO];
                //            //if (vEntity[DCITEMS.DC_NO] + "" != Core.Without_Dc)
                //            //{
                //            //    editgrid[INWARDITEMS.PO_ID, lookupRow].Value = Core.Without_Po;
                //            //    //editgrid[INWARDITEMS.DCITEM_ID, lookupRow].Value = vEntity[Dc_item.DC_ITEM_ID];
                //            //    //editgrid[INWARDITEMS.PRODUCT_ID, lookupRow].Value = vEntity[DCITEMS.PRODUCT_ID];
                //            //    //editgrid[INWARDITEMS.QTY, lookupRow].Value = vEntity[DCITEMS.REFERED_QTY];
                //            //    //editgrid[INWARDITEMS.PRICE, lookupRow].Value = vEntity[POITEMS.PRICE];

                //            //    editgrid.CurrentCell = editgrid[INWARDITEMS.PRODUCT_ID, lookupRow];
                //            //}
                //            //else
                //            //{
                //            //    editgrid.CurrentCell = editgrid[INWARDITEMS.DC_ID, lookupRow];
                //            //}
                //        }
                //    }
                //    break;

                case INWARDITEMS.PRODUCT_ID:
                    if (vEntity == null)
                    {
                        editgrid[INWARDITEMS.PRODUCT_ID, lookupRow].Value = "";
                    }
                    else
                    {
                        //if (Customise.Inward_poid_dcid == true)
                        //{
                        //    editgrid[INWARDITEMS.PO_ID, lookupRow].Value = Core.Without_Po;
                        //    editgrid[INWARDITEMS.DC_ID, lookupRow].Value = Core.Without_Dc;
                        //}

                        editgrid[INWARDITEMS.PRODUCT_ID, lookupRow].Value = Checks.RemoveEscape(vEntity[PRODUCT.PRODUCT_NAME].ToString());
                        //editgrid.CurrentCell = editgrid[INWARDITEMS.PRODUCT_ID, lookupRow];

                        //if (txt_taxtype_id.Text == "SGST")
                        //{
                        //    editgrid[INWARDITEMS.SGST_PERCENT, lookupRow].Value = Ccoreplus.GetSgst_Name(vEntity[PRODUCT.PRODUCT_ID] + "");
                        //    editgrid[INWARDITEMS.CGST_PERCENT, lookupRow].Value = Ccoreplus.GetCgst_Name(vEntity[PRODUCT.PRODUCT_ID] + "");
                        //}
                        //else if (txt_taxtype_id.Text == "IGST")
                        //{
                        //    editgrid[INWARDITEMS.IGST_PERCENT, lookupRow].Value = Ccoreplus.GetIgst_Name(vEntity[PRODUCT.PRODUCT_ID] + "");
                        //}
                    }
                    break;

                case INWARDITEMS.SIZES_ID:
                    if (vEntity == null)
                    {
                        editgrid[INWARDITEMS.SIZES_ID, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[INWARDITEMS.SIZES_ID, lookupRow].Value = vEntity[SIZES.SIZES_NAME];
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
                //case INWARDITEMS.PO_ID:
                //    if (Customise.Inward_poid_dcid == true)
                //    {
                //        //Po_NewEntry(pValue);
                //    }
                //    break;
                //case INWARDITEMS.DC_ID:
                //    if (Customise.Inward_poid_dcid == true)
                //    {
                //        //Dc_NewEntry(pValue);
                //    }
                //    break;
                case INWARDITEMS.PRODUCT_ID:
                    Product_NewEntry(pValue);
                    break;
                case INWARDITEMS.SIZES_ID:
                    Sizes_NewEntry(pValue);
                    break;
            }
        }

        #endregion[Look up]

        #region [New Entry]

        //#region [PO]

        //private FPo xPo = null;
        //void Po_NewEntry(string pValue)
        //{
        //    if (xPo == null)
        //    {
        //        xPo = new FPo();
        //    }
        //    this.Parent.Controls.Add(xPo);
        //    xPo.Dock = DockStyle.Fill;
        //    xPo.Show();
        //    xPo.BringToFront();
        //    xPo.Focus();
        //    xPo.SetAction(BtnEvent.New, null);
        //    xPo.SetFocus();
        //}

        //#endregion [PO]

        //#region [Dc]

        //private FDc xDc = null;
        //void Dc_NewEntry(string pValue)
        //{
        //    if (xDc == null)
        //    {
        //        xDc = new FDc();
        //    }
        //    this.Parent.Controls.Add(xDc);
        //    xDc.Dock = DockStyle.Fill;
        //    xDc.Show();
        //    xDc.BringToFront();
        //    xDc.Focus();
        //    xDc.SetAction(BtnEvent.New, null);
        //    xDc.SetFocus();
        //}

        //#endregion [Dc]

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
            editgrid[INWARDITEMS.PRODUCT_ID, lookupRow].Value = xproduct.GetName();
            editgrid.Focus();
            editgrid.CurrentCell = editgrid[INWARDITEMS.SIZES_ID, lookupRow];

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
            editgrid[INWARDITEMS.SIZES_ID, lookupRow].Value = xsizes.GetName();
            editgrid.Focus();
            editgrid.CurrentCell = editgrid[INWARDITEMS.QTY, lookupRow];

        }

        #endregion [Product]

        #endregion [New Entry]

    }//cls
}//ns
