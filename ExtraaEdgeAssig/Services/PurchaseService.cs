using ExtraaEdgeAssig.Models;
using ExtraaEdgeAssig.Repositories;

namespace ExtraaEdgeAssig.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _repo;
        public PurchaseService(IPurchaseRepository repo)
        {
            _repo = repo;
        }

        public int AddPurchase(Purchase purchase)
        {
            return _repo.AddPurchase(purchase);
        }
        public int DeletePurchase(int id)
        {
            return _repo.DeletePurchase(id);
        }
        public Purchase GetPurchaseById(int id)
        {
            return _repo.GetPurchaseById(id);
        }
        public IEnumerable<Purchase> GetAllPurchases()
        {
            return _repo.GetAllPurchases();
        }
        public int UpdatePurchase(Purchase purchase)
        {
            return _repo.UpdatePurchase(purchase);
        }

    }

}