using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razer.Pages.Models;

namespace RazerPageWeb.Data
{
    public class RazerPageWebContext : DbContext
    {
        public RazerPageWebContext (DbContextOptions<RazerPageWebContext> options)
            : base(options)
        {
        }

        public DbSet<Razer.Pages.Models.Movie> Movie { get; set; }
    }
}
