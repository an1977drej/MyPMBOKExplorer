using System.Collections.Generic;

namespace MyPMBOKExplorer
{
    public static  class CreatorKnowledgeAreas
    {
        public static List<KnowledgeArea> Create()
        {
            List<KnowledgeArea> knowledgeArea = new List<KnowledgeArea>() 
            {
                new KnowledgeArea() { Name = "Integration Management" },
                new KnowledgeArea() { Name = "Scope Management" },
                new KnowledgeArea() { Name = "Schedule Management" },
                new KnowledgeArea() { Name = "Cost Management" },
                new KnowledgeArea() { Name = "Quality Management" },
                new KnowledgeArea() { Name = "Resource Management" },
                new KnowledgeArea() { Name = "Communications Management" },
                new KnowledgeArea() { Name = "Risk Management" },
                new KnowledgeArea() { Name = "Procurement Management" },
                new KnowledgeArea() { Name = "Stakeholder Management" }
            };
            return knowledgeArea;
        }
    }
}
