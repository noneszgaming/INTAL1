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
            var byteArray = System.Text.Encoding.ASCII.GetBytes("planningproject2024@gmail.com:ATATT3xFfGF0w_vC5oOrtDH9hdx1z97kXNmq3UNyNnuVQAIdJPr7BATWPA8vaO4wpYGabMzKeBFAtV1F48NnQDosb8RkYXrl0gNYqQKNSxcwubg29fmFPiMYAbjAaijSHsHdxLG6E0KbEXaMi93V12XOfaj0QLDA41xU6D_tb85w9uEcYlZRDyg=F31CD981");
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

        [HttpGet("tasks/{customValue}")]
        public async Task<IActionResult> GetTasks(string customValue)
        {
            var response = await _httpClient.GetAsync($"https://planningproject2024.atlassian.net/rest/agile/1.0/sprint/{customValue}/issue");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return Ok(data);
            }
            return StatusCode((int)response.StatusCode);
        }

        // GET: api/<Jira>/sprints
        [HttpGet("sprints")]
        public async Task<IActionResult> GetSprints()
        {
            var response = await _httpClient.GetAsync("https://planningproject2024.atlassian.net/rest/agile/1.0/board/3/sprint");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return Ok(data);
            }
            return StatusCode((int)response.StatusCode);
        }



    }
}
