using Microsoft.EntityFrameworkCore;
using WebApiFuncionario.Models;

namespace WebApiFuncionario.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}