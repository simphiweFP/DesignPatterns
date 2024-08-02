using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Structural.Adapter.Model
{
    public class ExternalApiRepsonse
    {
        public string GetPersonDetailsXml(double id)
        {
            return $"<person><id>{id}</id><name>Sim Dlamuka</name><age>30</age></person>";
        }
    }
}
