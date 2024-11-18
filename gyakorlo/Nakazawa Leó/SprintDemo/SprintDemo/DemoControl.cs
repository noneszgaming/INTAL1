using System.Drawing;
using System.Windows.Forms;

namespace SprintDemo
{
    public abstract class DemoControl
    {
        public Label Label { get; }

        public DemoControl(Size size, Point location, string description, Font font, Control parent)
        {
            Label = new Label()
            {
                Size = size,
                Location = location,
                Text = description,
                Font = font,
            };

            parent.Controls.Add(Label);
        }
    }
}
