using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class TableCardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new TableCardViewModel
            {

            };
            return View("TableCard", model);
        }
    }
}