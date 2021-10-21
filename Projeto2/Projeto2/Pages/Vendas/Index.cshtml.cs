using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projeto2.Data;

namespace Projeto2.Pages.Vendas
{
    public class IndexModel : PageModel
    {
        private readonly Projeto2.Data.Projeto2Context _context;

        public IndexModel(Projeto2.Data.Projeto2Context context)
        {
            _context = context;
        }

        public IList<Venda> Venda { get;set; }

        public async Task OnGetAsync()
        {
            Venda = await _context.Venda.ToListAsync();
        }
    }
}
