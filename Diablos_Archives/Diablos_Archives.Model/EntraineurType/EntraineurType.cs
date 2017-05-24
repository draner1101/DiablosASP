namespace Diablos_Archives.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EntraineurType")]
    public partial class EntraineurType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntraineurType()
        {
            EntraineurTypes = new HashSet<EntraineurType>();
        }

        public int Id { get; set; }

        public int IdEntraineur { get; set; }

        public int IdType { get; set; }

        public int? IdParent { get; set; }

        [Required]
        [StringLength(35)]
        public string Statut { get; set; }

        public int? IdContact { get; set; }

        public virtual Entraineur Entraineur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntraineurType> EntraineurTypes { get; set; }

        public virtual EntraineurType Parent { get; set; }

        public virtual Type Type { get; set; }
    }
}
