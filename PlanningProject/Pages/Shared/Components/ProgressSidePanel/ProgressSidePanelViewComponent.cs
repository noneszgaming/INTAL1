using Microsoft.AspNetCore.Mvc;
using PlanningProject.Models;

public class ProgressSidePanelViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(List<Issue> issues)
    {
        var model = new ProgressSidePanelViewModel
        {
            Issues = issues
        };

        return View("ProgressSidePanel", model);
    }
}
