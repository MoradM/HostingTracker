using HostingTracker.Src.Common.DataTypes;
using HostingTracker.Src.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostingTracker.Src.HostingServices.GoDaddy
{
    public class GodaddyService : IHostingService
    {
        private readonly string _serviceName;
        private readonly string _apiKey;
        private HttpClient _httpClient;

        public GodaddyService(string apiKey)
        {
            _serviceName = "GoDaddy";
            _apiKey = apiKey;
            _httpClient = new()
            {
                BaseAddress = new Uri("??"),
            };
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _apiKey);
        }

        public string GetServiceName()
        {
            return _serviceName;
        }

        public Task<IList<HostingProduct>> GetHostingProducts()
        {
            throw new NotImplementedException();
        }
    }
}
