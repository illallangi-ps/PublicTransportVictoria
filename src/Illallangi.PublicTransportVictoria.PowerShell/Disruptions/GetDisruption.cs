using System;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

namespace Illallangi.PublicTransportVictoria.Disruptions
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.Get, "PtvDisruption")]
    public sealed class GetDisruption : PublicTransportVictoriaCmdlet
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