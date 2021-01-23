// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:23:08 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LUnit
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
                        LoadData(CUnit_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CUnit_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CUnit_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CUnit_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_unit_name.Text != "")
                    {
                        List<Unit> list = new List<Unit>
                     {
                     CUnit_exten.SearchName(txt_unit_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CUnit_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CUnit_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Unit> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[UNIT.UNIT_ID].Value = list[r].Unit_id;
                row.Cells[UNIT.UNIT_NAME].Value = list[r].Unit_name;
                row.Cells[UNIT.UNIT_DESC].Value = list[r].Unit_desc;
                row.Cells[UNIT.NOTES].Value = list[r].Notes;
                row.Cells[UNIT.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[UNIT.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
