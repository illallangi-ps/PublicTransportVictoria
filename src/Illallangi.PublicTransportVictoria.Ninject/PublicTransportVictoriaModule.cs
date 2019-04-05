using System.Net.Http;
using Ninject.Modules;

namespace Illallangi.PublicTransportVictoria
{
    public class PublicTransportVictoriaModule : NinjectModule
    {
        public override void Load()
        {
            Bind<OAuthHmacSha1Handler>().ToProvider<OAuthHmacSha1HandlerProvider>();
            Bind<HttpClient>().ToProvider<HttpClientProvider>();

            Bind<Departures.IDepartureClient>().ToProvider<RestServiceProvider<Departures.IDepartureClient>>();
            Bind<Directions.IDirectionClient>().ToProvider<RestServiceProvider<Directions.IDirectionClient>>();
            Bind<DisruptionModes.IDisruptionModeClient>().ToProvider<RestServiceProvider<DisruptionModes.IDisruptionModeClient>>();
            Bind<Disruptions.IDisruptionClient>().ToProvider<RestServiceProvider<Disruptions.IDisruptionClient>>();
            Bind<Outlets.IOutletClient>().ToProvider<RestServiceProvider<Outlets.IOutletClient>>();
            Bind<Patterns.IPatternClient>().ToProvider<RestServiceProvider<Patterns.IPatternClient>>();
            Bind<Routes.IRouteClient>().ToProvider<RestServiceProvider<Routes.IRouteClient>>();
            Bind<RouteTypes.IRouteTypeClient>().ToProvider<RestServiceProvider<RouteTypes.IRouteTypeClient>>();
            Bind<Runs.IRunClient>().ToProvider<RestServiceProvider<Runs.IRunClient>>();
            Bind<Stops.IStopClient>().ToProvider<RestServiceProvider<Stops.IStopClient>>();
        }
    }
}
