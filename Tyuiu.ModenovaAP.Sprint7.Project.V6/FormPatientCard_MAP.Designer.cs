namespace Tyuiu.ModenovaAP.Sprint7.Project.V6
{
    partial class FormPatientCard_MAP
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
            this.chartStats_MAP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxStats_MAP = new System.Windows.Forms.GroupBox();
            this.textBoxAvgTime_MAP = new System.Windows.Forms.TextBox();
            this.textBoxMaxTime_MAP = new System.Windows.Forms.TextBox();
            this.textBoxMinTime_MAP = new System.Windows.Forms.TextBox();
            this.textBoxPatientsTimes_MAP = new System.Windows.Forms.TextBox();
            this.labelAvgTime_MAP = new System.Windows.Forms.Label();
            this.labelMaxTime_MAP = new System.Windows.Forms.Label();
            this.labelMinTime_MAP = new System.Windows.Forms.Label();
            this.labelPatientsTimes_MAP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_MAP)).BeginInit();
            this.groupBoxStats_MAP.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartStats_MAP
            // 
            this.chartStats_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            chartArea1.Name = "ChartArea1";
            this.chartStats_MAP.ChartAreas.Add(chartArea1);
            this.chartStats_MAP.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartStats_MAP.Legends.Add(legend1);
            this.chartStats_MAP.Location = new System.Drawing.Point(161, 0);
            this.chartStats_MAP.Name = "chartStats_MAP";
            series1.BackImageTransparentColor = System.Drawing.Color.White;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.IsVisibleInLegend = false;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStats_MAP.Series.Add(series1);
            this.chartStats_MAP.Size = new System.Drawing.Size(641, 465);
            this.chartStats_MAP.TabIndex = 3;
            this.chartStats_MAP.Text = "chart1";
            // 
            // groupBoxStats_MAP
            // 
            this.groupBoxStats_MAP.Controls.Add(this.textBoxAvgTime_MAP);
            this.groupBoxStats_MAP.Controls.Add(this.textBoxMaxTime_MAP);
            this.groupBoxStats_MAP.Controls.Add(this.textBoxMinTime_MAP);
            this.groupBoxStats_MAP.Controls.Add(this.textBoxPatientsTimes_MAP);
            this.groupBoxStats_MAP.Controls.Add(this.labelAvgTime_MAP);
            this.groupBoxStats_MAP.Controls.Add(this.labelMaxTime_MAP);
            this.groupBoxStats_MAP.Controls.Add(this.labelMinTime_MAP);
            this.groupBoxStats_MAP.Controls.Add(this.labelPatientsTimes_MAP);
            this.groupBoxStats_MAP.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxStats_MAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxStats_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.groupBoxStats_MAP.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStats_MAP.Name = "groupBoxStats_MAP";
            this.groupBoxStats_MAP.Size = new System.Drawing.Size(161, 465);
            this.groupBoxStats_MAP.TabIndex = 2;
            this.groupBoxStats_MAP.TabStop = false;
            this.groupBoxStats_MAP.Text = "Статистика";
            // 
            // textBoxAvgTime_MAP
            // 
            this.textBoxAvgTime_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxAvgTime_MAP.Location = new System.Drawing.Point(12, 313);
            this.textBoxAvgTime_MAP.Name = "textBoxAvgTime_MAP";
            this.textBoxAvgTime_MAP.ReadOnly = true;
            this.textBoxAvgTime_MAP.Size = new System.Drawing.Size(125, 24);
            this.textBoxAvgTime_MAP.TabIndex = 7;
            // 
            // textBoxMaxTime_MAP
            // 
            this.textBoxMaxTime_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxMaxTime_MAP.Location = new System.Drawing.Point(12, 248);
            this.textBoxMaxTime_MAP.Name = "textBoxMaxTime_MAP";
            this.textBoxMaxTime_MAP.ReadOnly = true;
            this.textBoxMaxTime_MAP.Size = new System.Drawing.Size(125, 24);
            this.textBoxMaxTime_MAP.TabIndex = 6;
            // 
            // textBoxMinTime_MAP
            // 
            this.textBoxMinTime_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxMinTime_MAP.Location = new System.Drawing.Point(16, 167);
            this.textBoxMinTime_MAP.Name = "textBoxMinTime_MAP";
            this.textBoxMinTime_MAP.ReadOnly = true;
            this.textBoxMinTime_MAP.Size = new System.Drawing.Size(125, 24);
            this.textBoxMinTime_MAP.TabIndex = 5;
            // 
            // textBoxPatientsTimes_MAP
            // 
            this.textBoxPatientsTimes_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxPatientsTimes_MAP.Location = new System.Drawing.Point(16, 79);
            this.textBoxPatientsTimes_MAP.Name = "textBoxPatientsTimes_MAP";
            this.textBoxPatientsTimes_MAP.ReadOnly = true;
            this.textBoxPatientsTimes_MAP.Size = new System.Drawing.Size(125, 24);
            this.textBoxPatientsTimes_MAP.TabIndex = 4;
            // 
            // labelAvgTime_MAP
            // 
            this.labelAvgTime_MAP.AutoSize = true;
            this.labelAvgTime_MAP.Location = new System.Drawing.Point(13, 292);
            this.labelAvgTime_MAP.Name = "labelAvgTime_MAP";
            this.labelAvgTime_MAP.Size = new System.Drawing.Size(115, 18);
            this.labelAvgTime_MAP.TabIndex = 3;
            this.labelAvgTime_MAP.Text = "Среднее время";
            // 
            // labelMaxTime_MAP
            // 
            this.labelMaxTime_MAP.AutoSize = true;
            this.labelMaxTime_MAP.Location = new System.Drawing.Point(2, 209);
            this.labelMaxTime_MAP.Name = "labelMaxTime_MAP";
            this.labelMaxTime_MAP.Size = new System.Drawing.Size(155, 36);
            this.labelMaxTime_MAP.TabIndex = 2;
            this.labelMaxTime_MAP.Text = "Максимальный срок\r\nнетрудоспособности";
            this.labelMaxTime_MAP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMinTime_MAP
            // 
            this.labelMinTime_MAP.AutoSize = true;
            this.labelMinTime_MAP.Location = new System.Drawing.Point(2, 128);
            this.labelMinTime_MAP.Name = "labelMinTime_MAP";
            this.labelMinTime_MAP.Size = new System.Drawing.Size(155, 36);
            this.labelMinTime_MAP.TabIndex = 1;
            this.labelMinTime_MAP.Text = "Минимальный срок\r\nнетрудоспособности";
            this.labelMinTime_MAP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPatientsTimes_MAP
            // 
            this.labelPatientsTimes_MAP.AutoSize = true;
            this.labelPatientsTimes_MAP.Location = new System.Drawing.Point(35, 58);
            this.labelPatientsTimes_MAP.Name = "labelPatientsTimes_MAP";
            this.labelPatientsTimes_MAP.Size = new System.Drawing.Size(82, 18);
            this.labelPatientsTimes_MAP.TabIndex = 0;
            this.labelPatientsTimes_MAP.Text = "Раз болел";
            // 
            // FormPatientCard_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(802, 465);
            this.Controls.Add(this.chartStats_MAP);
            this.Controls.Add(this.groupBoxStats_MAP);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.MinimumSize = new System.Drawing.Size(564, 389);
            this.Name = "FormPatientCard_MAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пациент ";
            this.Load += new System.EventHandler(this.FormPatientCard_MAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_MAP)).EndInit();
            this.groupBoxStats_MAP.ResumeLayout(false);
            this.groupBoxStats_MAP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_MAP;
        private System.Windows.Forms.GroupBox groupBoxStats_MAP;
        private System.Windows.Forms.TextBox textBoxAvgTime_MAP;
        private System.Windows.Forms.TextBox textBoxMaxTime_MAP;
        private System.Windows.Forms.TextBox textBoxMinTime_MAP;
        private System.Windows.Forms.TextBox textBoxPatientsTimes_MAP;
        private System.Windows.Forms.Label labelAvgTime_MAP;
        private System.Windows.Forms.Label labelMaxTime_MAP;
        private System.Windows.Forms.Label labelMinTime_MAP;
        private System.Windows.Forms.Label labelPatientsTimes_MAP;
    }
}