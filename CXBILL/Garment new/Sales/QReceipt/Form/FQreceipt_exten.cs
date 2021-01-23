// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:15 AM
// last update : 13-03-2018

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXBILL
{
    public partial class FQreceipt 
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
                case QRECEIPTITEMS.QRECEIPT_AMOUNT:
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
                    case QRECEIPTITEMS.QRECEIPT_BY:
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
                decimal vInvoice_amount = Global.ToDecimal(editgrid[QRECEIPTITEMS.QUOTATION_AMOUNT, r].Value);
                vTotal_Invoice_amount += vInvoice_amount;
                decimal vReceipt_amount = Global.ToDecimal(editgrid[QRECEIPTITEMS.QRECEIPT_AMOUNT, r].Value);
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

                case QRECEIPTITEMS.QRECEIPT_BY:
                    {
                        frmLookup.LookupColNames = new string[] { QRECEIPTITEMS.QRECEIPT_BY, QRECEIPTITEMS.QUOTATION_NO, QRECEIPTITEMS.QUOTATION_AMOUNT, QRECEIPTITEMS.QRECEIPT_AMOUNT };
                        frmLookup.SelectedPkValue = editgrid[QRECEIPTITEMS.QRECEIPT_BY, lookupRow].Value;
                        frmLookup.AllowNewEntry = true;
                        frmLookup.AllowEmptySelection = true;

                        if (txt_party_id.Text != "")
                        {
                            frmLookup.LookupList = CQreceipt_manual.ReceiptLookup(txt_party_id.Text);
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
                case QRECEIPTITEMS.QRECEIPT_BY:

                    if (vEntity == null)
                    {
                        editgrid[QRECEIPTITEMS.QRECEIPT_BY, lookupRow].Value = "";
                        editgrid[QRECEIPTITEMS.QUOTATION_NO, lookupRow].Value = "";
                        editgrid[QRECEIPTITEMS.QUOTATION_AMOUNT, lookupRow].Value = "";
                    }
                    else
                    {
                        editgrid[QRECEIPTITEMS.QRECEIPT_BY, lookupRow].Value = vEntity[QRECEIPTITEMS.QRECEIPT_BY];

                        if (vEntity[QRECEIPTITEMS.QRECEIPT_BY].ToString() == Core.Advance)
                        {
                            editgrid[QRECEIPTITEMS.QUOTATION_NO, lookupRow].Value = "";
                            editgrid[QRECEIPTITEMS.QUOTATION_AMOUNT, lookupRow].Value = "";
                            editgrid[QRECEIPTITEMS.QRECEIPT_AMOUNT, lookupRow].Value = "";
                            editgrid.CurrentCell = editgrid[QRECEIPTITEMS.QUOTATION_AMOUNT, lookupRow];
                        }
                        else
                        {
                            editgrid[QRECEIPTITEMS.QUOTATION_NO, lookupRow].Value = vEntity[QRECEIPTITEMS.QUOTATION_NO];
                            editgrid[QRECEIPTITEMS.QUOTATION_AMOUNT, lookupRow].Value = vEntity[QRECEIPTITEMS.QUOTATION_AMOUNT];
                            editgrid[QRECEIPTITEMS.QRECEIPT_AMOUNT, lookupRow].Value = vEntity[QRECEIPTITEMS.QRECEIPT_AMOUNT];
                            editgrid.CurrentCell = editgrid[QRECEIPTITEMS.QUOTATION_AMOUNT, lookupRow];
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
