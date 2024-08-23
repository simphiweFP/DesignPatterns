using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Structural.Bridge
{
    public interface IPolicy
    {
        void BuyStandardPolicy();
        void BuyBasicPolicy();
        void BuyFullPolicy();
    }
}
