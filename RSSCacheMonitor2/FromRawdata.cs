using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace RSSCacheMonitor
{
    public partial class FormRawdata : Form
    {
        // SQLite Database
        private long currentNo = 1;
        private string path = "";
        private SQLiteConnection connection;

        // RSS から受信するアイテム名と値を格納するディクショナリ
        private Dictionary<string, string> item;


        // RSSからの受信データ時間の計測
        DateTime curTime;
        DateTime prevTime = new DateTime(0);


        public FormRawdata()
        {
            InitializeComponent();
        }

        private void FormRawdata_Load(object sender, EventArgs e)
        {
            path = @"C:\RSS_DATA\20190718_RSS_4565.db";
            item = new Dictionary<string, string>()
            {
                { "最良売気配数量２", ""},
                { "最良売気配数量１", ""},
                { "最良売気配値２", ""},
                { "最良売気配値１", ""},
                { "最良買気配値１", ""},
                { "最良買気配値２", ""},
                { "最良買気配数量１", ""},
                { "最良買気配数量２", ""},
                { "現在値", ""},
                { "出来高", ""},
                { "出来高加重平均", ""},
            };

            Initialize();
        }

        private void Initialize()
        {
            richRaw.Clear();
        }


        private void MonitoringDatabase()
        {
            connection = new SQLiteConnection($"Version=3;Data Source={path};Read Only=True;");
            connection.Open();

            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = $"select * from RSS where No > {currentNo} limit 10";
                cmd.Prepare();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string k = $"{reader["Item"]}";
                        string v = $"{reader["Value"]}";
                        Color itemColor = Color.White;

                        curTime = DateTime.Parse($"{reader["Time"]}");
                        if (prevTime == new DateTime(0)) { prevTime = curTime; };
                        TimeSpan ts = curTime - prevTime;
                        prevTime = curTime;

                        currentNo = (long)reader["No"];

                        item[k] = v;

                        switch (k)
                        {
                            case "最良売気配値１":
                                itemColor = Color.LightGreen;
                                break;
                            case "最良売気配数量１":
                                itemColor = Color.LightGreen;
                                break;
                            case "最良買気配値１":
                                itemColor = Color.LightPink;
                                break;
                            case "最良買気配数量１":
                                itemColor = Color.LightPink;
                                break;
                            case "現在値":
                                itemColor = Color.Yellow;
                                break;

                            case "出来高":
                                itemColor = Color.LightYellow;
                                break;

                            case "出来高加重平均":
                                itemColor = Color.Red;
                                break;

                        }
                        string s =
                                    $"{reader["No"]} " +
                                    $"{reader["Time"].ToString().Substring(11)} " +
                                    $"{ts.Milliseconds,4} " +
                                    $"{reader["Value"],10} " +
                                    $"{reader["Item"]} " +
                                    $"{Environment.NewLine}";
                        Display_Rawdata(s, itemColor);

                    }
                }
            }
            connection.Close();
        }

        private void Display_Rawdata(string s, Color kind)
        {
            richRaw.SelectionStart = richRaw.Text.Length;
            richRaw.SelectionLength = 0;
            richRaw.SelectionColor = kind;
            richRaw.SelectedText = s;
            richRaw.ScrollToCaret();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MonitoringDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = (timer1.Enabled == false) ? true : false;
            button1.Text = (timer1.Enabled == false) ? "開始" : "停止";
        }
    }

}