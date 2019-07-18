using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace RSSCacheMonitor
{
    class Database
    {
        // SQLite Database
        private string path = "";
        private SQLiteConnection connection;

        private long currentNo = 1;


        // 楽天RSS用アイテム
        private Dictionary<string, string> item
        = new Dictionary<string, string>()
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

        // 計測用タイマー  
        DateTime curTime;
        DateTime prevTime = new DateTime(0);


        /// <summary>
        /// 日毎のデータベースを作成する
        /// </summary>
        /// <param name="code"></param>
        private void CreateDatabase(string code)
        {
            path = $"RSS_{code}_{DateTime.Now.ToString("yyyyMMdd")}.db"; ;
            connection = new SQLiteConnection("Data Source=" + path);

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + path))
            {
                connection.Open();

                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS tick(" +
                        "No INTEGER NOT NULL PRIMARY KEY," +
                        "Time TEXT NOT NULL," +
                        "Tick INTEGER NOT NULL," +
                        "Kind TEXT NOT NULL," + // Yellow, Red, Green
                        "Price REAL NOT NULL);";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// レコードの挿入
        /// </summary>
        /// <param name="r"></param>
        private void InsertValue(string time, string tick, string kind, string price)
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = $"insert into tick (Time,Tick,Kind,Price) values (" +
                    $"'{time}','{tick}','{kind}','{price}')";
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 
        /// </summary>
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

                        curTime = DateTime.Parse($"{reader["Time"]}");
                        if (prevTime == new DateTime(0)) { prevTime = curTime; };
                        TimeSpan ts = curTime - prevTime;
                        prevTime = curTime;

                        currentNo = (long)reader["No"];

                        item[k] = v;


                            switch (k)
                            {
                                case "最良売気配値１":
                                    break;
                                case "最良買気配値１":
                                    break;
                                case "現在値":
                                    break;

                                case "出来高":
                                    break;

                                case "出来高加重平均":


                                    break;
                            }

                        }
                    }
                }
            connection.Close();
        }
    }
}
