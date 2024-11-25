using System.Windows.Forms;

namespace SprintDemo
{
    public partial class SprintDemoForm : Form
    {
        public static User FocusedUser { get; set; }

        public SprintDemoForm()
        {
            InitializeComponent();

            _ = new User(userLabel1);
            _ = new User(userLabel2);
            _ = new User(userLabel3);

            _ = new Lobby(lobbyLabel1);
            _ = new Lobby(lobbyLabel2);
            _ = new Lobby(lobbyLabel3);
        }

        private void OnClick(object sender, System.EventArgs e)
        {
            Lobby.RemoveUser(this);
        }
    }
}
