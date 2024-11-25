using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class LobbySprintPanelViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new LobbySprintPanelViewModel
            {

            };
            return View("LobbySprintPanel", model);
        }
    }
}