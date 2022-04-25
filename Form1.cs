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
        //SQLITE:
        private SQLiteConnection sqlite_connection;
        private SQLiteCommand sqlite_command;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database.sqlite_connection = Database.CreateConnection();
            Database.sqlite_command = Database.sqlite_connection.CreateCommand();
        }
        
        //Will be deleted once Database.cs is confirmed to be working alright.
        /*private SQLiteConnection CreateConnection()
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

            //Console.WriteLine("CONNECTED TO DATABASE.");
            return sqlite_connection;
        }*/

        private void loginButton_Click(object sender, EventArgs e)
        {
            //TODO Check login

            
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text;
            string password = passwordField.Text;


            if (username.Length > 4 && password.Length > 4)
            {
                Database.createNewUser(username,password);
                warningLabel.Text = "User created."; //UI stuff just for testing, will be removed from this function. Same for below.
                warningLabel.Visible = true;
            }
            else
            {
                warningLabel.Text = "Username and password must be longer than 4 characters.";
                warningLabel.Visible = true;
            }
                
        }

        
    }
}
