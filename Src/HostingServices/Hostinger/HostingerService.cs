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

        public async Task<IList<HostingProduct>> GetHostingProducts()
        {
            IList<HostingProduct> products = new List<HostingProduct>();

            // For webhosting, we must call subs api.
            var subs = await CallHostingerApi<IList<HostingerSub>>("api/billing/v1/subscriptions");

            // Gather web hosting
            var webHostingSubs = subs.Where(sub => sub.name.ToLower().Contains("hosting"));
            foreach (var webHosting in webHostingSubs)
            {
                products.Add(new HostingProduct(
                    webHosting.name,
                    HostingType.WebHosting,
                    webHosting.expiration != null ? DateTime.Parse(webHosting.expiration) : DateTime.MinValue,
                    webHosting.is_auto_renewed
                ));
            }

            // Get domains
            var domains = (await GetDomains());
            foreach (var domain in domains)
            {
                if (!domain.type.ToLower().Contains("free_domain"))
                {
                    products.Add(new HostingProduct(
                        domain.path,
                        HostingType.Domain,
                        domain.expiration != null ? DateTime.Parse(domain.expiration) : DateTime.MinValue,
                        null // Hostinger API does not provide auto-renew info for domains - we map this to unknown in the form
                    ));
                }
            }

            // Get VMs
            // For VMS, we can map expires_at and is auto renewed from subs api
            var vms = await GetVMs();
            foreach (var vm in vms)
            {
                var vmSub = subs.Where(sub => sub.id == vm.subscriptionId).First();
                products.Add(new HostingProduct(
                    vm.hostname,
                    HostingType.VPS,
                    vmSub?.expiration != null ? DateTime.Parse(vmSub.expiration) : DateTime.MinValue,
                    vmSub?.is_auto_renewed
                ));
            }

            return products;
        }

        private async Task<IList<HostingerDomain>> GetDomains()
        {
            return await CallHostingerApi<IList<HostingerDomain>>("api/domains/v1/portfolio");
        }

        private async Task<IList<HostingerVM>> GetVMs()
        {
            return await CallHostingerApi<IList<HostingerVM>>("api/vps/v1/virtual-machines");
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
