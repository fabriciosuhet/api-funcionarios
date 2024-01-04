using Microsoft.EntityFrameworkCore;
using webapifuturo.Models;

namespace webapifuturo.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options)
        {
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
