using System;
using System.Collections.Generic;
using System.Linq;
using TSport.Models;
using TSport.Models.Data;

namespace TSport.Services.SizeService
{
    public class SizeService : ISizeService
    {
        private readonly TSportDbContext _db;

        public SizeService(TSportDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Size> Add(Size model)
        {
            try
            {
                _db.Sizes.Add(model);
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
                var size = Get(id);
                if (size != null)
                {
                    _db.Sizes.Remove(size);
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

        public Size Get(int id)
        {
            return _db.Sizes.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Size> GetAll()
        {
            return _db.Sizes.ToList();
        }

        public IEnumerable<Size> Update(Size model)
        {
            try
            {
                _db.Sizes.Update(model);
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
