using System.Drawing;
using System.Windows.Forms;

namespace SprintDemo
{
    public class Task : DemoControl
    {
        public Point OriginalLocation { get; }

        public Task(Size size, Point location, string description, Font font, Control parent) : base(size, location, description, font, parent)
        {
            OriginalLocation = location;
            Label.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
