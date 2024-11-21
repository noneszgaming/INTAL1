using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using PlanningProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace PlanningProject.Pages
{
    public class TasksModel : PageModel
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TasksModel(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
        }

        public IssueResponse IssueResponse { get; private set; }

        [BindProperty(SupportsGet = true)]
        public int SprintId { get; set; }

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
        }
    }
}