using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { 
            
        }

        // Criando as Tabelas.
        public DbSet<EmprestimoModel> Emprestimos { get; set; }
    }
}
