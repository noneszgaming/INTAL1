using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Text.Json;
using PlanningProject.Models;

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
                model.Sprints = sprintsResponse.Values;
            }

            return View("LobbySprintPanel", model);
        }
    }
}
