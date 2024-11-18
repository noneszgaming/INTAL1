using System.Drawing;
using System.Windows.Forms;

namespace SprintDemo
{
    public class Sprint : DemoControl
    {
        public Sprint(Size size, Point location, string description, Font font, Control parent) : base(size, location, description, font, parent)
        {
            Label.BorderStyle = BorderStyle.FixedSingle;
            Label.TextAlign = ContentAlignment.BottomCenter;
        }
    }
}
