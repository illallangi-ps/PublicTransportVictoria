using System.Collections.Generic;

namespace Illallangi.PublicTransportVictoria.Runs
{
    public class GetRunByRoute : BaseResponse
    {
        public List<Run> Runs { get; set; }
    }
}