using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlanningProject.Data;
using PlanningProject.Models;

namespace PlanningProject.Pages.Lobby
{
    public class LobbyModel(ApplicationDbContext context) : PageModel
    {
        ApplicationDbContext _context = context;

        [BindProperty]
        public string? Username { get; set; }
        public int Sprint_id {  get; set; }

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

        public IActionResult OnPost()
        {
            var newsprint = new DbSprint(Sprint_id);
            return RedirectToPage("/Poker/Poker", HttpContext.Request.Query["userId"]);
        }
    }
}

