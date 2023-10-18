using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Models
{
    public class FisicoModel : ClienteModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o cnpj!")]
        public string? CNPJ { get; set; }

        [Required(ErrorMessage = "Digite o nome fantasma!")]
        public string? NomeFantasma { get; set; }

    }
}
