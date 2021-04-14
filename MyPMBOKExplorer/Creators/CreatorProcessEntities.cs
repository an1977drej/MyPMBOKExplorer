using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
    public class CreatorProcessEntities
    {
        private Project m_project;
        private string m_projectRootPath;
        public CreatorProcessEntities(Project project)
        {
            m_project = project;
            m_projectRootPath = m_project.FolderPath;
        }

        private Dictionary<string, string> ListOfIOs()
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            list.Add("Accepted deliverables", "Deliverables flow");
            list.Add("Activity attributes", "Project documents");
            list.Add("Activity duration estimates", "Project documents");
            list.Add("Activity list", "Project documents");
            list.Add("Agreements", "Business Documents");
            list.Add("Approved change requests", "Change request flow");
            list.Add("Assumption log", "Project documents");
            list.Add("Basis of estimates", "Project documents");
            list.Add("Benefits management plan", "Business Documents");
            list.Add("Bid documents", "Procurements flow");
            list.Add("Business case", "Business Documents");
            list.Add("Change log", "Change request flow");
            list.Add("Change management plan", "Change request flow");
            list.Add("Change requests", "Change request flow");
            list.Add("Closed procurements", "Procurements flow");
            list.Add("Communications management plan", "Project management plan");
            list.Add("Configuration management plan", "Project management plan");
            list.Add("Cost baseline", "Project management plan");
            list.Add("Cost estimates", "Project documents");
            list.Add("Cost estimating policies", "Environmental");
            list.Add("Cost forecasts", "Project documents");
            list.Add("Cost management plan", "Project management plan");
            list.Add("Deliverables", "Deliverables flow");
            list.Add("Development approach", "Project management plan");
            list.Add("Duration estimates", "Project documents");
            list.Add("Enterprise environmental factors", "Environmental");
            list.Add("Final product, service, or result transition", "Deliverables flow");
            list.Add("Final report", "Project documents");
            list.Add("Independent cost estimates", "Procurements flow");
            list.Add("Issue log", "Project documents");
            list.Add("Lessons learned register", "Project documents");
            list.Add("Make-or-buy decisions", "Procurements flow");
            list.Add("Management reviews", "Project management plan");
            list.Add("Meeting log", "Project documents");
            list.Add("Milestone list", "Project documents");
            list.Add("Organizational process assets", "Environmental");
            list.Add("Performance measurement baseline", "Project management plan");
            list.Add("Physical resource assignments", "Project documents");
            list.Add("Procurement documentation", "Procurements flow");
            list.Add("Procurement management plan", "Project management plan");
            list.Add("Procurement statement of work", "Procurements flow");
            list.Add("Procurement strategy", "Procurements flow");
            list.Add("Project calendars", "Project documents");
            list.Add("Project charter", "Project documents");
            list.Add("Project communications", "Project documents");
            list.Add("Project documents", "Project documents");
            list.Add("Project funding requirements", "Project documents");
            list.Add("Project life cycle description", "Project management plan");
            list.Add("Project management plan", "Project management plan");
            list.Add("Project schedule", "Project documents");
            list.Add("Project schedule network diagrams", "Project documents");
            list.Add("Project scope statement", "Project documents");
            list.Add("Project team assignments", "Project documents");
            list.Add("Quality control measurements", "Project documents");
            list.Add("Quality management plan", "Project management plann");
            list.Add("Quality metrics", "Project documents");
            list.Add("Quality reports", "Project documents");
            list.Add("Requirements documentation", "Project documents");
            list.Add("Requirements management plan", "Project management plan");
            list.Add("Requirements traceability matrix", "Project documents");
            list.Add("Resource breakdown structure", "Project documents");
            list.Add("Resource calendars", "Project documents");
            list.Add("Resource management plan", "Project management plan");
            list.Add("Resource requirements", "Project documents");
            list.Add("Risk management plan", "Project management plan");
            list.Add("Risk register", "Project documents");
            list.Add("Risk report", "Project documents");
            list.Add("Schedule baseline", "Project management plan");
            list.Add("Schedule data", "Project documents");
            list.Add("Schedule forecasts", "Project documents");
            list.Add("Schedule management plan", "Project management plan");
            list.Add("Scope baseline", "Project management plan");
            list.Add("Scope management plan", "Project management plan");
            list.Add("Selected sellers", "Procurements flow");
            list.Add("Seller proposals", "Procurements flow");
            list.Add("Source selection criteria", "Project documents");
            list.Add("Stakeholder engagement plan", "Project management plan");
            list.Add("Stakeholder register", "Project documents");
            list.Add("Team charter", "Project documents");
            list.Add("Team performance assessments", "Project documents");
            list.Add("Test and evaluation documents", "Project documents");
            list.Add("Verified deliverables", "Deliverables flow");
            list.Add("WBS", "Project management plan");
            list.Add("WBS dictionary", "Project management plan");
            list.Add("Work performance data", "Work performance flow");
            list.Add("Work performance information", "Work performance flow");
            list.Add("Work performance reports", "Work performance flow");
            return list;
        }

        private List<string> ListOfTools()
        {
            List<string> tools = new List<string>();
            tools.Add("Active listening");
            tools.Add("Advertising");
            tools.Add("Affinity diagrams");
            tools.Add("Agile release planning");
            tools.Add("Alternatives analysis");
            tools.Add("Analogous estimating");
            tools.Add("Assessment of other risk parameters");
            tools.Add("Assumption and constraint analysis");
            tools.Add("Audits");
            tools.Add("Autocratic decision making");
            tools.Add("Benchmarking");
            tools.Add("Benefit-cost ratio");
            tools.Add("Bidder conferences");
            tools.Add("Bottom-up estimating");
            tools.Add("Brainstorming");
            tools.Add("Cause-and-effect diagrams");
            tools.Add("Change control tools");
            tools.Add("Check sheets");
            tools.Add("Checklists");
            tools.Add("Claims administration");
            tools.Add("Colocation");
            tools.Add("Communication competence");
            tools.Add("Communication methods");
            tools.Add("Communication models");
            tools.Add("Communication requirements analysis");
            tools.Add("Communication styles assessment");
            tools.Add("Communication technology");
            tools.Add("Conflict management");
            tools.Add("Constrained optimization methods");
            tools.Add("Context diagram");
            tools.Add("Contingent response strategies");
            tools.Add("Control charts");
            tools.Add("Cost aggregation");
            tools.Add("Cost of quality");
            tools.Add("Cost-benefit analysis");
            tools.Add("Critical path method");
            tools.Add("Cultural awareness");
            tools.Add("Decision tree analysis");
            tools.Add("Decomposition");
            tools.Add("Dependency determination");
            tools.Add("Design for X");
            tools.Add("Document analysis");
            tools.Add("Earned value analysis");
            tools.Add("Emotional intelligence");
            tools.Add("Expert judgment");
            tools.Add("Facilitation");
            tools.Add("Feedback");
            tools.Add("Financing");
            tools.Add("Flowcharts");
            tools.Add("Focus groups");
            tools.Add("Funding limit reconciliation");
            tools.Add("Ground rules");
            tools.Add("Hierarchical charts");
            tools.Add("Histograms");
            tools.Add("Historical information review");
            tools.Add("Individual and team assessments");
            tools.Add("Influence diagrams");
            tools.Add("Influencing");
            tools.Add("Information management");
            tools.Add("Inspection");
            tools.Add("Internal rate of return (IRR)");
            tools.Add("Interviews");
            tools.Add("Iteration burndown chart");
            tools.Add("Knowledge management");
            tools.Add("Leadership");
            tools.Add("Leads and lags");
            tools.Add("Logical data model");
            tools.Add("Make-or-buy analysis");
            tools.Add("Market research");
            tools.Add("Matrix diagrams");
            tools.Add("Meeting management");
            tools.Add("Meetings");
            tools.Add("Mind mapping");
            tools.Add("Motivation");
            tools.Add("Multicriteria decision analysis");
            tools.Add("Murder board");
            tools.Add("Negotiation");
            tools.Add("Net present value");
            tools.Add("Networking");
            tools.Add("Nominal group technique");
            tools.Add("Nonverbal communication");
            tools.Add("Observation-conversation");
            tools.Add("Organizational theory");
            tools.Add("Parametric estimating");
            tools.Add("Payback period");
            tools.Add("Peer review");
            tools.Add("Performance reviews");
            tools.Add("Political awareness");
            tools.Add("Pre-assignment");
            tools.Add("Precedence diagramming method");
            tools.Add("Present value");
            tools.Add("Presentations");
            tools.Add("Prioritization-ranking");
            tools.Add("Probability and impact matrix");
            tools.Add("Problem solving");
            tools.Add("Process analysis");
            tools.Add("Product analysis");
            tools.Add("Project management information system");
            tools.Add("Project reporting");
            tools.Add("Prompt lists");
            tools.Add("Proposal evaluation");
            tools.Add("Prototypes");
            tools.Add("Quality improvement methods");
            tools.Add("Questionnaires and surveys");
            tools.Add("Recognition and rewards");
            tools.Add("Regression analysis");
            tools.Add("Representations of uncertainty");
            tools.Add("Reserve analysis");
            tools.Add("Resource optimization");
            tools.Add("Responsibility assignment matrix");
            tools.Add("Risk categorization");
            tools.Add("Risk data quality assessment");
            tools.Add("Risk probability and impact assessment");
            tools.Add("Rolling wave planning");
            tools.Add("Root cause analysis");
            tools.Add("Scatter diagrams");
            tools.Add("Schedule compression");
            tools.Add("Schedule network analysis");
            tools.Add("Scoring models");
            tools.Add("Sensitivity analysis");
            tools.Add("Simulation");
            tools.Add("Source selection analysis");
            tools.Add("Stakeholder analysis");
            tools.Add("Stakeholder engagement assessment matrix");
            tools.Add("Stakeholder mapping-representation");
            tools.Add("Statistical sampling");
            tools.Add("Strategies for opportunities");
            tools.Add("Strategies for overall project risk");
            tools.Add("Strategies for threats");
            tools.Add("SWOT analysis");
            tools.Add("Team building");
            tools.Add("Technical performance analysis");
            tools.Add("Test and inspection planning");
            tools.Add("Testing-product evaluations");
            tools.Add("Text-oriented formats");
            tools.Add("Three-point estimating");
            tools.Add("To-complete performance index");
            tools.Add("Training");
            tools.Add("Trend analysis");
            tools.Add("Variance analysis");
            tools.Add("Virtual teams");
            tools.Add("Voting");
            tools.Add("What-if scenario analysis");
            return tools;
        }

        public List<ProcessEntity> Create()
        {
            List<ProcessEntity> processEntities = new List<ProcessEntity>();
            string pathDocuments = Path.Combine(m_projectRootPath,"Project Documents");
            foreach (var item in ListOfIOs())
            {
                string pathDoc = Path.Combine(pathDocuments, item.Key);
                if (!Directory.Exists(pathDoc))
                {
                    Directory.CreateDirectory(pathDoc);
                }
                Document doc = new Document() { Name = item.Key, FolderPath = pathDoc, PartOf = item.Value };
                processEntities.Add(doc);
            }
            //********************************************************************
            string pathTools = Path.Combine(m_projectRootPath, "Project Tools");
            foreach (var item in ListOfTools())
            {
                string pathTool = Path.Combine(pathTools, item);
                if (!Directory.Exists(pathTool))
                {
                    Directory.CreateDirectory(pathTool);
                }
                Tool tool = new Tool() { Name = item, FolderPath= pathTool };
                processEntities.Add(tool);
            }
            return processEntities;
        }

    }
}
