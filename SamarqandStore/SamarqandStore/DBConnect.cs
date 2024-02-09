using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SamarqandStore
{
    class DBConnect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-C6O8MQ3;Initial Catalog=samarqand;Integrated Security=True");

        public SqlConnection GetCon()
        {
            return connection;
        }

        public void OpenCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    } 

}
