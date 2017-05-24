namespace Diablos_Archives.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entraineur")]
    public partial class Entraineur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entraineur()
        {
            Entraineurs = new HashSet<Entraineur>();
            EntraineurEquipes = new HashSet<EntraineurEquipe>();
            EntraineurTypes = new HashSet<EntraineurType>();
        }

        public int Id { get; set; }

        public int IdPersonne { get; set; }

        public int? IdParent { get; set; }

        [StringLength(35)]
        public string Statut { get; set; }

        public int? IdContact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entraineur> Entraineurs { get; set; }

        public virtual Entraineur Parent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntraineurEquipe> EntraineurEquipes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntraineurType> EntraineurTypes { get; set; }
    }
}
