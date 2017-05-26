namespace Diablos_Archives.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DiablosDB : DbContext
    {
        public DiablosDB()
            : base("name=DiablosDB1")
        {
        }

        public virtual DbSet<Artisan> Artisans { get; set; }
        public virtual DbSet<Entraineur> Entraineurs { get; set; }
        public virtual DbSet<EntraineurEquipe> EntraineurEquipes { get; set; }
        public virtual DbSet<EntraineurType> EntraineurTypes { get; set; }
        public virtual DbSet<Equipe> Equipes { get; set; }
        public virtual DbSet<Joueur> Joueurs { get; set; }
        public virtual DbSet<JoueurEquipe> JoueurEquipes { get; set; }
        public virtual DbSet<NoEmbauche> NoEmbauches { get; set; }
        public virtual DbSet<Personne> Personnes { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleEntraineurEquipe> RoleEntraineurEquipes { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Telephone> Telephones { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artisan>()
                .HasMany(e => e.Roles)
                .WithMany(e => e.Artisans)
                .Map(m => m.ToTable("ArtisanRole").MapLeftKey("IdArtisan").MapRightKey("IdRole"));

            modelBuilder.Entity<Entraineur>()
                .HasMany(e => e.Entraineurs)
                .WithOptional(e => e.Parent)
                .HasForeignKey(e => e.IdParent);

            modelBuilder.Entity<Entraineur>()
                .HasMany(e => e.EntraineurEquipes)
                .WithRequired(e => e.Entraineur)
                .HasForeignKey(e => e.IdEntraineur);

            modelBuilder.Entity<Entraineur>()
                .HasMany(e => e.EntraineurTypes)
                .WithRequired(e => e.Entraineur)
                .HasForeignKey(e => e.IdEntraineur);

            modelBuilder.Entity<EntraineurEquipe>()
                .HasMany(e => e.EntraineurEquipes)
                .WithOptional(e => e.Parent)
                .HasForeignKey(e => e.IdParent);

            modelBuilder.Entity<EntraineurEquipe>()
                .HasMany(e => e.RoleEntraineurEquipes)
                .WithRequired(e => e.EntraineurEquipe)
                .HasForeignKey(e => e.IdEntraineurEquipe);

            modelBuilder.Entity<EntraineurType>()
                .HasMany(e => e.EntraineurTypes)
                .WithOptional(e => e.Parent)
                .HasForeignKey(e => e.IdParent);

            modelBuilder.Entity<Equipe>()
                .Property(e => e.Saison)
                .IsFixedLength();

            modelBuilder.Entity<Equipe>()
                .HasMany(e => e.EntraineurEquipes)
                .WithRequired(e => e.Equipe)
                .HasForeignKey(e => e.IdEquipe);

            modelBuilder.Entity<Equipe>()
                .HasMany(e => e.Equipes)
                .WithOptional(e => e.Parent)
                .HasForeignKey(e => e.IdParent);

            modelBuilder.Entity<Equipe>()
                .HasMany(e => e.JoueurEquipes)
                .WithRequired(e => e.Equipe)
                .HasForeignKey(e => e.IdEquipe);

            modelBuilder.Entity<Joueur>()
                .Property(e => e.TailleCm)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Joueur>()
                .Property(e => e.PoidsKg)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Joueur>()
                .HasMany(e => e.Joueurs)
                .WithOptional(e => e.Parent)
                .HasForeignKey(e => e.IdParent);

            modelBuilder.Entity<Joueur>()
                .HasMany(e => e.JoueurEquipes)
                .WithRequired(e => e.Joueur)
                .HasForeignKey(e => e.IdJoueur);

            modelBuilder.Entity<JoueurEquipe>()
                .HasMany(e => e.JoueurEquipes)
                .WithOptional(e => e.Parent)
                .HasForeignKey(e => e.IdParent);

            modelBuilder.Entity<Personne>()
                .HasMany(e => e.Artisans)
                .WithOptional(e => e.Personne)
                .HasForeignKey(e => e.IdPersonne)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Personne>()
                .HasMany(e => e.Joueurs)
                .WithRequired(e => e.Personne)
                .HasForeignKey(e => e.IdPersonne);

            modelBuilder.Entity<Personne>()
                .HasMany(e => e.NoEmbauches)
                .WithRequired(e => e.Personne)
                .HasForeignKey(e => e.IdPersonne);

            modelBuilder.Entity<Personne>()
                .HasMany(e => e.Personnes)
                .WithOptional(e => e.Parent)
                .HasForeignKey(e => e.IdParent);

            modelBuilder.Entity<Personne>()
                .HasMany(e => e.Telephones)
                .WithRequired(e => e.Personne)
                .HasForeignKey(e => e.IdPersonne);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.Personnes)
                .WithOptional(e => e.Province)
                .HasForeignKey(e => e.IdProvince)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Role>()
                .HasMany(e => e.RoleEntraineurEquipes)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.IdRole);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Sports)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("RoleSport").MapLeftKey("IdRole").MapRightKey("IdSport"));

            modelBuilder.Entity<Sport>()
                .HasMany(e => e.Equipes)
                .WithRequired(e => e.Sport)
                .HasForeignKey(e => e.IdSport);

            modelBuilder.Entity<Telephone>()
                .Property(e => e.Numero)
                .IsFixedLength();

            modelBuilder.Entity<Telephone>()
                .HasMany(e => e.Telephones)
                .WithOptional(e => e.Parent)
                .HasForeignKey(e => e.IdParent);

            modelBuilder.Entity<Type>()
                .HasMany(e => e.EntraineurTypes)
                .WithRequired(e => e.Type)
                .HasForeignKey(e => e.IdType);
        }

        public System.Data.Entity.DbSet<Diablos_Archives.Model.JoueurViewModel> JoueurViewModels { get; set; }
    }
}
