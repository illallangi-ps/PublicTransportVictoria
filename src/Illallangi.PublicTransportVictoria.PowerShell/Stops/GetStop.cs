using System;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

namespace Illallangi.PublicTransportVictoria.Stops
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.Get, "PtvStop")]
    public sealed class GetStop : PublicTransportVictoriaCmdlet
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