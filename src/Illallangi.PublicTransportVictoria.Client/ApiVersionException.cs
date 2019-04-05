using System;

namespace Illallangi.PublicTransportVictoria
{
    public sealed class ApiVersionException : Exception
    {
        public ApiVersionException(string version)
            : base($"Api Version not equal to 3.0 (received {version}).")
        {
        }
    }
}
