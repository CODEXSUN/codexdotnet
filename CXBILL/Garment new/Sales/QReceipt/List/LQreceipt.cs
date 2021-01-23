// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:15 AM
// last update : 13-03-2018

using System;
using System.Windows.Forms;
using CXLIB;
using CXCORE;

namespace CXBILL
{
    public partial class LQreceipt 
    {
        #region[Grid Action]

        void Listgrid_RowAction(object sender, EventArgs e)
        {
            if (listgrid.SelectedRow == null)
            {
                return;
            }
            if (freceipt == null)
            {
                freceipt = new FQreceipt();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                freceipt.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Build Form]

        private void BuildForm()
        {
            if (freceipt == null)
            {
                freceipt = new FQreceipt();
            }
            freceipt.FReceipt_NeedToRefresh += VReceipt_NeedToRefresh;
            Parent.Controls.Add(freceipt);
            freceipt.Dock = DockStyle.Fill;
            freceipt.Show();
            freceipt.BringToFront();

        }

        #endregion[Build Form]

        #region[Radio btn event]

        //private void Rdo_unrefer_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdo_unrefer.Checked == true)
        //    {
        //        List_Option(ListOption.unrefer);
        //    }
        //}

        //private void Rdo_refer_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdo_refer.Checked == true)
        //    {
        //        List_Option(ListOption.refer);
        //    }
        //}

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
            freceipt.SetAction(BtnEvent.New, null);
            freceipt.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            string pkValue = GetSelectedPkValue();
            BuildForm();
            if (pkValue != null)
            {
                freceipt.SetAction(BtnEvent.Edit, pkValue);
                freceipt.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            string pkValue = GetSelectedPkValue();
            BuildForm();
            if (pkValue != null)
            {
                freceipt.SetAction(BtnEvent.Delete, pkValue);
                freceipt.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                freceipt.SetAction(BtnEvent.Print, pkValue);
                freceipt.SetFocus();
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
            txt_no.LookupColNames = new string[] { QRECEIPT.QRECEIPT_NO };
            txt_no.LookupUpdate += Txt_no_LookupUpdate;
        }
        void Txt_no_LookupUpdate(object sender, EventArgs e)
        {
            txt_no.LookupList = CQreceipt_exten.LookupNo(new DAL());
        }

        #endregion[No lookup]

        #region[Date lookup]

        public void Date_lookup()
        {
            txt_date.LookupColNames = new string[] { QRECEIPT.QRECEIPT_DATE };
            txt_date.LookupUpdate += Txt_date_LookupUpdate;
        }
        void Txt_date_LookupUpdate(object sender, EventArgs e)
        {
            txt_date.LookupList = CQreceipt_exten.LookupDate(new DAL());
        }

        #endregion[Date lookup]

        #region[Party lookup]

        public void Party_lookup()
        {
            txt_party.LookupColNames = new string[] { PARTY.PARTY_NAME };
            txt_party.LookupUpdate += Txt_party_LookupUpdate;
        }
        void Txt_party_LookupUpdate(object sender, EventArgs e)
        {
            txt_party.LookupList = CQreceipt_exten.LookupParty(new DAL());
        }

        #endregion[Date lookup]

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
                selPkValue = vSelRow.Cells[QRECEIPT.QRECEIPT_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VReceipt_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.showall);
        }
        //public event EventHandler LQreceipt_NeedToRefresh;
        //public void RaiseEvent_NeedToRefresh()
        //{
        //    if (LQreceipt_NeedToRefresh != null)
        //    {
        //        LQreceipt_NeedToRefresh(this, new EventArgs());
        //    }
        //}

        #endregion[RaiseEvent]

    }//cls
}//ns
