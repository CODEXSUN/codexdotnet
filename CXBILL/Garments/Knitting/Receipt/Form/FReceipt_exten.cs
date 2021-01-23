// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:15 AM
// last update : 13-03-2018

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXKNITTING
{
    public partial class FReceipt : UserControl
    {
        #region[Grid Event]

        void Editgrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcTotals();
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
                case KNITTING_RECEIPTITEMS.RECEIPT_AMOUNT:
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
                    case KNITTING_RECEIPTITEMS.RECEIPT_BY:
                        ShowLookupForm();
                        break;
                }
            }
        }

        #endregion[Grid Event]

        #region[Calc Total]

        private void CalcTotals()
        {
            decimal vTotal_Invoice_amount = 0M;
            decimal vTotal_Receipt_amount = 0M;
            for (int r = 0; r <= editgrid.Rows.Count - 1; r++)
            {
                decimal vInvoice_amount = Global.ToDecimal(editgrid[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT, r].Value);
                vTotal_Invoice_amount += vInvoice_amount;
                decimal vReceipt_amount = Global.ToDecimal(editgrid[KNITTING_RECEIPTITEMS.RECEIPT_AMOUNT, r].Value);
                vTotal_Receipt_amount += vReceipt_amount;
            }

            txt_total_amount.Text = vTotal_Receipt_amount.ToString();
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

                case KNITTING_RECEIPTITEMS.RECEIPT_BY:
                    {
                        frmLookup.LookupColNames = new string[] { KNITTING_RECEIPTITEMS.RECEIPT_BY, KNITTING_RECEIPTITEMS.KNITTING_INVOICED_NO, KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT, KNITTING_RECEIPTITEMS.RECEIPT_AMOUNT };
                        frmLookup.SelectedPkValue = editgrid[KNITTING_RECEIPTITEMS.RECEIPT_BY, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        if (txt_party_id.Text != "")
                        {
                            frmLookup.LookupList = CReceipt_manual.ReceiptLookup(txt_party_id.Text);
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
                case KNITTING_RECEIPTITEMS.RECEIPT_BY:

                    if (vEntity == null)
                    {
                        editgrid[KNITTING_RECEIPTITEMS.RECEIPT_BY, lookupRow].Value = "";
                        editgrid[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_NO, lookupRow].Value = "";
                        editgrid[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[KNITTING_RECEIPTITEMS.RECEIPT_BY, lookupRow].Value = vEntity[KNITTING_RECEIPTITEMS.RECEIPT_BY];

                        if (vEntity[KNITTING_RECEIPTITEMS.RECEIPT_BY].ToString() == Core.Advance)
                        {
                            editgrid[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_NO, lookupRow].Value = "";
                            editgrid[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT, lookupRow].Value = "";
                            editgrid[KNITTING_RECEIPTITEMS.RECEIPT_AMOUNT, lookupRow].Value = "";
                            editgrid.CurrentCell = editgrid[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT, lookupRow];
                        }
                        else
                        {
                            editgrid[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_NO, lookupRow].Value = vEntity[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_NO];
                            editgrid[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT, lookupRow].Value = vEntity[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT];
                            editgrid[KNITTING_RECEIPTITEMS.RECEIPT_AMOUNT, lookupRow].Value = vEntity[KNITTING_RECEIPTITEMS.RECEIPT_AMOUNT];
                            editgrid.CurrentCell = editgrid[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT, lookupRow];
                        }
                    }
                    break;
                    //
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

        #endregion[Look up]

}//cls
}//ns
