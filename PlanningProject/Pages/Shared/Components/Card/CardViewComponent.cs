using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class CardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(bool inDeck, bool isVoted, bool isRevealed, int value)
        {
            var model = new CardViewModel
            {
                inDeck = inDeck,
                isVoted = isVoted,

                isRevealed = isRevealed,
                value = value
            };
            return View("Card", model);
        }
    }
}