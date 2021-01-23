using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AXCODE
{
    [TestClass]
    public class MenuTest
    {
        [TestMethod]
        public void TestMenu()
        {

            string tbl = "Payment";

            string currentFolder = (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)).Replace(@"CODEIT\bin\Debug", "");

            string path = currentFolder + @"CODEXSUN\Main";

            CMenu.Creater(tbl, path, MenuType.list);

        }
    }
}
