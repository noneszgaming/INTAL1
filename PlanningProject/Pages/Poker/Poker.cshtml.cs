using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using PlanningProject.Data;
using PlanningProject.Models;
using PlanningProject.Pages.Shared.Components;
using System.Text.Json;

namespace PlanningProject.Pages.Poker
{
    public class PokerModel : PageModel
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly ApplicationDbContext _context;

        public IssueResponse IssueResponse { get; private set; }

        public PokerModel(HttpClient httpClient, IHttpContextAccessor httpContextAccessor, ApplicationDbContext context)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;

            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public int SprintId { get; set; }

        public List<DbTask> Tasks { get; set; } = [];

        public async Task OnGetAsync()
        {
            var request = _httpContextAccessor.HttpContext.Request;
            var baseUrl = $"{request.Scheme}://{request.Host}";

            var response = await _httpClient.GetAsync($"{baseUrl}/api/Jira/tasks/{SprintId}");

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                IssueResponse = JsonSerializer.Deserialize<IssueResponse>(jsonResponse, options);
            }
            else
            {
                IssueResponse = new IssueResponse { Issues = new List<Issue>() };
            }

            for (int i = 0; i < IssueResponse.Issues.Count; i++)
            {
                var issuePoint = IssueResponse.Issues[i].Fields.customfield_10016;

                issuePoint ??= 0.0;

                Tasks.Add(new DbTask { Task_id = IssueResponse.Issues[i].Key, Sprint_id = SprintId, Description = IssueResponse.Issues[i].Fields.Description, Est_point = (double)issuePoint });
            }

            if (Tasks != null)
            {
                foreach (var task in Tasks)
                {
                    // Check if a sprint with the same SprintId already exists
                    var exists = await _context.Tasks.AnyAsync(db => db.Task_id == task.Task_id);

                    var newDbTask = new DbTask { Task_id = task.Task_id, Sprint_id = task.Sprint_id, Description = task.Description, Est_point = task.Est_point };

                    if (!exists)
                    {
                        // If it doesn't exist, add it to the database

                        _context.Tasks.Add(newDbTask);
                    }
                }

                // Save changes to the database
                await _context.SaveChangesAsync();
            }
        }
    }
}
