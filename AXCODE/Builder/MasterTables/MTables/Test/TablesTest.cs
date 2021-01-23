using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AXCODE
{
    [TestClass]
    public class TablesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            CCTables obj = new CCTables()
            {
                Tables_id = "",
                Databases_id = "1",
                Tables_name = "TABLESITEMS_TBL",
                Tables_alias = "TABLESITEMS",
                Createdon = "12-11-18",
                Notes = "",
                Active_id = "1",
                User_id = "1",
            };

            CCTables.Insert(obj, new SQLITE_DAL());



        }
    }
}
