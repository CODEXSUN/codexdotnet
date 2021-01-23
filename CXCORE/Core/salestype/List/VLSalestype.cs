// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:11:06 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LSalestype
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
                        LoadData(CSalestype_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CSalestype_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CSalestype_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CSalestype_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_salestype_name.Text != "")
                    {
                        List<Salestype> list = new List<Salestype>
                     {
                     CSalestype_exten.SearchName(txt_salestype_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CSalestype_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CSalestype_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Salestype> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[SALESTYPE.SALESTYPE_ID].Value = list[r].Salestype_id;
                row.Cells[SALESTYPE.SALESTYPE_NAME].Value = list[r].Salestype_name;
                row.Cells[SALESTYPE.NOTES].Value = list[r].Notes;
                row.Cells[SALESTYPE.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[SALESTYPE.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
