using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace infnetMVC.Models
{
    public class InfnetDbContexto : IdentityDbContext
    {
        public DbSet<Funcionario> Funcionario { get; set; }

        public DbSet<Departamento> Departamento { get; set; }

        public InfnetDbContexto(DbContextOptions<InfnetDbContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Funcionario>()
                    .HasOne(f => f.Departamento)
                    .WithMany(d => d.Funcionarios)
                    .HasForeignKey(f => f.DepartamentoId);
        }
    }
}
