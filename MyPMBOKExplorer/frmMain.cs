using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPMBOKExplorer
{
    public partial class frmMain : Form
    {
        Project m_currentProject;
        TreeViewSetuper1 m_treeViewSetuper1;
        TreeViewSetuper2 m_treeViewSetuper2;

        public frmMain()
        {
            InitializeComponent();
            SetupGUI();
            ClearStatusStrip2();
            statusStrip2.Renderer = new CustomRendererForToolStrip();
            
        }

        private void SetupGUI()
        {
            m_treeViewSetuper1 = new TreeViewSetuper1(this);
            m_treeViewSetuper2 = new TreeViewSetuper2(this);
            m_currentProject = CreatorProject.GetProject();
            treeListView1.AddObject(m_currentProject);
            treeListView1.ExpandAll();
        }

        #region ToolStrip1
        private void toolStrip1ButtonNew_Click(object sender, EventArgs e)
        {

        }
        private void toolStrip1ButtonOpenProject_Click(object sender, EventArgs e)
        {

        }
        private void toolStrip1ButtonSaveProject_Click(object sender, EventArgs e)
        {

        }
        private void toolStrip1ButtonExpand_Click(object sender, EventArgs e)
        {
            treeListView1.ExpandAll();
        }
        private void toolStrip1ButtonCollaps_Click(object sender, EventArgs e)
        {
            foreach (var item in treeListView1.Objects)
            {
                if (item is Project project)
                {
                    foreach (var knowledgeArea in project.KnowledgeAreas)
                    {
                        treeListView1.Collapse(knowledgeArea);
                    }
                }
            }
        }
        #endregion


        #region ToolStrip 2

        private void toolStrip2ButtonShowDocuments_Click(object sender, EventArgs e)
        {
            ClearStatusStrip2();
            m_treeViewSetuper2.ShowDocuments(m_currentProject);
        }
        private void toolStrip2ButtonShowTools_Click(object sender, EventArgs e)
        {
            ClearStatusStrip2();
            m_treeViewSetuper2.ShowTools(m_currentProject);
        }
        private void toolStrip2ButtonExpand_Click(object sender, EventArgs e)
        {
            foreach (var item in treeListView2.Objects)
            {
                treeListView2.Expand(item); 
            }
        }
        private void toolStrip2ButtonCollaps_Click(object sender, EventArgs e)
        {
            foreach (var item in treeListView2.Objects)
            {
                treeListView2.Collapse(item);
            }

        }
        #endregion

        public void ClearStatusStrip2()
        {
            toolStripStatusLabelPath.Text = "";
            toolStripSplitButtonSettings.Visible = false;
        }

        private void myDocViewer1_Resize(object sender, EventArgs e)
        {
            myDocViewer1.FitPage();
        }
    }
}
