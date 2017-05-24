namespace Diablos_Archives.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JoueurEquipe")]
    public partial class JoueurEquipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JoueurEquipe()
        {
            JoueurEquipes = new HashSet<JoueurEquipe>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int IdJoueur { get; set; }

        public int IdEquipe { get; set; }

        public int? Position { get; set; }

        public short? Numero { get; set; }

        public int? IdParent { get; set; }

        public int Statut { get; set; }

        public int? IdContact { get; set; }

        public virtual Equipe Equipe { get; set; }

        public virtual Joueur Joueur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JoueurEquipe> JoueurEquipes { get; set; }

        public virtual JoueurEquipe Parent { get; set; }
    }
}
