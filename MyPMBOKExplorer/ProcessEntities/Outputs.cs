using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
  public  class Outputs
    {
        public string Name { get; set; } = "Outputs";
        public List<IProcessEntity> Items { get; set; } = new List<IProcessEntity>();
    }
}
