using System;
using System.Collections.Generic;
using System.Text;

namespace BmpmnApp.ApiContract.Requests
{
    public class CreateSubProcessRequest
    {
        public Guid ParentDiagramId { get; set; }
        public string TaskId { get; set; }
    }
}
