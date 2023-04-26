using ExtraaEdgeAssig.Data;
using ExtraaEdgeAssig.Models;

namespace ExtraaEdgeAssig.Repositories
{
    public class BrandRepository: IBrandRepository
    {
        private readonly ApplicationDbContext _db;
        public BrandRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public int AddBrand(Brand brand)
        {
            _db.Brands.Add(brand);
            int res = _db.SaveChanges();
            return res;
        }

        public int DeleteBrand(int id)
        {
            int res = 0;
            var brand = _db.Brands.Find(id);
            if (brand != null)
            {
                _db.Brands.Remove(brand);
                res = _db.SaveChanges();
            }
            return res;
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            return _db.Brands.ToList();
        }

        public Brand GetBrandById(int id)
        {
            var prod = _db.Brands.Find(id);
            return prod;
        }

        public int UpdateBrand(Brand brand)
        {
            int res = 0;
            var p = _db.Brands.Where(x => x.BId == brand.BId).FirstOrDefault();
            if (p != null)
            {
                _db.Brands.Update(brand);

                res = _db.SaveChanges();
            }
            return res;
        }

    }
}
