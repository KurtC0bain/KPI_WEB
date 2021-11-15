using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task2_lab6.Pages
{
    public class FormModel : PageModel
    {
        private readonly ILogger<FormModel> _logger;

        public FormModel(ILogger<FormModel> logger)
        {
            _logger = logger;
        }
       
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string password { get; set; }
        public void OnPost()
        {
            firstname = Request.Form["firstname"];
            lastname = Request.Form["lastname"];
            password = Request.Form["Password"];
        }
    }
}
