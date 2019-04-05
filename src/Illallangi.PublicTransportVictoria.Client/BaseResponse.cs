using Newtonsoft.Json;

namespace Illallangi.PublicTransportVictoria
{
    public abstract class BaseResponse
    {
        [JsonProperty(@"status")]
        public Status Status { get; set; }

        public T ThrowIfNotHealthy<T>() where T : BaseResponse
        {
            if (this.Status.Health != "1")
            {
                throw new ApiHealthException(this.Status.Health);
            }
            return (T)this;
        }

        public T ThrowIfNotCorrectVersion<T>() where T : BaseResponse
        {
            if (this.Status.Version != "3.0")
            {
                throw new ApiVersionException(this.Status.Version);
            }
            return (T)this;
        }
    }
}
