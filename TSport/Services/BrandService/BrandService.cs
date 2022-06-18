using System;
using System.Collections.Generic;
using System.Linq;
using TSport.Models;
using TSport.Models.Data;

namespace TSport.Services.BrandService
{
    public class BrandService : IBrandService
    {
        private readonly TSportDbContext _db;

        public BrandService(TSportDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Brand> Add(Brand model)
        {
            try
            {
                _db.Brands.Add(model);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return GetAll();
        }

        public bool Delete(int id)
        {
            try
            {
                var brand = Get(id);
                if (brand != null)
                {
                    _db.Brands.Remove(brand);
                    _db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public Brand Get(int id)
        {
            return _db.Brands.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Brand> GetAll()
        {
            return _db.Brands.ToList();
        }

        public IEnumerable<Brand> Update(Brand model)
        {
            try
            {
                _db.Brands.Update(model);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return GetAll();
        }
    }
}
