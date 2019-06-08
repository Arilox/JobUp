using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Modele.Entities
{
    [Table("APP_EMPLOYE")]
    public class Employe
    {
        [Key]
        [Column("EMP_ID")]
        public int Id { get; set; }

        [Column("EMP_NOM")]
        public string Nom { get; set; }


        [Column("EMP_PRENOM")]
        public string Prenom { get; set; }

        [Column("EMP_DATENAISSANCE")]
        public DateTime DateNaissance { get; set; }

        [Column("EMP_ANVIENNETE")]
        public float Ancienete { get; set; }

        [Column("EMP_BIOGRAPHIE")]
        public string Biographie { get; set; }
    }
}
