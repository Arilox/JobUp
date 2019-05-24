using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.Entities
{
    [Table("APP_FORMATION")]
    public class Formation
    {
        [Key]
        [Column("FOR_ID")]
        public int Id { get; set; }

        [ForeignKey("")]
        [Column("FOR_EMPLOYEE")]
        public int EmployeeId { get; set; }

        [Column("FOR_INTITULE")]
        public string Intitule { get; set; }

        [Column("FOR_DATE")]
        public DateTime Date { get; set; }
    }
}
