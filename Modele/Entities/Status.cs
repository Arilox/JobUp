using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.Entities
{
    [Table("APP_STATUS")]
    public class Status
    {
        [Key]
        [Column("STA_ID")]
        public int Id { get; set; }

        [Column("STA_LIBELE")]
        public string Libele { get; set; }
    }
}
