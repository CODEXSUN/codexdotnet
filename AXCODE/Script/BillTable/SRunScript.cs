using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AXCODE
{
    [TestClass]
    public class STablesScript
    {
        [TestMethod]
        public void SRunScriptTest()

        {
            SRun(3);

        }

        public static void SRun(int tbl_id)
        {
           // BillTable_Const.Create(STX.Logics(tbl_id));
           SConstItems.XConstItems(STX.Logics(tbl_id));

            //SClass.XClass(STX.Logics(tbl_id));
            //SClass_exten.XClass_exten(STX.Logics(tbl_id));

            SClassitems.XClassitems(STX.Logics(tbl_id));
            SClassitems_exten.XClassitems_exten(STX.Logics(tbl_id));

            //SForm.XForm(STX.Logics(tbl_id));
            //SForm_Default.XForm_Default(STX.Logics(tbl_id));
            ////SForm_Design.XForm_Design(STX.Logics(tbl_id));
            ////SForm_exten.XForm_exten(STX.Logics(tbl_id));
            //SVForm.XForm(STX.Logics(tbl_id));

            //SList.XList(STX.Logics(tbl_id));
            //SList_default.XList_default(STX.Logics(tbl_id));
            //SList_designer.XList_designer(STX.Logics(tbl_id));
            //SVList.XVlist(STX.Logics(tbl_id));

            //SSetup.XSetup(STX.Logics(tbl_id));

        }
    }
}
