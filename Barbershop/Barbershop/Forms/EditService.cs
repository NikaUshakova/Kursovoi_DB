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
    public partial class EditService : Form
    {
        private readonly int id_service;
        public EditService(int id)
        {
            id_service = id;
            InitializeComponent();
            ConnectionClass.GetConnect();
          
        }       
       
        private void CloseExe_Click(object sender, EventArgs e)
        {
           var mas = new MastersServices();
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
       

        private void EditService_Load(object sender, EventArgs e)           
        {              
            LoadInf(id_service);           
        }
        public void LoadInf(int id_master)
        {            
            string query = "SELECT * FROM service WHERE service.id_service=" + id_service; 
            if (ConnectionClass.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, ConnectionClass.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    nameService.Text = dataReader[1].ToString();
                    price.Text = dataReader[2].ToString();
                }
                dataReader.Close();
                ConnectionClass.connection.Close();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string ser = nameService.Text;
            int pr = int.Parse(price.Text);
           
            string queryUpdate = "UPDATE service SET name_service = '"+ser+ "', price = " + pr + " WHERE (id_service = " + id_service + ");";
            QueriesClass.QuerytoTable(queryUpdate);
            MessageBox.Show("Изменения сохранены!");
            this.Hide();

            MastersServices mas = new MastersServices();
            mas.Show();
        }

      

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && !(e.KeyChar == ',' && e.KeyChar == '/'))
                e.Handled = true;
            return;
        }

        int moveX, moveY, move;

        private void panel1_EditService_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_EditService_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panel1_EditService_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }
    }
}
