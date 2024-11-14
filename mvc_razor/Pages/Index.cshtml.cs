using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mvc_razor.Pages
{
    public class IndexModel : PageModel
    {
        public string CurrentTime { get; set; }
        private readonly ILogger<IndexModel> _logger;
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            CurrentTime = DateTime.Now.ToLongDateString();
        }
    }
}
