using System;
using System.Collections.Generic;
using System.Linq;
using TSport.Models;
using TSport.Models.Data;

namespace TSport.Services.ColorService
{
    public class ColorService : IColorService
    {
        private readonly TSportDbContext _db;

        public ColorService(TSportDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Color> Add(Color model)
        {
            try
            {
                _db.Colors.Add(model);
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
                var color = Get(id);
                if (color != null)
                {
                    _db.Colors.Remove(color);
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

        public Color Get(int id)
        {
            return _db.Colors.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Color> GetAll()
        {
            return _db.Colors.ToList();
        }

        public IEnumerable<Color> Update(Color model)
        {
            try
            {
                _db.Colors.Update(model);
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
