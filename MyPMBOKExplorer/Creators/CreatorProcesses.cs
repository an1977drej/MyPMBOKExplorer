using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
    public static class CreatorProcesses
    {

        public static List<Process> Create(Project m_Project)
        {
            List<Process> m_Processes = new List<Process>();
            //**************************************************************
            #region Initiating
            Process p1 = new Process(m_Project, "Develop Project Charter");
            p1.AssignToProcessGroup("Initiating");
            p1.AssignToKnowledgeArea("Integration Management");
            p1.AssignToInputs(new List<string>() { "Business case", "Benefits management plan", "Agreements",
            "Enterprise environmental factors","Organizational process assets"});
            p1.AssignToOutputsCreated(new List<string>() { "Project charter", "Assumption log" });
            p1.AssignToTools(new List<string>() { "Brainstorming", "Focus groups", "Interviews", 
            "Conflict management", "Facilitation", "Meeting management","Meetings","Expert judgment" });
            m_Processes.Add(p1);
            //*************************************************************
            Process p2 = new Process(m_Project, "Identify Stakeholders");
            p2.AssignToProcessGroup("Initiating");
            p2.AssignToKnowledgeArea("Stakeholder Management");
            p2.AssignToInputs(new List<string>() { "Project charter", "Business case", "Benefits management plan",
            "Communications management plan","Stakeholder engagement plan","Change log","Issue log","Requirements documentation",
            "Agreements", "Enterprise environmental factors","Organizational process assets" });
            p2.AssignToOutputsCreated(new List<string>() { "Stakeholder register", "Change requests"});
            p2.AssignToOutputsUpdated(new List<string>() {"Requirements management plan","Communications management plan",
            "Risk management plan","Stakeholder engagement plan","Assumption log","Issue log", "Risk register" });
            p2.AssignToTools(new List<string>() { "Brainstorming", "Questionnaires and surveys", "Document analysis",
            "Stakeholder analysis", "Stakeholder mapping-representation", "Meetings", "Expert judgment" });
            m_Processes.Add(p2);

            #endregion
            //**************************************************************
            #region Planning
            //**************************************************************
            Process p3 = new Process(m_Project, "Develop Project Management Plan");
            p3.AssignToProcessGroup("Planning");
            p3.AssignToKnowledgeArea("Integration Management");
            p3.AssignToInputs(new List<string>() { "Project charter", "Enterprise environmental factors", "Organizational process assets" });
            p3.AssignToOutputsCreated(new List<string>() { "Change management plan", "Configuration management plan", 
            "Performance measurement baseline", "Project life cycle description","Development approach","Management reviews"  });
            p3.AssignToOutputsUpdated(new List<string>() { "Scope management plan", "Requirements management plan",
            "Schedule management plan","Cost management plan", "Quality management plan", "Resource management plan",
            "Communications management plan","Risk management plan", "Procurement management plan",
            "Stakeholder engagement plan","Scope baseline", "Schedule baseline", "Cost baseline"});
            p3.AssignToTools(new List<string>() { "Brainstorming", "Checklists", "Focus groups", "Interviews", "Conflict management",
            "Facilitation","Meeting management", "Meetings", "Expert judgment" });
            m_Processes.Add(p3);
            //**************************************************************
            Process p4 = new Process(m_Project, "Plan Scope Management");
            p4.AssignToProcessGroup("Planning");
            p4.AssignToKnowledgeArea("Scope Management");
            p4.AssignToInputs(new List<string>() { "Project charter", "Quality management plan", "Project life cycle description",
            "Development approach", "Enterprise environmental factors","Organizational process assets" });
            p4.AssignToOutputsCreated(new List<string>() { "Scope management plan", "Requirements management plan" });
            p4.AssignToTools(new List<string>() { "Alternatives analysis", "Meetings", "Expert judgment" });
            m_Processes.Add(p4);
            //**************************************************************
            Process p5 = new Process(m_Project, "Collect Requirements");
            p5.AssignToProcessGroup("Planning");
            p5.AssignToKnowledgeArea("Scope Management");
            p5.AssignToInputs(new List<string>() { "Project charter", "Scope management plan", "Requirements management plan",
            "Stakeholder engagement plan","Assumption log","Lessons learned register","Stakeholder register",
            "Business case","Agreements","Enterprise environmental factors","Organizational process assets"});
            p5.AssignToOutputsCreated(new List<string>() { "Requirements documentation", "Requirements traceability matrix" });
            p5.AssignToTools(new List<string>() { "Brainstorming", "Interviews", "Focus groups", "Questionnaires and surveys",
            "Benchmarking","Document analysis","Voting","Multicriteria decision analysis","Affinity diagrams","Mind mapping",
            "Nominal group technique","Observation-conversation","Facilitation","Context diagram","Prototypes","Expert judgment"});
            m_Processes.Add(p5);
            //**************************************************************
            Process p6 = new Process(m_Project, "Define Scope");
            p6.AssignToProcessGroup("Planning");
            p6.AssignToKnowledgeArea("Scope Management");
            p6.AssignToInputs(new List<string>() { "Project charter", "Scope management plan", "Requirements documentation",
            "Assumption log","Risk register","Enterprise environmental factors","Organizational process assets"});
            p6.AssignToOutputsCreated(new List<string>() { "Project scope statement" });
            p6.AssignToOutputsUpdated(new List<string>() { "Stakeholder register", "Requirements documentation", 
            "Requirements traceability matrix","Assumption log" });
            p6.AssignToTools(new List<string>() { "Alternatives analysis", "Multicriteria decision analysis", "Facilitation",
            "Product analysis","Expert judgment"});
            m_Processes.Add(p6);
            //**************************************************************
            Process p7 = new Process(m_Project, "Create WBS");
            p7.AssignToProcessGroup("Planning");
            p7.AssignToKnowledgeArea("Scope Management");
            p7.AssignToInputs(new List<string>() { "Scope management plan", "Project scope statement", "Requirements documentation",
            "Enterprise environmental factors","Organizational process assets"});
            p7.AssignToOutputsCreated(new List<string>() { "WBS", "WBS dictionary", "Scope baseline" });
            p7.AssignToOutputsUpdated(new List<string>() { "Assumption log", "Requirements documentation" });
            p7.AssignToTools(new List<string>() { "Decomposition", "Expert judgment" });
            m_Processes.Add(p7);
            //**************************************************************
            Process p8 = new Process(m_Project, "Plan Schedule Management");
            p8.AssignToProcessGroup("Planning");
            p8.AssignToKnowledgeArea("Schedule Management");
            p8.AssignToInputs(new List<string>() { "Project charter", "Scope management plan", "Development approach",
            "Enterprise environmental factors","Organizational process assets"});
            p8.AssignToOutputsCreated(new List<string>() { "Schedule management plan" });
            //p7.SetOutputsUpdated(new List<string>() { });
            p8.AssignToTools(new List<string>() { "Alternatives analysis", "Meetings", "Expert judgment" });
            m_Processes.Add(p8);
            //**************************************************************
            Process p9 = new Process(m_Project, "Define Activities");
            p9.AssignToProcessGroup("Planning");
            p9.AssignToKnowledgeArea("Schedule Management");
            p9.AssignToInputs(new List<string>() { "Schedule management plan", "Scope baseline", 
            "Enterprise environmental factors","Organizational process assets" });
            p9.AssignToOutputsCreated(new List<string>() { "Activity list", "Activity attributes", "Milestone list", "Change requests" });
            p9.AssignToOutputsUpdated(new List<string>() { "Schedule baseline", "Cost baseline" });
            p9.AssignToTools(new List<string>() { "Decomposition", "Rolling wave planning", "Meetings", "Expert judgment" });
            m_Processes.Add(p9);
            //**************************************************************
            Process p10 = new Process(m_Project, "Sequence Activities");
            p10.AssignToProcessGroup("Planning");
            p10.AssignToKnowledgeArea("Schedule Management");
            p10.AssignToInputs(new List<string>() { "Activity list", "Activity attributes", "Milestone list",
            "Schedule management plan","Scope baseline","Assumption log","Enterprise environmental factors",
            "Organizational process assets"});
            p10.AssignToOutputsCreated(new List<string>() { "Project schedule network diagrams" });
            p10.AssignToOutputsUpdated(new List<string>() { "Activity list", "Activity attributes", "Milestone list", "Assumption log" });
            p10.AssignToTools(new List<string>() { "Precedence diagramming method", "Dependency determination",
            "Leads and lags","Project management information system"});
            m_Processes.Add(p10);
            //**************************************************************
            Process p11 = new Process(m_Project, "Estimate Activity Resources");
            p11.AssignToProcessGroup("Planning");
            p11.AssignToKnowledgeArea("Resource Management");
            p11.AssignToInputs(new List<string>() { "Activity list", "Activity attributes", "Scope baseline",
            "Resource management plan","Assumption log","Cost estimates","Resource calendars","Risk register",
            "Enterprise environmental factors","Organizational process assets"});
            p11.AssignToOutputsCreated(new List<string>() { "Resource requirements", "Basis of estimates", "Resource breakdown structure" });
            p11.AssignToOutputsUpdated(new List<string>() { "Activity attributes", "Assumption log", "Lessons learned register" });
            p11.AssignToTools(new List<string>() { "Bottom-up estimating", "Analogous estimating", "Parametric estimating",
            "Alternatives analysis","Project management information system","Meetings","Expert judgment"});
            m_Processes.Add(p11);
            //**************************************************************
            Process p12 = new Process(m_Project, "Estimate Activity Durations");
            p12.AssignToProcessGroup("Planning");
            p12.AssignToKnowledgeArea("Schedule Management");
            p12.AssignToInputs(new List<string>() { "Activity list", "Activity attributes", "Schedule management plan",
            "Scope baseline","Assumption log","Lessons learned register","Milestone list","Project team assignments",
            "Resource breakdown structure","Resource calendars","Resource requirements","Risk register",
            "Enterprise environmental factors","Organizational process assets"});
            p12.AssignToOutputsCreated(new List<string>() { "Activity duration estimates", "Basis of estimates" });
            p12.AssignToOutputsUpdated(new List<string>() { "Activity attributes", "Assumption log", "Lessons learned register" });
            p12.AssignToTools(new List<string>() { "Analogous estimating", "Parametric estimating", "Bottom-up estimating",
            "Three-point estimating","Alternatives analysis","Reserve analysis","Voting","Meetings","Expert judgment"});
            m_Processes.Add(p12);
            //**************************************************************
            Process p13 = new Process(m_Project, "Develop Schedule");
            p13.AssignToProcessGroup("Planning");
            p13.AssignToKnowledgeArea("Schedule Management");
            p13.AssignToInputs(new List<string>() { "Activity list", "Activity attributes", "Activity duration estimates",
            "Scope baseline","Schedule management plan","Assumption log","Basis of estimates","Lessons learned register",
            "Milestone list","Project schedule network diagrams","Project team assignments","Resource requirements",
            "Resource calendars","Risk register","Agreements","Enterprise environmental factors",
            "Organizational process assets"});
            p13.AssignToOutputsCreated(new List<string>() { "Schedule baseline", "Project schedule", "Schedule data", 
            "Project calendars",
            "Change requests"});
            p13.AssignToOutputsUpdated(new List<string>() { "Schedule management plan", "Cost baseline", "Activity attributes",
            "Activity duration estimates","Lessons learned register","Resource requirements","Risk register","Assumption log"});
            p13.AssignToTools(new List<string>() { "Schedule network analysis", "Critical path method", "Resource optimization",
            "What-if scenario analysis","Simulation","Leads and lags","Schedule compression","Project management information system",
            "Agile release planning"});
            m_Processes.Add(p13);
            //**************************************************************
            Process p15 = new Process(m_Project, "Plan Cost Management");
            p15.AssignToProcessGroup("Planning");
            p15.AssignToKnowledgeArea("Cost Management");
            p15.AssignToInputs(new List<string>() { "Project charter", "Schedule management plan", "Risk management plan",
            "Enterprise environmental factors","Organizational process assets"});
            p15.AssignToOutputsCreated(new List<string>() { "Cost management plan" });
            //p15.SetOutputsUpdated(new List<string>() { "" });
            p15.AssignToTools(new List<string>() { "Alternatives analysis", "Meetings", "Expert judgment" });
            m_Processes.Add(p15);
            //**************************************************************
            Process p16 = new Process(m_Project, "Estimate Costs");
            p16.AssignToProcessGroup("Planning");
            p16.AssignToKnowledgeArea("Cost Management");
            p16.AssignToInputs(new List<string>() { "Cost management plan", "Scope baseline", "Quality management plan",
            "Project schedule","Resource requirements","Risk register","Lessons learned register",
            "Enterprise environmental factors","Organizational process assets", "Cost estimating policies"});
            p16.AssignToOutputsCreated(new List<string>() { "Cost estimates", "Basis of estimates" });
            p16.AssignToOutputsUpdated(new List<string>() { "Risk register", "Assumption log", "Lessons learned register" });
            p16.AssignToTools(new List<string>() { "Analogous estimating", "Parametric estimating", "Bottom-up estimating",
            "Three-point estimating","Alternatives analysis","Reserve analysis","Cost of quality",
            "Project management information system","Voting","Expert judgment"});
            m_Processes.Add(p16);
            //**************************************************************
            Process p17 = new Process(m_Project, "Determine Budget");
            p17.AssignToProcessGroup("Planning");
            p17.AssignToKnowledgeArea("Cost Management");
            p17.AssignToInputs(new List<string>() { "Cost estimates", "Cost management plan", "Resource management plan",
            "Scope baseline","Basis of estimates", "Project schedule","Risk register","Business case",
            "Benefits management plan","Agreements", "Enterprise environmental factors","Organizational process assets"});
            p17.AssignToOutputsCreated(new List<string>() { "Cost baseline", "Project funding requirements" });
            p17.AssignToOutputsUpdated(new List<string>() { "Cost estimates", "Project schedule", "Risk register" });
            p17.AssignToTools(new List<string>() { "Cost aggregation", "Reserve analysis", "Historical information review",
            "Funding limit reconciliation","Financing","Expert judgment"});
            m_Processes.Add(p17);
            //**************************************************************
            Process p18 = new Process(m_Project, "Plan Quality Management");
            p18.AssignToProcessGroup("Planning");
            p18.AssignToKnowledgeArea("Quality Management");
            p18.AssignToInputs(new List<string>() { "Project charter", "Requirements management plan", "Risk management plan",
            "Stakeholder engagement plan","Scope baseline","Assumption log","Requirements documentation",
            "Requirements traceability matrix","Risk register","Stakeholder register",
            "Enterprise environmental factors","Organizational process assets"});
            p18.AssignToOutputsCreated(new List<string>() { "Quality management plan", "Quality metrics" });
            p18.AssignToOutputsUpdated(new List<string>() { "Risk management plan", "Scope baseline", "Stakeholder register",
            "Risk register","Requirements traceability matrix","Lessons learned register"});
            p18.AssignToTools(new List<string>() { "Benchmarking", "Brainstorming", "Interviews", "Cost-benefit analysis",
            "Cost of quality","Multicriteria decision analysis","Flowcharts","Logical data model","Matrix diagrams",
            "Mind mapping","Test and inspection planning","Meetings","Expert judgment"});
            m_Processes.Add(p18);
            //**************************************************************
            Process p19 = new Process(m_Project, "Plan Resource Management");
            p19.AssignToProcessGroup("Planning");
            p19.AssignToKnowledgeArea("Resource Management");
            p19.AssignToInputs(new List<string>() { "Project charter", "Quality management plan", "Scope baseline",
            "Project schedule","Requirements documentation","Stakeholder register","Risk register",
            "Enterprise environmental factors","Organizational process assets"});
            p19.AssignToOutputsCreated(new List<string>() { "Resource management plan", "Team charter" });
            p19.AssignToOutputsUpdated(new List<string>() { "Risk register", "Assumption log" });
            p19.AssignToTools(new List<string>() { "Hierarchical charts", "Responsibility assignment matrix", "Text-oriented formats",
            "Organizational theory","Meetings","Expert judgment"});
            m_Processes.Add(p19);
            //**************************************************************
            Process p20 = new Process(m_Project, "Plan Communications Management");
            p20.AssignToProcessGroup("Planning");
            p20.AssignToKnowledgeArea("Communications Management");
            p20.AssignToInputs(new List<string>() { "Project charter", "Resource management plan", "Stakeholder engagement plan",
            "Requirements documentation","Stakeholder register","Enterprise environmental factors","Organizational process assets"});
            p20.AssignToOutputsCreated(new List<string>() { "Communications management plan" });
            p20.AssignToOutputsUpdated(new List<string>() { "Stakeholder engagement plan", "Stakeholder register", "Project schedule" });
            p20.AssignToTools(new List<string>() { "Communication methods", "Communication models", "Communication requirements analysis",
            "Communication styles assessment","Communication technology","Cultural awareness","Political awareness",
            "Stakeholder engagement assessment matrix","Meetings","Expert judgment"});
            m_Processes.Add(p20);
            //**************************************************************
            Process p21 = new Process(m_Project, "Plan Stakeholder Engagement");
            p21.AssignToProcessGroup("Planning");
            p21.AssignToKnowledgeArea("Stakeholder Management");
            p21.AssignToInputs(new List<string>() { "Project charter", "Resource management plan", "Communications management plan",
            "Risk management plan","Stakeholder register","Risk register","Project schedule","Assumption log","Change log",
            "Issue log","Agreements","Enterprise environmental factors","Organizational process assets"});
            p21.AssignToOutputsCreated(new List<string>() { "Stakeholder engagement plan" });
            //p21.SetOutputsUpdated(new List<string>() { "" });
            p21.AssignToTools(new List<string>() { "Assumption and constraint analysis", "Benchmarking", "Mind mapping",
            "Root cause analysis","Stakeholder engagement assessment matrix","Prioritization-ranking","Meetings","Expert judgment"});
            m_Processes.Add(p21);
            //**************************************************************
            Process p22 = new Process(m_Project, "Plan Risk Management");
            p22.AssignToProcessGroup("Planning");
            p22.AssignToKnowledgeArea("Risk Management");
            p22.AssignToInputs(new List<string>() { "Project charter", "Scope management plan", "Scope baseline",
            "Requirements management plan","Schedule management plan","Schedule baseline","Cost management plan",
            "Cost baseline","Performance measurement baseline","Quality management plan","Resource management plan",
            "Communications management plan","Stakeholder engagement plan","Stakeholder register",
            "Risk management plan","Procurement management plan","Change management plan","Configuration management plan",
            "Project life cycle description","Development approach","Management reviews",
            "Enterprise environmental factors","Organizational process assets"});
            p22.AssignToOutputsCreated(new List<string>() { "Risk management plan" });
            //p22.SetOutputsUpdated(new List<string>() { "" });
            p22.AssignToTools(new List<string>() { "Stakeholder analysis", "Meetings", "Expert judgment" });
            m_Processes.Add(p22);
            //**************************************************************
            Process p23 = new Process(m_Project, "Identify Risks");
            p23.AssignToProcessGroup("Planning");
            p23.AssignToKnowledgeArea("Risk Management");
            p23.AssignToInputs(new List<string>() { "Requirements management plan", "Requirements documentation", "Schedule management plan",
            "Cost management plan","Quality management plan","Resource management plan","Resource requirements",
            "Risk management plan","Scope baseline","Schedule baseline","Cost baseline","Cost estimates",
            "Activity duration estimates","Stakeholder register","Procurement management plan","Procurement strategy",
            "Procurement statement of work","Bid documents","Assumption log","Issue log","Agreements",
            "Lessons learned register","Enterprise environmental factors","Organizational process assets"});
            p23.AssignToOutputsCreated(new List<string>() { "Risk register", "Risk report" });
            p23.AssignToOutputsUpdated(new List<string>() { "Lessons learned register", "Issue log", "Assumption log" });
            p23.AssignToTools(new List<string>() { "Brainstorming", "Checklists", "Interviews", "Root cause analysis",
            "SWOT analysis","Document analysis","Assumption and constraint analysis","Facilitation",
            "Prompt lists","Meetings","Expert judgment"});
            m_Processes.Add(p23);
            //**************************************************************
            Process p24 = new Process(m_Project, "Perform Qualitative Risk Analysis");
            p24.AssignToProcessGroup("Planning");
            p24.AssignToKnowledgeArea("Risk Management");
            p24.AssignToInputs(new List<string>() { "Risk register", "Risk management plan", "Stakeholder register","Assumption log",
            "Enterprise environmental factors","Organizational process assets"});
            //p24.SetOutputsCreated(new List<string>() { "" });
            p24.AssignToOutputsUpdated(new List<string>() { "Risk report", "Risk register", "Assumption log", "Issue log" });
            p24.AssignToTools(new List<string>() { "Interviews", "Risk data quality assessment", "Risk probability and impact assessment",
            "Assessment of other risk parameters","Probability and impact matrix","Hierarchical charts","Risk categorization",
            "Facilitation","Meetings","Expert judgment"});
            m_Processes.Add(p24);
            //**************************************************************
            Process p25 = new Process(m_Project, "Perform Quantitative Risk Analysis");
            p25.AssignToProcessGroup("Planning");
            p25.AssignToKnowledgeArea("Risk Management");
            p25.AssignToInputs(new List<string>() { "Risk register", "Risk report", "Risk management plan", "Scope baseline",
            "Schedule baseline","Activity duration estimates","Schedule forecasts","Cost baseline","Cost estimates",
            "Cost forecasts","Basis of estimates","Assumption log","Milestone list","Resource requirements",
            "Enterprise environmental factors","Organizational process assets"});
            //p25.SetOutputsCreated(new List<string>() { "" });
            p25.AssignToOutputsUpdated(new List<string>() { "Risk report" });
            p25.AssignToTools(new List<string>() { "Interviews", "Facilitation", "Representations of uncertainty", "Simulation",
            "Sensitivity analysis","Decision tree analysis","Influence diagrams","Expert judgment"});
            m_Processes.Add(p25);
            //**************************************************************
            Process p26 = new Process(m_Project, "Plan Risk Responses");
            p26.AssignToProcessGroup("Planning");
            p26.AssignToKnowledgeArea("Risk Management");
            p26.AssignToInputs(new List<string>() { "Risk management plan", "Resource management plan", "Risk report", "Risk register",
            "Cost baseline","Stakeholder register","Project schedule","Resource calendars","Project team assignments",
            "Lessons learned register","Enterprise environmental factors","Organizational process assets"});
            p26.AssignToOutputsCreated(new List<string>() { "Change requests" });
            p26.AssignToOutputsUpdated(new List<string>() { "Risk register", "Risk report", "Schedule management plan",
            "Cost management plan","Quality management plan","Resource management plan","Procurement management plan",
            "Scope baseline","Schedule baseline","Cost baseline","Assumption log","Cost forecasts","Lessons learned register",
            "Project schedule","Project team assignments"});
            p26.AssignToTools(new List<string>() { "Interviews", "Facilitation", "Strategies for threats", "Strategies for opportunities",
            "Contingent response strategies","Strategies for overall project risk","Alternatives analysis",
            "Cost-benefit analysis","Multicriteria decision analysis","Expert judgment"});
            m_Processes.Add(p26);
            //**************************************************************
            Process p27 = new Process(m_Project, "Plan Procurement Management");
            p27.AssignToProcessGroup("Planning");
            p27.AssignToKnowledgeArea("Procurement Management");
            p27.AssignToInputs(new List<string>() { "Project charter", "Business case", "Benefits management plan",
            "Scope management plan","Quality management plan","Resource management plan","Scope baseline","Milestone list",
            "Project team assignments","Requirements documentation","Requirements traceability matrix","Resource requirements",
            "Stakeholder register","Risk register","Enterprise environmental factors","Organizational process assets"});
            p27.AssignToOutputsCreated(new List<string>() { "Procurement management plan", "Procurement strategy", "Bid documents",
            "Procurement statement of work","Source selection criteria","Make-or-buy decisions","Independent cost estimates"});
            p27.AssignToOutputsUpdated(new List<string>() { "Stakeholder register", "Risk register", "Requirements documentation",
            "Requirements traceability matrix","Milestone list","Lessons learned register","Organizational process assets"});
            p27.AssignToTools(new List<string>() { "Market research", "Make-or-buy analysis", "Source selection analysis", "Meetings",
            "Expert judgment"});
            m_Processes.Add(p27);
            #endregion
            //**************************************************************
            #region Executing
            Process p28 = new Process(m_Project, "Direct and Manage Project Work");
            p28.AssignToProcessGroup("Executing");
            p28.AssignToKnowledgeArea("Integration Management");
            p28.AssignToInputs(new List<string>() { "Scope management plan", "Requirements management plan", "Schedule management plan",
            "Cost management plan","Quality management plan","Resource management plan","Communications management plan",
            "Stakeholder engagement plan","Risk management plan","Procurement management plan","Change management plan",
            "Configuration management plan","Scope baseline","Schedule baseline","Cost baseline","Performance measurement baseline",
            "Project life cycle description","Development approach","Management reviews","Change log","Lessons learned register",
            "Milestone list","Project communications","Project schedule","Requirements traceability matrix","Risk register",
            "Risk report","Approved change requests","Enterprise environmental factors","Organizational process assets"});
            p28.AssignToOutputsCreated(new List<string>() { "Work performance data", "Deliverables", "Issue log" });
            p28.AssignToOutputsUpdated(new List<string>() { "Any project management plan component", "Scope management plan",
            "Requirements management plan","Schedule management plan","Cost management plan","Quality management plan",
            "Communications management plan","Resource management plan","Stakeholder engagement plan","Risk management plan",
            "Procurement management plan","Scope baseline","Schedule baseline","Cost baseline","Performance measurement baseline",
            "Change management plan","Configuration management plan","Project life cycle description","Development approach",
            "Management reviews","Activity list","Assumption log","Lessons learned register","Requirements documentation",
            "Risk register","Stakeholder register","Organizational process assets"});
            p28.AssignToTools(new List<string>() { "Meetings", "Project management information system", "Expert judgment" });
            m_Processes.Add(p28);
            //**************************************************************
            Process p29 = new Process(m_Project, "Manage Project Knowledge");
            p29.AssignToProcessGroup("Executing");
            p29.AssignToKnowledgeArea("Integration Management");
            p29.AssignToInputs(new List<string>() { "Scope management plan", "Requirements management plan",
            "Schedule management plan","Cost management plan","Quality management plan","Resource management plan",
            "Communications management plan","Stakeholder engagement plan","Risk management plan","Procurement management plan",
            "Change management plan","Configuration management plan","Scope baseline","Schedule baseline","Cost baseline",
            "Performance measurement baseline","Project life cycle description","Development approach","Management reviews",
            "Lessons learned register","Project team assignments","Resource breakdown structure","Source selection criteria",
            "Stakeholder register","Deliverables","Enterprise environmental factors","Organizational process assets"});
            p29.AssignToOutputsCreated(new List<string>() { "Lessons learned register" });
            p29.AssignToOutputsUpdated(new List<string>() { "Scope management plan", "Requirements management plan",
            "Schedule management plan","Cost management plan","Quality management plan","Communications management plan",
            "Resource management plan","Stakeholder engagement plan","Risk management plan","Procurement management plan",
            "Scope baseline","Schedule baseline","Cost baseline","Performance measurement baseline","Change management plan",
            "Configuration management plan","Project life cycle description","Development approach","Management reviews"});
            p29.AssignToTools(new List<string>() { "Knowledge management", "Information management", "Active listening",
            "Expert judgment","Facilitation","Leadership","Networking","Political awareness"});
            m_Processes.Add(p29);
            //**************************************************************
            Process p30 = new Process(m_Project, "Acquire Resources");
            p30.AssignToProcessGroup("Executing");
            p30.AssignToKnowledgeArea("Resource Management");
            p30.AssignToInputs(new List<string>() { "Resource management plan", "Procurement management plan", "Cost baseline",
            "Project schedule","Stakeholder register","Resource requirements","Resource calendars",
            "Enterprise environmental factors","Organizational process assets"});
            p30.AssignToOutputsCreated(new List<string>() { "Project team assignments", "Physical resource assignments",
            "Resource calendars","Change requests"});
            p30.AssignToOutputsUpdated(new List<string>() { "Stakeholder register", "Risk register", "Resource requirements",
            "Resource breakdown structure","Project schedule","Lessons learned register","Cost baseline","Resource management plan"});
            p30.AssignToTools(new List<string>() { "Multicriteria decision analysis", "Negotiation", "Pre-assignment", "Virtual teams" });
            m_Processes.Add(p30);
            //**************************************************************
            Process p31 = new Process(m_Project, "Develop Team");
            p31.AssignToProcessGroup("Executing");
            p31.AssignToKnowledgeArea("Resource Management");
            p31.AssignToInputs(new List<string>() { "Resource management plan", "Project team assignments", "Team charter",
            "Resource calendars","Project schedule","Lessons learned register","Enterprise environmental factors",
            "Organizational process assets"});
            p31.AssignToOutputsCreated(new List<string>() { "Team performance assessments", "Change requests" });
            p31.AssignToOutputsUpdated(new List<string>() { "Team charter", "Resource calendars", "Project team assignments",
            "Project schedule","Lessons learned register","Resource management plan","Enterprise environmental factors",
            "Organizational process assets"});
            p31.AssignToTools(new List<string>() { "Colocation", "Virtual teams", "Communication technology",
            "Conflict management","Influencing","Motivation","Negotiation","Team building","Recognition and rewards",
            "Training","Individual and team assessments", "Meetings"});
            m_Processes.Add(p31);
            //**************************************************************
            Process p32 = new Process(m_Project, "Manage Team");
            p32.AssignToProcessGroup("Executing");
            p32.AssignToKnowledgeArea("Resource Management");
            p32.AssignToInputs(new List<string>() { "Resource management plan", "Team charter", "Project team assignments",
            "Team performance assessments","Work performance reports","Lessons learned register","Issue log",
            "Enterprise environmental factors","Organizational process assets"});
            p32.AssignToOutputsCreated(new List<string>() { "Change requests" });
            p32.AssignToOutputsUpdated(new List<string>() { "Project team assignments", "Resource management plan", "Issue log",
            "Cost baseline","Schedule baseline","Lessons learned register","Enterprise environmental factors"});
            p32.AssignToTools(new List<string>() { "Conflict management", "Decision making", "Emotional intelligence", "Influencing",
            "Leadership","Project management information system"});
            m_Processes.Add(p32);
            //**************************************************************
            Process p33 = new Process(m_Project, "Manage Quality");
            p33.AssignToProcessGroup("Executing");
            p33.AssignToKnowledgeArea("Quality Management");
            p33.AssignToInputs(new List<string>() { "Quality management plan", "Quality metrics", "Quality control measurements",
            "Risk report","Lessons learned register","Organizational process assets"});
            p33.AssignToOutputsCreated(new List<string>() { "Quality reports", "Test and evaluation documents", "Change requests" });
            p33.AssignToOutputsUpdated(new List<string>() { "Risk register", "Lessons learned register", "Scope baseline", "Schedule baseline",
            "Cost baseline","Quality management plan","Issue log"});
            p33.AssignToTools(new List<string>() { "Checklists", "Alternatives analysis", "Document analysis", "Process analysis",
            "Root cause analysis","Multicriteria decision analysis","Affinity diagrams","Cause-and-effect diagrams",
            "Flowcharts","Histograms","Matrix diagrams","Scatter diagrams","Audits","Design for X","Problem solving",
            "Quality improvement methods"});
            m_Processes.Add(p33);
            //**************************************************************
            Process p34 = new Process(m_Project, "Implement Risk Responses");
            p34.AssignToProcessGroup("Executing");
            p34.AssignToKnowledgeArea("Risk Management");
            p34.AssignToInputs(new List<string>() { "Risk management plan", "Risk report", "Risk register", "Lessons learned register",
            "Organizational process assets"});
            p34.AssignToOutputsCreated(new List<string>() { "Change requests" });
            p34.AssignToOutputsUpdated(new List<string>() { "Risk report", "Risk register", "Project team assignments",
            "Lessons learned register","Issue log"});
            p34.AssignToTools(new List<string>() { "Influencing", "Project management information system", "Expert judgment" });
            m_Processes.Add(p34);
            //**************************************************************
            Process p35 = new Process(m_Project, "Manage Communications");
            p35.AssignToProcessGroup("Executing");
            p35.AssignToKnowledgeArea("Communications Management");
            p35.AssignToInputs(new List<string>() { "Communications management plan", "Resource management plan",
            "Stakeholder engagement plan","Stakeholder register","Quality reports","Risk report","Work performance reports",
            "Change log","Issue log","Lessons learned register","Enterprise environmental factors","Organizational process assets"});
            p35.AssignToOutputsCreated(new List<string>() { "Project communications" });
            p35.AssignToOutputsUpdated(new List<string>() { "Stakeholder register", "Risk register", "Project schedule", "Lessons learned register",
            "Issue log","Stakeholder engagement plan","Communications management plan","Organizational process assets"});
            p35.AssignToTools(new List<string>() { "Communication methods", "Communication technology", "Communication competence",
            "Feedback","Nonverbal communication","Presentations","Project management information system","Project reporting",
            "Active listening","Conflict management","Cultural awareness","Meeting management","Networking","Political awareness","Meetings"});
            m_Processes.Add(p35);
            //**************************************************************
            Process p36 = new Process(m_Project, "Manage Stakeholder Engagement");
            p36.AssignToProcessGroup("Executing");
            p36.AssignToKnowledgeArea("Stakeholder Management");
            p36.AssignToInputs(new List<string>() { "Communications management plan", "Stakeholder engagement plan", "Stakeholder register",
            "Risk management plan","Change management plan","Issue log","Change log","Lessons learned register",
            "Enterprise environmental factors","Organizational process assets"});
            p36.AssignToOutputsCreated(new List<string>() { "Change requests" });
            p36.AssignToOutputsUpdated(new List<string>() { "Stakeholder register", "Stakeholder engagement plan",
            "Communications management plan","Lessons learned register","Issue log","Change log"});
            p36.AssignToTools(new List<string>() { "Conflict management", "Cultural awareness", "Expert judgment",
            "Feedback","Ground rules","Meetings","Negotiation","Observation-conversation","Political awareness"});
            m_Processes.Add(p36);
            //**************************************************************
            Process p37 = new Process(m_Project, "Conduct Procurements");
            p37.AssignToProcessGroup("Executing");
            p37.AssignToKnowledgeArea("Procurement Management");
            p37.AssignToInputs(new List<string>() { "Procurement management plan", "Scope management plan",
            "Requirements management plan","Requirements documentation","Communications management plan",
            "Stakeholder register","Risk management plan","Risk register","Configuration management plan","Cost baseline",
            "Project schedule","Seller proposals","Procurement strategy","Procurement statement of work","Bid documents",
            "Lessons learned register","Enterprise environmental factors","Organizational process assets"});
            p37.AssignToOutputsCreated(new List<string>() { "Selected sellers", "Agreements" });
            p37.AssignToOutputsUpdated(new List<string>() { "Stakeholder register", "Risk register", "Resource calendars",
            "Requirements traceability matrix","Requirements documentation","Lessons learned register","Cost baseline",
            "Schedule baseline","Scope baseline","Procurement management plan","Risk management plan","Communications management plan",
            "Quality management plan","Requirements management plan","Organizational process assets"});
            p37.AssignToTools(new List<string>() { "Advertising", "Bidder conferences", "Proposal evaluation", "Negotiation", "Expert judgment" });
            m_Processes.Add(p37);

            #endregion

            //**************************************************************
            #region Monitoring and Controlling
            
            //**************************************************************
            Process p38 = new Process(m_Project, "Monitor and Control Project Work");
            p38.AssignToProcessGroup("Monitoring");
            p38.AssignToKnowledgeArea("Integration Management");
            p38.AssignToInputs(new List<string>() { "Scope management plan", "Communications management plan", "Requirements management plan",
            "Stakeholder engagement plan","Schedule management plan","Risk management plan","Cost management plan",
            "Quality management plan","Resource management plan","Procurement management plan","Change management plan",
            "Configuration management plan","Scope baseline","Schedule baseline","Cost baseline","Performance measurement baseline",
            "Project life cycle description","Development approach","Management reviews","Assumption log","Basis of estimates",
            "Cost forecasts","Issue log","Lessons learned register","Milestone list","Quality reports","Risk register",
            "Risk report","Schedule forecasts","Work performance information"});
            p38.AssignToOutputsCreated(new List<string>() { "Work performance reports", "Change requests" });
            p38.AssignToOutputsUpdated(new List<string>() { "Scope management plan", "Requirements management plan",
            "Schedule management plan","Cost management plan","Quality management plan","Communications management plan",
            "Resource management plan","Stakeholder engagement plan","Risk management plan","Procurement management plan",
            "Scope baseline","Schedule baseline","Cost baseline","Performance measurement baseline","Change management plan",
            "Configuration management plan","Project life cycle description","Development approach","Management reviews",
            "Cost forecasts","Issue log","Lessons learned register","Risk register","Schedule forecasts"});
            p38.AssignToTools(new List<string>() { "Alternatives analysis", "Cost-benefit analysis", "Earned value analysis",
            "Variance analysis","Root cause analysis","Trend analysis","Voting","Meetings","Expert judgment"});
            m_Processes.Add(p38);
            //**************************************************************
            Process p39 = new Process(m_Project, "Perform Integrated Change Control");
            p39.AssignToProcessGroup("Monitoring");
            p39.AssignToKnowledgeArea("Integration Management");
            p39.AssignToInputs(new List<string>() { "Change requests", "Change management plan", "Configuration management plan",
            "Scope baseline","Schedule baseline","Cost baseline","Basis of estimates","Requirements traceability matrix",
            "Risk report","Work performance reports","Enterprise environmental factors","Organizational process assets"});
            p39.AssignToOutputsCreated(new List<string>() { "Approved change requests", "Change log" });
            p39.AssignToOutputsUpdated(new List<string>() { "Scope management plan", "Requirements management plan",
            "Schedule management plan","Cost management plan","Quality management plan","Communications management plan",
            "Resource management plan","Stakeholder engagement plan","Risk management plan","Procurement management plan",
            "Scope baseline","Schedule baseline","Cost baseline","Performance measurement baseline",
            "Change management plan","Configuration management plan","Project life cycle description","Development approach",
            "Management reviews","Change log"});
            p39.AssignToTools(new List<string>() { "Change control tools", "Alternatives analysis", "Cost-benefit analysis",
            "Autocratic decision making","Multicriteria decision analysis","Voting","Meetings","Expert judgment"});
            m_Processes.Add(p39);
            //**************************************************************
            Process p40 = new Process(m_Project, "Control Resources");
            p40.AssignToProcessGroup("Monitoring");
            p40.AssignToKnowledgeArea("Resource Management");
            p40.AssignToInputs(new List<string>() { "Resource management plan", "Issue log", "Lessons learned register",
            "Physical resource assignments","Project schedule","Resource breakdown structure","Resource requirements",
            "Risk register","Work performance data","Agreements","Organizational process assets"});
            p40.AssignToOutputsCreated(new List<string>() { "Work performance information", "Change requests" });
            p40.AssignToOutputsUpdated(new List<string>() { "Resource management plan", "Schedule baseline", "Cost baseline", "Assumption log",
            "Issue log","Lessons learned register","Physical resource assignments","Resource breakdown structure","Risk register"});
            p40.AssignToTools(new List<string>() { "Alternatives analysis", "Cost-benefit analysis", "Performance reviews",
            "Trend analysis","Problem solving","Influencing","Negotiation","Project management information system"});
            m_Processes.Add(p40);
            //**************************************************************
            Process p41 = new Process(m_Project, "Control Scope");
            p41.AssignToProcessGroup("Monitoring");
            p41.AssignToKnowledgeArea("Scope Management");
            p41.AssignToInputs(new List<string>() { "Scope management plan", "Requirements management plan", "Change management plan",
            "Configuration management plan","Scope baseline","Performance measurement baseline","Lessons learned register",
            "Requirements documentation","Requirements traceability matrix","Work performance data","Organizational process assets"});
            p41.AssignToOutputsCreated(new List<string>() { "Work performance information", "Change requests" });
            p41.AssignToOutputsUpdated(new List<string>() { "Scope management plan", "Scope baseline", "Schedule baseline", "Cost baseline",
            "Performance measurement baseline","Lessons learned register","Requirements documentation","Requirements traceability matrix"});
            p41.AssignToTools(new List<string>() { "Variance analysis", "Trend analysis" });
            m_Processes.Add(p41);
            //**************************************************************
            Process p42 = new Process(m_Project, "Control Schedule");
            p42.AssignToProcessGroup("Monitoring");
            p42.AssignToKnowledgeArea("Schedule Management");
            p42.AssignToInputs(new List<string>() { "Schedule management plan", "Schedule baseline", "Scope baseline",
            "Performance measurement baseline","Lessons learned register","Project calendars","Project schedule","Resource calendars",
            "Schedule data","Work performance data","Organizational process assets"});
            p42.AssignToOutputsCreated(new List<string>() { "Work performance information", "Schedule forecasts", "Change requests" });
            p42.AssignToOutputsUpdated(new List<string>() { "Schedule management plan", "Schedule baseline", "Cost baseline",
            "Performance measurement baseline","Assumption log","Basis of estimates","Lessons learned register","Project schedule",
            "Resource calendars","Risk register","Schedule data"});
            p42.AssignToTools(new List<string>() { "Earned value analysis", "Iteration burndown chart", "Performance reviews",
            "Variance analysis","Trend analysis","What-if scenario analysis","Critical path method", "Project management information system",
            "Resource optimization","Leads and lags","Schedule compression"});
            m_Processes.Add(p42);
            //**************************************************************
            Process p43 = new Process(m_Project, "Control Costs");
            p43.AssignToProcessGroup("Monitoring");
            p43.AssignToKnowledgeArea("Cost Management");
            p43.AssignToInputs(new List<string>() { "Cost management plan", "Cost baseline", "Performance measurement baseline",
            "Lessons learned register","Project funding requirements","Work performance data","Organizational process assets"});
            p43.AssignToOutputsCreated(new List<string>() { "Work performance information", "Cost forecasts", "Change requests" });
            p43.AssignToOutputsUpdated(new List<string>() { "Cost management plan", "Cost estimates", "Basis of estimates",
            "Cost baseline","Performance measurement baseline","Assumption log","Lessons learned register","Risk register"});
            p43.AssignToTools(new List<string>() { "Earned value analysis", "Expert judgment", "Project management information system",
            "Reserve analysis","To-complete performance index","Trend analysis","Variance analysis"});
            m_Processes.Add(p43);
            //**************************************************************
            Process p44 = new Process(m_Project, "Control Quality");
            p44.AssignToProcessGroup("Monitoring");
            p44.AssignToKnowledgeArea("Quality Management");
            p44.AssignToInputs(new List<string>() { "Quality management plan", "Lessons learned register", "Quality metrics",
            "Test and evaluation documents","Approved change requests","Deliverables","Work performance data",
            "Enterprise environmental factors","Organizational process assets"});
            p44.AssignToOutputsCreated(new List<string>() { "Work performance information", "Quality control measurements",
            "Verified deliverables","Change requests"});
            p44.AssignToOutputsUpdated(new List<string>() { "Quality management plan", "Test and evaluation documents", "Risk register",
            "Lessons learned register","Issue log"});
            p44.AssignToTools(new List<string>() { "Checklists", "Check sheets", "Statistical sampling", "Questionnaires and surveys",
            "Performance reviews","Root cause analysis","Inspection","Testing/product evaluations","Cause-and-effect diagrams",
            "Control charts","Histograms","Scatter diagrams","Meetings"});
            m_Processes.Add(p44);
            //**************************************************************
            Process p45 = new Process(m_Project, "Validate Scope");
            p45.AssignToProcessGroup("Monitoring");
            p45.AssignToKnowledgeArea("Scope Management");
            p45.AssignToInputs(new List<string>() { "Scope management plan", "Requirements management plan", "Scope baseline",
            "Lessons learned register","Quality reports","Requirements documentation","Requirements traceability matrix",
            "Verified deliverables","Work performance data"});
            p45.AssignToOutputsCreated(new List<string>() { "Work performance information", "Accepted deliverables", "Change requests" });
            p45.AssignToOutputsUpdated(new List<string>() { "Requirements documentation", "Requirements traceability matrix",
            "Lessons learned register"});
            p45.AssignToTools(new List<string>() { "Inspection", "Voting" });
            m_Processes.Add(p45);
            //**************************************************************
            Process p46 = new Process(m_Project, "Monitor Communications");
            p46.AssignToProcessGroup("Monitoring");
            p46.AssignToKnowledgeArea("Communications Management");
            p46.AssignToInputs(new List<string>() { "Resource management plan", "Communications management plan", "Stakeholder engagement plan",
            "Issue log","Lessons learned register","Project communications","Work performance data","Enterprise environmental factors",
            "Organizational process assets"});
            p46.AssignToOutputsCreated(new List<string>() { "Work performance information", "Change requests" });
            p46.AssignToOutputsUpdated(new List<string>() { "Stakeholder engagement plan", "Stakeholder register", "Communications management plan",
            "Lessons learned register","Issue log"});
            p46.AssignToTools(new List<string>() { "Stakeholder engagement assessment matrix", "Observation-conversation",
            "Project management information system","Meetings","Expert judgment"});
            m_Processes.Add(p46);
            //**************************************************************
            Process p47 = new Process(m_Project, "Monitor Stakeholder Engagement");
            p47.AssignToProcessGroup("Monitoring");
            p47.AssignToKnowledgeArea("Stakeholder Management");
            p47.AssignToInputs(new List<string>() { "Resource management plan", "Communications management plan", "Stakeholder engagement plan",
            "Issue log","Lessons learned register","Project communications","Risk register","Stakeholder register","Work performance data",
            "Enterprise environmental factors","Organizational process assets"});
            p47.AssignToOutputsCreated(new List<string>() { "Work performance information", "Change requests" });
            p47.AssignToOutputsUpdated(new List<string>() { "Resource management plan", "Communications management plan",
            "Stakeholder engagement plan","Issue log","Lessons learned register","Risk register","Stakeholder register"});
            p47.AssignToTools(new List<string>() { "Alternatives analysis", "Root cause analysis", "Stakeholder analysis",
            "Multicriteria decision analysis","Voting","Stakeholder engagement assessment matrix","Feedback","Presentations",
            "Active listening","Cultural awareness","Leadership","Networking","Political awareness","Meetings"});
            m_Processes.Add(p47);
            //**************************************************************
            Process p48 = new Process(m_Project, "Monitor Risks");
            p48.AssignToProcessGroup("Monitoring");
            p48.AssignToKnowledgeArea("Risk Management");
            p48.AssignToInputs(new List<string>() { "Risk management plan", "Issue log", "Lessons learned register", "Risk register",
            "Risk report","Work performance data","Work performance reports"});
            p48.AssignToOutputsCreated(new List<string>() { "Work performance information", "Change requests" });
            p48.AssignToOutputsUpdated(new List<string>() { "Scope management plan", "Requirements management plan", "Schedule management plan",
            "Cost management plan","Quality management plan","Communications management plan","Resource management plan",
            "Stakeholder engagement plan","Risk management plan","Procurement management plan","Scope baseline","Schedule baseline",
            "Cost baseline","Performance measurement baseline","Change management plan","Configuration management plan","Project life cycle description",
            "Development approach","Management reviews","Assumption log","Issue log","Lessons learned register","Risk register","Risk report",
            "Organizational process assets"});
            p48.AssignToTools(new List<string>() { "Audits", "Technical performance analysis", "Reserve analysis", "Meetings" });
            m_Processes.Add(p48);
            //**************************************************************
            Process p49 = new Process(m_Project, "Control Procurements");
            p49.AssignToProcessGroup("Monitoring");
            p49.AssignToKnowledgeArea("Procurement Management");
            p49.AssignToInputs(new List<string>() { "Requirements management plan", "Risk management plan", "Procurement management plan",
            "Change management plan","Schedule baseline","Assumption log","Lessons learned register","Milestone list",
            "Quality reports","Requirements documentation","Requirements traceability matrix","Risk register","Stakeholder register",
            "Agreements","Procurement strategy","Procurement statement of work","Bid documents","Work performance data",
            "Approved change requests","Enterprise environmental factors","Organizational process assets","Procurement policies"});
            p49.AssignToOutputsCreated(new List<string>() { "Work performance information", "Closed procurements", "Change requests" });
            p49.AssignToOutputsUpdated(new List<string>() { "Risk management plan", "Procurement management plan", "Schedule baseline",
            "Cost baseline","Lessons learned register","Resource requirements","Requirements traceability matrix","Risk register",
            "Stakeholder register","Bid documents","Independent cost estimates","Make-or-buy decisions","Procurement strategy",
            "Source selection criteria","Procurement statement of work"});
            p49.AssignToTools(new List<string>() { "Claims administration", "Performance reviews", "Earned value analysis",
            "Trend analysis","Inspection","Audits","Expert judgment"});
            m_Processes.Add(p49);

            #endregion
            //**************************************************************

            #region Closing
            //**************************************************************
            Process p50 = new Process(m_Project, "Close Project or Phase");
            p50.AssignToProcessGroup("Closing");
            p50.AssignToKnowledgeArea("Integration Management");
            p50.AssignToInputs(new List<string>() { "Project charter", "Scope management plan", "Stakeholder engagement plan",
            "Communications management plan","Requirements management plan","Risk management plan","Cost management plan",
            "Schedule management plan","Quality management plan","Resource management plan","Procurement management plan",
            "Change management plan","Configuration management plan","Scope baseline","Schedule baseline","Cost baseline",
            "Performance measurement baseline","Project life cycle description","Development approach","Management reviews",
            "Assumption log","Basis of estimates","Change log","Issue log","Lessons learned register","Milestone list",
            "Project communications","Quality control measurements","Quality reports","Requirements documentation",
            "Risk register","Risk report","Accepted deliverables","Business case","Benefits management plan",
            "Agreements","Bid documents","Independent cost estimates","Make-or-buy decisions","Procurement statement of work",
            "Procurement strategy","Source selection criteria","Organizational process assets"});
            p50.AssignToOutputsCreated(new List<string>() { "Final product, service, or result transition", "Final report" });
            p50.AssignToOutputsUpdated(new List<string>() { "Lessons learned register", "Organizational process assets" });
            p50.AssignToTools(new List<string>() { "Variance analysis", "Document analysis", "Trend analysis", "Regression analysis",
            "Meetings","Expert judgment"});
            m_Processes.Add(p50);
            //**************************************************************
            Process p51 = new Process(m_Project, "Close Procurements");
            p51.AssignToProcessGroup("Closing");
            p51.AssignToKnowledgeArea("Procurement Management");
            m_Processes.Add(p51);
            #endregion

            return m_Processes;
        
        
        }
    }
}
