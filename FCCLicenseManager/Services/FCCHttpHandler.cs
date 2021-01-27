using FCCLicenseManager.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace FCCLicenseManager.Services
{
    public class FCCHttpHandler : IFCCHttpHandler
    {
        private readonly HttpClient client;
        public string URL { get; }

        public FCCHttpHandler(HttpClient client)
        {
            this.client = client;
            URL = "https://data.fcc.gov/api/license-view/basicSearch/getLicenses?searchValue=0001526953&format=json&pageSize=800";
        }

        public Response GetData()
        {
            var response = client.GetAsync(URL).Result;
            return JsonConvert.DeserializeObject<Response>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
