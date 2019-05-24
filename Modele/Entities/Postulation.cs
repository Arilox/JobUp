using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.Entities
{
    [Table("APP_POSTULATION")]
    public class Postulation
    {
        [Key]
        [ForeignKey("")]
        [Column("OFF_ID")]
        public int Id { get; set; }

        [Key]
        [ForeignKey("")]
        [Column("EMP_ID")]
        public int EmployeeId { get; set; }

        [Column("POS_DATE")]
        public DateTime Date { get; set; }

        [Column("POS_STATUT")]
        public Status Status { get; set; }
    }
}
