namespace Diablos_Archives.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Telephone")]
    public partial class Telephone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Telephone()
        {
            Telephones = new HashSet<Telephone>();
        }

        public int Id { get; set; }

        public int IdPersonne { get; set; }

        [Required]
        [StringLength(15)]
        public string Numero { get; set; }

        [StringLength(10)]
        public string Extension { get; set; }

        [StringLength(35)]
        public string Lieu { get; set; }

        public int? IdParent { get; set; }

        [Required]
        [StringLength(35)]
        public string Statut { get; set; }

        public int? IdContact { get; set; }

        public virtual Personne Personne { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Telephone> Telephones { get; set; }

        public virtual Telephone Parent { get; set; }
    }
}
