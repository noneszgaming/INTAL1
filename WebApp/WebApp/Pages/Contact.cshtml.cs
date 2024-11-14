using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Message { get; set; }

        public string ResponseMessage { get; set; }

        public void OnPost()
        {
            ResponseMessage = $"Köszönjük, {Name}. Üzenete: {Message}";
        }
    }
}
