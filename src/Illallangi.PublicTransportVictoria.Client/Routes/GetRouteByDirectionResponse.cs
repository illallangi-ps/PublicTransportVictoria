using System.Collections.Generic;

namespace Illallangi.PublicTransportVictoria.Routes
{
    public class GetRouteByDirectionResponse : BaseResponse
    {
        public List<Route> Routes { get; set; }
    }
}