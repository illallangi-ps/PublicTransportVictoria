using System.Threading.Tasks;

using Refit;

namespace Illallangi.PublicTransportVictoria.DisruptionModes
{
    public interface IDisruptionModeClient
    {
        // Get all disruption modes
        [Get(@"/v3/disruptions/modes")]
        Task<GetDisruptionMode> Get();
    }
}
