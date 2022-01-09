using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OnlineRetailStore.Models;
using OnlineRetailStore.Repository.Interfaces;

namespace OnlineRetailStore.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContext _dbContext;

        public ProductRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Add(Product product)
        {
            _dbContext.Add(product);
            _dbContext.SaveChanges();
        }

        public void Update(Product product)
        {
            _dbContext.Update(product);
            _dbContext.SaveChanges();
        }

        public void Delete(Product product)
        {
            _dbContext.Remove(product);
            _dbContext.SaveChanges();
        }

        Product IProductRepository.Get(int id)
        {
            return _dbContext.Find<Product>(id);
        }

        List<Product> IProductRepository.GetAll()
        {
            return _dbContext.Set<Product>().ToList();
        }
    }
}
