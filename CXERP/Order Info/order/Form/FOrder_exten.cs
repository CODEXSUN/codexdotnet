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
    public partial class FOrder : UserControl
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
                case ORDERITEMS.QTY:
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
                case ORDERITEMS.QTY:
                    CalcAmount(e.RowIndex);
                    CalcTotals();
                    break;
                case ORDERITEMS.PRICE:
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
                    case ORDERITEMS.STYLE_ID:
                        ShowLookupForm();
                        break;
                    case ORDERITEMS.COLOURS_ID:
                        ShowLookupForm();
                        break;
                }
            }
        }

        #endregion[Grid Event]

        #region[Calc Total]

        private void CalcAmount(int pRowIndex)
        {
            decimal vQty = Global.ToDecimal(editgrid[ORDERITEMS.QTY, pRowIndex].Value);
            decimal vPrice = Global.ToDecimal(editgrid[ORDERITEMS.PRICE, pRowIndex].Value);
            decimal vAmount = vQty * vPrice;
        }

        private void CalcTotals()
        {
            decimal vTotQty = 0M;
            for (int r = 0; r <= editgrid.Rows.Count - 1; r++)
            {
                decimal vQty = Global.ToDecimal(editgrid[ORDERITEMS.QTY, r].Value);
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

                case ORDERITEMS.STYLE_ID:
                    {
                        frmLookup.LookupColNames = new string[] { STYLE.STYLE_NO,STYLE.STYLE_NAME  };
                        frmLookup.SelectedPkValue = editgrid[ORDERITEMS.STYLE_ID, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        if (txt_party_id.Text != "")
                        {
                            frmLookup.LookupList = CStyle_exten.LookupStyle();
                            frmLookup.LoadLookupList();
                        }
                    }
                    break;

                case ORDERITEMS.COLOURS_ID:
                    {
                        frmLookup.LookupColNames = new string[] { COLOURS.COLOURS_NAME };
                        frmLookup.SelectedPkValue = editgrid[ORDERITEMS.COLOURS_ID, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        if (txt_party_id.Text != "")
                        {
                            frmLookup.LookupList = CColours_exten.GetforLookup(new DAL());
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
                case ORDERITEMS.STYLE_ID:
                    if (vEntity == null)
                    {
                        editgrid[ORDERITEMS.STYLE_ID, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[ORDERITEMS.STYLE_ID, lookupRow].Value = vEntity[STYLE.STYLE_NO];
                        editgrid[ORDERITEMS.STYLE_NAME, lookupRow].Value = vEntity[STYLE.STYLE_NAME];
                        
                    }
                    editgrid.CurrentCell = editgrid[ORDERITEMS.STYLE_ID, lookupRow];
                    break;

                case ORDERITEMS.COLOURS_ID:
                    if (vEntity == null)
                    {
                        editgrid[ORDERITEMS.COLOURS_ID, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[ORDERITEMS.COLOURS_ID, lookupRow].Value = vEntity[COLOURS.COLOURS_NAME];
                    }
                    editgrid.CurrentCell = editgrid[ORDERITEMS.COLOURS_ID, lookupRow];
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
                case ORDERITEMS.STYLE_ID:
                    FstyleNewEntry(pValue);
                    break;

                case ORDERITEMS.COLOURS_ID:
                    FcoloursNewEntry(pValue);
                    break;
            }
        }

        #endregion[Look up]

        #region [New Entry]

        #region[Product]

        private FStyle xstyle = null;
        void FstyleNewEntry(string pValue)
        {
            if (xstyle == null)
            {
                xstyle = new FStyle();
                xstyle.FStyle_NeedToRefresh += Xproduct_refresh;
            }
            this.Parent.Controls.Add(xstyle);
            xstyle.Dock = DockStyle.Fill;
            xstyle.Show();
            xstyle.BringToFront();
            xstyle.Focus();
            xstyle.SetAction(BtnEvent.New, null);
            xstyle.SetFocus();
        }
        private void Xproduct_refresh(object sender, EventArgs e)
        {
            editgrid[ORDERITEMS.STYLE_ID, lookupRow].Value = xstyle.GetName();
            editgrid.Focus();
            editgrid.CurrentCell = editgrid[ORDERITEMS.COLOURS_ID, lookupRow];

        }

        #endregion[Product]

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
            editgrid[ORDERITEMS.COLOURS_ID, lookupRow].Value = xcolours.GetName();
            editgrid.Focus();
            editgrid.CurrentCell = editgrid[ORDERITEMS.QTY, lookupRow];

        }

        #endregion[colours]

        #endregion [New Entry]

    }//cls
}//ns
