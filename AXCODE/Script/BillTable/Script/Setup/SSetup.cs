﻿using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SSetup
    {
        public static void XSetup(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.SPath.Setupfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\" + tbl_name + "_Tbl.cs", result);
        }

        #region []

        private static string XCreate(BillTable obj)
        {
            List<SFields> list = obj.SFields;
            List<SFieldsItems> Slist = obj.SFieldsItems;

            string vtablesname = obj.STables.Stables_name;

            string vnamespaces = obj.STables.Namespaces_id;

            //string TABLENAME = vtablesname.ToUpper();

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

            //___result += "using CXSETUP; \r\n";
            ___result += "using CXLIB; \r\n";
            ___result += "\r\n";
            #endregion[using]

            #region[Table]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{\r\n";
            ___result += "    public class " + UPPERFIRST + "_Tbl\r\n";
            ___result += "    {\r\n";
            ___result += "        #region[Create Table]\r\n";
            ___result += "\r\n";
            ___result += "        public " + UPPERFIRST + "_Tbl (string db)\r\n";
            ___result += "        {\r\n";
            ___result += "            string q = USE.DB(db);\r\n";
            ___result += "\r\n";
            ___result += "            q += CREATE.TABLE(" + CAPITAL + "." + CAPITAL + "_TBL);\r\n";
            ___result += "            q += AddFields.Primary(" + CAPITAL + "." + CAPITAL + "_ID);\r\n";

            ___result += "            q += AddFields.Unique_500(" + CAPITAL + ".UNIQUENO);\r\n";
            ___result += "            q += AddFields.Foreign(" + CAPITAL + "." + CAPITAL + "_TBL, " + CAPITAL + ".COMPANY_ID);\r\n";
            ___result += "            q += AddFields.Foreign(" + CAPITAL + "." + CAPITAL + "_TBL, " + CAPITAL + ".ACY_ID);\r\n";


            for (int r = 0; r < list.Count; r++)
            {
                switch (list[r].Datatype)

                {

                    case DATATYPES.VARCHAR_500:
                        ___result += "            q += AddFields.VARCHAR_500(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.VARCHAR_300:
                        ___result += "            q += AddFields.VARCHAR_300(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.VARCHAR_200:
                        ___result += "            q += AddFields.VARCHAR_200(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.VARCHAR_100:
                        ___result += "            q += AddFields.VARCHAR_100(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.UNIQUE_500:
                        ___result += "            q += AddFields.Unique_500(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.INT:
                        ___result += "            q += AddFields.Int(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.FORIEGN:
                        ___result += "            q += AddFields.Foreign(" + CAPITAL + "." + CAPITAL + "_TBL, " + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;


                    case DATATYPES.DATE:
                        ___result += "            q += AddFields.Date(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.DATETIME:
                        ___result += "            q += AddFields.DateTime(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.ENUM_Y_N:
                        ___result += "            q += AddFields.Enum_y_n(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;
                    case DATATYPES.SMALLINT:
                        ___result += "            q += AddFields.Smallint(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.BOOLX:
                        ___result += "            q += AddFields.BoolX(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;
                    case DATATYPES.FALSEX:
                        ___result += "            q += AddFields.FalseX(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;
                    case DATATYPES.TRUEX:
                        ___result += "            q += AddFields.TrueX(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.DECMIAL_3:
                        ___result += "            q += AddFields.Decimal_3(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.DECMIAL_2:
                        ___result += "            q += AddFields.Decimal_2(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.DOUBLE:
                        ___result += "            q += AddFields.Double(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;
                    case DATATYPES.LONGTEXT:
                        ___result += "            q += AddFields.Longtext(" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                }
            }
            ___result += "            q += AddFields.Notes;\r\n";
            ___result += "            q += AddFields.Active;\r\n";
            ___result += "            q += AddFields.User_id(" + CAPITAL + "." + CAPITAL + "_TBL);\r\n";
            ___result += "            q += AddFields.EOF;\r\n";
            ___result += "\r\n";
            ___result += "            new " + xDAL + "().Execute(q);\r\n";
            ___result += "\r\n";
            ___result += "            " + UPPERFIRST + "Items_Tbl(db);\r\n";
            ___result += "\r\n";
            ___result += "        }\r\n";
            ___result += "        #endregion[Table]\r\n";
            ___result += "\r\n";

            #endregion[Table]

            #region[Table items]

            ___result += "        #region[Table Items]\r\n";
            ___result += "\r\n";
            ___result += "        public static void " + UPPERFIRST + "Items_Tbl(string db)\r\n";
            ___result += "        {\r\n";
            ___result += "            string q = USE.DB(db);\r\n";
            ___result += "\r\n";
            ___result += "            q += CREATE.TABLE(" + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_TBL);\r\n";
            ___result += "            q += AddFields.Primary(" + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_ID);\r\n";

            for (int r = 0; r < Slist.Count; r++)
            {
                switch (Slist[r].Datatype)

                {

                    case DATATYPES.VARCHAR_500:
                        ___result += "            q += AddFields.VARCHAR_500(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.VARCHAR_300:
                        ___result += "            q += AddFields.VARCHAR_300(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.VARCHAR_200:
                        ___result += "            q += AddFields.VARCHAR_200(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.VARCHAR_100:
                        ___result += "            q += AddFields.VARCHAR_100(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.UNIQUE_500:
                        ___result += "            q += AddFields.Unique_500(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.INT:
                        ___result += "            q += AddFields.Int(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.FORIEGN:
                        ___result += "            q += AddFields.Foreign(" + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_TBL, " + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;


                    case DATATYPES.DATE:
                        ___result += "            q += AddFields.Date(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.DATETIME:
                        ___result += "            q += AddFields.DateTime(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.ENUM_Y_N:
                        ___result += "            q += AddFields.Enum_y_n(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;
                    case DATATYPES.SMALLINT:
                        ___result += "            q += AddFields.Smallint(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.BOOLX:
                        ___result += "            q += AddFields.BoolX(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;
                    case DATATYPES.FALSEX:
                        ___result += "            q += AddFields.FalseX(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;
                    case DATATYPES.TRUEX:
                        ___result += "            q += AddFields.TrueX(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.DECMIAL_3:
                        ___result += "            q += AddFields.Decimal_3(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.DECMIAL_2:
                        ___result += "            q += AddFields.Decimal_2(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                    case DATATYPES.DOUBLE:
                        ___result += "            q += AddFields.Double(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;
                    case DATATYPES.LONGTEXT:
                        ___result += "            q += AddFields.Longtext(" + CAPITAL + "ITEMS." + Slist[r].Fieldsname.ToUpper() + "); \r\n";
                        break;

                }
            }
            ___result += "            q += AddFields.EOF;\r\n";
            ___result += "\r\n";
            ___result += "            new " + xDAL + "().Execute(q);\r\n";
            ___result += "\r\n";
            ___result += "        }\r\n";
            ___result += "        #endregion[Table Items]\r\n";
            ___result += "\r\n";

            #endregion[Tables Items]

            #region[result]
            ___result += "    }//cls\r\n";
            ___result += "}//ns\r\n";
            return ___result;
            #endregion[result]
        }
    }//cls
}//ns
