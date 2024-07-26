using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Car
{
    public class CorporateCarInsurancePolicy : ICarInsurancePolicy
    {
        public string GetDetails()
        {
            return "Corporate Car Insurance Policy Details";
        }
    }
}
