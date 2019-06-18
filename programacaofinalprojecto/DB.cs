
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace programacaofinalprojecto
{
    class DB
    {

        SqlConnection connection = null;
     
       
        public void connect ()
        {
            connection = new SqlConnection(Properties.Settings.Default.Connection);
        }
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }


        }


        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


        public SqlConnection getConnection()
        {
            return connection;
        }


        }
    }
