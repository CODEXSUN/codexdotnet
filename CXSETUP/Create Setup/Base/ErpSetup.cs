using CXERP;
using CXLIB;

namespace CXSETUP.Create_Setup.Base
{
    class ErpSetup
    {

        #region[ERP]

        public static void Install(Setup obj)
        {

            switch (obj.SoftwareType)
            {
                case Softwares.GARMENT:
                    new Po_Tbl(obj.Database);
                    new Article_Tbl(obj.Database);
                    new Style_Tbl(obj.Database);
                    new Order_Tbl(obj.Database);
                    
                    new Inward_Tbl(obj.Database);



                    break;
            }

        }

        #endregion[ERP]
    }
}
