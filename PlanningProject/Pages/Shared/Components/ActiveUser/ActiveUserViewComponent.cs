using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages.Shared.Components
{
    public class ActiveUserViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string username)
        {
            var model = new ActiveUserViewModel
            {
                Username = username
            };
            return View("ActiveUser", model);
        }
    }
}
