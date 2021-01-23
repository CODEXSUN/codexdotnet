// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:22:51 AM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace CXCORE
{
    public partial class LTaxtype
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
                        LoadData(CTaxtype_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CTaxtype_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CTaxtype_exten.NotActive(new DAL()));
                    }
                    else
                    {
                        LoadData(CTaxtype_exten.Active(new DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_taxtype_name.Text != "")
                    {
                        List<Taxtype> list = new List<Taxtype>
                     {
                     CTaxtype_exten.SearchName(txt_taxtype_name.Text, new DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CTaxtype_exten.Active(new DAL()));
                    }
                    break;

                default:
                    LoadData(CTaxtype_exten.Active(new DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Taxtype> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[TAXTYPE.TAXTYPE_ID].Value = list[r].Taxtype_id;
                row.Cells[TAXTYPE.TAXTYPE_NAME].Value = list[r].Taxtype_name;
                row.Cells[TAXTYPE.NOTES].Value = list[r].Notes;
                row.Cells[TAXTYPE.ACTIVE_ID].Value = list[r].Active_id;
                row.Cells[TAXTYPE.USER_ID].Value = list[r].User_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
