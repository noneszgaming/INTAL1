using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using PlanningProject.Data;
using PlanningProject.Models;
using System.ComponentModel.DataAnnotations;


namespace PlanningProject.Pages.Login
{
    public class LoginModel(ApplicationDbContext context) : PageModel
    {
        ApplicationDbContext _context = context;

        [BindProperty]

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters.")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Username can only contain letters and numbers.")]
        public string? Username { get; set; }

        public string? FeedbackMessage { get; set; }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(Username))
            {
                if (!ModelState.IsValid)
                {
                    return Page(); // Return the page with validation messages
                }

                // Check if the username already exists
                var existingUser = _context.Users.FirstOrDefault(u => u.Username == Username);

                if (existingUser != null)
                {
                    // Save the username in the database
                    //var user = new DbUser(Username);
                    //_context.Users.Add(user);
                    //_context.SaveChanges();

                    //int userId = user.User_id;

                    return RedirectToPage("/Lobby/Lobby", new { userId = existingUser.User_id });
                }

                FeedbackMessage = "A felhasználónév nem szerepel az adatbázisban, kérem adjon meg egy létező felhasználónevet.";
            }

            return Page();
        }
    }
}
