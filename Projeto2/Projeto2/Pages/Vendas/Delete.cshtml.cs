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
    public class DeleteModel : PageModel
    {
        private readonly Projeto2.Data.Projeto2Context _context;

        public DeleteModel(Projeto2.Data.Projeto2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Venda Venda { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Venda = await _context.Venda.FirstOrDefaultAsync(m => m.ID == id);

            if (Venda == null)
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

            Venda = await _context.Venda.FindAsync(id);

            if (Venda != null)
            {
                _context.Venda.Remove(Venda);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
