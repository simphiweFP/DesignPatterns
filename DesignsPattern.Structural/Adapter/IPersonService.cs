using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Structural.Adapter
{
    public interface IPersonService
    {
        string GetPersonDetails(double id);
    }
}
