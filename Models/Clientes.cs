using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Annexus_API.Models
{
    public class Clientes
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Nome é Obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é Obrigatório.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "A Data do Cadastro é Obrigatório.")]
        public string DataCadastro { get; set; }

        public string Telefone { get; set; }


        public int GrupoClientesId { get; set; }
        public GrupoClientes GrupoClientes { get; set; }
    }
}
