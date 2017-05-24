namespace Diablos_Archives.Model
{
    using Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personne")]
    public partial class Personne : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personne()
        {
            Artisans = new HashSet<Artisan>();
            Joueurs = new HashSet<Joueur>();
            NoEmbauches = new HashSet<NoEmbauche>();
            Personnes = new HashSet<Personne>();
            Telephones = new HashSet<Telephone>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(35)]
        public string Nom { get; set; }

        [Required]
        [StringLength(35)]
        public string Prenom { get; set; }

        public byte Sexe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateNaissance { get; set; }

        [StringLength(255)]
        public string Courriel { get; set; }

        public int? IdProvince { get; set; }

        [StringLength(40)]
        public string Ville { get; set; }

        [StringLength(255)]
        public string Rue { get; set; }

        [StringLength(6)]
        public string CodePostal { get; set; }

        public int? IdParent { get; set; }

        [Required]
        [StringLength(35)]
        public string Statut { get; set; }

        public int? IdContact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artisan> Artisans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Joueur> Joueurs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NoEmbauche> NoEmbauches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personne> Personnes { get; set; }

        public virtual Personne Parent { get; set; }

        public virtual Province Province { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Telephone> Telephones { get; set; }
    }
}
