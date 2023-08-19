
namespace BudgetCalculatorAppUI
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.totalArrivalLabel = new System.Windows.Forms.Label();
            this.totalExpenseLabel = new System.Windows.Forms.Label();
            this.totalResultLabel = new System.Windows.Forms.Label();
            this.mostPopularCategoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Expenses";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(573, 174);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(600, 12);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "ExpensesIncomes";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(174, 174);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // totalArrivalLabel
            // 
            this.totalArrivalLabel.AutoSize = true;
            this.totalArrivalLabel.Location = new System.Drawing.Point(13, 201);
            this.totalArrivalLabel.Name = "totalArrivalLabel";
            this.totalArrivalLabel.Size = new System.Drawing.Size(35, 13);
            this.totalArrivalLabel.TabIndex = 2;
            this.totalArrivalLabel.Text = "label1";
            // 
            // totalExpenseLabel
            // 
            this.totalExpenseLabel.AutoSize = true;
            this.totalExpenseLabel.Location = new System.Drawing.Point(13, 223);
            this.totalExpenseLabel.Name = "totalExpenseLabel";
            this.totalExpenseLabel.Size = new System.Drawing.Size(35, 13);
            this.totalExpenseLabel.TabIndex = 3;
            this.totalExpenseLabel.Text = "label2";
            // 
            // totalResultLabel
            // 
            this.totalResultLabel.AutoSize = true;
            this.totalResultLabel.Location = new System.Drawing.Point(12, 249);
            this.totalResultLabel.Name = "totalResultLabel";
            this.totalResultLabel.Size = new System.Drawing.Size(35, 13);
            this.totalResultLabel.TabIndex = 4;
            this.totalResultLabel.Text = "label2";
            // 
            // mostPopularCategoryLabel
            // 
            this.mostPopularCategoryLabel.AutoSize = true;
            this.mostPopularCategoryLabel.Location = new System.Drawing.Point(12, 275);
            this.mostPopularCategoryLabel.Name = "mostPopularCategoryLabel";
            this.mostPopularCategoryLabel.Size = new System.Drawing.Size(35, 13);
            this.mostPopularCategoryLabel.TabIndex = 5;
            this.mostPopularCategoryLabel.Text = "label2";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 317);
            this.Controls.Add(this.mostPopularCategoryLabel);
            this.Controls.Add(this.totalResultLabel);
            this.Controls.Add(this.totalExpenseLabel);
            this.Controls.Add(this.totalArrivalLabel);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label totalArrivalLabel;
        private System.Windows.Forms.Label totalExpenseLabel;
        private System.Windows.Forms.Label totalResultLabel;
        private System.Windows.Forms.Label mostPopularCategoryLabel;
    }
}