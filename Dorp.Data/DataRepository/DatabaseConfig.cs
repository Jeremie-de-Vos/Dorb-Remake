using Dorp.Data.DataClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Dorp.Data.DataRepository
{
    class DatabaseConfig
    {
        //Create-And-Return-ConnectionString
        public static string ConnectionString =>
            "datasource = " + DatabaseData.datasource + "; username = " + DatabaseData.username + "; password=" + DatabaseData.password + "; database = " + DatabaseData.database + ";SslMode=none";

        //Return-Open-SQLconnection
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            return connection;
        }
    }   
}
