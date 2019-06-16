using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.Entities
{
    [Table("APP_OFFRE")]
    public class Offre
    {
        [Key]
        [Column("OFF_ID")]
        public int Id { get; set; }

        [Column("OFF_INTITULE")]
        public string Intitule { get; set; }

        [Column("OFF_DATE")]
        public DateTime Date { get; set; }

        [Column("OFF_SALAIRE")]
        public float Salaire { get; set; }

        [Column("OFF_DESCRIPTION")]
        public string Description { get; set; }

        [ForeignKey("")]
        [Column("OFF_STATUT")]
        public Boolean Statut { get; set; }

        [Column("RESP_ID")]
        public int ResponsableId { get; set; }

        [ForeignKey("ResponsableId")]
        public Employe Responsable { get; set; }
    }
}
