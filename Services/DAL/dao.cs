using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace abstractFactoryCSharp.DAL
{
    public class dao: IDisposable
    {
        private string _connString = "Data Source=DESKTOP-7U7FVAB\\SQLEXPRESS;Initial Catalog = Northwind; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection _myConnection;
        private SqlCommand _cmd;

        #region "Public Methods"
        public DataSet ExecuteGet(string _storedProcedureName, Dictionary<string,object> _parameters )
        {
            DataSet ds = new DataSet();

            _myConnection = new SqlConnection(_connString);
            _myConnection.Open();
           
            SqlDataAdapter sqlDr = new SqlDataAdapter(_storedProcedureName, _myConnection);
            sqlDr.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDr.SelectCommand.CommandTimeout = 900;

            foreach (var item in _parameters)
            {
                sqlDr.SelectCommand.Parameters.Add(SetParameter(item.Key, item.Value));
            }

            sqlDr.Fill(ds, "Employees");

            sqlDr.Dispose();
            _myConnection.Close();

            return ds;
        }

       public Boolean ExecuteNonQuery(string _storedProcedureName,Dictionary<string,object> _parameters)
        {
            _myConnection = new SqlConnection(_connString);
            _myConnection.Open();

            _cmd = new SqlCommand(_storedProcedureName, _myConnection);
            _cmd.CommandType = CommandType.StoredProcedure;

            foreach (var item in _parameters)
            {
               _cmd.Parameters.Add(SetParameter(item.Key,item.Value));
            }
            _cmd.ExecuteNonQuery();
            return true;
        }
        #region

        #region "Private Methods"
        private SqlParameter SetParameter (string key, object value)
        {
            SqlParameter parm = new SqlParameter();
            parm.ParameterName = key;
            parm.Value = value;
            return parm;
        }
        #region

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _myConnection.Dispose();
                    _cmd.Dispose();
                }

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}

