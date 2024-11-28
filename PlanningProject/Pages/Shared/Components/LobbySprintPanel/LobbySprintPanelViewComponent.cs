using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Text.Json;
using PlanningProject.Models;
using System.Globalization;

namespace PlanningProject.Pages.Shared.Components
{
    public class LobbySprintPanelViewComponent : ViewComponent
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LobbySprintPanelViewComponent(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var request = _httpContextAccessor.HttpContext.Request;
            var baseUrl = $"{request.Scheme}://{request.Host}";
            var response = await _httpClient.GetAsync($"{baseUrl}/api/Jira/sprints");

            var model = new LobbySprintPanelViewModel();

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var sprintsResponse = JsonSerializer.Deserialize<SprintsResponse>(jsonResponse, options);
                model.Sprints = sprintsResponse.Values.Select(sprint => new Sprint
                {
                    Id = sprint.Id,
                    Name = sprint.Name,
                    StartDate = !string.IsNullOrEmpty(sprint.StartDate) ? DateTime.Parse(sprint.StartDate).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) : null,
                    EndDate = !string.IsNullOrEmpty(sprint.EndDate) ? DateTime.Parse(sprint.EndDate).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) : null
                }).ToList();
            }
            else
            {
                model.Sprints = new List<Sprint>();
            }

            return View("LobbySprintPanel", model);
        }
    }
}
