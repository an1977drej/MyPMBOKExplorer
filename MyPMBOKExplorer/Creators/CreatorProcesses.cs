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
            //**************************************************************
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
            Process p19 = new Process(project, "Plan Resource Management");
            p19.SetProcessGroup("Planning");
            p19.SetKnowledgeArea("Resource Management");
            p19.SetInputs(new List<string>() { "Project charter", "Quality management plan", "Scope baseline",
            "Project schedule","Requirements documentation","Stakeholder register","Risk register",
            "Enterprise environmental factors","Organizational process assets"});
            p19.SetOutputsCreated(new List<string>() { "Resource management plan", "Team charter" });
            p19.SetOutputsUpdated(new List<string>() { "Risk register", "Assumption log" });
            p19.SetTools(new List<string>() { "Hierarchical charts", "Responsibility assignment matrix", "Text-oriented formats",
            "Organizational theory","Meetings","Expert judgment"});
            processes.Add(p19);
            //**************************************************************
            Process p20 = new Process(project, "Plan Communications Management");
            p20.SetProcessGroup("Planning");
            p20.SetKnowledgeArea("Communications Management");
            p20.SetInputs(new List<string>() { "Project charter", "Resource management plan", "Stakeholder engagement plan",
            "Requirements documentation","Stakeholder register","Enterprise environmental factors","Organizational process assets"});
            p20.SetOutputsCreated(new List<string>() { "Communications management plan" });
            p20.SetOutputsUpdated(new List<string>() { "Stakeholder engagement plan", "Stakeholder register", "Project schedule" });
            p20.SetTools(new List<string>() { "Communication methods", "Communication models", "Communication requirements analysis",
            "Communication styles assessment","Communication technology","Cultural awareness","Political awareness",
            "Stakeholder engagement assessment matrix","Meetings","Expert judgment"});
            processes.Add(p20);
            //**************************************************************
            Process p21 = new Process(project, "Plan Stakeholder Engagement");
            p21.SetProcessGroup("Planning");
            p21.SetKnowledgeArea("Stakeholder Management");
            p21.SetInputs(new List<string>() { "Project charter", "Resource management plan", "Communications management plan",
            "Risk management plan","Stakeholder register","Risk register","Project schedule","Assumption log","Change log",
            "Issue log","Agreements","Enterprise environmental factors","Organizational process assets"});
            p21.SetOutputsCreated(new List<string>() { "Stakeholder engagement plan" });
            //p21.SetOutputsUpdated(new List<string>() { "" });
            p21.SetTools(new List<string>() { "Assumption and constraint analysis", "Benchmarking", "Mind mapping",
            "Root cause analysis","Stakeholder engagement assessment matrix","Prioritization-ranking","Meetings","Expert judgment"});
            processes.Add(p21);
            //**************************************************************
            Process p22 = new Process(project, "Plan Risk Management");
            p22.SetProcessGroup("Planning");
            p22.SetKnowledgeArea("Risk Management");
            p22.SetInputs(new List<string>() { "Project charter", "Scope management plan", "Scope baseline",
            "Requirements management plan","Schedule management plan","Schedule baseline","Cost management plan",
            "Cost baseline","Performance measurement baseline","Quality management plan","Resource management plan",
            "Communications management plan","Stakeholder engagement plan","Stakeholder register",
            "Risk management plan","Procurement management plan","Change management plan","Configuration management plan",
            "Project life cycle description","Development approach","Management reviews",
            "Enterprise environmental factors","Organizational process assets"});
            p22.SetOutputsCreated(new List<string>() { "Risk management plan" });
            //p22.SetOutputsUpdated(new List<string>() { "" });
            p22.SetTools(new List<string>() { "Stakeholder analysis", "Meetings", "Expert judgment" });
            processes.Add(p22);
            //**************************************************************
            Process p23 = new Process(project, "Identify Risks");
            p23.SetProcessGroup("Planning");
            p23.SetKnowledgeArea("Risk Management");
            p23.SetInputs(new List<string>() { "Requirements management plan", "Requirements documentation", "Schedule management plan",
            "Cost management plan","Quality management plan","Resource management plan","Resource requirements",
            "Risk management plan","Scope baseline","Schedule baseline","Cost baseline","Cost estimates",
            "Activity duration estimates","Stakeholder register","Procurement management plan","Procurement strategy",
            "Procurement statement of work","Bid documents","Assumption log","Issue log","Agreements",
            "Lessons learned register","Enterprise environmental factors","Organizational process assets"});
            p23.SetOutputsCreated(new List<string>() { "Risk register", "Risk report" });
            p23.SetOutputsUpdated(new List<string>() { "Lessons learned register", "Issue log", "Assumption log" });
            p23.SetTools(new List<string>() { "Brainstorming", "Checklists", "Interviews", "Root cause analysis",
            "SWOT analysis","Document analysis","Assumption and constraint analysis","Facilitation",
            "Prompt lists","Meetings","Expert judgment"});
            processes.Add(p23);
            //**************************************************************
            Process p24 = new Process(project, "Perform Qualitative Risk Analysis");
            p24.SetProcessGroup("Planning");
            p24.SetKnowledgeArea("Risk Management");
            p24.SetInputs(new List<string>() { "Risk register", "Risk management plan", "Stakeholder register","Assumption log",
            "Enterprise environmental factors","Organizational process assets"});
            //p24.SetOutputsCreated(new List<string>() { "" });
            p24.SetOutputsUpdated(new List<string>() { "Risk report", "Risk register", "Assumption log", "Issue log" });
            p24.SetTools(new List<string>() { "Interviews", "Risk data quality assessment", "Risk probability and impact assessment",
            "Assessment of other risk parameters","Probability and impact matrix","Hierarchical charts","Risk categorization",
            "Facilitation","Meetings","Expert judgment"});
            processes.Add(p24);
            //**************************************************************
            Process p25 = new Process(project, "Perform Quantitative Risk Analysis");
            p25.SetProcessGroup("Planning");
            p25.SetKnowledgeArea("Risk Management");
            p25.SetInputs(new List<string>() { "Risk register", "Risk report", "Risk management plan", "Scope baseline",
            "Schedule baseline","Activity duration estimates","Schedule forecasts","Cost baseline","Cost estimates",
            "Cost forecasts","Basis of estimates","Assumption log","Milestone list","Resource requirements",
            "Enterprise environmental factors","Organizational process assets"});
            //p25.SetOutputsCreated(new List<string>() { "" });
            p25.SetOutputsUpdated(new List<string>() { "Risk report" });
            p25.SetTools(new List<string>() { "Interviews", "Facilitation", "Representations of uncertainty", "Simulation",
            "Sensitivity analysis","Decision tree analysis","Influence diagrams","Expert judgment"});
            processes.Add(p25);
            //**************************************************************
            Process p26 = new Process(project, "Plan Risk Responses");
            p26.SetProcessGroup("Planning");
            p26.SetKnowledgeArea("Risk Management");
            p26.SetInputs(new List<string>() { "Risk management plan", "Resource management plan", "Risk report", "Risk register",
            "Cost baseline","Stakeholder register","Project schedule","Resource calendars","Project team assignments",
            "Lessons learned register","Enterprise environmental factors","Organizational process assets"});
            p26.SetOutputsCreated(new List<string>() { "Change requests" });
            p26.SetOutputsUpdated(new List<string>() { "Risk register", "Risk report", "Schedule management plan",
            "Cost management plan","Quality management plan","Resource management plan","Procurement management plan",
            "Scope baseline","Schedule baseline","Cost baseline","Assumption log","Cost forecasts","Lessons learned register",
            "Project schedule","Project team assignments"});
            p26.SetTools(new List<string>() { "Interviews", "Facilitation", "Strategies for threats", "Strategies for opportunities",
            "Contingent response strategies","Strategies for overall project risk","Alternatives analysis",
            "Cost-benefit analysis","Multicriteria decision analysis","Expert judgment"});
            processes.Add(p26);
            //**************************************************************
            Process p27 = new Process(project, "Plan Procurement Management");
            p27.SetProcessGroup("Planning");
            p27.SetKnowledgeArea("Procurement Management");
            p27.SetInputs(new List<string>() { "Project charter", "Business case", "Benefits management plan",
            "Scope management plan","Quality management plan","Resource management plan","Scope baseline","Milestone list",
            "Project team assignments","Requirements documentation","Requirements traceability matrix","Resource requirements",
            "Stakeholder register","Risk register","Enterprise environmental factors","Organizational process assets"});
            p27.SetOutputsCreated(new List<string>() { "Procurement management plan", "Procurement strategy", "Bid documents",
            "Procurement statement of work","Source selection criteria","Make-or-buy decisions","Independent cost estimates"});
            p27.SetOutputsUpdated(new List<string>() { "Stakeholder register", "Risk register", "Requirements documentation",
            "Requirements traceability matrix","Milestone list","Lessons learned register","Organizational process assets"});
            p27.SetTools(new List<string>() { "Market research", "Make-or-buy analysis", "Source selection analysis", "Meetings",
            "Expert judgment"});
            processes.Add(p27);
            #endregion
            //**************************************************************
            #region Executing
            Process p28 = new Process(project, "Direct and Manage Project Work");
            p28.SetProcessGroup("Executing");
            p28.SetKnowledgeArea("Integration Management");
            p28.SetInputs(new List<string>() { "Scope management plan", "Requirements management plan", "Schedule management plan",
            "Cost management plan","Quality management plan","Resource management plan","Communications management plan",
            "Stakeholder engagement plan","Risk management plan","Procurement management plan","Change management plan",
            "Configuration management plan","Scope baseline","Schedule baseline","Cost baseline","Performance measurement baseline",
            "Project life cycle description","Development approach","Management reviews","Change log","Lessons learned register",
            "Milestone list","Project communications","Project schedule","Requirements traceability matrix","Risk register",
            "Risk report","Approved change requests","Enterprise environmental factors","Organizational process assets"});
            p28.SetOutputsCreated(new List<string>() { "Work performance data", "Deliverables", "Issue log" });
            p28.SetOutputsUpdated(new List<string>() { "Any project management plan component", "Scope management plan",
            "Requirements management plan","Schedule management plan","Cost management plan","Quality management plan",
            "Communications management plan","Resource management plan","Stakeholder engagement plan","Risk management plan",
            "Procurement management plan","Scope baseline","Schedule baseline","Cost baseline","Performance measurement baseline",
            "Change management plan","Configuration management plan","Project life cycle description","Development approach",
            "Management reviews","Activity list","Assumption log","Lessons learned register","Requirements documentation",
            "Risk register","Stakeholder register","Organizational process assets"});
            p28.SetTools(new List<string>() { "Meetings", "Project management information system", "Expert judgment" });
            processes.Add(p28);
            //**************************************************************
            Process p29 = new Process(project, "Manage Project Knowledge");
            p29.SetProcessGroup("Executing");
            p29.SetKnowledgeArea("Integration Management");
            p29.SetInputs(new List<string>() { "Scope management plan", "Requirements management plan",
            "Schedule management plan","Cost management plan","Quality management plan","Resource management plan",
            "Communications management plan","Stakeholder engagement plan","Risk management plan","Procurement management plan",
            "Change management plan","Configuration management plan","Scope baseline","Schedule baseline","Cost baseline",
            "Performance measurement baseline","Project life cycle description","Development approach","Management reviews",
            "Lessons learned register","Project team assignments","Resource breakdown structure","Source selection criteria",
            "Stakeholder register","Deliverables","Enterprise environmental factors","Organizational process assets"});
            p29.SetOutputsCreated(new List<string>() { "Lessons learned register" });
            p29.SetOutputsUpdated(new List<string>() { "Scope management plan", "Requirements management plan",
            "Schedule management plan","Cost management plan","Quality management plan","Communications management plan",
            "Resource management plan","Stakeholder engagement plan","Risk management plan","Procurement management plan",
            "Scope baseline","Schedule baseline","Cost baseline","Performance measurement baseline","Change management plan",
            "Configuration management plan","Project life cycle description","Development approach","Management reviews"});
            p29.SetTools(new List<string>() { "Knowledge management", "Information management", "Active listening",
            "Expert judgment","Facilitation","Leadership","Networking","Political awareness"});
            processes.Add(p29);
            //**************************************************************
            Process p30 = new Process(project, "Acquire Resources");
            p30.SetProcessGroup("Executing");
            p30.SetKnowledgeArea("Resource Management");
            p30.SetInputs(new List<string>() { "Resource management plan", "Procurement management plan", "Cost baseline",
            "Project schedule","Stakeholder register","Resource requirements","Resource calendars",
            "Enterprise environmental factors","Organizational process assets"});
            p30.SetOutputsCreated(new List<string>() { "Project team assignments", "Physical resource assignments",
            "Resource calendars","Change requests"});
            p30.SetOutputsUpdated(new List<string>() { "Stakeholder register", "Risk register", "Resource requirements",
            "Resource breakdown structure","Project schedule","Lessons learned register","Cost baseline","Resource management plan"});
            p30.SetTools(new List<string>() { "Multicriteria decision analysis", "Negotiation", "Pre-assignment", "Virtual teams" });
            processes.Add(p30);
            //**************************************************************
            Process p31 = new Process(project, "Develop Team");
            p31.SetProcessGroup("Executing");
            p31.SetKnowledgeArea("Resource Management");
            p31.SetInputs(new List<string>() { "Resource management plan", "Project team assignments", "Team charter",
            "Resource calendars","Project schedule","Lessons learned register","Enterprise environmental factors",
            "Organizational process assets"});
            p31.SetOutputsCreated(new List<string>() { "Team performance assessments", "Change requests" });
            p31.SetOutputsUpdated(new List<string>() { "Team charter", "Resource calendars", "Project team assignments",
            "Project schedule","Lessons learned register","Resource management plan","Enterprise environmental factors",
            "Organizational process assets"});
            p31.SetTools(new List<string>() { "Colocation", "Virtual teams", "Communication technology",
            "Conflict management","Influencing","Motivation","Negotiation","Team building","Recognition and rewards",
            "Training","Individual and team assessments", "Meetings"});
            processes.Add(p31);
            //**************************************************************
            Process p32 = new Process(project, "Manage Team");
            p32.SetProcessGroup("Executing");
            p32.SetKnowledgeArea("Resource Management");
            p32.SetInputs(new List<string>() { "Resource management plan", "Team charter", "Project team assignments",
            "Team performance assessments","Work performance reports","Lessons learned register","Issue log",
            "Enterprise environmental factors","Organizational process assets"});
            p32.SetOutputsCreated(new List<string>() { "Change requests" });
            p32.SetOutputsUpdated(new List<string>() { "Project team assignments", "Resource management plan", "Issue log",
            "Cost baseline","Schedule baseline","Lessons learned register","Enterprise environmental factors"});
            p32.SetTools(new List<string>() { "Conflict management", "Decision making", "Emotional intelligence", "Influencing",
            "Leadership","Project management information system"});
            processes.Add(p32);
            //**************************************************************
            Process p33 = new Process(project, "Manage Quality");
            p33.SetProcessGroup("Executing");
            p33.SetKnowledgeArea("Quality Management");
            p33.SetInputs(new List<string>() { "Quality management plan", "Quality metrics", "Quality control measurements",
            "Risk report","Lessons learned register","Organizational process assets"});
            p33.SetOutputsCreated(new List<string>() { "Quality reports", "Test and evaluation documents", "Change requests" });
            p33.SetOutputsUpdated(new List<string>() { "Risk register", "Lessons learned register", "Scope baseline", "Schedule baseline",
            "Cost baseline","Quality management plan","Issue log"});
            p33.SetTools(new List<string>() { "Checklists", "Alternatives analysis", "Document analysis", "Process analysis",
            "Root cause analysis","Multicriteria decision analysis","Affinity diagrams","Cause-and-effect diagrams",
            "Flowcharts","Histograms","Matrix diagrams","Scatter diagrams","Audits","Design for X","Problem solving",
            "Quality improvement methods"});
            processes.Add(p33);
            //**************************************************************
            Process p34 = new Process(project, "Implement Risk Responses");
            p34.SetProcessGroup("Executing");
            p34.SetKnowledgeArea("Risk Management");
            p34.SetInputs(new List<string>() { "Risk management plan", "Risk report", "Risk register", "Lessons learned register",
            "Organizational process assets"});
            p34.SetOutputsCreated(new List<string>() { "Change requests" });
            p34.SetOutputsUpdated(new List<string>() { "Risk report", "Risk register", "Project team assignments",
            "Lessons learned register","Issue log"});
            p34.SetTools(new List<string>() { "Influencing", "Project management information system", "Expert judgment" });
            processes.Add(p34);
            //**************************************************************
            Process p35 = new Process(project, "Manage Communications");
            p35.SetProcessGroup("Executing");
            p35.SetKnowledgeArea("Communications Management");
            p35.SetInputs(new List<string>() { "Communications management plan", "Resource management plan",
            "Stakeholder engagement plan","Stakeholder register","Quality reports","Risk report","Work performance reports",
            "Change log","Issue log","Lessons learned register","Enterprise environmental factors","Organizational process assets"});
            p35.SetOutputsCreated(new List<string>() { "Project communications" });
            p35.SetOutputsUpdated(new List<string>() { "Stakeholder register", "Risk register", "Project schedule", "Lessons learned register",
            "Issue log","Stakeholder engagement plan","Communications management plan","Organizational process assets"});
            p35.SetTools(new List<string>() { "Communication methods", "Communication technology", "Communication competence",
            "Feedback","Nonverbal communication","Presentations","Project management information system","Project reporting",
            "Active listening","Conflict management","Cultural awareness","Meeting management","Networking","Political awareness","Meetings"});
            processes.Add(p35);
            //**************************************************************
            Process p36 = new Process(project, "Manage Stakeholder Engagement");
            p36.SetProcessGroup("Executing");
            p36.SetKnowledgeArea("Stakeholder Management");
            p36.SetInputs(new List<string>() { "Communications management plan", "Stakeholder engagement plan", "Stakeholder register",
            "Risk management plan","Change management plan","Issue log","Change log","Lessons learned register",
            "Enterprise environmental factors","Organizational process assets"});
            p36.SetOutputsCreated(new List<string>() { "Change requests" });
            p36.SetOutputsUpdated(new List<string>() { "Stakeholder register", "Stakeholder engagement plan",
            "Communications management plan","Lessons learned register","Issue log","Change log"});
            p36.SetTools(new List<string>() { "Conflict management", "Cultural awareness", "Expert judgment",
            "Feedback","Ground rules","Meetings","Negotiation","Observation-conversation","Political awareness"});
            processes.Add(p36);
            //**************************************************************
            Process p37 = new Process(project, "Conduct Procurements");
            p37.SetProcessGroup("Executing");
            p37.SetKnowledgeArea("Procurement Management");
            p37.SetInputs(new List<string>() { "Procurement management plan", "Scope management plan",
            "Requirements management plan","Requirements documentation","Communications management plan",
            "Stakeholder register","Risk management plan","Risk register","Configuration management plan","Cost baseline",
            "Project schedule","Seller proposals","Procurement strategy","Procurement statement of work","Bid documents",
            "Lessons learned register","Enterprise environmental factors","Organizational process assets"});
            p37.SetOutputsCreated(new List<string>() { "Selected sellers", "Agreements" });
            p37.SetOutputsUpdated(new List<string>() { "Stakeholder register", "Risk register", "Resource calendars",
            "Requirements traceability matrix","Requirements documentation","Lessons learned register","Cost baseline",
            "Schedule baseline","Scope baseline","Procurement management plan","Risk management plan","Communications management plan",
            "Quality management plan","Requirements management plan","Organizational process assets"});
            p37.SetTools(new List<string>() { "Advertising", "Bidder conferences", "Proposal evaluation", "Negotiation", "Expert judgment" });
            processes.Add(p37);

            #endregion

            //**************************************************************
            #region Monitoring and Controlling
            
            //**************************************************************
            Process p38 = new Process(project, "Monitor and Control Project Work");
            p38.SetProcessGroup("Monitoring");
            p38.SetKnowledgeArea("Integration Management");
            p38.SetInputs(new List<string>() { "Scope management plan", "Communications management plan", "Requirements management plan",
            "Stakeholder engagement plan","Schedule management plan","Risk management plan","Cost management plan",
            "Quality management plan","Resource management plan","Procurement management plan","Change management plan",
            "Configuration management plan","Scope baseline","Schedule baseline","Cost baseline","Performance measurement baseline",
            "Project life cycle description","Development approach","Management reviews","Assumption log","Basis of estimates",
            "Cost forecasts","Issue log","Lessons learned register","Milestone list","Quality reports","Risk register",
            "Risk report","Schedule forecasts","Work performance information"});
            p38.SetOutputsCreated(new List<string>() { "Work performance reports", "Change requests" });
            p38.SetOutputsUpdated(new List<string>() { "Scope management plan", "Requirements management plan",
            "Schedule management plan","Cost management plan","Quality management plan","Communications management plan",
            "Resource management plan","Stakeholder engagement plan","Risk management plan","Procurement management plan",
            "Scope baseline","Schedule baseline","Cost baseline","Performance measurement baseline","Change management plan",
            "Configuration management plan","Project life cycle description","Development approach","Management reviews",
            "Cost forecasts","Issue log","Lessons learned register","Risk register","Schedule forecasts"});
            p38.SetTools(new List<string>() { "Alternatives analysis", "Cost-benefit analysis", "Earned value analysis",
            "Variance analysis","Root cause analysis","Trend analysis","Voting","Meetings","Expert judgment"});
            processes.Add(p38);
            //**************************************************************
            Process p39 = new Process(project, "Perform Integrated Change Control");
            p39.SetProcessGroup("Monitoring");
            p39.SetKnowledgeArea("Integration Management");
            p39.SetInputs(new List<string>() { "Change requests", "Change management plan", "Configuration management plan",
            "Scope baseline","Schedule baseline","Cost baseline","Basis of estimates","Requirements traceability matrix",
            "Risk report","Work performance reports","Enterprise environmental factors","Organizational process assets"});
            p39.SetOutputsCreated(new List<string>() { "Approved change requests", "Change log" });
            p39.SetOutputsUpdated(new List<string>() { "Scope management plan", "Requirements management plan",
            "Schedule management plan","Cost management plan","Quality management plan","Communications management plan",
            "Resource management plan","Stakeholder engagement plan","Risk management plan","Procurement management plan",
            "Scope baseline","Schedule baseline","Cost baseline","Performance measurement baseline",
            "Change management plan","Configuration management plan","Project life cycle description","Development approach",
            "Management reviews","Change log"});
            p39.SetTools(new List<string>() { "Change control tools", "Alternatives analysis", "Cost-benefit analysis",
            "Autocratic decision making","Multicriteria decision analysis","Voting","Meetings","Expert judgment"});
            processes.Add(p39);
            //**************************************************************
            Process p40 = new Process(project, "Control Resources");
            p40.SetProcessGroup("Monitoring");
            p40.SetKnowledgeArea("Resource Management");
            p40.SetInputs(new List<string>() { "Resource management plan", "Issue log", "Lessons learned register",
            "Physical resource assignments","Project schedule","Resource breakdown structure","Resource requirements",
            "Risk register","Work performance data","Agreements","Organizational process assets"});
            p40.SetOutputsCreated(new List<string>() { "Work performance information", "Change requests" });
            p40.SetOutputsUpdated(new List<string>() { "Resource management plan", "Schedule baseline", "Cost baseline", "Assumption log",
            "Issue log","Lessons learned register","Physical resource assignments","Resource breakdown structure","Risk register"});
            p40.SetTools(new List<string>() { "Alternatives analysis", "Cost-benefit analysis", "Performance reviews",
            "Trend analysis","Problem solving","Influencing","Negotiation","Project management information system"});
            processes.Add(p40);
            //**************************************************************
            Process p41 = new Process(project, "Control Scope");
            p41.SetProcessGroup("Monitoring");
            p41.SetKnowledgeArea("Scope Management");
            p41.SetInputs(new List<string>() { "Scope management plan", "Requirements management plan", "Change management plan",
            "Configuration management plan","Scope baseline","Performance measurement baseline","Lessons learned register",
            "Requirements documentation","Requirements traceability matrix","Work performance data","Organizational process assets"});
            p41.SetOutputsCreated(new List<string>() { "Work performance information", "Change requests" });
            p41.SetOutputsUpdated(new List<string>() { "Scope management plan", "Scope baseline", "Schedule baseline", "Cost baseline",
            "Performance measurement baseline","Lessons learned register","Requirements documentation","Requirements traceability matrix"});
            p41.SetTools(new List<string>() { "Variance analysis", "Trend analysis" });
            processes.Add(p41);
            //**************************************************************
            Process p42 = new Process(project, "Control Schedule");
            p42.SetProcessGroup("Monitoring");
            p42.SetKnowledgeArea("Schedule Management");
            p42.SetInputs(new List<string>() { "Schedule management plan", "Schedule baseline", "Scope baseline",
            "Performance measurement baseline","Lessons learned register","Project calendars","Project schedule","Resource calendars",
            "Schedule data","Work performance data","Organizational process assets"});
            p42.SetOutputsCreated(new List<string>() { "Work performance information", "Schedule forecasts", "Change requests" });
            p42.SetOutputsUpdated(new List<string>() { "Schedule management plan", "Schedule baseline", "Cost baseline",
            "Performance measurement baseline","Assumption log","Basis of estimates","Lessons learned register","Project schedule",
            "Resource calendars","Risk register","Schedule data"});
            p42.SetTools(new List<string>() { "Earned value analysis", "Iteration burndown chart", "Performance reviews",
            "Variance analysis","Trend analysis","What-if scenario analysis","Critical path method", "Project management information system",
            "Resource optimization","Leads and lags","Schedule compression"});
            processes.Add(p42);
            //**************************************************************
            Process p43 = new Process(project, "Control Costs");
            p43.SetProcessGroup("Monitoring");
            p43.SetKnowledgeArea("Cost Management");
            p43.SetInputs(new List<string>() { "Cost management plan", "Cost baseline", "Performance measurement baseline",
            "Lessons learned register","Project funding requirements","Work performance data","Organizational process assets"});
            p43.SetOutputsCreated(new List<string>() { "Work performance information", "Cost forecasts", "Change requests" });
            p43.SetOutputsUpdated(new List<string>() { "Cost management plan", "Cost estimates", "Basis of estimates",
            "Cost baseline","Performance measurement baseline","Assumption log","Lessons learned register","Risk register"});
            p43.SetTools(new List<string>() { "Earned value analysis", "Expert judgment", "Project management information system",
            "Reserve analysis","To-complete performance index","Trend analysis","Variance analysis"});
            processes.Add(p43);
            //**************************************************************
            Process p44 = new Process(project, "Control Quality");
            p44.SetProcessGroup("Monitoring");
            p44.SetKnowledgeArea("Quality Management");
            p44.SetInputs(new List<string>() { "Quality management plan", "Lessons learned register", "Quality metrics",
            "Test and evaluation documents","Approved change requests","Deliverables","Work performance data",
            "Enterprise environmental factors","Organizational process assets"});
            p44.SetOutputsCreated(new List<string>() { "Work performance information", "Quality control measurements",
            "Verified deliverables","Change requests"});
            p44.SetOutputsUpdated(new List<string>() { "Quality management plan", "Test and evaluation documents", "Risk register",
            "Lessons learned register","Issue log"});
            p44.SetTools(new List<string>() { "Checklists", "Check sheets", "Statistical sampling", "Questionnaires and surveys",
            "Performance reviews","Root cause analysis","Inspection","Testing/product evaluations","Cause-and-effect diagrams",
            "Control charts","Histograms","Scatter diagrams","Meetings"});
            processes.Add(p44);
            //**************************************************************
            Process p45 = new Process(project, "Validate Scope");
            p45.SetProcessGroup("Monitoring");
            p45.SetKnowledgeArea("Scope Management");
            p45.SetInputs(new List<string>() { "Scope management plan", "Requirements management plan", "Scope baseline",
            "Lessons learned register","Quality reports","Requirements documentation","Requirements traceability matrix",
            "Verified deliverables","Work performance data"});
            p45.SetOutputsCreated(new List<string>() { "Work performance information", "Accepted deliverables", "Change requests" });
            p45.SetOutputsUpdated(new List<string>() { "Requirements documentation", "Requirements traceability matrix",
            "Lessons learned register"});
            p45.SetTools(new List<string>() { "Inspection", "Voting" });
            processes.Add(p45);
            //**************************************************************
            Process p46 = new Process(project, "Monitor Communications");
            p46.SetProcessGroup("Monitoring");
            p46.SetKnowledgeArea("Communications Management");
            p46.SetInputs(new List<string>() { "Resource management plan", "Communications management plan", "Stakeholder engagement plan",
            "Issue log","Lessons learned register","Project communications","Work performance data","Enterprise environmental factors",
            "Organizational process assets"});
            p46.SetOutputsCreated(new List<string>() { "Work performance information", "Change requests" });
            p46.SetOutputsUpdated(new List<string>() { "Stakeholder engagement plan", "Stakeholder register", "Communications management plan",
            "Lessons learned register","Issue log"});
            p46.SetTools(new List<string>() { "Stakeholder engagement assessment matrix", "Observation-conversation",
            "Project management information system","Meetings","Expert judgment"});
            processes.Add(p46);
            //**************************************************************
            Process p47 = new Process(project, "Monitor Stakeholder Engagement");
            p47.SetProcessGroup("Monitoring");
            p47.SetKnowledgeArea("Stakeholder Management");
            p47.SetInputs(new List<string>() { "Resource management plan", "Communications management plan", "Stakeholder engagement plan",
            "Issue log","Lessons learned register","Project communications","Risk register","Stakeholder register","Work performance data",
            "Enterprise environmental factors","Organizational process assets"});
            p47.SetOutputsCreated(new List<string>() { "Work performance information", "Change requests" });
            p47.SetOutputsUpdated(new List<string>() { "Resource management plan", "Communications management plan",
            "Stakeholder engagement plan","Issue log","Lessons learned register","Risk register","Stakeholder register"});
            p47.SetTools(new List<string>() { "Alternatives analysis", "Root cause analysis", "Stakeholder analysis",
            "Multicriteria decision analysis","Voting","Stakeholder engagement assessment matrix","Feedback","Presentations",
            "Active listening","Cultural awareness","Leadership","Networking","Political awareness","Meetings"});
            processes.Add(p47);
            //**************************************************************
            Process p48 = new Process(project, "Monitor Risks");
            p48.SetProcessGroup("Monitoring");
            p48.SetKnowledgeArea("Risk Management");
            p48.SetInputs(new List<string>() { "Risk management plan", "Issue log", "Lessons learned register", "Risk register",
            "Risk report","Work performance data","Work performance reports"});
            p48.SetOutputsCreated(new List<string>() { "Work performance information", "Change requests" });
            p48.SetOutputsUpdated(new List<string>() { "Scope management plan", "Requirements management plan", "Schedule management plan",
            "Cost management plan","Quality management plan","Communications management plan","Resource management plan",
            "Stakeholder engagement plan","Risk management plan","Procurement management plan","Scope baseline","Schedule baseline",
            "Cost baseline","Performance measurement baseline","Change management plan","Configuration management plan","Project life cycle description",
            "Development approach","Management reviews","Assumption log","Issue log","Lessons learned register","Risk register","Risk report",
            "Organizational process assets"});
            p48.SetTools(new List<string>() { "Audits", "Technical performance analysis", "Reserve analysis", "Meetings" });
            processes.Add(p48);
            //**************************************************************
            Process p49 = new Process(project, "Control Procurements");
            p49.SetProcessGroup("Monitoring");
            p49.SetKnowledgeArea("Procurement Management");
            p49.SetInputs(new List<string>() { "Requirements management plan", "Risk management plan", "Procurement management plan",
            "Change management plan","Schedule baseline","Assumption log","Lessons learned register","Milestone list",
            "Quality reports","Requirements documentation","Requirements traceability matrix","Risk register","Stakeholder register",
            "Agreements","Procurement strategy","Procurement statement of work","Bid documents","Work performance data",
            "Approved change requests","Enterprise environmental factors","Organizational process assets","Procurement policies"});
            p49.SetOutputsCreated(new List<string>() { "Work performance information", "Closed procurements", "Change requests" });
            p49.SetOutputsUpdated(new List<string>() { "Risk management plan", "Procurement management plan", "Schedule baseline",
            "Cost baseline","Lessons learned register","Resource requirements","Requirements traceability matrix","Risk register",
            "Stakeholder register","Bid documents","Independent cost estimates","Make-or-buy decisions","Procurement strategy",
            "Source selection criteria","Procurement statement of work"});
            p49.SetTools(new List<string>() { "Claims administration", "Performance reviews", "Earned value analysis",
            "Trend analysis","Inspection","Audits","Expert judgment"});
            processes.Add(p49);

            #endregion
            //**************************************************************

            #region Closing
            //**************************************************************
            Process p50 = new Process(project, "Close Project or Phase");
            p50.SetProcessGroup("Closing");
            p50.SetKnowledgeArea("Integration Management");
            p50.SetInputs(new List<string>() { "Project charter", "Scope management plan", "Stakeholder engagement plan",
            "Communications management plan","Requirements management plan","Risk management plan","Cost management plan",
            "Schedule management plan","Quality management plan","Resource management plan","Procurement management plan",
            "Change management plan","Configuration management plan","Scope baseline","Schedule baseline","Cost baseline",
            "Performance measurement baseline","Project life cycle description","Development approach","Management reviews",
            "Assumption log","Basis of estimates","Change log","Issue log","Lessons learned register","Milestone list",
            "Project communications","Quality control measurements","Quality reports","Requirements documentation",
            "Risk register","Risk report","Accepted deliverables","Business case","Benefits management plan",
            "Agreements","Bid documents","Independent cost estimates","Make-or-buy decisions","Procurement statement of work",
            "Procurement strategy","Source selection criteria","Organizational process assets"});
            p50.SetOutputsCreated(new List<string>() { "Final product, service, or result transition", "Final report" });
            p50.SetOutputsUpdated(new List<string>() { "Lessons learned register", "Organizational process assets" });
            p50.SetTools(new List<string>() { "Variance analysis", "Document analysis", "Trend analysis", "Regression analysis",
            "Meetings","Expert judgment"});
            processes.Add(p50);
            #endregion

            return processes;
        
        
        }
    }
}
