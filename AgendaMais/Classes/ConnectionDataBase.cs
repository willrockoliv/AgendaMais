using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace AgendaMais.Classes
{
    public class ConnectionDataBase
    {
        private static string serverName = "127.0.0.1";                     //localhost
        private static string port = "5432";                                //porta default
        private static string userName = "postgres";                        //nome do administrador
        private static string password = "postgres";                        //senha do administrador
        private static string databaseName = "AgendaMais";          //nome do banco de dados
        private static NpgsqlConnection pgsqlConnection = null;

        public static NpgsqlConnection ConnectionDataBases()
        {
            string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};Pooling=false;",
                                        serverName, port, userName, password, databaseName);

            pgsqlConnection = new NpgsqlConnection(connString);
            pgsqlConnection.Open();

            return pgsqlConnection;
        }
    }
}
