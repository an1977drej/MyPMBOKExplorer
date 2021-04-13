using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
    [Serializable]
    public class ProcessGroup
    {
        public string Name { get; set; }
        public List<Process> Processes { get; set; } = new List<Process>();
    }
}
