using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razer.Pages.Models;
using RazerPageWeb.Data;

namespace RazerPageWeb.Pages.Models
{
    public class IndexModel : PageModel
    {
        private readonly RazerPageWeb.Data.RazerPageWebContext _context;

        public IndexModel(RazerPageWeb.Data.RazerPageWebContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
