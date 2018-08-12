using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.VipAlgorithms
{
    [Vip(Vip.普通会员)]
    public class VipOrdinary : IVipAlgorithm
    {
        public int CalcPrice(int orginalPrice)
        {
            var currentPrice = (int)(orginalPrice * 0.9 + 0.5);
            return currentPrice;
        }
    }
}
