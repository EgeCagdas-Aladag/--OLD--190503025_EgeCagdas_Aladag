using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Private_Musikschule_Verwaltungsanwendung;
{
    static class Database
    {

        public static SQLiteConnection sqlite_connection { get; set; }
        public static SQLiteCommand sqlite_command { get; set; }

        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_connection;
            sqlite_connection = new SQLiteConnection(@"DataSource=D:\INF202 Project\Private Musikschule Verwaltungsanwendung\Private Musikschule Verwaltungsanwendung\Data\MusicSchool.db;" +
                "Version=3;");
            try
            {
                sqlite_connection.Open();
            }
            catch (Exception e)
            {
                //TODO: Catch exception
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("CONNECTED TO DATABASE.");
            return sqlite_connection;
        }

        public static void createNewUser(string username, string password)
        {
            //TODO: Use SQLiteCommand.Parameters.Add to create command - will be safe against SQLInjection.
            sqlite_command.ExecuteNonQuery();
        }
    }
}
