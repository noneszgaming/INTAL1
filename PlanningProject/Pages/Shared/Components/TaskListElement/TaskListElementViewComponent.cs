using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class TaskListElementViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id, string title, string status, double averageScore)
        {
            var model = new TaskListElementViewModel
            {
                id = id,
                title = title,
                status = status,
                averageScore = averageScore
            };
            return View("TaskListElement", model);
        }
    }
}