﻿using ExtraaEdgeAssig.Models;

namespace ExtraaEdgeAssig.Repositories
{
    public interface IBrandRepository
    {
        IEnumerable<Brand> GetAllBrands();
        Brand GetBrandById(int id);
        int AddBrand(Brand brand);
        int UpdateBrand(Brand brand);
        int DeleteBrand(int id);
    }
}
