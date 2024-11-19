using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PlanningProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Jira : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private const string JIRA_BASE_URL = "https://planningproject2024.atlassian.net/rest/api/3/issue";

        public Jira(HttpClient httpClient)
        {
            _httpClient = httpClient;
            var byteArray = System.Text.Encoding.ASCII.GetBytes("planningproject2024@gmail.com:ATATT3xFfGF0yaIyJjg2iRqBgzUiTGCgGPLgAgHAPFVRr3TymLyTZjzTHTcvVqJTh-evaAS2obEGpO8GS9tP_lcaTZUxS0nNPT-KsPhYChBclMLniJUvWPkq0WTs4c9xq__qORhaBkvzueEWNGY3zW15meS-0r8dReEPzT9liGOEzCBNq5Bi1RU=49BB3325");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            _httpClient.BaseAddress = new Uri(JIRA_BASE_URL);
        }

        [HttpGet("task/{issueKey}/{storyPoints}")]
        public async Task<IActionResult> UpdateStoryPoints(string issueKey, int storyPoints)
        {
            var updateData = new
            {
                fields = new
                {
                    customfield_10016 = storyPoints
                }
            };
            var response = await _httpClient.PutAsJsonAsync($"{JIRA_BASE_URL}/{issueKey}", updateData);

            if (response.IsSuccessStatusCode)
            {
                return Ok($"Story points updated for {issueKey} to {storyPoints}");
            }

            return BadRequest("Failed to update story points");
        }
    }
}
