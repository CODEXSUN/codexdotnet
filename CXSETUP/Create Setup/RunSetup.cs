using System;
using CXLIB;
using CXSETUP.Create_Setup.Base;

namespace CXSETUP
{
    public static class RunSetup
    {
        public static string screenText = "";
        ///
        public static event EventHandler Processing = null;

        public static void Install(Setup obj)
        {

            switch (obj.Mode)
            {
                case "new":

                   DB_Setup.DropDatabase(obj.Database);
                   DB_Setup.CreateDatabase(obj.Database);

                    screenText = "Installed database " + obj.Database;
                    Processing(null, null);

                    CoreSetup.Install(obj);

                    //InstallErp(obj);

                    //InstallEntries(obj);

                    //CxAccounts(obj);

                    screenText = "Installed Setup Success " + obj.Database;
                    Processing(null, null);

                    break;

            }
        }
    }
}
