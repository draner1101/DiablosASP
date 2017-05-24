namespace Diablos_Archives.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Equipe")]
    public partial class Equipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipe()
        {
            EntraineurEquipes = new HashSet<EntraineurEquipe>();
            Equipes = new HashSet<Equipe>();
            JoueurEquipes = new HashSet<JoueurEquipe>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nom { get; set; }

        public byte Sexe { get; set; }

        [Required]
        [StringLength(9)]
        public string Saison { get; set; }

        public int IdSport { get; set; }

        public int? IdParent { get; set; }

        [Required]
        [StringLength(35)]
        public string Statut { get; set; }

        public int? IdContact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntraineurEquipe> EntraineurEquipes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipe> Equipes { get; set; }

        public virtual Equipe Parent { get; set; }

        public virtual Sport Sport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JoueurEquipe> JoueurEquipes { get; set; }
    }
}
