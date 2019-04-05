using System;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

namespace Illallangi.PublicTransportVictoria.DisruptionModes
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.Get, "PtvDisruptionMode")]
    public sealed class GetDisruptionMode : PublicTransportVictoriaCmdlet
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