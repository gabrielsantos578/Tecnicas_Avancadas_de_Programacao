namespace Biblioteca.Models
{
    public class EmprestimoModel
    {

        // Modelo do Empréstimo no Banco de Dados
        public int Id { get; set; }
        public string Recebedor { get; set; }
        public string Fornecedor { get; set;}
        public string Livro { get; set;}
        public DateTime Data { get; set; } = DateTime.Now;

}       
}
