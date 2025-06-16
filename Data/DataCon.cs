using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTIC_WindowsForm_By_Fazal.Data
{
    internal static class DataCon
    {
        private static string ConnectionString = "Data Source = UnicomTICDB.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            return conn;
        }
         
    }
}

