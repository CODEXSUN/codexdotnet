// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:33:13 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LProducttype
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
                        LoadData(CProducttype_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CProducttype_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CProducttype_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CProducttype_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_producttype_name.Text != "")
                    {
                        List<Producttype> list = new List<Producttype>
                     {
                     CProducttype_exten.SearchName(txt_producttype_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CProducttype_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CProducttype_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Producttype> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[PRODUCTTYPE.PRODUCTTYPE_ID].Value = list[r].Producttype_id;
                row.Cells[PRODUCTTYPE.PRODUCTTYPE_NAME].Value = list[r].Producttype_name;
                row.Cells[PRODUCTTYPE.NOTES].Value = list[r].Notes;
                row.Cells[PRODUCTTYPE.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[PRODUCTTYPE.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
