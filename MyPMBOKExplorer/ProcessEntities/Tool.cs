using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
    public class Tool : IProcessEntity
    {
        public string Name { get; set; }
        public string FolderPath { get; set; }
        public List<IDocFile> Documents { get; set; } = new List<IDocFile>();
    }
}
