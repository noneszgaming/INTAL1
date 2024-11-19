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
            var byteArray = System.Text.Encoding.ASCII.GetBytes("planningproject2024@gmail.com:ATATT3xFfGF0SLCL4yoivp1vtRSjY17hW8oVmrb9O9V5K8-PwkDoSPk4Cp2nc9QY0gVKB2aHRQLAJDoqSGKVGK3JXpV22We5GkIVRAssE8dB5poklnaO9HA8wCeBDTKqVySW4CiZg7tQZvAROb-6UwI-78Gkkcf0Ww_BDHLwU5WbC-puYoAwz6M=D9321DFA");
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

        }
    }
}
