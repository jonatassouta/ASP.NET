using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2.Pages.Vendas
{
    public class Venda
    {
        public int ID { get; set; }
        public string NomeProduto { get; set; }
        [Display(Name = "Data Venda")]
        public DateTime dataVenda { get; set; }
        public decimal ValorVenda { get; set; }
        [Required]
        [StringLength(30)]
        [MinLength(3)]
        public string Cliente { get; set; }
        [Required]
        public decimal QuantidadeVendida { get; set; }
    }
}
