using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.Builder
{
    public interface IInsurancePolicyBuilder
    {
        IInsurancePolicyBuilder WithPolicyType(string policyType);
        IInsurancePolicyBuilder WithPremium(double premium);
        IInsurancePolicyBuilder WithCoverAmount(double coverAmount);
        InsurancePolicy Build();
    }
}
