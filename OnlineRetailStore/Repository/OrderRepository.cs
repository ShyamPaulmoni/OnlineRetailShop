using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineRetailStore.Models;
using OnlineRetailStore.Repository.Interfaces;

namespace OnlineRetailStore.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DbContext _dbContext;

        public OrderRepository(DbContext dbContext){

            _dbContext = dbContext;
        }

        public void Add(Order order)
        {
            _dbContext.Add(order);
            _dbContext.SaveChanges();
        }

        public void Delete(Order order)
        {
            _dbContext.Remove(order);
            _dbContext.SaveChanges();
        }

        public Order Get(int id)
        {
            return _dbContext.Find<Order>(id);
        }

        public List<Order> GetAll()
        {
            return _dbContext.Set<Order>().ToList();
        }
    }
}
