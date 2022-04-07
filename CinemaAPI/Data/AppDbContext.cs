using CinemaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EnderecoModel>()
                .HasOne(endereco => endereco.Cinema)
                .WithOne(cinema => cinema.Endereco)
                .HasForeignKey<CinemaModel>(cinema => cinema.EnderecoId);

            builder.Entity<CinemaModel>()
                .HasOne(cinema => cinema.Gerente)
                .WithMany(gerente => gerente.Cinemas)
                .HasForeignKey(cinema => cinema.GerenteId);

            builder.Entity<SessaoModel>()
                .HasOne(sessao => sessao.Filme)
                .WithMany(filme => filme.Sessoes)
                .HasForeignKey(sessao => sessao.FilmeId);

            builder.Entity<SessaoModel>()
                .HasOne(sessao => sessao.Cinema)
                .WithMany(cinema => cinema.Sessoes)
                .HasForeignKey(sessao => sessao.CinemaId);

        }

        public DbSet<FilmeModel> Filmes { get; set; }
        public DbSet<CinemaModel> Cinemas { get; set; }
        public DbSet<EnderecoModel> Enderecos { get; set; }
        public DbSet<GerenteModel> Gerentes { get; set; }
        public DbSet<SessaoModel> Sessoes { get; set; }
    }
}