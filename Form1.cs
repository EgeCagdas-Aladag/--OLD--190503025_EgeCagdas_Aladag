using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Private_Musikschule_Verwaltungsanwendung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SQLiteConnection sqlite_connection;
            sqlite_connection = CreateConnection();
        }
        
        SQLiteConnection CreateConnection()
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
    }
}
