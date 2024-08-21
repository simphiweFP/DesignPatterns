
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Structural.Bridge
{
    public class FuneralPolicy : IPolicy
    {
        public void BuyPolicy()
        {
            Console.WriteLine("Buy Funeral.");
        }
    }
}
