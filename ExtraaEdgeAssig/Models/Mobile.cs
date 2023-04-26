using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtraaEdgeAssig.Models
{
    [Table("Mobile")]

    public class Mobile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BId { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
