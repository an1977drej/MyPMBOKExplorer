﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyPMBOKExplorer
{
    [Serializable]
    public class Process
    {
        Project m_project;
        public string Name { get; set; }
        [XmlIgnore]
        public KnowledgeArea KnowledgeArea { get; private set; }
        [XmlIgnore]
        public ProcessGroup ProcessGroup { get; private set; }
        [XmlIgnore]
        public Inputs Inputs { get; set; } = new Inputs();
        [XmlIgnore]
        public Outputs OutputsCreated { get; set; } = new Outputs();
        [XmlIgnore]
        public Outputs OutputsUpdated { get; set; } = new Outputs();
        [XmlIgnore]
        public Tools Tools { get; set; } = new Tools();

        [XmlIgnore]
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
        [XmlIgnore]
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
        [XmlIgnore]
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
        [XmlIgnore]
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
        [XmlIgnore]
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
        public Process()
        {

        }
        public void AssignToProcessGroup(string processGroup)
        {
            ProcessGroup = m_project.ProcessGroups.FirstOrDefault(x => x.Name == processGroup);
            ProcessGroup.Processes.Add(this);
            
        }
        public void AssignToKnowledgeArea(string knowledgeArea)
        {
            KnowledgeArea = m_project.KnowledgeAreas.FirstOrDefault(x => x.Name == knowledgeArea);
            KnowledgeArea.Processes.Add(this);
        }
        public void AssignToInputs(List<string> inputs)
        {
            foreach (string item in inputs)
            {
                if (m_project.ProcessEntities.FirstOrDefault(x => x.Name == item) != null)
                {
                    Inputs.Items.Add(m_project.ProcessEntities.FirstOrDefault(x => x.Name == item));
                }
            }
        }
        public void AssignToOutputsCreated(List<string> ouputs)
        {
            foreach (string item in ouputs)
            {
                ProcessEntity selectedTool = m_project.ProcessEntities.FirstOrDefault(x => x.Name == item);
                if (m_project.ProcessEntities.FirstOrDefault(x => x.Name == item) != null)
                {
                    OutputsCreated.Items.Add(m_project.ProcessEntities.FirstOrDefault(x => x.Name == item));
                }
            }
        }
        public void AssignToOutputsUpdated(List<string> ouputs)
        {
            foreach (string item in ouputs)
            {
                ProcessEntity selectedTool = m_project.ProcessEntities.FirstOrDefault(x => x.Name == item);
                if (m_project.ProcessEntities.FirstOrDefault(x => x.Name == item) != null)
                {
                    OutputsUpdated.Items.Add(m_project.ProcessEntities.FirstOrDefault(x => x.Name == item));
                }
            }
        }
        public void AssignToTools(List<string> tools)
        {
            foreach (string item in tools)
            {
                ProcessEntity selectedTool = m_project.ProcessEntities.FirstOrDefault(x => x.Name == item);
                if (m_project.ProcessEntities.FirstOrDefault(x => x.Name == item) != null)
                {
                    Tools.Items.Add(m_project.ProcessEntities.FirstOrDefault(x => x.Name == item));
                }
            }
        }

    }
}
