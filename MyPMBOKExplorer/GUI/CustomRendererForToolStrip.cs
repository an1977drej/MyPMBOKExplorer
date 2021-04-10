using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPMBOKExplorer
{
   public class CustomRendererForToolStrip : ToolStripProfessionalRenderer
    {
        //Then it's enough to set Renderer of your StatusStrip to your custom renderer:
        //this.statusStrip1.Renderer = new CustomRenderer();
        //You can see the behavior of a ToolStripStatusLabel which it's Spring property is set to true
        //and its StatusStrip uses CustomRenderer:
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.Item is ToolStripStatusLabel)
                TextRenderer.DrawText(e.Graphics, e.Text, e.TextFont,
                    e.TextRectangle, e.TextColor, Color.Transparent,
                    e.TextFormat | TextFormatFlags.EndEllipsis);
            else
                base.OnRenderItemText(e);
        }
    }
}
