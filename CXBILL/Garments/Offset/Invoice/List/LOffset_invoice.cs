// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:58 PM
// last update : 17-08-2017

using System;
using System.Windows.Forms;
using CXLIB;
using CXCORE;

namespace CXBILL
{
    public partial class LOffset_invoice
    {
        #region[Grid Action]

        void Listgrid_RowAction(object sender, EventArgs e)
        {
            if (listgrid.SelectedRow == null)
            {
                return;
            }
            if (finvoice == null)
            {
                finvoice = new FOffset_Invoice();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                finvoice.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Build Form]

        private void BuildForm()
        {
            if (finvoice == null)
            {
                finvoice = new FOffset_Invoice();
            }
            finvoice.FInvoice_NeedToRefresh += VInvoice_NeedToRefresh;
            Parent.Controls.Add(finvoice);
            finvoice.Dock = DockStyle.Fill;
            finvoice.Show();
            finvoice.BringToFront();

        }

        #endregion[Build Form]

        #region[Radio btn event]

        private void Rdo_unrefer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_unrefer.Checked == true)
            {
                List_Option(ListOption.unrefer);
            }
        }

        private void Rdo_refer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_refer.Checked == true)
            {
                List_Option(ListOption.refer);
            }
        }

        private void Rdo_showall_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_showall.Checked == true)
            {
                List_Option(ListOption.showall);
            }
        }

        private void Rdo_notactive_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_notactive.Checked == true)
            {
                List_Option(ListOption.notactive);
            }
        }

        #endregion[Radio btn event]

        #region[Btn Event]

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            BuildForm();
            finvoice.SetAction(BtnEvent.New, null);
            finvoice.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            string pkValue = GetSelectedPkValue();
            if (COffset_invoice_exten.LockStatus(pkValue) == false)
            {
                BuildForm();
                if (pkValue != null)
                {
                    finvoice.SetAction(BtnEvent.Edit, pkValue);
                    finvoice.SetFocus();
                }
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            string pkValue = GetSelectedPkValue();
            if (COffset_invoice_exten.LockStatus(pkValue) == false)
            {
                BuildForm();
                if (pkValue != null)
                {
                    finvoice.SetAction(BtnEvent.Delete, pkValue);
                    finvoice.SetFocus();
                }
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                finvoice.SetAction(BtnEvent.Print, pkValue);
                finvoice.SetFocus();
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Hide();
            RaiseEvent_NeedToRefresh();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            List_Option(ListOption.Search);
        }

        #endregion[Btn Event]

        #region[text change event]
        private void Txt_datePicker_TextChanged(object sender, EventArgs e)
        {
            txt_date.Text = txt_datePicker.Text;
        }

        private void Txt_TodatePicker_TextChanged(object sender, EventArgs e)
        {
            txt_Todate.Text = txt_TodatePicker.Text;
        }


        #endregion[text change event]

        #region[Enter Event]

        private void Txt_no_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_no.BackColor = XTheme.lbl_EnterBackColor;
            lbl_no.BorderColor = XTheme.lbl_EnterBorderColor;
            lbl_no.ForeColor = XTheme.lbl_EnterForeColor;
        }

        private void Txt_date_Enter(object sender, EventArgs e)
        {
            lbl_date.BackColor = XTheme.lbl_EnterBackColor;
            lbl_date.BorderColor = XTheme.lbl_EnterBorderColor;
            lbl_date.ForeColor = XTheme.lbl_EnterForeColor;
        }

        private void Txt_party_Enter(object sender, EventArgs e)
        {
            lbl_party.BackColor = XTheme.lbl_EnterBackColor;
            lbl_party.BorderColor = XTheme.lbl_EnterBorderColor;
            lbl_party.ForeColor = XTheme.lbl_EnterForeColor;
        }

        private void Change_infocus()
        {

            lbl_no.BackColor = XTheme.lbl_BackColor;
            lbl_no.BorderColor = XTheme.lbl_BorderColor;
            lbl_no.ForeColor = XTheme.lbl_ForeColor;

            lbl_date.BackColor = XTheme.lbl_BackColor;
            lbl_date.BorderColor = XTheme.lbl_BorderColor;
            lbl_date.ForeColor = XTheme.lbl_ForeColor;

            lbl_party.BackColor = XTheme.lbl_BackColor;
            lbl_party.BorderColor = XTheme.lbl_BorderColor;
            lbl_party.ForeColor = XTheme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[No lookup]

        public void No_lookup()
        {
            txt_no.LookupColNames = new string[] { OFFSET_INVOICE.OFFSET_INVOICE_NO };
            txt_no.LookupUpdate += Txt_no_LookupUpdate;
        }
        void Txt_no_LookupUpdate(object sender, EventArgs e)
        {
            txt_no.LookupList = COffset_invoice_exten.LookupNo(new DAL());
        }

        #endregion[No lookup]

        #region[Party lookup]

        public void Party_lookup()
        {
            txt_party.LookupColNames = new string[] { PARTY.PARTY_NAME };
            txt_party.LookupUpdate += Txt_party_LookupUpdate;
        }
        void Txt_party_LookupUpdate(object sender, EventArgs e)
        {
            txt_party.LookupList = COffset_invoice_exten.LookupParty(new DAL());
        }

        #endregion[Party lookup]

        #region[Get selected pk value]

        private string GetSelectedPkValue()
        {
            DataGridViewRow vSelRow = null;
            if (listgrid.SelectedRows != null && listgrid.SelectedRows.Count != 0)
            {
                vSelRow = listgrid.SelectedRows[0];
            }

            string selPkValue = null;
            if (vSelRow != null)
            {
                selPkValue = vSelRow.Cells[OFFSET_INVOICE.OFFSET_INVOICE_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VInvoice_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
