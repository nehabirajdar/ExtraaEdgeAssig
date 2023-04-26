
using System.ComponentModel.DataAnnotations;
namespace ExtraaEdgeAssig.Models
{
    public class MobilePurchase
    {
        public int CustId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int PurPrice { get; set; }
        public int Discount { get; set; }   
        public int FinalPrice { get; set; } 
        public int Price { get; set; }  
    }
}
