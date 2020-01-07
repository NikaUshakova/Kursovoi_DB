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
    public partial class AddOrder : Form
    {
        
        public AddOrder()
        {
            InitializeComponent();
            ConnectionClass.GetConnect();
            TableSelectMasters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TableSelectService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }       
       
        private void CloseExe_Click(object sender, EventArgs e)
        {            
            DoneWorks works = new DoneWorks();
            works.Show();
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
       

        private void AddOrder_Load(object sender, EventArgs e)
        {
                          string querySelMasters = "SELECT id_master, Concat_ws(' ',surname,name,patronymic )  FROM masters";
            QueriesClass.SelectQuery(querySelMasters, TableSelectMasters);
            string querySelService = "SELECT id_service, name_service, service.price  FROM service";
            QueriesClass.SelectQuery(querySelService, TableSelectService);
            Reset();
        }        

        private void Reset()
        {
            listBox.Items.Clear();
            TableSelectMasters.Rows[0].Selected = true;
            TableSelectService.Rows[0].Selected = true;
            monthCalendar1.ShowToday=true;
            monthCalendar1.ShowTodayCircle = true;
           
            OrderDate.Text = "";
            OrderMaster.Text = "";
            OrderSum.Text = "";
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

     
        int moveX, moveY, move;

        private void panel1_AddOrder_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void yes_Click(object sender, EventArgs e)
        {
            string service = "";
            if (TableSelectService.CurrentRow.Index == TableSelectService.Rows.Count - 1)
            {
                //MessageBox.Show(TableSelectService.CurrentRow.Index.ToString());
               
                DialogResult result = MessageBox.Show(
                             "Была выбрана пустая строка! Выберите услугу для заказа!",
                              "Attention",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning,
                             MessageBoxDefaultButton.Button1,
                             MessageBoxOptions.DefaultDesktopOnly);
                this.TopMost = true;
                return;
            }
            else
            {
                
                foreach (DataGridViewRow dr in TableSelectService.SelectedRows)
                {
                    service = dr.Cells[1].Value.ToString();        //name_service
                    listBox.Items.Add(service);
                }
            }
                // MessageBox.Show(TableSelectService.Rows.Count.ToString());
            
        }
         
        //private int Special()
        //{
        //    int specialPay = 0;
        //    string service = "";
        //    foreach (DataGridViewRow dr in TableSelectService.SelectedRows)
        //    {
        //        service = dr.Cells[1].Value.ToString();        //name_service                
        //    }
        //    if (service == "Сложное окрашивание" || service == "Окрашивание волос")
        //    {
        //        Choose.Enabled = true;
        //        if (shortBtn.Checked & ownBtn.Checked)                     //начальная 80/35р, в зависимости от длины добавляется 15р
        //        {
        //            specialPay = 0;
        //            Choose.Enabled = false;
        //        }
        //        else if (shortBtn.Checked & salonBtn.Checked)                    //при использовании салонной краски добавляется 30р
        //        {
        //            specialPay = 30;
        //            Choose.Enabled = false;
        //        }
        //        else if (avgBtn.Checked & ownBtn.Checked)
        //        {
        //            specialPay = 15;
        //            Choose.Enabled = false;
        //        }
        //        if (avgBtn.Checked & salonBtn.Checked)
        //        {
        //            specialPay = 15 + 30;
        //            Choose.Enabled = false;
        //        }
        //        else if (longBtn.Checked & ownBtn.Checked)
        //        {
        //            specialPay = 30;
        //            Choose.Enabled = false;
        //        }
        //        else if (longBtn.Checked & salonBtn.Checked)
        //        {
        //            specialPay = 30 + 30;
        //            Choose.Enabled = false;
        //        }
        //        else
        //        {
        //            specialPay = 0;
        //            MessageBox.Show("Необходимо выбрать подробную информацию об окрашивании. Выберите длину волос и краску!");
        //        }
        //        MessageBox.Show("че вышло= " + specialPay + " ");
        //    }
        //    return specialPay;
        //}
       
        private void TableSelectService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Special();
        }
        private void Summ_Click(object sender, EventArgs e)
        {
            string service_name;
            //MessageBox.Show(listBox.Items.Count.ToString());
            string query;
           
            int[] price= new int[listBox.Items.Count] ;
            int sum=0;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                service_name = listBox.Items[i].ToString();
                query = "SELECT price FROM service WHERE service.name_service = '" + service_name + "';";                
                price[i] = QueriesClass.SelectOne(query);      //+Special()
                //MessageBox.Show(price[i].ToString());
                
                sum += price[i];
                
            }
            OrderSum.Text =  sum + "BYN";
        }
        private void InsOrder_Click(object sender, EventArgs e) 
        {           
                DateTime day = monthCalendar1.SelectionStart;
           
                int IdMaster = 0;
                int IdOrder;
                string queryIDorder;
                foreach (DataGridViewRow dr in TableSelectMasters.SelectedRows)
                {
                    IdMaster = Convert.ToInt32(dr.Cells[0].Value);        //ID_master
                }
               // MessageBox.Show("id мастера " + IdMaster.ToString());
           
                string InsertOrder = "INSERT INTO orders VALUES (0,concat_ws('-', "+ day.Year + ", " + day.Month + ","+ day.Day + "),"+IdMaster+")";
                QueriesClass.QuerytoTable(InsertOrder);
           
                queryIDorder = "SELECT last_insert_id(orders.id_order) FROM orders ORDER BY orders.id_order desc LIMIT 1"; // Get ID of last order
                //MessageBox.Show("Сейчас кину ошибку");
                IdOrder = QueriesClass.SelectOne(queryIDorder);       //ID_order           
           
                string InsertOrder_Service;
                string queryIDservice, service_name;  //field for queries
                int IdService;
            if (listBox.Items.Count > 0 && TableSelectService.CurrentRow.Index != -1 && TableSelectMasters.CurrentRow.Index != -1)
            {
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    service_name = listBox.Items[i].ToString();
                    queryIDservice = "SELECT service.id_service FROM service WHERE service.name_service = '" + service_name + "';";      //Get service ID

                    IdService = QueriesClass.SelectOne(queryIDservice);       //ID_service

                    // MessageBox.Show("id услуги "+IdService.ToString());
                    // MessageBox.Show("id заказа " + IdOrder.ToString());

                    InsertOrder_Service = "INSERT INTO order_service  VALUES (0," + IdOrder + "," + IdService + ")";  //Add fields in Order_service table
                    QueriesClass.QuerytoTable(InsertOrder_Service);
                }
                DialogResult result = MessageBox.Show(
                           "Заказ добавлен!",
                            "Well",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1,
                           MessageBoxOptions.DefaultDesktopOnly);
                this.TopMost = true;
                Reset();
            }
            else 
            {
                DialogResult result = MessageBox.Show(
                             "Для оформления заказа выберите услуги, мастера и дату проведения!",
                              "Attention",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning,
                             MessageBoxDefaultButton.Button1,
                             MessageBoxOptions.DefaultDesktopOnly);
                this.TopMost = true;
                return;
            }
            
        }

        private void No_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void TableSelectMasters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string master = "";
            if (TableSelectMasters.CurrentRow.Index == TableSelectMasters.Rows.Count - 1)
            {
              //  MessageBox.Show(TableSelectMasters.CurrentRow.Index.ToString());
                
                DialogResult result = MessageBox.Show(
                             "Была выбрана пустая строка! Выберите мастера, который выполнит заказ!",
                              "Attention",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning,
                             MessageBoxDefaultButton.Button1,
                             MessageBoxOptions.DefaultDesktopOnly);
                this.TopMost = true;
                return;
            }
            else
            {
                foreach (DataGridViewRow dr in TableSelectMasters.SelectedRows)
                {
                    master = dr.Cells[1].Value.ToString();        //master
                    OrderMaster.Text =  master;
                }                
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime day = monthCalendar1.SelectionStart;
            OrderDate.Text = day.ToShortDateString();   //ShortDate
        }

       

        private void panel1_AddOrder_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panel1_AddOrder_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }
    }
}
