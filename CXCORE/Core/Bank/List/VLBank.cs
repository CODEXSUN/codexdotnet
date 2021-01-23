// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LBank
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
                        LoadData(CBank_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CBank_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CBank_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CBank_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_bank_name.Text != "")
                    {
                        List<Bank> list = new List<Bank>
                     {
                     CBank_exten.SearchName(txt_bank_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CBank_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CBank_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Bank> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells["SN"].Value = (r + 1);
                row.Cells[BANK.BANK_ID].Value = list[r].Bank_id;
                row.Cells[BANK.BANK_NAME].Value = list[r].Bank_name;
                row.Cells[BANK.ACCOUNT_NUMBER].Value = list[r].Account_number;
                row.Cells[BANK.IFSC_CODE].Value = list[r].Ifsc_code;
                row.Cells[BANK.OPENING_BALANCE].Value = list[r].Opening_balance;
                row.Cells[BANK.NOTES].Value = list[r].Notes;
                row.Cells[BANK.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[BANK.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
