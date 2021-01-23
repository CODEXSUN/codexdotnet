// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 06-12-2018 10:53:54 PM

using System.Windows.Forms;
using System.Collections.Generic;
using CXLIB;

namespace AXCODE
{
    public partial class LMasterpath : UserControl
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
                        LoadData(CMpath_exten.NotActive(new SQLITE_DAL()));
                    }
                    else
                    {
                        LoadData(CMpath_exten.Active(new SQLITE_DAL()));
                    }

                    break;

                case ListOption.notactive:

                    if (chk_notactive.Checked == true)
                    {
                        LoadData(CMpath_exten.NotActive(new SQLITE_DAL()));
                    }
                    else
                    {
                        LoadData(CMpath_exten.Active(new SQLITE_DAL()));
                    }

                    break;

                case ListOption.Search:
                    if (txt_mtables_id.Text != "")
                    {
                        List<MasterTablePath> list = new List<MasterTablePath>
                     {
                     CMpath_exten.SearchName(txt_mtables_id.Text, new SQLITE_DAL())
                     };
                        LoadData(list);
                    }
                    else
                    {
                        LoadData(CMpath_exten.Active(new SQLITE_DAL()));
                    }
                    break;

                default:
                    LoadData(CMpath_exten.Active(new SQLITE_DAL()));
                    break;
            }
        }

        #endregion[list Option] 

        #region[Load Data] 

        public void LoadData(List<MasterTablePath> list)
        {
            listgrid.RowCount = 0;
            listgrid.RowCount = list.Count;
            for (int r = 0; r < list.Count; r++)
            {
                DataGridViewRow row = listgrid.Rows[r];

                row.Cells[MASTERPATH.MASTERPATH_ID].Value = list[r].Masterpath_id;
                row.Cells[MASTERPATH.MASTERTABLES_ID].Value = list[r].Mastertables_id;
                row.Cells[MASTERPATH.ROOT_FOLDER].Value = list[r].Root_folder;
                row.Cells[MASTERPATH.CONTFOLDER].Value = list[r].Contfolder;
                row.Cells[MASTERPATH.CLASSFOLDER].Value = list[r].Classfolder;
                row.Cells[MASTERPATH.FORMFOLDER].Value = list[r].Formfolder;
                row.Cells[MASTERPATH.LISTFOLDER].Value = list[r].Listfolder;
                row.Cells[MASTERPATH.SETUPFOLDER].Value = list[r].Setupfolder;
                row.Cells[MASTERPATH.TESTFOLDER].Value = list[r].Testfolder;
                row.Cells[MASTERPATH.ACTIVE_ID].Value = list[r].Active_id;
            }
        }

        #endregion[Load Data] 

    }//cls 
}//ns 
