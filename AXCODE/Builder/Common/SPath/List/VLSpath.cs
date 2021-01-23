// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 06-12-2018 10:53:54 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace AXCODE
{
    public partial class LSpath : UserControl
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
                        LoadData(CSpath_exten.NotActive(new SQLITE_DAL()));
                    }
                    else
                    {
                        LoadData(CSpath_exten.Active(new SQLITE_DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CSpath_exten.NotActive(new SQLITE_DAL()));
                    }
                    else
                    {
                        LoadData(CSpath_exten.Active(new SQLITE_DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_mtables_id.Text != "")
                    {
                        List<Spath> list = new List<Spath>
                     {
                     CSpath_exten.SearchName(txt_mtables_id.Text, new SQLITE_DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CSpath_exten.Active(new SQLITE_DAL()));
                    }
                    break;

                default:
                    LoadData(CSpath_exten.Active(new SQLITE_DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<Spath> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[SPATH.SPATH_ID].Value = list[r].Spath_id;
                row.Cells[SPATH.STABLES_ID].Value = list[r].Stables_id;
                row.Cells[SPATH.ROOT_FOLDER].Value = list[r].Root_folder;
                row.Cells[SPATH.CONTFOLDER].Value = list[r].Contfolder;
                row.Cells[SPATH.CLASSFOLDER].Value = list[r].Classfolder;
                row.Cells[SPATH.FORMFOLDER].Value = list[r].Formfolder;
                row.Cells[SPATH.LISTFOLDER].Value = list[r].Listfolder;
                row.Cells[SPATH.SETUPFOLDER].Value = list[r].Setupfolder;
                row.Cells[SPATH.TESTFOLDER].Value = list[r].Testfolder;
                row.Cells[SPATH.ACTIVE_ID].Value = list[r].Active_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
