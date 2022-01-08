using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
    public class CreatorProject
    {
        public static Project GetNewProject(string filePath)
        {
            string folderPath = Path.GetDirectoryName(filePath);
            string name = Path.GetFileNameWithoutExtension(filePath);
            Project newProject = new Project();
            newProject.Name = name;
            newProject.FolderPath = folderPath;
            newProject.FilePath = filePath;
            newProject.ProcessGroups.AddRange(CreatorProcessGroups.Create());
            newProject.KnowledgeAreas.AddRange(CreatorKnowledgeAreas.Create());
            newProject.ProcessEntities.AddRange(new CreatorProcessEntities(newProject).Create());
            newProject.Processes.AddRange(CreatorProcesses.Create(newProject));
            return newProject;
        }

        public static Project GetSavedProject(string filePath)
        {
            var savedProject = MyXMLSerializer.DeSerializeObject<Project>(filePath);
            Project project = GetNewProject(filePath);
            foreach (var process in project.Processes)
            {
               
            }
            foreach (var processEntity in project.ProcessEntities)
            {
                var savedProcessEntity = savedProject.ProcessEntities.First(x => x.Name == processEntity.Name);
                processEntity.FolderPath = savedProcessEntity.FolderPath;
            }
            return project;
        }

    }
}
