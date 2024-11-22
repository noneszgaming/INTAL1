using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class StartButtonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("StartBtn");
        }
    }
}
