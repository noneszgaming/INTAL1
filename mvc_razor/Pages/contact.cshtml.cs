using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mvc_razor.Pages
{
    public class contactModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Message { get; set; }

        public string ResponseMessage { get; private set; }
        public void OnGet()
        {
        }
        public void OnPost() {
            ResponseMessage = $"szia {Name} üzenet {Message}";
        }
    }
}
