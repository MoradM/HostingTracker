using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HostingTracker.Src.HostingServices.Hostinger.DataTypes
{
    public class HostingerDomain
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("domain")]
        public string path { get; set; }
        [JsonPropertyName("expires_at")]
        public string? expiration { get; set; }
        [JsonPropertyName("type")]
        public string type { get; set; }
    }

    public class HostingerDomainsReply
    {
        public IList<HostingerDomain> domains { get; set; }
    }
}
