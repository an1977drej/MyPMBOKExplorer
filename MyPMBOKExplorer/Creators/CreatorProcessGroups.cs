using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
   public static class CreatorProcessGroups
    {
        public static List<ProcessGroup> Create()
        {
            List<ProcessGroup> processGroups = new List<ProcessGroup>();
            processGroups.Add(new ProcessGroup() { Name = "Initiating" });
            processGroups.Add(new ProcessGroup() { Name = "Planning" });
            processGroups.Add(new ProcessGroup() { Name = "Executing" });
            processGroups.Add(new ProcessGroup() { Name = "Monitoring" });
            processGroups.Add(new ProcessGroup() { Name = "Closing" });
            return processGroups;
        }
    }
}
