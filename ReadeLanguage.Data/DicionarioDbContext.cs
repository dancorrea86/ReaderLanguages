using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ReadeLanguage.Data.Negocio;

namespace ReadeLanguage.Data
{
    public class DicionarioDbContext : DbContext
    {
        public DbSet<Palavra> Palavras { get; set; }
        public DbSet<PalavraFrances> PalavrasFrances { get; set; }
        public DbSet<PalavraIngles> PalavrasIngles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOPDANIEL;Database=Dicionario;Trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Palavra>()
                .Property(a => a.PalavraPt)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<PalavraFrances>()
                .Property(a => a.PalavraFr)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<PalavraIngles>()
                .Property(a => a.PalavraEn)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}