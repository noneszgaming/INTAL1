using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PlanningProject.Data;
using PlanningProject.Models;
using System.Text.Json;

namespace PlanningProject.Pages.Lobby
{
    public class LobbyModel(HttpClient httpClient, IHttpContextAccessor httpContextAccessor, ApplicationDbContext context) : PageModel
    {
        readonly HttpClient _httpClient = httpClient;
        readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

        readonly ApplicationDbContext _context = context;

        public List<Sprint>? Sprints { get; private set; }

        public string? Username { get; set; }

        public async Task OnGetAsync()
        {
            var request = _httpContextAccessor.HttpContext.Request;
            var baseUrl = $"{request.Scheme}://{request.Host}";
            var response = await _httpClient.GetAsync($"{baseUrl}/api/Jira/sprints");

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var sprintsResponse = JsonSerializer.Deserialize<SprintsResponse>(jsonResponse, options);

                Sprints = sprintsResponse.Values;

                if (Sprints != null)
                {
                    foreach (var sprint in Sprints)
                    {
                        // Check if a sprint with the same SprintId already exists
                        var exists = await _context.Sprints.AnyAsync(db => db.Sprint_id == sprint.Id);

                        var newDbSprint = new DbSprint { Sprint_id = sprint.Id, Description = sprint.Name };

                        if (!exists)
                        {
                            // If it doesn't exist, add it to the database

                            _context.Sprints.Add(newDbSprint);
                        }
                        else
                        {
                            _context.Sprints.Update(newDbSprint);
                        }
                    }

                    // Save changes to the database
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                Sprints = [];
            }
        }

        public IActionResult OnPost()
        {
            var dbSprint = new DbSprint
            {
                Sprint_id = int.Parse("1")
            };

            return RedirectToPage("/Poker/Poker", HttpContext.Request.Query["userId"], new { sprintId = dbSprint.Sprint_id });
        }
    }

}

