using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.FactoryMethod.PolicyCreators
{
    public interface IPolicyCreator
    {
        IPolicy CreatePolicy();

    }
}
