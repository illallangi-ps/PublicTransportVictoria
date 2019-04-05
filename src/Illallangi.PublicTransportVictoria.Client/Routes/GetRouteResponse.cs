using System.Collections.Generic;

namespace Illallangi.PublicTransportVictoria.Routes
{
    public class GetRouteResponse : BaseResponse
    {
        public List<Route> Routes { get; set; }
    }
}