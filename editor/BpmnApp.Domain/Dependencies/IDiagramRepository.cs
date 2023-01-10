using BmpmnApp.ApiContract.Requests;
using BmpmnApp.ApiContract.Responses;
using BpmnApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BpmnApp.Domain.Dependencies
{
    public interface IDiagramRepository
    {
        public Task<DiagramModel> GetDiagramXml(Guid diagramId);
        public Task SaveDiagram(SaveDiagramRequest diagramRequest);
        public Task<Guid> CreateSubProcess(CreateSubProcessRequest request);
        public Task<List<DiagramSubprocessResponse>> GetDiagramSubprocesses(Guid diagramId);
    }
}
