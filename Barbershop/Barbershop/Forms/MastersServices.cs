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
    public partial class MastersServices : Form
    {
       
        
        public MastersServices()
        {
            InitializeComponent();
            ConnectionClass.GetConnect();
            MastersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
       
        string querySelectMasters = "SELECT * From masters";
        string querySelectService = "SELECT * From service";

        private void Masters_Load(object sender, EventArgs e)
        {           
            QueriesClass.SelectQuery(querySelectMasters, MastersTable);
            QueriesClass.SelectQuery(querySelectService, tableService);
            count.Text = "Количество мастеров: " + (MastersTable.RowCount - 1);

        }
        int moveX, moveY, move;
        private void panel1_Masters_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            string querySearhM = "SELECT * FROM masters WHERE masters.Surname like '%"+SearchField.Text+ "%' or masters.Name like '%" + SearchField.Text + "%' or masters.Patronymic like '%" + SearchField.Text + "%' or masters.Phone like '%" + SearchField.Text + "%'";
            QueriesClass.SelectQuery(querySearhM, MastersTable);
        }
        private void searchService_TextChanged(object sender, EventArgs e)
        {
            string querySearhS = "SELECT * FROM service WHERE service.name_service like '%" + searchService.Text + "%'";
            QueriesClass.SelectQuery(querySearhS, tableService);
        }

        private void редактироватьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editForm = new EditMaster(Convert.ToInt32(MastersTable.CurrentRow.Cells[0].Value));
           // MessageBox.Show(Convert.ToInt32(MastersTable.CurrentRow.Cells[0].Value).ToString());
            this.Hide();
            editForm.Show();     
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            int id_master = Convert.ToInt32(MastersTable.CurrentRow.Cells[0].Value);        //ID_master
            
            string queryDeleteMaster = "DELETE from masters WHERE masters.id_master =" + id_master;

            DialogResult result = MessageBox.Show(
                           "Вы действительно хотите удалить этого мастера?",
                            "Подтверждение",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1,
                           MessageBoxOptions.DefaultDesktopOnly);
            // Проверяем какая кнопка нажата ...             
            if (result == DialogResult.Yes)
            {
                QueriesClass.QuerytoTable(queryDeleteMaster);
                QueriesClass.SelectQuery(querySelectMasters, MastersTable);
            }
            else
            {
                this.TopMost = true;
            }// Ставим нашу форму по верх всех окон  
            this.TopMost = true;

        }

        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var editServ = new EditService(Convert.ToInt32(tableService.CurrentRow.Cells[0].Value));
            editServ.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int id_service = Convert.ToInt32(tableService.CurrentRow.Cells[0].Value);        //ID_service

            string queryDeleteMaster = "DELETE from service WHERE service.id_service =" + id_service;

            DialogResult result = MessageBox.Show(
                           "Вы действительно хотите удалить эту услугу?",
                            "Подтверждение",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1,
                           MessageBoxOptions.DefaultDesktopOnly);
            // Проверяем какая кнопка нажата ...             
            if (result == DialogResult.Yes)
            {
                QueriesClass.QuerytoTable(queryDeleteMaster);
                QueriesClass.SelectQuery(querySelectMasters, MastersTable);
            }
            else
            {
                this.TopMost = true;
            }// Ставим нашу форму по верх всех окон  
            this.TopMost = true;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                count.Text = "Количество услуг: " + (tableService.RowCount - 1);
            }
            else 
            {
                count.Text = "Количество мастеров: " + (MastersTable.RowCount - 1);
            }
        }

        private void panel1_Masters_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panel1_Masters_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
    }
}
