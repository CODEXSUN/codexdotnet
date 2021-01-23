using System;
using System.Data;
using CXLIB;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CXTEST
{
    [TestClass]
    public class WebTest
    {
        [TestMethod]
        public void TestWeb()
        {

            string q = "SELECT * FROM  USER_TBL";



            using (IDataReader redr = new WEBDAL().Listreader(q))
            {
                while (redr.Read() == true)
                {





                    System.Diagnostics.Debug.WriteLine("sucess");
                }
                

            }

            


        }
    }
}
