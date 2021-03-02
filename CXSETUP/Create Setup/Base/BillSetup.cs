using CXLIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CXSETUP.Create_Setup.Base
{
    class BillSetup
    {
        #region[Entries]

        public static void Entries(Setup obj)
        {

            switch (obj.SoftwareType)
            {

                case Softwares.GARMENT:
                   GarmentSetup.Install(obj);
                    break;

                //case Softwares.OFFSET:
                //    CxOffset(obj);
                //    break;

                //case Softwares.OFFSET_1:
                //    CxOffset_1(obj);
                //    break;

                case Softwares.TEX:
                   // CxTex(obj);
                    break;

                //case Softwares.KNITTING:

                //    break;

                case Softwares.UPVC:
                   // CxUPVC(obj);
                    break;

            }

        }

        #endregion[Entries]

    }
}
