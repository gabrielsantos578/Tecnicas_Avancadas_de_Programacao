using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models
{
    public class LocacaoModel
    {

        public int Id { get; set; }

        public DateTime DataLocacao { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Digite o valor da locação!")]
        public decimal Valor { get; set; }
        
        public string? DataDevolucao { get; set; }

    }
}
