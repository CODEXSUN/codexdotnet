// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:15:23 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LSizes : UserControl
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
                        LoadData(CSizes_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CSizes_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CSizes_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CSizes_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_sizes_name.Text != "")
                    {
                        List<Sizes> list = new List<Sizes>
                     {
                     CSizes_exten.SearchName(txt_sizes_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CSizes_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CSizes_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Sizes> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[SIZES.SIZES_ID].Value = list[r].Sizes_id;
                row.Cells[SIZES.SIZES_NAME].Value = list[r].Sizes_name;
                row.Cells[SIZES.NOTES].Value = list[r].Notes;
                row.Cells[SIZES.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[SIZES.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
