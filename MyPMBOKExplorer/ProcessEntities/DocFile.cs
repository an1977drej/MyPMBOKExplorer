using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPMBOKExplorer
{
   public class DocFile : IDocFile
    {
        public string  Name { get { return Path.GetFileName(FilePath); } }
        public string FilePath { get; set; }
        public Bitmap Icon { get { return System.Drawing.Icon.ExtractAssociatedIcon(FilePath).ToBitmap().ResizeBitmap(20, 20); } }
    }
}
