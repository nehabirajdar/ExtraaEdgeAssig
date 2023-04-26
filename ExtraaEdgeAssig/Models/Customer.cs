using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtraaEdgeAssig.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustId { get; set; }
        [Required]
        public string CustName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        public string Address { get; set; }

    }
}
