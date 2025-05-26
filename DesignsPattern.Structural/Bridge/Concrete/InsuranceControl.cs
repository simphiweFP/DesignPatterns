using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Structural.Bridge.Concrete
{
    public abstract class InsuranceControl
    {
        protected object policy; // Use object type for generalization

        public InsuranceControl(object policy)
        {
            this.policy = policy;
        }

        public void Buy()
        {
            // Use reflection to call BuyStandardPolicy()
            policy.GetType().GetMethod("BuyStandardPolicy")?.Invoke(policy, null);
        }

        public void BuyBasic()
        {
            // Use reflection to call BuyBasicPolicy()
            policy.GetType().GetMethod("BuyBasicPolicy")?.Invoke(policy, null);
        }

        public void BuyFull()
        {
            // Use reflection to call BuyFullPolicy()
            policy.GetType().GetMethod("BuyFullPolicy")?.Invoke(policy, null);
        }
    }

}
