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
            ConnectionClass.GetConnect();
            InfoWorks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }              
    /// <summary>
    /// Open main menu form.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
        //string querySelectMasters = "SELECT * From masters";

        /// <summary>
        /// Сonclusion of orders when loading a form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoneWorks_Load(object sender, EventArgs e)
        {
            QueriesClass.SelectQuery(querySelectOrders, InfoWorks,1); // заменить на заказы
            countWorks.Text= "Количество выполненных работ: "+ (InfoWorks.RowCount-1);
        }
        int moveX, moveY, move;

        private void panel1_DoneWorks_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void panel1_DoneWorks_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panel1_DoneWorks_MouseUp(object sender, MouseEventArgs e)
        {
            move = 5;
        }
    }
}
