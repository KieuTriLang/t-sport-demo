using System;
using System.Collections.Generic;
using System.Linq;
using TSport.Models;
using TSport.Models.Data;

namespace TSport.Services.OrderHistoryService
{
    public class OrderHistoryService : IOrderHistoryService
    {
        private readonly TSportDbContext _db;

        public OrderHistoryService(TSportDbContext db)
        {
            _db = db;
        }
        public IEnumerable<OrderHistory> Add(OrderHistory model)
        {
            try
            {
                _db.OrderHistories.Add(model);
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
                var orderHistory = Get(id);
                if (orderHistory != null)
                {
                    _db.OrderHistories.Remove(orderHistory);
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

        public OrderHistory Get(int id)
        {
            return _db.OrderHistories.FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<OrderHistory> GetAll()
        {
            return _db.OrderHistories.ToList();
        }

        public IEnumerable<OrderHistory> Update(OrderHistory model)
        {
            try
            {
                _db.OrderHistories.Update(model);
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
