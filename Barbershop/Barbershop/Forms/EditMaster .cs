﻿using System;
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
    public partial class EditMaster : Form
    {
        private readonly int id_master;
        public EditMaster(int id)
        {
            id_master = id;
            InitializeComponent();
            ConnectionClass.GetConnect();
          
        }       
       
        private void CloseExe_Click(object sender, EventArgs e)
        {
            
            MastersServices mas = new MastersServices();
            mas.Show();
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
       

        private void EditMaster_Load(object sender, EventArgs e)           
        {              
            LoadInf(id_master);           
        }
        public void LoadInf(int id_master)
        {            
            string query = "SELECT * FROM masters WHERE masters.id_master=" + id_master; 
            if (ConnectionClass.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, ConnectionClass.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    surname.Text = dataReader[1].ToString();
                    nameTB.Text = dataReader[2].ToString();
                    patronymic.Text = dataReader[3].ToString();
                    adress.Text = dataReader[4].ToString();
                    phoneNumber.Text = dataReader[5].ToString();
                }
                dataReader.Close();
                ConnectionClass.connection.Close();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string sur = surname.Text;
            string name = nameTB.Text;
            string patro = patronymic.Text;
            string adr = adress.Text;
            string ph = phoneNumber.Text;
            string queryUpdate = "UPDATE masters SET Surname = '"+sur+ "', Name = '" + name + "', Patronymic = '" + patro + "', Adress = '" + 
                                  adr + "', Phone = '" + ph + "' WHERE (id_master = " + id_master + ");";
            QueriesClass.QuerytoTable(queryUpdate);
            MessageBox.Show("Изменения сохранены!");
            this.Hide();

           MastersServices mas = new MastersServices();
            mas.Show();
        }

      

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && !(e.KeyChar == ',' && e.KeyChar == '/'))
                e.Handled = true;
            return;
        }

        private void patronymic_name_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Space && e.KeyChar != '-')
                e.Handled = true;
            return;
        }
        int moveX, moveY, move;

        private void panel1_EditMaster_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_EditMaster_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panel1_EditMaster_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }
    }
}
