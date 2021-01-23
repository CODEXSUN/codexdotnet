// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:07:41 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LReceipttype : UserControl
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
                        LoadData(CReceipttype_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CReceipttype_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CReceipttype_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CReceipttype_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_receipttype_name.Text != "")
                    {
                        List<Receipttype> list = new List<Receipttype>
                     {
                     CReceipttype_exten.SearchName(txt_receipttype_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CReceipttype_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CReceipttype_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Receipttype> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[RECEIPTTYPE.RECEIPTTYPE_ID].Value = list[r].Receipttype_id;
                row.Cells[RECEIPTTYPE.RECEIPTTYPE_NAME].Value = list[r].Receipttype_name;
                row.Cells[RECEIPTTYPE.NOTES].Value = list[r].Notes;
                row.Cells[RECEIPTTYPE.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[RECEIPTTYPE.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
