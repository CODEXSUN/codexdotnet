// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 05-12-2018 09:57:54 PM

using System;
using System.Windows.Forms;
using CXLIB;

namespace AXCODE
{
    public partial class LMastertables : UserControl
    {
        #region[Grid Action]

        void Listgrid_RowAction(object sender, EventArgs e)
        {
            if (listgrid.SelectedRow == null)
            {
                return;
            }
            if (fmtables == null)
            {
                fmtables = new FMtables();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fmtables.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Build Form]

        private void BuildForm()
        {
            if (fmtables == null)
            {
                fmtables = new FMtables();
            }
             fmtables.FMtables_NeedToRefresh += VMtables_NeedToRefresh;
            Parent.Controls.Add(fmtables);
            fmtables.Dock = DockStyle.Fill;
            fmtables.Show();
            fmtables.BringToFront();

        }

        #endregion[Build Form]

        #region[Radio btn event]


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
            fmtables.SetAction(BtnEvent.New, null);
            fmtables.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            string pkValue = GetSelectedPkValue();
            BuildForm();
            if (pkValue != null)
            {
                fmtables.SetAction(BtnEvent.Edit, pkValue);
                fmtables.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            string pkValue = GetSelectedPkValue();
            BuildForm();
            if (pkValue != null)
            {
                fmtables.SetAction(BtnEvent.Delete, pkValue);
                fmtables.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fmtables.SetAction(BtnEvent.Print, pkValue);
                fmtables.SetFocus();
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


        private void Btn_generate_Click(object sender, EventArgs e)
        {
            MTablesScript.MRun(Convert.ToInt32(""+CMtables_exten.GetId_Name(txt_mtables.Text)));

            MessageBox.Show("Sucess!");

        }

        #endregion[Btn Event]

        #region[Enter Event]

        private void Txt_no_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_database.BackColor = XTheme.lbl_EnterBackColor;
            lbl_database.BorderColor = XTheme.lbl_EnterBorderColor;
            lbl_database.ForeColor = XTheme.lbl_EnterForeColor;
        }


        private void Txt_party_Enter(object sender, EventArgs e)
        {
            lbl_mtables.BackColor = XTheme.lbl_EnterBackColor;
            lbl_mtables.BorderColor = XTheme.lbl_EnterBorderColor;
            lbl_mtables.ForeColor = XTheme.lbl_EnterForeColor;
        }

        private void Change_infocus()
        {

            lbl_database.BackColor = XTheme.lbl_BackColor;
            lbl_database.BorderColor = XTheme.lbl_BorderColor;
            lbl_database.ForeColor = XTheme.lbl_ForeColor;

            lbl_mtables.BackColor = XTheme.lbl_BackColor;
            lbl_mtables.BorderColor = XTheme.lbl_BorderColor;
            lbl_mtables.ForeColor = XTheme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[No lookup]

        public void No_lookup()
        {
            txt_database.LookupColNames = new string[] { DATABASES.DATABASES_NAME };
            txt_database.LookupUpdate += Txt_no_LookupUpdate;
        }
        void Txt_no_LookupUpdate(object sender, EventArgs e)
        {
            txt_database.LookupList = CDatabases_exten.GetforLookup();
        }

        #endregion[No lookup]

        #region[Party lookup]

        public void Party_lookup()
        {
            txt_mtables.LookupColNames = new string[] { MASTERTABLES.MASTERTABLES_NAME };
            txt_mtables.LookupUpdate += Txt_party_LookupUpdate;
        }
        void Txt_party_LookupUpdate(object sender, EventArgs e)
        {
            txt_mtables.LookupList = CMtables_exten.GetforLookup(new SQLITE_DAL());
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
                selPkValue = vSelRow.Cells[MASTERTABLES.MASTERTABLES_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VMtables_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }
        public event EventHandler LMtables_NeedToRefresh;
        public void RaiseEvent_NeedToRefresh()
        {
            LMtables_NeedToRefresh?.Invoke(this, new EventArgs());
        }

        #endregion[RaiseEvent]

    }//cls
}//ns
