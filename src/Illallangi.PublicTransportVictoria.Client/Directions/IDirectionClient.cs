using System.Threading.Tasks;

using Refit;

namespace Illallangi.PublicTransportVictoria.Directions
{
    public interface IDirectionClient
    {
        // View directions that a route travels in
        [Get(@"/v3/directions/route/{route}")]
        Task<GetDirectionByRoute> GetByRoute(int route);
    }
}
