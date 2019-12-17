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
            this.SearchField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.countWorks = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddOrder = new System.Windows.Forms.Button();
            this.DeleteOrders = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoWorks)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1268, 30);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_DoneWorks_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_DoneWorks_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_DoneWorks_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(553, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выполненные заказы";
            // 
            // CloseExe
            // 
            this.CloseExe.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CloseExe.Image = global::Barbershop.Properties.Resources.multiply;
            this.CloseExe.Location = new System.Drawing.Point(1185, 0);
            this.CloseExe.Name = "CloseExe";
            this.CloseExe.Size = new System.Drawing.Size(28, 28);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoWorks.DefaultCellStyle = dataGridViewCellStyle2;
            this.InfoWorks.Location = new System.Drawing.Point(10, 60);
            this.InfoWorks.Name = "InfoWorks";
            this.InfoWorks.RowHeadersWidth = 51;
            this.InfoWorks.RowTemplate.Height = 24;
            this.InfoWorks.Size = new System.Drawing.Size(1245, 214);
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
            this.Sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sum.HeaderText = "Сумма заказа(б.р.)";
            this.Sum.MaxInputLength = 5;
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 169;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date.HeaderText = "Дата проведения";
            this.Date.MaxInputLength = 10;
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 154;
            // 
            // SearchField
            // 
            this.SearchField.Location = new System.Drawing.Point(88, 32);
            this.SearchField.Multiline = true;
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(860, 25);
            this.SearchField.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Поиск:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countWorks});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1300, 24);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // countWorks
            // 
            this.countWorks.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countWorks.Name = "countWorks";
            this.countWorks.Size = new System.Drawing.Size(265, 18);
            this.countWorks.Text = "Количество выполненных работ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировки, фильтры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "редактировать ПКМ";
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(495, 280);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(121, 42);
            this.AddOrder.TabIndex = 16;
            this.AddOrder.Text = "Добавить заказ ";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // DeleteOrders
            // 
            this.DeleteOrders.Location = new System.Drawing.Point(690, 280);
            this.DeleteOrders.Name = "DeleteOrders";
            this.DeleteOrders.Size = new System.Drawing.Size(121, 42);
            this.DeleteOrders.TabIndex = 17;
            this.DeleteOrders.Text = "Удалить ВСЕ заказы";
            this.DeleteOrders.UseVisualStyleBackColor = true;
            this.DeleteOrders.Click += new System.EventHandler(this.DoneWorks_Click);
            // 
            // DoneWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1300, 561);
            this.Controls.Add(this.DeleteOrders);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchField);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseExe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView InfoWorks;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel countWorks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button DeleteOrders;
    }
}