using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
    public class TreeViewSetuper2
    {
        frmMain m_frmMain;
        private BrightIdeasSoftware.TreeListView m_treeListView2;
        private BrightIdeasSoftware.OLVColumn m_olvColumnName;
        private BrightIdeasSoftware.OLVColumn m_olvColumnPartOf;
        private string m_platzhalter = "";

        public TreeViewSetuper2(frmMain frmMain)
        {
            m_frmMain = frmMain;
            m_treeListView2 = m_frmMain.treeListView2;
            CreateColumns();
            CanExpandGetter(m_treeListView2);
            ChildrenGetter(m_treeListView2);
            SetupColumnsText();
            SetupColumnsImage();
            m_treeListView2.SelectionChanged += m_treeListView2_SelectionChanged;
        }
        
        public void CreateColumns()
        {
            m_olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            m_olvColumnName.AspectName = "Name";
            m_olvColumnName.Text = "Process Entities";
            m_olvColumnName.Width = 350;

            m_olvColumnPartOf = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            m_olvColumnPartOf.AspectName = "PartOf";
            m_olvColumnPartOf.Text = "Par of";
            m_olvColumnPartOf.Width = 0;

            m_treeListView2.AllColumns.Add(m_olvColumnName);
            m_treeListView2.AllColumns.Add(m_olvColumnPartOf);
            m_treeListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { m_olvColumnName, m_olvColumnPartOf });
        }
        private void CanExpandGetter(BrightIdeasSoftware.TreeListView mytreeListView)
        {
            mytreeListView.CanExpandGetter = delegate (object x)
            {
                if (x is Inputs || x is Outputs || x is Tools || x is Document || x is Tool)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                //return x is StromKreis;
            };
        }
        private void ChildrenGetter(BrightIdeasSoftware.TreeListView mytreeListView)
        {
            mytreeListView.ChildrenGetter = delegate (object x)
            {
                try
                {
                    if (x is Inputs)
                    {
                        return ((Inputs)x).Items;
                    }
                    if (x is Outputs)
                    {
                        return ((Outputs)x).Items;
                    }
                    if (x is Tools)
                    {
                        return ((Tools)x).Items;
                    }
                    if (x is Document doc)
                    {
                        List<DocFile> docFile = new List<DocFile>();
                        string[] files = Directory.GetFiles(doc.FolderPath, "*", SearchOption.AllDirectories);
                        foreach (var item in files)
                        {
                            docFile.Add(new DocFile() {FilePath = item });
                        }
                        return docFile;
                    }
                    if (x is Tool tool)
                    {
                        List<Tool> toolFile = new List<Tool>();
                        foreach (var item in Directory.GetFiles(tool.FolderPath, "*", SearchOption.AllDirectories))
                        {
                            toolFile.Add(new Tool() { Name = Path.GetFileName(item) });
                        }
                        return toolFile;
                    }

                    else
                    {
                        return new ArrayList();
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    //this.BeginInvoke((MethodInvoker)delegate ()
                    //{
                    mytreeListView.Collapse(x);
                    //    MessageBox.Show(this, ex.Message, "ObjectListViewDemo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //});
                    return new ArrayList();
                }
            };
        }
        private void SetupColumnsText()
        {
            m_olvColumnPartOf.AspectGetter = delegate (object x)
            {
                if (x is Document document)
                {
                    return document.PartOf;
                }
                else
                {
                    return m_platzhalter;
                }
            };
        }
        private void SetupColumnsImage()
        {
            m_olvColumnName.ImageGetter = delegate (object x)
            {
                if (x is Tools)
                {
                    Tools p = (Tools)x;
                    return Properties.Resources.Tools1.ResizeBitmap(20, 20);
                }
                if (x is Inputs)
                {
                    
                    return Properties.Resources.Input.ResizeBitmap(20, 20);
                }
                if (x is Outputs)
                {

                    return Properties.Resources.Output.ResizeBitmap(20, 20);
                }
                if (x is DocFile doc)
                {
                   return doc.Icon;
                }

                else
                {
                    return "";
                }
            };
        }
        public void ShowDocuments(Project currentProject)
        {
            m_treeListView2.RemoveObjects((ICollection)m_treeListView2.Objects);
            m_treeListView2.GetColumn(0).Text = "Documents";
            var result = currentProject.ProcessEntities.Where(x => x.GetType() == typeof(Document)).ToList();
            m_treeListView2.AddObjects(result);
            m_treeListView2.CollapseAll();
        }
        public void ShowTools(Project currentProject)
        {
            m_treeListView2.RemoveObjects((ICollection)m_treeListView2.Objects);
            m_treeListView2.GetColumn(0).Text = "Tools";
            var result = currentProject.ProcessEntities.Where(x => x.GetType() == typeof(Tool)).ToList();
            m_treeListView2.AddObjects(result);
            m_treeListView2.CollapseAll();
        }

        private void m_treeListView2_SelectionChanged(object sender, EventArgs e)
        {
            Object selObj = m_treeListView2.SelectedObject;
            if (selObj is IProcessEntity entity)
            {
                m_frmMain.myDocViewer1.UnloadMyDoc();
                m_frmMain.toolStripStatusLabelPath.Text = entity.FolderPath;
                m_frmMain.toolStripSplitButtonSettings.Visible = true;
            }
            else if (selObj is DocFile docFile)
            {
                m_frmMain.ClearStatusStrip2();
                m_frmMain.myDocViewer1.LoadMyDoc(docFile.FilePath);
            }
            else
            {
                m_frmMain.myDocViewer1.UnloadMyDoc();
                m_frmMain.ClearStatusStrip2();
            }
        }
    }
}
