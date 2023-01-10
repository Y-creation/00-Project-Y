using BmpmnApp.ApiContract.Requests;
using BmpmnApp.ApiContract.Responses;
using BpmnApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BpmnApp.Domain.Contracts
{
    public interface IDiagramService
    {
        public Task<DiagramModel> GetDiagramXml(Guid diagramId);
        public Task SaveDiagram(SaveDiagramRequest diagramRequest);

        public Task<CreateSubpocessResponse> CreateSubProcess(CreateSubProcessRequest request);

        public Task<List<DiagramSubprocessResponse>> GetDiagramSubprocesses(Guid diagramId);
    }
}
