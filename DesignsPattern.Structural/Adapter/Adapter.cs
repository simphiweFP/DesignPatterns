using DesignsPattern.Structural.Adapter.Model;
using DesignsPattern.Utils.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Structural.Adapter
{
    public class Adapter
    {
        private readonly IOutput _output;

        public Adapter(IOutput output)
        {
            _output = output;
        }

        public void Run(string option)
        {
            switch (option)
            {
                case "Search Person Details":
                    ExternalApiRepsonse externalApiService = new ExternalApiRepsonse();
                    IPersonService personService = new PersonServiceAdapter(externalApiService);

                    Console.WriteLine("Enter the ID:");
                    double id = Convert.ToDouble(Console.ReadLine());

                    string personDetailsJson = personService.GetPersonDetails(id);

                    _output.Display("Person Details in JSON format:");
                    _output.Display(personDetailsJson);
                    break;
                default:
                    _output.Display("Invalid option.");
                    break;
            }

        }
    }
}
