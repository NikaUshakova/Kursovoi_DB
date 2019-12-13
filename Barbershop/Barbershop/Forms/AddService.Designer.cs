namespace Barbershop
{
    partial class AddService
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseExe = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameService = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.InsService = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(479, 30);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_AddService_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_AddService_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_AddService_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добавление услуг";
            // 
            // CloseExe
            // 
            this.CloseExe.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CloseExe.Image = global::Barbershop.Properties.Resources.multiply;
            this.CloseExe.Location = new System.Drawing.Point(436, -1);
            this.CloseExe.Name = "CloseExe";
            this.CloseExe.Size = new System.Drawing.Size(28, 28);
            this.CloseExe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseExe.TabIndex = 5;
            this.CloseExe.TabStop = false;
            this.CloseExe.Click += new System.EventHandler(this.CloseExe_Click);
            this.CloseExe.MouseLeave += new System.EventHandler(this.CloseExe_MouseLeave);
            this.CloseExe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseExe_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название:";
            // 
            // nameService
            // 
            this.nameService.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameService.Location = new System.Drawing.Point(131, 58);
            this.nameService.MaxLength = 100;
            this.nameService.Multiline = true;
            this.nameService.Name = "nameService";
            this.nameService.Size = new System.Drawing.Size(311, 25);
            this.nameService.TabIndex = 1;
            this.nameService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameService_KeyPress);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(131, 101);
            this.price.MaxLength = 5;
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(311, 25);
            this.price.TabIndex = 2;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цена(б.р):";
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
            this.resetBtn.Location = new System.Drawing.Point(248, 143);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(194, 67);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Сброс";
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
            this.InsService.Location = new System.Drawing.Point(31, 143);
            this.InsService.Name = "InsService";
            this.InsService.Size = new System.Drawing.Size(194, 67);
            this.InsService.TabIndex = 7;
            this.InsService.Text = "Добавить";
            this.InsService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InsService.UseVisualStyleBackColor = false;
            this.InsService.Click += new System.EventHandler(this.InsService_Click);
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(475, 222);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsService);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.AddMaster_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_AddService_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_AddService_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_AddService_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseExe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameService;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetBtn;
    }
}