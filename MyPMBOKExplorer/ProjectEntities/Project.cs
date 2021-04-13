using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyPMBOKExplorer
{
    [Serializable]
    public class Project
    {
        public string Name { get; set; }
        public string FolderPath { get; set; }
        public string FilePath { get; set; }
        [XmlIgnore]
        public List<KnowledgeArea> KnowledgeAreas { get; set; } = new List<KnowledgeArea>();
        [XmlIgnore]
        public List<ProcessGroup> ProcessGroups { get; set; } = new List<ProcessGroup>();
        //[XmlIgnore]
        public List<ProcessEntity> ProcessEntities { get; set; } = new List<ProcessEntity>();
        //[XmlIgnore]
        public List<Process> Processes { get; set; } = new List<Process>();
    }
}
