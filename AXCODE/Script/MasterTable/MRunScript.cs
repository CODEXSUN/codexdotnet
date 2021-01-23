using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AXCODE
{
    [TestClass]
    public class MTablesScript
    {
        [TestMethod]
        public void MTablesRunScriptTest()
        {
            int[] tbl_id = { 33 };//1, 2, 3, 4,5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 };

            for (int i = 0; i < tbl_id.Length; i++)
            {
                MRun(tbl_id[i]);
            }
        }

        public static void MRun(int tbl_id)
        {
            MasterTable_Const.Create(MTX.Logics(tbl_id));

            MClass.XClass(MTX.Logics(tbl_id));
            MClass_exten.XClass_exten(MTX.Logics(tbl_id));

            MForm.XForm(MTX.Logics(tbl_id));
            MForm_Default.XForm_Default(MTX.Logics(tbl_id));
            MForm_Design.XForm_Design(MTX.Logics(tbl_id));
            MVForm.XVForm(MTX.Logics(tbl_id));

            MList.XList(MTX.Logics(tbl_id));
            MList_default.XList_default(MTX.Logics(tbl_id));
            MList_designer.XList_designer(MTX.Logics(tbl_id));
            MVList.XVlist(MTX.Logics(tbl_id));

            MSetup.XSetup(MTX.Logics(tbl_id));

            //MTest.XTest(MTX.Logics(tbl_id));

            MasterUpdate.Create(MTX.Logics(tbl_id));

        }

    }//cls
}//ns
