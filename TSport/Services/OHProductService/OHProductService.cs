using System;
using System.Collections.Generic;
using System.Linq;
using TSport.Models;
using TSport.Models.Data;

namespace TSport.Services.OHProductService
{
    public class OHProductService : IOHProductService
    {
        private readonly TSportDbContext _db;

        public OHProductService(TSportDbContext db)
        {
            _db = db;
        }
        public IEnumerable<OHProduct> Add(OHProduct model)
        {
            try
            {
                _db.OHProducts.Add(model);
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
                var oHProduct = Get(id);
                if (oHProduct != null)
                {
                    _db.OHProducts.Remove(oHProduct);
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

        public OHProduct Get(int id)
        {
            return _db.OHProducts.FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<OHProduct> GetAll()
        {
            return _db.OHProducts.ToList();
        }

        public IEnumerable<OHProduct> Update(OHProduct model)
        {
            try
            {
                _db.OHProducts.Update(model);
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
