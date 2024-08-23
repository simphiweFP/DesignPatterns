using DesignsPattern.Structural.Adapter.Model;
using DesignsPattern.Structural.Adapter;
using DesignsPattern.Utils.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignsPattern.Structural.Bridge.Concrete;

namespace DesignsPattern.Structural.Bridge
{
    public class Bridger
    {
        private readonly IOutput _output;

        public Bridger(IOutput output)
        {
            _output = output;
        }

        public void Run(string option)
        {
       
               // Step 1: Select the Policy
          _output.Display("Select a policy type:");
            _output.Display("1. Funeral Policy");
            _output.Display("2. Life Policy");
            Console.Write("Enter your choice (1 or 2): ");
               option  = Console.ReadLine();

            IPolicy policy = null;
            InsuranceControl control = null;

            switch (option)
            {
                case "1":
                    policy = new FuneralPolicy();
                    control = new FuneralPolicyControl(policy);
                    _output.Display("Funeral Policy selected.");
                    break;

                case "2":
                    policy = new LifePolicy();
                    control = new LifePolicyControl(policy);
                    _output.Display("Life Policy selected.");
                    break;

                default:
                    _output.Display("Invalid option.");
                    return;
            }
            // Step 2: Select the Action
            _output.Display("Select an action:");
            _output.Display("1. Standard Policy");
            _output.Display("2. Basic Policy");
            _output.Display("3. Full Policy");
            Console.Write("Enter your choice (1, 2, or 3): ");
            string actionChoice = Console.ReadLine();

            switch (actionChoice)
            {
                case "1":
                    control.Buy();
                    break;

                case "2":
                    control.BuyBasic();
                    break;

                case "3":
                    control.BuyFull();
                    break;

                default:
                    _output.Display("Invalid action.");
                    break;
            }
        }
    }
}
