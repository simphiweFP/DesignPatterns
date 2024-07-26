using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.FactoryMethod.PolivyTypes
{
    public class HealthPolicy : IPolicy
    {
        public string GetPolicyType() => "Health Insurance";
    }
}
