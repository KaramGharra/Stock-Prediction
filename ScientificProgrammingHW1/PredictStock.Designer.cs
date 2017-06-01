namespace ScientificProgrammingHW1
{
    partial class PredictStock
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.btnGetRecords = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FromDt = new System.Windows.Forms.DateTimePicker();
            this.ToDt = new System.Windows.Forms.DateTimePicker();
            this.FromDtStatus = new System.Windows.Forms.Label();
            this.toDtStat = new System.Windows.Forms.Label();
            this.HistoryRecords = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClosingPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PredictionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PredictionDate = new System.Windows.Forms.DateTimePicker();
            this.PredictionDtStatus = new System.Windows.Forms.Label();
            this.RL = new System.Windows.Forms.Label();
            this.Pr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company\'s name";
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(102, 23);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(199, 20);
            this.CompanyName.TabIndex = 1;
            this.CompanyName.TextChanged += new System.EventHandler(this.CompanyName_TextChanged);
            // 
            // btnGetRecords
            // 
            this.btnGetRecords.Location = new System.Drawing.Point(102, 174);
            this.btnGetRecords.Name = "btnGetRecords";
            this.btnGetRecords.Size = new System.Drawing.Size(203, 23);
            this.btnGetRecords.TabIndex = 2;
            this.btnGetRecords.Text = "Get Records and Predictions";
            this.btnGetRecords.UseVisualStyleBackColor = true;
            this.btnGetRecords.Click += new System.EventHandler(this.btnGetRecords_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Get historical records:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "to:";
            // 
            // FromDt
            // 
            this.FromDt.Location = new System.Drawing.Point(102, 87);
            this.FromDt.Name = "FromDt";
            this.FromDt.Size = new System.Drawing.Size(203, 20);
            this.FromDt.TabIndex = 6;
            this.FromDt.Value = new System.DateTime(2016, 4, 10, 0, 0, 0, 0);
            this.FromDt.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ToDt
            // 
            this.ToDt.Location = new System.Drawing.Point(102, 113);
            this.ToDt.Name = "ToDt";
            this.ToDt.Size = new System.Drawing.Size(203, 20);
            this.ToDt.TabIndex = 7;
            this.ToDt.Value = new System.DateTime(2017, 4, 9, 0, 0, 0, 0);
            this.ToDt.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FromDtStatus
            // 
            this.FromDtStatus.AutoSize = true;
            this.FromDtStatus.ForeColor = System.Drawing.Color.Red;
            this.FromDtStatus.Location = new System.Drawing.Point(311, 81);
            this.FromDtStatus.Name = "FromDtStatus";
            this.FromDtStatus.Size = new System.Drawing.Size(143, 26);
            this.FromDtStatus.TabIndex = 8;
            this.FromDtStatus.Text = "From Date can only be set to\r\n a date before today\r\n";
            // 
            // toDtStat
            // 
            this.toDtStat.AutoSize = true;
            this.toDtStat.ForeColor = System.Drawing.Color.Red;
            this.toDtStat.Location = new System.Drawing.Point(311, 113);
            this.toDtStat.Name = "toDtStat";
            this.toDtStat.Size = new System.Drawing.Size(143, 26);
            this.toDtStat.TabIndex = 9;
            this.toDtStat.Text = "To date can only be set to a \r\ndate after from date";
            // 
            // HistoryRecords
            // 
            this.HistoryRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.ClosingPrice});
            this.HistoryRecords.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.HistoryRecords.Location = new System.Drawing.Point(102, 213);
            this.HistoryRecords.Name = "HistoryRecords";
            this.HistoryRecords.Size = new System.Drawing.Size(199, 228);
            this.HistoryRecords.TabIndex = 10;
            this.HistoryRecords.UseCompatibleStateImageBehavior = false;
            this.HistoryRecords.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 74;
            // 
            // ClosingPrice
            // 
            this.ClosingPrice.Text = "Closing Price";
            this.ClosingPrice.Width = 120;
            // 
            // PredictionChart
            // 
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisY.Title = "Closing Price";
            chartArea1.Name = "ChartArea1";
            this.PredictionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PredictionChart.Legends.Add(legend1);
            this.PredictionChart.Location = new System.Drawing.Point(497, 58);
            this.PredictionChart.Name = "PredictionChart";
            this.PredictionChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBorderWidth = 3;
            series1.Legend = "Legend1";
            series1.Name = "BestFit";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
            series2.Legend = "Legend1";
            series2.Name = "points";
            series2.YValuesPerPoint = 4;
            this.PredictionChart.Series.Add(series1);
            this.PredictionChart.Series.Add(series2);
            this.PredictionChart.Size = new System.Drawing.Size(669, 442);
            this.PredictionChart.TabIndex = 11;
            this.PredictionChart.Text = "chart1";
            // 
            // ChartTitle
            // 
            this.ChartTitle.AutoSize = true;
            this.ChartTitle.Location = new System.Drawing.Point(736, 26);
            this.ChartTitle.Name = "ChartTitle";
            this.ChartTitle.Size = new System.Drawing.Size(111, 13);
            this.ChartTitle.TabIndex = 12;
            this.ChartTitle.Text = "Regression linear Line";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date of prediction";
            // 
            // PredictionDate
            // 
            this.PredictionDate.Location = new System.Drawing.Point(102, 139);
            this.PredictionDate.Name = "PredictionDate";
            this.PredictionDate.Size = new System.Drawing.Size(203, 20);
            this.PredictionDate.TabIndex = 14;
            this.PredictionDate.Value = new System.DateTime(2017, 4, 11, 0, 0, 0, 0);
            this.PredictionDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // PredictionDtStatus
            // 
            this.PredictionDtStatus.AutoSize = true;
            this.PredictionDtStatus.ForeColor = System.Drawing.Color.Red;
            this.PredictionDtStatus.Location = new System.Drawing.Point(311, 139);
            this.PredictionDtStatus.Name = "PredictionDtStatus";
            this.PredictionDtStatus.Size = new System.Drawing.Size(136, 26);
            this.PredictionDtStatus.TabIndex = 15;
            this.PredictionDtStatus.Text = "Prediction date can only be\r\nin the future";
            this.PredictionDtStatus.Visible = false;
            // 
            // RL
            // 
            this.RL.AutoSize = true;
            this.RL.Location = new System.Drawing.Point(494, 527);
            this.RL.Name = "RL";
            this.RL.Size = new System.Drawing.Size(121, 13);
            this.RL.TabIndex = 16;
            this.RL.Text = "Best-Fit Regression Line";
            // 
            // Pr
            // 
            this.Pr.AutoSize = true;
            this.Pr.Location = new System.Drawing.Point(494, 554);
            this.Pr.Name = "Pr";
            this.Pr.Size = new System.Drawing.Size(85, 13);
            this.Pr.TabIndex = 17;
            this.Pr.Text = "Stock Prediction";
            // 
            // PredictStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 470);
            this.Controls.Add(this.Pr);
            this.Controls.Add(this.RL);
            this.Controls.Add(this.PredictionDtStatus);
            this.Controls.Add(this.PredictionDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChartTitle);
            this.Controls.Add(this.PredictionChart);
            this.Controls.Add(this.HistoryRecords);
            this.Controls.Add(this.toDtStat);
            this.Controls.Add(this.FromDtStatus);
            this.Controls.Add(this.ToDt);
            this.Controls.Add(this.FromDt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetRecords);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.label1);
            this.Name = "PredictStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Predict Stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PredictionChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.Button btnGetRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FromDt;
        private System.Windows.Forms.DateTimePicker ToDt;
        private System.Windows.Forms.Label FromDtStatus;
        private System.Windows.Forms.Label toDtStat;
        private System.Windows.Forms.ListView HistoryRecords;
        private System.Windows.Forms.DataVisualization.Charting.Chart PredictionChart;
        private System.Windows.Forms.Label ChartTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker PredictionDate;
        private System.Windows.Forms.Label PredictionDtStatus;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader ClosingPrice;
        private System.Windows.Forms.Label RL;
        private System.Windows.Forms.Label Pr;
    }
}

