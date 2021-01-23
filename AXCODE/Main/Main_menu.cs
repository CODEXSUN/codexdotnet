using System;
using System.Windows.Forms;

namespace AXCODE
{
    partial class Main
    {

        #region [Menucreater] 

        private FMenuCreater Fmenucreater = null;
        private TabPage menucreatertab = null;

        private void Menucreater_menu_Click(object sender, EventArgs e)
        {
            if (Fmenucreater == null)
            {
                Fmenucreater = new FMenuCreater();
                menucreatertab = new TabPage("MENUCREATER");
                main_tabControl.TabPages.Add(menucreatertab);
                menucreatertab.Controls.Add(Fmenucreater);
                Fmenucreater.Dock = DockStyle.Fill;
                Fmenucreater.Show();
                Fmenucreater.BringToFront();
            }
            main_tabControl.SelectTab(menucreatertab);
        }

        void FMenucreater_ToRefresh(object sender, EventArgs e)
        {
            if (Fmenucreater != null)
            {
                main_tabControl.TabPages.Remove(menucreatertab);
                Fmenucreater = null;
            }
        }

        #endregion[Menucreater] 

        #region [Tabels] 

        private LMastertables Lmastertabels = null;
        private TabPage mtabelstab = null;

        private void Mastertables_menu_Click(object sender, EventArgs e)
        {
            if (Lmastertabels == null)
            {
                Lmastertabels = new LMastertables();
                mtabelstab = new TabPage("MASTERTABELS");
                //Ltabels.Tabels_NeedToRefresh += LTabels_ToRefresh;
                main_tabControl.TabPages.Add(mtabelstab);
                mtabelstab.Controls.Add(Lmastertabels);
                Lmastertabels.Dock = DockStyle.Fill;
                Lmastertabels.Show();
                Lmastertabels.BringToFront();
            }
            Lmastertabels.ListRefresh();
            main_tabControl.SelectTab(mtabelstab);
        }

        void LTabels_ToRefresh(object sender, EventArgs e)
        {
            if (Lmastertabels != null)
            {
                main_tabControl.TabPages.Remove(mtabelstab);
                Lmastertabels = null;
            }
        }

        #endregion[Tabels] 

        #region [Databases] 

        private LDatabases  Ldatabases = null; 
        private  TabPage  databasestab  = null; 

        private void Databases_menu_Click(object sender, EventArgs e) 
        { 
            if (Ldatabases == null) 
            { 
                Ldatabases = new LDatabases(); 
                databasestab = new TabPage("DATABASES"); 
                //Ldatabases.Databases_NeedToRefresh += LDatabases_ToRefresh; 
                main_tabControl.TabPages.Add(databasestab); 
                databasestab.Controls.Add(Ldatabases); 
                Ldatabases.Dock = DockStyle.Fill; 
                Ldatabases.Show(); 
                Ldatabases.BringToFront(); 
            } 
             Ldatabases .ListRefresh();
            main_tabControl.SelectTab(databasestab); 
        } 

        void LDatabases_ToRefresh(object sender, EventArgs e) 
        { 
            if(Ldatabases != null) 
            { 
                main_tabControl.TabPages.Remove(databasestab); 
                Ldatabases = null; 
            } 
        } 

        #endregion[Databases] 

        #region [Lstables] 

        private LStables  Llstables = null; 
        private  TabPage  lstablestab  = null; 

        private void Lstables_menu_Click(object sender, EventArgs e) 
        { 
            if (Llstables == null) 
            { 
                Llstables = new LStables(); 
                lstablestab = new TabPage("LSTABLES"); 
                Llstables.LStables_NeedToRefresh += Lstables_ToRefresh; 
                main_tabControl.TabPages.Add(lstablestab); 
                lstablestab.Controls.Add(Llstables); 
                Llstables.Dock = DockStyle.Fill; 
                Llstables.Show(); 
                Llstables.BringToFront(); 
            } 
             Llstables .ListRefresh();
            main_tabControl.SelectTab(lstablestab); 
        } 

        void Lstables_ToRefresh(object sender, EventArgs e) 
        { 
            if(Llstables != null) 
            { 
                main_tabControl.TabPages.Remove(lstablestab); 
                Llstables = null; 
            } 
        } 

        #endregion[Lstables] 

        #region [Mpath] 

        private LMasterpath  lmpath = null; 
        private  TabPage  lmpathtab  = null; 

        private void Lmpath_menu_Click(object sender, EventArgs e) 
        { 
            if (lmpath == null) 
            { 
                lmpath = new LMasterpath(); 
                lmpathtab = new TabPage("MPATH"); 
                lmpath.LMpath_NeedToRefresh += Lmpath_ToRefresh; 
                main_tabControl.TabPages.Add(lmpathtab); 
                lmpathtab.Controls.Add(lmpath); 
                lmpath.Dock = DockStyle.Fill; 
                lmpath.Show(); 
                lmpath.BringToFront(); 
            } 
             lmpath .ListRefresh();
            main_tabControl.SelectTab(lmpathtab); 
        } 

        void Lmpath_ToRefresh(object sender, EventArgs e) 
        { 
            if(lmpath != null) 
            { 
                main_tabControl.TabPages.Remove(lmpathtab); 
                lmpath = null; 
            } 
        }

        #endregion[Mpath] 

        #region [Spath] 

        private LSpath lspath = null;
        private TabPage lspathtab = null;

        private void Lspath_menu_Click(object sender, EventArgs e)
        {
            if (lspath == null)
            {
                lspath = new LSpath();
                lspathtab = new TabPage("MPATH");
                lspath.LSpath_NeedToRefresh += Lspath_ToRefresh;
                main_tabControl.TabPages.Add(lspathtab);
                lspathtab.Controls.Add(lspath);
                lspath.Dock = DockStyle.Fill;
                lspath.Show();
                lspath.BringToFront();
            }
            lspath.ListRefresh();
            main_tabControl.SelectTab(lspathtab);
        }

        void Lspath_ToRefresh(object sender, EventArgs e)
        {
            if (lspath != null)
            {
                main_tabControl.TabPages.Remove(lspathtab);
                lspath = null;
            }
        }

        #endregion[Mpath] 

    }//cls
}//ns
