using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
// C# Project by Aviad Kattav 305200446, Shahar Alaluf 038101507

namespace WindowsFormsApplication1
{
    public class DbAccess
    {
        #region Constructor +  Members
        protected OleDbConnection _conn = null;

        public DbAccess(string connectionstring)
        {
            _conn = new OleDbConnection(connectionstring);
        }
        #endregion

        #region Protected Methodds

        protected void Connect() // Connect to DB
        {
            if (_conn.State !=ConnectionState.Open)
            {
                _conn.Open();
            }
        }
        protected void Disconnect() // Disconnect from DB
        {
            _conn.Close();
        }

        protected void ExecuteSimpleQuery(OleDbCommand command) // Execute a simple query from DB
        {
            lock(_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    command.ExecuteNonQuery();
                }
                finally
                {
                    Disconnect();
                }
            }

        }
        protected int ExecuteScalarIntQuery(OleDbCommand command) // Execute a query returning an int, from DB
        {
            int ret = -1;
            lock(_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    ret = (int)command.ExecuteScalar();
                }
                finally
                {
                    Disconnect();
                }
            }
            return ret;
        }

        protected string ExecuteStringQuery(OleDbCommand command) // Execute a query returning a string, from DB
        {
            string ret = string.Empty;
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    ret = (string)command.ExecuteScalar();
                }
                finally
                {
                    Disconnect();
                }
            }
            return ret;
        }

        protected DataSet GetMulipleQuery(OleDbCommand command) // Execute a multiple results query from DB
        {

            DataSet dataset = new DataSet();
            lock(_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dataset);
                }
                finally
                {
                    Disconnect();
                }
            }
            return dataset;
        }
        #endregion

    }
}
