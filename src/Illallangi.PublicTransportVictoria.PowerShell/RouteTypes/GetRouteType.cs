using System;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

namespace Illallangi.PublicTransportVictoria.RouteTypes
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.Get, "PtvRouteType")]
    public sealed class GetRouteType : PublicTransportVictoriaCmdlet
    {
        protected override void EndProcessing()
        {
            switch (this.ParameterSetName)
            {
                default:
                    throw new NotImplementedException();
            }
        }
    }
}