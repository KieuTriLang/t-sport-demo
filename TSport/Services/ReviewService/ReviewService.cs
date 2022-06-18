using System;
using System.Collections.Generic;
using System.Linq;
using TSport.Models;
using TSport.Models.Data;

namespace TSport.Services.ReviewService
{
    public class ReviewService : IReviewService
    {
        private readonly TSportDbContext _db;

        public ReviewService(TSportDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Review> Add(Review model)
        {
            try
            {
                _db.Reviews.Add(model);
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
                var review = Get(id);
                if (review != null)
                {
                    _db.Reviews.Remove(review);
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

        public Review Get(int id)
        {
            return _db.Reviews.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Review> GetAll()
        {
            return _db.Reviews.ToList();
        }

        public IEnumerable<Review> Update(Review model)
        {
            try
            {
                _db.Reviews.Update(model);
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
