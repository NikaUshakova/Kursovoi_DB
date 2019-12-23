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
    public partial class AddService : Form
    {
        
        public AddService()
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
       

        private void AddMaster_Load(object sender, EventArgs e)
        {
            Reset();
        }


        private void InsService_Click(object sender, EventArgs e)
        {
            string queryInsertService;
                if (nameService.Text != "")
                {
                      if (price.Text!="" )
                      {
                            if (!price.Text.Contains("."))
                            {
                                 queryInsertService = "Insert into service VALUES(0,'" + nameService.Text + "'," + int.Parse(price.Text) + ");";
                                 QueriesClass.QuerytoTable(queryInsertService);
                        DialogResult result = MessageBox.Show(
                          "Услуга добавлена!",
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
                                MessageBox.Show("Цена должна быть целочисленным значением!", "Ошибка!");
                                price.Focus();
                                return;
                            }

                      }
                      else
                      {
                           MessageBox.Show("Введите цену за услугу!", "Ошибка!");
                           price.Focus();
                           return;
                      }
                }
                else
                {
                      MessageBox.Show("Введите название услуги!", "Ошибка!");
                      nameService.Focus();
                      return;
                }                   
                  
        }

        private void Reset()
        {
            price.Text = "";
            nameService.Text = "";
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && !(e.KeyChar == ',' && e.KeyChar == '/') )
                e.Handled = true;
            return;
        }

        private void nameService_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Space )
                e.Handled = true;
            return;
        }
        int moveX, moveY, move;

        private void panel1_AddService_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_AddService_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panel1_AddService_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }
    }
}
