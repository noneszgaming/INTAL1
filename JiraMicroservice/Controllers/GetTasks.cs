using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlanningProject.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace JiraMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GetTasks : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public GetTasks(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseUrl = Environment.GetEnvironmentVariable("jira_url");
            var email = Environment.GetEnvironmentVariable("jira_email");
            var api = Environment.GetEnvironmentVariable("jira_api_key");

            var byteArray = System.Text.Encoding.ASCII.GetBytes($"{email}:{api}");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }

        public IssueResponse? IssueResponse { get; private set; }

        [HttpGet("{customValue}")]
        public async Task<IActionResult> Get(string customValue)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}agile/1.0/sprint/{customValue}/issue");
            if (response.IsSuccessStatusCode)
            {

                var jsonString = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var issueResponse = JsonSerializer.Deserialize<IssueResponse>(jsonString, options);

                var simplifiedIssues = issueResponse.Issues.Select(issue => new
                {
                    Key = issue.Key,
                    StoryPoints = issue.Fields.customfield_10016 ??=0,
                    Description = issue.Fields.Description ??= " ",
                    Sprint = issue.Fields.Sprint
                }).ToList();

                return Ok(simplifiedIssues);
            }
            return StatusCode((int)response.StatusCode);
        }
    }
}