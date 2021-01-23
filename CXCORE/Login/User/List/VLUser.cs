// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:37:39 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LUser 
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
                        LoadData(CUser_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CUser_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CUser_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CUser_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_user_name.Text != "")
                    {
                        List<User> list = new List<User>
                     {
                     CUser_exten.SearchName(txt_user_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CUser_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CUser_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<User> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[USER.USER_ID].Value = list[r].User_id;
                row.Cells[USER.USER_NAME].Value = list[r].User_name;
                row.Cells[USER.USER_PASSWORD].Value = list[r].User_password;
                row.Cells[USER.CREATEON].Value = list[r].Createon;
                row.Cells[USER.ROLE_ID].Value = list[r].Role_id;
                row.Cells[USER.ENTRYBY].Value = list[r].Entryby;
                row.Cells[USER.NOTES].Value = list[r].Notes;
                row.Cells[USER.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[USER.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
