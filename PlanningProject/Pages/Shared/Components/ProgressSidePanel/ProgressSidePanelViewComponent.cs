using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class ProgressSidePanelViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new ProgressSidePanelViewModel
            {

            };
            return View("ProgressSidePanel", model);
        }
    }
}