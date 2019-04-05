using System.Threading.Tasks;

using Refit;

namespace Illallangi.PublicTransportVictoria.Patterns
{
    public interface IPatternClient
    {
        // View the stopping pattern for a specific trip/service run
        [Get(@"/v3/pattern/run/{run}/route_type/{routeType}")]
        Task<GetPatternByRunAndRouteType> GetByRunAndRouteType(int run, int routeType);
    }
}
