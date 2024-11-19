using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class CardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(bool isVoted, bool isSelected)
        {
            var model = new CardViewModel
            {
                isVoted = isVoted,
                isSelected = isSelected
            };
            return View("Card", model);
        }
    }
}