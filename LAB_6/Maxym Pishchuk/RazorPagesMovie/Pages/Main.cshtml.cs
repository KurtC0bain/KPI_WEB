using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PishchukM.Pages
{

    public class MainModel : PageModel
    {
        private readonly ILogger<MainModel> _logger;

        public MainModel(ILogger<MainModel> logger)
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
