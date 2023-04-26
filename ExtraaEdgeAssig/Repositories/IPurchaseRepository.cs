using ExtraaEdgeAssig.Models;

namespace ExtraaEdgeAssig.Repositories
{
    public interface IPurchaseRepository
    {
        IEnumerable<Purchase> GetAllPurchases();
        Purchase GetPurchaseById(int id);
        int AddPurchase(Purchase purchase);
        int UpdatePurchase(Purchase purchase);
        int DeletePurchase(int id);
    }
}
