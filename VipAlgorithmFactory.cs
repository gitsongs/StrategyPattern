using StrategyPattern.VipAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class VipAlgorithmFactory
    {
        public static IVipAlgorithm GetVipAlgorithm(Customer cust, out Vip? vipLevel)
        {
            var custVip = VipConfig.Instance.VipCondition.Where(x => x.Value <= cust._totalAmount)
                .OrderByDescending(x => x.Value)
                .ToList();
            IVipAlgorithm vipAlgorithm = null;
            if (custVip.Count == 0)
            {
                vipLevel = null;
                vipAlgorithm = new VipNone();
            }
            else
            {
                vipLevel = custVip.First().Key;
                vipAlgorithm = VipConfig.Instance.VipAlgorithm[vipLevel.Value];
            }
            return vipAlgorithm;
        }
    }
}
