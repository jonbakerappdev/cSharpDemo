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
                SqlParameter parm = new SqlParameter();
                parm.ParameterName = item.Key;
                parm.Value = item.Value;
                sqlDr.SelectCommand.Parameters.Add(parm);
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
                SqlParameter parm = new SqlParameter();
                parm.ParameterName = item.Key;
                parm.Value = item.Value;
                _cmd.Parameters.Add(parm);
            }
            _cmd.ExecuteNonQuery();
            return true;
        }

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
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~dao() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion


    }
}

