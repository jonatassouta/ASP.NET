using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto2.Pages.Funcionarios;
using Projeto2.Pages.Estoque;
using Projeto2.Pages.Vendas;

namespace Projeto2.Data
{
    public class Projeto2Context : DbContext
    {
        public Projeto2Context (DbContextOptions<Projeto2Context> options)
            : base(options)
        {
        }

        public DbSet<Projeto2.Pages.Funcionarios.Funcionario> Funcionario { get; set; }

        public DbSet<Projeto2.Pages.Estoque.Estoque> Estoque { get; set; }

        public DbSet<Projeto2.Pages.Vendas.Venda> Venda { get; set; }
    }
}
