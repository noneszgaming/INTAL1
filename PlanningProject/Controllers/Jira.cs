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
            var byteArray = System.Text.Encoding.ASCII.GetBytes("planningproject2024@gmail.com:ATATT3xFfGF01NMkKpNj4DUNV8KyPb0GWXKwAa1jtjrucR22c_lroCV5iEW7tscQcnZhwB4MhefjVVMdVlxPeJAWEl5egbX9MZxL211zsv9XX5Z0ambRpIKfGLK0-3-mRNCc6dLi0Dlh88zb9zlHfXoZCIqc5m8YP_Oe2xhkAl8ApAxzWRhXbY0=8835AC2B");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

  

        // Other actions can be similarly updated to handle Jira data
    }
}
