// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:28:28 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LBundle : UserControl
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
                        LoadData(CBundle_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CBundle_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CBundle_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CBundle_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_bundle_name.Text != "")
                    {
                        List<Bundle> list = new List<Bundle>
                     {
                     CBundle_exten.SearchName(txt_bundle_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CBundle_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CBundle_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Bundle> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[BUNDLE.BUNDLE_ID].Value = list[r].Bundle_id;
                row.Cells[BUNDLE.BUNDLE_NAME].Value = list[r].Bundle_name;
                row.Cells[BUNDLE.NOTES].Value = list[r].Notes;
                row.Cells[BUNDLE.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[BUNDLE.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
