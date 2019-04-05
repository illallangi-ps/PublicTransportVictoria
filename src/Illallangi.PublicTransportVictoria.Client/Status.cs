using Newtonsoft.Json;

namespace Illallangi.PublicTransportVictoria
{
    public sealed class Status
    {
        [JsonProperty(@"health")]
        public string Health { get; set; }

        [JsonProperty(@"version")]
        public string Version { get; set; }
    }
}
