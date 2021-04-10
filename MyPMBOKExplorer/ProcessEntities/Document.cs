using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
   public class Document : IProcessEntity
    {
        public string Name { get; set; }
        public string FolderPath { get; set; }
        public string PartOf { get; set; }
    }
}
