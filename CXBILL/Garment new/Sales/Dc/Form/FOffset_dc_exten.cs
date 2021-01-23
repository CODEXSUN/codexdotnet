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
    public partial class FOffset_dc : UserControl
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
                case OFFSET_DCITEMS.QTY:
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
                case OFFSET_DCITEMS.QTY:
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
                    case OFFSET_DCITEMS.OFFSET_PO_ID:
                        ShowLookupForm();
                        break;
                    case OFFSET_DCITEMS.PRODUCT_ID:
                        ShowLookupForm();
                        break;
                }
            }
        }

        #endregion[Grid Event]

        #region[Calc Total]
        private void CalcTotals()
        {
            decimal vTotQty = 0M;
            for (int r = 0; r <= editgrid.Rows.Count - 1; r++)
            {
                decimal vQty = ConvertTO.Decimal(editgrid[OFFSET_DCITEMS.QTY, r].Value);
                vTotQty += vQty;
            }
            //
            txt_total_qty.Text = vTotQty.ToString();
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

                case OFFSET_DCITEMS.OFFSET_PO_ID:
                    {
                        frmLookup.LookupColNames = new string[] { OFFSET_PO.OFFSET_PO_NO, OFFSET_POITEMS.PRODUCT_ID, OFFSET_POITEMS.QTY, OFFSET_POITEMS.REFERED_QTY };
                        frmLookup.SelectedPkValue = editgrid[OFFSET_DCITEMS.OFFSET_PO_ID, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;
                        //
                        if (txt_party_id.Text != "")
                        {
                            frmLookup.LookupList = CPo_lookup.DCLookup(txt_party_id.Text);
                            frmLookup.LoadLookupList();
                        }
                        //
                    }
                    break;

                case OFFSET_DCITEMS.PRODUCT_ID:
                    {
                        frmLookup.LookupColNames = new string[] { PRODUCT.PRODUCT_NAME };
                        frmLookup.SelectedPkValue = editgrid[OFFSET_DCITEMS.PRODUCT_ID, lookupRow].Value;
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
                case OFFSET_DCITEMS.OFFSET_PO_ID:
                    if (vEntity == null)
                    {
                        editgrid[OFFSET_DCITEMS.OFFSET_PO_ID, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[OFFSET_DCITEMS.OFFSET_PO_ID, lookupRow].Value = vEntity[OFFSET_PO.OFFSET_PO_NO];

                        if ((editgrid[OFFSET_DCITEMS.OFFSET_PO_ID, lookupRow].Value) != null)
                        {
                            if ((editgrid[OFFSET_DCITEMS.OFFSET_PO_ID, lookupRow].Value).ToString() != Core.Without_Po)
                            {
                                editgrid.CurrentCell = editgrid[OFFSET_DCITEMS.OFFSET_PO_ID, lookupRow];
                            }
                            else
                            {
                                editgrid.CurrentCell = editgrid[OFFSET_DCITEMS.PRODUCT_ID, lookupRow];
                            }
                        }

                        if (vEntity[OFFSET_PO.OFFSET_PO_NO] + "" != Core.Without_Po)
                        {
                            editgrid[OFFSET_DCITEMS.OFFSET_POITEMS_ID, lookupRow].Value = vEntity[OFFSET_POITEMS.OFFSET_POITEMS_ID];
                            editgrid[OFFSET_DCITEMS.PRODUCT_ID, lookupRow].Value = vEntity[OFFSET_POITEMS.PRODUCT_ID];
                            editgrid[OFFSET_DCITEMS.QTY, lookupRow].Value = vEntity[OFFSET_POITEMS.REFERED_QTY];

                            editgrid.CurrentCell = editgrid[OFFSET_DCITEMS.PRODUCT_ID, lookupRow];
                        }
                        else
                        {
                            editgrid.CurrentCell = editgrid[OFFSET_DCITEMS.OFFSET_PO_ID, lookupRow];
                        }


                    }
                    break;

                case OFFSET_DCITEMS.PRODUCT_ID:
                    if (vEntity == null)
                    {
                        editgrid[OFFSET_DCITEMS.PRODUCT_ID, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[OFFSET_DCITEMS.PRODUCT_ID, lookupRow].Value = vEntity[PRODUCT.PRODUCT_NAME];
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
                case OFFSET_DCITEMS.PRODUCT_ID:
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
            editgrid[OFFSET_DCITEMS.PRODUCT_ID, lookupRow].Value = xproduct.GetName();
            editgrid.Focus();
            editgrid.CurrentCell = editgrid[OFFSET_DCITEMS.QTY, lookupRow];

        }

        #endregion [New Entry]

}//cls
}//ns
