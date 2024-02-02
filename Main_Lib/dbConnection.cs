using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;

namespace Main_Lib
{
    public class dbConnection
    {
        private string _connectionString { get; set; }
        private NpgsqlConnection _connection { get; set; }
        public dbConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["p_flow"].ConnectionString;
            _connection = new NpgsqlConnection(_connectionString);
        }

        public NpgsqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
