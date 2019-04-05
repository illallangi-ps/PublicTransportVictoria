using System;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

namespace Illallangi.PublicTransportVictoria.Outlets
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.Get, "PtvOutlet")]
    public sealed class GetOutlet : PublicTransportVictoriaCmdlet
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