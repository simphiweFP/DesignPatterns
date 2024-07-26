using DesignsPattern.Creatinal.FactoryMethod.PolicyCreators;
using DesignsPattern.Utils.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.FactoryMethod
{
    public class FactoryMethod
    {
        private readonly IOutput _output;

        public FactoryMethod(IOutput output)
        {
            _output = output;
        }

        public void Run(string policyType)
        {
            //Advantages
            // Flexibility in adding new product types
            // Simplifies code maintenance
            // Promotes loose coupling

            //Disadvantages
            // Can introduce complexity with many subclasses
            // Overhead in creating multiple classes

            IPolicyCreator creator = null;
            switch (policyType)
            {
                case "Health":
                    creator = new HealthPolicyCreator();
                    break;
                case "Life":
                    creator = new FuneralPolicyCreator();
                    break;
                case "Vehicle":
                    creator = new CarPolicyCreator();
                    break;
                default:
                    _output.Display("Invalid policy type.");
                    break;
            }

            if (creator is not null)
            {
                IPolicy policy = creator.CreatePolicy();
                _output.Display($"Created policy type: {policy.GetPolicyType()}");
            }

        }
    }
}
