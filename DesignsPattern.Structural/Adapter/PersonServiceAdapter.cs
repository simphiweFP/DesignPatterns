using DesignsPattern.Structural.Adapter.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignsPattern.Structural.Adapter
{
   public class PersonServiceAdapter : IPersonService
    {
        private readonly ExternalApiRepsonse _externalApiResponse;

        public PersonServiceAdapter(ExternalApiRepsonse externalXmlApiService)
        {
            _externalApiResponse = externalXmlApiService;
        }

        public string GetPersonDetails(double id)
        {
            // Request the person details from the external API
            string xmlResponse = _externalApiResponse.GetPersonDetailsXml(id);

            // Convert the XML response to JSON
            XDocument xmlDocument = XDocument.Parse(xmlResponse);
            string jsonResponse = JsonConvert.SerializeXNode(xmlDocument);

            return jsonResponse;
        }
    }
}
