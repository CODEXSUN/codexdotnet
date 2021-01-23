using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SForm_exten
    {
        public static void XForm_exten(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.SPath.Formfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);
            File.WriteAllText(@"" + vpath + "\\F" + tbl_name + "_exten.cs", result);
        }

        #region []

        private static string XCreate(BillTable obj)
        {
            List<SFields> list = obj.SFields;

            string vtablesname = obj.STables.Stables_name;

            string vnamespaces = obj.STables.Namespaces_id;

            string TABLENAME = vtablesname.ToUpper();

            string TRIM_TBL = vtablesname.Remove(vtablesname.Length - 4);

            string CAPITAL = cCultureInfo.toUpperCase(TRIM_TBL);
            string SMALL = cCultureInfo.toLowerCase(TRIM_TBL);
            string UPPERFIRST = ChangeCase.UpperFirst(SMALL);
            string ___result = "";

            //string xDAL = "DAL";

            #endregion []

            #region [Conclusion]

            ___result += "// " + CVersion_exten.Get_Current_Version() + "\r\n";
            ___result += "// Auto Generated\r\n";
            ___result += "// " + DateTime.Now + "\r\n";
            ___result += "// last update : " + DateTime.Now.ToString("dd-MM-yyyy") + "\r\n";
            ___result += "\r\n";

            #endregion [Conclusion]

            #region[using]

            ___result += "using System;\r\n";
            //___result += "using System.ComponentModel;\r\n";
            //___result += "using System.Collections.Generic;\r\n";
            ___result += "using System.Drawing;\r\n";
            ___result += "using System.Windows.Forms;\r\n";
            ___result += "using CXLIB;\r\n";
            ___result += "using CXCORE;\r\n";
            ___result += "\r\n";

            #endregion[using]

            #region[namespace]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{\r\n";
            ___result += "    public partial class F" + UPPERFIRST + " : UserControl\r\n";
            ___result += "    {\r\n";

            #endregion[namespace]

            #region[Grid Event]

            ___result += "        #region[Grid Event]\r\n";
            ___result += "\r\n";
            ___result += "        void Editgrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            CalcTotals();\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        void Editgrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            if (e.FormattedValue + \"\" == \"\")\r\n";
            ___result += "            {\r\n";
            ___result += "                return;\r\n";
            ___result += "            }\r\n";
            ___result += "            string vColName = editgrid.Columns[e.ColumnIndex].Name;\r\n";
            ___result += "            switch (vColName)\r\n";
            ___result += "            {\r\n";
            ___result += "                case " + CAPITAL + "ITEMS.QTY:\r\n";
            ___result += "                    decimal newDecimal;\r\n";
            ___result += "                    if (decimal.TryParse(e.FormattedValue.ToString(), out newDecimal) == false || newDecimal < 0)\r\n";
            ___result += "                    {\r\n";
            ___result += "                        MessageBox.Show(this.FindForm(), \"The value must be an number.\", \"Number Check...\", MessageBoxButtons.OK, MessageBoxIcon.Information);\r\n";
            ___result += "                        editgrid.CancelEdit();\r\n";
            ___result += "                        e.Cancel = true;\r\n";
            ___result += "                    }\r\n";
            ___result += "                    break;\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        void Editgrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            string vColName = editgrid.Columns[e.ColumnIndex].Name;\r\n";
            ___result += "            if (vColName != Core.SLNO && editgrid[Core.SLNO, e.RowIndex].Value + \"\" != \"*\")\r\n";
            ___result += "            {\r\n";
            ___result += "                for (int r = 0; r < editgrid.RowCount; r++)\r\n";
            ___result += "                {\r\n";
            ___result += "                    DataGridViewRow row = editgrid.Rows[r];\r\n";
            ___result += "                    row.Cells[Core.SLNO].Value = \" \" + (r + 1) + \"\";\r\n";
            ___result += "                    CalcTotals();\r\n";
            ___result += "                }\r\n";
            ___result += "            }\r\n";
            ___result += "            switch (vColName)\r\n";
            ___result += "            {\r\n";
            ___result += "                case " + CAPITAL + "ITEMS.QTY:\r\n";
            if (obj.STables.Stables_id != "2")
            {
                ___result += "                    CalcAmount(e.RowIndex);\r\n";
            }
            ___result += "                    CalcTotals();\r\n";
            ___result += "                    break;\r\n";
            if (obj.STables.Stables_id != "2")
            {
                ___result += "                case " + CAPITAL + "ITEMS.PRICE:\r\n";
                ___result += "                    CalcAmount(e.RowIndex);\r\n";
                ___result += "                    CalcTotals();\r\n";
                ___result += "                    break;\r\n";
            }
            ___result += "            }\r\n";
            ___result += "\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        void Editgrid_CurrentCellChanged(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            if (editgrid.Focused == false)\r\n";
            ___result += "            {\r\n";
            ___result += "                return;\r\n";
            ___result += "            }\r\n";
            ___result += "            if (editgrid.ReadOnly == true)\r\n";
            ___result += "            {\r\n";
            ___result += "                return;\r\n";
            ___result += "            }\r\n";
            ___result += "            if (editgrid.CurrentCell != null)\r\n";
            ___result += "            {\r\n";
            ___result += "                lookupRow = editgrid.CurrentCell.RowIndex;\r\n";
            ___result += "                lookupCol = editgrid.CurrentCell.ColumnIndex;\r\n";
            ___result += "                lookupColName = editgrid.Columns[lookupCol].Name;\r\n";
            ___result += "\r\n";
            ___result += "                switch (lookupColName)\r\n";
            ___result += "                {\r\n";
            ___result += "                    case " + CAPITAL + "ITEMS.PRODUCT_ID:\r\n";
            ___result += "                        ShowLookupForm();\r\n";
            ___result += "                        break;\r\n";
            ___result += "                }\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Grid Event]\r\n";
            ___result += "\r\n";

            #endregion[Grid Event]

            #region[Calc Total]

            ___result += "        #region[Calc Total]\r\n";

            if (obj.STables.Stables_id != "2")
            {
                ___result += "\r\n";
                ___result += "        private void CalcAmount(int pRowIndex)\r\n";
                ___result += "        {\r\n";
                ___result += "            decimal vQty = Global.ToDecimal(editgrid[" + CAPITAL + "ITEMS.QTY, pRowIndex].Value);\r\n";
                ___result += "            decimal vPrice = Global.ToDecimal(editgrid[" + CAPITAL + "ITEMS.PRICE, pRowIndex].Value);\r\n";
                ___result += "            decimal vAmount = vQty * vPrice;\r\n";
                ___result += "            editgrid[" + CAPITAL + "ITEMS.SUB_TOTAL , pRowIndex].Value = ConvertTO.Decimal2d(vAmount.ToString());\r\n";
                ___result += "        }\r\n";
                ___result += "\r\n";
            }
            ___result += "        private void CalcTotals()\r\n";
            ___result += "        {\r\n";
            ___result += "            decimal vTotQty = 0M;\r\n";
            if (obj.STables.Stables_id != "2")
            {
                ___result += "            decimal vSubTotal = 0M;\r\n";
            }
            ___result += "            for (int r = 0; r <= editgrid.Rows.Count - 1; r++)\r\n";
            ___result += "            {\r\n";
            ___result += "                decimal vQty = Global.ToDecimal(editgrid[" + CAPITAL + "ITEMS.QTY, r].Value);\r\n";
            ___result += "                vTotQty += vQty;\r\n";
            if (obj.STables.Stables_id != "2")
            {
                ___result += "                decimal vTotal = Global.ToDecimal(editgrid[" + CAPITAL + "ITEMS.SUB_TOTAL, r].Value);\r\n";
                ___result += "                vSubTotal += vTotal;\r\n";
            }
            ___result += "            }\r\n";
            ___result += "            //\r\n";
            ___result += "            txt_total_qty.Text = vTotQty.ToString();\r\n";
            if (obj.STables.Stables_id != "2")
            {
                ___result += "            txt_total_amount.Text = vSubTotal.ToString();\r\n";
            }
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Calc Total]\r\n";
            ___result += "\r\n";

            #endregion[Calc Total]

            #region[Look up]

            ___result += "        #region[Look up]\r\n";
            ___result += "\r\n";
            ___result += "        private int lookupRow;\r\n";
            ___result += "        private int lookupCol;\r\n";
            ___result += "        private string lookupColName;\r\n";
            ___result += "        private LookupForm frmLookup;\r\n";
            ___result += "        public void ShowLookupForm()\r\n";
            ___result += "        {\r\n";
            ___result += "            FrmLookup_LookupHide(null, null);\r\n";
            ___result += "\r\n";
            ___result += "            frmLookup = new LookupForm();\r\n";
            ___result += "\r\n";
            ___result += "            switch (lookupColName)\r\n";
            ___result += "            {\r\n";
            ___result += "\r\n";
            ___result += "                case " + CAPITAL + "ITEMS.PRODUCT_ID:\r\n";
            ___result += "                    {\r\n";
            ___result += "                        frmLookup.LookupColNames = new string[] { PRODUCT.PRODUCT_NAME };\r\n";
            ___result += "                        frmLookup.SelectedPkValue = editgrid[" + CAPITAL + "ITEMS.PRODUCT_ID, lookupRow].Value;\r\n";
            ___result += "                        frmLookup.AllowNewEntry = true;\r\n";
            ___result += "                        frmLookup.AllowEmptySelection = true;\r\n";
            ___result += "                     \r\n";
            ___result += "                        if (txt_party_id.Text != \"\")\r\n";
            ___result += "                        {\r\n";
            ___result += "                            frmLookup.LookupList = CProduct_exten.GetforLookup(new DAL());\r\n";
            ___result += "                            frmLookup.LoadLookupList();\r\n";
            ___result += "                        }\r\n";
            ___result += "                    }\r\n";
            ___result += "                    break;\r\n";
            ___result += "\r\n";
            ___result += "                default:\r\n";
            ___result += "                    throw new System.Exception(\"'\" + lookupColName + \"' Not Found\");\r\n";
            ___result += "            }\r\n";
            ___result += "            frmLookup.LookupSelected += new EventHandler(FrmLookup_LookupSelected);\r\n";
            ___result += "            frmLookup.AfterSelection += new EventHandler(FrmLookup_AfterSelection);\r\n";
            ___result += "            frmLookup.LookupHide += new EventHandler(FrmLookup_LookupHide);\r\n";
            ___result += "            frmLookup.NewEntryNeeded += new LookupForm.NewEntryHandler(FrmLookup_NewEntryNeeded);\r\n";
            ___result += "            frmLookup.Owner = this.FindForm();\r\n";
            ___result += "            //////////\r\n";
            ___result += "            frmLookup.Show();\r\n";
            ___result += "            //////////\r\n";
            ___result += "            int vWidth = frmLookup.GetAutoWidth();\r\n";
            ___result += "            int vCellWidth = editgrid.Columns[lookupColName].Width;\r\n";
            ___result += "            if (vWidth < vCellWidth) vWidth = vCellWidth;\r\n";
            ___result += "            frmLookup.AutoFillLastColumn();\r\n";
            ___result += "\r\n";
            ___result += "            int vHeight = frmLookup.GetAutoHeight();\r\n";
            ___result += "\r\n";
            ___result += "            Rectangle screenRect = Global.GetScreenRect(editgrid);\r\n";
            ___result += "            frmLookup.Bounds = Global.GetSnapRect(screenRect, vWidth, vHeight);\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        void FrmLookup_LookupSelected(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            System.Data.DataRow vEntity = frmLookup.SelectedEntity;\r\n";
            ___result += "\r\n";
            ___result += "            switch (lookupColName)\r\n";
            ___result += "            {\r\n";
            ___result += "                case " + CAPITAL + "ITEMS.PRODUCT_ID:\r\n";
            ___result += "                    if (vEntity == null)\r\n";
            ___result += "                    {\r\n";
            ___result += "                        editgrid[" + CAPITAL + "ITEMS.PRODUCT_ID, lookupRow].Value = \"\";\r\n";
            ___result += "                    }\r\n";
            ___result += "                    else\r\n";
            ___result += "                    {\r\n";
            ___result += "                        editgrid[" + CAPITAL + "ITEMS.PRODUCT_ID, lookupRow].Value = vEntity[PRODUCT.PRODUCT_NAME];\r\n";
            ___result += "                    }\r\n";
            ___result += "                    break;\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        void FrmLookup_AfterSelection(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            editgrid.FocusNextCell();\r\n";
            ___result += "        }\r\n";
            ___result += "        void FrmLookup_LookupHide(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            Application.DoEvents();\r\n";
            ___result += "            Application.DoEvents();\r\n";
            ___result += "            if (frmLookup != null)\r\n";
            ___result += "            {\r\n";
            ___result += "                frmLookup.Dispose();\r\n";
            ___result += "                frmLookup = null;\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        void FrmLookup_NewEntryNeeded(object sender, string pValue)\r\n";
            ___result += "        {\r\n";
            ___result += "            switch (lookupColName)\r\n";
            ___result += "            {\r\n";
            ___result += "                case " + CAPITAL + "ITEMS.PRODUCT_ID:\r\n";
            ___result += "                    FproductNewEntry(pValue);\r\n";
            ___result += "                    break;\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Look up]\r\n";
            ___result += "\r\n";

            #endregion[Look up]

            #region [New Entry]

            ___result += "        #region [New Entry]\r\n";
            ___result += "\r\n";
            ___result += "        private FProduct xproduct = null;\r\n";
            ___result += "        void FproductNewEntry(string pValue)\r\n";
            ___result += "        {\r\n";
            ___result += "            if (xproduct == null)\r\n";
            ___result += "            {\r\n";
            ___result += "                xproduct = new FProduct();\r\n";
            ___result += "                xproduct.FProduct_NeedToRefresh += Xproduct_refresh;\r\n";
            ___result += "            }\r\n";
            ___result += "            this.Parent.Controls.Add(xproduct);\r\n";
            ___result += "            xproduct.Dock = DockStyle.Fill;\r\n";
            ___result += "            xproduct.Show();\r\n";
            ___result += "            xproduct.BringToFront();\r\n";
            ___result += "            xproduct.Focus();\r\n";
            ___result += "            xproduct.SetAction(BtnEvent.New, null);\r\n";
            ___result += "            xproduct.SetFocus();\r\n";
            ___result += "            xproduct.setname(pValue);\r\n";
            ___result += "        }\r\n";
            ___result += "        private void Xproduct_refresh(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            editgrid[" + CAPITAL + "ITEMS.PRODUCT_ID, lookupRow].Value = xproduct.GetName();\r\n";
            ___result += "            editgrid.Focus();\r\n";
            ___result += "            editgrid.CurrentCell = editgrid[" + CAPITAL + "ITEMS.QTY, lookupRow];\r\n";
            ___result += "\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion [New Entry]\r\n";
            ___result += "\r\n";

            #endregion [New Entry]

            #region[result]

            ___result += "}//cls\r\n";
            ___result += "}//ns\r\n";

            return ___result;

            #endregion[result]

        }

    }//cls
}//ns