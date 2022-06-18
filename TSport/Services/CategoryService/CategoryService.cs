using System;
using System.Collections.Generic;
using System.Linq;
using TSport.Models;
using TSport.Models.Data;

namespace TSport.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly TSportDbContext _db;

        public CategoryService(TSportDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Category> Add(Category model)
        {
            try
            {
                _db.Categories.Add(model);
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
                var category = Get(id);
                if (category != null)
                {
                    _db.Categories.Remove(category);
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

        public Category Get(int id)
        {
            return _db.Categories.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _db.Categories.ToList();
        }

        public IEnumerable<Category> Update(Category model)
        {
            try
            {
                _db.Categories.Update(model);
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
