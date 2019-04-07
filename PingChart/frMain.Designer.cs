namespace PingChart
{
    partial class frMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPingCount = new System.Windows.Forms.Label();
            this.lbLoss = new System.Windows.Forms.Label();
            this.lbMinPing = new System.Windows.Forms.Label();
            this.lbMaxPing = new System.Windows.Forms.Label();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbAvg = new System.Windows.Forms.Label();
            this.lbRunningTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.gbInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PingChart);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 701);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRunningTime);
            this.groupBox1.Controls.Add(this.lbAvg);
            this.groupBox1.Controls.Add(this.lbPingCount);
            this.groupBox1.Controls.Add(this.lbLoss);
            this.groupBox1.Controls.Add(this.lbMinPing);
            this.groupBox1.Controls.Add(this.lbMaxPing);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "狀態";
            // 
            // lbPingCount
            // 
            this.lbPingCount.AutoSize = true;
            this.lbPingCount.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbPingCount.Location = new System.Drawing.Point(410, 16);
            this.lbPingCount.Name = "lbPingCount";
            this.lbPingCount.Size = new System.Drawing.Size(99, 19);
            this.lbPingCount.TabIndex = 6;
            this.lbPingCount.Text = "Ping總數：";
            // 
            // lbLoss
            // 
            this.lbLoss.AutoSize = true;
            this.lbLoss.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbLoss.Location = new System.Drawing.Point(228, 59);
            this.lbLoss.Name = "lbLoss";
            this.lbLoss.Size = new System.Drawing.Size(66, 19);
            this.lbLoss.TabIndex = 5;
            this.lbLoss.Text = "丟失：";
            // 
            // lbMinPing
            // 
            this.lbMinPing.AutoSize = true;
            this.lbMinPing.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbMinPing.Location = new System.Drawing.Point(6, 59);
            this.lbMinPing.Name = "lbMinPing";
            this.lbMinPing.Size = new System.Drawing.Size(85, 19);
            this.lbMinPing.TabIndex = 4;
            this.lbMinPing.Text = "最低值：";
            // 
            // lbMaxPing
            // 
            this.lbMaxPing.AutoSize = true;
            this.lbMaxPing.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbMaxPing.Location = new System.Drawing.Point(6, 18);
            this.lbMaxPing.Name = "lbMaxPing";
            this.lbMaxPing.Size = new System.Drawing.Size(85, 19);
            this.lbMaxPing.TabIndex = 3;
            this.lbMaxPing.Text = "最高值：";
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.btnStart);
            this.gbInput.Controls.Add(this.tbIp);
            this.gbInput.Controls.Add(this.label1);
            this.gbInput.Location = new System.Drawing.Point(688, 4);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(362, 84);
            this.gbInput.TabIndex = 0;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "IP輸入";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(213, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 63);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Ping!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbIp
            // 
            this.tbIp.Font = new System.Drawing.Font("新細明體", 14F);
            this.tbIp.Location = new System.Drawing.Point(40, 33);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(160, 30);
            this.tbIp.TabIndex = 1;
            this.tbIp.Text = "168.95.1.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F);
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // PingChart
            // 
            chartArea2.Name = "ChartArea1";
            this.PingChart.ChartAreas.Add(chartArea2);
            this.PingChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            legend6.Name = "Legend2";
            legend7.Name = "Legend3";
            legend8.Name = "Legend4";
            this.PingChart.Legends.Add(legend5);
            this.PingChart.Legends.Add(legend6);
            this.PingChart.Legends.Add(legend7);
            this.PingChart.Legends.Add(legend8);
            this.PingChart.Location = new System.Drawing.Point(0, 0);
            this.PingChart.Margin = new System.Windows.Forms.Padding(0);
            this.PingChart.Name = "PingChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend2";
            series2.Name = "Series1";
            this.PingChart.Series.Add(series2);
            this.PingChart.Size = new System.Drawing.Size(1054, 607);
            this.PingChart.TabIndex = 0;
            this.PingChart.Text = "圖表";
            // 
            // lbAvg
            // 
            this.lbAvg.AutoSize = true;
            this.lbAvg.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbAvg.Location = new System.Drawing.Point(209, 16);
            this.lbAvg.Name = "lbAvg";
            this.lbAvg.Size = new System.Drawing.Size(85, 19);
            this.lbAvg.TabIndex = 7;
            this.lbAvg.Text = "平均值：";
            // 
            // lbRunningTime
            // 
            this.lbRunningTime.AutoSize = true;
            this.lbRunningTime.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbRunningTime.Location = new System.Drawing.Point(405, 57);
            this.lbRunningTime.Name = "lbRunningTime";
            this.lbRunningTime.Size = new System.Drawing.Size(104, 19);
            this.lbRunningTime.TabIndex = 8;
            this.lbRunningTime.Text = "運行時間：";
            // 
            // frMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1054, 701);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frMain";
            this.Text = "Ping測試程式";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frMain_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PingChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart PingChart;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMaxPing;
        private System.Windows.Forms.Label lbMinPing;
        private System.Windows.Forms.Label lbLoss;
        private System.Windows.Forms.Label lbPingCount;
        private System.Windows.Forms.Label lbAvg;
        private System.Windows.Forms.Label lbRunningTime;
    }
}

