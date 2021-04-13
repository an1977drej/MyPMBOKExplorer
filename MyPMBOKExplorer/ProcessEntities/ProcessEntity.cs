using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyPMBOKExplorer
{
    [Serializable]
    [XmlInclude(typeof(Tool))]
    [XmlInclude(typeof(Document))]
    public class ProcessEntity
    {
        public string Name { get; set; }
        public string FolderPath { get; set; }
    }
}
