using System;

namespace Illallangi.PublicTransportVictoria
{
    public sealed class ApiHealthException : Exception
    {
        public ApiHealthException(string health)
            : base($"Api Health not equal to 1 (received {health}).")
        {
        }
    }
}
