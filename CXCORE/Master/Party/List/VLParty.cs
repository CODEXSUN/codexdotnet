// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 08:07:53 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LParty
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
                        LoadData(CParty_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CParty_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CParty_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CParty_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_party_name.Text != "")
                    {
                        List<Party> list = new List<Party>
                     {
                     CParty_exten.SearchName(txt_party_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CParty_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CParty_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Party> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells["SN"].Value = (r + 1);
                row.Cells[PARTY.PARTY_ID].Value = list[r].Party_id;
                row.Cells[PARTY.PARTY_NAME].Value = "    " + list[r].Party_name;
                row.Cells[PARTY.CONTACTTYPE_ID].Value = list[r].Contacttype_id;
                row.Cells[PARTY.CONTACT_PERSON].Value = list[r].Contact_person;
                row.Cells[PARTY.STREET_1].Value = list[r].Street_1;
                row.Cells[PARTY.STREET_2].Value = list[r].Street_2;
                row.Cells[PARTY.CITY_ID].Value = list[r].City_id;
                row.Cells[PARTY.STATE_ID].Value = list[r].State_id;
                row.Cells[PARTY.COUNTRY_ID].Value = list[r].Country_id;
                row.Cells[PARTY.PINCODE_ID].Value = list[r].Pincode_id;
                row.Cells[PARTY.PHONE].Value = list[r].Phone;
                row.Cells[PARTY.CELL].Value = list[r].Cell;
                row.Cells[PARTY.EMAIL].Value = list[r].Email;
                row.Cells[PARTY.WEBSITE].Value = list[r].Website;
                row.Cells[PARTY.GSTIN].Value = list[r].Gstin;
                row.Cells[PARTY.PAN].Value = list[r].Pan;
                row.Cells[PARTY.OPENING_BALANCE].Value = list[r].Opening_balance;
                row.Cells[PARTY.CREDIT_DAYS].Value = list[r].Credit_days;
                row.Cells[PARTY.NOTES].Value = list[r].Notes;
                row.Cells[PARTY.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[PARTY.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
