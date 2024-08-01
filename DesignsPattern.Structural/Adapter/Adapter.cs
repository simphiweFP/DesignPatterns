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
                    // Create an instance of the external XML API service
                    ExternalApiRepsonse externalApiService = new ExternalApiRepsonse();

                    // Create an instance of the adapter
                    IPersonService personService = new PersonServiceAdapter(externalApiService);

                    // Get the ID from the user
                    Console.WriteLine("Enter the ID:");
                    double id = Convert.ToDouble(Console.ReadLine());

                    // Get the person details
                    string personDetailsJson = personService.GetPersonDetails(id);

                    // Display the person details in JSON format
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
