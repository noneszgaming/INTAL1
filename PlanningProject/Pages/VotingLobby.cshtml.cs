using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlanningProject.Models;
using System.Text.Json;

namespace PlanningProject.Pages
{
    public class VotingLobbyModel : PageModel
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VotingLobbyModel(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
        }

        [BindProperty(SupportsGet = true)]
        public int SprintId { get; set; }

        public List<Issue> Issues { get; private set; } = new List<Issue>();

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
                var issueResponse = JsonSerializer.Deserialize<IssueResponse>(jsonResponse, options);
                Issues = issueResponse?.Issues ?? new List<Issue>();
            }
        }
    }
}
