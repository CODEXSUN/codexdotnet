using System.Data;

namespace AXCODE
{
    public class DATATYPES
    {
        public const string VARCHAR_UNIQUE = "VARCHAR_UNIQUE";
        public const string VARCHAR_500 = "VARCHAR_500";
        public const string VARCHAR_300 = "VARCHAR_300";
        public const string VARCHAR_200 = "VARCHAR_200";
        public const string VARCHAR_100 = "VARCHAR_100";

        public const string UNIQUE_500 = "UNIQUE_500";

        public const string INT = "INT";

        public const string PRIMARY = "PRIMARY";
        public const string FORIEGN = "FORIEGN";

        public const string DATE = "DATE";
        public const string DATETIME = "DATETIME";

        public const string ENUM_Y_N = "ENUM_Y_N";
        public const string SMALLINT = "SMALLINT";

        public const string BOOLX = "BOOL";
        public const string FALSEX = "FALSE";
        public const string TRUEX = "TRUE";

        public const string DECMIAL_3 = "DECMIAL_3";
        public const string DECMIAL_2 = "DECMIAL_2";

        public const string DOUBLE = "DOUBLE";
        public const string LONGTEXT = "LONGTEXT";

    }

    public class Datatypes
    {
        public static DataTable Lookups()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(MASTERTABLESITEMS.DATATYPE, typeof(string));

            tbl.Rows.Add(DATATYPES.VARCHAR_500);
            tbl.Rows.Add(DATATYPES.VARCHAR_300);
            tbl.Rows.Add(DATATYPES.VARCHAR_200);

            tbl.Rows.Add(DATATYPES.UNIQUE_500);

            tbl.Rows.Add(DATATYPES.INT);

            tbl.Rows.Add(DATATYPES.PRIMARY);
            tbl.Rows.Add(DATATYPES.FORIEGN);

            tbl.Rows.Add(DATATYPES.DATE);
            tbl.Rows.Add(DATATYPES.DATETIME);

            tbl.Rows.Add(DATATYPES.ENUM_Y_N);
            tbl.Rows.Add(DATATYPES.SMALLINT);

            tbl.Rows.Add(DATATYPES.BOOLX);
            tbl.Rows.Add(DATATYPES.FALSEX);
            tbl.Rows.Add(DATATYPES.TRUEX);

            tbl.Rows.Add(DATATYPES.DECMIAL_3);
            tbl.Rows.Add(DATATYPES.DECMIAL_2);

            tbl.Rows.Add(DATATYPES.DOUBLE);
            tbl.Rows.Add(DATATYPES.LONGTEXT);

            return tbl;
        }
    }
}
