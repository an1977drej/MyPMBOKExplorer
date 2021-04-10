using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
   public class Project
    {
        public string Name { get; set; }
        public string RootPath { get; set; } = @"C:\Users\Andrej\Desktop\PM Project";
        public List<KnowledgeArea> KnowledgeAreas { get; set; } = new List<KnowledgeArea>();
        public List<ProcessGroup> ProcessGroups { get; set; } = new List<ProcessGroup>();
        public List<IProcessEntity> ProcessEntities { get; set; } = new List<IProcessEntity>();
        public List<Process> Processes { get; set; } = new List<Process>();
    }
}
