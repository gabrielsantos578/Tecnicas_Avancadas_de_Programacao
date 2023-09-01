using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models
{
    public class PedidoModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Cliente")]
        public string? Cliente { get; set; }

        public DateTime Data { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Digite o Valor do Pedido")]
        public decimal Valor { get; set; }

    }
}
