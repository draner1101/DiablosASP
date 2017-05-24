namespace Diablos_Archives.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NoEmbauche")]
    public partial class NoEmbauche
    {
        public int Id { get; set; }

        public int IdPersonne { get; set; }

        [Required]
        [StringLength(25)]
        public string Numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateEmbauche { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateFin { get; set; }

        public virtual Personne Personne { get; set; }
    }
}
