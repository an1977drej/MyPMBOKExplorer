using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gnostice.Core.Viewer;

namespace DocViewer
{
    public partial class MyDocViewer: UserControl
    {
        public MyDocViewer()
        {
            //Gnostice.Licensing.GnosticeLicenseProvider gnosticeLicenseProvider = new Gnostice.Licensing.GnosticeLicenseProvider();
            //var s = gnosticeLicenseProvider.CreateUnauthenticatedLicense("2423-F2C4-9EC4-F3C8-D79B-A965-FEC5-5D9E");
            InitializeComponent();
            //Gnostice.Licensing.License license = new Gnostice.Licensing.License();
        }

        public void LoadMyDoc(string filePath)
        {
            documentViewer1.LoadDocument(filePath);
            documentViewer1.NavigationPane.Visibility = Visibility.Never;
            documentViewer1.PageLayout.LayoutMode = PageLayoutMode.AutoFitPagesInWindow;
            documentViewer1.Zoom.ZoomMode = ZoomMode.FitPage;
        }
        public void UnloadMyDoc()
        {
            
           if (documentViewer1.ActiveDocument!= null)
            {
                documentViewer1.CloseDocument(); 
            }
        }


        public void FitPage()
        {
            documentViewer1.PageLayout.LayoutMode = PageLayoutMode.AutoFitPagesInWindow;
            documentViewer1.Zoom.ZoomMode = ZoomMode.FitPage;
        }

    }
}
