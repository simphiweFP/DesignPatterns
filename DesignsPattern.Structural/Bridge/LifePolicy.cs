using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Structural.Bridge
{
    public class LifePolicy 
    {
        public void BuyStandardPolicy()
        {
            Console.WriteLine("Buy Standard Life Policy.");
        }

        public void BuyBasicPolicy()
        {
            Console.WriteLine("Buy Basic Life Policy.");
        }

        public void BuyFullPolicy()
        {
            Console.WriteLine("Buy Full Life Policy.");
        }
    }
}
