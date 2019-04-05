using System.Collections.Generic;

namespace Illallangi.PublicTransportVictoria.Routes
{
    public class GetRouteByIdResponse : BaseResponse
    {
        public Route Route { get; set; }
    }
}