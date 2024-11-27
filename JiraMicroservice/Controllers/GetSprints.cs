using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace JiraMicroservice.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GetSprints : ControllerBase {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public GetSprints(HttpClient httpClient) {
            _httpClient = httpClient;
            _baseUrl = Environment.GetEnvironmentVariable("jira_url");
            var email = Environment.GetEnvironmentVariable("jira_email");
            var api = Environment.GetEnvironmentVariable("jira_api_key");

            var byteArray = System.Text.Encoding.ASCII.GetBytes($"{email}:{api}");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }

        [HttpGet]
        public async Task<IActionResult> Get() {
            var response = await _httpClient.GetAsync($"{_baseUrl}agile/1.0/board/3/sprint");
            if (response.IsSuccessStatusCode) {
                var data = await response.Content.ReadAsStringAsync();
                return Ok(data);
            }
            return StatusCode((int)response.StatusCode);
        }
    }
}
