using System;
using System.Net.Http;
using Ninject.Activation;
using Illallangi.PublicTransportVictoria.Settings;

namespace Illallangi.PublicTransportVictoria
{
    public sealed class HttpClientProvider : Provider<HttpClient>
    {
        public OAuthHmacSha1Handler OAuthHmacSha1Handler { get; }

        public Setting Setting { get; }

        public HttpClientProvider(
            OAuthHmacSha1Handler oAuthHmacSha1Handler,
            Setting setting)
        {
            this.OAuthHmacSha1Handler = oAuthHmacSha1Handler;
            this.Setting = setting;
        }

        protected override HttpClient CreateInstance(
            IContext cx)
        {
            return new HttpClient(
                this.OAuthHmacSha1Handler)
                {
                    BaseAddress = new Uri(this.Setting.BaseUrl)
                };
        }
    }
}
