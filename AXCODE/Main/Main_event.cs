using System;

namespace AXCODE
{
    partial class Main
    {
        private void Menu_Event()
        {

            menucreater_menu.Click += new EventHandler(Menucreater_menu_Click); 
            mtables_menu.Click += new EventHandler(Mastertables_menu_Click); 
            databases_menu.Click += new EventHandler(Databases_menu_Click); 
            stables_menu.Click += new EventHandler(Lstables_menu_Click);
            mpath_menu.Click += new EventHandler(Lmpath_menu_Click); 
            spath_menu.Click += new EventHandler(Lspath_menu_Click); 
        }//void
    }//cls
}//ns
