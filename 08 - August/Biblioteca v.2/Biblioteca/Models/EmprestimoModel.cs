namespace Biblioteca.Models
{
    public class EmprestimoModel
    {

        // Modelo do Banco de Dados
        public int Id { get; set; }
        public string Recebedor { get; set; }
        public string Fornecedor { get; set; }
        public string NomeLivro { get; set;}
        public DateTime DataEmprestimo { get; set; } = DateTime.Now; 
        // DateTime.Now = Pega a data (atual) da máquina.

    }
}
