using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.Entities
{
    [Table("APP_EXPERIENCE")]
    public class Experience
    {
        [Key]
        [Column("EXP_ID")]
        public int Id { get; set; }

        [Column("EMP_ID")]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employe Employe { get; set; }

        [Column("EXP_INTITULE")]
        public string Intitule { get; set; }

        [Column("EXP_DATE")]
        public int Date { get; set; }
    }
}