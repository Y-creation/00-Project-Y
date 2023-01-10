using System;
using System.Collections.Generic;
using System.Text;

namespace BmpmnApp.ApiContract.Responses
{
    public class DiagramSubprocessResponse
    {
        public Guid SubprocessDiagramId { get; set; }
        public string DiagramTaskId { get; set; }
    }
}
