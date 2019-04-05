using System;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

namespace Illallangi.PublicTransportVictoria.Directions
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.Get, "PtvDirection")]
    public sealed class GetDirection : PublicTransportVictoriaCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = @"ByRoute")]
        public int RouteId { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = @"ByDirection")]
        [Parameter(Mandatory = true, ParameterSetName = @"ByDirectionAndRouteType")]
        public int DirectionId { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = @"ByDirectionAndRouteType")]
        public int RouteTypeId { get; set; }

        protected override void EndProcessing()
        {
            switch (this.ParameterSetName)
            {
                case @"ByRoute":
                    break;

                case @"ByDirection":
                    break;

                case @"ByDirectionAndRouteType":
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}