using Npgsql;
using System.IO;
using System.Windows.Forms;

namespace AgendaMais.Classes
{
    public class ConnectionDataBase
    {
        private static string path_config = Path.GetDirectoryName(Application.ExecutablePath) + "\\BD\\config.conf";
        private static string serverName = "127.0.0.1";                     //localhost
        private static string port = "5432";                                //porta default
        private static string userName = "postgres";                        //nome do administrador
        private static string password = "postgres";                        //senha do administrador
        private static string databaseName = "AgendaMais";          //nome do banco de dados
        private static NpgsqlConnection pgsqlConnection = null;

        public static NpgsqlConnection ConnectionDataBases()
        {
            if (File.Exists(path_config))
            {
                string[] config = File.ReadAllText(path_config).Split('|');
                serverName = config[0].Trim();
                port = config[1].Trim();
                userName = config[2].Trim();
                password = config[3].Trim();
                databaseName = config[4].Trim();
            }

            string connString = $"Server={serverName};Port={port};User Id={userName};Password={password};Database={databaseName};";//String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};Pooling=false;", serverName, port, userName, password, databaseName);

            pgsqlConnection = new NpgsqlConnection(connString);
            pgsqlConnection.Open();

            return pgsqlConnection;
        }
    }
}
