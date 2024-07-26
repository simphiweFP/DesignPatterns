using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.FactoryMethod.PolivyTypes
{
    public class FuneralPolicy : IPolicy
    {
        public string GetPolicyType() => "Funeral Insurance";
    }
}
