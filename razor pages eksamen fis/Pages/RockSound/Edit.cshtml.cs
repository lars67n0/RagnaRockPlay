using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using razor_pages_eksamen_fis.Data;
using razor_pages_eksamen_fis.Models;

namespace razor_pages_eksamen_fis.Pages.RockSound
{
    public class EditModel : PageModel
    {
        private readonly razor_pages_eksamen_fis.Data.razor_pages_eksamen_fisContext _context;

        public EditModel(razor_pages_eksamen_fis.Data.razor_pages_eksamen_fisContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SoundList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SoundListExists(SoundList.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SoundListExists(int id)
        {
            return _context.SoundList.Any(e => e.ID == id);
        }
    }
}
