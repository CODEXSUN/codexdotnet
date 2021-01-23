// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:34:52 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LRole : UserControl
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
                        LoadData(CRole_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CRole_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CRole_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CRole_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_role_name.Text != "")
                    {
                        List<Role> list = new List<Role>
                     {
                     CRole_exten.SearchName(txt_role_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CRole_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CRole_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Role> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[ROLE.ROLE_ID].Value = list[r].Role_id;
                row.Cells[ROLE.ROLE_NAME].Value = list[r].Role_name;
                row.Cells[ROLE.NOTES].Value = list[r].Notes;
                row.Cells[ROLE.ACTIVE_ID].Value = list[r].Active_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
