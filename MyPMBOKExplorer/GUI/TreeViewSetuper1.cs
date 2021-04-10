using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
    public class TreeViewSetuper1
    {
        private frmMain m_frmMain;
        private  BrightIdeasSoftware.TreeListView m_treeListView1;
        private BrightIdeasSoftware.TreeListView m_treeListView2;
        private  string m_platzhalter = "";
        private  BrightIdeasSoftware.OLVColumn olvColumnName;
        private  BrightIdeasSoftware.OLVColumn olvColumnInitiating;
        private  BrightIdeasSoftware.OLVColumn olvColumnPlanning;
        private  BrightIdeasSoftware.OLVColumn olvColumnExecuting;
        private  BrightIdeasSoftware.OLVColumn olvColumnMonitoring;
        private  BrightIdeasSoftware.OLVColumn olvColumnClosing;

        public TreeViewSetuper1(frmMain frmMain)
        {
            m_frmMain = frmMain;
            m_treeListView1 = m_frmMain.treeListView1;
            m_treeListView2 = m_frmMain.treeListView2;
            CreateColumns();
            CanExpandGetter(m_treeListView1);
            ChildrenGetter(m_treeListView1);
            SetupColumnsText();
            SetupColumnsImage();
            m_treeListView1.SelectionChanged += new System.EventHandler(m_treeListView_SelectionChanged);
        }
        
        public  void CreateColumns()
        {
            olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            olvColumnName.AspectName = "Name";
            olvColumnName.Text = "Processes";
            olvColumnName.Width = 250;

            olvColumnInitiating = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            olvColumnInitiating.AspectName = "Initiating";
            olvColumnInitiating.Text = "Initiating";
            olvColumnInitiating.Width = 55;
            olvColumnInitiating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            olvColumnPlanning = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            olvColumnPlanning.AspectName = "Planning";
            olvColumnPlanning.Text = "Planning";
            olvColumnPlanning.Width = 55;
            olvColumnPlanning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            olvColumnExecuting = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            olvColumnExecuting.AspectName = "Executing";
            olvColumnExecuting.Text = "Executing";
            olvColumnExecuting.Width = 55;
            olvColumnExecuting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            olvColumnMonitoring = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            olvColumnMonitoring.AspectName = "Monitoring";
            olvColumnMonitoring.Text = "Monitoring";
            olvColumnMonitoring.Width = 55;
            olvColumnMonitoring.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            olvColumnClosing = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            olvColumnClosing.AspectName = "Closing";
            olvColumnClosing.Text = "Closing";
            olvColumnClosing.Width = 55;
            olvColumnClosing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            m_treeListView1.AllColumns.Add(olvColumnName);
            m_treeListView1.AllColumns.Add(olvColumnInitiating);
            m_treeListView1.AllColumns.Add(olvColumnPlanning);
            m_treeListView1.AllColumns.Add(olvColumnExecuting);
            m_treeListView1.AllColumns.Add(olvColumnMonitoring);
            m_treeListView1.AllColumns.Add(olvColumnClosing);
            m_treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            {olvColumnName,olvColumnInitiating,olvColumnPlanning,olvColumnExecuting,olvColumnMonitoring,olvColumnClosing});



        }

        private  void CanExpandGetter(BrightIdeasSoftware.TreeListView mytreeListView)
        {
            mytreeListView.CanExpandGetter = delegate (object x)
            {
                if (x is Project || x is KnowledgeArea)
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

        private  void ChildrenGetter(BrightIdeasSoftware.TreeListView mytreeListView)
        {
            mytreeListView.ChildrenGetter = delegate (object x)
            {
                try
                {
                    if (x is Project)
                    {
                        return ((Project)x).KnowledgeAreas;
                    }
                    if (x is KnowledgeArea)
                    {
                        return ((KnowledgeArea)x).Processes;
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

        private  void SetupColumnsText()
        {
            olvColumnInitiating.AspectGetter = delegate (object x)
            {
                if (x is Process)
                {
                    Process p = (Process)x;
                    if (p.Initiating == true)
                    {
                        return "";
                        //return Properties.Resources.ShaderSpot;
                    }
                    else
                    {
                        return m_platzhalter;
                    }
                }
                else
                {
                    return m_platzhalter;
                }
            };

            olvColumnPlanning.AspectGetter = delegate (object x)
            {
                if (x is Process)
                {
                    Process p = (Process)x;
                    if (p.Planning == true)
                    {
                        return "";
                    }
                    else
                    {
                        return m_platzhalter;
                    }
                }
                else
                {
                    return m_platzhalter;
                }
            };

            olvColumnExecuting.AspectGetter = delegate (object x)
            {
                if (x is Process)
                {
                    Process p = (Process)x;
                    if (p.Executing == true)
                    {
                        return "";
                    }
                    else
                    {
                        return m_platzhalter;
                    }
                }
                else
                {
                    return m_platzhalter;
                }
            };

            olvColumnMonitoring.AspectGetter = delegate (object x)
            {
                if (x is Process)
                {
                    Process p = (Process)x;
                    if (p.Monitoring == true)
                    {
                        return "";
                    }
                    else
                    {
                        return m_platzhalter;
                    }
                }
                else
                {
                    return m_platzhalter;
                }
            };

            olvColumnClosing.AspectGetter = delegate (object x)
            {
                if (x is Process)
                {
                    Process p = (Process)x;
                    if (p.Closing == true)
                    {
                        return "";
                    }
                    else
                    {
                        return m_platzhalter;
                    }
                }
                else
                {
                    return m_platzhalter;
                }
            };
        }

        private  void SetupColumnsImage()
        {
            olvColumnInitiating.ImageGetter = delegate (object x)
            {
                if (x is Process)
                {
                    Process p = (Process)x;
                    if (p.Initiating == true)
                    {
                        //return "XXXXX";
                        return Properties.Resources.ShaderSpot.ResizeBitmap(20, 20);
                    }
                    else
                    {
                        return m_platzhalter;
                    }
                }
                else
                {
                    return m_platzhalter;
                }
            };

            olvColumnPlanning.ImageGetter = delegate (object x)
            {
                if (x is Process)
                {
                    Process p = (Process)x;
                    if (p.Planning == true)
                    {
                        return Properties.Resources.ShaderSpot.ResizeBitmap(20, 20);
                    }
                    else
                    {
                        return m_platzhalter;
                    }
                }
                else
                {
                    return m_platzhalter;
                }
            };

            olvColumnExecuting.ImageGetter = delegate (object x)
            {
                if (x is Process)
                {
                    Process p = (Process)x;
                    if (p.Executing == true)
                    {
                        return Properties.Resources.ShaderSpot.ResizeBitmap(20, 20);
                    }
                    else
                    {
                        return m_platzhalter;
                    }
                }
                else
                {
                    return m_platzhalter;
                }
            };

            olvColumnMonitoring.ImageGetter = delegate (object x)
            {
                if (x is Process)
                {
                    Process p = (Process)x;
                    if (p.Monitoring == true)
                    {
                        return Properties.Resources.ShaderSpot.ResizeBitmap(20, 20);
                    }
                    else
                    {
                        return m_platzhalter;
                    }
                }
                else
                {
                    return m_platzhalter;
                }
            };

            olvColumnClosing.ImageGetter = delegate (object x)
            {
                if (x is Process)
                {
                    Process p = (Process)x;
                    if (p.Closing == true)
                    {
                        return Properties.Resources.ShaderSpot.ResizeBitmap(20, 20);
                    }
                    else
                    {
                        return m_platzhalter;
                    }
                }
                else
                {
                    return m_platzhalter;
                }
            };
        }

        private void m_treeListView_SelectionChanged(object sender, EventArgs e)
        {
            m_frmMain.myDocViewer1.UnloadMyDoc();
            m_treeListView2.GetColumn(0).Text = "Process Entities";
            Object selObj = m_treeListView1.SelectedObject;
            if (selObj is Process)
            {
                Process process = (Process)selObj;
                m_treeListView2.RemoveObjects((ICollection)m_treeListView2.Objects);
                m_treeListView2.ClearObjects();
                m_treeListView2.AddObject(process.Inputs);
                m_treeListView2.AddObject(process.OutputsCreated);
                //m_treeListView2.AddObject(process.OutputsUpdated);
                if (process.OutputsUpdated.Items.Count>0)
                {
                    process.OutputsCreated.Name = "Outputs Created";
                    process.OutputsUpdated.Name = "Outputs Updated";
                    m_treeListView2.AddObject(process.OutputsUpdated); 
                }
                m_treeListView2.AddObject(process.Tools);
                m_treeListView2.ExpandAll();
                m_frmMain.ClearStatusStrip2();
            }
            else
            {
                m_treeListView2.RemoveObjects((ICollection)m_treeListView2.Objects);
                m_frmMain.ClearStatusStrip2();
            }

        }

        


    }
}
