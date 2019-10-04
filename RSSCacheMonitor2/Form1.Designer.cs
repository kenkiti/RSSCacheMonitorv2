namespace RSSCacheMonitor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.richTick = new System.Windows.Forms.RichTextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblVWAP = new System.Windows.Forms.Label();
            this.lblNO = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生データ表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(121, 31);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(199, 19);
            this.txtPath.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(410, 27);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(76, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "監視開始";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(111, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(40, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(111, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "label12";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(111, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "label13";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(16, 34);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(102, 12);
            this.lblPath.TabIndex = 17;
            this.lblPath.Text = "SQLite.db へのパス：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(329, 28);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(75, 23);
            this.btnFileOpen.TabIndex = 18;
            this.btnFileOpen.Text = "参照";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // richTick
            // 
            this.richTick.BackColor = System.Drawing.Color.Black;
            this.richTick.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTick.Location = new System.Drawing.Point(652, 57);
            this.richTick.Name = "richTick";
            this.richTick.Size = new System.Drawing.Size(225, 470);
            this.richTick.TabIndex = 19;
            this.richTick.Text = "";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(504, 27);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 20;
            this.btnPlay.Text = "コマ送り";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrice.Location = new System.Drawing.Point(68, 204);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 12);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "現在値";
            // 
            // lblVWAP
            // 
            this.lblVWAP.AutoSize = true;
            this.lblVWAP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVWAP.Location = new System.Drawing.Point(63, 147);
            this.lblVWAP.Name = "lblVWAP";
            this.lblVWAP.Size = new System.Drawing.Size(37, 12);
            this.lblVWAP.TabIndex = 17;
            this.lblVWAP.Text = "VWAP";
            // 
            // lblNO
            // 
            this.lblNO.AutoSize = true;
            this.lblNO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNO.Location = new System.Drawing.Point(64, 69);
            this.lblNO.Name = "lblNO";
            this.lblNO.Size = new System.Drawing.Size(47, 12);
            this.lblNO.TabIndex = 17;
            this.lblNO.Text = "Row No.";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(6, 96);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 12);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "時刻";
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(207, 57);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Name = "Bid";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Name = "Ask";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Price";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(439, 232);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(111, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(111, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(111, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(68, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "買い";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(111, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(68, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "売り";
            // 
            // chart2
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(530, 533);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series4.Legend = "Legend1";
            series4.Name = "Strong";
            series4.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series5.Legend = "Legend1";
            series5.Name = "Weak";
            series5.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Price";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "VWAP";
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Size = new System.Drawing.Size(289, 141);
            this.chart2.TabIndex = 29;
            this.chart2.Text = "chart2";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(111, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(111, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(68, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "Price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(68, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 12);
            this.label14.TabIndex = 17;
            this.label14.Text = "Remain";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(111, 379);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 4;
            this.label15.Text = "label15";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(68, 384);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 17;
            this.label16.Text = "buy";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(111, 402);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 4;
            this.label17.Text = "label17";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(68, 407);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 12);
            this.label18.TabIndex = 17;
            this.label18.Text = "sell";
            // 
            // chart3
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX2.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY2.MajorGrid.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Location = new System.Drawing.Point(207, 295);
            this.chart3.Name = "chart3";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series8.Name = "Remains";
            series8.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Name = "Price";
            this.chart3.Series.Add(series8);
            this.chart3.Series.Add(series9);
            this.chart3.Size = new System.Drawing.Size(439, 232);
            this.chart3.TabIndex = 30;
            this.chart3.Text = "chart3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生データ表示ToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // 生データ表示ToolStripMenuItem
            // 
            this.生データ表示ToolStripMenuItem.Name = "生データ表示ToolStripMenuItem";
            this.生データ表示ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.生データ表示ToolStripMenuItem.Text = "生データ表示";
            this.生データ表示ToolStripMenuItem.Click += new System.EventHandler(this.生データ表示ToolStripMenuItem_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(40, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(171, 23);
            this.label19.TabIndex = 11;
            this.label19.Text = "label19";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(68, 459);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 12);
            this.label20.TabIndex = 34;
            this.label20.Text = "r 値";
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(111, 454);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 33;
            this.label21.Text = "label21";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(111, 477);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 23);
            this.label22.TabIndex = 33;
            this.label22.Text = "0";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(68, 482);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 12);
            this.label23.TabIndex = 34;
            this.label23.Text = "r (MAX)";
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(111, 500);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 23);
            this.label24.TabIndex = 33;
            this.label24.Text = "1";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label25.Location = new System.Drawing.Point(68, 505);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 34;
            this.label25.Text = "r (MIN)";
            // 
            // label26
            // 
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label26.Location = new System.Drawing.Point(111, 523);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 23);
            this.label26.TabIndex = 33;
            this.label26.Text = "label26";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label27.Location = new System.Drawing.Point(68, 528);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(21, 12);
            this.label27.TabIndex = 34;
            this.label27.Text = "t値";
            // 
            // label28
            // 
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label28.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label28.Location = new System.Drawing.Point(111, 546);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 23);
            this.label28.TabIndex = 33;
            this.label28.Text = "label28";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label29.Location = new System.Drawing.Point(68, 551);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 12);
            this.label29.TabIndex = 34;
            this.label29.Text = "p値";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 572);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 191);
            this.textBox1.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(883, 775);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.richTick);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.lblVWAP);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNO);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.RichTextBox richTick;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblVWAP;
        private System.Windows.Forms.Label lblNO;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生データ表示ToolStripMenuItem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox1;
    }
}

