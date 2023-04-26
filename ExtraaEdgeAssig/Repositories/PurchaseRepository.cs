using ExtraaEdgeAssig.Data;
using ExtraaEdgeAssig.Models;

namespace ExtraaEdgeAssig.Repositories
{
    public class PurchaseRepository: IPurchaseRepository
    {
        private readonly ApplicationDbContext db;
        public PurchaseRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddPurchase(Purchase purchase)
        {
            db.Purchases.Add(purchase);
            int res = db.SaveChanges();
            return res;
        }

        public int DeletePurchase(int id)
        {
            int res = 0;
            var emp = db.Purchases.Find(id);
            if (emp != null)
            {
                db.Purchases.Remove(emp);
                res = db.SaveChanges();
            }
            return res;
        }

       
        public Purchase GetPurchaseById(int id)
        {
            var emp = db.Purchases.Find(id);
            return emp;
        }
        public IEnumerable<Purchase> GetAllPurchases()
        {
            return db.Purchases.ToList();
        }

        public int UpdatePurchase(Purchase purchase)
        {
            int res = 0;
            var p = db.Purchases.Where(x => x.PId == purchase.PId).FirstOrDefault();
            if (p != null)
            {
                db.Purchases.Update(purchase);

                res = db.SaveChanges();
            }
            return res;
        }

    }
}
