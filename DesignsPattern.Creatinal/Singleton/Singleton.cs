using DesignsPattern.Utils.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.Singleton
{
    public class Singleton
    {
        private readonly IOutput _output;

        public Singleton(IOutput output)
        {
            _output = output;
        }

        public void Run()
        {
            InsurancePolicySingleton firstpolicy = InsurancePolicySingleton.Instance;
            firstpolicy.PolicyId = 1;
            firstpolicy.PolicyType = "Single";
            firstpolicy.Premium = 100.00;
            firstpolicy.CoverAmount = 10000.00;

            InsurancePolicySingleton secondpolicy = InsurancePolicySingleton.Instance;

            _output.Display("First policy :" + firstpolicy.ToString());
            _output.Display("Second policy :" + secondpolicy.ToString());

            _output.Display("Are the same :" + (object.ReferenceEquals(firstpolicy, secondpolicy)? "Yes":"No")); 

        }
    }
}
