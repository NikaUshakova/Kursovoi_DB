namespace Barbershop
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseExe = new System.Windows.Forms.PictureBox();
            this.OrderSum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TableSelectMasters = new System.Windows.Forms.DataGridView();
            this.ID_master = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOmaster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Choose = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ownBtn = new System.Windows.Forms.RadioButton();
            this.salonBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.longBtn = new System.Windows.Forms.RadioButton();
            this.avgBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.shortBtn = new System.Windows.Forms.RadioButton();
            this.No = new System.Windows.Forms.PictureBox();
            this.yes = new System.Windows.Forms.PictureBox();
            this.Summ = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.TableSelectService = new System.Windows.Forms.DataGridView();
            this.ID_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resetBtn = new System.Windows.Forms.Button();
            this.InsOrder = new System.Windows.Forms.Button();
            this.OrderDate = new System.Windows.Forms.Label();
            this.OrderMaster = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSelectMasters)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Choose.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.No)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSelectService)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1114, 26);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_AddOrder_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_AddOrder_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_AddOrder_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(476, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добавление заказа";
            // 
            // CloseExe
            // 
            this.CloseExe.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CloseExe.Image = global::Barbershop.Properties.Resources.multiply;
            this.CloseExe.Location = new System.Drawing.Point(1073, 0);
            this.CloseExe.Name = "CloseExe";
            this.CloseExe.Size = new System.Drawing.Size(22, 22);
            this.CloseExe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseExe.TabIndex = 5;
            this.CloseExe.TabStop = false;
            this.CloseExe.Click += new System.EventHandler(this.CloseExe_Click);
            this.CloseExe.MouseLeave += new System.EventHandler(this.CloseExe_MouseLeave);
            this.CloseExe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseExe_MouseMove);
            // 
            // OrderSum
            // 
            this.OrderSum.AutoSize = true;
            this.OrderSum.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderSum.Location = new System.Drawing.Point(670, 468);
            this.OrderSum.Name = "OrderSum";
            this.OrderSum.Size = new System.Drawing.Size(183, 17);
            this.OrderSum.TabIndex = 10;
            this.OrderSum.Text = "Общая сумма заказа:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TableSelectMasters);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(10, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 237);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор мастера";
            // 
            // TableSelectMasters
            // 
            this.TableSelectMasters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSelectMasters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_master,
            this.FIOmaster});
            this.TableSelectMasters.Location = new System.Drawing.Point(6, 24);
            this.TableSelectMasters.MultiSelect = false;
            this.TableSelectMasters.Name = "TableSelectMasters";
            this.TableSelectMasters.RowHeadersWidth = 25;
            this.TableSelectMasters.RowTemplate.Height = 24;
            this.TableSelectMasters.Size = new System.Drawing.Size(429, 207);
            this.TableSelectMasters.TabIndex = 19;
            this.TableSelectMasters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableSelectMasters_CellClick);
            // 
            // ID_master
            // 
            this.ID_master.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_master.HeaderText = "ID";
            this.ID_master.MaxInputLength = 7;
            this.ID_master.MinimumWidth = 6;
            this.ID_master.Name = "ID_master";
            this.ID_master.ReadOnly = true;
            this.ID_master.Width = 51;
            // 
            // FIOmaster
            // 
            this.FIOmaster.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FIOmaster.HeaderText = "ФИО мастера";
            this.FIOmaster.MaxInputLength = 200;
            this.FIOmaster.MinimumWidth = 6;
            this.FIOmaster.Name = "FIOmaster";
            this.FIOmaster.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(458, 455);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 237);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор даты";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 24);
            this.monthCalendar1.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.TodayDate = new System.DateTime(2019, 12, 21, 0, 0, 0, 0);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Choose);
            this.groupBox3.Controls.Add(this.No);
            this.groupBox3.Controls.Add(this.yes);
            this.groupBox3.Controls.Add(this.Summ);
            this.groupBox3.Controls.Add(this.listBox);
            this.groupBox3.Controls.Add(this.TableSelectService);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(10, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1089, 409);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор услуг";
            // 
            // Choose
            // 
            this.Choose.Controls.Add(this.panel2);
            this.Choose.Controls.Add(this.label3);
            this.Choose.Controls.Add(this.longBtn);
            this.Choose.Controls.Add(this.avgBtn);
            this.Choose.Controls.Add(this.label2);
            this.Choose.Controls.Add(this.shortBtn);
            this.Choose.Enabled = false;
            this.Choose.Location = new System.Drawing.Point(667, 251);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(415, 103);
            this.Choose.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ownBtn);
            this.panel2.Controls.Add(this.salonBtn);
            this.panel2.Location = new System.Drawing.Point(156, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 64);
            this.panel2.TabIndex = 7;
            // 
            // ownBtn
            // 
            this.ownBtn.AutoSize = true;
            this.ownBtn.Location = new System.Drawing.Point(20, 3);
            this.ownBtn.Name = "ownBtn";
            this.ownBtn.Size = new System.Drawing.Size(65, 22);
            this.ownBtn.TabIndex = 5;
            this.ownBtn.TabStop = true;
            this.ownBtn.Text = "Своя";
            this.ownBtn.UseVisualStyleBackColor = true;
            // 
            // salonBtn
            // 
            this.salonBtn.AutoSize = true;
            this.salonBtn.Location = new System.Drawing.Point(20, 24);
            this.salonBtn.Name = "salonBtn";
            this.salonBtn.Size = new System.Drawing.Size(98, 22);
            this.salonBtn.TabIndex = 6;
            this.salonBtn.TabStop = true;
            this.salonBtn.Text = "Салонная";
            this.salonBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(153, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Краска:";
            // 
            // longBtn
            // 
            this.longBtn.AutoSize = true;
            this.longBtn.Location = new System.Drawing.Point(26, 65);
            this.longBtn.Name = "longBtn";
            this.longBtn.Size = new System.Drawing.Size(114, 22);
            this.longBtn.TabIndex = 3;
            this.longBtn.TabStop = true;
            this.longBtn.Text = "свыше 40см";
            this.longBtn.UseVisualStyleBackColor = true;
            // 
            // avgBtn
            // 
            this.avgBtn.AutoSize = true;
            this.avgBtn.Location = new System.Drawing.Point(26, 44);
            this.avgBtn.Name = "avgBtn";
            this.avgBtn.Size = new System.Drawing.Size(85, 22);
            this.avgBtn.TabIndex = 2;
            this.avgBtn.TabStop = true;
            this.avgBtn.Text = "20-40см";
            this.avgBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Длина волос:";
            // 
            // shortBtn
            // 
            this.shortBtn.AutoSize = true;
            this.shortBtn.Location = new System.Drawing.Point(26, 23);
            this.shortBtn.Name = "shortBtn";
            this.shortBtn.Size = new System.Drawing.Size(86, 22);
            this.shortBtn.TabIndex = 0;
            this.shortBtn.TabStop = true;
            this.shortBtn.Text = "до 20см";
            this.shortBtn.UseVisualStyleBackColor = true;
            // 
            // No
            // 
            this.No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.No.Image = ((System.Drawing.Image)(resources.GetObject("No.Image")));
            this.No.Location = new System.Drawing.Point(618, 200);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(47, 39);
            this.No.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.No.TabIndex = 18;
            this.No.TabStop = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // yes
            // 
            this.yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yes.Image = global::Barbershop.Properties.Resources.right;
            this.yes.Location = new System.Drawing.Point(618, 155);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(47, 39);
            this.yes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yes.TabIndex = 17;
            this.yes.TabStop = false;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // Summ
            // 
            this.Summ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Summ.FlatAppearance.BorderSize = 2;
            this.Summ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Summ.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Summ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Summ.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Summ.Location = new System.Drawing.Point(666, 363);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(416, 40);
            this.Summ.TabIndex = 17;
            this.Summ.Text = "Сумма";
            this.Summ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Summ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Summ.UseVisualStyleBackColor = false;
            this.Summ.Click += new System.EventHandler(this.Summ_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(667, 25);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(416, 220);
            this.listBox.TabIndex = 12;
            // 
            // TableSelectService
            // 
            this.TableSelectService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSelectService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_service,
            this.Name_service,
            this.Price});
            this.TableSelectService.Location = new System.Drawing.Point(6, 24);
            this.TableSelectService.MultiSelect = false;
            this.TableSelectService.Name = "TableSelectService";
            this.TableSelectService.RowHeadersWidth = 25;
            this.TableSelectService.RowTemplate.Height = 24;
            this.TableSelectService.Size = new System.Drawing.Size(605, 379);
            this.TableSelectService.TabIndex = 11;
            this.TableSelectService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableSelectService_CellClick);
            // 
            // ID_service
            // 
            this.ID_service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID_service.HeaderText = "ID";
            this.ID_service.MaxInputLength = 7;
            this.ID_service.MinimumWidth = 6;
            this.ID_service.Name = "ID_service";
            this.ID_service.ReadOnly = true;
            this.ID_service.Width = 51;
            // 
            // Name_service
            // 
            this.Name_service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Name_service.HeaderText = "Название услуги";
            this.Name_service.MaxInputLength = 200;
            this.Name_service.MinimumWidth = 6;
            this.Name_service.Name = "Name_service";
            this.Name_service.ReadOnly = true;
            this.Name_service.Width = 140;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Цена";
            this.Price.MaxInputLength = 5;
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resetBtn.FlatAppearance.BorderSize = 2;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetBtn.Image = global::Barbershop.Properties.Resources.reset_40_;
            this.resetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetBtn.Location = new System.Drawing.Point(905, 635);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(194, 51);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Отчистить";
            this.resetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // InsOrder
            // 
            this.InsOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InsOrder.FlatAppearance.BorderSize = 2;
            this.InsOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsOrder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InsOrder.Image = global::Barbershop.Properties.Resources.add_40_;
            this.InsOrder.Location = new System.Drawing.Point(676, 635);
            this.InsOrder.Name = "InsOrder";
            this.InsOrder.Size = new System.Drawing.Size(194, 51);
            this.InsOrder.TabIndex = 7;
            this.InsOrder.Text = "Добавить";
            this.InsOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InsOrder.UseVisualStyleBackColor = false;
            this.InsOrder.Click += new System.EventHandler(this.InsOrder_Click);
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSize = true;
            this.OrderDate.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDate.Location = new System.Drawing.Point(670, 523);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(111, 17);
            this.OrderDate.TabIndex = 18;
            this.OrderDate.Text = "Дата заказа:";
            // 
            // OrderMaster
            // 
            this.OrderMaster.AutoSize = true;
            this.OrderMaster.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderMaster.Location = new System.Drawing.Point(670, 496);
            this.OrderMaster.Name = "OrderMaster";
            this.OrderMaster.Size = new System.Drawing.Size(72, 17);
            this.OrderMaster.TabIndex = 19;
            this.OrderMaster.Text = "Мастер:";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1111, 703);
            this.Controls.Add(this.OrderMaster);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.OrderSum);
            this.Controls.Add(this.InsOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_AddOrder_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_AddOrder_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_AddOrder_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableSelectMasters)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.Choose.ResumeLayout(false);
            this.Choose.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.No)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSelectService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseExe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsOrder;
        private System.Windows.Forms.Label OrderSum;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.PictureBox yes;
        private System.Windows.Forms.PictureBox No;
        private System.Windows.Forms.DataGridView TableSelectMasters;
        private System.Windows.Forms.Button Summ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_master;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOmaster;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.Label OrderMaster;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView TableSelectService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Panel Choose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton ownBtn;
        private System.Windows.Forms.RadioButton salonBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton longBtn;
        private System.Windows.Forms.RadioButton avgBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton shortBtn;
    }
}