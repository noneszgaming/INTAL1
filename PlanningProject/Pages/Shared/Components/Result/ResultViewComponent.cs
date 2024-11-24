using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class TasksViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<ResultItem> tasks, bool showOkButton = true)
        {
            var model = new ResultViewModel
            {
                Result = tasks,
                ShowOkButton = showOkButton
            };
            return View("Result", model);
        }
    }
}