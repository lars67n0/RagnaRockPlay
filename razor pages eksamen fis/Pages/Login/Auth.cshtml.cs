using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace razor_pages_eksamen_fis.Pages.Login
{
    public class AuthModel : PageModel
    {
        [BindProperty]
        public  Login Login { get; set; }
        public void OnGet()
        {
            

        }

        public async Task<IActionResult> OnpostAsync()
        {
            if (!ModelState.IsValid) return Page();

            if (Login.UserName == "admin" && Login.Password == "password")
            {

                var Claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Email, "admin@ad.com")
                };

                var identity = new ClaimsIdentity(Claims, "MyAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MyAuth", claimsPrincipal);
                return RedirectToPage("/RockSound/Index");

            }

            return Page();

        }

    }
    public class Login
    {
        [Required]
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
