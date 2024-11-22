using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class DateViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string startDate, string endDate)
        {
            var model = new DateViewModel
            {
                StartDate = startDate,
                EndDate = endDate
            };
            return View("Date", model);
        }
    }
}
