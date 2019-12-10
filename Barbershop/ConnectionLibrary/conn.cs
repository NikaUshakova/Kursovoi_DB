using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConnectionLibrary
{
    public partial class conn: UserControl
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        static List<string[]> donework = new List<string[]>();
        
        public conn()
        {
            InitializeComponent();
            server = "localhost";
            database = "barbershop";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            
        }
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                // MessageBox.Show("Соединение установлено!");
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
       
        public  List<string[]> Sel(string query )
        {
            MessageBox.Show("hello");
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                donework.Clear();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    donework.Add(new string[6]);
                    donework[donework.Count - 1][0] = dataReader[0].ToString(); //id
                    donework[donework.Count - 1][1] = dataReader[1].ToString();//surname
                    donework[donework.Count - 1][2] = dataReader[2].ToString();//name
                    donework[donework.Count - 1][3] = dataReader[3].ToString();//patronymic
                    donework[donework.Count - 1][4] = dataReader[4].ToString();//ordername
                    donework[donework.Count - 1][5] = dataReader[5].ToString();//sumorder
                    //donework[donework.Count - 1][6] = dataReader[6].ToString();//date

                }
 /////////////////RefreshInfo();
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return donework;
            }
            else
            {
                return donework;
            }
        }
        // string querySelectMasters = "SELECT * From masters";
    
       
       

        //private void conn_Load(object sender, EventArgs e)
        //{
        //   // Sel(querySelectMasters);
        //}
        
    }
}
