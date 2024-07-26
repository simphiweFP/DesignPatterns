using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.Builder.Director
{
    public class InsurancePolicyDirector
    {
        public InsurancePolicy ConstructCarPolicy(IInsurancePolicyBuilder builder)
        {
            return builder
                .WithPolicyType("Comprehensive")
                .WithPremium(1500.00)
                .WithCoverAmount(500000.00)
                .Build();
        }

        public InsurancePolicy ConstructFuneralPolicy(IInsurancePolicyBuilder builder)
        {
            return builder
                .WithPolicyType("Family")
                .WithPremium(500.00)
                .WithCoverAmount(100000.00)
                .Build();
        }
        public InsurancePolicy ConstructHealthFPolicy(IInsurancePolicyBuilder builder)
        {
            return builder
                .WithPolicyType("All")
                .WithPremium(500.00)
                .WithCoverAmount(100000.00)
                .Build();
        }
    }
}
