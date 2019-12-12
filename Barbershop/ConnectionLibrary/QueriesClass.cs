using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace ConnectionLibrary
{
    /// <summary>
    /// Class contains queries for the databases 
    /// </summary>
    public static class  QueriesClass
    {
        static List<string[]> donework = new List<string[]>();
        static List<string[]> masters = new List<string[]>();
        // static DataGridView InfoWorksTable;
        public static List<string[]> SelectOrders(string query, DataGridView Info, int casenumber)
        {
                       //Open connection
            if (ConnectionClass.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, ConnectionClass.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                donework.Clear();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    switch (casenumber)
                    {
                        case 1:
                            {
                                donework.Add(new string[6]);
                                donework[donework.Count - 1][0] = dataReader[0].ToString(); //id
                                donework[donework.Count - 1][1] = dataReader[1].ToString();//surname
                                donework[donework.Count - 1][2] = dataReader[2].ToString();//name
                                donework[donework.Count - 1][3] = dataReader[3].ToString();//patronymic
                                donework[donework.Count - 1][4] = dataReader[4].ToString();//ordername
                                donework[donework.Count - 1][5] = dataReader[5].ToString();//sumorder
                                                                          // donework[donework.Count - 1][6] = dataReader[6].ToString();//date
                                RefreshInfo(Info, 1);
                                break;
                            }
                        case 2:
                            {
                                masters.Add(new string[6]);
                                masters[masters.Count - 1][0] = dataReader[0].ToString(); //id
                                masters[masters.Count - 1][1] = dataReader[1].ToString();//surname
                                masters[masters.Count - 1][2] = dataReader[2].ToString();//name
                                masters[masters.Count - 1][3] = dataReader[3].ToString();//patronymic
                                masters[masters.Count - 1][4] = dataReader[4].ToString();//adress
                                masters[masters.Count - 1][5] = dataReader[5].ToString();//phone
                                RefreshInfo(Info,2);
                                break;
                            }
                    }
                    
                }
               
                //close Data Reader
                dataReader.Close();

                //close Connection
                ConnectionClass.CloseConnection();

                //return list to be displayed
                return donework;
            }
            else
            {
                return donework;
            }
        }
        public static void RefreshInfo(DataGridView Info, int check)
        {
            List <string []>listName = new List<string[]>();
            switch (check)
            {
                case 1:
                    {
                        listName = donework;
                        break;
                    }
                case 2:
                    {
                        listName = masters;
                        break;
                    }
            }
            Info.Rows.Clear();
            for (int i = 0; i < listName.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Info.Rows.Add(listName[i]);
                    Info.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(222, 236, 255);
                }
                else
                {
                    Info.Rows.Add(listName[i]);
                    Info.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(243, 248, 255);
                }
            }

        }
    }
}
