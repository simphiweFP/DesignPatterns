using DesignsPattern.Structural.Adapter.Model;
using DesignsPattern.Structural.Adapter;
using DesignsPattern.Utils.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            switch (option)
            {
                case "Funeral":
                    IPolicy funeralpolicy = new FuneralPolicy();
                    _output.Display("Funeral Policy");
                    funeralpolicy.BuyPolicy();
                    break;
                case "Life":
                    IPolicy lifepolicy = new LifePolicy ();
                    _output.Display("life Policy");
                    lifepolicy.BuyPolicy();
                    break;
                default:
                    _output.Display("Invalid option.");
                    break;
            }
        }
    }
}
