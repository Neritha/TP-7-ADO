using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class Connection
    {
        private static string connectionString = "server=btssio.dedyn.io; port=3306; Database=CARREVIC_PPE4; Uid=CARREVIC; password=16012004";

        //private MySqlConnection maConnection;

        private static MySqlConnection maConnection = new MySqlConnection(connectionString);

        public static MySqlConnection MaConnection { get => maConnection; }
    }
}
