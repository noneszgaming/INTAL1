using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlanningProject.Models;
using PlanningProject.Pages.Shared.Components;

public class ProgressSidePanelViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(List<DbTask> tasks)
    {
        var model = new ProgressSidePanelViewModel
        {
            Tasks = tasks
        };

        return View("ProgressSidePanel", model);
    }
}
