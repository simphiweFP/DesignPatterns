using DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Health;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Funeral
{
    public class CorporateFuneralInsurancePolicy : IFuneralInsurancePolicy
    {
        public string GetDetails()
        {
            return "Corporate Health Insurance Policy Details";
        }
    }
}

