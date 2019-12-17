﻿using System;
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
        //static List<string[]> donework = new List<string[]>();
        //static List<string[]> masters = new List<string[]>();
        //static List<string[]> service = new List<string[]>();
        // static DataGridView InfoWorksTable;
        static List<string[]> listName = new List<string[]>();
        public static List<string[]> SelectQuery(string query, DataGridView table)
        {
            int countColumn = table.ColumnCount;
            //List<string[]> listName = GetList(check);
            //Open connection
            if (ConnectionClass.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, ConnectionClass.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                listName.Clear();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    listName.Add(new string[countColumn]);
                    for (int i = 0; i < countColumn; i++)
                    {                        
                        listName[listName.Count - 1][i] = dataReader[i].ToString(); //get info from DB tables depending on the count of columns
                    }                               
                         
                }
                RefreshInfo(table);

                //close Data Reader
                dataReader.Close();

                //close Connection
                ConnectionClass.CloseConnection();

                //return list to be displayed
                return listName;
            }
            else
            {
                return listName;
            }
        }

        public static string SelectLabel(string query)
        {
            string result = "";
            //Open connection
            if (ConnectionClass.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, ConnectionClass.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                listName.Clear();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    result = dataReader.GetInt32(0).ToString();
                }           

                //close Data Reader
                dataReader.Close();

                //close Connection
                ConnectionClass.CloseConnection();

                //return list to be displayed
                return result;
            }
            else
            {
                return result;
            }
        }

        //private static List<string[]> GetList(int check)
        //{
        //    List<string[]> listName = new List<string[]>();
        //    switch (check)
        //    {
        //        case 1:
        //            {
        //                listName = donework;
        //                break;
        //            }
        //        case 2:                                                                    ПОХОЖЕ НАХЕР НАДО
        //            {
        //                listName = masters;
        //                break;
        //            }
        //        case 3:
        //            {
        //                listName = service;
        //                break;
        //            }

        //    }
        //    return listName;
        //}
        private static void RefreshInfo(DataGridView Info)
        {
           // List<string[]> listName = GetList(check);
            Info.Rows.Clear();
            for (int i = 0; i < listName.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Info.Rows.Add(listName[i]);
                    Info.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(251, 254, 254);
                }
                else
                {
                    Info.Rows.Add(listName[i]);
                    Info.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(223, 248, 248);
                }
            }

        }

        public static void QuerytoTable(string query)
        {
            try
            {
                          //open connection
                if (ConnectionClass.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, ConnectionClass.connection);
                    
                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    ConnectionClass.CloseConnection();
                }
            }
            catch
            {
                MessageBox.Show("Какая-то ошибка в твоей жизни");
                return;
            }
        }
    }
}
