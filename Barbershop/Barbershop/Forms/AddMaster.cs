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
    public partial class AddMaster : Form
    {
        
        public AddMaster()
        {
            InitializeComponent();
            ConnectionClass.GetConnect();
            PhoneKod.KeyPress += (sender, e) => e.Handled = true;
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


        private void InsMaster_Click(object sender, EventArgs e)
        {
            string phone;
            string queryInsertMaster;
              
            if (surname.Text != "" )
            {
                if (nameTB.Text != "" )
                {
                    if (patronymic.Text != "")
                    {
                        if (adress.Text != "")
                        {
                            if (phoneNumber.Text != "" && PhoneKod.SelectedIndex!=-1)
                            {
                                if (!phoneNumber.Text.Contains("."))
                                {
                                     phone = PhoneKod.SelectedItem.ToString() + phoneNumber.Text;
                                     queryInsertMaster = "Insert into masters VALUES(0,'" + surname.Text + "','" + nameTB.Text + "','" + patronymic.Text + "','" +
                                         adress.Text + "','" + phone + "');";
                                    QueriesClass.QuerytoTable(queryInsertMaster);
                                    DialogResult result = MessageBox.Show(
                          "Мастер добавлен!",
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
                                    MessageBox.Show("Номер телефона не должен содержать '.'!", "Ошибка!");
                                    phoneNumber.Focus();
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Введите номер телефона!", "Ошибка!");
                                phoneNumber.Focus();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введите адрес!", "Ошибка!");
                            adress.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите отчество!", "Ошибка!");
                        patronymic.Focus();
                        return;
                    }
                   
                }
                else
                {
                    MessageBox.Show("Введите имя!", "Ошибка!");
                    nameTB.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Введите фамилию!", "Ошибка!");
                surname.Focus();
                return;
            }
           
        }

        private void Reset()
        {
            nameTB.Text = "";
            surname.Text = "";
            patronymic.Text = "";
            adress.Text = "";
            phoneNumber.Text = "";
            PhoneKod.SelectedIndex = -1;
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && !(e.KeyChar == ',' && e.KeyChar == '/'))
                e.Handled = true;
            return;
        }

        private void patronymic_name_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Space && e.KeyChar != '-')
                e.Handled = true;
            return;
        }
        int moveX, moveY, move;

        private void panel1_AddMaster_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_AddMaster_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panel1_AddMaster_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }
    }
}
