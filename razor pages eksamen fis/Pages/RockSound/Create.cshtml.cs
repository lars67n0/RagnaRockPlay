using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using razor_pages_eksamen_fis.Data;
using razor_pages_eksamen_fis.Models;

namespace razor_pages_eksamen_fis.Pages.RockSound
{
    public class CreateModel : PageModel
    {
        private readonly razor_pages_eksamen_fis.Data.razor_pages_eksamen_fisContext _context;

        public CreateModel(razor_pages_eksamen_fis.Data.razor_pages_eksamen_fisContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SoundList SoundList { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SoundList.Add(SoundList);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
