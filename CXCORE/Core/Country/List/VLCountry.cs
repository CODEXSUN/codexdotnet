// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:45:30 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LCountry 
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
                        LoadData(CCountry_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CCountry_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CCountry_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CCountry_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_country_name.Text != "")
                    {
                        List<Country> list = new List<Country>
                     {
                     CCountry_exten.SearchName(txt_country_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CCountry_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CCountry_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Country> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[COUNTRY.COUNTRY_ID].Value = list[r].Country_id;
                row.Cells[COUNTRY.COUNTRY_NAME].Value = list[r].Country_name;
                row.Cells[COUNTRY.NOTES].Value = list[r].Notes;
                row.Cells[COUNTRY.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[COUNTRY.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
