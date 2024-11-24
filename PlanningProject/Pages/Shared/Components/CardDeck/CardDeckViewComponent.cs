using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class CardDeckViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new CardDeckViewModel
            {

            };
            return View("CardDeck", model);
        }
    }
}