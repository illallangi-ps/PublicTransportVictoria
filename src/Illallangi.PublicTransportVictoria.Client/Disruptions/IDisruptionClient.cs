using System.Threading.Tasks;

using Refit;

namespace Illallangi.PublicTransportVictoria.Disruptions
{
    public interface IDisruptionClient
    {
        // View all disruptions for all route types
        [Get(@"/v3/disruptions")]
        Task<GetDisruption> Get();

        // View a specific disruption
        [Get(@"/v3/disruptions/{id}")]
        Task<GetDisruptionById> GetById(int id);

        // View all disruptions for a particular route
        [Get(@"/v3/disruptions/route/{route}")]
        Task<GetDisruptionByRoute> GetByRoute(int route);

        // View all disruptions for a particular route and stop
        [Get(@"/v3/disruptions/route/{route}/stop/{stop}")]
        Task<GetDisruptionByRouteAndStop> GetByRouteAndStop(int route, int stop);

        // View all disruptions for a particular stop
        [Get(@"/v3/disruptions/stop/{stop}")]
        Task<GetDisruptionByStop> GetByStop(int stop);
    }
}
