using System.Collections.Generic;

namespace Illallangi.PublicTransportVictoria.Routes
{
    public class GetRouteByDirectionAndRouteTypeResponse : BaseResponse
    {
        public List<Route> Routes { get; set; }
    }
}