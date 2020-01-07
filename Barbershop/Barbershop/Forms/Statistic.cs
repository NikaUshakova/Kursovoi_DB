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
    public partial class Statistic : Form
    {
        List<string> masters = new List<string>();
        // List<string[]> countWorks = new List<string[]>();
        
        public Statistic()
        {            
            InitializeComponent();
            ConnectionClass.GetConnect();
            period.KeyPress += (sender, e) => e.Handled = true;
        }       
       
        private void CloseExe_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //var menu = new Menu();
            //this.Hide();
            //menu.Show();
        }

        private void CloseExe_MouseLeave(object sender, EventArgs e)
        {
            CloseExe.Size = new Size(22,22);
        }

        private void CloseExe_MouseMove(object sender, MouseEventArgs e)
        {
            CloseExe.Size = new Size(23, 23);
        }

            

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && !(e.KeyChar == ',' && e.KeyChar == '/'))
                e.Handled = true;
            return;
        }

        int moveX, moveY, move;

        private void panel1_Statistic_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void LoadChartCount()
        {
            string nameMS = "", surnameMS = "", patronymicMS = "";
            string queryMasters = "SELECT Concat_ws(' ',surname,name,patronymic) FROM masters";
            string queryCountWorks;
            masters = QueriesClass.SelectCombo(queryMasters);  //list of FIO masters
            int count = 0;
            for (int i = 0; i < masters.Count; i++)
            {
                //string text = masters[i].ToString();
                //MessageBox.Show(text);
                string[] FIO = masters[i].ToString().Split(' ');
                surnameMS = FIO[0];
                //MessageBox.Show(surnameMS);
                nameMS = FIO[1];
                //MessageBox.Show(nameMS);
                patronymicMS = FIO[2];
                // MessageBox.Show(patronymicMS);
                queryCountWorks = "SELECT count(*) FROM orders INNER JOIN masters ON orders.id_master=masters.id_master Where masters.surname = '" + surnameMS + "' and masters.Name = '" + nameMS + "' and masters.Patronymic = '" + patronymicMS + "'";
                count = QueriesClass.SelectOne(queryCountWorks);
                chartCount.Series["Количество работ"].Points.AddXY(masters[i], count);
                chartCount.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                chartCount.ChartAreas[0].AxisX.LabelStyle.Angle = -30;
            }
        }
            private void LoadChartSum()
            {
                string nameMS = "", surnameMS = "", patronymicMS = "";
                string queryMasters = "SELECT Concat_ws(' ',surname,name,patronymic) FROM masters";
                string querySum;
                masters = QueriesClass.SelectCombo(queryMasters);  //list of FIO masters
                int [] Sum = new int[masters.Count];
                for (int i = 0; i < masters.Count; i++)
                {
                    //string text = masters[i].ToString();
                    //MessageBox.Show(text);
                    string[] FIO = masters[i].ToString().Split(' ');
                    surnameMS = FIO[0];
                    //MessageBox.Show(surnameMS);
                    nameMS = FIO[1];
                    //MessageBox.Show(nameMS);
                    patronymicMS = FIO[2];
                    // MessageBox.Show(patronymicMS);
                    querySum = "SELECT sum(service.price) FROM service INNER JOIN order_service ON order_service.id_service=service.id_service" +
                        " INNER JOIN orders ON order_service.id_order = orders.id_order"+
                        " INNER JOIN masters ON orders.id_master = masters.id_master Where masters.surname = '" + surnameMS + "' and masters.Name = '" + nameMS + "' and masters.Patronymic = '" + patronymicMS + "'IS NOT NULL";
                    Sum[i] = QueriesClass.SelectOne(querySum);
                    chartSum.Series["Выручка"].Points.AddXY(masters[i], Sum[i]);  //???
                    chartSum.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    chartSum.ChartAreas[0].AxisX.LabelStyle.Angle = -30;
                }
            
        }
        private void Statistic_Load(object sender, EventArgs e)
        {
            LoadChartCount();
            LoadChartSum();
        }

        private void period_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryDate = "";
            if (period.SelectedIndex == 0)
            {
                queryDate = "";
            }
        }

        private void panel1_Statistic_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panel1_Statistic_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }
    }
}
