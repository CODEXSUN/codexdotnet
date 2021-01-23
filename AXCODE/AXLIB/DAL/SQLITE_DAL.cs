using System;
using System.Data;
using System.Data.SQLite;

namespace AXCODE
{
    public class SQLITE_DAL
    {
        private static string CONNECTION_STRING;
        private SQLiteConnection mysqlCon;
        private SQLiteTransaction mysqlTran;
        static SQLITE_DAL()
        {

            string currentFolder = (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)).Replace(@"AXCODE\bin\Debug", "");

            string Db = currentFolder + @"AXCODE\SqliteDB\Data\CODEIT.sqlite";

            CONNECTION_STRING = ("Data Source=" + Db + ";Version=3;");
        }
        public SQLITE_DAL()
        {
            mysqlCon = new SQLiteConnection()
            {
                ConnectionString = CONNECTION_STRING
            };
        }
        #region[Listdata ]

        public DataTable Listdata(string sql)
        {
            DataSet ds = new DataSet();

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, mysqlCon);
            if (mysqlTran != null)
            {
                da.SelectCommand.Transaction = mysqlTran;
            }
            System.Diagnostics.Debug.WriteLine(sql);
            da.Fill(ds);
            DataTable tbl = ds.Tables[0];
            return tbl;

        }

        public IDataReader Listreader(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, mysqlCon);

            if (mysqlTran != null) { cmd.Transaction = mysqlTran; }
            if (mysqlTran == null)
            {
                if (mysqlCon.State != ConnectionState.Closed)
                {
                    mysqlCon.Close();
                }

                mysqlCon.Open();
            }

            System.Diagnostics.Debug.WriteLine(sql);

            return cmd.ExecuteReader();
        }

        #endregion

        #region [ Execute ]

        public void Execute(string sql)
        {
            try
            {

                SQLiteCommand cmd = new SQLiteCommand(sql, mysqlCon);
                if (mysqlTran != null) { cmd.Transaction = mysqlTran; }
                if (mysqlTran == null) { mysqlCon.Open(); }
                System.Diagnostics.Debug.WriteLine(sql);
                cmd.ExecuteNonQuery();

            }
            finally
            {
                if (mysqlTran == null)
                {
                    if (mysqlCon.State != ConnectionState.Closed)
                    {
                        mysqlCon.Close();
                    }
                }
            }

        }

        #endregion [ Execute ]

        #region [ Execute Scalar ]
        public object ExecuteScalar(string sql)
        {
            object res = "";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, mysqlCon);
                if (mysqlTran != null)
                {
                    cmd.Transaction = mysqlTran;
                }
                if (mysqlTran == null) { mysqlCon.Open(); }
                res = cmd.ExecuteScalar();
            }
            finally
            {
                if (mysqlTran == null)
                {
                    if (mysqlCon.State != ConnectionState.Closed)
                    {
                        mysqlCon.Close();
                    }
                }
            }

            return res;
        }

        #endregion [ Execute ]

        #region [ Begin transaction ]
        public void BeginTransaction()
        {
            if (mysqlTran != null)
            {
                throw new Exception("Can not create a db transction when one already exists.");
            }
            mysqlCon.Open();
            mysqlTran = mysqlCon.BeginTransaction();
        }

        #endregion [ Begin transaction ]

        #region [ Commit ]

        public void Commit()
        {

            mysqlTran.Commit();
            mysqlTran = null;
            mysqlCon.Close();
            mysqlCon = null;
        }

        #endregion [ Commit ]

        #region [ rollback]

        public void Rollback()
        {
            if (mysqlTran != null)
            {
                mysqlTran.Rollback();
                mysqlTran = null;
            }
            if (mysqlCon != null)
            {
                if (mysqlCon.State != ConnectionState.Closed)
                {

                    mysqlCon.Close();
                    mysqlCon = null;
                }
            }
        }

        #endregion [ rollback]

        public static string GetIdentity(SQLITE_DAL dalsession)
        {
            string q = "SELECT last_insert_rowid()";
            return (dalsession.ExecuteScalar(q)).ToString();
        }

    }//cls
}//ns
