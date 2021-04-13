using System;
using System.Collections;
using System.Linq;
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
            m_treeViewSetuper1 = new TreeViewSetuper1(this);
            m_treeViewSetuper2 = new TreeViewSetuper2(this);
            ClearStatusStrip2();
            statusStrip2.Renderer = new CustomRendererForToolStrip();

        }

        private void LoadProject()
        {
            if (m_currentProject!=null)
            {
                SaveToFile(m_currentProject.FilePath);
            }
            treeListView1.RemoveObjects((ICollection)treeListView1.Objects);
            treeListView2.RemoveObjects((ICollection)treeListView2.Objects);
            treeListView1.AddObject(m_currentProject);
            treeListView1.ExpandAll();
        }

        #region ToolStrip1
        private void toolStrip1ButtonNew_Click(object sender, EventArgs e)
        {
            CreateNew();
        }
        private void toolStrip1ButtonOpenProject_Click(object sender, EventArgs e)
        {
            OpenFromFile();
        }
        private void toolStrip1ButtonSaveProject_Click(object sender, EventArgs e)
        {
            if (m_currentProject != null)
            {
                string filePath = SaveDialog(m_currentProject.Name, m_currentProject.FolderPath);
                if (!String.IsNullOrEmpty(filePath))
                {
                    SaveToFile(filePath);
                } 
            }
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
        //*************************************************************
        private void CreateNew()
        {
            string filePath = SaveDialog("PMP Project", "");
            if (!String.IsNullOrEmpty(filePath))
            {
                m_currentProject = CreatorProject.GetNewProject(filePath);
                LoadProject();
            }
        }
        private void OpenFromFile()
        {
            //TODO: open async
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PMP Project files (*.abprj)|*.abprj|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    m_currentProject = CreatorProject.GetSavedProject(filePath);
                    LoadProject();
                }
            }
        }
        private string SaveDialog(string fileName, string folderPath)
        {
            string filePaht = "";
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = fileName;
            sf.InitialDirectory = folderPath;
            sf.Filter = "PMP Project files (*.abprj)|*.abprj|All files (*.*)|*.*";
            //sf.CheckFileExists = false;
            if (sf.ShowDialog() == DialogResult.OK)
            {
                filePaht = sf.FileName;
            }
            return filePaht;
        }
        private void SaveToFile(string filePath)
        {
            MyXMLSerializer.SerializeObject<Project>(m_currentProject, filePath);
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

        private void ToolStripMenuItemSetNewPath_Click(object sender, EventArgs e)
        {
            object selObj = treeListView2.SelectedObject;
            if (selObj is ProcessEntity processEntity)
            {
                var dlg = new FolderPicker();
                //dlg.InputPath = @"c:\windows\system32";
                if (dlg.ShowDialog(this.Handle) == true)
                {
                    string folderPath = dlg.ResultPath;
                    var projectProcessEntity = m_currentProject.ProcessEntities.FirstOrDefault(x => x.Name == processEntity.Name);
                    if (projectProcessEntity != null)
                    {
                        projectProcessEntity.FolderPath = folderPath;
                        processEntity.FolderPath = folderPath;
                        toolStripStatusLabelPath.Text = folderPath;
                        //MessageBox.Show( folderPath);
                    }
                }
            }
        }
    }
}
