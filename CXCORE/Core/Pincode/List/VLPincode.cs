// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 09:06:46 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LPincode 
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
                        LoadData(CPincode_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CPincode_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CPincode_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CPincode_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_pincode_name.Text != "")
                    {
                        List<Pincode> list = new List<Pincode>
                     {
                     CPincode_exten.SearchName(txt_pincode_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CPincode_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CPincode_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Pincode> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[PINCODE.PINCODE_ID].Value = list[r].Pincode_id;
                row.Cells[PINCODE.PINCODE_NAME].Value = list[r].Pincode_name;
                row.Cells[PINCODE.NOTES].Value = list[r].Notes;
                row.Cells[PINCODE.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[PINCODE.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
