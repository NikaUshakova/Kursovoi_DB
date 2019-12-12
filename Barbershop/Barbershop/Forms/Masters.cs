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
    public partial class Masters : Form
    {
        
        public Masters()
        {
            InitializeComponent();
            ConnectionClass.GetConnect();            
        }       
       
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
        string querySelectMasters = "SELECT * From masters";
        
        private void Masters_Load(object sender, EventArgs e)
        {
            QueriesClass.SelectOrders(querySelectMasters, MastersTable,2);
        }

        
        

        
    }
}
