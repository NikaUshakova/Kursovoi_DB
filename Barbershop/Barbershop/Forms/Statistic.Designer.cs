namespace Barbershop
{
    partial class Statistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistic));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseExe = new System.Windows.Forms.PictureBox();
            this.chartSum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.period = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.forward = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forward)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1108, 26);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_Statistic_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_Statistic_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_Statistic_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(402, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Статистика работы салона красоты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // chartSum
            // 
            this.chartSum.BackColor = System.Drawing.Color.PaleTurquoise;
            this.chartSum.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartSum.BackSecondaryColor = System.Drawing.SystemColors.Info;
            this.chartSum.BorderlineColor = System.Drawing.Color.Black;
            this.chartSum.BorderSkin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.chartSum.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartSum.BorderSkin.BackSecondaryColor = System.Drawing.Color.BlueViolet;
            this.chartSum.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartSum.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle6;
            chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisX.LineWidth = 2;
            chartArea3.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.AxisY.Title = "Выручка, BYN";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 71F;
            chartArea3.InnerPlotPosition.Width = 90F;
            chartArea3.InnerPlotPosition.X = 9F;
            chartArea3.InnerPlotPosition.Y = 5F;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 80F;
            chartArea3.Position.Width = 95F;
            chartArea3.Position.Y = 13F;
            this.chartSum.ChartAreas.Add(chartArea3);
            this.chartSum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Enabled = false;
            legend3.Font = new System.Drawing.Font("Verdana", 8F);
            legend3.IsEquallySpacedItems = true;
            legend3.IsTextAutoFit = false;
            legend3.ItemColumnSpacing = 10;
            legend3.Name = "Legend1";
            legend3.Position.Auto = false;
            legend3.Position.Height = 5F;
            legend3.Position.Width = 20F;
            legend3.Position.X = 75F;
            legend3.Position.Y = 15F;
            this.chartSum.Legends.Add(legend3);
            this.chartSum.Location = new System.Drawing.Point(12, 31);
            this.chartSum.Name = "chartSum";
            this.chartSum.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.BorderColor = System.Drawing.Color.Black;
            series3.ChartArea = "ChartArea1";
            series3.CustomProperties = "PixelPointWidth=50, DrawSideBySide=True, DrawingStyle=Cylinder, MinPixelPointWidt" +
    "h=15, PointWidth=0.5, LabelStyle=Top, MaxPixelPointWidth=30, EmptyPointValue=Zer" +
    "o";
            series3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.Label = "#VAL";
            series3.LabelBackColor = System.Drawing.SystemColors.Info;
            series3.LabelBorderColor = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.Black;
            series3.MarkerColor = System.Drawing.Color.White;
            series3.MarkerSize = 2;
            series3.Name = "Выручка";
            series3.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartSum.Series.Add(series3);
            this.chartSum.Size = new System.Drawing.Size(1082, 475);
            this.chartSum.TabIndex = 2;
            this.chartSum.TabStop = false;
            title3.BackColor = System.Drawing.Color.Transparent;
            title3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "title";
            title3.Text = "Выручка за период";
            this.chartSum.Titles.Add(title3);
            // 
            // chartCount
            // 
            this.chartCount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.chartCount.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartCount.BackSecondaryColor = System.Drawing.SystemColors.Info;
            this.chartCount.BorderlineColor = System.Drawing.Color.Black;
            this.chartCount.BorderSkin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.chartCount.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartCount.BorderSkin.BackSecondaryColor = System.Drawing.Color.BlueViolet;
            this.chartCount.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartCount.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle6;
            chartArea4.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea4.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.AxisX.LineWidth = 2;
            chartArea4.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LineWidth = 2;
            chartArea4.AxisY.Title = "Кол-во выполненных заказов, шт.";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.InnerPlotPosition.Auto = false;
            chartArea4.InnerPlotPosition.Height = 75F;
            chartArea4.InnerPlotPosition.Width = 90F;
            chartArea4.InnerPlotPosition.X = 8F;
            chartArea4.InnerPlotPosition.Y = 5F;
            chartArea4.Name = "ChartArea1";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 85F;
            chartArea4.Position.Width = 95F;
            chartArea4.Position.Y = 10F;
            this.chartCount.ChartAreas.Add(chartArea4);
            this.chartCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Enabled = false;
            legend4.Font = new System.Drawing.Font("Verdana", 8F);
            legend4.IsEquallySpacedItems = true;
            legend4.IsTextAutoFit = false;
            legend4.ItemColumnSpacing = 10;
            legend4.Name = "Legend1";
            legend4.Position.Auto = false;
            legend4.Position.Height = 5F;
            legend4.Position.Width = 20F;
            legend4.Position.X = 75F;
            legend4.Position.Y = 15F;
            this.chartCount.Legends.Add(legend4);
            this.chartCount.Location = new System.Drawing.Point(12, 28);
            this.chartCount.Name = "chartCount";
            this.chartCount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.BorderColor = System.Drawing.Color.Black;
            series4.ChartArea = "ChartArea1";
            series4.CustomProperties = "PixelPointWidth=50, DrawSideBySide=True, DrawingStyle=Cylinder, MinPixelPointWidt" +
    "h=15, PointWidth=0.3, LabelStyle=Top, MaxPixelPointWidth=40";
            series4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.Label = "#VAL";
            series4.LabelBackColor = System.Drawing.SystemColors.Info;
            series4.LabelBorderColor = System.Drawing.Color.Black;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.Black;
            series4.MarkerColor = System.Drawing.Color.White;
            series4.MarkerSize = 2;
            series4.Name = "Количество работ";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartCount.Series.Add(series4);
            this.chartCount.Size = new System.Drawing.Size(1082, 540);
            this.chartCount.TabIndex = 7;
            this.chartCount.TabStop = false;
            title4.BackColor = System.Drawing.Color.Transparent;
            title4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "title";
            title4.Text = "Количество выполненных работ на мастера";
            this.chartCount.Titles.Add(title4);
            // 
            // period
            // 
            this.period.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.period.FormattingEnabled = true;
            this.period.Items.AddRange(new object[] {
            "За всё время",
            "За последние 2недели",
            "За последний месяц",
            "За последние 3 месяца"});
            this.period.Location = new System.Drawing.Point(90, 79);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(314, 26);
            this.period.TabIndex = 8;
            this.period.SelectedIndexChanged += new System.EventHandler(this.period_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(474, 567);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(69, 45);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 20;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forward.Image = global::Barbershop.Properties.Resources.right;
            this.forward.Location = new System.Drawing.Point(567, 567);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(69, 45);
            this.forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forward.TabIndex = 19;
            this.forward.TabStop = false;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1106, 613);
            this.Controls.Add(this.chartCount);
            this.Controls.Add(this.period);
            this.Controls.Add(this.chartSum);
            this.Controls.Add(this.back);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_Statistic_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_Statistic_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_Statistic_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forward)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseExe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCount;
        private System.Windows.Forms.ComboBox period;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox forward;
    }
}