using System.Collections.Generic;

namespace Illallangi.PublicTransportVictoria.Stops
{
    public class GetStopByRouteAndRouteType : BaseResponse
    {
        public List<Stop> Stops { get; set; }
    }
}