// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 05-12-2018 09:57:54 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace AXCODE
{
    public partial class LMastertables : UserControl
    {
        #region[list Option]

        public void ListRefresh()
        {
            List_Option(fAction);
        }

        private ListOption fAction = ListOption.showall;
        public void List_Option(ListOption pAction)
        {
            fAction = pAction;

            switch (fAction)
            {

                case ListOption.notactive:

                    if (rdo_notactive.Checked == true)
                    {
                        LoadData(CMtables_exten.NotActive(new SQLITE_DAL()));
                    }
                    else
                    {
                        LoadData(CMtables_exten.Active(new SQLITE_DAL()));
                    }

                    break;

                case ListOption.Search:
                    LoadData(CMtables_exten.Searchby(txt_database.Text, txt_mtables.Text));
                    break;

                default:
                    LoadData(CMtables_exten.Active(new SQLITE_DAL()));
                    break;
            }
        }

        #endregion[list Option]

        #region[Load Data]

        public void LoadData(List<MasterTables> list)
        {
            if (constructed_flag == false)
            {
                return;
            }

            listgrid.SuspendLayout();

            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[MASTERTABLES.MASTERTABLES_ID].Value = list[r].Mastertables_id;
                row.Cells[MASTERTABLES.DATABASES_ID].Value = list[r].Databases_id;
                row.Cells[MASTERTABLES.MASTERTABLES_NAME].Value = list[r].Mastertables_name;
                row.Cells[MASTERTABLES.ALIAS].Value = list[r].Alias;
                row.Cells[MASTERTABLES.NAMESPACES_ID].Value = list[r].Namespaces_id;
            }
            listgrid.ResumeLayout(true);

            listgrid.Refresh();
            if (listgrid.RowCount != 0)
            {
                listgrid.CurrentCell = listgrid[MASTERTABLES.MASTERTABLES_NAME, listgrid.RowCount - 1];
            }
        }

        #endregion[Load Data]


    }//cls
}//ns
