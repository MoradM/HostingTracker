using HostingTracker.Src.Common.DataTypes;
using HostingTracker.Src.Common.Interfaces;
using HostingTracker.Src.HostingServices.Hostinger.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HostingTracker.Src.HostingServices.Hostinger
{
    public class HostingerService : IHostingService
    {
        private readonly string _serviceName;
        private readonly string _apiKey;
        private HttpClient _httpClient;

        public HostingerService(string apiKey) 
        {
            _serviceName = "Hostinger";
            _apiKey = apiKey;
            _httpClient = new()
            {
                BaseAddress = new Uri("https://developers.hostinger.com"),
            };
            _httpClient.DefaultRequestHeaders.Authorization = 
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _apiKey);
        }

        public async Task<IList<Domain>> GetDomains()
        {
            IList<Domain> result = [];

            try
            {
                using HttpResponseMessage response = await _httpClient.GetAsync("api/domains/v1/portfolio");
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var parsedHostingerDomains = JsonSerializer.Deserialize<IList<HostingerDomain>>(jsonResponse);
                IList<Domain> domains = 
                    parsedHostingerDomains.Select<HostingerDomain, Domain>(domain => 
                    new Domain(
                        domain.path,
                        domain.expiration != null ? DateTime.Parse(domain.expiration) : DateTime.MinValue))
                    .ToList();
                return domains;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting domains from Hostinger: {Msg}", ex.Message);
            }

            return null;
        }
    }
}
