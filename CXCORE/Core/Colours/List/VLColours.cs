// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:38:20 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LColours : UserControl
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
                        LoadData(CColours_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CColours_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CColours_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CColours_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_colours_name.Text != "")
                    {
                        List<Colours> list = new List<Colours>
                     {
                     CColours_exten.SearchName(txt_colours_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CColours_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CColours_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Colours> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[COLOURS.COLOURS_ID].Value = list[r].Colours_id;
                row.Cells[COLOURS.COLOURS_NAME].Value = list[r].Colours_name;
                row.Cells[COLOURS.NOTES].Value = list[r].Notes;
                row.Cells[COLOURS.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[COLOURS.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
