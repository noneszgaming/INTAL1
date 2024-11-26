using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class StartBtnViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int sprintId)
        {
            var model = new StartBtnViewModel
            {
                SprintId = sprintId
            };
            return View("StartBtn", model);
        }
    }
}
