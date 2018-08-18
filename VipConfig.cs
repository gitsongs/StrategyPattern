using StrategyPattern.VipAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class VipConfig
    {
        public readonly Dictionary<Vip, int> VipCondition;
        public readonly Dictionary<Vip, IVipAlgorithm> VipAlgorithm;
        private static VipConfig _vipConfigInstance;
        private VipConfig()
        {
            //这里将配置硬编码到字典中，实际可以从配置文件中读取
            VipCondition = new Dictionary<Vip, int> { { Vip.普通会员, 1000 * 100 }, { Vip.黄金会员, 3000 * 100 }, { Vip.钻石会员, 5000 * 100 } };
            VipAlgorithm = Assembly.GetExecutingAssembly().GetExportedTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IVipAlgorithm)))
                .Select(t => new
                {
                    Type = t,
                    Vip = t.GetCustomAttribute<VipAttribute>()?.Vip
                })
                .Where(x => x.Vip != null)
                .ToDictionary(x => x.Vip.Value, x => (IVipAlgorithm)Activator.CreateInstance(x.Type));
        }
        public static VipConfig Instance
        {
            get
            {
                if (_vipConfigInstance == null)
                {
                    _vipConfigInstance = new VipConfig();
                }
                return _vipConfigInstance;
            }
        }
    }
    public enum Vip
    {
        普通会员 = 1,
        黄金会员 = 2,
        钻石会员 = 3
    }
}
