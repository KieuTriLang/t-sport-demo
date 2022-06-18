using System;
using System.Collections.Generic;
using System.Linq;
using TSport.Models;
using TSport.Models.Data;

namespace TSport.Services.BlogService
{
    public class BlogService : IBlogService
    {
        private readonly TSportDbContext _db;

        public BlogService(TSportDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Blog> Add(Blog model)
        {
            try
            {
                _db.Blogs.Add(model);
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
                var blog = Get(id);
                if (blog != null)
                {
                    _db.Blogs.Remove(blog);
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

        public Blog Get(int id)
        {
            return _db.Blogs.Where(b => b.Id == id).FirstOrDefault();
        }

        public IEnumerable<Blog> GetAll()
        {
            return _db.Blogs.ToList();
        }

        public IEnumerable<Blog> Update(Blog model)
        {
            try
            {
                _db.Blogs.Update(model);
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
