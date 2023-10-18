using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models
{
    public class ClienteModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome!")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Digite a idade!")]
        public int? Idade { get; set; }

    }
}
