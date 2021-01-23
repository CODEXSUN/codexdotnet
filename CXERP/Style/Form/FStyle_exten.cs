// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 08-01-2018 10:25:49 PM
// last update : 08-01-2018

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;
using CXCORE;

namespace CXERP
{
    public partial class FArticle : UserControl
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
                case ARTICLEITEMS.QTY:
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
                case ARTICLEITEMS.QTY:
                    CalcAmount(e.RowIndex);
                    CalcTotals();
                    break;
                case ARTICLEITEMS.PRICE:
                    CalcAmount(e.RowIndex);
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
                    case ARTICLEITEMS.PRODUCT_ID:
                        ShowLookupForm();
                        break;
                    case ARTICLEITEMS.COLOURS_ID:
                        ShowLookupForm();
                        break;
                    case ARTICLEITEMS.SIZES_ID:
                        ShowLookupForm();
                        break;
                }
            }
        }

        #endregion[Grid Event]

        #region[Calc Total]

        private void CalcAmount(int pRowIndex)
        {
            decimal vQty = Global.ToDecimal(editgrid[ARTICLEITEMS.QTY, pRowIndex].Value);
            decimal vPrice = Global.ToDecimal(editgrid[ARTICLEITEMS.PRICE, pRowIndex].Value);
            decimal vAmount = vQty * vPrice;
        }

        private void CalcTotals()
        {
            decimal vTotQty = 0M;
            for (int r = 0; r <= editgrid.Rows.Count - 1; r++)
            {
                decimal vQty = Global.ToDecimal(editgrid[ARTICLEITEMS.QTY, r].Value);
                vTotQty += vQty;
            }
            //
            //txt_total_qty.Text = vTotQty.ToString();
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

                case ARTICLEITEMS.PRODUCT_ID:
                    {
                        frmLookup.LookupColNames = new string[] { PRODUCT.PRODUCT_NAME };
                        frmLookup.SelectedPkValue = editgrid[ARTICLEITEMS.PRODUCT_ID, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        if (txt_article_no.Text != "")
                        {
                            frmLookup.LookupList = CProduct_exten.GetforLookup(new DAL());
                            frmLookup.LoadLookupList();
                        }
                    }
                    break;

                case ARTICLEITEMS.COLOURS_ID:
                    {
                        frmLookup.LookupColNames = new string[] { COLOURS.COLOURS_NAME };
                        frmLookup.SelectedPkValue = editgrid[ARTICLEITEMS.COLOURS_ID, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        if (txt_article_no.Text != "")
                        {
                            frmLookup.LookupList = CColours_exten.GetforLookup(new DAL());
                            frmLookup.LoadLookupList();
                        }
                    }
                    break;

                case ARTICLEITEMS.SIZES_ID:
                    {
                        frmLookup.LookupColNames = new string[] { SIZES.SIZES_NAME };
                        frmLookup.SelectedPkValue = editgrid[ARTICLEITEMS.SIZES_ID, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        if (txt_article_no.Text != "")
                        {
                            frmLookup.LookupList = CSizes_exten.GetforLookup(new DAL());
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
                case ARTICLEITEMS.PRODUCT_ID:
                    if (vEntity == null)
                    {
                        editgrid[ARTICLEITEMS.PRODUCT_ID, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[ARTICLEITEMS.PRODUCT_ID, lookupRow].Value = vEntity[PRODUCT.PRODUCT_NAME];
                    }
                    editgrid.CurrentCell = editgrid[ARTICLEITEMS.PRODUCT_ID, lookupRow];
                    break;

                case ARTICLEITEMS.COLOURS_ID:
                    if (vEntity == null)
                    {
                        editgrid[ARTICLEITEMS.COLOURS_ID, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[ARTICLEITEMS.COLOURS_ID, lookupRow].Value = vEntity[COLOURS.COLOURS_NAME];
                    }
                    editgrid.CurrentCell = editgrid[ARTICLEITEMS.COLOURS_ID, lookupRow];
                    break;

                case ARTICLEITEMS.SIZES_ID:
                    if (vEntity == null)
                    {
                        editgrid[ARTICLEITEMS.SIZES_ID, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[ARTICLEITEMS.SIZES_ID, lookupRow].Value = vEntity[SIZES.SIZES_NAME];
                    }
                    editgrid.CurrentCell = editgrid[ARTICLEITEMS.SIZES_ID, lookupRow];
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
                case ARTICLEITEMS.PRODUCT_ID:
                    FproductNewEntry(pValue);
                    break;

                case ARTICLEITEMS.COLOURS_ID:
                    FcoloursNewEntry(pValue);
                    break;

                case ARTICLEITEMS.SIZES_ID:
                    FsizesNewEntry(pValue);
                    break;
            }
        }

        #endregion[Look up]

        #region [New Entry]

        #region[Product]

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
            editgrid[ARTICLEITEMS.PRODUCT_ID, lookupRow].Value = xproduct.GetName();
            editgrid.Focus();
            editgrid.CurrentCell = editgrid[ARTICLEITEMS.SIZES_ID, lookupRow];

        }

        #endregion[Product]

        #region[SIZES]

        private FSizes xsizes = null;
        void FsizesNewEntry(string pValue)
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
            editgrid[ARTICLEITEMS.SIZES_ID, lookupRow].Value = xsizes.GetName();
            editgrid.Focus();
            editgrid.CurrentCell = editgrid[ARTICLEITEMS.QTY, lookupRow];

        }

        #endregion[sizes]

        #region[COLOURS]

        private FColours xcolours = null;
        void FcoloursNewEntry(string pValue)
        {
            if (xcolours == null)
            {
                xcolours = new FColours();
                xcolours.FColours_NeedToRefresh += Xcolours_refresh;
            }
            this.Parent.Controls.Add(xcolours);
            xcolours.Dock = DockStyle.Fill;
            xcolours.Show();
            xcolours.BringToFront();
            xcolours.Focus();
            xcolours.SetAction(BtnEvent.New, null);
            xcolours.SetFocus();
            xcolours.setname(pValue);
        }
        private void Xcolours_refresh(object sender, EventArgs e)
        {
            editgrid[ARTICLEITEMS.COLOURS_ID, lookupRow].Value = xcolours.GetName();
            editgrid.Focus();
            editgrid.CurrentCell = editgrid[ARTICLEITEMS.QTY, lookupRow];

        }

        #endregion[colours]

        #endregion [New Entry]

    }//cls
}//ns
