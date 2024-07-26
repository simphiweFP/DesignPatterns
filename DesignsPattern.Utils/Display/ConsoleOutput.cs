using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Utils.Display
{
    public class ConsoleOutput : IOutput
    {
        public void Display(string value)
        {
            Console.WriteLine(value);
        }
    }
}
