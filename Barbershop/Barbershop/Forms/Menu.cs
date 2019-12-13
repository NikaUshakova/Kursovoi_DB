using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void CloseExe_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CloseExe_MouseLeave(object sender, EventArgs e)
        {
            CloseExe.Size = new Size(23,23);
        }

        private void CloseExe_MouseMove(object sender, MouseEventArgs e)
        {
            CloseExe.Size = new Size(25, 25);
        }

        
        private void works_Click(object sender, EventArgs e)
        {
            DoneWorks doneWorks = new DoneWorks();
            doneWorks.Show();
            this.Hide();
        }

        int moveX, moveY, move;

        private void menuStrip1_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void MastersBtn_Click(object sender, EventArgs e)
        {
            Masters formMasters = new Masters();
            formMasters.Show();
            this.Hide();
        }

        private void AddMasterForm_Click(object sender, EventArgs e)
        {
            var addMaster = new AddMaster();
            addMaster.Show();
            this.Hide();
        }

        private void AddServiceForm_Click(object sender, EventArgs e)
        {
            var addService = new AddService();
            addService.Show();
            this.Hide();
        }

        private void menuStrip1_Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void menuStrip1_Menu_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
    }
}
