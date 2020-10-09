namespace BusinessSystem.FastFood.Managment
{
    partial class ReportData
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
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.MainMetroPage = new MetroFramework.Controls.MetroTabPage();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.ReportPage = new MetroFramework.Controls.MetroTabPage();
            this.Label1 = new MetroFramework.Controls.MetroLabel();
            this.Label2 = new MetroFramework.Controls.MetroLabel();
            this.CircleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabControl.SuspendLayout();
            this.MainMetroPage.SuspendLayout();
            this.ReportPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CircleChart)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MainMetroPage);
            this.TabControl.Controls.Add(this.ReportPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(20, 60);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 1;
            this.TabControl.Size = new System.Drawing.Size(822, 384);
            this.TabControl.Style = MetroFramework.MetroColorStyle.Purple;
            this.TabControl.TabIndex = 0;
            this.TabControl.UseStyleColors = true;
            // 
            // MainMetroPage
            // 
            this.MainMetroPage.Controls.Add(this.metroTile1);
            this.MainMetroPage.Controls.Add(this.Date);
            this.MainMetroPage.HorizontalScrollbarBarColor = true;
            this.MainMetroPage.Location = new System.Drawing.Point(4, 35);
            this.MainMetroPage.Name = "MainMetroPage";
            this.MainMetroPage.Size = new System.Drawing.Size(814, 345);
            this.MainMetroPage.TabIndex = 0;
            this.MainMetroPage.Text = "Главная";
            this.MainMetroPage.VerticalScrollbarBarColor = true;
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile1.Location = new System.Drawing.Point(201, 170);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(412, 61);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Открыть";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(201, 133);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(412, 31);
            this.Date.TabIndex = 6;
            // 
            // ReportPage
            // 
            this.ReportPage.Controls.Add(this.CircleChart);
            this.ReportPage.Controls.Add(this.Label2);
            this.ReportPage.Controls.Add(this.Label1);
            this.ReportPage.HorizontalScrollbarBarColor = true;
            this.ReportPage.Location = new System.Drawing.Point(4, 35);
            this.ReportPage.Name = "ReportPage";
            this.ReportPage.Size = new System.Drawing.Size(814, 345);
            this.ReportPage.TabIndex = 1;
            this.ReportPage.Text = "Отчет";
            this.ReportPage.VerticalScrollbarBarColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label1.Location = new System.Drawing.Point(22, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(66, 25);
            this.Label1.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Расход";
            this.Label1.UseStyleColors = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label2.Location = new System.Drawing.Point(22, 54);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 25);
            this.Label2.Style = MetroFramework.MetroColorStyle.Orange;
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Продажа";
            this.Label2.UseStyleColors = true;
            // 
            // CircleChart
            // 
            this.CircleChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.Name = "ChartArea1";
            this.CircleChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend";
            this.CircleChart.Legends.Add(legend1);
            this.CircleChart.Location = new System.Drawing.Point(22, 82);
            this.CircleChart.Name = "CircleChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend";
            series1.Name = "CircleChartSeries";
            this.CircleChart.Series.Add(series1);
            this.CircleChart.Size = new System.Drawing.Size(393, 222);
            this.CircleChart.TabIndex = 4;
            this.CircleChart.Text = "CircleChart";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title";
            title1.Text = "Расход и Продажи";
            title1.ToolTip = "Расход и Продажи";
            this.CircleChart.Titles.Add(title1);
            // 
            // ReportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 464);
            this.Controls.Add(this.TabControl);
            this.Name = "ReportData";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.ReportData_Load);
            this.TabControl.ResumeLayout(false);
            this.MainMetroPage.ResumeLayout(false);
            this.ReportPage.ResumeLayout(false);
            this.ReportPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CircleChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage MainMetroPage;
        private MetroFramework.Controls.MetroTabPage ReportPage;
        private MetroFramework.Controls.MetroTile metroTile1;
        public System.Windows.Forms.DateTimePicker Date;
        private MetroFramework.Controls.MetroLabel Label1;
        private MetroFramework.Controls.MetroLabel Label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart CircleChart;
    }
}