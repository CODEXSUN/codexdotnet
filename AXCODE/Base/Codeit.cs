using System;
using System.Data;
using System.IO;

namespace AXCODE
{
    public class CodeIT
    {
        public static string NVersion
        {
            get
            {
                //return "Version : 2.0.0.0 dt : 16-10-2018";
                //return "Version : 2.1.0.0 dt : 04-12-2018";
                //return "Version : 2.2.0.0 dt : 15-03-2019";
                return "Version : 4.0.0.1 dt : 12-07-2020";
            }
        }
        public static string NPath
        {
            get
            {
                return (Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)).Replace(@"AXCODE\bin\Debug", "");
            }
        }
    }
    public class TBL
    {
        public string Tabel { get; set; }
        public string Alias { get; set; }
        public string DisplayName { get; set; }
        public string Namespaces { get; set; }
        public State WithSub { get; set; }
    }

    public class IPath
    {
        public string ContFolder { get; set; }
        public string ClassFolder { get; set; }
        public string FormFolder { get; set; }
        public string ListFolder { get; set; }
        public string SetupFolder { get; set; }
        public string TestFolder { get; set; }
    }

    public class Fields
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Type { get; set; }
        public INPUTTYPE Inputtype { get; set; }

        public string Width { get; set; }

        public ISDEFAULT Isdefault { get; set; }
        public bool Validate { get; set; }
        public string Cposition { get; internal set; }
        public string Rposition { get; internal set; }
    }


    public enum State
    {
        YES,
        NO,
        TRUE,
        FALSE
    }


    public enum INPUTTYPE
    {
        LookupBox,
        TextBox,
        DateBox,
        DateTimeBox,
        TimeBox,
        NumberBox,
        None,
        LookupFirst,
        TextBoxFirst,
        TextBox_BelowGridFirst,
        NumberBoxFirst,
        DateBoxFirst,
        DateTimeBoxFirst,
        TimeBoxFirst,


    }

    public enum WIDTH
    {

    }



    public class Find
    {
        //public void TxtLength_Point()
        //{
        //    string T = TxtLength_Point("Setup Database Test");

        //    //            Assert.AreEqual("275", T);
        //}


        public static string TxtLength_Point(string txt)
        {
            Double l = Convert.ToDouble(txt.Length);

            if (l > 8)
            {
                return Math.Round(((l + 3) / 8) * 100).ToString();
            }

            return "100";
        }
    }



    public class InputControls
    {
        public static string Datebox_format { get; set; } = "dd-MM-yyyy";
        public static string Datetimebox_format { get; set; } = "dd-MM-yyyy hh:mm:ss tt";
        public static string Timebox_format { get; set; } = "hh:mm:ss tt";

        public static string None { get; internal set; }

        public static string Lookupbox { get; set; }
        public static string Lookupbox_first { get; set; }
        public static string Textbox { get; set; }
        public static string Textbox_first { get; set; }
        public static string Numberbox { get; set; }
        public static string Numberbox_first { get; set; }
        public static string Datebox { get; set; }
        public static string Datebox_first { get; set; }
        public static string Datetimebox { get; set; }
        public static string Datetimebox_first { get; set; }
        public static string Timebox { get; set; }
        public static string Timebox_first { get; set; }
        public static string Textbox_belowgridfirst { get; set; }



        public const string NONE = "NONE";
        public const string LOOKUPBOX = "LOOKUPBOX";
        public const string LOOKUPBOX_FIRST = "LOOKUPBOX_FIRST";
        public const string TEXTBOX = "TEXTBOX";
        public const string TEXTBOX_FIRST = "TEXTBOX_FIRST";
        public const string NUMBERBOX = "NUMBERBOX";
        public const string NUMBERBOX_FIRST = "NUMBERBOX_FIRST";
        public const string DATEBOX = "DATEBOX";
        public const string DATEBOX_FIRST = "DATEBOX_FIRST";
        public const string DATETIMEBOX = "DATETIMEBOX";
        public const string DATETIMEBOX_FIRST = "DATETIMEBOX_FIRST";
        public const string TIMEBOX = "TIMEBOX";
        public const string TIMEBOX_FIRST = "TIMEBOX_FIRST";
        public const string TEXTBOX_BELOWGRIDFIRST = "TEXTBOX_BELOWGRIDFIRST";


        public static string Get(string c)
        {
            switch (c)
            {
                case LOOKUPBOX:
                    return "LookupBox";
                case TEXTBOX:
                    return "XTextBox";
                case NUMBERBOX:
                    return "XNumberBox"; ;
                case DATEBOX:
                    return "xDatepicker";
                case DATETIMEBOX:
                    return "xDateTimepicker";
                case TIMEBOX:
                    return "xTimepicker";

                case LOOKUPBOX_FIRST:
                    return "LookupBox";
                case TEXTBOX_FIRST:
                    return "XTextBox";
                case NUMBERBOX_FIRST:
                    return "XNumberBox";
                case DATEBOX_FIRST:
                    return "xDatepicker";
                case DATETIMEBOX_FIRST:
                    return "xDateTimepicker";
                case TIMEBOX_FIRST:
                    return "xTimepicker";
                case TEXTBOX_BELOWGRIDFIRST:
                    return "XTextBox";
            }
            return "";
        }


    }

    public enum ISDEFAULT
    {
        YES,
        NO
    }



    class CDir
    {
        public static string CheckDir(string vpath)
        {
            vpath = vpath.Replace(@"/", @"\");

            if (!Directory.Exists(@"" + vpath + ""))
            {
                Directory.CreateDirectory(@"" + vpath + "");
            }

            return vpath;
        }
    }

    public class AutoCode
    {
        public const string C1 = "1 Column";
        public const string C2 = "2 Column";
        public const string C3 = "3 Column";
        public const string C4 = "4 Column";

        public const string R1 = "1 Row";
        public const string R2 = "2 Row";
        public const string R3 = "3 Row";
        public const string R4 = "4 Row";

        public const string P1 = "1st";
        public const string P2 = "2nd";
        public const string P3 = "3rd";
        public const string P4 = "4th";

        public const string SAME_ROW = "SAME_ROW";
        public const string NEXT_ROW = "NEXT_ROW";

        public const string Left = "MiddleLeft";
        public const string Right = "MiddleRight";
        public const string Center = "MiddleCenter";

        public const string YES = "YES";
        public const string NO = "NO";


        public const string AboveGrid = "ABOVE GRID";
        public const string BelowGrid = "BELOW GRID";

        #region[GetCaption]
        public static string GetCaption(string tables_id, string v)
        {
            switch (tables_id)
            {
                case "1":
                    switch (v)
                    {
                        case "rdo_refer":
                            return "DELIVERED";
                        case "rdo_unrefer":
                            return "DELIVERED";
                        case "btn_quick":
                            return "DC";
                    }
                    break;
                case "2":
                    switch (v)
                    {
                        case "rdo_refer":
                            return "INVOICED";
                        case "rdo_unrefer":
                            return "INVOICED";
                        case "btn_quick":
                            return "INVOICE";
                    }
                    break;
                case "3":
                    switch (v)
                    {
                        case "rdo_refer":
                            return "RECEIPTED";
                        case "rdo_unrefer":
                            return "RECEIPTED";
                        case "btn_quick":
                            return "RECEIPT";
                    }
                    break;
                case "5":
                    switch (v)
                    {
                        case "rdo_refer":
                            return "N";
                        case "rdo_unrefer":
                            return "n";
                        case "btn_quick":
                            return "N";
                    }
                    break;
            }
            return v;
        }

        #endregion[GetCaption]

        #region[layout]
        /// 
        /// 1 column
        ///
        public const string R1_Label = "R1_Label";
        public const string R1_Text = "R1_Text";
        /// 
        /// 2 column
        ///
        public const string R1_2Label_1 = "R1_2Label_1";
        public const string R1_2Text_1 = "R1_2Text_1";

        public const string R1_2Label_2 = "R1_2Label_2";
        public const string R1_2Text_2 = "R1_2Text_2";

        ///****

        public const string R2_2Label_1 = "R2_2Label_1";
        public const string R2_2Text_1 = "R2_2Text_1";

        public const string R2_2Label_2 = "R2_2Label_2";
        public const string R2_2Text_2 = "R2_2Text_2";
        /// 
        /// 3 column
        /// 
        public const string R1_3Label_1 = "R1_3Label_1";
        public const string R1_3Text_1 = "R1_3Text_1";

        public const string R1_3Label_2 = "R1_3Label_2";
        public const string R1_3Text_2 = "R1_3Text_2";

        public const string R1_3Label_3 = "R1_3Label_3";
        public const string R1_3Text_3 = "R1_3Text_3";

        ///****

        public const string R2_3Label_1 = "R2_3Label_1";
        public const string R2_3Text_1 = "R2_3Text_1";

        public const string R2_3Label_2 = "R2_3Label_2";
        public const string R2_3Text_2 = "R2_3Text_2";

        public const string R2_3Label_3 = "R2_3Label_2";
        public const string R2_3Text_3 = "R2_3Text_2";

        /// 
        /// 4 column
        /// 
        public const string R1_4Label_1 = "R1_4Label_1";
        public const string R1_4Text_1 = "R1_4Text_1";

        public const string R1_4Label_2 = "R1_4Label_2";
        public const string R1_4Text_2 = "R1_4Text_2";

        public const string R1_4Label_3 = "R1_4Label_3";
        public const string R1_4Text_3 = "R1_4Text_3";

        public const string R1_4Label_4 = "R1_4Label_4";
        public const string R1_4Text_4 = "R1_4Text_4";

        ////****

        public const string R2_4Label_1 = "R2_4Label_1";
        public const string R2_4Text_1 = "R2_4Text_1";

        public const string R2_4Label_2 = "R2_4Label_2";
        public const string R2_4Text_2 = "R2_4Text_2";

        public const string R2_4Label_3 = "R2_4Label_3";
        public const string R2_4Text_3 = "R2_4Text_3";

        public const string R2_4Label_4 = "R2_4Label_4";
        public const string R2_4Text_4 = "R2_4Text_4";

        #endregion[layout]

        #region[GetCaption]
        public static string Quickbtn(string CAPITAL)
        {
            switch (CAPITAL)
            {
                case "PO":
                    return "Dc";
                case "DC":
                    return "Invoice";
            }
            return "";
        }
        #endregion[GetCaption]





        #region[Pkeys]

        //internal static DataTable Pkeys()
        //{
        //    DataTable tbl = new DataTable();
        //    tbl.Columns.Add(MTABLESITEMS.PKEYS, typeof(string));
        //    tbl.Rows.Add(PRIMARYKEY);
        //    tbl.Rows.Add(FOREIGNKEY);
        //    tbl.Rows.Add(UNIQUE);
        //    tbl.Rows.Add(NONE);
        //    return tbl;
        //}

        public const string PRIMARYKEY = "PRIMARY KEY";
        public const string FOREIGNKEY = "FOREIGN KEY";
        public const string UNIQUE = "UNIQUE";
        public const string NONE = "NONE";

        internal static string CheckKEYS(string keys)
        {
            string str;
            switch (keys)
            {
                case "MUL":
                    str = FOREIGNKEY;
                    break;
                case "PRI":
                    str = PRIMARYKEY;
                    break;
                case "UNI":
                    str = UNIQUE;
                    break;
                default:
                    str = NONE;
                    break;
            }
            return str;
        }

        #endregion[Pkeys]

        #region[ifnull]
        //internal static DataTable Ifnull()
        //{
        //    DataTable tbl = new DataTable();
        //    tbl.Columns.Add(MTABLESITEMS.IFNULL, typeof(string));
        //    tbl.Rows.Add(NOTNULL);
        //    tbl.Rows.Add(NULL);
        //    return tbl;
        //}

        public const string NOTNULL = "NOT NULL";
        public const string NULL = "NULL";

        internal static string CheckNULL(string nulls)
        {
            string str;
            switch (nulls)
            {
                case "NO":
                    str = NOTNULL;
                    break;
                default:
                    str = NULL;
                    break;
            }
            return str;
        }

        #endregion[ifnull]

        #region[Input Type]

        internal static DataTable InputType()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(MASTERTABLESITEMS.INPUTTYPE, typeof(string));

            tbl.Rows.Add(InputControls.TEXTBOX);
            tbl.Rows.Add(InputControls.LOOKUPBOX);
            tbl.Rows.Add(InputControls.NUMBERBOX);
            tbl.Rows.Add(InputControls.DATEBOX);
            tbl.Rows.Add(InputControls.DATETIMEBOX);
            tbl.Rows.Add(InputControls.NONE);
            tbl.Rows.Add(InputControls.TEXTBOX_FIRST);
            tbl.Rows.Add(InputControls.LOOKUPBOX_FIRST);
            tbl.Rows.Add(InputControls.NUMBERBOX_FIRST);
            tbl.Rows.Add(InputControls.DATEBOX_FIRST);
            tbl.Rows.Add(InputControls.DATETIMEBOX_FIRST);
            tbl.Rows.Add(InputControls.TEXTBOX_BELOWGRIDFIRST);

            return tbl;
        }
        #endregion[Input Type]

        #region[Width]

        internal static DataTable Width()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(MASTERTABLESITEMS.WIDTH, typeof(string));
            tbl.Rows.Add(C1);
            tbl.Rows.Add(C2);
            tbl.Rows.Add(C3);
            tbl.Rows.Add(C4);
            return tbl;
        }

        #endregion[Width]

        #region[Height]

        internal static DataTable Height()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(MASTERTABLESITEMS.HEIGHT, typeof(string));
            tbl.Rows.Add(R1);
            tbl.Rows.Add(R2);
            tbl.Rows.Add(R3);
            tbl.Rows.Add(R4);
            return tbl;
        }
        //public const string R1 = "1 Row";
        //public const string R2 = "2 Row";
        //public const string R3 = "3 Row";
        //public const string R4 = "4 Row";

        #endregion[Height]

        #region[Cposition]

        internal static DataTable Cposition()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(MASTERTABLESITEMS.CPOSITION, typeof(string));
            tbl.Rows.Add(P1);
            tbl.Rows.Add(P2);
            tbl.Rows.Add(P3);
            tbl.Rows.Add(P4);
            return tbl;
        }

        //public const string P1 = "1st";
        //public const string P2 = "2nd";
        //public const string P3 = "3rd";
        //public const string P4 = "4th";

        #endregion[Cposition]

        #region[Rposition]

        internal static DataTable Rposition()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(MASTERTABLESITEMS.RPOSITION, typeof(string));
            tbl.Rows.Add(NEXT_ROW);
            tbl.Rows.Add(SAME_ROW);
            return tbl;
        }

        //public const string SAME_ROW = "SAME_ROW";
        //public const string NEXT_ROW = "NEXT_ROW";

        #endregion[Rposition]

        #region[Alignto]

        internal static DataTable Alignto()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(SFIELDS.ALIGNTO, typeof(string));
            tbl.Rows.Add(Left);
            tbl.Rows.Add(Right);
            tbl.Rows.Add(Center);
            return tbl;
        }

        //public const string Left = "MiddleLeft";
        //public const string Right = "MiddleRight";
        //public const string Center = "MiddleCenter";

        #endregion[Cposition]

        #region[Validate]

        internal static DataTable Validate()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(MASTERTABLESITEMS.VALIDATE, typeof(string));
            tbl.Rows.Add(NO);
            tbl.Rows.Add(YES);
            return tbl;
        }

        //public const string YES = "YES";
        //public const string NO = "NO";

        #endregion[Validate]

        #region[IsDefault]

        internal static DataTable IsDefault()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(MASTERTABLESITEMS.ISDEFAULT, typeof(string));
            tbl.Rows.Add(NO);
            tbl.Rows.Add(YES);
            return tbl;
        }

        #endregion[IsDefault]

        #region[Placement]

        internal static DataTable Placement()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(SFIELDS.PLACEMENT, typeof(string));
            tbl.Rows.Add(AboveGrid);
            tbl.Rows.Add(BelowGrid);
            return tbl;
        }

        internal static DataTable Readonly()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(SFIELDS.READONLY, typeof(string));
            tbl.Rows.Add("No");
            tbl.Rows.Add("Readonly");
            return tbl;
        }

        //public const string AboveGrid = "ABOVE GRID";
        //public const string BelowGrid = "BELOW GRID";

        #endregion[Placement]

        //#region[Readonly]

        //internal static DataTable Readonly()
        //{
        //    DataTable tbl = new DataTable();
        //    tbl.Columns.Add(SFIELDS.READONLY, typeof(string));
        //    tbl.Rows.Add(NO);
        //    tbl.Rows.Add(YES);
        //    return tbl;
        //}

        //#endregion[Readonly]

        //#region[GetCaption]
        //public static string GetCaption(string tables_id, string v)
        //{
        //    switch (tables_id)
        //    {
        //        case "1":
        //            switch (v)
        //            {
        //                case "rdo_refer":
        //                    return "DELIVERED";
        //                case "rdo_unrefer":
        //                    return "DELIVERED";
        //                case "btn_quick":
        //                    return "DC";
        //            }
        //            break;
        //        case "2":
        //            switch (v)
        //            {
        //                case "rdo_refer":
        //                    return "INVOICED";
        //                case "rdo_unrefer":
        //                    return "INVOICED";
        //                case "btn_quick":
        //                    return "INVOICE";
        //            }
        //            break;
        //        case "3":
        //            switch (v)
        //            {
        //                case "rdo_refer":
        //                    return "RECEIPTED";
        //                case "rdo_unrefer":
        //                    return "RECEIPTED";
        //                case "btn_quick":
        //                    return "RECEIPT";
        //            }
        //            break;
        //        case "5":
        //            switch (v)
        //            {
        //                case "rdo_refer":
        //                    return "N";
        //                case "rdo_unrefer":
        //                    return "n";
        //                case "btn_quick":
        //                    return "N";
        //            }
        //            break;
        //    }
        //    return v;
        //}

        //#endregion[GetCaption]

        //#region[layout]
        ///// 
        ///// 1 column
        /////
        //public const string R1_Label = "R1_Label";
        //public const string R1_Text = "R1_Text";
        ///// 
        ///// 
        ///// 2 column
        /////
        //public const string R1_2Label_1 = "R1_2Label_1";
        //public const string R1_2Text_1 = "R1_2Text_1";

        //public const string R1_2Label_2 = "R1_2Label_2";
        //public const string R1_2Text_2 = "R1_2Text_2";

        /////****

        //public const string R2_2Label_1 = "R2_2Label_1";
        //public const string R2_2Text_1 = "R2_2Text_1";

        //public const string R2_2Label_2 = "R2_2Label_2";
        //public const string R2_2Text_2 = "R2_2Text_2";
        ///// 
        ///// 3 column
        ///// 
        //public const string R1_3Label_1 = "R1_3Label_1";
        //public const string R1_3Text_1 = "R1_3Text_1";

        //public const string R1_3Label_2 = "R1_3Label_2";
        //public const string R1_3Text_2 = "R1_3Text_2";

        //public const string R1_3Label_3 = "R1_3Label_3";
        //public const string R1_3Text_3 = "R1_3Text_3";

        /////****

        //public const string R2_3Label_1 = "R2_3Label_1";
        //public const string R2_3Text_1 = "R2_3Text_1";

        //public const string R2_3Label_2 = "R2_3Label_2";
        //public const string R2_3Text_2 = "R2_3Text_2";

        //public const string R2_3Label_3 = "R2_3Label_2";
        //public const string R2_3Text_3 = "R2_3Text_2";

        ///// 
        ///// 4 column
        ///// 
        //public const string R1_4Label_1 = "R1_4Label_1";
        //public const string R1_4Text_1 = "R1_4Text_1";

        //public const string R1_4Label_2 = "R1_4Label_2";
        //public const string R1_4Text_2 = "R1_4Text_2";

        //public const string R1_4Label_3 = "R1_4Label_3";
        //public const string R1_4Text_3 = "R1_4Text_3";

        //public const string R1_4Label_4 = "R1_4Label_4";
        //public const string R1_4Text_4 = "R1_4Text_4";

        //////****

        //public const string R2_4Label_1 = "R2_4Label_1";
        //public const string R2_4Text_1 = "R2_4Text_1";

        //public const string R2_4Label_2 = "R2_4Label_2";
        //public const string R2_4Text_2 = "R2_4Text_2";

        //public const string R2_4Label_3 = "R2_4Label_3";
        //public const string R2_4Text_3 = "R2_4Text_3";

        //public const string R2_4Label_4 = "R2_4Label_4";
        //public const string R2_4Text_4 = "R2_4Text_4";

        //#endregion[layout]

        //#region[GetCaption]
        //public static string Quickbtn(string CAPITAL)
        //{
        //    switch (CAPITAL)
        //    {
        //        case "PO":
        //            return "Dc";
        //        case "DC":
        //            return "Invoice";
        //    }
        //    return "";
        //}
        //#endregion[GetCaption]
    }
}