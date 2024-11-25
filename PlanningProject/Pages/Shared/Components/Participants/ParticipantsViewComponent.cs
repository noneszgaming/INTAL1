using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class ParticipantsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int currentParticipants, int totalParticipants)
        {
            var model = new ParticipantsViewModel
            {
                CurrentParticipants = currentParticipants,
                TotalParticipants = totalParticipants
            };
            return View("Participants", model);
        }
    }
}
