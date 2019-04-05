using System;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

namespace Illallangi.PublicTransportVictoria.Departures
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.Get, "PtvDeparture")]
    public sealed class GetDeparture : PublicTransportVictoriaCmdlet
    {
        [Parameter(Mandatory=true, ParameterSetName=@"ByRouteTypeAndStop")]
        [Parameter(Mandatory = true, ParameterSetName = @"ByRouteTypeStopAndRoute")]
        public int RouteTypeId { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = @"ByRouteTypeAndStop")]
        [Parameter(Mandatory = true, ParameterSetName = @"ByRouteTypeStopAndRoute")]
        public int StopId { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = @"ByRouteTypeStopAndRoute")]
        public int RouteId { get; set; }

        protected override void EndProcessing()
        {
            switch (this.ParameterSetName)
            {
                case @"ByRouteTypeAndStop":
                    break;

                case @"ByRouteTypeStopAndRoute":
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}