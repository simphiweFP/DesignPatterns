
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Structural.Bridge
{
    public class FuneralPolicy : IPolicy
    {
        public void BuyStandardPolicy()
        {
            Console.WriteLine("Buy Standard Funeral Policy.");
        }

        public void BuyBasicPolicy()
        {
            Console.WriteLine("Buy Basic Funeral Policy.");
        }

        public void BuyFullPolicy()
        {
            Console.WriteLine("Buy Full Funeral Policy.");
        }
    }
}
