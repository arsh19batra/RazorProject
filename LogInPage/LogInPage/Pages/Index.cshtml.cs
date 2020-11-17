using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LogInPage.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }
        public string Msg;
        public void OnGet()
        {
        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("useranme");
            return Page();
        }

        public IActionResult OnPost()
        {
            if(Username.Equals("user") && Password.Equals("123"))
            {
                HttpContext.Session.SetString("username", Username);
                return RedirectToPage("Welcome");
            }
            else
            {
                Msg = "Invalid User";
                return Page();
            }
        }
    }
}
