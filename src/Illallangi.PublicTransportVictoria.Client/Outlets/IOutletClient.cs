using System.Threading.Tasks;

using Refit;

namespace Illallangi.PublicTransportVictoria.Outlets
{
    public interface IOutletClient
    {
        // List all ticket outlets
        [Get(@"/v3/outlets")]
        Task<GetOutlet> Get();

        // List ticket outlets near a specific location
        [Get(@"/v3/outlets/location/{latitude},{longitude}")]
        Task<GetOutletByLatitudeAndLongitude> GetByLatitudeAndLongitude(double latitude, double longitude);
    }
}
