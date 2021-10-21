using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2.Pages.Estoque
{
    public class Estoque
    {
        public int ID { get; set; }
        public string NomeProduto { get; set; }
        [Display(Name = "Data Admissao")]
        public DateTime dataCompra { get; set; }
        public decimal ValorCompra { get; set; }
        [Required]
        [StringLength(30)]
        [MinLength(3)]
        public decimal Quantidade { get; set; }
        [Required]
        public string Categoria { get; set; }
    }
}
