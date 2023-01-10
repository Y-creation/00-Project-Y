//Service class is responsible for some part of logic,
//each method has some input from controller and should define which methods of repository should be called and how to work with their results
//In our case all logic is implemented in one service -> should be changed

using BmpmnApp.ApiContract.Requests;
using BmpmnApp.ApiContract.Responses;
using BpmnApp.Domain.Contracts;
using BpmnApp.Domain.Dependencies;
using BpmnApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BpmnApp.Domain.Services
{
    public class DiagramService : IDiagramService
    {
        private readonly IDiagramRepository diagramRepository;
        public DiagramService(IDiagramRepository _diagramRepository)
        {
            diagramRepository = _diagramRepository;
        }

        public async Task<CreateSubpocessResponse> CreateSubProcess(CreateSubProcessRequest request)
        {
            var response = await diagramRepository.CreateSubProcess(request);
            return new CreateSubpocessResponse { DiagramId = response };
        }

        public Task<List<DiagramSubprocessResponse>> GetDiagramSubprocesses(Guid diagramId)
        {
            return diagramRepository.GetDiagramSubprocesses(diagramId);
        }

        public Task<DiagramModel> GetDiagramXml(Guid diagramId)
        {
            return diagramRepository.GetDiagramXml(diagramId);
        }

        public Task SaveDiagram(SaveDiagramRequest diagramRequest)
        {
            return diagramRepository.SaveDiagram(diagramRequest);
        }
    }
}
