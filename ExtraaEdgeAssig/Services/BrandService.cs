using ExtraaEdgeAssig.Models;
using ExtraaEdgeAssig.Repositories;

namespace ExtraaEdgeAssig.Services
{
    public class BrandService: IBrandService
    {
        private readonly IBrandRepository _repo;

        public BrandService(IBrandRepository repo)
        {
           _repo = repo;
        }
        public int AddBrand(Brand brand)
        {
            return _repo.AddBrand(brand);
        }
        
        public int DeleteBrand(int id)
        {
            return _repo.DeleteBrand(id);
        }
        
        
        public IEnumerable<Brand> GetAllBrands() 
        {
            return _repo.GetAllBrands();
        }
        public Brand GetBrandById(int id)
        {
            return _repo.GetBrandById(id);
        }
        public int UpdateBrand(Brand brand)
        {
            return _repo.UpdateBrand(brand);
        }
    }

}
