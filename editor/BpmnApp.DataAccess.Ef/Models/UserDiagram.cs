﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BpmnApp.DataAccess.Ef.Models
{
    public partial class UserDiagram
    {
        public Guid UserDiagramId { get; set; }
        public Guid UserId { get; set; }
        public Guid DiagramId { get; set; }

        public virtual Diagram Diagram { get; set; }
        public virtual AppUser User { get; set; }
    }
}