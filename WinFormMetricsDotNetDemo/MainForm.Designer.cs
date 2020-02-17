namespace WinFormMetricsDotNetDemo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GaugeButton = new System.Windows.Forms.Button();
            this.CounterButton = new System.Windows.Forms.Button();
            this.HistogramButton = new System.Windows.Forms.Button();
            this.MeterButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.GaugeButton);
            this.MainPanel.Controls.Add(this.CounterButton);
            this.MainPanel.Controls.Add(this.HistogramButton);
            this.MainPanel.Controls.Add(this.MeterButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(572, 360);
            this.MainPanel.TabIndex = 0;
            // 
            // GaugeButton
            // 
            this.GaugeButton.Location = new System.Drawing.Point(3, 3);
            this.GaugeButton.Name = "GaugeButton";
            this.GaugeButton.Size = new System.Drawing.Size(184, 76);
            this.GaugeButton.TabIndex = 0;
            this.GaugeButton.Text = "Gauge";
            this.GaugeButton.UseVisualStyleBackColor = true;
            this.GaugeButton.Click += new System.EventHandler(this.GaugeButton_Click);
            // 
            // CounterButton
            // 
            this.CounterButton.Location = new System.Drawing.Point(193, 3);
            this.CounterButton.Name = "CounterButton";
            this.CounterButton.Size = new System.Drawing.Size(184, 76);
            this.CounterButton.TabIndex = 1;
            this.CounterButton.Text = "Counter";
            this.CounterButton.UseVisualStyleBackColor = true;
            this.CounterButton.Click += new System.EventHandler(this.CounterButton_Click);
            // 
            // HistogramButton
            // 
            this.HistogramButton.Location = new System.Drawing.Point(383, 3);
            this.HistogramButton.Name = "HistogramButton";
            this.HistogramButton.Size = new System.Drawing.Size(184, 76);
            this.HistogramButton.TabIndex = 2;
            this.HistogramButton.Text = "Histogram";
            this.HistogramButton.UseVisualStyleBackColor = true;
            this.HistogramButton.Click += new System.EventHandler(this.HistogramButton_Click);
            // 
            // MeterButton
            // 
            this.MeterButton.Location = new System.Drawing.Point(3, 85);
            this.MeterButton.Name = "MeterButton";
            this.MeterButton.Size = new System.Drawing.Size(184, 76);
            this.MeterButton.TabIndex = 3;
            this.MeterButton.Text = "Meter";
            this.MeterButton.UseVisualStyleBackColor = true;
            this.MeterButton.Click += new System.EventHandler(this.MeterButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 360);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private System.Windows.Forms.Button GaugeButton;
        private System.Windows.Forms.Button CounterButton;
        private System.Windows.Forms.Button HistogramButton;
        private System.Windows.Forms.Button MeterButton;
    }
}

