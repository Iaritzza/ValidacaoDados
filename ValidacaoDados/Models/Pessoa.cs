using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoDados.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(20, ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Range (1,100, ErrorMessage = "Você não é velho assim! Digite um valor válido")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        [Compare("Email", ErrorMessage = "Não válido")]
        public string ConfirmarEmail { get; set; }
    }
}
