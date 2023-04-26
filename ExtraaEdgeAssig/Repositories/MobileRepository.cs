using ExtraaEdgeAssig.Data;
using ExtraaEdgeAssig.Models;

namespace ExtraaEdgeAssig.Repositories
{
    public class MobileRepository : IMobileRepository
    {
        private readonly ApplicationDbContext db;
        public MobileRepository(ApplicationDbContext db)
        {
            db = db;
        }
        public int AddMobile(Mobile mob)
        {
            db.Mobiles.Add(mob);
            int res = db.Mobiles.Count();
            return res;
        }

        public int DeleteMobile(int id)
        {
            int res = 0;
            var prod = db.Mobiles.Find(id);
            if (prod != null)
            {
               db.Mobiles.Remove(prod);
                res = db.SaveChanges();
            }
            return res;
        }

        

        public Mobile GetMobileById(int id)
        {
            var prod = db.Mobiles.Find(id);
            return prod;
        }
        public IEnumerable<Mobile> GetAllMobiles()
        {
            return db.Mobiles.ToList();
        }
        public int UpdateMobile(Mobile mob)
        {
            int res = 0;
            var p = db.Mobiles.Where(x => x.Id == mob.Id).FirstOrDefault();
            if (p != null)
            {
                db.Mobiles.Update(mob);

                res = db.SaveChanges();
            }
            return res;
        }

    }
}
