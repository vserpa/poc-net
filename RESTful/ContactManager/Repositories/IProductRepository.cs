using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        void Remove(Product product);
        Product GetById(Guid productId);
        Product GetByName(string name);
        ICollection<Product> GetByCategory(string category);
    }
}