using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;

using System.Windows.Forms.DataVisualization.Charting;


namespace RSSCacheMonitor
{
    public partial class Form1 : Form
    {
        class Record
        {
            public long No = 1;
            public string Time = "";
            public ulong Tick = 0;
            public string Kind = "";
            public double Vwap = 0;
            public double Price = 0;
            public double Ask = 0;
            public double Bid = 0;
        }

        //class DouituYakujou
        //{
        //    public long weak = 0;
        //    public long strong = 0;
        //    public long remains = 0;
        //}

        // SQLite Database
        private string _path = "";
        private SQLiteConnection connection;

        private long currentNo = 1;
        private Record recpre = new Record();

        // Chart
        private List<double> history_price = new List<double>();

        // 100ティックあたりの売買代金
        private List<double> buy_100t = new List<double>();
        private List<double> sell_100t = new List<double>();
        //private List<ulong> remain = new List<ulong>();

        private double strong = 0;
        private double weak = 0;
        private long max_strong = 0;
        private long min_Weak = 0;

        const int MAX_COUNT_PRICE = 1000;
        const int MAX_COUNT_TICK = 300;
        const int MAX_POINTS = 120;

        // オーダーチェック
        private Order _order = new Order();
        private double _remain = 0; 


        /// <summary>
        /// TODO: InitializeChart 関数を作る
        /// </summary>
        
        // 同一約定気配分析

        private void MonitoringDatabase()
        {
            connection = new SQLiteConnection($"Version=3;Data Source={_path};Read Only=True;");
            connection.Open();

            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = $"select * from tick where No > {currentNo} limit 10";
                cmd.Prepare();
                using (SQLiteDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        var rec = new Record();
                        rec.No = (long)r["No"];
                        rec.Time = (string)r["Time"];
                        rec.Tick = ulong.Parse($"{r["Tick"]}");
                        rec.Kind = (string)r["Kind"];
                        rec.Vwap = (double)r["Vwap"];
                        rec.Price = (double)r["Price"];
                        rec.Ask = (double)r["Ask"];
                        rec.Bid = (double)r["Bid"];

                        currentNo = rec.No;
                        label13.Text = $"{rec.No}";
                        label9.Text = $"{rec.Time}";
                        label1.Text = $"{rec.Bid}";
                        label2.Text = $"{rec.Price}";
                        label3.Text = $"{rec.Ask}";

                        // 現在値が売り板(ask)に近ければ強い、買い板（bid)に近ければ弱いとする
                        bool kind = false;
                        if (recpre.Bid - rec.Price < rec.Price - recpre.Ask)
                        {
                            // 強い
                            kind = true;
                            strong += rec.Tick;
                        }
                        else
                        {
                            // 弱い
                            kind = false;
                            weak += rec.Tick;
                        }

                        // Tick 表示
                        ShowTick(rec.Time,rec.Tick, rec.Price, kind);

                        // 同一気配約定分析
                        // 
                        if (recpre.Ask != rec.Ask || recpre.Bid != rec.Bid )
                        {
                            if (kind)
                            {
                                HistoryBuyTick(strong);
                                ShowChart(rec.Price, 0, strong);
                                _remain += strong;
                            }
                            else
                            {
                                HistorySellTick(weak);
                                ShowChart(rec.Price, weak, 0);
                                _remain -= weak;
                            }
                            strong = 0;
                            weak = 0;
                            ShowChart2(rec.Price, rec.Vwap);
                        }
                        ShowChart3(rec.Price);
                        recpre = rec;
                    }
                }
            }
            label19.Text = $"{FromUnixTime(recpre.No).ToString("yyyy-MM-dd HH:mm:ss.ffff")}"; 
            connection.Close();
        }

        private void MonitoringDatabase2()
        {
            connection = new SQLiteConnection($"Version=3;Data Source={_path};Read Only=True;");
            connection.Open();

            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = $"select * from tick";
                cmd.Prepare();
                using (SQLiteDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        var rec = new Record();
                        rec.No = (long)r["No"];
                        rec.Time = (string)r["Time"];
                        rec.Tick = ulong.Parse($"{r["Tick"]}");
                        rec.Kind = (string)r["Kind"];
                        rec.Vwap = (double)r["Vwap"];
                        rec.Price = (double)r["Price"];
                        rec.Ask = (double)r["Ask"];
                        rec.Bid = (double)r["Bid"];

                        currentNo = rec.No;
                        label13.Text = $"{rec.No}";
                        label9.Text = $"{rec.Time}";
                        label1.Text = $"{rec.Bid}";
                        label2.Text = $"{rec.Price}";
                        label3.Text = $"{rec.Ask}";

                        // 現在値が売り板(ask)に近ければ強い、買い板（bid)に近ければ弱いとする
                        bool kind = false;
                        if (recpre.Bid - rec.Price < rec.Price - recpre.Ask)
                        {
                            // 強い
                            kind = true;
                            strong += rec.Tick;
                        }
                        else
                        {
                            // 弱い
                            kind = false;
                            weak += rec.Tick;
                        }

                        // Tick 表示
                        ShowTick(rec.Time, rec.Tick, rec.Price, kind);

                        // 同一気配約定分析
                        // 
                        if (recpre.Ask != rec.Ask || recpre.Bid != rec.Bid)
                        {
                            if (kind)
                            {
                                HistoryBuyTick(strong);
                                //label4.Text = $"{HistoryBuyTick(rec.Tick)}";
                                ShowChart(rec.Price, 0, strong);
                                _remain += strong;
                            }
                            else
                            {
                                HistorySellTick(weak);
                                //label6.Text = $"{HistorySellTick(rec.Tick)}";
                                ShowChart(rec.Price, weak, 0);
                                _remain -= weak;
                            }
                            strong = 0;
                            weak = 0;
                            ShowChart2(rec.Price, rec.Vwap);
                        }
                        ShowChart3(rec.Price);
                        recpre = rec;
                    }
                }
            }
            label19.Text = $"{FromUnixTime(recpre.No).ToString("yyyy-MM-dd HH:mm:ss.ffff")}";
            connection.Close();
        }



        public static DateTime FromUnixTime(long unixTime)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(unixTime).LocalDateTime;
        }

        /// チャート初期化
        private void initChart()
        {

            // 凡例を非表示,各値に数値を表示しない
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Trebuchet MS", 6, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Trebuchet MS", 6, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY2.LabelStyle.Font = new Font("Trebuchet MS", 6, FontStyle.Bold);

            chart2.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Trebuchet MS", 6, FontStyle.Bold);
            chart2.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Trebuchet MS", 6, FontStyle.Bold);
            chart2.ChartAreas[0].AxisY2.LabelStyle.Font = new Font("Trebuchet MS", 6, FontStyle.Bold);
            chart3.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Trebuchet MS", 6, FontStyle.Bold);

            chart3.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Trebuchet MS", 6, FontStyle.Bold);
            chart3.ChartAreas[0].AxisY2.LabelStyle.Font = new Font("Trebuchet MS", 6, FontStyle.Bold);

            chart1.Series["Price"].Color = Color.Black;
            chart1.Series["Bid"].Color = Color.Blue;
            chart1.Series["Ask"].Color = Color.Red;
            chart1.Series["Bid"].SetCustomProperty("PointWidth", "0.5");
            chart1.Series["Ask"].SetCustomProperty("PointWidth", "0.5");


            chart2.Series["Price"].Color = Color.Black;
            chart2.Series["Strong"].Color = Color.Green;
            chart2.Series["Weak"].Color = Color.Red;
            chart2.Series["VWAP"].Color = Color.Blue;
        }


        /// <summary>
        /// 現在値、最良買気配値と最良売気配値
        /// チャート表示
        /// </summary>
        private void ShowChart(double price, double bid, double ask)
        {
            HistoryPrice(price);


            chart1.ChartAreas[0].AxisY.Maximum = history_price.Max();
            chart1.ChartAreas[0].AxisY.Minimum = history_price.Min();
            chart1.ChartAreas[0].AxisY2.Maximum = buy_100t.Max();

            if (chart1.Series["Price"].Points.Count > MAX_POINTS)
            {
                for (int i = 1; i <= MAX_POINTS; i++)
                {
                    chart1.Series["Price"].Points[i - 1].YValues = chart1.Series["Price"].Points[i].YValues;
                    chart1.Series["Bid"].Points[i - 1].YValues = chart1.Series["Bid"].Points[i].YValues;
                    chart1.Series["Ask"].Points[i - 1].YValues = chart1.Series["Ask"].Points[i].YValues;
                }
                chart1.Series["Price"].Points.RemoveAt(MAX_POINTS);
                chart1.Series["Bid"].Points.RemoveAt(MAX_POINTS);
                chart1.Series["Ask"].Points.RemoveAt(MAX_POINTS);
            }
            chart1.Series["Price"].Points.AddXY(0, price);
            chart1.Series["Bid"].Points.AddXY(0, bid);
            chart1.Series["Ask"].Points.AddXY(0, ask);
        }

        /// <summary>
        /// 現在値と強約定・弱約定の差分（灰色）
        /// チャート表示
        /// </summary>
        private void ShowChart3(double price)
        {
            HistoryPrice(price);

            chart3.ChartAreas[0].AxisY.Maximum = history_price.Max();
            chart3.ChartAreas[0].AxisY.Minimum = history_price.Min();


            if (chart3.Series["Price"].Points.Count > MAX_POINTS)
            {
                for (int i = 1; i <= MAX_POINTS; i++)
                {
                    chart3.Series["Price"].Points[i - 1].YValues = chart3.Series["Price"].Points[i].YValues;
                    chart3.Series["Remains"].Points[i - 1].YValues = chart3.Series["Remains"].Points[i].YValues;
                }
                chart3.Series["Price"].Points.RemoveAt(MAX_POINTS);
                chart3.Series["Remains"].Points.RemoveAt(MAX_POINTS);
            }
            chart3.Series["Price"].Points.AddXY(0, price);
            chart3.Series["Remains"].Points.AddXY(0, _remain);

            // 相関係数の算出
            double r = chart3.DataManipulator.Statistics.Correlation("Price", "Remains");

            label21.Text = $"{r:F4}";
            if (double.Parse(label22.Text) < r && r != 1) label22.Text = $"{r:F4}";
            if (double.Parse(label24.Text) > r && r != 0) label24.Text = $"{r:F4}";

            //// 相関係数からt-valueへの変換この辺りはこちらで書く必要あり
            //double t = r * Math.Sqrt((buy_100t.Count - 2) / (1 - r * r));
            //// t-valueからp-valueへの変換 最後の引数はfalseで両側検定になる
            //double p = chart3.DataManipulator.Statistics.TDistribution(t, buy_100t.Count - 2, false);
            //label26.Text = $"{t}";
            //label28.Text = $"{p}";

            //
            // order check
            //

            //double sum = 0;
            //for(int i = 1; i <= 30; i++)
            //{
            //    sum += chart3.Series["Remains"].Points[i].YValues[0];
            //}
            //double avg = sum / 30;
            //label26.Text = $"{avg:F4}";

            if (chart3.Series["Remains"].Points.Count() > 10)
            {

                var p = chart3.Series["Price"];
                var p2 = chart3.Series["Remains"];
                double p_sum = 0;
                double p2_sum = 0;
                for (int i = 0; i <= 5; i++)
                {
                    p_sum += Math.Log(p.Points[i].YValues[0] / p.Points[i + 4].YValues[0]);
                    p2_sum += Math.Log(p2.Points[i].YValues[0] / p2.Points[i + 4].YValues[0]);
                }
                label26.Text = $"{p_sum:F4}";
                label28.Text = $"{p2_sum:F4}";

                var s = _order.Check("", label9.Text, price, r);
                if (s != "")
                {
                    textBox1.AppendText(s + Environment.NewLine);
                }
            }
        }

        /// <summary>
        /// 現在値、強約定、弱約定と VWAP
        /// チャート表示
        /// </summary>
        /// <param name="price"></param>
        /// <param name="bid"></param>
        /// <param name="ask"></param>
        private void ShowChart2(double price, double vwap)
        {
            HistoryPrice(price);
            var b = buy_100t.Sum();
            var s = sell_100t.Sum();
            //var remain = b - s;

            max_strong = (b > max_strong) ? (long)b : max_strong;
            min_Weak = (s < min_Weak) ? (long)s : min_Weak;

            chart2.ChartAreas[0].AxisY.Maximum = history_price.Max();
            chart2.ChartAreas[0].AxisY.Minimum = history_price.Min();

            chart2.ChartAreas[0].AxisY2.Maximum = max_strong;
            chart2.ChartAreas[0].AxisY2.Minimum = min_Weak;

            if (chart2.Series["Price"].Points.Count > MAX_POINTS)
            {
                for (int i = 1; i <= MAX_POINTS; i++)
                {
                    chart2.Series["Price"].Points[i - 1].YValues = chart2.Series["Price"].Points[i].YValues;
                    chart2.Series["Strong"].Points[i - 1].YValues = chart2.Series["Strong"].Points[i].YValues;
                    chart2.Series["Weak"].Points[i - 1].YValues = chart2.Series["Weak"].Points[i].YValues;
                    chart2.Series["VWAP"].Points[i - 1].YValues = chart2.Series["VWAP"].Points[i].YValues;
                }
                chart2.Series["Price"].Points.RemoveAt(MAX_POINTS);
                chart2.Series["Strong"].Points.RemoveAt(MAX_POINTS);
                chart2.Series["Weak"].Points.RemoveAt(MAX_POINTS);
                chart2.Series["VWAP"].Points.RemoveAt(MAX_POINTS);
            }
            chart2.Series["Price"].Points.AddXY(0, price);
            chart2.Series["Strong"].Points.AddXY(0, b);
            chart2.Series["Weak"].Points.AddXY(0, s);
            chart2.Series["VWAP"].Points.AddXY(0, vwap);

            label10.Text = $"{_remain}";
            label15.Text = $"{b}";
            label17.Text = $"{s}";

        }


        private void HistoryPrice(double price)
        {
            if (history_price.Count > MAX_COUNT_PRICE)
            {
                history_price.RemoveAt(0);
            }
            history_price.Add(price);
        }

        private double HistoryBuyTick(double tick)
        {
            if (buy_100t.Count > MAX_COUNT_TICK)
            {
                buy_100t.RemoveAt(0);
            }
            buy_100t.Add(tick);
            return (double)buy_100t.Sum();
        }

        private double HistorySellTick(double tick)
        {
            if (sell_100t.Count > MAX_COUNT_TICK)
            {
                sell_100t.RemoveAt(0);
            }
            sell_100t.Add(tick);
            return (double)sell_100t.Sum();
        }

        private void InitializeChart()
        {
            // 画面初期化
            richTick.Clear();
            initChart();

            currentNo = 1;
            recpre = new Record();
            strong = 0;
            weak = 0;

            // Chart
            history_price = new List<double>();

            // 100ティックあたりの売買代金
            buy_100t = new List<double>();
            sell_100t = new List<double>();

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();

        }

        /// <summary>
        /// 歩み値の表示
        /// </summary>
        /// <param name="time"></param>
        /// <param name="tick"></param>
        /// <param name="price"></param>
        /// <param name="kind"></param>
        private void ShowTick(string time, ulong tick, double price, bool kind)
        {
            richTick.SelectionStart = 0;
            richTick.SelectionLength = 0;
            richTick.SelectionColor = kind == true ? Color.Red : Color.Green;
            richTick.SelectedText = $"{time.Substring(11)} {tick,9} {price,6}{Environment.NewLine}";
        }

        /*********************************************************************************/

        public Form1()
        {
            // 初期化
            InitializeComponent();
            InitializeChart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtPath.Text = @"C:\RSS_DATA\20190704_RSS_4565.db";
            txtPath.Text = @"C:\RSS_DATA\20190718_RSS_4565.db";
            _path = txtPath.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MonitoringDatabase();
        }

        // データベースファイルを開くダイアログ
        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "SQLite.db を開く";
            d.InitialDirectory = @"C:\RSS_DATA\";
            d.Filter = "データベースファイル(*.db)|*.db";

            DialogResult dr = d.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = d.FileName;
            }
            _path = txtPath.Text;
        }

        // コマ送りボタン
        private void btnPlay_Click(object sender, EventArgs e)
        {
            MonitoringDatabase();
        }

        // 監視開始ボタン
        private void btnView_Click(object sender, EventArgs e)
        {
            InitializeChart();
            _path = txtPath.Text;
            timer1.Enabled = (timer1.Enabled == true ) ? false : true;
            btnView.Text = (timer1.Enabled == true) ? "停止" : "開始";
        }

        private void 生データ表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRawdata f = new FormRawdata();
            f.Show();
        }

        // バックテストボタン
        private void button1_Click(object sender, EventArgs e)
        {
            InitializeChart();
            MonitoringDatabase2();
        }
    }
}
