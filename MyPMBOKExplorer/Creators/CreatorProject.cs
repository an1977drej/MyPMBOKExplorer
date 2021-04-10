using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
    public class CreatorProject
    {
        public static Project GetProject()
        {

            Project newProject = new Project();
            //newProject.Name = "Rig PCR AR228";
            newProject.Name = "Rig PCR AR229";
            newProject.ProcessGroups.AddRange(CreatorProcessGroups.Create());
            newProject.KnowledgeAreas.AddRange(CreatorKnowledgeAreas.Create());
            
            newProject.ProcessEntities.AddRange(new CreatorProcessEntities(newProject).Create());
            newProject.Processes.AddRange(CreatorProcesses.Create(newProject));
            return newProject;
        }

    }
}
