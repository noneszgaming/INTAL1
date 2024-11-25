using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class TableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(bool allVoted, bool anyVoted)
        {
            var model = new TableViewModel
            {
                AllVoted = allVoted,
            };
            return View("Table", model);
        }
    }
}
