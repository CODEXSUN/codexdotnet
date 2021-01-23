// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:51:36 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LLedgergroup
    {
        #region[list Option] 

        public void ListRefresh()
        {
            List_Option(fAction);
        }

        private ListOption fAction = ListOption.active;
        public void List_Option(ListOption pAction)
        {
            fAction = pAction;

            switch (fAction)
            {
                case ListOption.active:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CLedgergroup_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CLedgergroup_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CLedgergroup_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CLedgergroup_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_ledgergroup_name.Text != "")
                    {
                        List<Ledgergroup> list = new List<Ledgergroup>
                     {
                     CLedgergroup_exten.SearchName(txt_ledgergroup_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CLedgergroup_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CLedgergroup_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Ledgergroup> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[LEDGERGROUP.LEDGERGROUP_ID].Value = list[r].Ledgergroup_id;
                row.Cells[LEDGERGROUP.LEDGERGROUP_NAME].Value = list[r].Ledgergroup_name;
                row.Cells[LEDGERGROUP.NOTES].Value = list[r].Notes;
                row.Cells[LEDGERGROUP.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[LEDGERGROUP.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
