using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.VipAlgorithms
{
    [Vip(Vip.黄金会员)]
    public class VipGold : IVipAlgorithm
    {
        public int CalcPrice(int orginalPrice)
        {
            var currentPrice = (int)(orginalPrice * 0.8 + 0.5);
            return currentPrice;
        }
    }
}