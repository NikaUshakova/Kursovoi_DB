namespace Barbershop
{
    partial class DoneWorks
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseExe = new System.Windows.Forms.PictureBox();
            this.InfoWorks = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasterSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.countWorks = new System.Windows.Forms.ToolStripStatusLabel();
            this.summLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboFIO = new System.Windows.Forms.ComboBox();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.secondPrice = new System.Windows.Forms.TextBox();
            this.firstPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteOrders = new System.Windows.Forms.Button();
            this.AddOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoWorks)).BeginInit();
            this.delOrder.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseExe);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 26);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_DoneWorks_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_DoneWorks_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_DoneWorks_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(530, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выполненные заказы";
            // 
            // CloseExe
            // 
            this.CloseExe.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CloseExe.Image = global::Barbershop.Properties.Resources.multiply;
            this.CloseExe.Location = new System.Drawing.Point(1217, 0);
            this.CloseExe.Name = "CloseExe";
            this.CloseExe.Size = new System.Drawing.Size(22, 22);
            this.CloseExe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseExe.TabIndex = 5;
            this.CloseExe.TabStop = false;
            this.CloseExe.Click += new System.EventHandler(this.CloseExe_Click);
            this.CloseExe.MouseLeave += new System.EventHandler(this.CloseExe_MouseLeave);
            this.CloseExe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseExe_MouseMove);
            // 
            // InfoWorks
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoWorks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InfoWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoWorks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MasterSurname,
            this.MasterName,
            this.Patronymic,
            this.Order,
            this.Sum,
            this.Date});
            this.InfoWorks.ContextMenuStrip = this.delOrder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoWorks.DefaultCellStyle = dataGridViewCellStyle2;
            this.InfoWorks.Location = new System.Drawing.Point(4, 159);
            this.InfoWorks.Name = "InfoWorks";
            this.InfoWorks.RowHeadersWidth = 20;
            this.InfoWorks.RowTemplate.Height = 24;
            this.InfoWorks.Size = new System.Drawing.Size(1238, 350);
            this.InfoWorks.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 5;
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 30;
            // 
            // MasterSurname
            // 
            this.MasterSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MasterSurname.HeaderText = "Фамилия";
            this.MasterSurname.MaxInputLength = 45;
            this.MasterSurname.MinimumWidth = 6;
            this.MasterSurname.Name = "MasterSurname";
            this.MasterSurname.ReadOnly = true;
            this.MasterSurname.Width = 105;
            // 
            // MasterName
            // 
            this.MasterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MasterName.HeaderText = "Имя";
            this.MasterName.MaxInputLength = 45;
            this.MasterName.MinimumWidth = 6;
            this.MasterName.Name = "MasterName";
            this.MasterName.ReadOnly = true;
            this.MasterName.Width = 67;
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.MaxInputLength = 45;
            this.Patronymic.MinimumWidth = 6;
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            this.Patronymic.Width = 108;
            // 
            // Order
            // 
            this.Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Order.HeaderText = "Наименование заказа";
            this.Order.MaxInputLength = 4000;
            this.Order.MinimumWidth = 6;
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Сумма заказа(BYN)";
            this.Sum.MaxInputLength = 5;
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 115;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Date.HeaderText = "Дата проведения";
            this.Date.MaxInputLength = 10;
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 110;
            // 
            // delOrder
            // 
            this.delOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.delOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.delOrder.Name = "editContextMenu";
            this.delOrder.Size = new System.Drawing.Size(263, 28);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(262, 24);
            this.toolStripMenuItem2.Text = "Удалить выбранный заказ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countWorks,
            this.summLine});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1252, 26);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // countWorks
            // 
            this.countWorks.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countWorks.Name = "countWorks";
            this.countWorks.Size = new System.Drawing.Size(265, 20);
            this.countWorks.Text = "Количество выполненных работ:";
            // 
            // summLine
            // 
            this.summLine.Name = "summLine";
            this.summLine.Size = new System.Drawing.Size(62, 20);
            this.summLine.Text = "Сумма: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Barbershop.Properties.Resources.update_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(1207, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.resetFilters_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "BYN";
            // 
            // comboFIO
            // 
            this.comboFIO.FormattingEnabled = true;
            this.comboFIO.Location = new System.Drawing.Point(6, 20);
            this.comboFIO.Name = "comboFIO";
            this.comboFIO.Size = new System.Drawing.Size(449, 26);
            this.comboFIO.TabIndex = 4;
            this.comboFIO.SelectedIndexChanged += new System.EventHandler(this.comboFIO_SelectedIndexChanged);
            // 
            // comboService
            // 
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(6, 20);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(449, 26);
            this.comboService.TabIndex = 3;
            this.comboService.SelectedIndexChanged += new System.EventHandler(this.comboService_SelectedIndexChanged);
            // 
            // secondPrice
            // 
            this.secondPrice.Location = new System.Drawing.Point(145, 20);
            this.secondPrice.MaxLength = 5;
            this.secondPrice.Name = "secondPrice";
            this.secondPrice.Size = new System.Drawing.Size(72, 24);
            this.secondPrice.TabIndex = 6;
            this.secondPrice.TextChanged += new System.EventHandler(this.firstSecondPrice_TextChanged);
            this.secondPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstPrice_KeyPress);
            // 
            // firstPrice
            // 
            this.firstPrice.Location = new System.Drawing.Point(34, 20);
            this.firstPrice.MaxLength = 4;
            this.firstPrice.Name = "firstPrice";
            this.firstPrice.Size = new System.Drawing.Size(72, 24);
            this.firstPrice.TabIndex = 5;
            this.firstPrice.TextChanged += new System.EventHandler(this.firstSecondPrice_TextChanged);
            this.firstPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "до";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "до";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(285, 20);
            this.dateTimePicker2.MaxDate = new System.DateTime(2199, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2020, 1, 7, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2020, 1, 7, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "от";
            // 
            // DeleteOrders
            // 
            this.DeleteOrders.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeleteOrders.FlatAppearance.BorderSize = 2;
            this.DeleteOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrders.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteOrders.Image = global::Barbershop.Properties.Resources.database;
            this.DeleteOrders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteOrders.Location = new System.Drawing.Point(773, 516);
            this.DeleteOrders.Name = "DeleteOrders";
            this.DeleteOrders.Size = new System.Drawing.Size(227, 51);
            this.DeleteOrders.TabIndex = 20;
            this.DeleteOrders.Text = "Удалить заказы";
            this.DeleteOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteOrders.UseVisualStyleBackColor = false;
            this.DeleteOrders.Click += new System.EventHandler(this.DeleteOrders_Click);
            // 
            // AddOrder
            // 
            this.AddOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddOrder.FlatAppearance.BorderSize = 2;
            this.AddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddOrder.Image = global::Barbershop.Properties.Resources.add_40_;
            this.AddOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddOrder.Location = new System.Drawing.Point(1006, 516);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(236, 51);
            this.AddOrder.TabIndex = 19;
            this.AddOrder.Text = "Добавить заказ";
            this.AddOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddOrder.UseVisualStyleBackColor = false;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboService);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(589, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 51);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Название услуги";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(4, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 51);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дата проведения";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboFIO);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(589, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 51);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ФИО мастера";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.secondPrice);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.firstPrice);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(4, 88);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 51);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Сумма заказа";
            // 
            // DoneWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1252, 602);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.DeleteOrders);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.InfoWorks);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoneWorks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.DoneWorks_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_DoneWorks_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_DoneWorks_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_DoneWorks_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoWorks)).EndInit();
            this.delOrder.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseExe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView InfoWorks;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel countWorks;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button DeleteOrders;
        private System.Windows.Forms.ToolStripStatusLabel summLine;
        private System.Windows.Forms.ComboBox comboFIO;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.TextBox secondPrice;
        private System.Windows.Forms.TextBox firstPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip delOrder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}