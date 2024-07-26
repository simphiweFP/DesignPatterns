using DesignsPattern.Creatinal.AbstractFactory.Factories;
using DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Car;
using DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Funeral;
using DesignsPattern.Creatinal.AbstractFactory.PolicyTypes.Health;
using DesignsPattern.Utils.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.AbstractFactory
{
    public class AbstractFactory
    {
        private readonly IOutput _output;

        public AbstractFactory(IOutput output)
        {
            _output = output;
        }

        public void Run(string option)
        {
            //Advantages
            // Flexibility in adding new product types
            // Simplifies code maintenance
            // Promotes loose coupling

            //Disadvantages
            // Can introduce complexity with many subclasses
            // Overhead in creating multiple classes

            switch (option)
            {
                case "Individual":
                    IInsurancePolicyFactory individualFactory = new IndividualInsurancePolicyFactory();

                    IHealthInsurancePolicy individualHealthPolicy = individualFactory.CreateHealthInsurancePolicy();
                    _output.Display(individualHealthPolicy.GetDetails());

                    ICarInsurancePolicy individualCarPolicy = individualFactory.CreateCarInsurancePolicy();
                    _output.Display(individualCarPolicy.GetDetails());

                    IFuneralInsurancePolicy individualHomePolicy = individualFactory.CreateFuneralInsurancePolicy();
                    _output.Display(individualHomePolicy.GetDetails());

                    break;
                case "Corporate":
                    IInsurancePolicyFactory corporateFactory = new CorporateInsurancePolicyFactory();

                    IHealthInsurancePolicy corporateHealthPolicy = corporateFactory.CreateHealthInsurancePolicy();
                    _output.Display(corporateHealthPolicy.GetDetails());

                    ICarInsurancePolicy corporateCarPolicy = corporateFactory.CreateCarInsurancePolicy();
                    _output.Display(corporateCarPolicy.GetDetails());

                    IFuneralInsurancePolicy corporateHomePolicy = corporateFactory.CreateFuneralInsurancePolicy();
                    _output.Display(corporateHomePolicy.GetDetails());
                    break;
                default:
                    _output.Display("Invalid option.");
                    break;
            }


        }
    }
}
