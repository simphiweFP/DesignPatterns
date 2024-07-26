using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.Prototype
{
    public interface IInsurancePolicyPrototype
    {
        IInsurancePolicyPrototype Clone();
    }
}
