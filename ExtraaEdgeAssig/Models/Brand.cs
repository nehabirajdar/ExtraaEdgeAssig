using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtraaEdgeAssig.Models
{
    [Table("Brand")]

    public class Brand
    {
        [Key]
        public int BId { get; set; }
        [Required]
        public string BName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
