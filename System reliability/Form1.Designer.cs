﻿
namespace System_reliability
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series55 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series56 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series57 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series58 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series59 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series60 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonPauseContinue = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chartModeling = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbRezult = new System.Windows.Forms.Label();
            this.dgStates = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelInfo = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartModeling)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStates)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1894, 800);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonPauseContinue);
            this.tabPage1.Controls.Add(this.buttonStop);
            this.tabPage1.Controls.Add(this.buttonStart);
            this.tabPage1.Controls.Add(this.chartModeling);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1886, 771);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Графики";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonPauseContinue
            // 
            this.buttonPauseContinue.Enabled = false;
            this.buttonPauseContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPauseContinue.Location = new System.Drawing.Point(1538, 84);
            this.buttonPauseContinue.Name = "buttonPauseContinue";
            this.buttonPauseContinue.Size = new System.Drawing.Size(340, 46);
            this.buttonPauseContinue.TabIndex = 3;
            this.buttonPauseContinue.Text = "Пауза";
            this.buttonPauseContinue.UseVisualStyleBackColor = true;
            this.buttonPauseContinue.Click += new System.EventHandler(this.buttonPauseContinue_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(1716, 23);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(163, 46);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(1538, 23);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(163, 46);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chartModeling
            // 
            chartArea10.AxisX.Interval = 1D;
            chartArea10.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea10.AxisX.Minimum = 0D;
            chartArea10.AxisY.Interval = 1D;
            chartArea10.AxisY.Maximum = 7D;
            chartArea10.Name = "ChartArea1";
            this.chartModeling.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartModeling.Legends.Add(legend10);
            this.chartModeling.Location = new System.Drawing.Point(6, 6);
            this.chartModeling.Name = "chartModeling";
            series55.BorderWidth = 5;
            series55.ChartArea = "ChartArea1";
            series55.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series55.Legend = "Legend1";
            series55.LegendText = "Элемент 1";
            series55.Name = "Element1";
            series56.BorderWidth = 5;
            series56.ChartArea = "ChartArea1";
            series56.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series56.Legend = "Legend1";
            series56.LegendText = "Элемент 2";
            series56.Name = "Element2";
            series56.YValuesPerPoint = 3;
            series57.BorderWidth = 5;
            series57.ChartArea = "ChartArea1";
            series57.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series57.Legend = "Legend1";
            series57.LegendText = "Элемент 3";
            series57.Name = "Element3";
            series58.BorderWidth = 5;
            series58.ChartArea = "ChartArea1";
            series58.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series58.Legend = "Legend1";
            series58.LegendText = "Элемент 4";
            series58.Name = "Element4";
            series59.BorderWidth = 5;
            series59.ChartArea = "ChartArea1";
            series59.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series59.Color = System.Drawing.Color.MediumAquamarine;
            series59.Legend = "Legend1";
            series59.LegendText = "Элемент 5";
            series59.Name = "Element5";
            series60.BorderWidth = 5;
            series60.ChartArea = "ChartArea1";
            series60.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series60.Color = System.Drawing.Color.Fuchsia;
            series60.Legend = "Legend1";
            series60.LegendText = "Система";
            series60.Name = "System";
            this.chartModeling.Series.Add(series55);
            this.chartModeling.Series.Add(series56);
            this.chartModeling.Series.Add(series57);
            this.chartModeling.Series.Add(series58);
            this.chartModeling.Series.Add(series59);
            this.chartModeling.Series.Add(series60);
            this.chartModeling.Size = new System.Drawing.Size(1526, 795);
            this.chartModeling.TabIndex = 0;
            this.chartModeling.Text = "chartModeling";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelInfo);
            this.tabPage2.Controls.Add(this.lbRezult);
            this.tabPage2.Controls.Add(this.dgStates);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1886, 771);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Данные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbRezult
            // 
            this.lbRezult.AutoSize = true;
            this.lbRezult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRezult.Location = new System.Drawing.Point(5, 12);
            this.lbRezult.Name = "lbRezult";
            this.lbRezult.Size = new System.Drawing.Size(613, 25);
            this.lbRezult.TabIndex = 1;
            this.lbRezult.Text = "Число случаев, соответствующих отказам более 3 элементов: ";
            // 
            // dgStates
            // 
            this.dgStates.AllowUserToAddRows = false;
            this.dgStates.AllowUserToDeleteRows = false;
            this.dgStates.AllowUserToResizeColumns = false;
            this.dgStates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgStates.Location = new System.Drawing.Point(6, 49);
            this.dgStates.Name = "dgStates";
            this.dgStates.RowHeadersWidth = 51;
            this.dgStates.RowTemplate.Height = 24;
            this.dgStates.Size = new System.Drawing.Size(1874, 716);
            this.dgStates.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(1365, 19);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(61, 17);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "labelInfo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Время, ч";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Состояние элемента 1";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Состояние элемента 2";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Состояние элемента 3";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Состояние элемента 4";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Состояние элемента 5";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Состояние системы";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1902, 803);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Моделирование восстанавливаемой системы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartModeling)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartModeling;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPauseContinue;
        private System.Windows.Forms.DataGridView dgStates;
        private System.Windows.Forms.Label lbRezult;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

