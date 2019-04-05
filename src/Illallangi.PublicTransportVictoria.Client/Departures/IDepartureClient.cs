using System.Threading.Tasks;

using Refit;

namespace Illallangi.PublicTransportVictoria.Departures
{
    public interface IDepartureClient
    {
        // View departures for all routes from a stop
        [Get(@"/v3/departures/route_type/{routeType}/stop/{stop}")]
        Task<GetDepartureByRouteTypeAndStop> GetByRouteTypeAndStop(int routeType, int stop);

        // View departures for a specific route from a stop
        [Get(@"/v3/departures/route_type/{routeType}/stop/{stop}/route/{route}")]
        Task<GetDepartureByRouteTypeStopAndRoute> GetByRouteTypeStopAndRoute(int routeType, int stop, int route);
    }
}
