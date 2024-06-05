namespace IMLab13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            CreditBox = new TextBox();
            WupiupiBox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            StartStopButton = new Button();
            CreditLabel = new Label();
            WupiupiLabel = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            InitialPriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(12, 99);
            chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelFormat = "f4";
            series1.Legend = "Legend1";
            series1.Name = "Галактические кредиты";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelFormat = "f4";
            series2.Legend = "Legend1";
            series2.Name = "Вупиупи";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(805, 361);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // CreditBox
            // 
            CreditBox.Location = new Point(257, 41);
            CreditBox.Name = "CreditBox";
            CreditBox.Size = new Size(100, 23);
            CreditBox.TabIndex = 1;
            // 
            // WupiupiBox
            // 
            WupiupiBox.Location = new Point(257, 70);
            WupiupiBox.Name = "WupiupiBox";
            WupiupiBox.Size = new Size(100, 23);
            WupiupiBox.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // StartStopButton
            // 
            StartStopButton.Location = new Point(363, 54);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(96, 23);
            StartStopButton.TabIndex = 3;
            StartStopButton.Text = "Старт/Стоп";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // CreditLabel
            // 
            CreditLabel.AutoSize = true;
            CreditLabel.Location = new Point(114, 45);
            CreditLabel.Name = "CreditLabel";
            CreditLabel.Size = new Size(137, 15);
            CreditLabel.TabIndex = 4;
            CreditLabel.Text = "Галактические кредиты";
            // 
            // WupiupiLabel
            // 
            WupiupiLabel.AutoSize = true;
            WupiupiLabel.Location = new Point(197, 74);
            WupiupiLabel.Name = "WupiupiLabel";
            WupiupiLabel.Size = new Size(54, 15);
            WupiupiLabel.TabIndex = 5;
            WupiupiLabel.Text = "Вупиупи";
            // 
            // InitialPriceLabel
            // 
            InitialPriceLabel.AutoSize = true;
            InitialPriceLabel.Location = new Point(257, 23);
            InitialPriceLabel.Name = "InitialPriceLabel";
            InitialPriceLabel.Size = new Size(99, 15);
            InitialPriceLabel.TabIndex = 6;
            InitialPriceLabel.Text = "Начальная цена:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 472);
            Controls.Add(InitialPriceLabel);
            Controls.Add(WupiupiLabel);
            Controls.Add(CreditLabel);
            Controls.Add(StartStopButton);
            Controls.Add(WupiupiBox);
            Controls.Add(CreditBox);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "IMLab13";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox CreditBox;
        private TextBox WupiupiBox;
        private System.Windows.Forms.Timer timer1;
        private Button StartStopButton;
        private Label CreditLabel;
        private Label WupiupiLabel;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Label InitialPriceLabel;
    }
}
