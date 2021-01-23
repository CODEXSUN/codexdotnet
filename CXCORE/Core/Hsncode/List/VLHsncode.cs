// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:41:08 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LHsncode
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
                        LoadData(CHsncode_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CHsncode_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CHsncode_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CHsncode_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_hsncode_name.Text != "")
                    {
                        List<Hsncode> list = new List<Hsncode>
                     {
                     CHsncode_exten.SearchName(txt_hsncode_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CHsncode_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CHsncode_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Hsncode> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[HSNCODE.HSNCODE_ID].Value = list[r].Hsncode_id;
                row.Cells[HSNCODE.HSNCODE_NAME].Value = list[r].Hsncode_name;
                row.Cells[HSNCODE.DESCRIPTION].Value = list[r].Description;
                row.Cells[HSNCODE.NOTES].Value = list[r].Notes;
                row.Cells[HSNCODE.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[HSNCODE.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
