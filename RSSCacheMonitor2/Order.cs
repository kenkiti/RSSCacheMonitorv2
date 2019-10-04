using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSCacheMonitor
{
    class Order
    {
        private bool _isPosition = false;
        private double _pos_price = 0;
        private bool _isProfit = false;
        private double _profit_sum = 0;

        public string Check(string code, string time, double price, double r)
        {
            Console.WriteLine($"{time},{price},{r}");

            // 価格と売買残高を比較して、高値掴みを避ける
            //float ratio_price = _cli.RatioPrice;
            //float ratio_remain = _cli.RatioRemains;
            var result = "";

            // ポジションなし
            if (_isPosition == false)
            {
                if (r < 0.25)
                {
                    //// 売買残高より、価格の方が下がっていた場合
                    //if ( ratio_price < ratio_remain)
                    //{
                    //ポジションなしの時、相関係数0.25以下で買い
                    //_client.Write($"buy,{_monitorCode},{_cli.Time},{_cli.Price},{r}");
                    result = $"buy,{code},{time},{price},{r:F4}";
                    _isPosition = true;
                    _pos_price = price;
                    //}
                }
            }
            else
            // ポジションあり
            {
                double profit = price - _pos_price;

                // ポジションあり、相関係数0.95を超えて利益なしの場合、決済する
                if (r > 0.94)
                {
                    if (profit < 0)
                    {
                        // 利益がなく、相関係数 0.95 を超えていたら損切する
                        _isPosition = false;
                        _profit_sum += profit;
                        result = $"sell,{code},{time},{price},{r:F4},{profit},{_profit_sum}";
                    }
                    else
                    {
                        _isProfit = true;
                    }
                }


                if (r <= 0.94 && _isProfit == true)
                {
                    // 利益があり、相関係数 0.95 以上の推移が終わったら、利確する。
                    _isPosition = false;
                    _isProfit = false;
                    _profit_sum += profit;
                    result = $"sell,{code},{time},{price},{r:F4},{profit},{_profit_sum}";
                }
            }
            //label2.Text = $"profit={_profit_sum} p={ratio_price},r={ratio_remain}";
            return result;
        }
    }
}
