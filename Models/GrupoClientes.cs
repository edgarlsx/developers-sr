using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Annexus_API.Models
{
    public class GrupoClientes
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "A Descrição é Obrigatória.")]
        public string Nome { get; set; }

        [Display(Name = "Ativo")]
        [Required(ErrorMessage = "Ativo é Obrigatório.")]
        public bool Ativo { get; set; }

    }
}
