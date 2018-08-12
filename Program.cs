using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.Buy(1000);
            cust.Buy(1000);
            cust.Buy(1000);
            cust.Buy(1000);
            cust.Buy(1000);
            cust.Buy(1000);
            cust.Buy(1000);
            Console.ReadLine();
        }
    }
}
