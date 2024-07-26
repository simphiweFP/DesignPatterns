using DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Health;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Funeral
{
    public class IndividualFuneralInsurancePolicy : IFuneralInsurancePolicy
    {
        public string GetDetails()
        {
            return "Individual Health Insurance Policy Details";
        }
    }
}
