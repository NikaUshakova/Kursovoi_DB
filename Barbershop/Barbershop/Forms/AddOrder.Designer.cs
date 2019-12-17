﻿namespace Barbershop
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.No = new System.Windows.Forms.PictureBox();
            this.yes = new System.Windows.Forms.PictureBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.TableSelectService = new System.Windows.Forms.DataGridView();
            this.ID_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resetBtn = new System.Windows.Forms.Button();
            this.InsService = new System.Windows.Forms.Button();
            this.Summ = new System.Windows.Forms.Button();
            this.OrderDate = new System.Windows.Forms.Label();
            this.OrderMaster = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSelectMasters)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1114, 30);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_AddOrder_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_AddOrder_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_AddOrder_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(416, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добавление заказа";
            // 
            // CloseExe
            // 
            this.CloseExe.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CloseExe.Image = global::Barbershop.Properties.Resources.multiply;
            this.CloseExe.Location = new System.Drawing.Point(1069, -1);
            this.CloseExe.Name = "CloseExe";
            this.CloseExe.Size = new System.Drawing.Size(28, 28);
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
            this.OrderSum.Location = new System.Drawing.Point(693, 296);
            this.OrderSum.Name = "OrderSum";
            this.OrderSum.Size = new System.Drawing.Size(183, 17);
            this.OrderSum.TabIndex = 10;
            this.OrderSum.Text = "Общая сумма заказа:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TableSelectMasters);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(10, 285);
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
            this.groupBox2.Location = new System.Drawing.Point(458, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 237);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор даты";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.No);
            this.groupBox3.Controls.Add(this.yes);
            this.groupBox3.Controls.Add(this.Summ);
            this.groupBox3.Controls.Add(this.listBox);
            this.groupBox3.Controls.Add(this.TableSelectService);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(10, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1089, 243);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор услуг";
            // 
            // No
            // 
            this.No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.No.Image = ((System.Drawing.Image)(resources.GetObject("No.Image")));
            this.No.Location = new System.Drawing.Point(617, 126);
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
            this.yes.Location = new System.Drawing.Point(617, 81);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(47, 39);
            this.yes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yes.TabIndex = 17;
            this.yes.TabStop = false;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(667, 25);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(416, 184);
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
            this.TableSelectService.Size = new System.Drawing.Size(605, 213);
            this.TableSelectService.TabIndex = 11;
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
            this.resetBtn.Location = new System.Drawing.Point(905, 460);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(194, 62);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Отчистить";
            this.resetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // InsService
            // 
            this.InsService.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InsService.FlatAppearance.BorderSize = 2;
            this.InsService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsService.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsService.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InsService.Image = global::Barbershop.Properties.Resources.add_40_;
            this.InsService.Location = new System.Drawing.Point(905, 392);
            this.InsService.Name = "InsService";
            this.InsService.Size = new System.Drawing.Size(194, 62);
            this.InsService.TabIndex = 7;
            this.InsService.Text = "Добавить";
            this.InsService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InsService.UseVisualStyleBackColor = false;
            this.InsService.Click += new System.EventHandler(this.InsOrder_Click);
            // 
            // Summ
            // 
            this.Summ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Summ.FlatAppearance.BorderSize = 2;
            this.Summ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Summ.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Summ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Summ.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Summ.Location = new System.Drawing.Point(667, 197);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(416, 40);
            this.Summ.TabIndex = 17;
            this.Summ.Text = "Сумма";
            this.Summ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Summ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Summ.UseVisualStyleBackColor = false;
            this.Summ.Click += new System.EventHandler(this.Summ_Click);
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSize = true;
            this.OrderDate.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDate.Location = new System.Drawing.Point(693, 351);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(111, 17);
            this.OrderDate.TabIndex = 18;
            this.OrderDate.Text = "Дата заказа:";
            // 
            // OrderMaster
            // 
            this.OrderMaster.AutoSize = true;
            this.OrderMaster.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderMaster.Location = new System.Drawing.Point(693, 324);
            this.OrderMaster.Name = "OrderMaster";
            this.OrderMaster.Size = new System.Drawing.Size(72, 17);
            this.OrderMaster.TabIndex = 19;
            this.OrderMaster.Text = "Мастер:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 24);
            this.monthCalendar1.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.TodayDate = new System.DateTime(2019, 12, 17, 0, 0, 0, 0);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1111, 533);
            this.Controls.Add(this.OrderMaster);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.OrderSum);
            this.Controls.Add(this.InsService);
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
        private System.Windows.Forms.Button InsService;
        private System.Windows.Forms.Label OrderSum;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView TableSelectService;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.PictureBox yes;
        private System.Windows.Forms.PictureBox No;
        private System.Windows.Forms.DataGridView TableSelectMasters;
        private System.Windows.Forms.Button Summ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_master;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOmaster;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.Label OrderMaster;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}