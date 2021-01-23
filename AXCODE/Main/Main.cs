using System;
using System.Windows.Forms;

namespace AXCODE
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

            Menu_Event();
        }

        private void btn_mtabels_runscript_Click(object sender, EventArgs e)
        {
            MTablesScript.MRun(6);
        }

        private void btn_version_Click(object sender, EventArgs e)
        {
            Lversion_menu_Click(null,null);
        }
        #region [Lstables] 

        private LVersion lversion = null;
        private TabPage lversiontab = null;

        private void Lversion_menu_Click(object sender, EventArgs e)
        {
            if (lversion == null)
            {
                lversion = new LVersion();
                lversiontab = new TabPage("VERSION");
                main_tabControl.TabPages.Add(lversiontab);
                lversiontab.Controls.Add(lversion);
                lversion.Dock = DockStyle.Fill;
                lversion.Show();
                lversion.BringToFront();
            }
            main_tabControl.SelectTab(lversiontab);
        }

        void LVersion_ToRefresh(object sender, EventArgs e)
        {
            if (lversion != null)
            {
                main_tabControl.TabPages.Remove(lversiontab);
                lversion = null;
            }
        }

        #endregion[Lstables] 
    }
}
