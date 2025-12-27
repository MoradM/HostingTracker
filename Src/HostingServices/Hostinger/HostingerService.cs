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
            var parsedHostingerDomains = await CallHostingerApi<IList<HostingerDomain>>("api/domains/v1/portfolio");
            IList<Domain> domains = 
                parsedHostingerDomains.Select<HostingerDomain, Domain>(domain => 
                new Domain(
                    domain.path,
                    domain.expiration != null ? DateTime.Parse(domain.expiration) : DateTime.MinValue))
                .ToList();
            return domains;
        }

        public Task<IList<HostingProduct>> GetProducts()
        {
            throw new NotImplementedException();
        }

        private async Task<T> CallHostingerApi<T>(string endpoint)
        {
            try
            {
                using HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var parsedReply = JsonSerializer.Deserialize<T>(jsonResponse);
                return parsedReply;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calling {endpoint} from Hostinger: {ex.Message}");
            }

            return default;
        }
    }
}
