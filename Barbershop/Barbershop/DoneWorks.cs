using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConnectionLibrary;

namespace Barbershop
{
    public partial class DoneWorks : Form
    {
       
        public DoneWorks()
        {
            InitializeComponent();         
        }
        conn conn = new conn();
        List<string[]> donework = new List<string[]>();
        public List<string[]> SelectOrders()
        {
            string query = "SELECT masters.id_master,masters.Surname,masters.Name,masters.Patronymic," +
             " orders.Name, orders.Sum, orders.Date from masters " +
             " JOIN orders ON masters.id_master=orders.id_master Group BY masters.id_master";

            //Open connection
            if (conn.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                donework.Clear();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    donework.Add(new string[7]);
                    donework[donework.Count - 1][0] = dataReader[0].ToString(); //id
                    donework[donework.Count - 1][1] = dataReader[1].ToString();//surname
                    donework[donework.Count - 1][2] = dataReader[2].ToString();//name
                    donework[donework.Count - 1][3] = dataReader[3].ToString();//patronymic
                    donework[donework.Count - 1][4] = dataReader[4].ToString();//ordername
                    donework[donework.Count - 1][5] = dataReader[5].ToString();//sumorder
                    donework[donework.Count - 1][6] = dataReader[6].ToString();//date

                }
                RefreshInfo();
                //close Data Reader
                dataReader.Close();

                //close Connection
                conn.CloseConnection();

                //return list to be displayed
                return donework;
            }
            else
            {
                return donework;
            }
        }
        public void RefreshInfo()
        {
            InfoWorks.Rows.Clear();
            for (int i = 0; i < donework.Count; i++)
            {
                if (i % 2 == 0)
                {
                    InfoWorks.Rows.Add(donework[i]);
                    InfoWorks.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(222, 236, 255);
                }
                else
                {
                    InfoWorks.Rows.Add(donework[i]);
                    InfoWorks.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(243, 248, 255);
                }

            }
        }
        private void CloseExe_Click(object sender, EventArgs e)
        {
            
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void CloseExe_MouseLeave(object sender, EventArgs e)
        {
            CloseExe.Size = new Size(22,22);
        }

        private void CloseExe_MouseMove(object sender, MouseEventArgs e)
        {
            CloseExe.Size = new Size(23, 23);
        }


        /// <summary>
        /// queries
        /// </summary>
        string querySelectOrders = "SELECT masters.id_master,masters.Surname,masters.Name,masters.Patronymic," +
             " orders.Name, orders.Sum, orders.Date from masters " +
             " JOIN orders ON masters.id_master=orders.id_master Group BY masters.id_master";
        string querySelectMasters = "SELECT * From masters";
        
        private void DoneWorks_Load(object sender, EventArgs e)
        {
          
        }

        
        

        
    }
}
