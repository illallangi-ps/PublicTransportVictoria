using System.Threading.Tasks;

using Refit;

namespace Illallangi.PublicTransportVictoria.Stops
{
    public interface IStopClient
    {
        // View facilities at a specific stop (Metro and V/Line stations only)
        [Get(@"/v3/stops/{id}/route_type/{routeType}")]
        Task<GetStopByIdAndRouteType> GetByIdAndRouteType(int id, int routeType);

        // View all stops on a specific route
        [Get(@"/v3/stops/route/{route}/route_type/{routeType}")]
        Task<GetStopByRouteAndRouteType> GetByRouteAndRouteType(int route, int routeType);

        // View all stops near a specific location
        [Get(@"/v3/stops/location/{latitude},{longitude}")]
        Task<GetStopByLatitudeAndLongitude> GetByLatitudeAndLongitude(double latitude, double longitude);
    }
}
