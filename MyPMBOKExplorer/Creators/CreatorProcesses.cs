using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
    public static class CreatorProcesses
    {

        public static List<Process> Create(Project project)
        {
            List<Process> processes = new List<Process>();
            //*************************************************************
            #region Initiating
            Process p1 = new Process(project, "Develop Project Charter");
            p1.SetProcessGroup("Initiating");
            p1.SetKnowledgeArea("Integration Management");
            p1.SetInputs(new List<string>() { "Business case", "Benefits management plan", "Agreements",
            "Enterprise environmental factors","Organizational process assets"});
            p1.SetOutputsCreated(new List<string>() { "Project charter", "Assumption log" });
            p1.SetTools(new List<string>() { "Brainstorming", "Focus groups", "Interviews", 
            "Conflict management", "Facilitation", "Meeting management","Meetings","Expert judgment" });
            processes.Add(p1);
            //*************************************************************
            Process p2 = new Process(project, "Identify Stakeholders");
            p2.SetProcessGroup("Initiating");
            p2.SetKnowledgeArea("Stakeholder Management");
            p2.SetInputs(new List<string>() { "Project charter", "Business case", "Benefits management plan",
            "Communications management plan","Stakeholder engagement plan","Change log","Issue log","Requirements documentation",
            "Agreements", "Enterprise environmental factors","Organizational process assets" });
            p2.SetOutputsCreated(new List<string>() { "Stakeholder register", "Change requests"});
            p2.SetOutputsUpdated(new List<string>() {"Requirements management plan","Communications management plan",
            "Risk management plan","Stakeholder engagement plan","Assumption log","Issue log", "Risk register" });
            p2.SetTools(new List<string>() { "Brainstorming", "Questionnaires and surveys", "Document analysis",
            "Stakeholder analysis", "Stakeholder mapping-representation", "Meetings", "Expert judgment" });
            processes.Add(p2);

            #endregion
            //**************************************************************
            #region Planning
            //**************************************************************
            Process p3 = new Process(project, "Develop Project Management Plan");
            p3.SetProcessGroup("Planning");
            p3.SetKnowledgeArea("Integration Management");
            p3.SetInputs(new List<string>() { "Project charter", "Enterprise environmental factors", "Organizational process assets" });
            p3.SetOutputsCreated(new List<string>() { "Change management plan", "Configuration management plan", 
            "Performance measurement baseline", "Project life cycle description","Development approach","Management reviews"  });
            p3.SetOutputsUpdated(new List<string>() { "Scope management plan", "Requirements management plan",
            "Schedule management plan","Cost management plan", "Quality management plan", "Resource management plan",
            "Communications management plan","Risk management plan", "Procurement management plan",
            "Stakeholder engagement plan","Scope baseline", "Schedule baseline", "Cost baseline"});
            p3.SetTools(new List<string>() { "Brainstorming", "Checklists", "Focus groups", "Interviews", "Conflict management",
            "Facilitation","Meeting management", "Meetings", "Expert judgment" });
            processes.Add(p3);
            //**************************************************************
            Process p4 = new Process(project, "Plan Scope Management");
            p4.SetProcessGroup("Planning");
            p4.SetKnowledgeArea("Scope Management");
            p4.SetInputs(new List<string>() { "Project charter", "Quality management plan", "Project life cycle description",
            "Development approach", "Enterprise environmental factors","Organizational process assets" });
            p4.SetOutputsCreated(new List<string>() { "Scope management plan", "Requirements management plan" });
            p4.SetTools(new List<string>() { "Alternatives analysis", "Meetings", "Expert judgment" });
            processes.Add(p4);
            //**************************************************************
            Process p5 = new Process(project, "Collect Requirements");
            p5.SetProcessGroup("Planning");
            p5.SetKnowledgeArea("Scope Management");
            p5.SetInputs(new List<string>() { "Project charter", "Scope management plan", "Requirements management plan",
            "Stakeholder engagement plan","Assumption log","Lessons learned register","Stakeholder register",
            "Business case","Agreements","Enterprise environmental factors","Organizational process assets"});
            p5.SetOutputsCreated(new List<string>() { "Requirements documentation", "Requirements traceability matrix" });
            p5.SetTools(new List<string>() { "Brainstorming", "Interviews", "Focus groups", "Questionnaires and surveys",
            "Benchmarking","Document analysis","Voting","Multicriteria decision analysis","Affinity diagrams","Mind mapping",
            "Nominal group technique","Observation-conversation","Facilitation","Context diagram","Prototypes","Expert judgment"});
            processes.Add(p5);
            //**************************************************************
            Process p6 = new Process(project, "Define Scope");
            p6.SetProcessGroup("Planning");
            p6.SetKnowledgeArea("Scope Management");
            p6.SetInputs(new List<string>() { "Project charter", "Scope management plan", "Requirements documentation",
            "Assumption log","Risk register","Enterprise environmental factors","Organizational process assets"});
            p6.SetOutputsCreated(new List<string>() { "Project scope statement" });
            p6.SetOutputsUpdated(new List<string>() { "Stakeholder register", "Requirements documentation", 
            "Requirements traceability matrix","Assumption log" });
            p6.SetTools(new List<string>() { "Alternatives analysis", "Multicriteria decision analysis", "Facilitation",
            "Product analysis","Expert judgment"});
            processes.Add(p6);
            //**************************************************************
            Process p7 = new Process(project, "Create WBS");
            p7.SetProcessGroup("Planning");
            p7.SetKnowledgeArea("Scope Management");
            p7.SetInputs(new List<string>() { "Scope management plan", "Project scope statement", "Requirements documentation",
            "Enterprise environmental factors","Organizational process assets"});
            p7.SetOutputsCreated(new List<string>() { "WBS", "WBS dictionary", "Scope baseline" });
            p7.SetOutputsUpdated(new List<string>() { "Assumption log", "Requirements documentation" });
            p7.SetTools(new List<string>() { "Decomposition", "Expert judgment" });
            processes.Add(p7);
            //**************************************************************
            Process p8 = new Process(project, "Plan Schedule Management");
            p8.SetProcessGroup("Planning");
            p8.SetKnowledgeArea("Schedule Management");
            p8.SetInputs(new List<string>() { "Project charter", "Scope management plan", "Development approach",
            "Enterprise environmental factors","Organizational process assets"});
            p8.SetOutputsCreated(new List<string>() { "Schedule management plan" });
            //p7.SetOutputsUpdated(new List<string>() { });
            p8.SetTools(new List<string>() { "Alternatives analysis", "Meetings", "Expert judgment" });
            processes.Add(p8);
            //**************************************************************
            Process p9 = new Process(project, "Define Activities");
            p9.SetProcessGroup("Planning");
            p9.SetKnowledgeArea("Schedule Management");
            p9.SetInputs(new List<string>() { "Schedule management plan", "Scope baseline", 
            "Enterprise environmental factors","Organizational process assets" });
            p9.SetOutputsCreated(new List<string>() { "Activity list", "Activity attributes", "Milestone list", "Change requests" });
            p9.SetOutputsUpdated(new List<string>() { "Schedule baseline", "Cost baseline" });
            p9.SetTools(new List<string>() { "Decomposition", "Rolling wave planning", "Meetings", "Expert judgment" });
            processes.Add(p9);
            //**************************************************************
            Process p10 = new Process(project, "Sequence Activities");
            p10.SetProcessGroup("Planning");
            p10.SetKnowledgeArea("Schedule Management");
            p10.SetInputs(new List<string>() { "Activity list", "Activity attributes", "Milestone list",
            "Schedule management plan","Scope baseline","Assumption log","Enterprise environmental factors",
            "Organizational process assets"});
            p10.SetOutputsCreated(new List<string>() { "Project schedule network diagrams" });
            p10.SetOutputsUpdated(new List<string>() { "Activity list", "Activity attributes", "Milestone list", "Assumption log" });
            p10.SetTools(new List<string>() { "Precedence diagramming method", "Dependency determination",
            "Leads and lags","Project management information system"});
            processes.Add(p10);
            //**************************************************************
            Process p11 = new Process(project, "Estimate Activity Resources");
            p11.SetProcessGroup("Planning");
            p11.SetKnowledgeArea("Resource Management");
            p11.SetInputs(new List<string>() { "Activity list", "Activity attributes", "Scope baseline",
            "Resource management plan","Assumption log","Cost estimates","Resource calendars","Risk register",
            "Enterprise environmental factors","Organizational process assets"});
            p11.SetOutputsCreated(new List<string>() { "Resource requirements", "Basis of estimates", "Resource breakdown structure" });
            p11.SetOutputsUpdated(new List<string>() { "Activity attributes", "Assumption log", "Lessons learned register" });
            p11.SetTools(new List<string>() { "Bottom-up estimating", "Analogous estimating", "Parametric estimating",
            "Alternatives analysis","Project management information system","Meetings","Expert judgment"});
            processes.Add(p11);
            //**************************************************************
            Process p12 = new Process(project, "Estimate Activity Durations");
            p12.SetProcessGroup("Planning");
            p12.SetKnowledgeArea("Schedule Management");
            p12.SetInputs(new List<string>() { "Activity list", "Activity attributes", "Schedule management plan",
            "Scope baseline","Assumption log","Lessons learned register","Milestone list","Project team assignments",
            "Resource breakdown structure","Resource calendars","Resource requirements","Risk register",
            "Enterprise environmental factors","Organizational process assets"});
            p12.SetOutputsCreated(new List<string>() { "Activity duration estimates", "Basis of estimates" });
            p12.SetOutputsUpdated(new List<string>() { "Activity attributes", "Assumption log", "Lessons learned register" });
            p12.SetTools(new List<string>() { "Analogous estimating", "Parametric estimating", "Bottom-up estimating",
            "Three-point estimating","Alternatives analysis","Reserve analysis","Voting","Meetings","Expert judgment"});
            processes.Add(p12);
            //**************************************************************
            Process p13 = new Process(project, "Develop Schedule");
            p13.SetProcessGroup("Planning");
            p13.SetKnowledgeArea("Schedule Management");
            p13.SetInputs(new List<string>() { "Activity list", "Activity attributes", "Activity duration estimates",
            "Scope baseline","Schedule management plan","Assumption log","Basis of estimates","Lessons learned register",
            "Milestone list","Project schedule network diagrams","Project team assignments","Resource requirements",
            "Resource calendars","Risk register","Agreements","Enterprise environmental factors",
            "Organizational process assets"});
            p13.SetOutputsCreated(new List<string>() { "Schedule baseline", "Project schedule", "Schedule data", 
            "Project calendars",
            "Change requests"});
            p13.SetOutputsUpdated(new List<string>() { "Schedule management plan", "Cost baseline", "Activity attributes",
            "Activity duration estimates","Lessons learned register","Resource requirements","Risk register","Assumption log"});
            p13.SetTools(new List<string>() { "Schedule network analysis", "Critical path method", "Resource optimization",
            "What-if scenario analysis","Simulation","Leads and lags","Schedule compression","Project management information system",
            "Agile release planning"});
            processes.Add(p13);
            //**************************************************************
            Process p15 = new Process(project, "Plan Cost Management");
            p15.SetProcessGroup("Planning");
            p15.SetKnowledgeArea("Cost Management");
            p15.SetInputs(new List<string>() { "Project charter", "Schedule management plan", "Risk management plan",
            "Enterprise environmental factors","Organizational process assets"});
            p15.SetOutputsCreated(new List<string>() { "Cost management plan" });
            //p15.SetOutputsUpdated(new List<string>() { "" });
            p15.SetTools(new List<string>() { "Alternatives analysis", "Meetings", "Expert judgment" });
            processes.Add(p15);
            //**************************************************************
            Process p16 = new Process(project, "Estimate Costs");
            p16.SetProcessGroup("Planning");
            p16.SetKnowledgeArea("Cost Management");
            p16.SetInputs(new List<string>() { "Cost management plan", "Scope baseline", "Quality management plan",
            "Project schedule","Resource requirements","Risk register","Lessons learned register",
            "Enterprise environmental factors","Organizational process assets", "Cost estimating policies"});
            p16.SetOutputsCreated(new List<string>() { "Cost estimates", "Basis of estimates" });
            p16.SetOutputsUpdated(new List<string>() { "Risk register", "Assumption log", "Lessons learned register" });
            p16.SetTools(new List<string>() { "Analogous estimating", "Parametric estimating", "Bottom-up estimating",
            "Three-point estimating","Alternatives analysis","Reserve analysis","Cost of quality",
            "Project management information system","Voting","Expert judgment"});
            processes.Add(p16);
            //**************************************************************
            Process p17 = new Process(project, "Determine Budget");
            p17.SetProcessGroup("Planning");
            p17.SetKnowledgeArea("Cost Management");
            p17.SetInputs(new List<string>() { "Cost estimates", "Cost management plan", "Resource management plan",
            "Scope baseline","Basis of estimates", "Project schedule","Risk register","Business case",
            "Benefits management plan","Agreements", "Enterprise environmental factors","Organizational process assets"});
            p17.SetOutputsCreated(new List<string>() { "Cost baseline", "Project funding requirements" });
            p17.SetOutputsUpdated(new List<string>() { "Cost estimates", "Project schedule", "Risk register" });
            p17.SetTools(new List<string>() { "Cost aggregation", "Reserve analysis", "Historical information review",
            "Funding limit reconciliation","Financing","Expert judgment"});
            processes.Add(p17);
            //**************************************************************
            Process p18 = new Process(project, "Plan Quality Management");
            p18.SetProcessGroup("Planning");
            p18.SetKnowledgeArea("Quality Management");
            p18.SetInputs(new List<string>() { "Project charter", "Requirements management plan", "Risk management plan",
            "Stakeholder engagement plan","Scope baseline","Assumption log","Requirements documentation",
            "Requirements traceability matrix","Risk register","Stakeholder register",
            "Enterprise environmental factors","Organizational process assets"});
            p18.SetOutputsCreated(new List<string>() { "Quality management plan", "Quality metrics" });
            p18.SetOutputsUpdated(new List<string>() { "Risk management plan", "Scope baseline", "Stakeholder register",
            "Risk register","Requirements traceability matrix","Lessons learned register"});
            p18.SetTools(new List<string>() { "Benchmarking", "Brainstorming", "Interviews", "Cost-benefit analysis",
            "Cost of quality","Multicriteria decision analysis","Flowcharts","Logical data model","Matrix diagrams",
            "Mind mapping","Test and inspection planning","Meetings","Expert judgment"});
            processes.Add(p18);



            //**************************************************************
            //Process p100 = new Process(project, "");
            //p100.SetProcessGroup("");
            //p100.SetKnowledgeArea("");
            //p100.SetInputs(new List<string>() {"" });
            //p100.SetOutputsCreated(new List<string>() {"" });
            //p100.SetOutputsUpdated(new List<string>() {"" });
            //p100.SetTools(new List<string>() {"" });
            //processes.Add(p100);

            #endregion
            //**************************************************************
            return processes;
        
        
        }
    }
}
