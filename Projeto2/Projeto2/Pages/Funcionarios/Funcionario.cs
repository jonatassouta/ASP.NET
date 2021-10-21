using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2.Pages.Funcionarios
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        [Display(Name="Data Admissao")]
        public DateTime dtAdmissao { get; set; }
        public decimal SalBruto { get; set; }
        [Required]
        [StringLength(30)]
        [MinLength (3)]
        public decimal Cidade { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
