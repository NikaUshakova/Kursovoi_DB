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
            comboFIO.KeyPress += (sender, e) => e.Handled = true;
            comboService.KeyPress += (sender, e) => e.Handled = true;
        }              
  
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

        string querySelectOrders = "SELECT orders.id_order,masters.Surname,masters.Name,masters.Patronymic,Group_concat(service.name_service SEPARATOR ', ')," +
                                " sum(service.price) ,concat_ws('-',day(orders.Date),month(orders.Date),year(orders.Date))" +
                  " FROM service INNER JOIN order_service ON service.id_service=order_service.id_service " +
                  " INNER JOIN orders ON orders.id_order= order_service.id_order" +
                  " INNER JOIN masters ON masters.id_master = orders.id_master" +
                  " GROUP BY order_service.id_order";

        private int Total()
        {
            int total = 0;
            for (int i = 0; i < InfoWorks.Rows.Count; i++)
            {
                total += Convert.ToInt32(InfoWorks.Rows[i].Cells[5].Value);
            }
            return total;
        }
        private void DoneWorks_Load(object sender, EventArgs e)
        {           
                        
            QueriesClass.SelectQuery(querySelectOrders, InfoWorks); 
            countWorks.Text= "Количество выполненных работ: " + (InfoWorks.RowCount-1);
               
            summLine.Text = "Сумма: " + Total()+"BYN";
            ////////////////////////////////////////////////////////////////////////////                          WELL, MY BRAIN IS BROKEN
            string querycount = "Select count(*) FROM masters";
            string querycountser = "Select count(*) FROM service";
            string querySelFIO = "SELECT Concat_ws(' ',surname,name,patronymic )  FROM masters";
            string querySelService = "SELECT name_service  FROM service";
            int count = QueriesClass.SelectOne(querycount);
            int countser = QueriesClass.SelectOne(querycountser);
            List<string> pamagite = new List<string>();
            List<string> pamagi = new List<string>();
            ///
            pamagite.Clear();
            pamagite = QueriesClass.SelectCombo(querySelFIO);
            for (int i = 0; i < count; i++)
            {                
                comboFIO.Items.Add(pamagite[i].ToString());                             
            }
            ///
            pamagi.Clear();
            pamagi = QueriesClass.SelectCombo(querySelService);
            for (int i = 0; i < countser ; i++)
            {
                comboService.Items.Add(pamagi[i].ToString());
            }
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

        private void DeleteOrders_Click(object sender, EventArgs e)
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

        private void comboService_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  Filter();
            if (comboService.SelectedIndex > -1)
            {
                comboFIO.SelectedIndex = -1;
                string querySelService = "SELECT orders.id_order,masters.Surname,masters.Name,masters.Patronymic,Group_concat(service.name_service SEPARATOR ', '), " +
                                  "sum(service.price) ,concat_ws('-',day(orders.Date),month(orders.Date),year(orders.Date))" +
                    " FROM service INNER JOIN order_service ON service.id_service=order_service.id_service " +
                    " INNER JOIN orders ON orders.id_order= order_service.id_order " +
                    " INNER JOIN masters ON masters.id_master = orders.id_master" +
                    " GROUP BY order_service.id_order" +                 //sosat
                    " having INSTR(Group_concat(service.name_service SEPARATOR ', '), '" + comboService.Text + "') > 0 ";
                QueriesClass.SelectQuery(querySelService, InfoWorks);
            }
            else
            {
                QueriesClass.SelectQuery(querySelectOrders, InfoWorks);
            }
            countWorks.Text = "Количество выполненных работ: " + (InfoWorks.RowCount - 1);
            summLine.Text = "Сумма: " + Total() + "BYN";
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //private void Filter()
        //{
        //    try
        //    {
        //        string FIO = comboFIO.SelectedItem.ToString();
        //        string[] arrFIO = FIO.Split(' ');
        //        string surname = arrFIO[0];
        //        string name = arrFIO[1];
        //        string patronymic = arrFIO[2];
        //        string date1 = dateTimePicker1.Value.Year.ToString() + dateTimePicker1.Value.Month.ToString() + dateTimePicker1.Value.Day.ToString();
        //        string date2 = dateTimePicker2.Value.Year.ToString() + dateTimePicker2.Value.Month.ToString() + dateTimePicker2.Value.Day.ToString();
        //        if (comboService.SelectedIndex > -1 && comboFIO.SelectedIndex > -1 && firstPrice.Text != "" && secondPrice.Text != "")
        //        {
        //            // comboFIO.SelectedIndex = -1;
        //            string querySelService = "SELECT orders.id_order,masters.Surname,masters.Name,masters.Patronymic,Group_concat(service.name_service SEPARATOR ', '), " +
        //                              "sum(service.price) ,concat_ws('-',day(orders.Date),month(orders.Date),year(orders.Date))" +
        //                " FROM service INNER JOIN order_service ON service.id_service=order_service.id_service " +
        //                " INNER JOIN orders ON orders.id_order= order_service.id_order " +
        //                " INNER JOIN masters ON masters.id_master = orders.id_master" +
        //                " WHERE  (orders.Date BETWEEN '" + date1 + "' AND '" + date2 + "') AND masters.Surname = '" + surname + "'AND masters.Name = '" + name + "'AND masters.Patronymic = '" + patronymic + "'" +
        //                " GROUP BY order_service.id_order" +                 //sosat
        //                " having INSTR(Group_concat(service.name_service SEPARATOR ', '), '" + comboService.Text + "') > 0 AND " +
        //                " (sum(service.Price) BETWEEN " + int.Parse(firstPrice.Text) + " AND " + int.Parse(secondPrice.Text)+")";

        //            QueriesClass.SelectQuery(querySelService, InfoWorks);
        //        }
        //        else
        //        {
        //            QueriesClass.SelectQuery(querySelectOrders, InfoWorks);
        //        }
        //    }
        //    catch { }
        //}

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void comboFIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filter();
            if (comboFIO.SelectedIndex > -1)
            {
                comboService.SelectedIndex = -1;
                string FIO = comboFIO.SelectedItem.ToString();
                string[] arrFIO = FIO.Split(' ');
                string surname = arrFIO[0];
                string name = arrFIO[1];
                string patronymic = arrFIO[2];
                // MessageBox.Show(FIO);
                string querySelMaster = "SELECT orders.id_order,masters.Surname,masters.Name,masters.Patronymic,Group_concat(service.name_service SEPARATOR ', ')," +
                                     " sum(service.price) ,concat_ws('-',day(orders.Date),month(orders.Date),year(orders.Date))" +
                       " FROM service INNER JOIN order_service ON service.id_service=order_service.id_service " +
                       " INNER JOIN orders ON orders.id_order= order_service.id_order" +
                       " INNER JOIN masters ON masters.id_master = orders.id_master" +
                       " WHERE masters.Surname = '" + surname + "'AND masters.Name = '" + name + "'AND masters.Patronymic = '" + patronymic + "' " +                 
                       " GROUP BY order_service.id_order";
                QueriesClass.SelectQuery(querySelMaster, InfoWorks);
            }
            else
            {
                QueriesClass.SelectQuery(querySelectOrders, InfoWorks);
            }
            countWorks.Text = "Количество выполненных работ: " + (InfoWorks.RowCount - 1);
            summLine.Text = "Сумма: " + Total() + "BYN";
        }

        private void firstPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' && e.KeyChar != (char)Keys.Delete && !(e.KeyChar == ',' && e.KeyChar == '/'))
                e.Handled = true;
            return;
        }

        private void resetFilters_Click(object sender, EventArgs e)
        {
            comboFIO.SelectedIndex = -1;
            comboService.SelectedIndex = -1;
            dateTimePicker2.Value = dateTimePicker1.Value;
            QueriesClass.SelectQuery(querySelectOrders, InfoWorks);
            firstPrice.Text = "";
            secondPrice.Text = "";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int id_order = Convert.ToInt32(InfoWorks.CurrentRow.Cells[0].Value);        //ID_order

            string queryDelOrder = "DELETE from orders WHERE orders.id_order =" + id_order;

            DialogResult result = MessageBox.Show(
                           "Вы действительно хотите удалить выбранный заказ?",
                            "Подтверждение",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1,
                           MessageBoxOptions.DefaultDesktopOnly);
            // Проверяем какая кнопка нажата ...             
            if (result == DialogResult.Yes)
            {
                QueriesClass.QuerytoTable(queryDelOrder);
                QueriesClass.SelectQuery(querySelectOrders, InfoWorks);
            }
            else
            {
                this.TopMost = true;
            }// Ставим нашу форму по верх всех окон  
            this.TopMost = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboFIO.SelectedIndex = -1;
            comboService.SelectedIndex = -1;
            firstPrice.Text = "";
            secondPrice.Text = "";
            string date1 = dateTimePicker1.Value.Year.ToString()+"-" + dateTimePicker1.Value.Month.ToString() +"-" + dateTimePicker1.Value.Day.ToString();
            string date2 = dateTimePicker2.Value.Year.ToString() + "-" + dateTimePicker2.Value.Month.ToString() + "-" + dateTimePicker2.Value.Day.ToString();
            //MessageBox.Show(date1 + "   " + date2);
            string querySeldate = "SELECT orders.id_order,masters.Surname,masters.Name,masters.Patronymic,Group_concat(service.name_service SEPARATOR ', ')," +
                                  " sum(service.price) ,concat_ws('-',day(orders.Date),month(orders.Date),year(orders.Date))" +
                    " FROM service INNER JOIN order_service ON service.id_service=order_service.id_service " +
                    " INNER JOIN orders ON orders.id_order= order_service.id_order" +
                    " INNER JOIN masters ON masters.id_master = orders.id_master" +
                    " WHERE  orders.Date BETWEEN '" + date1 + "' AND '" + date2 + "'" +               
                    " GROUP BY order_service.id_order";
            QueriesClass.SelectQuery(querySeldate, InfoWorks);
            // Filter();
            countWorks.Text = "Количество выполненных работ: " + (InfoWorks.RowCount - 1);
            summLine.Text = "Сумма: " + Total() + "BYN";
        }
        
        private void firstSecondPrice_TextChanged(object sender, EventArgs e)
        {
            //Filter();
            try
            {
                if (firstPrice.Text != "" && secondPrice.Text != "")
                {
                    string AllPrice = "SELECT orders.id_order,masters.Surname,masters.Name,masters.Patronymic,Group_concat(service.name_service SEPARATOR ', ')," +
                                            " sum(service.price) ,concat_ws('-',day(orders.Date),month(orders.Date),year(orders.Date))" +
                              " FROM service INNER JOIN order_service ON service.id_service=order_service.id_service " +
                              " INNER JOIN orders ON orders.id_order= order_service.id_order" +
                              " INNER JOIN masters ON masters.id_master = orders.id_master" +
                              " GROUP BY order_service.id_order" +
                               " HAVING sum(service.Price) BETWEEN " + int.Parse(firstPrice.Text) + " AND " + int.Parse(secondPrice.Text);
                    QueriesClass.SelectQuery(AllPrice, InfoWorks);
                }
                else
                {
                    QueriesClass.SelectQuery(querySelectOrders, InfoWorks);
                }

                if (firstPrice.Text != "" && secondPrice.Text == "")
                {
                    string fromPrice = "SELECT orders.id_order,masters.Surname,masters.Name,masters.Patronymic,Group_concat(service.name_service SEPARATOR ', ')," +
                                            " sum(service.price) ,concat_ws('-',day(orders.Date),month(orders.Date),year(orders.Date))" +
                              " FROM service INNER JOIN order_service ON service.id_service=order_service.id_service " +
                              " INNER JOIN orders ON orders.id_order= order_service.id_order" +
                              " INNER JOIN masters ON masters.id_master = orders.id_master" +
                              " GROUP BY order_service.id_order" +
                               " HAVING sum(service.Price)> " + int.Parse(firstPrice.Text);
                    QueriesClass.SelectQuery(fromPrice, InfoWorks);
                }
                else
                  if (firstPrice.Text == "" && secondPrice.Text != "")
                  {
                    string toPrice = "SELECT orders.id_order,masters.Surname,masters.Name,masters.Patronymic,Group_concat(service.name_service SEPARATOR ', ')," +
                                            " sum(service.price) ,concat_ws('-',day(orders.Date),month(orders.Date),year(orders.Date))" +
                              " FROM service INNER JOIN order_service ON service.id_service=order_service.id_service " +
                              " INNER JOIN orders ON orders.id_order= order_service.id_order" +
                              " INNER JOIN masters ON masters.id_master = orders.id_master" +
                              " GROUP BY order_service.id_order" +
                               " HAVING sum(service.Price)< " + int.Parse(secondPrice.Text);
                    QueriesClass.SelectQuery(toPrice, InfoWorks);
                  }

            }
            catch
            {
                DialogResult result = MessageBox.Show(
                             "Цена должна быть целочисленного формата",
                              "Attention",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information,
                             MessageBoxDefaultButton.Button1,
                             MessageBoxOptions.DefaultDesktopOnly);
                if (firstPrice.Text.Contains(".")) firstPrice.Text = "";
                else secondPrice.Text = "";
                this.TopMost = true;

            }
            countWorks.Text = "Количество выполненных работ: " + (InfoWorks.RowCount - 1);
            summLine.Text = "Сумма: " + Total() + "BYN";
        }

        private void panel1_DoneWorks_MouseUp(object sender, MouseEventArgs e)
        {
            move = 5;
        }


        private void AddOrder_Click(object sender, EventArgs e)
        {
            AddOrder newOrder = new AddOrder();
            newOrder.Show();
            this.Hide();          
        }
    }
}
