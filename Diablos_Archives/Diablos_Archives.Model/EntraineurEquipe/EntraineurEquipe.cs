namespace Diablos_Archives.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EntraineurEquipe")]
    public partial class EntraineurEquipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntraineurEquipe()
        {
            EntraineurEquipes = new HashSet<EntraineurEquipe>();
            RoleEntraineurEquipes = new HashSet<RoleEntraineurEquipe>();
        }

        public int Id { get; set; }

        public int IdEntraineur { get; set; }

        public int IdEquipe { get; set; }

        public int? IdParent { get; set; }

        [Required]
        [StringLength(35)]
        public string Statut { get; set; }

        public int? IdContact { get; set; }

        public virtual Entraineur Entraineur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntraineurEquipe> EntraineurEquipes { get; set; }

        public virtual EntraineurEquipe Parent { get; set; }

        public virtual Equipe Equipe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleEntraineurEquipe> RoleEntraineurEquipes { get; set; }
    }
}
