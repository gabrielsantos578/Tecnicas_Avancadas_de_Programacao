using Microsoft.EntityFrameworkCore;
using Restaurante.Models;

namespace Restaurante.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<JuridicoModel> Juridicos { get; set; }
        public DbSet<FisicoModel> Fisicos { get; set; }
        public DbSet<LocacaoModel> Locacoes { get; set; }
        public DbSet<CarroModel> Carros { get; set; }
        public DbSet<LocacaoCarroModel> LocacaoCarros { get; set; }
    }
}
