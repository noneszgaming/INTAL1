using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace JiraMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PutTask : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public PutTask(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseUrl = Environment.GetEnvironmentVariable("jira_url");
            var email = Environment.GetEnvironmentVariable("jira_email");
            var api = Environment.GetEnvironmentVariable("jira_api_key");

            var byteArray = System.Text.Encoding.ASCII.GetBytes($"{email}:{api}");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }

        [HttpPut("task/{issueKey}/{storyPoints}")]
        public async Task<IActionResult> UpdateStoryPoints(string issueKey, int storyPoints)
        {
            var field = Environment.GetEnvironmentVariable("jira_s_point_field");
            var updateData = new
            {
                fields = new Dictionary<string, int>
                {
                    { field, storyPoints }
                }
            };

            var response = await _httpClient.PutAsJsonAsync($"{_baseUrl}api/3/issue/{issueKey}", updateData);
            if (response.IsSuccessStatusCode)
            {
                return Ok($"Story points updated for {issueKey} to {storyPoints}");
            }
            return BadRequest("Failed to update story points");
        }
    }
}
