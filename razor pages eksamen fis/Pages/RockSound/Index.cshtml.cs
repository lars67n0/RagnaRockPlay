using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using razor_pages_eksamen_fis.Data;
using razor_pages_eksamen_fis.Models;

namespace razor_pages_eksamen_fis.Pages.RockSound
{
    public class IndexModel : PageModel
    {
        private readonly razor_pages_eksamen_fis.Data.razor_pages_eksamen_fisContext _context;

        public IndexModel(razor_pages_eksamen_fis.Data.razor_pages_eksamen_fisContext context)
        {
            _context = context;
        }

        public IList<SoundList> SoundList { get;set; }

        public async Task OnGetAsync()
        {
            SoundList = await _context.SoundList.ToListAsync();
        }

        

       
       
    }
}
