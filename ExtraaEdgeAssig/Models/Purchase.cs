using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace ExtraaEdgeAssig.Models
{

    [Table("Purchase")]

    public class Purchase
    {
        [Key]
        public int PId { get; set; }
        [Required]
        public int CustId { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]

        public DateTime PurchaseDate { get; set; }
        [Required]
        public int PurPrice { get; set; }
        [Required]
        public int Discount { get; set; }
        [Required]
        public int FinalPrice { get; set; }
    }
}
