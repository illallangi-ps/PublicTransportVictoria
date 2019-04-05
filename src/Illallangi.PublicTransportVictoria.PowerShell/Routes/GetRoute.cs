using System;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

namespace Illallangi.PublicTransportVictoria.Routes
{
    using Routes_GetRoute = Routes.GetRoute;

    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.Get, "PtvRoute")]
    public sealed class GetRoute : PublicTransportVictoriaCmdlet
    {
        [Parameter(Mandatory = false, ParameterSetName = @"Get")]
        public int? Id { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = @"GetByDirection")]
        [Parameter(Mandatory = true, ParameterSetName = @"GetByDirectionAndRouteType")]
        public int Direction { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = @"GetByDirectionAndRouteType")]
        public int RouteType { get; set; }

        protected override void EndProcessing()
        {
            switch (this.ParameterSetName)
            {
                case @"Get":
                    if (this.Id.HasValue)
                    {
                        this.WriteObject(this.Get<IRouteClient>()
                            .GetById(this.Id.Value)
                            .Result
                            .ThrowIfNotCorrectVersion<GetRouteByIdResponse>()
                            .ThrowIfNotHealthy<GetRouteByIdResponse>()
                            .Route, false);
                    }
                    else
                    {
                        this.WriteObject(this.Get<IRouteClient>()
                            .Get()
                            .Result
                            .ThrowIfNotCorrectVersion<GetRouteResponse>()
                            .ThrowIfNotHealthy<GetRouteResponse>()
                            .Routes, true);
                    }
                    break;

                case @"GetByDirection":
                    this.WriteObject(this.Get<IRouteClient>()
                        .GetByDirection(this.Direction)
                        .Result
                        .ThrowIfNotCorrectVersion<GetRouteByDirectionResponse>()
                        .ThrowIfNotHealthy<GetRouteByDirectionResponse>()
                        .Routes, true);
                    break;

                case @"GetByDirectionAndRouteType":
                    this.WriteObject(this.Get<IRouteClient>()
                        .GetByDirectionAndRouteType(this.Direction, this.RouteType)
                        .Result
                        .ThrowIfNotCorrectVersion<GetRouteByDirectionAndRouteTypeResponse>()
                        .ThrowIfNotHealthy<GetRouteByDirectionAndRouteTypeResponse>()
                        .Routes, true);
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}