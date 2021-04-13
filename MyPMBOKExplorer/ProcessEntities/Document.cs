using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
    [Serializable]
    public class Document : ProcessEntity
    {
        public string PartOf { get; set; }
    }
}
