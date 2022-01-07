
namespace MyPMBOKExplorer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1ButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1ButtonOpenProject = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1ButtonSaveProject = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1ButtonExpand = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1ButtonCollaps = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeListView2 = new BrightIdeasSoftware.TreeListView();
            this.myDocViewer1 = new DocViewer.MyDocViewer();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButtonSettings = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripMenuItemSetNewPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2ButtonExpand = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2ButtonCollaps = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowDocuments = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowTools = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView2)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeListView1
            // 
            this.treeListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListView1.GridLines = true;
            this.treeListView1.HideSelection = false;
            this.treeListView1.Location = new System.Drawing.Point(0, 27);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.OwnerDraw = true;
            this.treeListView1.ShowGroups = false;
            this.treeListView1.Size = new System.Drawing.Size(217, 382);
            this.treeListView1.TabIndex = 0;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(661, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeListView1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(661, 409);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip1ButtonNew,
            this.toolStrip1ButtonOpenProject,
            this.toolStrip1ButtonSaveProject,
            this.toolStripSeparator1,
            this.toolStrip1ButtonExpand,
            this.toolStrip1ButtonCollaps});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(217, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip1ButtonNew
            // 
            this.toolStrip1ButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip1ButtonNew.Image = global::MyPMBOKExplorer.Properties.Resources.New;
            this.toolStrip1ButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip1ButtonNew.Name = "toolStrip1ButtonNew";
            this.toolStrip1ButtonNew.Size = new System.Drawing.Size(29, 24);
            this.toolStrip1ButtonNew.Text = "New";
            this.toolStrip1ButtonNew.Click += new System.EventHandler(this.toolStrip1ButtonNew_Click);
            // 
            // toolStrip1ButtonOpenProject
            // 
            this.toolStrip1ButtonOpenProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip1ButtonOpenProject.Image = global::MyPMBOKExplorer.Properties.Resources.Open;
            this.toolStrip1ButtonOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip1ButtonOpenProject.Name = "toolStrip1ButtonOpenProject";
            this.toolStrip1ButtonOpenProject.Size = new System.Drawing.Size(29, 24);
            this.toolStrip1ButtonOpenProject.Text = "Open";
            this.toolStrip1ButtonOpenProject.Click += new System.EventHandler(this.toolStrip1ButtonOpenProject_Click);
            // 
            // toolStrip1ButtonSaveProject
            // 
            this.toolStrip1ButtonSaveProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip1ButtonSaveProject.Image = global::MyPMBOKExplorer.Properties.Resources.Save;
            this.toolStrip1ButtonSaveProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip1ButtonSaveProject.Name = "toolStrip1ButtonSaveProject";
            this.toolStrip1ButtonSaveProject.Size = new System.Drawing.Size(29, 24);
            this.toolStrip1ButtonSaveProject.Text = "Save";
            this.toolStrip1ButtonSaveProject.Click += new System.EventHandler(this.toolStrip1ButtonSaveProject_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStrip1ButtonExpand
            // 
            this.toolStrip1ButtonExpand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip1ButtonExpand.Image = global::MyPMBOKExplorer.Properties.Resources.Expand;
            this.toolStrip1ButtonExpand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip1ButtonExpand.Name = "toolStrip1ButtonExpand";
            this.toolStrip1ButtonExpand.Size = new System.Drawing.Size(29, 24);
            this.toolStrip1ButtonExpand.Text = "Expand";
            this.toolStrip1ButtonExpand.Click += new System.EventHandler(this.toolStrip1ButtonExpand_Click);
            // 
            // toolStrip1ButtonCollaps
            // 
            this.toolStrip1ButtonCollaps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip1ButtonCollaps.Image = global::MyPMBOKExplorer.Properties.Resources.Collapse;
            this.toolStrip1ButtonCollaps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip1ButtonCollaps.Name = "toolStrip1ButtonCollaps";
            this.toolStrip1ButtonCollaps.Size = new System.Drawing.Size(29, 24);
            this.toolStrip1ButtonCollaps.Text = "tooCollaps";
            this.toolStrip1ButtonCollaps.Click += new System.EventHandler(this.toolStrip1ButtonCollaps_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 27);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeListView2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.myDocViewer1);
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip2);
            this.splitContainer2.Size = new System.Drawing.Size(440, 382);
            this.splitContainer2.SplitterDistance = 146;
            this.splitContainer2.TabIndex = 1;
            // 
            // treeListView2
            // 
            this.treeListView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListView2.HideSelection = false;
            this.treeListView2.Location = new System.Drawing.Point(0, 0);
            this.treeListView2.Name = "treeListView2";
            this.treeListView2.OwnerDraw = true;
            this.treeListView2.ShowGroups = false;
            this.treeListView2.Size = new System.Drawing.Size(146, 382);
            this.treeListView2.TabIndex = 0;
            this.treeListView2.UseCompatibleStateImageBehavior = false;
            this.treeListView2.View = System.Windows.Forms.View.Details;
            this.treeListView2.VirtualMode = true;
            // 
            // myDocViewer1
            // 
            this.myDocViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDocViewer1.Location = new System.Drawing.Point(0, 26);
            this.myDocViewer1.Name = "myDocViewer1";
            this.myDocViewer1.Size = new System.Drawing.Size(290, 356);
            this.myDocViewer1.TabIndex = 1;
            this.myDocViewer1.Resize += new System.EventHandler(this.myDocViewer1_Resize);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPath,
            this.toolStripSplitButtonSettings});
            this.statusStrip2.Location = new System.Drawing.Point(0, 0);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(290, 26);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabelPath
            // 
            this.toolStripStatusLabelPath.Name = "toolStripStatusLabelPath";
            this.toolStripStatusLabelPath.Size = new System.Drawing.Size(194, 20);
            this.toolStripStatusLabelPath.Spring = true;
            this.toolStripStatusLabelPath.Text = ".";
            this.toolStripStatusLabelPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSplitButtonSettings
            // 
            this.toolStripSplitButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSetNewPath});
            this.toolStripSplitButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonSettings.Image")));
            this.toolStripSplitButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonSettings.Name = "toolStripSplitButtonSettings";
            this.toolStripSplitButtonSettings.Size = new System.Drawing.Size(81, 24);
            this.toolStripSplitButtonSettings.Text = "Settings";
            // 
            // ToolStripMenuItemSetNewPath
            // 
            this.ToolStripMenuItemSetNewPath.Name = "ToolStripMenuItemSetNewPath";
            this.ToolStripMenuItemSetNewPath.Size = new System.Drawing.Size(178, 26);
            this.ToolStripMenuItemSetNewPath.Text = "Set new path";
            this.ToolStripMenuItemSetNewPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItemSetNewPath.Click += new System.EventHandler(this.ToolStripMenuItemSetNewPath_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip2ButtonExpand,
            this.toolStrip2ButtonCollaps,
            this.toolStripButtonShowDocuments,
            this.toolStripButtonShowTools});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(440, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip2ButtonExpand
            // 
            this.toolStrip2ButtonExpand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip2ButtonExpand.Image = global::MyPMBOKExplorer.Properties.Resources.Expand;
            this.toolStrip2ButtonExpand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip2ButtonExpand.Name = "toolStrip2ButtonExpand";
            this.toolStrip2ButtonExpand.Size = new System.Drawing.Size(29, 24);
            this.toolStrip2ButtonExpand.Text = "Expand";
            this.toolStrip2ButtonExpand.Click += new System.EventHandler(this.toolStrip2ButtonExpand_Click);
            // 
            // toolStrip2ButtonCollaps
            // 
            this.toolStrip2ButtonCollaps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip2ButtonCollaps.Image = global::MyPMBOKExplorer.Properties.Resources.Collapse;
            this.toolStrip2ButtonCollaps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip2ButtonCollaps.Name = "toolStrip2ButtonCollaps";
            this.toolStrip2ButtonCollaps.Size = new System.Drawing.Size(29, 24);
            this.toolStrip2ButtonCollaps.Text = "Collaps";
            this.toolStrip2ButtonCollaps.Click += new System.EventHandler(this.toolStrip2ButtonCollaps_Click);
            // 
            // toolStripButtonShowDocuments
            // 
            this.toolStripButtonShowDocuments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowDocuments.Image = global::MyPMBOKExplorer.Properties.Resources.Textfile_818_16x;
            this.toolStripButtonShowDocuments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowDocuments.Name = "toolStripButtonShowDocuments";
            this.toolStripButtonShowDocuments.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonShowDocuments.Text = "Show Documents";
            this.toolStripButtonShowDocuments.Click += new System.EventHandler(this.toolStrip2ButtonShowDocuments_Click);
            // 
            // toolStripButtonShowTools
            // 
            this.toolStripButtonShowTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowTools.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowTools.Image")));
            this.toolStripButtonShowTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowTools.Name = "toolStripButtonShowTools";
            this.toolStripButtonShowTools.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonShowTools.Text = "Show Tools";
            this.toolStripButtonShowTools.Click += new System.EventHandler(this.toolStrip2ButtonShowTools_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 431);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My PMBOOK Explorer";
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView2)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public BrightIdeasSoftware.TreeListView treeListView1;
        public BrightIdeasSoftware.TreeListView treeListView2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrip1ButtonNew;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPath;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowDocuments;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowTools;
        public System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetNewPath;
        private System.Windows.Forms.ToolStripButton toolStrip2ButtonExpand;
        private System.Windows.Forms.ToolStripButton toolStrip2ButtonCollaps;
        private System.Windows.Forms.ToolStripButton toolStrip1ButtonOpenProject;
        private System.Windows.Forms.ToolStripButton toolStrip1ButtonSaveProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStrip1ButtonExpand;
        private System.Windows.Forms.ToolStripButton toolStrip1ButtonCollaps;
        public DocViewer.MyDocViewer myDocViewer1;
    }
}

