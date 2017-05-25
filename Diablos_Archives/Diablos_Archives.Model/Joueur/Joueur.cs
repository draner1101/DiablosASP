namespace Diablos_Archives.Model
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Joueur")]
    public partial class Joueur : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Joueur()
        {
            Joueurs = new HashSet<Joueur>();
            JoueurEquipes = new HashSet<JoueurEquipe>();
            Statut = "Actif";
        }

        [Key]
        public int Id { get; set; }

        public int IdPersonne { get; set; }

        public decimal? TailleCm { get; set; }

        public decimal? PoidsKg { get; set; }

        [StringLength(50)]
        public string EcoleSecondaire { get; set; }

        [StringLength(40)]
        public string VilleNatale { get; set; }

        [StringLength(100)]
        public string DomaineEtude { get; set; }

        public int? IdParent { get; set; }

        [Required]
        [StringLength(35)]
        public string Statut { get; set; }

        public int? IdContact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Joueur> Joueurs { get; set; }

        public virtual Joueur Parent { get; set; }

        public virtual Personne Personne { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JoueurEquipe> JoueurEquipes { get; set; }
    }
}
