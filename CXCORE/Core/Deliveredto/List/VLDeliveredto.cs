// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:46:35 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LDeliveredto : UserControl
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
                        LoadData(CDeliveredto_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CDeliveredto_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CDeliveredto_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CDeliveredto_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_deliveredto_name.Text != "")
                    {
                        List<Deliveredto> list = new List<Deliveredto>
                     {
                     CDeliveredto_exten.SearchName(txt_deliveredto_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CDeliveredto_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CDeliveredto_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Deliveredto> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[DELIVEREDTO.DELIVEREDTO_ID].Value = list[r].Deliveredto_id;
                row.Cells[DELIVEREDTO.DELIVEREDTO_NAME].Value = list[r].Deliveredto_name;
                row.Cells[DELIVEREDTO.NOTES].Value = list[r].Notes;
                row.Cells[DELIVEREDTO.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[DELIVEREDTO.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
