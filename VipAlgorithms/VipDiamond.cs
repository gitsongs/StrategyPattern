using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.VipAlgorithms
{
    [Vip(Vip.钻石会员)]
    public class VipDiamond: IVipAlgorithm
    {
        public int CalcPrice(int orginalPrice)
        {
            var currentPrice = (int)(orginalPrice * 0.7 + 0.5);
            return currentPrice;
        }
    }
}
