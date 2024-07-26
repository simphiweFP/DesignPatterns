using DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Car;
using DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Funeral;
using DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Health;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.AbstractFactory.Factories
{
    public class CorporateInsurancePolicyFactory : IInsurancePolicyFactory
    {
        public IHealthInsurancePolicy CreateHealthInsurancePolicy()
        {
            return new CorporateHealthInsurancePolicy();
        }

        public ICarInsurancePolicy CreateCarInsurancePolicy()
        {
            return new CorporateCarInsurancePolicy();
        }

        public IFuneralInsurancePolicy CreateFuneralInsurancePolicy()
        {
            return new CorporateFuneralInsurancePolicy();
        }
    }
}
