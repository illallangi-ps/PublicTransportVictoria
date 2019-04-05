using Newtonsoft.Json;

namespace Illallangi.PublicTransportVictoria.Stops
{
    public sealed class Stop
    {
        [JsonProperty(@"stop_id")]
        public int Id { get; set; }

        [JsonProperty(@"stop_suburb")]
        public string Suburb { get; set; }

        [JsonProperty(@"stop_name")]
        public string Name { get; set; }

        [JsonProperty(@"route_type")]
        public int RouteTypeId { get; set; }

        [JsonProperty(@"stop_latitude")]
        public double Latitude { get; set; }

        [JsonProperty(@"stop_longitude")]
        public double Longitude { get; set; }

        [JsonProperty(@"stop_sequence")]
        public int Sequence { get; set; }
    }
}