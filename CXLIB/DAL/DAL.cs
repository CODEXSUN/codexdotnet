using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CXLIB
{
    public class DAL
    {
        private static readonly string CONNECTION_STRING;
        private MySqlConnection mysqlCon;
        private MySqlTransaction mysqlTran;

        #region[DAL]

        static DAL()
        {
            CONNECTION_STRING = "Server=" + Server.DBHOST + ";Port=" + Server.DBPORT + "; Database=" + Server.DBNAME + "; User Id=" + Server.DBUSER + "; Password=" + Server.DBPASS + "; pooling=true;";//pooling=true; connection timeout=28800;
        }

        public DAL()
        {
            mysqlCon = new MySqlConnection()
            {
                ConnectionString = CONNECTION_STRING
            };
        }

        #endregion[DAL]

        #region[Listdata ]

        public DataTable Listdata(string sql)
        {
            DataSet ds = new DataSet();

            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlCon);
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
            MySqlCommand cmd = new MySqlCommand(sql, mysqlCon);

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

           return  cmd.ExecuteReader();
        }


        #endregion

        #region [ Execute ]

        public void Execute(string sql)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, mysqlCon);
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
                MySqlCommand cmd = new MySqlCommand(sql, mysqlCon);
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

        #region[GetIdentity]

        public static string GetIdentity(DAL dalsession)
        {
            string q = "select @@identity";
            return (dalsession.ExecuteScalar(q)).ToString();
        }

        #endregion[GetIdentity]

    }//cls
}//ns
