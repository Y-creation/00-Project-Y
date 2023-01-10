using System;
using System.Collections.Generic;
using System.Text;

namespace BpmnApp.Domain.Models
{
    public class DiagramModel
    {
        public Guid DiagramId { get; set; }
        public string DiagramXml { get; set; }
    }
}
