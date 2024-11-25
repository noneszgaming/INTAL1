using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlanningProject.Pages.Login
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(Username))
            {
                HttpContext.Session.SetString("Username", Username);
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}