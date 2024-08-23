using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Structural.Bridge.Concrete
{
    public abstract class InsuranceControl
    {
        protected IPolicy policy;

        public InsuranceControl(IPolicy policy)
        {
            this.policy = policy;
        }

        public void Buy()
        {
            policy.BuyStandardPolicy();
        }

        public void BuyBasic()
        {
            policy.BuyBasicPolicy();
        }

        public void BuyFull()
        {
            policy.BuyFullPolicy();
        }
    }
}
