using DesignsPattern.Structural.Bridge;
using DesignsPattern.Utils.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Structural.Builder
{
    public class BridgerBuilder : IBridgerBuilder
    {
        private IOutput _output;
        private string _policyOption;
        private string _actionOption;

        public IBridgerBuilder WithOutput(IOutput output)
        {
            _output = output;
            return this;
        }

        public IBridgerBuilder WithPolicyOption(string policyOption)
        {
            _policyOption = policyOption;
            return this;
        }

        public IBridgerBuilder WithActionOption(string actionOption)
        {
            _actionOption = actionOption;
            return this;
        }

        public Bridger Build()
        {
            if (_output == null)
            {
                throw new InvalidOperationException("Output cannot be null.");
            }

            var bridger = new Bridger(_output);

            // Assuming Run() is invoked directly during building for setting policy and action,
            // you could structure this to suit the intended design.
            bridger.Run(_policyOption);

            return bridger;
        }
    }

}
