using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razor_pages_eksamen_fis.Models;

namespace razor_pages_eksamen_fis.Data
{
    public class razor_pages_eksamen_fisContext : DbContext
    {
        public razor_pages_eksamen_fisContext (DbContextOptions<razor_pages_eksamen_fisContext> options)
            : base(options)
        {
        }

        public DbSet<razor_pages_eksamen_fis.Models.SoundList> SoundList { get; set; }
    }
}
