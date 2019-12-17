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
            this.Hide();
            menu.Show();
            
        }
       
        private void CloseExe_MouseLeave(object sender, EventArgs e)
        {
            CloseExe.Size = new Size(22,22);
        }

        private void CloseExe_MouseMove(object sender, MouseEventArgs e)
        {
            CloseExe.Size = new Size(23, 23);
        }


       string querySelectOrders = "SELECT orders.id_order,masters.Surname,masters.Name,masters.Patronymic,Group_concat(service.name_service SEPARATOR ', ') as 'Наименование заказа'," +
                                  " sum(service.price)  as 'Сумма заказа', date(orders.Date)" +
                    " FROM service INNER JOIN order_service ON service.id_service=order_service.id_service " +
                    " INNER JOIN orders ON orders.id_order= order_service.id_order" +
                    " INNER JOIN masters ON masters.id_master = orders.id_master" +
                    " GROUP BY order_service.id_order";
        
        private void DoneWorks_Load(object sender, EventArgs e)
        {
            QueriesClass.SelectQuery(querySelectOrders, InfoWorks); // заменить на заказы
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

        private void DoneWorks_Click(object sender, EventArgs e)
        {
            string deleteOrders = "DELETE from orders";

            if (InfoWorks.Rows.Count > 1)
            {
                DialogResult result = MessageBox.Show(
                            "Вы действительно хотите очистить весь список выполненных заказов?",
                             "Attention",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                // Проверяем какая кнопка нажата ...             
                if (result == DialogResult.Yes)
                {
                    QueriesClass.QuerytoTable(deleteOrders);
                    InfoWorks.Rows.Clear();
                }
                else
                {
                    this.TopMost = true;
                }// Ставим нашу форму по верх всех окон  
                this.TopMost = true;
            }
            else 
            {
                MessageBox.Show("В таблице нет заказов", "Information");
                return;
            }
        }

        private void panel1_DoneWorks_MouseUp(object sender, MouseEventArgs e)
        {
            move = 5;
        }


        private void AddOrder_Click(object sender, EventArgs e)
        {
            AddOrder newOrder = new AddOrder();
            newOrder.Show();
          
        }
    }
}
