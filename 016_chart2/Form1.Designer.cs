﻿namespace _016_chart2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn1chart = new System.Windows.Forms.Button();
            this.btn2chart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(476, 306);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btn1chart
            // 
            this.btn1chart.Location = new System.Drawing.Point(99, 312);
            this.btn1chart.Name = "btn1chart";
            this.btn1chart.Size = new System.Drawing.Size(108, 32);
            this.btn1chart.TabIndex = 1;
            this.btn1chart.Text = "합쳐서 그리기";
            this.btn1chart.UseVisualStyleBackColor = true;
            this.btn1chart.Click += new System.EventHandler(this.btn1chart_Click);
            // 
            // btn2chart
            // 
            this.btn2chart.Location = new System.Drawing.Point(249, 312);
            this.btn2chart.Name = "btn2chart";
            this.btn2chart.Size = new System.Drawing.Size(108, 32);
            this.btn2chart.TabIndex = 2;
            this.btn2chart.Text = "나누어 그리기";
            this.btn2chart.UseVisualStyleBackColor = true;
            this.btn2chart.Click += new System.EventHandler(this.btn2chart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 350);
            this.Controls.Add(this.btn2chart);
            this.Controls.Add(this.btn1chart);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn1chart;
        private System.Windows.Forms.Button btn2chart;
    }
}

