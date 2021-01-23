// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:24:05 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CodexsunLib;
using System;

namespace CodexsunCore
{
    public partial class LVoucher : UserControl
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
                        LoadData(CVoucher_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CVoucher_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CVoucher_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CVoucher_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:

                    List<Voucher> list =
                     CVoucher_exten.Searchfilter(
                      txt_voucher_no.Text
                      , txt_voucher_no_1.Text
                      , txt_voucher_date.Text
                     , txt_voucher_date_1.Text
                     , CVouchertype_exten.GetId_Name(txt_vouchertype.Text)
                     , COrder_exten.GetId_Name(txt_orderref.Text)
                     , CLedger_exten.GetId_Name(txt_ledger.Text)
                     , CParty_exten.GetId_Name(txt_party.Text)
                     , txt_purpose.Text
                     , new DAL());

                    LoadData(list);

                    break;

                default:
                    LoadData(CVoucher_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 
        private decimal dr; private decimal cr;
        public void LoadData(List<Voucher> list)
        {
           

            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[VOUCHER.VOUCHER_ID].Value = list[r].Voucher_id;
                row.Cells[VOUCHER.VOUCHER_NO].Value = list[r].Voucher_no;
                row.Cells[VOUCHER.VOUCHER_DATE].Value = ConvertTO.Date2S(list[r].Voucher_date);
                row.Cells[VOUCHER.VOUCHERTYPE_ID].Value = list[r].Vouchertype_id;
                row.Cells[VOUCHER.ORDER_ID].Value = list[r].Order_id;
                row.Cells[VOUCHER.LEDGER_ID].Value = list[r].Ledger_id;
                row.Cells[VOUCHER.PARTY_ID].Value = list[r].Party_id;
                row.Cells[VOUCHER.PURPOSE].Value = list[r].Purpose;

                row.Cells[VOUCHER.DEBIT].Value = list[r].Debit;

                dr += Convert.ToDecimal(list[r].Debit);

                row.Cells[VOUCHER.CREDIT].Value = list[r].Credit;

                cr += Convert.ToDecimal(list[r].Credit);

                row.Cells[VOUCHER.NOTES].Value = list[r].Notes;
                row.Cells[VOUCHER.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[VOUCHER.USER_ID].Value = list[r].User_id;
            }

            txt_debit.Text = dr.ToString();
            txt_credit.Text = cr.ToString();
            txt_balance.Text = (dr - cr).ToString();
            dr = 0;cr = 0;
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
