// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:15:52 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LState 
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
                        LoadData(CState_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CState_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CState_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CState_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_state_name.Text != "")
                    {
                        List<State> list = new List<State>
                     {
                     CState_exten.SearchName(txt_state_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CState_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CState_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<State> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[STATE.STATE_ID].Value = list[r].State_id;
                row.Cells[STATE.STATE_NAME].Value = list[r].State_name;
                row.Cells[STATE.STATE_CODE].Value = list[r].State_code;
                row.Cells[STATE.NOTES].Value = list[r].Notes;
                row.Cells[STATE.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[STATE.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
