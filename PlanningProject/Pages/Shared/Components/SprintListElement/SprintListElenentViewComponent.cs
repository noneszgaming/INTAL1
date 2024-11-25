using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class SprintListElementViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id, string title, string status, double averageScore, string startDate, string endDate, int currentParticipants, int totalParticipants)
        {
            var model = new SprintListElementViewModel
            {
                Id = id,
                Title = title,
                StartDate = startDate,
                EndDate = endDate,
                CurrentParticipants = currentParticipants,
                TotalParticipants = totalParticipants
            };
            return View("SprintListElement", model);
        }
    }
}

// ha kiszedem innen a statust és az avarageScore-t, a program összeomlik :') pedig sehol máshol nincsenek hasznélva...