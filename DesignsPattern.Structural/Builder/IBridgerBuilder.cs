using DesignsPattern.Structural.Bridge;
using DesignsPattern.Utils.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Structural.Builder
{
    public interface IBridgerBuilder
    {
        IBridgerBuilder WithOutput(IOutput output);
        IBridgerBuilder WithPolicyOption(string policyOption);
        IBridgerBuilder WithActionOption(string actionOption);
        Bridger Build();
    }

}
