import BpmnJS from 'bpmn-js';

function createBpmnViewer(containerId, diagramUrl) {
    var bpmnViewer = new BpmnJS({ container: containerId });
    bpmnViewer.importXML(diagramUrl, function(err) {
      if (err) {
        console.log('error rendering', err);
      } else {
        console.log('rendered');
      }
    });
  }

createBpmnViewer('#canvas', '/diagrams/diagramtest.bpmn')
console.log("this worked")