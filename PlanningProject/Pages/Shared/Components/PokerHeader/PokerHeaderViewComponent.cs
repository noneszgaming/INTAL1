using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class PokerHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(bool isOpened)
        {
            var model = new PokerHeaderViewModel
            {
                isOpened = isOpened
            };
            return View("PokerHeader", model);
        }
    }
}