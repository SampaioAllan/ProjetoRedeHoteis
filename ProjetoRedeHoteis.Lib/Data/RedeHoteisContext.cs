using Microsoft.EntityFrameworkCore;
using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data
{
    public class RedeHoteisContext : DbContext
    {
        public RedeHoteisContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //mapeando tabelas

            //CategoriaQuarto
            modelBuilder.Entity<CategoriaQuarto>().ToTable("rh_categorias_quarto");
            modelBuilder.Entity<CategoriaQuarto>().HasKey(key => key.GetId());
            modelBuilder.Entity<CategoriaQuarto>()
                                         .HasMany(quarto => quarto.Quartos)
                                         .WithOne(x => x.Categoria)
                                         .HasForeignKey(x => x.GetIdCategoria());
            //Estadia
            modelBuilder.Entity<Estadia>().ToTable("rh_estadias");
            modelBuilder.Entity<Estadia>().HasKey(key => key.GetId());
            modelBuilder.Entity<Estadia>()
                                         .HasOne(x => x.Quarto)
                                         .WithMany(x => x.Estadias)
                                         .HasForeignKey(x => x.GetIdQuarto());
            modelBuilder.Entity<Estadia>()
                                         .HasMany(x => x.EstadiasHospedes)
                                         .WithOne(x => x.Estadia)
                                         .HasForeignKey(x => x.GetIdEstadia());
            //EstadiaHospede
            modelBuilder.Entity<EstadiaHospede>().ToTable("rh_estadias_hospedes");
            modelBuilder.Entity<EstadiaHospede>().HasKey(key => key.GetId());
            modelBuilder.Entity<EstadiaHospede>()
                                         .HasOne(x => x.Estadia)
                                         .WithMany(x => x.EstadiasHospedes)
                                         .HasForeignKey(x => x.GetIdEstadia());
            modelBuilder.Entity<EstadiaHospede>()
                                         .HasOne(x => x.Hospede)
                                         .WithMany(x => x.EstadiasHospedes)
                                         .HasForeignKey(x => x.GetIdHospede());
            //Hospede
            modelBuilder.Entity<Hospede>().ToTable("rh_hospedes");
            modelBuilder.Entity<Hospede>().HasKey(key => key.GetId());
            modelBuilder.Entity<Hospede>()
                                         .HasMany(x => x.Estadias)
                                         .WithOne(x => x.Responsavel)
                                         .HasForeignKey(x => x.GetIdResponsavel());
            modelBuilder.Entity<Hospede>()
                                         .HasMany(x => x.EstadiasHospedes)
                                         .WithOne(x => x.Hospede)
                                         .HasForeignKey(x => x.GetIdHospede());
            //Hotel
            modelBuilder.Entity<Hotel>().ToTable("rh_hoteis");
            modelBuilder.Entity<Hotel>().HasKey(key => key.GetId());
            modelBuilder.Entity<Hotel>()
                                         .HasMany(x => x.ServicosHoteis)
                                         .WithOne(x => x.Hotel)
                                         .HasForeignKey(x => x.GetIdHotel());
            modelBuilder.Entity<Hotel>()
                                         .HasMany(x => x.Quartos)
                                         .WithOne(x => x.Hotel)
                                         .HasForeignKey(x => x.GetIdHotel());
            //Quarto
            modelBuilder.Entity<Quarto>().ToTable("rh_quartos");
            modelBuilder.Entity<Quarto>().HasKey(key => key.GetId());
            modelBuilder.Entity<Quarto>()
                                         .HasOne(x => x.Hotel)
                                         .WithMany(x => x.Quartos)
                                         .HasForeignKey(x => x.GetId());
            modelBuilder.Entity<Quarto>()
                                         .HasOne(x => x.Categoria)
                                         .WithMany(x => x.Quartos)
                                         .HasForeignKey(x => x.GetId());
            modelBuilder.Entity<Quarto>()
                                         .HasMany(x => x.Estadias)
                                         .WithOne(x => x.Quarto)
                                         .HasForeignKey(x => x.GetIdQuarto());
            //Servico
            modelBuilder.Entity<Servico>().ToTable("rh_servicos");
            modelBuilder.Entity<Servico>().HasKey(key => key.GetId());
            modelBuilder.Entity<Servico>()
                                         .HasMany(x => x.ServicosHoteis)
                                         .WithOne(x => x.Servico)
                                         .HasForeignKey(x => x.GetIdServico());
            
            //ServicoHotel
            modelBuilder.Entity<ServicoHotel>().ToTable("rh_servicos_hoteis");
            modelBuilder.Entity<ServicoHotel>().HasKey(key => key.GetId());
            modelBuilder.Entity<ServicoHotel>()
                                         .HasOne(x => x.Servico)
                                         .WithMany(x => x.ServicosHoteis)
                                         .HasForeignKey(x => x.GetId());
            modelBuilder.Entity<ServicoHotel>()
                                         .HasOne(x => x.Hotel)
                                         .WithMany(x => x.ServicosHoteis)
                                         .HasForeignKey(x => x.GetId());
        }
        public DbSet<CategoriaQuarto> CategoriasQuarto { get; set; }
        public DbSet<Estadia> Estadias { get; set; }
        public DbSet<EstadiaHospede> EstadiasHospedes { get; set; }
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ServicoHotel> ServicosHoteis { get; set; }
    }
}