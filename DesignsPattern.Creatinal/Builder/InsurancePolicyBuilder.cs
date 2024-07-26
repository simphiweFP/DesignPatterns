using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.Builder
{
    public class InsurancePolicyBuilder : IInsurancePolicyBuilder
    {
        private readonly InsurancePolicy _policy = new();

        public IInsurancePolicyBuilder WithPolicyType(string policyType)
        {
            _policy.PolicyType = policyType;
            return this;
        }

        public IInsurancePolicyBuilder WithPremium(double premium)
        {
            _policy.Premium = premium;
            return this;
        }

        public IInsurancePolicyBuilder WithCoverAmount(double coverAmount)
        {
            _policy.CoverAmount = coverAmount;
            return this;
        }

        public InsurancePolicy Build()
        {
            return _policy;
        }
    }
}
