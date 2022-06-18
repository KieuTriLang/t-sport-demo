using System;
using System.Collections.Generic;
using System.Linq;
using TSport.Models;
using TSport.Models.Data;

namespace TSport.Services.ColorProductService
{
    public class ColorProductService : IColorProductService
    {
        private readonly TSportDbContext _db;

        public ColorProductService(TSportDbContext db)
        {
            _db = db;
        }
        public IEnumerable<ColorProduct> Add(ColorProduct model)
        {
            try
            {
                _db.ColorProducts.Add(model);
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
                var cp = Get(id);
                if (cp != null)
                {
                    _db.ColorProducts.Remove(cp);
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

        public ColorProduct Get(int id)
        {
            return _db.ColorProducts.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<ColorProduct> GetAll()
        {
            return _db.ColorProducts.ToList();
        }

        public IEnumerable<ColorProduct> Update(ColorProduct model)
        {
            try
            {
                _db.ColorProducts.Update(model);
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
