using System.Threading.Tasks;

using Refit;

namespace Illallangi.PublicTransportVictoria.RouteTypes
{
    public interface IRouteTypeClient
    {
        // View all route types and their names
        [Get(@"/v3/route_types")]
        Task<GetRouteType> Get();
    }
}
