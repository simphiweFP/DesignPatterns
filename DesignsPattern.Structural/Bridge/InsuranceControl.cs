using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Structural.Bridge
{
    public abstract class InsuranceControl
    {
        protected IPolicy policy;

        public InsuranceControl(IPolicy policy)
        {
            this.policy = policy;
        }

    }
}
