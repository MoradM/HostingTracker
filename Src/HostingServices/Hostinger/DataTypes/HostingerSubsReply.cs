using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HostingTracker.Src.HostingServices.Hostinger.DataTypes
{
    public class HostingerSub
    {
        [JsonPropertyName("id")]
        public string id { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("expires_at")]
        public string? expiration { get; set; }
        [JsonPropertyName("is_auto_renewed")]
        public bool is_auto_renewed { get; set; }
    }

    public class HostingerSubsReply
    {
        public IList<HostingerSub> subscriptions { get; set; }
    }
}
