using Newtonsoft.Json;

namespace Illallangi.PublicTransportVictoria.RouteTypes
{
    public sealed class RouteType
    {
        [JsonProperty(@"route_type")]
        public int Id { get; set; }

        [JsonProperty(@"route_type_name")]
        public string Name { get; set; }
    }
}
