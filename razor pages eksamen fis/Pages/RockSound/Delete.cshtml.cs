using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_pages_eksamen_fis.Data;
using razor_pages_eksamen_fis.Models;

namespace razor_pages_eksamen_fis.Pages.RockSound
{
    public class DeleteModel : PageModel
    {
        private readonly razor_pages_eksamen_fis.Data.razor_pages_eksamen_fisContext _context;

        public DeleteModel(razor_pages_eksamen_fis.Data.razor_pages_eksamen_fisContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SoundList SoundList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SoundList = await _context.SoundList.FirstOrDefaultAsync(m => m.ID == id);

            if (SoundList == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SoundList = await _context.SoundList.FindAsync(id);

            if (SoundList != null)
            {
                _context.SoundList.Remove(SoundList);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
