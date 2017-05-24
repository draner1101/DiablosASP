namespace Diablos_Archives.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoleEntraineurEquipe")]
    public partial class RoleEntraineurEquipe
    {
        public int Id { get; set; }

        public int IdEntraineurEquipe { get; set; }

        public int IdRole { get; set; }

        public virtual EntraineurEquipe EntraineurEquipe { get; set; }

        public virtual Role Role { get; set; }
    }
}
