using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.VipAlgorithms
{
    /// <summary>
    /// 非会员顾客
    /// </summary>
    public class VipNone : IVipAlgorithm
    {
        public int CalcPrice(int originalPrice)
        {
            return originalPrice;
        }
    }
}
