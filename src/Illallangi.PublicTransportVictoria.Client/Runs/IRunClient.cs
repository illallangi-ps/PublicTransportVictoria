using System.Threading.Tasks;

using Refit;

namespace Illallangi.PublicTransportVictoria.Runs
{
    public interface IRunClient
    {
        // View all trip/service runs for a specific run ID
        [Get(@"/v3/runs/{run}")]
        Task<GetRunById> GetById(int run);

        // View all trip/service runs for a specific route ID
        [Get(@"/v3/runs/route/{route}")]
        Task<GetRunByRoute> GetByRoute(int route);

        // View all trip/service runs for a specific route ID and route type
        [Get(@"/v3/runs/route/{route}/route_type/{routeType}")]
        Task<GetRunByRouteAndRouteType> GetByRouteAndRouteType(int route, int routeType);
        
        // View the trip/service run for a specific run ID and route type
        [Get(@"/v3/runs/{id}/route_type/{routeType}")]
        Task<GetRunByIdAndRouteType> GetByIdAndRouteType(int id, int routeType);
    }
}
