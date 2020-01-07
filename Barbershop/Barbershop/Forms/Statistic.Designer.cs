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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseExe = new System.Windows.Forms.PictureBox();
            this.chartSum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.period = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseExe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCount)).BeginInit();
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
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 90F;
            chartArea1.InnerPlotPosition.Width = 90F;
            chartArea1.InnerPlotPosition.X = 8F;
            chartArea1.InnerPlotPosition.Y = 5F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 70F;
            chartArea1.Position.Width = 95F;
            chartArea1.Position.Y = 13F;
            this.chartSum.ChartAreas.Add(chartArea1);
            this.chartSum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Verdana", 8F);
            legend1.IsEquallySpacedItems = true;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSpacing = 10;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5F;
            legend1.Position.Width = 20F;
            legend1.Position.X = 75F;
            legend1.Position.Y = 15F;
            this.chartSum.Legends.Add(legend1);
            this.chartSum.Location = new System.Drawing.Point(12, 31);
            this.chartSum.Name = "chartSum";
            this.chartSum.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "PixelPointWidth=40, DrawSideBySide=True, DrawingStyle=Cylinder, MinPixelPointWidt" +
    "h=15, PointWidth=0.3, LabelStyle=Bottom, MaxPixelPointWidth=40";
            series1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Label = "#VAL";
            series1.LabelBackColor = System.Drawing.SystemColors.Info;
            series1.LabelBorderColor = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Выручка";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartSum.Series.Add(series1);
            this.chartSum.Size = new System.Drawing.Size(1082, 507);
            this.chartSum.TabIndex = 2;
            this.chartSum.TabStop = false;
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "title";
            title1.Text = "Выручка за период";
            this.chartSum.Titles.Add(title1);
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
            chartArea2.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 75F;
            chartArea2.InnerPlotPosition.Width = 90F;
            chartArea2.InnerPlotPosition.X = 8F;
            chartArea2.InnerPlotPosition.Y = 5F;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 85F;
            chartArea2.Position.Width = 95F;
            chartArea2.Position.Y = 10F;
            this.chartCount.ChartAreas.Add(chartArea2);
            this.chartCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Verdana", 8F);
            legend2.IsEquallySpacedItems = true;
            legend2.IsTextAutoFit = false;
            legend2.ItemColumnSpacing = 10;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 5F;
            legend2.Position.Width = 20F;
            legend2.Position.X = 75F;
            legend2.Position.Y = 15F;
            this.chartCount.Legends.Add(legend2);
            this.chartCount.Location = new System.Drawing.Point(12, 559);
            this.chartCount.Name = "chartCount";
            this.chartCount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "PixelPointWidth=40, DrawSideBySide=True, DrawingStyle=Cylinder, MinPixelPointWidt" +
    "h=15, PointWidth=0.3, LabelStyle=Bottom, MaxPixelPointWidth=40";
            series2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.Label = "#VAL";
            series2.LabelBackColor = System.Drawing.SystemColors.Info;
            series2.LabelBorderColor = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Black;
            series2.MarkerColor = System.Drawing.Color.White;
            series2.Name = "Количество работ";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartCount.Series.Add(series2);
            this.chartCount.Size = new System.Drawing.Size(1082, 540);
            this.chartCount.TabIndex = 7;
            this.chartCount.TabStop = false;
            title2.BackColor = System.Drawing.Color.Transparent;
            title2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "title";
            title2.Text = "Количество выполненных работ на мастера";
            this.chartCount.Titles.Add(title2);
            // 
            // period
            // 
            this.period.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.period.FormattingEnabled = true;
            this.period.Items.AddRange(new object[] {
            "За последние 2недели",
            "За последний месяц"});
            this.period.Location = new System.Drawing.Point(90, 79);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(314, 26);
            this.period.TabIndex = 8;
            this.period.SelectedIndexChanged += new System.EventHandler(this.period_SelectedIndexChanged);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1106, 1102);
            this.Controls.Add(this.period);
            this.Controls.Add(this.chartCount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartSum);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseExe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCount;
        private System.Windows.Forms.ComboBox period;
    }
}