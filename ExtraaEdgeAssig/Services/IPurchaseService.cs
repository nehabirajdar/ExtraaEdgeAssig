using ExtraaEdgeAssig.Models;

namespace ExtraaEdgeAssig.Services
{
    public interface IPurchaseService
    {
        IEnumerable<Purchase> GetAllPurchases();
        Purchase GetPurchaseById(int id);
        int AddPurchase(Purchase purchase);
        int UpdatePurchase(Purchase purchase);
        int DeletePurchase(int id);

    }
}
