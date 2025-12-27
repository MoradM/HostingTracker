using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HostingTracker.Src.HostingServices.Hostinger.DataTypes
{
    public class HostingerVM
    {
        [JsonPropertyName("hostname")]
        public string hostname { get; set; }
        [JsonPropertyName("subscription_id")]
        public string subscriptionId { get; set; }
    }

    public class HostingerVmsReply
    {

    }
}
