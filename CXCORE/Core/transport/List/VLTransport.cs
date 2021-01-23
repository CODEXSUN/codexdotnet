// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:22:56 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LTransport : UserControl
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
                        LoadData(CTransport_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CTransport_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CTransport_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CTransport_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_transport_name.Text != "")
                    {
                        List<Transport> list = new List<Transport>
                     {
                     CTransport_exten.SearchName(txt_transport_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CTransport_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CTransport_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Transport> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[TRANSPORT.TRANSPORT_ID].Value = list[r].Transport_id;
                row.Cells[TRANSPORT.TRANSPORT_NAME].Value = list[r].Transport_name;
                row.Cells[TRANSPORT.NOTES].Value = list[r].Notes;
                row.Cells[TRANSPORT.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[TRANSPORT.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
