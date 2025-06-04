using Microsoft.EntityFrameworkCore;
using WebApiFuncionario.Models;

namespace WebApi_Funcionario.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}