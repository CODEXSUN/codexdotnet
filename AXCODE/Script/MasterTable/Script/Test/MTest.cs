using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class MTest
    {
        public static void XTest(MasterDetails obj)
        {
            string tbl_name = obj.Mastertable.Mastertables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.Mastertablepath.Testfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\Test" + tbl_name + ".cs", result);
        }

        #region []

        private static string XCreate(MasterDetails obj)
        {
            List<MasterTablesItems> list = obj.Mastertablesitems;

            string vtablesname = obj.Mastertable.Mastertables_name;

            string vnamespaces = obj.Mastertable.Namespaces_id;

            string TABLENAME = vtablesname.ToUpper();

            string TRIM_TBL = vtablesname.Remove(vtablesname.Length - 4);

            string CAPITAL = cCultureInfo.toUpperCase(TRIM_TBL);
            string SMALL = cCultureInfo.toLowerCase(TRIM_TBL);
            string UPPERFIRST = ChangeCase.UpperFirst(SMALL);
            string ___result = "";

            string xDAL = "DAL";

            #endregion []

            #region [Conclusion]

            ___result += "// " + CVersion_exten.Get_Current_Version() + "\r\n";
            ___result += "// Auto Generated\r\n";
            ___result += "// last update : " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt") + "\r\n";
            ___result += "\r\n";

            #endregion [Conclusion]

            #region [using] 

            ___result += "using System; \r\n ";
            ___result += "using Microsoft.VisualStudio.TestTools.UnitTesting; \r\n ";
            ___result += "using System.Collections.Generic; \r\n ";
            ___result += "using System.Data; \r\n ";
            ___result += "using CXCORE; \r\n ";
            ___result += "using CXLIB; \r\n ";
            ___result += "\r\n";

            #endregion [using]

            #region [namespace]

            ___result += "namespace CXTEST\r\n";
            ___result += "{\r\n";
            ___result += "    [TestClass] \r\n ";
            ___result += "    public class Test" + UPPERFIRST + " \r\n ";
            ___result += "    { \r\n ";
           // ___result += "        [TestInitialize] \r\n ";
            //___result += "        public void " + UPPERFIRST + "Intilize() \r\n ";
           // ___result += "        { \r\n ";
            //___result += "            CodexsunSetup." + UPPERFIRST + "Tbl.CleanTbl(Server.DBNAME); \r\n ";
            //___result += "        } \r\n ";
            ___result += " \r\n ";
            ___result += "        [TestMethod] \r\n ";
            ___result += "        public void " + UPPERFIRST + "Test() \r\n ";
            ___result += "        { \r\n ";
            ___result += " \r\n ";

            #endregion [namespace]

            #region[Insert]

            ___result += "            #region[Insert] \r\n ";
            ___result += " \r\n ";
            ___result += "            " + UPPERFIRST + " obj = new " + UPPERFIRST + "() \r\n ";
            ___result += "            { \r\n ";
            ___result += "                " + UPPERFIRST + "_id = \"\", \r\n ";

            for (int r = 0; r <= list.Count - 1; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "                " + list[r].Fieldsname.UpperFirst() + " = \"1\", \r\n ";
                }
                else
                {

                    switch (list[r].Datatype)
                    {
                        case DATATYPES.VARCHAR_100:
                            ___result += "                " + list[r].Fieldsname.UpperFirst() + " = \"" + list[r].Fieldsname + "_insert\", \r\n ";
                            break;
                        case DATATYPES.DATE:
                            ___result += "                " + list[r].Fieldsname.UpperFirst() + " = \"" + ConvertTO.SqlDate(Current.Date) + "\", \r\n ";
                            break;
                        case DATATYPES.DATETIME:
                            ___result += "                " + list[r].Fieldsname.UpperFirst() + " = \"" + ConvertTO.SqlDateTime(Current.Datetime) + "\", \r\n ";
                            break;
                        case DATATYPES.BOOLX:
                            ___result += "                " + list[r].Fieldsname.UpperFirst() + " = \"True\", \r\n ";
                            break;
                        case DATATYPES.DECMIAL_2:
                            ___result += "                " + list[r].Fieldsname.UpperFirst() + " = \"1.03\", \r\n ";
                            break;
                        case DATATYPES.INT:
                            ___result += "                " + list[r].Fieldsname.UpperFirst() + " = \"9\", \r\n ";
                            break;
                        case DATATYPES.SMALLINT:
                            ___result += "                " + list[r].Fieldsname.UpperFirst() + " = \"1\", \r\n ";
                            break;
                        default:
                            ___result += "                " + list[r].Fieldsname.UpperFirst() + " = \"00\", \r\n ";
                            break;
                    }

                }
            }

            ___result += "                Notes = Core.EmptyNotes, \r\n ";
            ___result += "                Active_id = Core.Active, \r\n ";
            ___result += "                User_id = Current.Codexsun \r\n ";
            ___result += "            }; \r\n ";
            ___result += " \r\n ";
            ___result += "            C" + UPPERFIRST + ".Insert(obj, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "            #endregion[Insert] \r\n ";
            ___result += " \r\n ";

            #endregion[Insert]

            #region[search names & pkid]

            ___result += "            #region[search names & pkid] \r\n ";
            ___result += " \r\n ";
            ___result += "            " + UPPERFIRST + " obj1 = C" + UPPERFIRST + "_exten.SearchName(obj." + UPPERFIRST + "_name, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "            " + UPPERFIRST + " obj2 = C" + UPPERFIRST + "_exten.PKId(obj1." + UPPERFIRST + "_id, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";


            for (int r = 0; r <= list.Count - 1; r++)
            {
                if (list[r].Datatype == AutoCode.FOREIGNKEY)
                {
                    ___result += "            Assert.AreEqual(C" + list[r].Fieldsname.UpperFirst().Replace("_id", "") + "_exten.GetName_Id(obj." + list[r].Fieldsname.UpperFirst() + ") , obj2." + list[r].Fieldsname.UpperFirst() + "); \r\n ";
                }
                else
                {
                    ___result += "            Assert.AreEqual(obj." + list[r].Fieldsname.UpperFirst() + ", obj2." + list[r].Fieldsname.UpperFirst() + "); \r\n ";
                }

            }
            ___result += "            Assert.AreEqual(obj.Notes, obj2.Notes); \r\n ";
            ___result += "            Assert.AreEqual(obj.Active_id, obj2.Active_id); \r\n ";
            ___result += "            Assert.AreEqual(CUser_exten.GetName_Id(obj.User_id), obj2.User_id); \r\n ";
            ___result += " \r\n ";
            ___result += " \r\n ";
            ___result += "            #endregion[search names & pkid] \r\n ";
            ___result += " \r\n ";

            #endregion[search names & pkid]

            #region[Update]

            ___result += "            #region[Update] \r\n ";
            ___result += " \r\n ";
            ___result += "            obj." + UPPERFIRST + "_id = obj2." + UPPERFIRST + "_id; \r\n ";


            for (int r = 0; r <= list.Count - 1; r++)
            {
                if (list[r].Datatype == AutoCode.FOREIGNKEY)
                {
                    ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"1\"; \r\n ";
                }
                else
                {

                    switch (list[r].Datatype)
                    {
                        case DATATYPES.VARCHAR_100:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"" + list[r].Fieldsname.UpperFirst() + "_update\"; \r\n ";
                            break;
                        case DATATYPES.DATE:
                            ___result += "                obj." + list[r].Fieldsname.UpperFirst() + " = \"" + ConvertTO.SqlDate(Current.Date) + "\"; \r\n ";
                            break;
                        case DATATYPES.DATETIME:
                            ___result += "                obj." + list[r].Fieldsname.UpperFirst() + " = \"" + ConvertTO.SqlDateTime(Current.Datetime) + "\"; \r\n ";
                            break;
                        case DATATYPES.BOOLX:
                            ___result += "                obj." + list[r].Fieldsname.UpperFirst() + " = \"True\"; \r\n ";
                            break;
                        case DATATYPES.DECMIAL_2:
                            ___result += "                obj." + list[r].Fieldsname.UpperFirst() + " = \"1.23\"; \r\n ";
                            break;
                        case DATATYPES.INT:
                            ___result += "                obj." + list[r].Fieldsname.UpperFirst() + " = \"9\"; \r\n ";
                            break;
                        case DATATYPES.SMALLINT:
                            ___result += "                obj." + list[r].Fieldsname.UpperFirst() + " = \"1\"; \r\n ";
                            break;
                        default:
                            ___result += "                obj." + list[r].Fieldsname.UpperFirst() + " = \"00\"; \r\n ";
                            break;
                    }

                }
            }

            ___result += "            obj.Notes = \"test notes\"; \r\n ";
            ___result += "            obj.Active_id = Core.NotActive; \r\n ";
            ___result += "            obj.User_id = Current.Codexsun; \r\n ";
            ___result += " \r\n ";
            ___result += "            C" + UPPERFIRST + ".Update(obj, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "            obj1 = C" + UPPERFIRST + "_exten.SearchName(obj." + UPPERFIRST + "_name, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "            obj2 = C" + UPPERFIRST + "_exten.PKId(obj1." + UPPERFIRST + "_id, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "            Assert.AreEqual(obj." + UPPERFIRST + "_id, obj2." + UPPERFIRST + "_id); \r\n ";

            for (int r = 0; r <= list.Count - 1; r++)
            {
                if (list[r].Datatype == AutoCode.FOREIGNKEY)
                {
                    ___result += "            Assert.AreEqual(C" + list[r].Fieldsname.UpperFirst().Replace("_id", "") + "_exten.GetName_Id(obj." + list[r].Fieldsname.UpperFirst() + ") , obj2." + list[r].Fieldsname.UpperFirst() + "); \r\n ";
                }
                else
                {
                    ___result += "            Assert.AreEqual(obj." + list[r].Fieldsname.UpperFirst() + ", obj2." + list[r].Fieldsname.UpperFirst() + "); \r\n ";
                }
            }

            ___result += "            Assert.AreEqual(obj.Notes, obj2.Notes); \r\n ";
            ___result += "            Assert.AreEqual(obj.Active_id, obj2.Active_id); \r\n ";
            ___result += "            Assert.AreEqual(CUser_exten.GetName_Id(obj.User_id), obj2.User_id); \r\n ";
            ___result += " \r\n ";

            #endregion[Update]

            #region[delete]

            ___result += "            #endregion[Update] \r\n ";
            ___result += " \r\n ";
            ___result += "            #region[delete] \r\n ";
            ___result += " \r\n ";
            ___result += "            C" + UPPERFIRST + ".Delete(obj." + UPPERFIRST + "_id, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "            obj2 = C" + UPPERFIRST + "_exten.PKId(obj1." + UPPERFIRST + "_id, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "            Assert.AreEqual(null, obj2." + UPPERFIRST + "_id); \r\n ";
            ___result += " \r\n ";
            ___result += "            #endregion[delete] \r\n ";
            ___result += " \r\n ";

            #endregion[delete

            #region[active]

            ___result += "            #region[active] \r\n ";
            ___result += " \r\n ";
            ___result += "            obj = new " + UPPERFIRST + "() \r\n ";
            ___result += "            { \r\n ";
            ___result += "            " + UPPERFIRST + "_id = \"\", \r\n ";

            for (int r = 0; r <= list.Count - 1; r++)
            {
                if (list[r].Datatype == AutoCode.FOREIGNKEY)
                {
                    ___result += "            " + list[r].Fieldsname.UpperFirst() + " = \"1\", \r\n ";
                }
                else
                {

                    switch (list[r].Datatype)
                    {
                        case DATATYPES.VARCHAR_100:
                            ___result += "            " + list[r].Fieldsname.UpperFirst() + " = \"" + list[r].Fieldsname + "_active\", \r\n ";
                            break;
                        case DATATYPES.DATE:
                            ___result += "            " + list[r].Fieldsname.UpperFirst() + " = \"" + ConvertTO.SqlDate(Current.Date) + "\", \r\n ";
                            break;
                        case DATATYPES.DATETIME:
                            ___result += "            " + list[r].Fieldsname.UpperFirst() + " = \"" + ConvertTO.SqlDateTime(Current.Datetime) + "\", \r\n ";
                            break;
                        case DATATYPES.BOOLX:
                            ___result += "            " + list[r].Fieldsname.UpperFirst() + " = \"True\", \r\n ";
                            break;
                        case DATATYPES.DECMIAL_2:
                            ___result += "            " + list[r].Fieldsname.UpperFirst() + " = \"1.23\", \r\n ";
                            break;
                        case DATATYPES.INT:
                            ___result += "            " + list[r].Fieldsname.UpperFirst() + " = \"9\", \r\n ";
                            break;
                        case DATATYPES.SMALLINT:
                            ___result += "            " + list[r].Fieldsname.UpperFirst() + " = \"1\", \r\n ";
                            break;
                        default:
                            ___result += "            " + list[r].Fieldsname.UpperFirst() + " = \"00\", \r\n ";
                            break;
                    }

                }
            }

            ___result += "            Notes = Core.EmptyNotes, \r\n ";
            ___result += "            Active_id = Core.Active, \r\n ";
            ___result += "            User_id = Current.Codexsun \r\n ";
            ___result += "            }; \r\n ";
            ___result += " \r\n ";
            ___result += "            C" + UPPERFIRST + ".Insert(obj, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "            obj1 = C" + UPPERFIRST + "_exten.SearchName(obj." + UPPERFIRST + "_name, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "            obj2 = C" + UPPERFIRST + "_exten.PKId(obj1." + UPPERFIRST + "_id, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";


            ___result += "            List<" + UPPERFIRST + "> list = C" + UPPERFIRST + "_exten.Active(new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "\r\n ";
            ___result += "            if (list.Count != 0)\r\n ";
            ___result += "            {\r\n ";
            ___result += "                for (int i = 0; i < list.Count; i++)\r\n ";
            ___result += "                {\r\n ";
            ___result += "                    Assert.AreEqual(Core.Active, list[i].Active_id); \r\n ";
            ___result += "                }\r\n ";
            ___result += "            }\r\n ";
            ___result += " \r\n ";
            ___result += "            #endregion[Active] \r\n ";
            ___result += " \r\n ";

            #endregion[Active]

            #region[Not Active]

            ___result += "            #region[Not Active] \r\n ";
            ___result += " \r\n ";
            ___result += "            obj." + UPPERFIRST + "_id = obj1." + UPPERFIRST + "_id; \r\n ";

            for (int r = 0; r <= list.Count - 1; r++)
            {
                if (list[r].Datatype == AutoCode.FOREIGNKEY)
                {
                    ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"1\"; \r\n ";
                }
                else
                {

                    switch (list[r].Datatype)
                    {
                        case DATATYPES.VARCHAR_100:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"" + list[r].Fieldsname + "_notactive\"; \r\n ";
                            break;
                        case DATATYPES.DATE:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"" + ConvertTO.SqlDate(Current.Date) + "\"; \r\n ";
                            break;
                        case DATATYPES.DATETIME:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"" + ConvertTO.SqlDateTime(Current.Datetime) + "\"; \r\n ";
                            break;
                        case DATATYPES.BOOLX:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"True\"; \r\n ";
                            break;
                        case DATATYPES.DECMIAL_2:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"1.23\"; \r\n ";
                            break;
                        case DATATYPES.INT:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"9\"; \r\n ";
                            break;
                        case DATATYPES.SMALLINT:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"1\"; \r\n ";
                            break;
                        default:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"00\"; \r\n ";
                            break;
                    }

                }
            }
            ___result += "            obj.Notes = \"test notes\"; \r\n ";
            ___result += "            obj.Active_id = Core.NotActive; \r\n ";
            ___result += "            obj.User_id = Current.Codexsun; \r\n ";
            ___result += " \r\n ";
            ___result += "            C" + UPPERFIRST + ".Update(obj, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "            list = C" + UPPERFIRST + "_exten.NotActive(new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            //___result += "            Assert.AreEqual(obj." + UPPERFIRST + "_id, list[0]." + UPPERFIRST + "_id); \r\n ";
            ___result += "\r\n ";
            ___result += "            if (list.Count != 0)\r\n ";
            ___result += "            {\r\n ";
            ___result += "                for (int i = 0; i < list.Count; i++)\r\n ";
            ___result += "                {\r\n ";
            ___result += "                    Assert.AreEqual(Core.NotActive, list[i].Active_id); \r\n ";
            ___result += "                }\r\n ";
            ___result += "            }\r\n ";
            ___result += "\r\n ";
            ___result += "            #endregion[Not Active] \r\n ";
            ___result += " \r\n ";

            #endregion[Not Active]

            #region[Lookup]

            ___result += "            #region[Lookup] \r\n ";
            ___result += " \r\n ";
            ___result += "            obj." + UPPERFIRST + "_id = obj1." + UPPERFIRST + "_id; \r\n ";

            for (int r = 0; r <= list.Count - 1; r++)
            {
                if (list[r].Datatype == AutoCode.FOREIGNKEY)
                {
                    ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"1\"; \r\n ";
                }
                else
                {

                    switch (list[r].Datatype)
                    {
                        case DATATYPES.VARCHAR_100:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"" + list[r].Fieldsname + "_lookup\"; \r\n ";
                            break;
                        case DATATYPES.DATE:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"" + ConvertTO.SqlDate(Current.Date) + "\"; \r\n ";
                            break;
                        case DATATYPES.DATETIME:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"" + ConvertTO.SqlDateTime(Current.Datetime) + "\"; \r\n ";
                            break;
                        case DATATYPES.BOOLX:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"True\"; \r\n ";
                            break;
                        case DATATYPES.DECMIAL_2:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"1.25\"; \r\n ";
                            break;
                        case DATATYPES.INT:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"9\"; \r\n ";
                            break;
                        case DATATYPES.SMALLINT:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"1\"; \r\n ";
                            break;
                        default:
                            ___result += "            obj." + list[r].Fieldsname.UpperFirst() + " = \"00\"; \r\n ";
                            break;
                    }

                }
            }

            ___result += "            obj.Notes = \"test notes\"; \r\n ";
            ___result += "            obj.Active_id = Core.Active; \r\n ";
            ___result += "            obj.User_id = Current.Codexsun; \r\n ";
            ___result += " \r\n ";
            ___result += "            C" + UPPERFIRST + ".Update(obj, new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "            DataTable tbl = C" + UPPERFIRST + "_exten.GetforLookup(new " + xDAL + "()); \r\n ";
            ___result += " \r\n ";
            ___result += "\r\n ";
            ___result += "            if (list.Count != 0)\r\n ";
            ___result += "            {\r\n ";
            ___result += "                for (int i = 0; i < list.Count; i++)\r\n ";
            ___result += "                {\r\n ";
            ___result += "                    Assert.AreEqual(Core.Active, (tbl.Rows[i][COUNTRY.ACTIVE_ID]) + \"\"); \r\n ";
            ___result += "                }\r\n ";
            ___result += "            }\r\n ";
            ___result += "\r\n ";
            ___result += "            #endregion[Lookup] \r\n ";
            ___result += " \r\n ";
            #endregion[Lookup]

            #region[Get id name] 
            ___result += "            #region[Get id name] \r\n ";
            ___result += "\r\n ";
            ___result += "            Assert.AreEqual(C" + UPPERFIRST + "_exten.GetId_Name(obj." + UPPERFIRST + "_name), obj." + UPPERFIRST + "_id + \"\"); \r\n ";
            ___result += "            Assert.AreEqual(C" + UPPERFIRST + "_exten.GetName_Id(obj." + UPPERFIRST + "_id), obj." + UPPERFIRST + "_name + \"\"); \r\n ";
            ___result += "\r\n ";
            ___result += "            C" + UPPERFIRST + ".Delete(obj." + UPPERFIRST + "_id, new DAL());\r\n ";
            ___result += "\r\n ";
            ___result += "            #endregion[Get id name] \r\n ";

            #endregion

            #region[result]
            ___result += "        } \r\n ";
            ___result += "\r\n ";
            ___result += "    }//cls\r\n";
            ___result += "}//ns\r\n";
            return ___result;
            #endregion[result]
        }
    }//cls
}//ns
