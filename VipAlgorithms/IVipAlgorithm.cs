using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.VipAlgorithms
{
    /// <summary>
    /// Vip算法规则
    /// </summary>
    public interface IVipAlgorithm
    {
        int CalcPrice(int originalPrice);
    }
}
