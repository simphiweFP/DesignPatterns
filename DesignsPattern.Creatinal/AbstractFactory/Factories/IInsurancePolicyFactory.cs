using DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Car;
using DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Funeral;
using DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Health;


namespace DesignsPattern.Creatinal.AbstractFactory.Factories
{
    public interface IInsurancePolicyFactory
    {
        IHealthInsurancePolicy CreateHealthInsurancePolicy();
        ICarInsurancePolicy CreateCarInsurancePolicy();
        IFuneralInsurancePolicy CreateFuneralInsurancePolicy();
    }
}
