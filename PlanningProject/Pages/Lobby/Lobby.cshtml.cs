using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlanningProject.Data;

namespace PlanningProject.Pages.Lobby
{
    public class LobbyModel(ApplicationDbContext context) : PageModel
    {
        ApplicationDbContext _context = context;
        public string? Username { get; set; }
        public IActionResult OnGet(int userId)
        {
            // Retrieve the user from the database
            var user = _context.Users.FirstOrDefault(u => u.User_id == userId);
            if (user == null)
            {
                return NotFound(); // Handle case where user is not found
            }
            Username = user.Username;
            return Page();
        }
    }
}

