using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Text.Json;
using PlanningProject.Models;
using PlanningProject.Data;
using Microsoft.EntityFrameworkCore;

namespace PlanningProject.Pages.Shared.Components
{
    public class LobbySprintPanelViewComponent : ViewComponent
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly ApplicationDbContext _context;

        public LobbySprintPanelViewComponent(HttpClient httpClient, IHttpContextAccessor httpContextAccessor, ApplicationDbContext context)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sprints = await _context.Sprints.ToListAsync();

            var model = new LobbySprintPanelViewModel();
            model.Sprints = sprints;

            return View("LobbySprintPanel", model);
        }
    }
}
