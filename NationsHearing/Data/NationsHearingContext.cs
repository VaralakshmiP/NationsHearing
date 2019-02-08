using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NationsHearing.Models
{
    public class NationsHearingContext : DbContext
    {
        public NationsHearingContext (DbContextOptions<NationsHearingContext> options)
            : base(options)
        {
        }

        public DbSet<NationsHearing.Models.Menu> Menu { get; set; }
    }
}
