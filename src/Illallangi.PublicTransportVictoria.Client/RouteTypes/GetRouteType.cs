using System.Collections.Generic;

namespace Illallangi.PublicTransportVictoria.RouteTypes
{
    public class GetRouteType : BaseResponse
    {
        public List<RouteType> RouteTypes { get; set; }
    }
}