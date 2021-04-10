using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
    public class Process
    {
        Project m_project;
        public string Name { get; set; }
        public KnowledgeArea KnowledgeArea { get; private set; }
        public ProcessGroup ProcessGroup { get; private set; }
        public Inputs Inputs { get; set; } = new Inputs();
        public Outputs OutputsCreated { get; set; } = new Outputs();
        public Outputs OutputsUpdated { get; set; } = new Outputs();
        public Tools Tools { get; set; } = new Tools();

        public bool Initiating
        {
            get
            {
                if (ProcessGroup.Name == "Initiating")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Planning
        {
            get
            {
                if (ProcessGroup.Name == "Planning")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Executing
        {
            get
            {
                if (ProcessGroup.Name == "Executing")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Monitoring
        {
            get
            {
                if (ProcessGroup.Name == "Monitoring")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Closing
        {
            get
            {
                if (ProcessGroup.Name == "Closing")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Process(Project project, string name)
        {
            Name = name;
            m_project = project;
        }
        
        public void SetProcessGroup(string processGroup)
        {
            ProcessGroup = m_project.ProcessGroups.FirstOrDefault(x => x.Name == processGroup);
            ProcessGroup.Processes.Add(this);
            
        }
        public void SetKnowledgeArea(string knowledgeArea)
        {
            KnowledgeArea = m_project.KnowledgeAreas.FirstOrDefault(x => x.Name == knowledgeArea);
            KnowledgeArea.Processes.Add(this);
        }
        public void SetInputs(List<string> inputs)
        {
            foreach (string item in inputs)
            {
                if (m_project.ProcessEntities.FirstOrDefault(x => x.Name == item) != null)
                {
                    Inputs.Items.Add(m_project.ProcessEntities.FirstOrDefault(x => x.Name == item));
                }
            }
        }
        public void SetOutputsCreated(List<string> ouputs)
        {
            foreach (string item in ouputs)
            {
                IProcessEntity selectedTool = m_project.ProcessEntities.FirstOrDefault(x => x.Name == item);
                if (m_project.ProcessEntities.FirstOrDefault(x => x.Name == item) != null)
                {
                    OutputsCreated.Items.Add(m_project.ProcessEntities.FirstOrDefault(x => x.Name == item));
                }
            }
        }
        public void SetOutputsUpdated(List<string> ouputs)
        {
            foreach (string item in ouputs)
            {
                IProcessEntity selectedTool = m_project.ProcessEntities.FirstOrDefault(x => x.Name == item);
                if (m_project.ProcessEntities.FirstOrDefault(x => x.Name == item) != null)
                {
                    OutputsUpdated.Items.Add(m_project.ProcessEntities.FirstOrDefault(x => x.Name == item));
                }
            }
        }
        public void SetTools(List<string> tools)
        {
            foreach (string item in tools)
            {
                IProcessEntity selectedTool = m_project.ProcessEntities.FirstOrDefault(x => x.Name == item);
                if (m_project.ProcessEntities.FirstOrDefault(x => x.Name == item) != null)
                {
                    Tools.Items.Add(m_project.ProcessEntities.FirstOrDefault(x => x.Name == item));
                }
            }
        }

    }
}
