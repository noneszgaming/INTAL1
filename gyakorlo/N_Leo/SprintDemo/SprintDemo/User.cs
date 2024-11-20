using System;
using System.Windows.Forms;

namespace SprintDemo
{
    public class User
    {
        public Lobby Lobby {  get; set; }
        public Label Label { get; }

        public User(Label label)
        {
            Label = label;

            Label.Click += OnClick;
        }

        private void OnClick(object sender, EventArgs e)
        {
            SetUserFocused();
        }

        private void SetUserFocused()
        {
            User focusedUser = SprintDemoForm.FocusedUser;

            if (focusedUser != null)
            {
                focusedUser.Label.BorderStyle = BorderStyle.None;
            }

            SprintDemoForm.FocusedUser = this;

            Label.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
