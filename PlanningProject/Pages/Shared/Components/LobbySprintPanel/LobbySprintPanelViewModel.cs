using PlanningProject.Models;

namespace PlanningProject.Pages.Shared.Components
{
    public class LobbySprintPanelViewModel
    {
        public List<DbSprint> Sprints { get; set; } = new List<DbSprint>();
    }
}