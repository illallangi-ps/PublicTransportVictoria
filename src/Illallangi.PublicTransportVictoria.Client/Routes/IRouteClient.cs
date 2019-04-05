using System.Threading.Tasks;

using Refit;

namespace Illallangi.PublicTransportVictoria.Routes
{
    public interface IRouteClient
    {
        // View route names and numbers for all routes
        [Get(@"/v3/routes")]
        Task<GetRouteResponse> Get();

        // View route name and number for specific route ID
        [Get(@"/v3/routes/{id}")]
        Task<GetRouteByIdResponse> GetById(int id);

        // View all routes for a direction of travel
        [Get(@"/v3/directions/{direction}")]
        Task<GetRouteByDirectionResponse> GetByDirection(int direction);

        // View all routes of a particular type for a direction of travel
        [Get(@"/v3/directions/{direction}/route_type/{routeType}")]
        Task<GetRouteByDirectionAndRouteTypeResponse> GetByDirectionAndRouteType(int direction, int routeType);
    }
}
