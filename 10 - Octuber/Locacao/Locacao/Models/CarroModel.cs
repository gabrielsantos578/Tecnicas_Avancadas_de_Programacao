using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models
{
    public class CarroModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a marca!")]
        public string? Marca { get; set; }

        [Required(ErrorMessage = "Digite o modelo!")]
        public string? Modelo { get; set; }

    }
}
