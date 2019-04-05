using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;

namespace Illallangi
{
    public sealed class OAuthHmacSha1Handler : DelegatingHandler
    {
        #region Constructors

        public OAuthHmacSha1Handler(
            HttpMessageHandler innerHandler, 
            string userId, 
            string apiKey) :
            base(innerHandler)
        {
            this.UserId = userId ?? throw new ArgumentNullException(nameof(userId));
            this.ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        }

        #endregion

        #region Properties

        public string UserId { get; }

        public string ApiKey { get; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{base.ToString()}(innerHandler,userId:{this.UserId},apiKey:{this.ApiKey})";
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var query = string.Format("{0}{1}devid={2}", request.RequestUri.PathAndQuery, request.RequestUri.PathAndQuery.Contains("?") ? "&" : "?", this.UserId);

            var encoding = new ASCIIEncoding();
            // encode key
            byte[] apiKeyBytes = encoding.GetBytes(this.ApiKey);
            // encode url
            byte[] queryBytes = encoding.GetBytes(query);
            byte[] tokenBytes = new System.Security.Cryptography.HMACSHA1(apiKeyBytes).ComputeHash(queryBytes);
            var sb = new StringBuilder();
            // convert signature to string
            Array.ForEach<byte>(tokenBytes, x => sb.Append(x.ToString("X2")));
            // add signature to url
            var signature = string.Format("{0}&signature={1}", query, sb.ToString());

            var r = $"{request.RequestUri.GetLeftPart(UriPartial.Authority)}{signature}";
            request.RequestUri = new Uri(r);
            
            return await base.SendAsync(request, cancellationToken);
        }

        #endregion
    }
}