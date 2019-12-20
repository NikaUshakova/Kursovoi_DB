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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.countWorks = new System.Windows.Forms.ToolStripStatusLabel();
            this.summLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeleteOrders = new System.Windows.Forms.Button();
            this.AddOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.firstPrice = new System.Windows.Forms.TextBox();
            this.secondPrice = new System.Windows.Forms.TextBox();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.comboFIO = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoWorks)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseExe);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 26);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_DoneWorks_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_DoneWorks_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_DoneWorks_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(553, 1);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoWorks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.InfoWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoWorks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MasterSurname,
            this.MasterName,
            this.Patronymic,
            this.Order,
            this.Sum,
            this.Date});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoWorks.DefaultCellStyle = dataGridViewCellStyle12;
            this.InfoWorks.Location = new System.Drawing.Point(4, 199);
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
            this.Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Order.HeaderText = "Наименование заказа";
            this.Order.MaxInputLength = 4000;
            this.Order.MinimumWidth = 6;
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Width = 188;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Сумма заказа(б.р.)";
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countWorks,
            this.summLine});
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
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
            // DeleteOrders
            // 
            this.DeleteOrders.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeleteOrders.FlatAppearance.BorderSize = 2;
            this.DeleteOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrders.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteOrders.Image = global::Barbershop.Properties.Resources.delete_40_;
            this.DeleteOrders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteOrders.Location = new System.Drawing.Point(-1, 555);
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
            this.AddOrder.Location = new System.Drawing.Point(1005, 142);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(236, 51);
            this.AddOrder.TabIndex = 19;
            this.AddOrder.Text = "Добавить заказ";
            this.AddOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddOrder.UseVisualStyleBackColor = false;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboFIO);
            this.groupBox1.Controls.Add(this.comboService);
            this.groupBox1.Controls.Add(this.secondPrice);
            this.groupBox1.Controls.Add(this.firstPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 161);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите фильтр:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата проведения: от";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(439, 26);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Название услуги:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "ФИО мастера:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Сумма заказа: от";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "до";
            // 
            // firstPrice
            // 
            this.firstPrice.Location = new System.Drawing.Point(190, 124);
            this.firstPrice.MaxLength = 4;
            this.firstPrice.Name = "firstPrice";
            this.firstPrice.Size = new System.Drawing.Size(72, 26);
            this.firstPrice.TabIndex = 8;
            this.firstPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstPrice_KeyPress);
            // 
            // secondPrice
            // 
            this.secondPrice.Location = new System.Drawing.Point(301, 124);
            this.secondPrice.MaxLength = 5;
            this.secondPrice.Name = "secondPrice";
            this.secondPrice.Size = new System.Drawing.Size(72, 26);
            this.secondPrice.TabIndex = 9;
            this.secondPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstPrice_KeyPress);
            // 
            // comboService
            // 
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(190, 57);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(449, 26);
            this.comboService.TabIndex = 10;
            this.comboService.SelectedIndexChanged += new System.EventHandler(this.comboService_SelectedIndexChanged);
            // 
            // comboFIO
            // 
            this.comboFIO.FormattingEnabled = true;
            this.comboFIO.Location = new System.Drawing.Point(190, 89);
            this.comboFIO.Name = "comboFIO";
            this.comboFIO.Size = new System.Drawing.Size(449, 26);
            this.comboFIO.TabIndex = 11;
            this.comboFIO.SelectedIndexChanged += new System.EventHandler(this.comboFIO_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Barbershop.Properties.Resources.delete_40_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(661, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 72);
            this.button1.TabIndex = 21;
            this.button1.Text = "Сбросить фильтры";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoneWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1252, 641);
            this.Controls.Add(this.DeleteOrders);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.groupBox1);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button DeleteOrders;
        private System.Windows.Forms.ToolStripStatusLabel summLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboFIO;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.TextBox secondPrice;
        private System.Windows.Forms.TextBox firstPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}