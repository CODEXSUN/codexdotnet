using CXLIB;
using System.Collections.Generic;
using System.IO;

namespace AXCODE
{
    public enum MenuType
    {
        list,
        Form,
        Button
    }
    public class CMenu
    {
        private static string ___result;
        private static string f;
        private static string UPPERFIRST;
        private static string SMALL;
        private static string CAPITAL;



        public static void Creater(string v, string p, MenuType t)
        {
            StrBuild(v, t);
            AddMenu(p);
            AddEvent(p);
            AddLogout(p);
        }

        private static void StrBuild(string v, MenuType t)
        {
            if (t == MenuType.list)
            {
                f = "L";
            }
            else if (t == MenuType.Form)
            {
                f = "F";
            }

            CAPITAL = v.ToUpper();
            SMALL = v.ToLower();
            UPPERFIRST = SMALL.UpperFirst();
        }

        private  static void AddMenu(string path)
        {
            string __result = string.Empty;

            string _menu_path = @"" + path + @"\Main_menu.cs";

            IEnumerable<string> xmenu_txt = File.ReadLines(_menu_path);

            foreach (string _st in xmenu_txt)
            {
                if (!((_st.Trim() == "}//cls") || (_st.Trim() == "}//ns")))
                {
                    __result += _st + "\r\n";
                }
            }

            __result += "" + MenuScript();
            __result += "    }//cls\r\n";
            __result += "}//ns\r\n";
            File.WriteAllText(_menu_path, __result);
        }
        private static void AddEvent(string path)
        {
            string __result = string.Empty;
            string _eventhandler_path = @"" + path + @"\Main_event.cs";

            IEnumerable<string> xeventhandler_txt = File.ReadLines(_eventhandler_path);
            foreach (string _st in xeventhandler_txt)
            {
                if (!((_st.Trim() == "}//void") || (_st.Trim() == "}//cls") || (_st.Trim() == "}//ns")))
                {
                    __result += _st + "\r\n";
                }
            }
            __result += "            " + MenuEvent();
            __result += "        }//void\r\n";
            __result += "    }//cls\r\n";
            __result += "}//ns\r\n";
            File.WriteAllText(_eventhandler_path, __result);
        }


        private static void AddLogout(string path)
        {
            string __result = string.Empty;
            string _logout_path = @"" + path + @"\Main_logout.cs";

            IEnumerable<string> xlogout_txt = File.ReadLines(_logout_path);
            foreach (string _st in xlogout_txt)
            {
                if (!((_st.Trim() == "}//void") || (_st.Trim() == "}//cls") || (_st.Trim() == "}//ns")))
                {
                    __result += _st + "\r\n";
                }
            }
            __result += "            " + MenuLogout();
            __result += "        }//void\r\n";
            __result += "    }//cls\r\n";
            __result += "}//ns\r\n";
            File.WriteAllText(_logout_path, __result);
        }




        private static string MenuScript()
        {
            ___result = "";
            ___result += "        #region [" + UPPERFIRST + "] \r\n";
            ___result += "\r\n";
            ___result += "        private " + f + UPPERFIRST + "  " + f + SMALL + " = null; \r\n";
            ___result += "        private  TabPage  " + SMALL + "tab  = null; \r\n";
            ___result += "\r\n";
            ___result += "        private void " + UPPERFIRST + "_menu_Click(object sender, EventArgs e) \r\n";
            ___result += "        { \r\n";
            ___result += "            if (" + f + SMALL + " == null) \r\n";
            ___result += "            { \r\n";
            ___result += "                " + f + SMALL + " = new " + f + UPPERFIRST + "(); \r\n";
            ___result += "                " + SMALL + "tab = new TabPage(\"" + CAPITAL + "\"); \r\n";
            ___result += "                " + f + SMALL + "." + UPPERFIRST + "_NeedToRefresh += " + f + UPPERFIRST + "_ToRefresh; \r\n";
            ___result += "                main_tabControl.TabPages.Add(" + SMALL + "tab); \r\n";
            ___result += "                " + SMALL + "tab.Controls.Add(" + f + SMALL + "); \r\n";
            ___result += "                " + f + SMALL + ".Dock = DockStyle.Fill; \r\n";
            ___result += "                " + f + SMALL + ".Show(); \r\n";
            ___result += "                " + f + SMALL + ".BringToFront(); \r\n";
            ___result += "            } \r\n";
            ___result += "             " + f + SMALL + " .ListRefresh();\r\n";
            ___result += "            main_tabControl.SelectTab(" + SMALL + "tab); \r\n";
            ___result += "        } \r\n";
            ___result += "\r\n";
            ___result += "        void " + f + UPPERFIRST + "_ToRefresh(object sender, EventArgs e) \r\n";
            ___result += "        { \r\n";
            ___result += "            if(" + f + SMALL + " != null) \r\n";
            ___result += "            { \r\n";
            ___result += "                main_tabControl.TabPages.Remove(" + SMALL + "tab); \r\n";
            ___result += "                " + f + SMALL + " = null; \r\n";
            ___result += "            } \r\n";
            ___result += "        } \r\n";
            ___result += "\r\n";
            ___result += "        #endregion[" + UPPERFIRST + "] \r\n";
            ___result += "\r\n";
            return ___result;
        }

        private static string MenuEvent()
        {
            return  SMALL + ".Click += new EventHandler(" + UPPERFIRST + "_menu_Click); \r\n";
        }

        private static string MenuLogout()
        {
            return f + UPPERFIRST + "_ToRefresh(null, null); \r\n";
        }

    }
}
