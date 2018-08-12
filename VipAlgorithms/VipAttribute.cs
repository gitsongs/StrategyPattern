using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.VipAlgorithms
{
    public class VipAttribute : Attribute
    {
        public Vip Vip { get; set; }
        public VipAttribute(Vip vip)
        {
            Vip = vip;
        }
    }
}