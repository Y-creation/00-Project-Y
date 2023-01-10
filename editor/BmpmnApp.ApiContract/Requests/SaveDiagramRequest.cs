using System;
using System.Collections.Generic;
using System.Text;

namespace BmpmnApp.ApiContract.Requests
{
    public class SaveDiagramRequest
    {
        public Guid DiagramId { get; set; }
        public string DiagramXml { get; set; }
    }
}
