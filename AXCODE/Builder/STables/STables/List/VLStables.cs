using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace AXCODE
{
    public partial class LStables : UserControl
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

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CStables_exten.NotActive(new SQLITE_DAL()));
                    }
                    else
                    {
                        LoadData(CStables_exten.Active(new SQLITE_DAL()));
                    }

                    break;

                case ListOption.Search:
                    LoadData(CStables_exten.Searchby(txt_database.Text, txt_mtables.Text));
                    break;

                default:
                    LoadData(CStables_exten.Active(new SQLITE_DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Stables> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[STABLES.STABLES_ID].Value = list[r].Stables_id;
                row.Cells[STABLES.DATABASES_ID].Value = list[r].Databases_id;
                row.Cells[STABLES.STABLES_NAME].Value = list[r].Stables_name;
                row.Cells[STABLES.NAMESPACES_ID].Value = list[r].Namespaces_id;
                row.Cells[STABLES.ACTIVE_ID].Value = list[r].Active_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
