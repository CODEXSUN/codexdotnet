// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:55:36 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LLedger
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
                        LoadData(CLedger_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CLedger_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CLedger_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CLedger_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_ledger_name.Text != "")
                    {
                        List<Ledger> list = new List<Ledger>
                     {
                     CLedger_exten.SearchName(txt_ledger_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CLedger_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CLedger_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Ledger> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[LEDGER.LEDGER_ID].Value = list[r].Ledger_id;
                row.Cells[LEDGER.LEDGER_NAME].Value = list[r].Ledger_name;
                row.Cells[LEDGER.LEDGERGROUP_ID].Value = list[r].Ledgergroup_id;
                row.Cells[LEDGER.NOTES].Value = list[r].Notes;
                row.Cells[LEDGER.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[LEDGER.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
