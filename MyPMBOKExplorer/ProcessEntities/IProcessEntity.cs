using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
    public interface IProcessEntity
    {
        string Name { get; set; }
        string FolderPath { get; set; }
    }
}
