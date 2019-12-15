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
            QueriesClass.SelectQuery(querySelMasters, TableSelectMasters, 2);
            Reset();
        }


        private void InsOrder_Click(object sender, EventArgs e)
        {
                             
                  
        }

        private void Reset()
        {
           
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
