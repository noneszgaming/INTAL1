using System.Collections.Generic;
using System.Windows.Forms;

namespace SprintDemo
{
    public class Lobby
    {
        HashSet<User> users;

        Label label;

        public Lobby(Label label)
        {
            users = new HashSet<User>();

            this.label = label;
            this.label.Click += OnClick;
        }

        private void OnClick(object sender, System.EventArgs e)
        {
            AddUser();
        }

        void AddUser()
        {
            User focusedUser = SprintDemoForm.FocusedUser;

            if (focusedUser == null)
            {
                return;
            }

            if (focusedUser.Lobby != null)
            {
                return;
            }

            focusedUser.Lobby = this;
            users.Add(focusedUser);

            label.Controls.Add(focusedUser.Label);
        }

        public static void RemoveUser(Control originalControl)
        {
            User focusedUser = SprintDemoForm.FocusedUser;

            if (focusedUser == null)
            {
                return;
            }

            if (focusedUser.Lobby == null)
            {
                return;
            }

            focusedUser.Lobby.users.Remove(focusedUser);
            focusedUser.Lobby = null;

            originalControl.Controls.Add(focusedUser.Label);
        }
    }
}
