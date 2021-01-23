// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2020 08.01.05 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LContacttype : CxControl
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
                        LoadData(CContacttype_exten.NotActive());
                    }
                    else
                    {
                        LoadData(CContacttype_exten.Active());
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CContacttype_exten.NotActive());
                    }
                    else
                    {
                        LoadData(CContacttype_exten.Active());
                    }

                    break;

                case ListOption.Search:
                    if (txt_contacttype_name.Text != "")
                    {
                        List<Contacttype> list = new List<Contacttype>
                     {
                     CContacttype_exten.SearchName(txt_contacttype_name.Text)
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CContacttype_exten.Active());
                    }
                    break;

                default:
                    LoadData(CContacttype_exten.Active());
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Contacttype> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[CONTACTTYPE.CONTACTTYPE_ID].Value = list[r].Contacttype_id;
                row.Cells[CONTACTTYPE.CONTACTTYPE_NAME].Value = list[r].Contacttype_name;
                row.Cells[CONTACTTYPE.NOTES].Value = list[r].Notes;
                row.Cells[CONTACTTYPE.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[CONTACTTYPE.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
