namespace Barbershop
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddServiceForm = new System.Windows.Forms.Button();
            this.CloseExe = new System.Windows.Forms.PictureBox();
            this.StatisticForm = new System.Windows.Forms.Button();
            this.AddMasterForm = new System.Windows.Forms.Button();
            this.MastersForm = new System.Windows.Forms.Button();
            this.OrdersForm = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_Menu_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_Menu_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_Menu_MouseUp);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // AddServiceForm
            // 
            this.AddServiceForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddServiceForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddServiceForm.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddServiceForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddServiceForm.Image = global::Barbershop.Properties.Resources.add;
            this.AddServiceForm.Location = new System.Drawing.Point(12, 375);
            this.AddServiceForm.Name = "AddServiceForm";
            this.AddServiceForm.Size = new System.Drawing.Size(414, 101);
            this.AddServiceForm.TabIndex = 4;
            this.AddServiceForm.Text = "Добавление услуги      ";
            this.AddServiceForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddServiceForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddServiceForm.UseVisualStyleBackColor = false;
            this.AddServiceForm.Click += new System.EventHandler(this.AddServiceForm_Click);
            // 
            // CloseExe
            // 
            this.CloseExe.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CloseExe.Image = global::Barbershop.Properties.Resources.multiply;
            this.CloseExe.Location = new System.Drawing.Point(401, 2);
            this.CloseExe.Name = "CloseExe";
            this.CloseExe.Size = new System.Drawing.Size(22, 22);
            this.CloseExe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseExe.TabIndex = 5;
            this.CloseExe.TabStop = false;
            this.CloseExe.Click += new System.EventHandler(this.CloseExe_Click);
            this.CloseExe.MouseLeave += new System.EventHandler(this.CloseExe_MouseLeave);
            this.CloseExe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseExe_MouseMove);
            // 
            // StatisticForm
            // 
            this.StatisticForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StatisticForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticForm.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatisticForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StatisticForm.Image = global::Barbershop.Properties.Resources.analytics70;
            this.StatisticForm.Location = new System.Drawing.Point(12, 482);
            this.StatisticForm.Name = "StatisticForm";
            this.StatisticForm.Size = new System.Drawing.Size(414, 101);
            this.StatisticForm.TabIndex = 5;
            this.StatisticForm.Text = "Статистика                  ";
            this.StatisticForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatisticForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StatisticForm.UseVisualStyleBackColor = false;
            // 
            // AddMasterForm
            // 
            this.AddMasterForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddMasterForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMasterForm.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMasterForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddMasterForm.Image = global::Barbershop.Properties.Resources.new_user;
            this.AddMasterForm.Location = new System.Drawing.Point(12, 268);
            this.AddMasterForm.Name = "AddMasterForm";
            this.AddMasterForm.Size = new System.Drawing.Size(414, 101);
            this.AddMasterForm.TabIndex = 3;
            this.AddMasterForm.Text = "Добавление мастера    ";
            this.AddMasterForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMasterForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddMasterForm.UseVisualStyleBackColor = false;
            this.AddMasterForm.Click += new System.EventHandler(this.AddMasterForm_Click);
            // 
            // MastersForm
            // 
            this.MastersForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MastersForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MastersForm.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MastersForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MastersForm.Image = global::Barbershop.Properties.Resources.list70;
            this.MastersForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MastersForm.Location = new System.Drawing.Point(12, 162);
            this.MastersForm.Name = "MastersForm";
            this.MastersForm.Size = new System.Drawing.Size(414, 101);
            this.MastersForm.TabIndex = 2;
            this.MastersForm.Text = "Список мастеров и услуг  ";
            this.MastersForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MastersForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MastersForm.UseVisualStyleBackColor = false;
            this.MastersForm.Click += new System.EventHandler(this.MastersBtn_Click);
            // 
            // OrdersForm
            // 
            this.OrdersForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OrdersForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersForm.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OrdersForm.Image = global::Barbershop.Properties.Resources.all;
            this.OrdersForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersForm.Location = new System.Drawing.Point(12, 56);
            this.OrdersForm.Name = "OrdersForm";
            this.OrdersForm.Size = new System.Drawing.Size(414, 101);
            this.OrdersForm.TabIndex = 1;
            this.OrdersForm.Text = "Выполненные работы";
            this.OrdersForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrdersForm.UseVisualStyleBackColor = false;
            this.OrdersForm.Click += new System.EventHandler(this.works_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(438, 595);
            this.Controls.Add(this.AddServiceForm);
            this.Controls.Add(this.CloseExe);
            this.Controls.Add(this.StatisticForm);
            this.Controls.Add(this.AddMasterForm);
            this.Controls.Add(this.MastersForm);
            this.Controls.Add(this.OrdersForm);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_Menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_Menu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_Menu_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button OrdersForm;
        private System.Windows.Forms.Button MastersForm;
        private System.Windows.Forms.Button AddMasterForm;
        private System.Windows.Forms.Button StatisticForm;
        private System.Windows.Forms.PictureBox CloseExe;
        private System.Windows.Forms.Button AddServiceForm;
    }
}