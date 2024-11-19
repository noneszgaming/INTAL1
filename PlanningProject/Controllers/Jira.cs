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

        public Jira(HttpClient httpClient)
        {
            _httpClient = httpClient;
            var byteArray = System.Text.Encoding.ASCII.GetBytes("planningproject2024@gmail.com:ATATT3xFfGF0J5UM1F9-GRS9CoBH3dc1OZOwiIfWpdbqzL9-tVJx_U_0uE2xeFEUKELhd3JZ0XRyZwYTQEprXBxCpvHJYsGI8T-3FBHEXf85SRhDckb4F13EwsvVZjKd0_oByQ4b4oFULbYZ_eVC9IZqXyXyXS0zPr-GOnbtMsyZO07cyu5pDTs=26FF72F7");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
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


        // Other actions can be similarly updated to handle Jira data
    }
}
