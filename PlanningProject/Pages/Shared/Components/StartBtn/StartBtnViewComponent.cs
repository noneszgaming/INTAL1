using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class StartBtnViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new StartBtnViewModel();
            return View("StartBtn", model);
        }
    }
}
