using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TSport.Models;
using TSport.Models.Data;

namespace TSport.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly TSportDbContext _db;

        public ProductService(TSportDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Product> Add(Product model)
        {
            try
            {
                _db.Products.Add(model);
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
                var product = Get(id);
                if (product != null)
                {
                    _db.Products.Remove(product);
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

        public Product Get(int id)
        {
            return _db.Products.Where(p => p.Id == id)
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .Include(p => p.Colors)
                .Include(p => p.Sizes)
                .Include(p => p.Images)
                .Include(p => p.Reviews)
                    .ThenInclude(r => r.User)
                .FirstOrDefault();
        }

        public IEnumerable<Product> GetAll()
        {
            return _db.Products
                .Include(p => p.Sizes)
                .Include(p => p.Images)
                .ToList();
        }

        public IEnumerable<Product> Update(Product model)
        {
            try
            {
                _db.Products.Update(model);
                _db.SaveChanges();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return GetAll();
        }
    }
}
