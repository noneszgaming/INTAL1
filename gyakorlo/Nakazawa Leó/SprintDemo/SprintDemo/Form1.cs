using System;
using System.Drawing;
using System.Windows.Forms;

namespace SprintDemo
{
    public partial class SprintDemo : Form
    {
        Label focusedTaskLabel;

        public SprintDemo()
        {
            InitializeComponent();

            Font font = new Font("MS UI Gothic", 20);

            InitializeTasks(font);
            InitializeSprints(font);
        }

        void InitializeTasks(Font font)
        {
            Task temporaryTask;
            Size taskSize = new Size(100, 50);

            for (int i = 0; i < 10; i++)
            {
                temporaryTask = new Task(taskSize, new Point(0, i * taskSize.Height), "Task" + i, font, taskPanel);
                temporaryTask.Label.Click += OnTaskClick;
            }
        }

        void InitializeSprints(Font font)
        {
            Sprint temporarySprint;
            Size sprintSize = new Size(125, 500);
            int sprintPositionX = ClientSize.Width - sprintSize.Width;

            for (int i = 3; i > -1; i--)
            {
                temporarySprint = new Sprint(sprintSize, new Point(sprintPositionX - i * sprintSize.Width, 0), "Sprint" + i, font, this);
                temporarySprint.Label.Click += OnSprintClick;
            }
        }

        void OnTaskClick(object sender, EventArgs e)
        {
            if (focusedTaskLabel != null)
            {
                focusedTaskLabel.BorderStyle = BorderStyle.None;
            }

            focusedTaskLabel = (Label)sender;
            focusedTaskLabel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void OnSprintClick(object sender, EventArgs e)
        {
            if (focusedTaskLabel == null)
            {
                return;
            }

            ((Label)sender).Controls.Add(focusedTaskLabel);
        }

        void OnFormClick(object sender, EventArgs e)
        {
            if (focusedTaskLabel == null)
            {
                return;
            }

            taskPanel.Controls.Add(focusedTaskLabel);
        }

        void OnTaskPanelClick(object sender, EventArgs e)
        {
            if (focusedTaskLabel == null)
            {
                return;
            }

            taskPanel.Controls.Add(focusedTaskLabel);
        }
    }
}
