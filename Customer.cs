using StrategyPattern.VipAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Customer
    {
        public int _totalAmount = 0;
        public Vip? _vip = null;
        public IVipAlgorithm _vipAlgorithm;
        public void Buy(decimal originPriceM)
        {
            _vipAlgorithm = VipAlgorithmFactory.GetVipAlgorithm(this, out this._vip);
            var originPrice = (int)originPriceM * 100;
            var finalPrice = _vipAlgorithm.CalcPrice(originPrice);
            //
            Console.WriteLine($"您在本店历史消费总额：{_totalAmount * 0.01}元");
            var vipMsg = _vip.HasValue ? $"您是本店会员：{_vip.Value.ToString()}" : "您未升级为本店会员";
            Console.WriteLine(vipMsg);
            Console.WriteLine($"本次购买商品原价{originPrice * 0.01}元，需支付{finalPrice * 0.01}元");
            _totalAmount += originPrice;
            Console.WriteLine();
        }
    }
}
