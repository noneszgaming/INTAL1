using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace JiraMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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

        [HttpGet("{customValue}")]
        public async Task<IActionResult> Get(string customValue)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}agile/1.0/sprint/{customValue}/issue");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return Ok(data);
            }
            return StatusCode((int)response.StatusCode);
        }
    }
}