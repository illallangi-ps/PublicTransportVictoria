using System.Net.Http;
using Ninject.Activation;
using Illallangi.PublicTransportVictoria.Settings;

namespace Illallangi.PublicTransportVictoria
{
    public sealed class OAuthHmacSha1HandlerProvider : Provider<OAuthHmacSha1Handler>
    {
        public HttpMessageHandler HttpClientHandler { get; }

        public Setting Setting { get; }

        public OAuthHmacSha1HandlerProvider(
            HttpClientHandler httpClientHandler,
            Setting setting)
        {
            this.HttpClientHandler = httpClientHandler;
            this.Setting = setting;
        }

        protected override OAuthHmacSha1Handler CreateInstance(
            IContext cx)
        {
            return new OAuthHmacSha1Handler(
                this.HttpClientHandler, 
                this.Setting.UserId, 
                this.Setting.ApiKey);
        }
    }
}
