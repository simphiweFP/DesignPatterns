using DesignsPattern.Creatinal.FactoryMethod.PolivyTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.FactoryMethod.PolicyCreators
{
    public class FuneralPolicyCreator : IPolicyCreator
    {
        public IPolicy CreatePolicy() => new FuneralPolicy();
    }
}
