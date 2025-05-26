using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignsPattern.Structural.Bridge.Concrete;

namespace DesignsPattern.Structural.Bridge
{
    public class FuneralPolicyControl : InsuranceControl
    {
        public FuneralPolicyControl(FuneralPolicy policy) : base(policy) { }

        public void BuyFuneralPolicy()
        {
            Buy();
        }
    }

}
