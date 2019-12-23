namespace Barbershop
{
    partial class MastersServices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseExe = new System.Windows.Forms.PictureBox();
            this.MastersTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasterSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.count = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mastersPage = new System.Windows.Forms.TabPage();
            this.servicePage = new System.Windows.Forms.TabPage();
            this.tableService = new System.Windows.Forms.DataGridView();
            this.id_serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editService = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchService = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MastersTable)).BeginInit();
            this.editContextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.mastersPage.SuspendLayout();
            this.servicePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableService)).BeginInit();
            this.editService.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(862, 26);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_Masters_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_Masters_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_Masters_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Состав мастеров парикмахерской  и доступные услуги";
            // 
            // CloseExe
            // 
            this.CloseExe.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CloseExe.Image = global::Barbershop.Properties.Resources.multiply;
            this.CloseExe.Location = new System.Drawing.Point(818, 0);
            this.CloseExe.Name = "CloseExe";
            this.CloseExe.Size = new System.Drawing.Size(22, 22);
            this.CloseExe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseExe.TabIndex = 5;
            this.CloseExe.TabStop = false;
            this.CloseExe.Click += new System.EventHandler(this.CloseExe_Click);
            this.CloseExe.MouseLeave += new System.EventHandler(this.CloseExe_MouseLeave);
            this.CloseExe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseExe_MouseMove);
            // 
            // MastersTable
            // 
            this.MastersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MastersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MasterSurname,
            this.MasterName,
            this.Patronymic,
            this.Order,
            this.Sum});
            this.MastersTable.ContextMenuStrip = this.editContextMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MastersTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.MastersTable.Location = new System.Drawing.Point(7, 34);
            this.MastersTable.MultiSelect = false;
            this.MastersTable.Name = "MastersTable";
            this.MastersTable.RowHeadersWidth = 51;
            this.MastersTable.RowTemplate.Height = 24;
            this.MastersTable.Size = new System.Drawing.Size(836, 278);
            this.MastersTable.TabIndex = 7;
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
            this.MasterSurname.Width = 101;
            // 
            // MasterName
            // 
            this.MasterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MasterName.HeaderText = "Имя";
            this.MasterName.MaxInputLength = 45;
            this.MasterName.MinimumWidth = 6;
            this.MasterName.Name = "MasterName";
            this.MasterName.ReadOnly = true;
            this.MasterName.Width = 66;
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.MaxInputLength = 45;
            this.Patronymic.MinimumWidth = 6;
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            this.Patronymic.Width = 103;
            // 
            // Order
            // 
            this.Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Order.HeaderText = "Адрес";
            this.Order.MaxInputLength = 1000;
            this.Order.MinimumWidth = 6;
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sum.HeaderText = "Телефон";
            this.Sum.MaxInputLength = 5;
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // editContextMenu
            // 
            this.editContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.editContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьДанныеToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.editContextMenu.Name = "editContextMenu";
            this.editContextMenu.Size = new System.Drawing.Size(238, 52);
            // 
            // редактироватьДанныеToolStripMenuItem
            // 
            this.редактироватьДанныеToolStripMenuItem.Name = "редактироватьДанныеToolStripMenuItem";
            this.редактироватьДанныеToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.редактироватьДанныеToolStripMenuItem.Text = "Редактировать данные";
            this.редактироватьДанныеToolStripMenuItem.Click += new System.EventHandler(this.редактироватьДанныеToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Поиск:";
            // 
            // SearchField
            // 
            this.SearchField.Location = new System.Drawing.Point(84, 7);
            this.SearchField.Multiline = true;
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(759, 25);
            this.SearchField.TabIndex = 10;
            this.SearchField.TextChanged += new System.EventHandler(this.SearchField_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.count,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 26);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(103, 20);
            this.count.Text = "Количество ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel1.Text = "          ";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.mastersPage);
            this.tabControl.Controls.Add(this.servicePage);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(-1, 25);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(857, 352);
            this.tabControl.TabIndex = 13;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // mastersPage
            // 
            this.mastersPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mastersPage.Controls.Add(this.MastersTable);
            this.mastersPage.Controls.Add(this.SearchField);
            this.mastersPage.Controls.Add(this.label2);
            this.mastersPage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mastersPage.Location = new System.Drawing.Point(4, 27);
            this.mastersPage.Name = "mastersPage";
            this.mastersPage.Padding = new System.Windows.Forms.Padding(3);
            this.mastersPage.Size = new System.Drawing.Size(849, 321);
            this.mastersPage.TabIndex = 0;
            this.mastersPage.Tag = "0";
            this.mastersPage.Text = "Список мастеров";
            // 
            // servicePage
            // 
            this.servicePage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.servicePage.Controls.Add(this.tableService);
            this.servicePage.Controls.Add(this.searchService);
            this.servicePage.Controls.Add(this.label3);
            this.servicePage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicePage.Location = new System.Drawing.Point(4, 27);
            this.servicePage.Name = "servicePage";
            this.servicePage.Padding = new System.Windows.Forms.Padding(3);
            this.servicePage.Size = new System.Drawing.Size(849, 321);
            this.servicePage.TabIndex = 1;
            this.servicePage.Tag = "0";
            this.servicePage.Text = "Список услуг";
            // 
            // tableService
            // 
            this.tableService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_serv,
            this.nameService,
            this.price});
            this.tableService.ContextMenuStrip = this.editService;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableService.DefaultCellStyle = dataGridViewCellStyle1;
            this.tableService.Location = new System.Drawing.Point(7, 34);
            this.tableService.MultiSelect = false;
            this.tableService.Name = "tableService";
            this.tableService.RowHeadersWidth = 51;
            this.tableService.RowTemplate.Height = 24;
            this.tableService.Size = new System.Drawing.Size(836, 278);
            this.tableService.TabIndex = 12;
            // 
            // id_serv
            // 
            this.id_serv.HeaderText = "ID";
            this.id_serv.MaxInputLength = 5;
            this.id_serv.MinimumWidth = 6;
            this.id_serv.Name = "id_serv";
            this.id_serv.ReadOnly = true;
            this.id_serv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_serv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_serv.Width = 50;
            // 
            // nameService
            // 
            this.nameService.HeaderText = "Название услуги";
            this.nameService.MaxInputLength = 100;
            this.nameService.MinimumWidth = 6;
            this.nameService.Name = "nameService";
            this.nameService.ReadOnly = true;
            this.nameService.Width = 600;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Цена(BYN)";
            this.price.MaxInputLength = 45;
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // editService
            // 
            this.editService.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.editService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.editService.Name = "editContextMenu";
            this.editService.Size = new System.Drawing.Size(238, 52);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 24);
            this.toolStripMenuItem1.Text = "Редактировать данные";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 24);
            this.toolStripMenuItem2.Text = "Удалить";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // searchService
            // 
            this.searchService.Location = new System.Drawing.Point(84, 7);
            this.searchService.Multiline = true;
            this.searchService.Name = "searchService";
            this.searchService.Size = new System.Drawing.Size(759, 25);
            this.searchService.TabIndex = 13;
            this.searchService.TextChanged += new System.EventHandler(this.searchService_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Поиск:";
            // 
            // MastersServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(856, 403);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MastersServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Masters_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_Masters_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_Masters_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_Masters_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MastersTable)).EndInit();
            this.editContextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.mastersPage.ResumeLayout(false);
            this.mastersPage.PerformLayout();
            this.servicePage.ResumeLayout(false);
            this.servicePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableService)).EndInit();
            this.editService.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseExe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView MastersTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel count;
        private System.Windows.Forms.ContextMenuStrip editContextMenu;
        private System.Windows.Forms.ToolStripMenuItem редактироватьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mastersPage;
        private System.Windows.Forms.TabPage servicePage;
        public System.Windows.Forms.DataGridView tableService;
        private System.Windows.Forms.TextBox searchService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip editService;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameService;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
    }
}