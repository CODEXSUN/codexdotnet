// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 15-06-2019 10:08:59 AM

using System;
using System.Windows.Forms;
using CXLIB;
using CXCORE;

namespace CXERP
{
    public partial class LStyle : CxControl
    {
        #region[Grid Action]

        void Listgrid_RowAction(object sender, EventArgs e)
        {
            if (listgrid.SelectedRow == null)
            {
                return;
            }
            if (fStyle == null)
            {
                fStyle = new FStyle();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fStyle.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Build Form]

        private void BuildForm()
        {
            if (fStyle == null)
            {
                fStyle = new FStyle();
            }
            fStyle.FStyle_NeedToRefresh += VStyle_NeedToRefresh;
            Parent.Controls.Add(fStyle);
            fStyle.Dock = DockStyle.Fill;
            fStyle.Show();
            fStyle.BringToFront();

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
            fStyle.SetAction(BtnEvent.New, null);
            fStyle.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            string pkValue = GetSelectedPkValue();
            BuildForm();
            if (pkValue != null)
            {
                fStyle.SetAction(BtnEvent.Edit, pkValue);
                fStyle.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            string pkValue = GetSelectedPkValue();
            BuildForm();
            if (pkValue != null)
            {
                fStyle.SetAction(BtnEvent.Delete, pkValue);
                fStyle.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fStyle.SetAction(BtnEvent.Print, pkValue);
                fStyle.SetFocus();
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

        //private void Txt_party_Enter(object sender, EventArgs e)
        //{
        //    lbl_party.BackColor = XTheme.lbl_EnterBackColor;
        //    lbl_party.BorderColor = XTheme.lbl_EnterBorderColor;
        //    lbl_party.ForeColor = XTheme.lbl_EnterForeColor;
        //}

        private void Change_infocus()
        {

            lbl_no.BackColor = XTheme.lbl_BackColor;
            lbl_no.BorderColor = XTheme.lbl_BorderColor;
            lbl_no.ForeColor = XTheme.lbl_ForeColor;

            lbl_date.BackColor = XTheme.lbl_BackColor;
            lbl_date.BorderColor = XTheme.lbl_BorderColor;
            lbl_date.ForeColor = XTheme.lbl_ForeColor;

            //lbl_party.BackColor = XTheme.lbl_BackColor;
            //lbl_party.BorderColor = XTheme.lbl_BorderColor;
            //lbl_party.ForeColor = XTheme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[No lookup]

        public void No_lookup()
        {
            txt_no.LookupColNames = new string[] { STYLE.STYLE_NO };
            txt_no.LookupUpdate += Txt_no_LookupUpdate;
        }
        void Txt_no_LookupUpdate(object sender, EventArgs e)
        {
            txt_no.LookupList = CStyle_exten.LookupNo();
        }

        #endregion[No lookup]

        #region[Party lookup]

        //public void Party_lookup()
        //{
        //    txt_party.LookupColNames = new string[] { PARTY.PARTY_NAME };
        //    txt_party.LookupColHeadings = new string[] { "Name" };
        //    txt_party.LookupUpdate += Txt_party_LookupUpdate;
        //}
        //void Txt_party_LookupUpdate(object sender, EventArgs e)
        //{
        //    txt_party.LookupList = CParty_exten.GetforLookup(new DAL());
        //}

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
                selPkValue = vSelRow.Cells[STYLE.STYLE_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VStyle_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
