using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models
{
    public class JuridicoModel : ClienteModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o cpf!")]
        public string? CPF { get; set; }

        [Required(ErrorMessage = "Digite o rg!")]
        public string? RG { get; set; }

    }
}
