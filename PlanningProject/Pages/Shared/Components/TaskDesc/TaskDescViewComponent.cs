using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class TaskDescViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string taskName, string description)
        {
            var model = new TaskDescViewModel
            {
                TaskName = taskName,
                Description = description
            };
            return View("TaskDesc", model);
        }
    }
}
