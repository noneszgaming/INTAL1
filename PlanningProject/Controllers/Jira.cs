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
            var byteArray = System.Text.Encoding.ASCII.GetBytes("planningproject2024@gmail.com:ATATT3xFfGF0J5UM1F9-GRS9CoBH3dc1OZOwiIfWpdbqzL9-tVJx_U_0uE2xeFEUKELhd3JZ0XRyZwYTQEprXBxCpvHJYsGI8T-3FBHEXf85SRhDckb4F13EwsvVZjKd0_oByQ4b4oFULbYZ_eVC9IZqXyXyXS0zPr-GOnbtMsyZO07cyu5pDTs=26FF72F7");
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
    }
}
