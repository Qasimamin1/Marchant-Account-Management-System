using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class ConnectionLayer
    {
       
        public SqlConnection _connection;        
        public ConnectionLayer()
        {
            _connection = new SqlConnection(@"Data Source=192.168.0.201;Initial Catalog=MAMS;User ID=xprt;Password=xprt;");
        }        
        public void ConnectionOpen()
        {
            if (_connection.ConnectionString=="")
            {
                _connection = new SqlConnection(@"Data Source=192.168.0.201;Initial Catalog=MAMS;User ID=xprt;Password=xprt;");
            }

            _connection.Open();

        }
        public void ConnectionClose()
        {
            _connection.Close();
        }


         
    }
}
